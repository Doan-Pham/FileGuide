using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Diagnostics;

namespace FileGuide
{
    class ClsTreeListView
    {
        /// <summary>
        /// Function khởi tạo treeView 
        /// </summary>
        /// <param name="treeView"></param>
        public void CreateTreeView(TreeView treeView)
        {
            // Tạo các biến const thể hiện cho các thành phần của DriveType Enum - mỗi phần tử của enum thể hiện một loại ổ đĩa
            const int RemovableDisk = 2;
            const int LocalDisk = 3;
            const int NetworkDisk = 4;
            const int CDDisk = 5;

            // Tạo node đầu tiên là My Computer, đây sẽ là node gốc và thêm node gốc vào treeView
            TreeNode tnMyComputer = new TreeNode("My Computer", 0, 0);
            treeView.Nodes.Clear();
            treeView.Nodes.Add(tnMyComputer);

            // Lấy danh sách các ổ đĩa và đưa vào một collection rồi duyệt qua các ổ đĩa
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();

            foreach(ManagementObject mo in queryCollection)
            {
                int DiskImageIndex, DiskSelectIndex;

                // Gán các image index ứng với từng loại ổ đĩa
                switch (int.Parse(mo["DriveType"].ToString()))
                {
                    case RemovableDisk:
                        {
                            DiskImageIndex = 1;
                            DiskSelectIndex = 1;
                        }
                        break;

                    case LocalDisk:
                        {
                            DiskImageIndex = 2;
                            DiskSelectIndex = 2;
                        }
                        break;

                    case CDDisk:
                        {
                            DiskImageIndex = 3;
                            DiskSelectIndex = 3;
                        }
                        break;

                    case NetworkDisk:
                        {
                            DiskImageIndex = 4;
                            DiskSelectIndex = 4;
                        }
                        break;

                    default:
                        {
                            DiskImageIndex = 5;
                            DiskSelectIndex = 6;
                        }
                        break;

                }

                // Tạo một treenode cho từng ổ đĩa rồi thêm vào node collection của node gốc - My Computer
                TreeNode diskTreeNode = new TreeNode(mo["Name"].ToString() + "\\", DiskImageIndex, DiskSelectIndex);
                tnMyComputer.Nodes.Add(diskTreeNode);
            }
        }


