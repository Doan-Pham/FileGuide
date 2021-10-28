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
        /// Function tạo treeview 
        /// </summary>
        /// <param name="treeView"></param>
        public void CreateTreeView(TreeView treeView)
        {
            // Tạo các biến const thể hiện cho các thành phần của DriveType Enum - mỗi phần tử của enum thể hiện một loại ổ đĩa
            const int RemovableDisk = 2;
            const int LocalDisk = 3;
            const int NetworkDisk = 4;
            const int CDDisk = 5;


            // Tạo node đầu tiên là My Computer, đây sẽ là node gốc
            TreeNode tnMyComputer = new TreeNode("My Computer", 0, 0);

            // Thêm node gốc vào treeview
            treeView.Nodes.Clear();
            treeView.Nodes.Add(tnMyComputer);

            // Tập hợp các node của tnMyComputer
            TreeNodeCollection nodeCollection = tnMyComputer.Nodes;

            // Lấy danh sách các ổ đĩa và đưu vào một queryCollection
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();

            foreach(ManagementObject mo in queryCollection)
            {

                // Ứng mỗi loại ổ đĩa, gán imageIndex và selectIndex với index của các icon tương ứng
                int imageIndex, selectIndex;
                switch(int.Parse(mo["DriveType"].ToString()))
                {
                    case RemovableDisk:
                        {
                            imageIndex = 1;
                            selectIndex = 1;
                        }
                        break;

                    case LocalDisk:
                        {
                            imageIndex = 2;
                            selectIndex = 2;
                        }
                        break;

                    case CDDisk:
                        {
                            imageIndex = 3;
                            selectIndex = 3;
                        }
                        break;

                    case NetworkDisk:
                        {
                            imageIndex = 4;
                            selectIndex = 4;
                        }
                        break;

                    default:
                        {
                            imageIndex = 5;
                            selectIndex = 6;
                        }
                        break;

                }
                // Tạo một treenode cho từng ổ đĩa
                TreeNode diskTreeNode = new TreeNode(mo["Name"].ToString() + "\\", imageIndex, selectIndex);

                // Thêm treenode ổ đĩa vào node collection của My Computer
                nodeCollection.Add(diskTreeNode);
            }
        }


        /// <summary>
        /// Function show cây thư mục lên treeview
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="currentNode"></param>
        /// <returns></returns>
        public bool ShowFolderTree(TreeView treeView, ListView listView, TreeNode currentNode)
        {
            if (currentNode.Text != "My Computer")
            {
                try
                {
                    if (Directory.Exists(GetFullPath(currentNode.FullPath)) == false)
                    {
                        MessageBox.Show("Ổ đĩa hoặc thư mục không tồn tại.");
                        return false;
                    }
                    else
                    {
                        // Thêm tất cả directory vào treeView
                        string[] strDirectories = Directory.GetDirectories(GetFullPath(currentNode.FullPath));

                        foreach (string stringDir in strDirectories)
                        {
                            string strName = GetName(stringDir);
                            TreeNode nodeDir = new TreeNode(strName, 5, 6);
                            currentNode.Nodes.Add(nodeDir);
                        }

                        // Ánh xạ nội dung của thư mục hiện tại lên listView
                        ShowContent(listView, currentNode);
                    }
                    return true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Ổ đĩa hoặc thư mục không tồn tại.");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào ổ đĩa hoặc thư mục này");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }         
            }
            return false;
        }

        public void ShowContent(ListView listView, TreeNode currentNode)
        {
            try
            {
                listView.Items.Clear();

                ListViewItem item;
                DirectoryInfo directory = GetPathDir(currentNode);

                foreach (DirectoryInfo folder in directory.GetDirectories())
                {
                    item = GetLVItem(folder);
                    listView.Items.Add(item);
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    item = GetLVItem(file);
                    listView.Items.Add(item);
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// Hàm bổ trợ tạo ListViewItem từ folder. 
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public ListViewItem GetLVItem(DirectoryInfo folder)
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
        /// Hàm bổ trợ tạo ListViewItem từ file. 
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public ListViewItem GetLVItem(FileInfo file)
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
        /// Function bổ trợ đế lấy full path của một địa chỉ
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public string GetFullPath(string strPath)
        {
            return strPath.Replace("My Computer\\", "").Replace("\\\\", "\\");
        }

        /// <summary>
        /// Function bổ trợ để lấy tên file/directory (bỏ bớt đường dẫn)
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public string GetName(string strPath)
        {
            string[] strSplit = strPath.Split('\\');
            return strSplit[strSplit.Length - 1];
        }

        public DirectoryInfo GetPathDir(TreeNode currentNode)
        {
            string[] strList = currentNode.FullPath.Split('\\');
            string strPath = strList.GetValue(1).ToString();
            for (int i = 2; i < strList.Length; i++)
            {
                strPath += strList.GetValue(i) + "\\";
            }
            return new DirectoryInfo(strPath);
        }

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
    }
}

