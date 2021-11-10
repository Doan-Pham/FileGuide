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
using System.Diagnostics;
namespace FileGuide
{
    public partial class FrmMain : Form
    {
        private bool isCopying = false;
        private bool isCutting = false;
        private bool isRenaming = false;
        private bool isFolder = false;
        private bool isListView = false;
        private ListViewItem itemPaste;
        private string pathSource;
        private string pathDest;
        private string pathNode;
        private string currentPath;

        private ClsTreeListView clsTreeListView = new ClsTreeListView();
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create treeView and set min width for toolStrip path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            clsTreeListView.CreateTreeView(this.treeView);
            if (this.Width > 400)
                tscmbPath.Width = this.Width - 300;
        }

        /// <summary>
        /// Load folder tree onto treeView
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
        /// Run if a file, show content if a folder
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

        /// <summary>
        /// Run if a file, show content if a folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Go to the path on toolStrip Path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscmbPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {    
                try
                {
                    if (tscmbPath.Text != "")
                    {
                        // If path points to a file, process that file
                        if (File.Exists(tscmbPath.Text.Trim()))
                        {
                            FileInfo file = new FileInfo(tscmbPath.Text.Trim());
                            Process.Start(tscmbPath.Text.Trim());
                            DirectoryInfo parent = file.Directory;
                            tscmbPath.Text = parent.FullName;
                            
                        }

                        // If path points to a folder, open that folder
                        else if (Directory.Exists(tscmbPath.Text.Trim()))
                        {
                            clsTreeListView.ShowListView(this.listView, tscmbPath.Text) ;
                            currentPath = tscmbPath.Text;
                        }

                        // If path doesn't exist, show error message
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
            // Set min width for toolStrip Path when resize form
            if (this.Width > 400)
            tscmbPath.Width = this.Width - 300;
        }

        /// <summary>
        /// Copy item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCopy_Click(object sender, EventArgs e)
        {
            // Set isCopying to true so events for Paste feature know whether to cut paste or copy paste
            isCopying = true;

            // If listView is focused, assign item's path to a variable and enable Paste feature
            if (listView.Focused)
            {
                isListView = true;
                itemPaste = listView.FocusedItem;

                if (itemPaste == null)
                    return;

                pathSource = itemPaste.SubItems[4].Text;
                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                {
                    isFolder = true;
                    
                }
                else
                {
                    isFolder = false;
                }
            }
            else if (treeView.Focused)
            {
                pathSource = pathNode;
                isListView = false;
                isFolder = true;
            };

            menuPaste.Enabled = true;
            tsbtnPaste.Enabled = true;
        }

        /// <summary>
        /// Cut item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCut_Click(object sender, EventArgs e)
        {
            // The same as menuCopy_Click event but set isCutting to true and isCopying to false
            menuCopy_Click(sender, e);
            isCopying = false;
            isCutting = true;
        }

        /// <summary>
        /// Paste item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuPaste_Click(object sender, EventArgs e)
        {
            try 
            {
                // pathSource and pathDest respectively indicate item-needed-to-copy-cut's path and destination directory's path 
                if (isFolder)
                {
                    pathDest = currentPath;
                }
                else 
                {
                    pathDest = currentPath + "\\" + itemPaste.Text;
                }
               
                // If user is doing copy-paste, copy item to destination
                if (isCopying)
                {
                    if (isFolder)
                    {                 
                        Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(pathSource, pathDest + "\\" + clsTreeListView.GetFileFolderName(pathSource));
                    }
                    else 
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(pathSource, pathDest);
                    }
                    isCopying = false;
                }

                // If user is doing cut-paste, move item to new destination
                if (isCutting)
                {
                    if (isFolder)
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.MoveDirectory(pathSource, pathDest + "\\" + clsTreeListView.GetFileFolderName(pathSource));
                    }
                    else
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(pathSource, pathDest);
                    }
                    isCutting = false;
                }

                // After pasting, refresh listView and disable paste feature
                string strPath;
                if (!isFolder) strPath = clsTreeListView.GetParentDirectoryPath(pathDest);
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

        /// <summary>
        /// Delete item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDelete_Click(object sender, EventArgs e)
        {
            try 
            {
                if (listView.Focused)
                {
                    clsTreeListView.DeleteItem(listView, listView.FocusedItem);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Rename item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuRename_Click(object sender, EventArgs e)
        {
            isRenaming = true;
            listView.SelectedItems[0].BeginEdit();
        }

        private void listView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try 
            {
                if (isRenaming)
                {
                    string path = listView.FocusedItem.SubItems[4].Text;
                    if (e.Label == null) return;
                    FileInfo fi = new FileInfo(path);

                    //Rename item then refresh listView
                    if (fi.Exists)
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(path, e.Label);
                    }
                    else 
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(path, e.Label);
                    }
                    clsTreeListView.ShowListView(listView, clsTreeListView.GetParentDirectoryPath(path));
                    e.CancelEdit = true;
                    isRenaming = false;
                }
            }
            catch(IOException)
            {
                MessageBox.Show("File or Folder already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Go back to parent directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            try
            { 
                if (currentPath != "" && currentPath != "My Computer")
                {
                    currentPath = clsTreeListView.GetParentDirectoryPath(currentPath);
                    tscmbPath.Text = currentPath;
                    clsTreeListView.ShowListView(listView, currentPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Refresh listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            if (currentPath != "" && currentPath != "My Computer" )
                clsTreeListView.ShowListView(listView, currentPath);
        }

        /// <summary>
        /// Set listView display to large icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLarge_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
        }

        /// <summary>
        /// Set listView display to small icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSmall_Click(object sender, EventArgs e)
        {
            listView.View = View.SmallIcon;
        }

        /// <summary>
        /// Set listView display to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuList_Click(object sender, EventArgs e)
        {
            listView.View = View.List;
        }

        /// <summary>
        /// Set listView display to details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDetails_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;
        }

        /// <summary>
        /// Show number of items in current directory on status strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscmbPath_TextChanged(object sender, EventArgs e)
        {
            statusLblItemNum.Text = listView.Items.Count.ToString() + " items";
        }

        /// <summary>
        /// Show number of selected listView items on status strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            statusLblNumSelect.Text = listView.SelectedItems.Count.ToString() + " items selected";
        }
    }
}
