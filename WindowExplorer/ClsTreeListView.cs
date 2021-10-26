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
        public void CreateTreeView(TreeView treeView)
        {
            TreeNode tnMyComputer;

            // Tạo node mới
            tnMyComputer = new TreeNode("My Computer", 0, 0);

            // Xóa TreeView
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
        public string GetFullPath(string strPath)
        {
            return strPath.Replace("My Computer\\", "").Replace("\\\\", "\\");
        }
        public string GetName(string strPath)
        {
            string[] strSplit = strPath.Split('\\');
            return strSplit[strSplit.Length - 1];
        }

    }
}