        /// <summary>
        /// Function hiển thị cây thư mục lên treeview
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="currentNode"></param>
        /// <returns></returns>
        public bool ShowFolderTree(TreeView treeView, ListView listView, TreeNode currentNode)
        {
            // Phải xét xem current node có phải My Computer không, bởi vốn dĩ node My Computer đã được tạo (với các node con là các ổ đĩa) trong hàm CreateTreeView, xét lại sẽ gây lỗi
            if (currentNode.Text != "My Computer")
            {
                try
                {
                    if (!Directory.Exists(GetApproriatePath(currentNode.FullPath)))
                    {
                        MessageBox.Show("Directory not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        // Thêm tất cả directory con của node hiện tại vào treeView
                        string[] strDirectories = Directory.GetDirectories(GetApproriatePath(currentNode.FullPath));

                        foreach (string stringDir in strDirectories)
                        {
                            string strName = GetFileFolderName(stringDir);
                            TreeNode nodeDir = new TreeNode(strName, 5, 6);
                            currentNode.Nodes.Add(nodeDir);
                        }

                        // Ánh xạ nội dung của thư mục hiện tại lên listView
                        ShowListView(listView, currentNode);
                    }
                    return true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Directory does not exist","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You might not have permission to access this directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }         
            }
            return false;
        }


        /// <summary>
        /// Function hiển thị nội dung của thư mục lên listView
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="currentNode"></param>
        public void ShowListView(ListView listView, TreeNode currentNode)
        {
            try
            {
                // Dọn listView để chừa chỗ hiển thị nội dung
                listView.Items.Clear();

                // Lấy DirectoryInfo từ node, xét xem directory có tồn tại không, nếu có thì thêm các file, directory con vào listView
                ListViewItem item;
                DirectoryInfo directory = GetDirectoryInfoFromNode(currentNode);
                if (!directory.Exists)
                {
                    MessageBox.Show("Folder does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DirectoryInfo folder in directory.GetDirectories())
                {
                    item = GetListViewItem(folder);
                    listView.Items.Add(item);
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    item = GetListViewItem(file);
                    listView.Items.Add(item);
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// Function hiển thị nội dung của thư mục lên listView
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="strPath"></param>
        public void ShowListView(ListView listView, string strPath)
        {
            try
            {
                //if (!strPath.EndsWith("\\")) strPath += "\\";
                ListViewItem item;
                DirectoryInfo directory = new DirectoryInfo(strPath);
                listView.Items.Clear();
                foreach (DirectoryInfo folder in directory.GetDirectories())
                {
                    item = GetListViewItem(folder);
                    listView.Items.Add(item);
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    item = GetListViewItem(file);
                    listView.Items.Add(item);
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        /// <summary>
        /// Function xử lý item: thực thi nếu là file, mở ra nếu là folder
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="CurrentItem"></param>
        /// <returns></returns>
        public bool ClickItem(ListView listView, ListViewItem CurrentItem)
        {
            try
            {
                string path = CurrentItem.SubItems[4].Text;
                FileInfo fi = new FileInfo(path);

                // Nếu item được chọn là file thì, nếu là folder thì mở ra
                if (fi.Exists)
                {
                    Process.Start(path);
                }
                else
                {
                    ShowListView(listView, path);  
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return false;
        }

        public void DeleteItem(ListView listView, ListViewItem item)
        {
            try
            {
                string path = item.SubItems[4].Text;

                if (item.SubItems[1].Text == "Folder")
                {
                    DirectoryInfo directory = new DirectoryInfo(path);
                    if (!directory.Exists)
                    {
                        MessageBox.Show("Folder might not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else 
                    {
                        DialogResult dialog = MessageBox.Show("Are you sure you want to delete this folder ? \n" + item.Text.ToString(), "Delete folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dialog == DialogResult.Yes)
                        {
                            directory.Delete(true);
                        }
                        else return;

                        string pathFolder = GetParentDirectoryPath(path);
                        ShowListView(listView, pathFolder);
                    }
                }
                else 
                {
                    FileInfo file = new FileInfo(path);
                    if (!file.Exists)
                    {
                        MessageBox.Show("File might not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else 
                    {
                        DialogResult dialog = MessageBox.Show("Are you sure you want to delete this file ? \n" + item.Text.ToString(), "Delete file", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dialog == DialogResult.Yes)
                        {
                            file.Delete();
                        }
                        else return;

                        string pathFolder = GetParentDirectoryPath(path);
                        ShowListView(listView, pathFolder);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Function bổ trợ tạo ListViewItem từ folder. 
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public ListViewItem GetListViewItem(DirectoryInfo folder)
        {
            string[] item = new string[5];
            item[0] = folder.Name;
            item[1] = "Folder";
            item[2] = folder.CreationTime.ToString();
            item[3] = folder.LastWriteTime.ToString();
            item[4] = folder.FullName;

            ListViewItem newItem = new ListViewItem(item);
            newItem.ImageIndex = 4;
            return newItem;
        }


        /// <summary>
        /// Function bổ trợ tạo ListViewItem từ file. 
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public ListViewItem GetListViewItem(FileInfo file)
        {
            string[] item = new string[5];
            item[0] = file.Name;
            item[1] = (file.Length/1024).ToString() + " KB";
            item[2] = file.CreationTime.ToString();
            item[3] = file.LastWriteTime.ToString();
            item[4] = file.FullName;

            ListViewItem newItem = new ListViewItem(item);
            newItem.ImageIndex = GetImageIndex(file);
            return newItem;
        }

        
        /// <summary>
        /// Function bổ trợ sửa path cho phù hợp với việc xử lý và hiển thị
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public string GetApproriatePath(string strPath)
        {
            return strPath.Replace("My Computer\\", "").Replace("\\\\", "\\");
        }


        /// <summary>
        /// Function bổ trợ lấy tên file/directory (bỏ bớt các parent directory trong đường dẫn
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public string GetFileFolderName(string strPath)
        {
            string[] strSplit = strPath.Split('\\');
            return strSplit[strSplit.Length - 1];
        }


        /// <summary>
        /// Function bổ trợ tạo DirectoryInfo từ một node trong treeView
        /// </summary>
        /// <param name="currentNode"></param>
        /// <returns></returns>
        public DirectoryInfo GetDirectoryInfoFromNode(TreeNode currentNode)
        {
            string[] strList = currentNode.FullPath.Split('\\');
            string strPath = strList.GetValue(1).ToString();
            for (int i = 2; i < strList.Length; i++)
            {
                strPath += strList.GetValue(i) + "\\";
            }
            return new DirectoryInfo(strPath);
        }


        /// <summary>
        /// Function bổ trợ lấy index image ứng với extension của file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public int GetImageIndex(FileInfo file)
        {
            switch(file.Extension.ToUpper())
            {
                case ".MDB":
                    return 0;

                case ".DOC":
                case ".DOCX":
                    return 1;

                case ".EXE":
                    return 2;

                case ".HTM":
                case ".HTML":
                    return 5;

                case ".MP3":
                case ".WAV":
                case ".WMV":
                case ".ASF":
                case ".MPEG":
                case ".AVI":
                    return 6;

                case ".PDF":
                    return 7;

                case ".JPG":
                case ".PNG":
                case ".BMP":
                case ".GIF":
                    return 8;

                case ".PPT":
                case ".PPTX":
                    return 9;

                case ".RAR":
                case ".ZIP":
                    return 10;

                case ".SWF":
                case ".FLV":
                case ".FLA":
                    return 11;

                case ".TXT":
                case ".DIZ":
                case ".LOG":
                    return 12;

                case ".XLS":
                case ".XLSX":
                    return 13;

                default:
                    return 3;

            }
        }

        public string GetParentDirectoryPath(string path)
        {
            string[] strList = path.Split('\\');
            string strPath = strList.GetValue(0).ToString();
            for (int i = 1; i < strList.Length - 1; i++)
            {
                strPath += "\\" + strList.GetValue(i);
            }
            return strPath;
        }
    }
}

