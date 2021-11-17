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
using System.Reflection;

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
        private Color HoverColor = Color.FromArgb(229, 243, 255);
        private Color UnfocusedSelectColor = Color.FromArgb(242, 242, 242);
        private Color FocusedSelectColor = Color.FromArgb(205, 232, 255);
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
        /// Create treeView,load list of recent files into first page and set min width for toolStrip path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            clsTreeListView.CreateTreeView(this.treeView);
            treeView.ExpandAll();

            string DebugDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string RecentDirectory = System.IO.Path.Combine(DebugDirectory, "RecentAccessesFiles");
            string RecentFilesTxt = System.IO.Path.Combine(RecentDirectory,"RecentAccessedFiles.txt");

            clsTreeListView.ListRecentFiles.AddRange(File.ReadAllLines(RecentFilesTxt));
            clsTreeListView.ShowListViewFirstPage(flowLayoutPanelDrives,listViewRecentFiles);

            if (this.Width > 400)
                tscmbPath.Width = this.Width - 300;
        }

        /// <summary>
        /// Load folder tree onto treeView and show listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currentNode = e.Node;
            clsTreeListView.ShowFolderTree(this.treeView, currentNode);
            if (currentNode.Text == "My Computer")
            {
                tableLayoutFirstPage.Visible = true;
                listView.Visible = false;
                clsTreeListView.ShowListViewFirstPage(flowLayoutPanelDrives, listViewRecentFiles);
            }
            else 
            {
                tableLayoutFirstPage.Visible = false;
                listView.Visible = true;
                clsTreeListView.ShowListView(this.listView, currentNode);
            }
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
            ListViewItem item = listView.FocusedItem;

            if(clsTreeListView.ClickItem(listView,listViewRecentFiles ,item, tscmbPath))
            { 
                //If item is a folder, show folder's path on tsPath
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
                ListViewItem item = listView.FocusedItem;
                if (clsTreeListView.ClickItem(listView, listViewRecentFiles, item, tscmbPath))
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

        /// <summary>
        /// Set min width for toolStrip Path when resize form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.Width > 400)
            tscmbPath.Width = this.Width - 300;
        }

        /// <summary>
        /// Copy item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
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
            pasteToolStripMenuItem.Enabled = true;
            tsbtnPaste.Enabled = true;
        }

        /// <summary>
        /// Cut item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCut_Click(object sender, EventArgs e)
        {
            // The same as btnCopy_Click event but set isCutting to true and isCopying to false
            btnCopy_Click(sender, e);
            isCopying = false;
            isCutting = true;
        }

        /// <summary>
        /// Paste item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPaste_Click(object sender, EventArgs e)
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

                pasteToolStripMenuItem.Enabled = true;
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
        private void btnDelete_Click(object sender, EventArgs e)
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
        /// Begin renaming item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuRename_Click(object sender, EventArgs e)
        {
            isRenaming = true;
            listView.SelectedItems[0].BeginEdit();
        }

        /// <summary>
        /// Renaming item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (currentPath != "")
                {
                    currentPath = clsTreeListView.GetParentDirectoryPath(currentPath);
                    if (currentPath != "My Computer")
                    {
                        tableLayoutFirstPage.Visible = false;
                        listView.Visible = true;
                        clsTreeListView.ShowListView(listView, currentPath);
                    }
                    else
                    {
                        tableLayoutFirstPage.Visible = true;
                        listView.Visible = false;
                        clsTreeListView.ShowListViewFirstPage(flowLayoutPanelDrives, listViewRecentFiles);
                    }
                    tscmbPath.Text = currentPath;
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
            listView.OwnerDraw = false;
            listView.View = View.LargeIcon;
        }

        /// <summary>
        /// Set listView display to small icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSmall_Click(object sender, EventArgs e)
        {
            listView.OwnerDraw = false;
            listView.View = View.SmallIcon;
        }

        /// <summary>
        /// Set listView display to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuList_Click(object sender, EventArgs e)
        {
            listView.OwnerDraw = false;
            listView.View = View.List;
        }

        /// <summary>
        /// Set listView display to details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDetails_Click(object sender, EventArgs e)
        {
            listView.OwnerDraw = true;
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

        /// <summary>
        /// Customize listView column headers to developer's need
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                using (var headerFont = new Font("Questrial", 10, FontStyle.Regular))
                {
                    RectangleF rect = new RectangleF(e.Bounds.X + 12, e.Bounds.Y, e.Bounds.Width - 24, e.Bounds.Height);
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Gray, rect, sf);
                }             
            }      
        }

        private void listView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Rectangle itemRect = e.Item.Bounds;
            Graphics g = e.Graphics;
            // Change item's background color when selected
            if (e.State == ListViewItemStates.Hot)
            {
                Brush hoverBrush = new SolidBrush(HoverColor);
                g.FillRectangle(hoverBrush, e.Bounds);
            }

            if (e.Item.Selected)
            {
                Brush selectBrush;
                if (e.Item.ListView.Focused)
                {
                    selectBrush = new SolidBrush(FocusedSelectColor);
                }
                else
                {
                    selectBrush = new SolidBrush(UnfocusedSelectColor);
                }
                g.FillRectangle(selectBrush, itemRect);
            }
        }

        private void listView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Rectangle itemRect = e.Item.Bounds;
            Graphics g = e.Graphics;
            if (e.Item.ListView.View == View.Details)
            {
                if (e.Item.SubItems[1].Text == "Folder")
                {
                    g.DrawImage(Properties.Resources.Folder, e.Item.Bounds.X + 20, e.Item.Bounds.Y, 30, 30);
                }
                else
                {
                    g.DrawImage(Properties.Resources.file, e.Item.Bounds.X + 20, e.Item.Bounds.Y, 30, 30);
                }

                TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis |
       TextFormatFlags.ExpandTabs | TextFormatFlags.SingleLine;

                Rectangle textRect;
                Color textColor;

                if (e.ColumnIndex == 0)
                {
                    textRect = new Rectangle(e.Bounds.X + 50, e.Bounds.Y, e.Bounds.Width - 50, e.Bounds.Height);
                    textColor = Color.Black;
                }
                else
                {
                    textRect = new Rectangle(e.Bounds.X + 20, e.Bounds.Y, e.Bounds.Width - 20, e.Bounds.Height);
                    textColor = Color.Gray;
                }


                TextRenderer.DrawText(g, e.SubItem.Text, e.Item.ListView.Font, textRect, textColor, flags);

            }
            else if (e.Item.ListView.View == View.LargeIcon)

            {
                if (e.Item.SubItems[1].Text == "Folder")
                {
                    g.DrawImage(Properties.Resources.Folder, e.Item.Bounds.X, e.Item.Bounds.Y, 25,25);
                }
                else
                {
                    g.DrawImage(Properties.Resources.file, e.Item.Bounds.X + 20, e.Item.Bounds.Y, 25, 25);
                }

                TextFormatFlags flags = TextFormatFlags.Bottom |TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis |
       TextFormatFlags.ExpandTabs | TextFormatFlags.SingleLine;

                Rectangle textRect = new Rectangle(e.Bounds.X , e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                TextRenderer.DrawText(g, e.SubItem.Text, e.Item.ListView.Font, textRect, Color.Black, flags);

            }
        }

        /// <summary>
        /// Customize treeView's design to developer's needs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // Reduce the unnecessary DrawNode calls. Without this, some icons are drawn in weird places
            if (e.Bounds.Height < 1 || e.Bounds.Width < 1) return;

            Rectangle nodeRect = e.Node.Bounds;
            Graphics g = e.Graphics;

            // Change node's background color on hovering
            if (e.State == TreeNodeStates.Hot)
            {
                Brush hoverBrush = new SolidBrush(HoverColor);
                g.FillRectangle(hoverBrush, e.Bounds);
            }

            // Change node's background color when selected
            if (e.Node.IsSelected)
            {
                Brush selectBrush;
                if (e.Node.TreeView.Focused)
                {
                    selectBrush = new SolidBrush(FocusedSelectColor);
                }
                else
                {
                    selectBrush = new SolidBrush(UnfocusedSelectColor);
                }
                g.FillRectangle(selectBrush, e.Bounds);
            }

            // Draw expand/collapse chevrons
            if (e.Node.Nodes.Count > 0)
            { 
                if (e.Node.IsExpanded)
                {
                    g.DrawImage(Properties.Resources.ExpandChevron, nodeRect.Location.X - 40, nodeRect.Location.Y + 16, 16, 16);
                }
                else
                {
                    g.DrawImage(Properties.Resources.NormalChevron, nodeRect.Location.X - 40, nodeRect.Location.Y + 16, 16, 16);
                }
            }

            //Draw node icon
            if (e.Node.Text == "My Computer")
            {
                g.DrawImage(Properties.Resources.MyComputer, nodeRect.Location.X - 14, nodeRect.Location.Y + 8, 30, 30);
            }
            else
            {
                g.DrawImage(Properties.Resources.Folder, nodeRect.Location.X - 14, nodeRect.Location.Y + 8, 30, 30);
            }

            //Draw text
            if (e.Node.Bounds.X != 0)
            { 
                TextRenderer.DrawText(g, e.Node.Text, ((TreeView)sender).Font,
                      new Point(nodeRect.Location.X + 20, nodeRect.Location.Y+8), Color.Black);
            }
        }

        private void treeView_MouseMove(object sender, MouseEventArgs e)
        {
            TreeNode HoveredNode = ((TreeView)sender).GetNodeAt(e.Location);
            if (HoveredNode != null)
            {
                Cursor = Cursors.Hand;
            }
            else 
            {
                Cursor = Cursors.Default;
            }
        }

        private void treeView_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string DebugDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string RecentDirectory = System.IO.Path.Combine(DebugDirectory, "RecentAccessesFiles");
            string RecentFilesTxt = System.IO.Path.Combine(RecentDirectory, "RecentAccessedFiles.txt");

            if (!Directory.Exists(RecentDirectory))
                Directory.CreateDirectory(RecentDirectory);

            using (StreamWriter OutputFile = new StreamWriter(RecentFilesTxt))
            {
                foreach (string filePath in clsTreeListView.ListRecentFiles)
                    OutputFile.WriteLine(filePath);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView.Focused && listView.SelectedItems.Count == 0)
                {
                    contextMenuStripListView.Show(e.Location);
                }
            }
        }

        private void listView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (((ListView)sender).SelectedItems.Count > 0)
                {
                    contextMenuStripListViewItem.Show((ListView)sender, e.Location);
                }
                else
                {
                    contextMenuStripListView.Show((ListView)sender, e.Location);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTreeListView.ClickItem(listView, listViewRecentFiles, listView.SelectedItems[0], tscmbPath);
            currentPath = tscmbPath.Text;
        }
    }
}
