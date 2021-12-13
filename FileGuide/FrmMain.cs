using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Syroot.Windows.IO;
using Guna.UI2.WinForms;
using System.IO.Compression;

namespace FileGuide
{
    public partial class FrmMain : Form
    {
        List<string> tabPathList = new List<string> { "My Computer", "" };
        string spaceText = "      ";
        List<Guna2Panel> DrivePanelList = new List<Guna2Panel>();

        public static Color HoverColor = Color.FromArgb(229, 243, 255);
        public static Color UnfocusedSelectColor = Color.FromArgb(242, 242, 242);
        public static Color FocusedSelectColor = Color.FromArgb(205, 232, 255);
        public static Color PrimaryTextColor = Color.Black;
        public static Color SecondaryTextColor = Color.DimGray;

        public static Color PrimaryThemeColor = Color.FromArgb(9, 119, 199);
        public static Color SecondaryThemeColor = Color.FromArgb(43, 192, 228);
        public static Color PrimaryBackgroundColor = Color.White;
        public static Color SecondaryBackgroundColor = Color.FromArgb(244, 244, 244);


        private bool isSpecialFolder = false;
        private bool isCopying = false;
        private bool isCutting = false;
        private bool isFolder = false;
        private bool isListView = false;
        private bool isInDarkMode = false;

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
        /// Create treeView, load recent files list, load easy acccess list, load first page, load first tabs, set min width for tscmbPath
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            currentPath = "My Computer";

            // Create treeView and expand
            clsTreeListView.CreateTreeView(treeView);
            treeView.ExpandAll();

            // Show first page and add event handlers for drive panels' mouses events
            clsTreeListView.ShowFirstPage(flowLayoutPanelDrives, listViewRecentFiles, DrivePanelList);

            foreach (Panel DrivePanel in DrivePanelList)
            {
                foreach (Control control in DrivePanel.Controls)
                {
                    control.MouseEnter += DrivePanel_MouseEnter;
                    control.MouseLeave += DrivePanel_MouseLeave;
                    control.Click += DrivePanel_Click;
                }
            }

            // Set min width for tscmbPath
            if (Width > 900) tscmbPath.Width = Width - 800;

            // Initializes first 2 tabs: My Computer and Add
            tabControl.TabPages[tabControl.TabCount - 1].Text = "";
            tabControl.TabPages[0].Text = "My Computer    ";
            tabControl.TabPages[tabControl.TabCount - 1].ToolTipText = "Add a new tab";
            tabControl.Padding = new Point(16, 4);

            //this.ResizeBegin += (s, evt) => { this.SuspendLayout(); };
            //this.ResizeEnd += (s, evt) => { this.ResumeLayout(true); };
        }


        /// <summary>
        /// Set min width for tscmbPath when resize form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Resize(object sender, EventArgs e)
        {
           // listView.Columns[listView.Columns.Count - 1].Width = -1;
            if (Width > 900)
                tscmbPath.Width = Width - 800;
            toolBar.Width = Width - treeView.Width + 10;
            tsPath.Width = Width - treeView.Width + 10;
            ShortcutKeysPanel.Width = Width - treeView.Width + 10;
            listView.ColumnWidthChanging -= listView_ColumnWidthChanging;
            int SumColumnHeadersWidth = 0 ;
            for (int i = 0; i < listView.Columns.Count - 1;i++)
            {
                SumColumnHeadersWidth += listView.Columns[i].Width;
            }
            listView.Columns[listView.Columns.Count - 1].Width = listView.Width - SumColumnHeadersWidth - 26;
            listView.ColumnWidthChanging += listView_ColumnWidthChanging;
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }

        /// <summary>
        /// Write recent accessed files list and easy access folders to .txt files 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Write recent accessed files list
            string DebugDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string RecentDirectory = System.IO.Path.Combine(DebugDirectory, "RecentAccessesFiles");
            string RecentFilesTxt = System.IO.Path.Combine(RecentDirectory, "RecentAccessedFiles.txt");

            if (!Directory.Exists(RecentDirectory)) Directory.CreateDirectory(RecentDirectory);

