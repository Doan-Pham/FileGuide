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
using System.Runtime.InteropServices;

namespace FileGuide
{
    public partial class FrmMain : Form
    {
        List<string> tabPathList = new List<string> { "My Computer", ""};
        string spaceText = "      ";

        private Color HoverColor = Color.FromArgb(229, 243, 255);
        private Color UnfocusedSelectColor = Color.FromArgb(242, 242, 242);
        private Color FocusedSelectColor = Color.FromArgb(205, 232, 255);
        private Color PrimaryTextColor = Color.Black;
        private Color SecondaryTextColor = Color.Gray;

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


        #region Overall Form design

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
            string RecentFilesTxt = System.IO.Path.Combine(RecentDirectory, "RecentAccessedFiles.txt");
            if (File.Exists(RecentFilesTxt))
            clsTreeListView.ListRecentFiles.AddRange(File.ReadAllLines(RecentFilesTxt));
            clsTreeListView.ShowListViewFirstPage(flowLayoutPanelDrives, listViewRecentFiles);

            if (this.Width > 900)
                tscmbPath.Width = this.Width - 800;
            currentPath = "My Computer";
            this.tabControl.TabPages[this.tabControl.TabCount - 1].Text = "";
            this.tabControl.TabPages[0].Text = "My Computer    ";
            tabControl.TabPages[this.tabControl.TabCount - 1].ToolTipText = "Add a new tab";
            this.tabControl.Padding = new Point(12, 4);
            this.tabControl.HandleCreated += tabControl_HandleCreated;
        }


        /// <summary>
        /// Set min width for toolStrip Path when resize form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Resize(object sender, EventArgs e)
        {

            if (this.Width > 900)
                tscmbPath.Width = this.Width - 800;
        }
        

        /// <summary>
        /// Write list of recent accessed files to a txt file in debug folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion


