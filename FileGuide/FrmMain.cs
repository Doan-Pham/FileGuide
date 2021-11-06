using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FileGuide
{
    public partial class FrmMain : Form
    {
        private bool isCopying = false;
        private bool isCutting = false;
        private bool isFolder = false;
        private bool isListView = false;
        private ListViewItem itemPaste;
        private string pathFolder;
        private string pathFile;
        private string pathNode;
        private string currentPath;

        private ClsTreeListView clsTreeListView = new ClsTreeListView();
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khi load form, tạo treeview và listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            clsTreeListView.CreateTreeView(this.treeView);
            if (this.Width > 400)
                tscmbPath.Width = this.Width - 150;
        }

        /// <summary>
        /// Load cây thư mục vào treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currentNode = e.Node;
               clsTreeListView.ShowFolderTree(this.treeView,this.listView, currentNode);
            tscmbPath.Text = clsTreeListView.GetApproriatePath(currentNode.FullPath);
            pathNode = tscmbPath.Text;
            currentPath = pathNode;
        }

        /// <summary>
        /// Khi click vào một listView item, thực thi nếu là file, hiển thị nếu là folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listView.FocusedItem;

            if(clsTreeListView.ClickItem(this.listView, item))
            { 
                // Nếu item là folder thì hiển thị path lên tsPath
                if (item.SubItems[1].Text == "Folder")
                { 
                tscmbPath.Text = clsTreeListView.GetApproriatePath(item.SubItems[4].Text);
                currentPath = tscmbPath.Text;
                }
            }
        }
        private void listView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ListViewItem item = this.listView.FocusedItem;
                if (clsTreeListView.ClickItem(this.listView, item))
                {
                    // Nếu item là folder thì hiển thị path lên tsPath
                    if (item.SubItems[1].Text == "Folder")
                    { 
                        tscmbPath.Text = clsTreeListView.GetApproriatePath(item.SubItems[4].Text);
                        currentPath = tscmbPath.Text;
                    }
                }
            }
        }

        /// <summary>
        /// Đi đến đường dẫn trên tsPath, thực thi nếu là file, show content nếu là folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscmbPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {    
                try
                {
                    // Chỉ xử lý khi đường dẫn không trống
                    if (tscmbPath.Text != "")
                    {
                        // Nếu đường dẫn trỏ đến file thì thực thi file
                        if (File.Exists(tscmbPath.Text.Trim()))
                        {
                            FileInfo file = new FileInfo(tscmbPath.Text.Trim());
                            System.Diagnostics.Process.Start(tscmbPath.Text.Trim());
                            DirectoryInfo parent = file.Directory;
                            tscmbPath.Text = parent.FullName;
                            
                        }

                        // Nếu đường dẫn trỏ đến folder thì hiện nội dung folder lên listView
                        else if (Directory.Exists(tscmbPath.Text.Trim()))
                        {
                            clsTreeListView.ShowListView(this.listView, tscmbPath.Text) ;
                            currentPath = tscmbPath.Text;
                        }

                        // Nếu đường dẫn không tồn tại thì báo lỗi
                        else
                        {
                            MessageBox.Show("File/Folder not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.Width > 400)
            tscmbPath.Width = this.Width - 150;
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            isCopying = true;
            if (listView.Focused)
            {
                isListView = true;

                itemPaste = listView.FocusedItem;

                if (itemPaste == null)
                    return;

                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                {
                    isFolder = true;
                    pathFolder = clsTreeListView.GetApproriatePath(itemPaste.SubItems[4].Text + "\\");
                }
                else
                {
                    isFolder = false;
                    pathFile = clsTreeListView.GetApproriatePath(itemPaste.SubItems[4].Text);
                }
            }
            else if (treeView.Focused)
            {
                isListView = false;
                isFolder = true;
            };

            menuPaste.Enabled = true;
            tsbtnPaste.Enabled = true;
        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            isCutting = true;
            if (listView.Focused)
            {
                isListView = true;

                itemPaste = listView.FocusedItem;

                if (itemPaste == null)
                    return;

                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                {
                    isFolder = true;
                    pathFolder = itemPaste.SubItems[4].Text + "\\";
                }
                else
                {
                    isFolder = false;
                    pathFile = itemPaste.SubItems[4].Text;
                }
            }
            else if (treeView.Focused)
            {
                isListView = false;
                isFolder = true;
            };

            menuPaste.Enabled = true;
            tsbtnPaste.Enabled = true;
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            try 
            {
                string pathSource, pathDest;
                if (isListView)
                {
                    if (isFolder)
                    {
                        pathSource = pathFolder;
                        pathDest = currentPath;
                    }
                    else
                    {
                        pathSource = pathFile;
                        pathDest = currentPath + "\\" + itemPaste.Text;

                    }
                }
                else 
                {
                    pathSource = pathNode;
                    pathDest = currentPath;
                }

                if (isCopying)
                {
                    if (isFolder)
                    {                 
                        Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(pathSource, pathDest);
                    }
                    else 
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(pathSource, pathDest);
                    }
                    isCopying = false;
                }

                if (isCutting)
                {
                    if (isFolder)
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.MoveDirectory(pathSource, pathDest);
                    }
                    else
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(pathSource, pathDest);
                    }
                    isCutting = false;
                }

                string strPath;
                if (!isFolder)
                    strPath = clsTreeListView.GetDirectoryPathFromFilePath(pathDest);
                else strPath = pathDest;

                clsTreeListView.ShowListView(listView, strPath);

                menuPaste.Enabled = false;
                tsbtnPaste.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