            using (StreamWriter OutputFile = new StreamWriter(RecentFilesTxt))
            {
                foreach (string filePath in clsTreeListView.ListRecentFiles) OutputFile.WriteLine(filePath);
            }

            // Write easy access folders list
            string EasyAccessDirectory = System.IO.Path.Combine(DebugDirectory, "EasyAccess");
            string EasyAccessFoldersTxt = System.IO.Path.Combine(EasyAccessDirectory, "EasyAccessFolders.txt");

            if (!Directory.Exists(EasyAccessDirectory)) Directory.CreateDirectory(EasyAccessDirectory);

            using (StreamWriter OutputFile = new StreamWriter(EasyAccessFoldersTxt))
            {
                foreach (string filePath in clsTreeListView.EasyAccessFolderPathList) OutputFile.WriteLine(filePath);
            }
        }

        #endregion


        #region App features: copy, cut, paste, delete, new, rename file/folder


        /// <summary>
        /// Copy item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count >= 0)
            {
                // Set isCopying to true so events for Paste feature know whether to cut paste or copy paste
                isCopying = true;

                // If listView is focused, assign initial item's path to a variable and enable Paste feature
                if (listView.Focused)
                {
                    isListView = true;
                    itemPaste = listView.FocusedItem;
                    if (itemPaste == null) return;

                    pathSource = itemPaste.SubItems[5].Text;
                    if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                    {
                        isFolder = true;
                    }
                    else
                    {
                        if (itemPaste.SubItems[1].Text.Trim() == "Image File")
                        {
                            string ImagePath = HelperMethods.GetApproriatePath(itemPaste.SubItems[5].Text.Trim());
                            Image img = Image.FromFile(ImagePath);
                            Clipboard.SetImage(img);
                        }

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
            if (listView.SelectedItems.Count >= 0)
            {
                isCopying = false;
                isCutting = true;
            }

        }


        /// <summary>
        /// Paste item
        /// </summary>GetParentDirectoryPath
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
                        Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(pathSource, pathDest + "\\" + HelperMethods.GetFileFolderName(pathSource));
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
                        Microsoft.VisualBasic.FileIO.FileSystem.MoveDirectory(pathSource, pathDest + "\\" + HelperMethods.GetFileFolderName(pathSource));
                    }
                    else
                    {
                        Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(pathSource, pathDest);
                    }
                    isCutting = false;
                }

                // After pasting, refresh listView and disable paste feature
                string strNewPath;
                if (!isFolder) strNewPath = HelperMethods.GetParentDirectoryPath(pathDest);
                else strNewPath = pathDest;
                clsTreeListView.ShowListView(listView, strNewPath);

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
            if (listView.Focused)
            {
                try
                {
                    ListViewItem deleteItem = listView.FocusedItem;
                    string path = deleteItem.SubItems[5].Text;

                    if (deleteItem.SubItems[1].Text == "Folder")
                    {
                        DirectoryInfo directory = new DirectoryInfo(path);
                        if (!directory.Exists)
                        {
                            MessageBox.Show("Folder might not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this folder ? \n" + deleteItem.Text.ToString(), "Delete folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                            if (dialog == DialogResult.Yes)
                            {
                                directory.Delete(true);
                            }
                            else return;

                            string pathFolder = HelperMethods.GetParentDirectoryPath(path);
                            clsTreeListView.ShowListView(listView, pathFolder);
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
                            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this file ? \n" + deleteItem.Text.ToString(), "Delete file", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                            if (dialog == DialogResult.Yes)
                            {
                                file.Delete();
                            }
                            else return;

                            string pathFolder = HelperMethods.GetParentDirectoryPath(path);
                            clsTreeListView.ShowListView(listView, pathFolder);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        /// <summary>
        /// Create a new folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.Focused)
            {
                // Check for folders with the same name as the new folder to assign correct name, then create the new folder
                int SameNameCount = 1;
                string newFolderName = "New folder";
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.SubItems[0].Text.ToString().Contains("New folder") && item.SubItems[1].Text.ToString() == "Folder")
                    {
                        newFolderName = "New folder_" + SameNameCount.ToString();
                        SameNameCount++;
                    }
                }
                DirectoryInfo newlyCreatedFolder = Directory.CreateDirectory(System.IO.Path.Combine(currentPath, newFolderName));
                ListViewItem newlyCreatedItem = clsTreeListView.GetListViewItem(newlyCreatedFolder);

                // Check for the folder with same name and same type as the newly created folder and start renaming
                int index = 0;
                clsTreeListView.ShowListView(listView, currentPath);
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.SubItems[0].Text == newFolderName && item.SubItems[1].Text == newlyCreatedItem.SubItems[1].Text)
                    {
                        index = item.Index;
                    }
                }
                listView.Items[index].Selected = true;
                menuRename_Click(sender, e);

            }
        }


        /// <summary>
        /// Create a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.Focused)
            {
                // Check for folders with the same name as the new folder to assign correct name, then create the new folder
                string newFileName = "New file";
                int SameNameCount = 1;
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.SubItems[0].Text.ToString().Contains("New file") && item.SubItems[1].Text.ToString() != "Folder")
                    {
                        newFileName = "New file_" + SameNameCount.ToString();
                        SameNameCount++;
                    }
                }

                File.Create(System.IO.Path.Combine(currentPath, newFileName));

                // Go to the created folder and start renaming
                int index = 0;
                clsTreeListView.ShowListView(listView, currentPath);
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.SubItems[0].Text.ToString() == newFileName)
                    {
                        index = item.Index;
                    }
                }
                listView.Items[index].Selected = true;
                menuRename_Click(sender, e);

            }
        }


        /// <summary>
        /// Begin renaming item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuRename_Click(object sender, EventArgs e)
        {
            if (listView.Focused)
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
                // Refesh if the new label is empty
                if (e.Label == null || e.Label == "")
                {
                    refreshToolStripMenuItem.PerformClick();
                    e.CancelEdit = true;
                    return;
                }

                //Rename item then refresh listView
                string path = listView.FocusedItem.SubItems[5].Text;
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(path, e.Label);
                }
                else
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(path, e.Label);
                }
                clsTreeListView.ShowListView(listView, HelperMethods.GetParentDirectoryPath(path));
                e.CancelEdit = true;
            }
            catch (IOException)
            {
                MessageBox.Show("File or Folder already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region App features: Go to file/folder, refresh, go back, click file/folder, zip files/folders


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
                        // If path points to a file, run that file
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
                            clsTreeListView.ShowListView(listView, tscmbPath.Text);
                            currentPath = tscmbPath.Text;
                            tabPathList[tabControl.SelectedIndex] = currentPath;
                            tabControl.TabPages[tabControl.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
                        }

                        // If path doesn't exist, show error message
                        else
                        {
                            MessageBox.Show("File/Folder not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Show list view/first page and add mouse events to drive panels
            if (currentPath != "")
            {
                if (currentPath != "My Computer") clsTreeListView.ShowListView(listView, currentPath);
                else
                {
                    listViewRecentFiles.Refresh();
                    clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
                    foreach (Panel DrivePanel in DrivePanelList)
                    {
                        foreach (Control control in DrivePanel.Controls)
                        {
                            control.MouseEnter += DrivePanel_MouseEnter;
                            control.MouseLeave += DrivePanel_MouseLeave;
                            control.Click += DrivePanel_Click;
                        }
                    }
                }
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
                    currentPath = HelperMethods.GetParentDirectoryPath(currentPath);
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
                        clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
                    }
                    tscmbPath.Text = currentPath;
                    tabPathList[tabControl.SelectedIndex] = currentPath;
                    tabControl.TabPages[tabControl.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (clsTreeListView.ClickItem(listView, item, tscmbPath, false))
            {
                //If item is a folder, assign the current directory to currentPath
                if (item.SubItems[1].Text == "Folder")
                {
                    currentPath = tscmbPath.Text;
                    tabPathList[tabControl.SelectedIndex] = currentPath;
                    tabControl.TabPages[tabControl.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
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
                if (clsTreeListView.ClickItem(listView, item, tscmbPath, false))
                {
                    //If item is a folder, assign the current directory to currentPath and show on tscmbPath
                    if (item.SubItems[1].Text == "Folder")
                    {
                        currentPath = tscmbPath.Text;
                    }
                    tabPathList[tabControl.SelectedIndex] = currentPath;
                    tabControl.TabPages[tabControl.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
                }
            }
        }


        /// <summary>
        /// Zip files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zipFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstItemName = listView.SelectedItems[0].SubItems[0].Text;
                string ZipFilePath = currentPath + "\\" + FirstItemName.Split('.').ToList().ElementAt(0) + ".zip";


                foreach (ListViewItem item in listView.SelectedItems)
                {
                    string itemName = item.SubItems[0].Text;
                    string itemPath = currentPath + "\\" + itemName;
                    if (!System.IO.Path.GetExtension(itemPath).Equals(".zip"))
                    {
                        using (FileStream fs = new FileStream(ZipFilePath, FileMode.Create))
                        {
                            using (ZipArchive newZipFile = new ZipArchive(fs, ZipArchiveMode.Update))
                            {
                                HelperMethods.CreateEntryFromAny(newZipFile, itemPath);
                            }
                        }
                    }

                }
                btnRefresh.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while zipping files/folders \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Unzip compressed file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unzipFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ZipItemName;
                string ZipItemPath;

                foreach (ListViewItem item in listView.SelectedItems)
                {

                    ZipItemName = item.SubItems[0].Text;
                    ZipItemPath = currentPath + "\\" + ZipItemName;

                    if (System.IO.Path.GetExtension(ZipItemPath).Equals(".zip"))
                    {
                        string destinationPath = currentPath + "\\" + ZipItemName.Replace(".zip", "");

                        if (!File.Exists(destinationPath) && !Directory.Exists(destinationPath))
                        {
                            ZipFile.ExtractToDirectory(ZipItemPath, destinationPath);
                        }
                        else
                        {
                            int SameNameCount = 1;
                            string OriginalItemName = ZipItemName.Replace(".zip", "");
                            string newItemName = OriginalItemName;
                            foreach (ListViewItem LVitem in listView.Items)
                            {
                                if (LVitem.SubItems[0].Text.ToString().Contains(OriginalItemName))
                                {
                                    newItemName = OriginalItemName + SameNameCount.ToString();
                                    SameNameCount++;
                                }
                            }
                            ZipFile.ExtractToDirectory(ZipItemPath, currentPath + "\\" + newItemName);
                        }
                    }
                }
                btnRefresh.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while unzipping files \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void toolStripButtonDarkMode_Click(object sender, EventArgs e)
        {
            if (!isInDarkMode)
            {
                isInDarkMode = true;
                PrimaryTextColor = Color.White;
                HoverColor = Color.FromArgb(50, 50, 50);
                UnfocusedSelectColor = Color.FromArgb(75, 75, 75);
                FocusedSelectColor = Color.FromArgb(100, 100, 100);
                PrimaryBackgroundColor = Color.FromArgb(39, 39, 39);
                SecondaryBackgroundColor = FocusedSelectColor;

                foreach (Control control in this.Controls)
                {
                    UpdateColorControls(control, PrimaryBackgroundColor, PrimaryTextColor);
                }

                treeView.BackColor = HoverColor;

                UpdateColorControls(contextMenuStripListView, PrimaryBackgroundColor, PrimaryTextColor);
                UpdateColorControls(contextMenuStripListViewItem, PrimaryBackgroundColor, PrimaryTextColor);
                UpdateColorControls(contextMenuStripTreeView, PrimaryBackgroundColor, PrimaryTextColor);

                this.Refresh();

            }
            else
            {
                isInDarkMode = false;
                HoverColor = Color.FromArgb(229, 243, 255);
                UnfocusedSelectColor = Color.FromArgb(242, 242, 242);
                FocusedSelectColor = Color.FromArgb(205, 232, 255);
                PrimaryTextColor = Color.Black;
                SecondaryTextColor = Color.Gray;
                PrimaryBackgroundColor = Color.White;
                SecondaryBackgroundColor = Color.FromArgb(244, 244, 244);

                foreach (Control control in this.Controls)
                {
                    UpdateColorControls(control, PrimaryBackgroundColor, PrimaryTextColor);
                }
                treeView.BackColor = Color.FromArgb(244, 244, 244);

                UpdateColorControls(contextMenuStripListView, PrimaryBackgroundColor, PrimaryTextColor);
                UpdateColorControls(contextMenuStripListViewItem, PrimaryBackgroundColor, PrimaryTextColor);
                UpdateColorControls(contextMenuStripTreeView, PrimaryBackgroundColor, PrimaryTextColor);

                this.Refresh();
            }
            
        }


        public void UpdateColorControls(Control control, Color BackColor, Color ForeColor)
        {
            control.BackColor = BackColor;
            control.ForeColor = ForeColor;
            foreach (Control subControl in control.Controls)
            {
                UpdateColorControls(subControl, BackColor, ForeColor);
            }
        }


        #endregion


        #region App feature: Tabs control
        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            // If clicked on the last tab (tab with the plus sign), create a new tab
            var lastIndex = tabControl.TabCount - 1;
            if (tabControl.GetTabRect(lastIndex).Contains(e.Location))
            {
                TabPage newTab = new TabPage();
                newTab.BackColor = Color.White;
                newTab.BorderStyle = BorderStyle.None;
                newTab.Size = new Size(200, 10);
                ControlPaint.DrawBorder(tabControl.CreateGraphics(), newTab.Bounds, Color.AliceBlue, ButtonBorderStyle.Solid);

                newTab.Text = "My Computer" + spaceText;
                tabControl.TabPages.Insert(lastIndex, newTab);
                tabPathList.Insert(tabPathList.Count - 1, "My Computer");
                tabControl.SelectedIndex = lastIndex;
            }
            // If clicked on the X sign of any tab, delete that tab
            else
            {
                int imageSize = 16;
                for (var i = 0; i < tabControl.TabPages.Count; i++)
                {
                    var tabRect = tabControl.GetTabRect(i);
                    var imageRect = new Rectangle(
                        (tabRect.Right - imageSize - 4),
                        tabRect.Top + (tabRect.Height - imageSize) / 2,
                        imageSize,
                        imageSize);

                    if (imageRect.Contains(e.Location))
                    {
                        tabControl.TabPages.RemoveAt(i);
                        tabPathList.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == tabControl.TabCount - 1)
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
                    clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
                }
                else
                {
                    tableLayoutFirstPage.Visible = false;
                    listView.Visible = true;
                    clsTreeListView.ShowListView(listView, tabPathList[e.TabPageIndex]);
                }
                tscmbPath.Text = tabPath;
            }
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
                isSpecialFolder = false;
                TreeNode currentNode = e.Node;
                string SpecialFolderPath = "";

                // Check for special folders: downloads, desktop, easy access, documents
                if (clsTreeListView.GetTreeNodeRoot(currentNode).Text != "My Computer")
                {
                    switch (currentNode.Text)
                    {
                        case "Desktop":
                            SpecialFolderPath = new KnownFolder(KnownFolderType.Desktop).Path;
                            break;
                        case "Downloads":
                            SpecialFolderPath = new KnownFolder(KnownFolderType.Downloads).Path;
                            break;
                        case "Documents":
                            SpecialFolderPath = new KnownFolder(KnownFolderType.Documents).Path;
                            break;
                        default:
                            {
                                if (clsTreeListView.GetTreeNodeRoot(currentNode).Text == "Easy Access" && currentNode.Parent != null)
                                {
                                    SpecialFolderPath = clsTreeListView.EasyAccessFolderPathList[currentNode.Index];
                                }
                            }
                            break;
                    }
                    isSpecialFolder = true;
                }

                // If there's an error when showing folder tree, return
                if (!clsTreeListView.ShowFolderTree(treeView, currentNode, isSpecialFolder, SpecialFolderPath)) return;

                if (currentNode.Text == "My Computer")
                {
                    tableLayoutFirstPage.Visible = true;
                    listView.Visible = false;
                }
                else
                {
                    if (currentNode.Text == "Easy Access" && currentNode.Parent == null)
                    {
                        currentNode.Expand();
                        return;
                    }
                    tableLayoutFirstPage.Visible = false;
                    listView.Visible = true;
                    if (SpecialFolderPath == "") clsTreeListView.ShowListView(listView, currentNode);
                    else clsTreeListView.ShowListView(listView, SpecialFolderPath);
                }

                tscmbPath.Text = HelperMethods.GetApproriatePath(currentNode.FullPath);
                pathNode = tscmbPath.Text;
                currentPath = pathNode;

                tabPathList[tabControl.SelectedIndex] = currentPath;
                tabControl.TabPages[tabControl.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
            }
            catch (Exception ex)
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

            Graphics g = e.Graphics;
            Rectangle nodeRect = e.Node.Bounds;

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
                Rectangle flags = new Rectangle(e.Bounds.Right - 10, e.Bounds.Y, 10, e.Bounds.Height);
                g.FillRectangle(new SolidBrush(Color.BlueViolet), flags);
            }

            // Draw expand/collapse chevrons
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.IsExpanded)
                {
                    g.DrawImage(Properties.Resources.Icon_ExpandChevron, nodeRect.Location.X - 40, nodeRect.Location.Y + 16, 16, 16);
                }
                else
                {
                    g.DrawImage(Properties.Resources.Icon_NormalChevron, nodeRect.Location.X - 40, nodeRect.Location.Y + 16, 16, 16);
                }
            }

            //Draw node icon
            g.DrawImage(HelperMethods.GetNodeTypeIcon(e.Node), nodeRect.Location.X - 14, nodeRect.Location.Y + 8, 30, 30);

            //Draw text
            if (e.Node.Bounds.X != 0)
            {
                TextRenderer.DrawText(g, e.Node.Text, ((TreeView)sender).Font, new Point(nodeRect.Location.X + 20, nodeRect.Location.Y + 8), PrimaryTextColor);
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
            if (HoveredNode != null) Cursor = Cursors.Hand;
            else Cursor = Cursors.Default;
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


        /// <summary>
        /// Show contextMenuStrip when right click a treeView node
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView.SelectedNode = treeView.GetNodeAt(e.Location);
                if (treeView.SelectedNode != null)
                    contextMenuStripTreeView.Show((TreeView)sender, e.Location);
            }
        }


        /// <summary>
        /// Pin folder to easy access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                clsTreeListView.EasyAccessFolderPathList.Add(HelperMethods.GetApproriatePath(treeView.SelectedNode.FullPath));
                TreeNode clonedTreeNode = (TreeNode)treeView.SelectedNode.Clone();
                treeView.Nodes[1].Nodes.Add(treeView.SelectedNode.Text);
            }
            treeView.Nodes[1].Expand();
        }


        /// <summary>
        /// Unpin folder from easy access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unpingFromEasyAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null && clsTreeListView.GetTreeNodeRoot(treeView.SelectedNode).Text == "Easy Access")
            {
                clsTreeListView.EasyAccessFolderPathList.RemoveAt(treeView.SelectedNode.Index);
                treeView.Nodes[1].Nodes.RemoveAt(treeView.SelectedNode.Index);
            }
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
            // Draw text
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis |
       TextFormatFlags.ExpandTabs | TextFormatFlags.SingleLine;

            Rectangle textRect = new Rectangle(e.Bounds.X + 20, e.Bounds.Y, e.Bounds.Width - 20, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Header.ListView.Font, textRect, SecondaryTextColor, flags);

            // Draw border
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

            // Specify how to draw listView items in each view mode
            if (e.Item.ListView.View == View.LargeIcon)
            {
                float ImageSize = 80.0f;
                int ImageLocationX = ((e.Item.Bounds.Right - e.Bounds.X - (int)ImageSize) / 2) + e.Item.Bounds.X;
                int ImageLocationY = e.Bounds.Y;
                if (e.Item.SubItems[1].Text == "Folder")
                {
                    g.DrawImage(Properties.Resources.Icon_Folder, ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }
                else
                {
                    FileInfo itemPath = new FileInfo(e.Item.SubItems[5].Text);
                    g.DrawImage(HelperMethods.GetFileTypeIcon(itemPath), ImageLocationX, ImageLocationY, ImageSize, ImageSize);
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
                    g.DrawImage(Properties.Resources.Icon_Folder, ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }
                else
                {
                    FileInfo itemPath = new FileInfo(e.Item.SubItems[5].Text);
                    g.DrawImage(HelperMethods.GetFileTypeIcon(itemPath), ImageLocationX, ImageLocationY, ImageSize, ImageSize);
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
                    g.DrawImage(Properties.Resources.Icon_Folder, ImageLocationX, ImageLocationY, ImageSize, ImageSize);
                }
                else
                {
                    FileInfo itemPath = new FileInfo(e.Item.SubItems[5].Text);
                    g.DrawImage(HelperMethods.GetFileTypeIcon(itemPath), ImageLocationX, ImageLocationY, ImageSize, ImageSize);
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
                g.DrawImage(Properties.Resources.Icon_Folder, e.Item.Bounds.X + 20, e.Item.Bounds.Y, 30, 30);
            }
            else
            {
                g.DrawImage(Properties.Resources.Logo_UnknownFile, e.Item.Bounds.X + 20, e.Item.Bounds.Y, 30, 30);
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
            clsTreeListView.ClickItem(listView, listView.SelectedItems[0], tscmbPath, false);
            currentPath = tscmbPath.Text;
        }

        #endregion


        #region FirstPage design

        /// <summary>
        /// Go to file when click on recent access files list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewRecentFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clsTreeListView.ClickItem(listViewRecentFiles, listViewRecentFiles.FocusedItem, tscmbPath, true);
            btnRefresh.PerformClick();
        }

        /// <summary>
        /// Change background color of hovered drive panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrivePanel_MouseEnter(object sender, EventArgs e)
        {
            Control drivePanelChildControls = sender as Control;
            Panel drivePanel = (Panel)drivePanelChildControls.Parent;
            drivePanel.BackColor = Color.FromArgb(200, 200, 200);
            Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Change background color of unhovered drive panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrivePanel_MouseLeave(object sender, EventArgs e)
        {
            Control drivePanelChildControls = sender as Control;
            Panel drivePanel = (Panel)drivePanelChildControls.Parent;
            drivePanel.BackColor = Color.White;
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Go to the approriate hard disk when clicking on a drive panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrivePanel_Click(object sender, EventArgs e)
        {
            Control drivePanelChildControls = sender as Control;
            Panel drivePanel = (Panel)drivePanelChildControls.Parent;
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drivePanel.Controls[1].Text.Contains(drive.Name.ToString().Replace("\\", "")))
                {
                    tableLayoutFirstPage.Visible = false;
                    listView.Visible = true;
                    currentPath = drive.Name;
                    tscmbPath.Text = drive.Name;
                    tabPathList[tabControl.SelectedIndex] = currentPath;
                    tabControl.TabPages[tabControl.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
                    clsTreeListView.ShowListView(listView, currentPath);
                    return;
                }
            }
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
            if (currentPath == "My Computer")
            {
                foreach (Panel DrivePanel in DrivePanelList)
                {
                    foreach (Control control in DrivePanel.Controls)
                    {
                        control.MouseEnter += DrivePanel_MouseEnter;
                        control.MouseLeave += DrivePanel_MouseLeave;
                        control.Click += DrivePanel_Click;
                    }
                }
            }

            tabControl.TabPages[tabControl.SelectedIndex].Text = HelperMethods.GetFileFolderName(tabPathList[tabControl.SelectedIndex]) + spaceText;
        }


        /// <summary>
        /// Show number of selected listView items on status strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            statusLblNumSelect.Text = listView.SelectedItems.Count.ToString() + " items selected   ";
        }






        #endregion

        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
                e.Cancel = true;
                e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

        private void listViewRecentFiles_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }


    }
}
