using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Diagnostics;

namespace WindowExplorer
{
    class ClsTreeListView
    {
        /// <summary>
        /// Function tạo treeview - được thể hiện bằng 1 CTDL TreeNode trong code
        /// </summary>
        /// <param name="treeView"></param>
        public void CreateTreeView(TreeView treeView)
        {
            TreeNode tnMyComputer;

            // Tạo node đầu tiên là My Computer, đây sẽ là node gốc
            tnMyComputer = new TreeNode("My Computer", 0, 0);

            // Thêm node gốc vào treeview
            treeView.Nodes.Clear();
            treeView.Nodes.Add(tnMyComputer);

            // Tập hợp các node của tnMyComputer
            TreeNodeCollection nodeCollection = tnMyComputer.Nodes;

            // Lấy danh sách các ổ đĩa
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();

            foreach(ManagementObject mo in queryCollection)
            {
                TreeNode diskTreeNode;

                // Tạo một treenode cho từng ổ đĩa
                diskTreeNode = new TreeNode(mo["Name"].ToString() + "\\", 0, 0);

                // Thêm treenode ổ đĩa vào Treeview
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
                        // Lần lượt thêm tất cả các directory vào treenode
                        string[] strDirectories = Directory.GetDirectories(GetFullPath(currentNode.FullPath));

                        foreach (string stringDir in strDirectories)
                        {
                            string strName = GetName(stringDir);
                            TreeNode nodeDir;
                            nodeDir = new TreeNode(strName, 5, 6);
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
