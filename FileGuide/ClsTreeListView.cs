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
        public bool ShowFolderTree(TreeView treeView, TreeNode currentNode)
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
    }
}