        #region App features: copy, cut, paste, delete, new, go to file/folder, go back


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
            catch (Exception ex)
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
            catch (IOException)
            {
                MessageBox.Show("File or Folder already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion


        #region App features: Go to file/folder, go back, click file/folder


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
                            clsTreeListView.ShowListView(this.listView, tscmbPath.Text);
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
        /// Refresh listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            if (currentPath != "")
            {
                if (currentPath != "My Computer")
                    clsTreeListView.ShowListView(listView, currentPath);
                else
                    clsTreeListView.ShowListViewFirstPage(flowLayoutPanelDrives, listViewRecentFiles);
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
        /// Run if a file, show content if a folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView.FocusedItem;

            if (clsTreeListView.ClickItem(listView, listViewRecentFiles, item, tscmbPath))
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

        #endregion


        #region App feature: Tabs control
        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl.TabCount - 1;
            if (this.tabControl.GetTabRect(lastIndex).Contains(e.Location))
            {
                TabPage newTab = new TabPage();
                newTab.BackColor = Color.White;
                newTab.BorderStyle = BorderStyle.None;
                newTab.Size = new Size(200, 10);
                ControlPaint.DrawBorder(tabControl.CreateGraphics(), newTab.Bounds, Color.AliceBlue, ButtonBorderStyle.Solid);

                newTab.Text = "My Computer" + spaceText;
                this.tabControl.TabPages.Insert(lastIndex, newTab);
                tabPathList.Insert(tabPathList.Count-1, "My Computer");
                this.tabControl.SelectedIndex = lastIndex;
            }
            else
            {
                int imageSize = 16;
                for (var i = 0; i < this.tabControl.TabPages.Count; i++)
                {
                    var tabRect = this.tabControl.GetTabRect(i);
                    var imageRect = new Rectangle(
                        (tabRect.Right - imageSize - 4),
                        tabRect.Top + (tabRect.Height - imageSize) / 2,
                        imageSize,
                        imageSize);

                    if (imageRect.Contains(e.Location))
                    {
                        this.tabControl.TabPages.RemoveAt(i);
                        tabPathList.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = this.tabControl.TabPages[e.Index];
            var tabRect = this.tabControl.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            int imageSize = 16;

            if (e.Index == tabControl.SelectedIndex)
            {
                SolidBrush backgroundBrush = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }
            else
            {
                SolidBrush backgroundBrush = new SolidBrush(Color.FromArgb(243,243,243));
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            if (e.Index == this.tabControl.TabCount - 1)
            {
                Image addImage = Properties.Resources.Sign_Plus;
                e.Graphics.DrawImage
                    (addImage,
                    tabRect.Left + (tabRect.Width - imageSize) / 2,
                    tabRect.Top + (tabRect.Height - imageSize) / 2,
                    imageSize,
                    imageSize);
            }
            else
            {
                Image closeImage = Properties.Resources.Sign_Close;
                e.Graphics.DrawImage
                    (closeImage, 
                    tabRect.Right - imageSize - 5, 
                    tabRect.Top + (tabRect.Height - imageSize) / 2, 
                    imageSize, 
                    imageSize);

                TextFormatFlags textFlags = TextFormatFlags.Left |TextFormatFlags.EndEllipsis;
                 TextRenderer.DrawText
                    (e.Graphics, 
                    tabPage.Text, 
                    tabPage.Font, 
                    tabRect, tabPage.ForeColor, 
                    textFlags);
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabControl.TabCount - 1)
                e.Cancel = true; 
            else
            {
                string tabPath = tabPathList[e.TabPageIndex];
                e.TabPage.Controls.Add(listView);
                e.TabPage.Controls.Add(tableLayoutFirstPage);
                if (tabPath == "My Computer")
                {
                    tableLayoutFirstPage.Visible = true;
                    listView.Visible = false;
                    clsTreeListView.ShowListViewFirstPage(flowLayoutPanelDrives, listViewRecentFiles);
                }
                else
                {
                    tableLayoutFirstPage.Visible = false;
                    listView.Visible = true;
                    clsTreeListView.ShowListView(listView, tabPathList[e.TabPageIndex]); 
                }
                tscmbPath.Text = tabPath;
                //e.TabPage.Text = clsTreeListView.GetApproriatePath(tabPath) + spaceText;
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        private void tabControl_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(this.tabControl.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)7);
        }

        private void tabControl_MouseEnter(object sender, EventArgs e)
        {
           // tabControl.SelectedTab.BackColor = Color.Black;
        }

        private void tabControl_MouseLeave(object sender, EventArgs e)
        {
            //tabControl.SelectedTab.BackColor = SecondaryTextColor;
        }
        #endregion


        #region TreeView design


        /// <summary>
        /// Load folder tree onto treeView and show listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try 
            {
                TreeNode currentNode = e.Node;
                if (!clsTreeListView.ShowFolderTree(this.treeView, currentNode)) return;
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
                tabPathList[tabControl.SelectedIndex] = currentPath;
                tabControl.TabPages[tabControl.SelectedIndex].Text = clsTreeListView.GetFileFolderName(currentPath) + spaceText;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
           /* Color borderColor = Color.FromArgb(227, 227, 227);
            ControlPaint.DrawBorder(e.Graphics, e.Node.TreeView.ClientRectangle,
    borderColor, 0, ButtonBorderStyle.Solid,
    borderColor, 0, ButtonBorderStyle.Solid,
    borderColor, 2, ButtonBorderStyle.Solid,
    borderColor, 0, ButtonBorderStyle.Solid);*/

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
                      new Point(nodeRect.Location.X + 20, nodeRect.Location.Y + 8), PrimaryTextColor);
            }
        }


        /// <summary>
        /// Change cursor's appearnce on hovering treenode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Set cursor to default when not hovering treenode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        #endregion


        #region ListView design

        /// <summary>
        /// Set listView display to large icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLarge_Click(object sender, EventArgs e)
        {
            listView.OwnerDraw = true;
            listView.View = View.LargeIcon;
            clsTreeListView.SetListViewItemSizeLargeIcon(listView, 70, 70);
        }


        /// <summary>
        /// Set listView display to small icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSmall_Click(object sender, EventArgs e)
        {
            listView.OwnerDraw = true;
            listView.View = View.SmallIcon;
            clsTreeListView.SetListViewItemSizeSmallIcon(listView, 100, 30);
        }


        /// <summary>
        /// Set listView display to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuList_Click(object sender, EventArgs e)
        {
            listView.OwnerDraw = true;
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
        /// Customize appearance of listView column headers to developer's need
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis |
       TextFormatFlags.ExpandTabs | TextFormatFlags.SingleLine;

            Rectangle textRect = new Rectangle(e.Bounds.X + 20, e.Bounds.Y, e.Bounds.Width - 20, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Header.ListView.Font, textRect, SecondaryTextColor, flags);

            Pen textBorder = new Pen(Color.FromArgb(186, 186, 186), 1.5f);
            e.Graphics.DrawLine(textBorder, new Point(e.Bounds.X + 25, e.Bounds.Y - 5 + e.Bounds.Height), new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y - 5 + e.Bounds.Height));

        }


        /// <summary>
        ///  Customize appearance of listView items to developer's need
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Rectangle itemRect = e.Item.Bounds;
            Graphics g = e.Graphics;


            if (e.State == ListViewItemStates.Hot)
            {
                Brush hoverBrush = new SolidBrush(HoverColor);
                g.FillRectangle(hoverBrush, e.Bounds);
            }

            // Change item's background color when selected
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

            if (e.Item.ListView.View == View.LargeIcon)
            {
                float ImageSize = 80.0f;
                int ImageLocationX = ((e.Item.Bounds.Right - e.Bounds.X - (int)ImageSize) / 2) + e.Item.Bounds.X;
                int ImageLocationY = e.Bounds.Y;
                if (e.Item.SubItems[1].Text == "Folder")
                {
                    g.DrawImage(Properties.Resources.Folder, ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }
                else
                {
                    FileInfo itemPath = new FileInfo(e.Item.SubItems[5].Text);
                    g.DrawImage(clsTreeListView.GetFileTypeIcon(itemPath), ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }

                TextFormatFlags flags = TextFormatFlags.Top | TextFormatFlags.EndEllipsis | TextFormatFlags.HorizontalCenter | TextFormatFlags.SingleLine;
                Rectangle textRect = new Rectangle(e.Bounds.X, (int)(e.Bounds.Y + ImageSize), e.Bounds.Width, (int)(e.Bounds.Height - ImageSize));

                TextRenderer.DrawText(g, e.Item.Text, e.Item.ListView.Font, textRect, PrimaryTextColor, flags);
            }
            else if (e.Item.ListView.View == View.SmallIcon)
            {
                float ImageSize = 24.0f;
                int ImageLocationX = e.Bounds.X;
                int ImageLocationY = e.Bounds.Y + 5;
                if (e.Item.SubItems[1].Text == "Folder")
                {
                    g.DrawImage(Properties.Resources.Folder, ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }
                else
                {
                    g.DrawImage(Properties.Resources.file, ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }

                TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.ExpandTabs;
                Rectangle textRect = new Rectangle(e.Bounds.X + 30, e.Bounds.Y, e.Bounds.Width - 30, e.Bounds.Height);

                TextRenderer.DrawText(g, e.Item.Text, e.Item.ListView.Font, textRect, PrimaryTextColor, flags);
            }
            else if (e.Item.ListView.View == View.List)
            {
                float ImageSize = 24.0f;
                int ImageLocationX = e.Bounds.X;
                int ImageLocationY = e.Bounds.Y;
                if (e.Item.SubItems[1].Text == "Folder")
                {
                    g.DrawImage(Properties.Resources.Folder, ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }
                else
                {
                    g.DrawImage(Properties.Resources.file, ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }

                TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.ExpandTabs;
                Rectangle textRect = new Rectangle(e.Bounds.X + 30, e.Bounds.Y, e.Bounds.Width - 30, e.Bounds.Height);

                TextRenderer.DrawText(g, e.Item.Text, e.Item.ListView.Font, textRect, PrimaryTextColor, flags);
            }
        }


        /// <summary>
        /// Customize appearance of listView subitems to developer's need
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Rectangle itemRect = e.Item.Bounds;
            Graphics g = e.Graphics;
            if (e.Item.SubItems[1].Text == "Folder")
            {
                g.DrawImage(Properties.Resources.Folder, e.Item.Bounds.X + 20, e.Item.Bounds.Y, 30, 30);
            }
            else
            {
                g.DrawImage(Properties.Resources.file, e.Item.Bounds.X + 20, e.Item.Bounds.Y, 30, 30);
            }

            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis |
       TextFormatFlags.ExpandTabs | TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter;

            Rectangle textRect;
            Color textColor;

            if (e.ColumnIndex == 0)
            {
                textRect = new Rectangle(e.Bounds.X + 60, e.Bounds.Y, e.Bounds.Width - 60, e.Bounds.Height);
                textColor = PrimaryTextColor;
            }
            else
            {
                textRect = new Rectangle(e.Bounds.X + 20, e.Bounds.Y, e.Bounds.Width - 20, e.Bounds.Height);
                textColor = SecondaryTextColor;
            }

            TextRenderer.DrawText(g, e.SubItem.Text, e.Item.ListView.Font, textRect, textColor, flags);
        }


        /// <summary>
        /// Show approriate contextMenuStrip when right clicking on listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Process item: run if a file, open if a folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTreeListView.ClickItem(listView, listViewRecentFiles, listView.SelectedItems[0], tscmbPath);
            currentPath = tscmbPath.Text;
        }


        /// <summary>
        /// Create a new folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFolderName = "New folder";
            int count = 1;
            foreach (ListViewItem item in listView.Items)
            {
                if (item.SubItems[0].Text.ToString().Contains("New folder") && item.SubItems[1].Text.ToString() == "Folder")
                {
                    newFolderName = "New folder_" + count.ToString();
                    count++;
                }
            }
            Directory.CreateDirectory(System.IO.Path.Combine(currentPath, newFolderName));
            clsTreeListView.ShowListView(listView, currentPath);
        }


        /// <summary>
        /// Create a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFileName = "New file";
            int count = 1;
            foreach (ListViewItem item in listView.Items)
            {
                if (item.SubItems[0].Text.ToString().Contains("New file") && item.SubItems[1].Text.ToString() != "Folder")
                {
                    newFileName = "New file_" + count.ToString();
                    count++;
                }
            }
            File.Create(System.IO.Path.Combine(currentPath, newFileName));
            clsTreeListView.ShowListView(listView, currentPath);
        }


        #endregion


        #region Bottom statusBar design


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



        #endregion


    }
}
