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
using Microsoft.VisualBasic.FileIO;
using System.IO.Compression;

namespace FileGuide
{
    public partial class FrmMain : Form
    {
        List<string> tabPagePathList = new List<string> { "My Computer", "" };
        // Add spaceText to tab header's text to have space for "X" icon
        string spaceText = "      ";
        List<Panel> drivePanelList = new List<Panel>();

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
        public static bool isInDarkMode = false;

        private ListViewItem itemPaste;
        private string pathSource;
        private string pathDest;
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
        private void FrmMain_Load(object sender, EventArgs e)
        {
            currentPath = "My Computer";

            // Create treeView and expand
            clsTreeListView.CreateTreeView(treeViewFolderTree);
            treeViewFolderTree.ExpandAll();

            // Show first page and add event handlers for drive panels' mouses events
            clsTreeListView.CreateFirstPage(flowLayoutDrivePanels, listViewRecentFiles, drivePanelList);

            foreach (Panel drivePanel in drivePanelList)
            {
                foreach (Control control in drivePanel.Controls)
                {
                    control.MouseEnter += drivePanel_MouseEnter;
                    control.MouseLeave += drivePanel_MouseLeave;
                    control.Click += drivePanel_Click;
                }
            }

            // Set min width for tscmbPath
            if (Width > 900) tscmbPath.Width = Width - 800;

            // Initializes first 2 tabs: My Computer and Add
            tabWindow.TabPages[tabWindow.TabCount - 1].Text = "";
            tabWindow.TabPages[0].Text = "My Computer    ";
            tabWindow.TabPages[tabWindow.TabCount - 1].ToolTipText = "Add a new tab";
            tabWindow.Padding = new Point(16, 4);

            listViewFolderContent.Columns[listViewFolderContent.Columns.Count - 1].Width = -2;
            listViewRecentFiles.Columns[listViewRecentFiles.Columns.Count - 1].Width = -2;
        }


        /// <summary>
        /// Set min width for tscmbPath when resize form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (Width > 900) tscmbPath.Width = Width - 800;

            toolBar.Width = Width - treeViewFolderTree.Width + 50;
            tsPath.Width = Width - treeViewFolderTree.Width + 50;
            listViewFolderContent.Columns[listViewFolderContent.Columns.Count - 1].Width = -2;
            listViewRecentFiles.Columns[listViewRecentFiles.Columns.Count - 1].Width = -2;

            //listViewFolderContent.Width = Width - treeView.Width;
            //listViewRecentFiles.Width = Width - treeView.Width;
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            /*SuspendLayout();
            base.OnResizeBegin(e);*/
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            /*ResumeLayout();
            base.OnResizeEnd(e);*/
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
                foreach (string filePath in clsTreeListView.RecentFilesPathList) OutputFile.WriteLine(filePath);
            }

            // Write easy access folders list
            string EasyAccessDirectory = System.IO.Path.Combine(DebugDirectory, "EasyAccess");
            string EasyAccessFoldersTxt = System.IO.Path.Combine(EasyAccessDirectory, "EasyAccessFolders.txt");

            if (!Directory.Exists(EasyAccessDirectory)) Directory.CreateDirectory(EasyAccessDirectory);

            using (StreamWriter OutputFile = new StreamWriter(EasyAccessFoldersTxt))
            {
                foreach (string filePath in clsTreeListView.EasyAccessFolderPathList) OutputFile.WriteLine(filePath);
            }

            if (isInDarkMode)
            {
                darkModeToolStripMenuItem.PerformClick();
            }

        }

        #endregion


        #region App features: copy, cut, paste, delete, new, rename file/folder


        /// <summary>
        /// Copy item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyEvent(object sender, EventArgs e)
        {
            if (listViewFolderContent.SelectedItems.Count >= 0)
            {
                // Set isCopying to true so events for Paste feature know whether to cut paste or copy paste
                isCopying = true;
                isCutting = false;

                // If listViewFolderContent is focused, assign initial item's path to a variable and enable Paste feature
                itemPaste = listViewFolderContent.FocusedItem;
                if (itemPaste == null) return;

                pathSource = itemPaste.SubItems[5].Text;
                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                    isFolder = true;
                else
                    isFolder = false;

                pasteToolStripMenuItem.Enabled = true;
                tsbtnPaste.Enabled = true;
            }
        }


        /// <summary>
        /// Cut item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutEvent(object sender, EventArgs e)
        {
            // The same as btnCopy_Click event but set isCutting to true and isCopying to false
            CopyEvent(sender, e);
            if (listViewFolderContent.SelectedItems.Count >= 0)
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
        private void PasteEvent(object sender, EventArgs e)
        {
            try
            {
                // pathSource and pathDest respectively indicate item-needed-to-copy-cut's path and destination directory's path 
                if (isFolder) pathDest = currentPath + "\\" + HelperMethods.GetFileFolderName(pathSource);
                else pathDest = currentPath + "\\" + itemPaste.Text;

                // If user is doing copy-paste, copy item to destination
                if (isCopying)
                {
                    if (isFolder) FileSystem.CopyDirectory(pathSource, pathDest);
                    else FileSystem.CopyFile(pathSource, pathDest);
                    isCopying = false;
                }
                // If user is doing cut-paste, move item to new destination
                else if (isCutting)
                {
                    if (isFolder) FileSystem.MoveDirectory(pathSource, pathDest);
                    else FileSystem.MoveFile(pathSource, pathDest);
                    isCutting = false;
                }

                // After pasting, refresh listViewFolderContent and disable paste feature
                string strNewPath;
                if (!isFolder) strNewPath = HelperMethods.GetParentDirectoryPath(pathDest);
                else strNewPath = pathDest;
                clsTreeListView.ShowFolderContent(listViewFolderContent, strNewPath);
                pasteToolStripMenuItem.Enabled = true;
                tsbtnPaste.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while pasting \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Delete item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteEvent(object sender, EventArgs e)
        {
            if (listViewFolderContent.Focused)
            {
                try
                {
                    if (listViewFolderContent.SelectedItems.Count > 0)
                    {
                        DialogResult dialog = MessageBox.Show("Are you sure you want to delete these " + listViewFolderContent.SelectedItems.Count + " items ? \n", "Delete file/folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dialog == DialogResult.Yes)
                        {
                            foreach (ListViewItem item in listViewFolderContent.SelectedItems)
                            {
                                string ItemDeletePath = item.SubItems[5].Text;
                                if (item.SubItems[1].Text == "Folder")
                                {
                                    DirectoryInfo DeleteDirectory = new DirectoryInfo(ItemDeletePath);
                                    DeleteDirectory.Delete(true);
                                }
                                else
                                {
                                    FileInfo DeleteFile = new FileInfo(ItemDeletePath);
                                    DeleteFile.Delete();
                                }
                            }
                        }
                        clsTreeListView.ShowFolderContent(listViewFolderContent, currentPath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Create a new folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFolderEvent(object sender, EventArgs e)
        {
            if (listViewFolderContent.Focused)
            {
                // Check for folders with the same name as the new folder to assign correct name, then create the new folder
                int SameNameCount = 1;
                string newFolderName = "New folder";
                foreach (ListViewItem item in listViewFolderContent.Items)
                {
                    if (item.SubItems[0].Text.ToString().Contains("New folder") && item.SubItems[1].Text.ToString() == "Folder")
                    {
                        newFolderName = "New folder_" + SameNameCount.ToString();
                        SameNameCount++;
                    }
                }
                DirectoryInfo newlyCreatedFolder =
                    Directory.CreateDirectory(System.IO.Path.Combine(currentPath, newFolderName));

                clsTreeListView.ShowFolderContent(listViewFolderContent, currentPath);


                /* // Check for the folder with same name and same type as the newly created folder and start renaming
                 int index = 0;
                 ListViewItem newlyCreatedItem = clsTreeListView.GetListViewItem(newlyCreatedFolder);
                 clsTreeListView.ShowListView(listViewFolderContent, currentPath);
                 foreach (ListViewItem item in listViewFolderContent.Items)
                 {
                     if (item.SubItems[0].Text == newFolderName && item.SubItems[1].Text == newlyCreatedItem.SubItems[1].Text)
                     {
                         index = item.Index;
                     }
                 }
                 listViewFolderContent.Items[index].Selected = true;
                 menuRename_Click(sender, e);*/
            }
        }


        /// <summary>
        /// Create a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFileEvent(object sender, EventArgs e)
        {
            if (listViewFolderContent.Focused)
            {
                // Check for folders with the same name as the new folder to assign correct name, then create the new folder
                string newFileName = "New file";
                int SameNameCount = 1;
                foreach (ListViewItem item in listViewFolderContent.Items)
                {
                    if (item.SubItems[0].Text.ToString().Contains("New file") && item.SubItems[1].Text.ToString() != "Folder")
                    {
                        newFileName = "New file_" + SameNameCount.ToString();
                        SameNameCount++;
                    }
                }

                File.Create(System.IO.Path.Combine(currentPath, newFileName));
                clsTreeListView.ShowFolderContent(listViewFolderContent, currentPath);

                /* // Go to the created folder and start renaming
                 int index = 0;
                 foreach (ListViewItem item in listViewFolderContent.Items)
                 {
                     if (item.SubItems[0].Text.ToString() == newFileName)
                     {
                         index = item.Index;
                     }
                 }
                 listViewFolderContent.Items[index].Selected = true;
                 menuRename_Click(sender, e);*/
            }
        }


        /// <summary>
        /// Begin renaming item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameEvent(object sender, EventArgs e)
        {
            if (listViewFolderContent.Focused)
                listViewFolderContent.SelectedItems[0].BeginEdit();
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

                //Rename item then refresh listViewFolderContent
                string path = listViewFolderContent.FocusedItem.SubItems[5].Text;
                FileInfo fi = new FileInfo(path);
                if (fi.Exists) FileSystem.RenameFile(path, e.Label);
                else FileSystem.RenameDirectory(path, e.Label);
                clsTreeListView.ShowFolderContent
                    (listViewFolderContent, HelperMethods.GetParentDirectoryPath(path));
            }
            catch (IOException)
            {
                MessageBox.Show("File or Folder already exists", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while renaming \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region App features: Go to file/folder, refresh, go back, click file/folder, zip files/folders, darkmode


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
                            tscmbPath.Text = currentPath;
                        }

                        // If path points to a folder, open that folder
                        else if (Directory.Exists(tscmbPath.Text.Trim()))
                        {
                            listViewFolderContent.Visible = true;
                            tableLayoutFirstPage.Visible = false;
                            clsTreeListView.ShowFolderContent(listViewFolderContent, tscmbPath.Text);
                            currentPath = tscmbPath.Text;
                            tabPagePathList[tabWindow.SelectedIndex] = currentPath;
                            tabWindow.TabPages[tabWindow.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
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
                    MessageBox.Show("An error has occured \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Refresh listViewFolderContent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            // Show list view/first page and add mouse events to drive panels
            if (currentPath != "")
            {
                treeViewFolderTree.Refresh();
                if (currentPath != "My Computer") clsTreeListView.ShowFolderContent(listViewFolderContent, currentPath);
                else
                {
                    listViewRecentFiles.Refresh();
                    clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
                    foreach (Panel drivePanel in drivePanelList)
                    {
                        foreach (Control control in drivePanel.Controls)
                        {
                            control.MouseEnter += drivePanel_MouseEnter;
                            control.MouseLeave += drivePanel_MouseLeave;
                            control.Click += drivePanel_Click;
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
                        clsTreeListView.ShowFolderContent(listViewFolderContent, currentPath);
                        tableLayoutFirstPage.Visible = false;
                        listViewFolderContent.Visible = true;
                    }
                    else
                    {
                        clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
                        tableLayoutFirstPage.Visible = true;
                        listViewFolderContent.Visible = false;
                    }
                    tscmbPath.Text = currentPath;

                    tabPagePathList[tabWindow.SelectedIndex] = currentPath;
                    tabWindow.TabPages[tabWindow.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Run if a file, show content if a folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listViewFolderContent.FocusedItem;
            if (clsTreeListView.ClickItem(listViewFolderContent, item, tscmbPath, false))
            {
                clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
                //If item is a folder, assign the current directory to currentPath
                if (item.SubItems[1].Text == "Folder")
                {
                    currentPath = tscmbPath.Text;
                    tabPagePathList[tabWindow.SelectedIndex] = currentPath;
                    tabWindow.TabPages[tabWindow.SelectedIndex].Text
                        = HelperMethods.GetFileFolderName(currentPath) + spaceText;
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
                ListViewItem item = listViewFolderContent.FocusedItem;
                if (clsTreeListView.ClickItem(listViewFolderContent, item, tscmbPath, false))
                {
                    clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
                    //If item is a folder, assign the current directory to currentPath and show on tscmbPath
                    if (item.SubItems[1].Text == "Folder")
                    {
                        currentPath = tscmbPath.Text;
                    }
                    tabPagePathList[tabWindow.SelectedIndex] = currentPath;
                    tabWindow.TabPages[tabWindow.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
                }
            }
        }


        /// <summary>
        /// Zip files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZipEvent(object sender, EventArgs e)
        {
            try
            {
                if (listViewFolderContent.SelectedItems.Count == 0) return;
                string FirstItemName = listViewFolderContent.SelectedItems[0].SubItems[0].Text;
                string ZipFilePath = 
                    currentPath + "\\" + FirstItemName.Split('.').ToList().ElementAt(0) + ".zip";

                using (FileStream fs = new FileStream(ZipFilePath, FileMode.Create))
                {
                    using (ZipArchive newZipFile = new ZipArchive(fs, ZipArchiveMode.Update))
                    {
                        foreach (ListViewItem item in listViewFolderContent.SelectedItems)
                        {
                            string itemPath = currentPath + "\\" + item.SubItems[0].Text;
                            HelperMethods.CreateEntryFromAny(newZipFile, itemPath);
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
        private void UnzipEvent(object sender, EventArgs e)
        {
            try
            {
                if (listViewFolderContent.SelectedItems.Count == 0) return;
                string ZipItemName;
                string ZipItemPath;
                foreach (ListViewItem item in listViewFolderContent.SelectedItems)
                {
                    ZipItemName = item.SubItems[0].Text;
                    ZipItemPath = currentPath + "\\" + ZipItemName;
                    if (System.IO.Path.GetExtension(ZipItemPath).Equals(".zip"))
                    {
                        string destinationPath = currentPath + "\\" + ZipItemName.Replace(".zip", "");
                        if (!File.Exists(destinationPath) && !Directory.Exists(destinationPath))
                            ZipFile.ExtractToDirectory(ZipItemPath, destinationPath);

                        else
                        {
                            int SameNameCount = 1;
                            string OriginalItemName = ZipItemName.Replace(".zip","");
                            string newItemName = OriginalItemName;
                            foreach (ListViewItem LVitem in listViewFolderContent.Items)
                                if (LVitem.SubItems[0].Text.ToString().Contains(OriginalItemName))
                                {
                                    newItemName = OriginalItemName + SameNameCount.ToString();
                                    SameNameCount++;
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


        private void DarkModeEvent(object sender, EventArgs e)
        {
            if (!isInDarkMode)
            {
                isInDarkMode = true;
                PrimaryTextColor = Color.White;
                HoverColor = Color.FromArgb(60, 60, 60);
                UnfocusedSelectColor = Color.FromArgb(75, 75, 75);
                FocusedSelectColor = Color.FromArgb(100, 100, 100);
                PrimaryBackgroundColor = Color.FromArgb(39, 39, 39);
                SecondaryBackgroundColor = Color.FromArgb(45, 45, 45);

                foreach (Control control in this.Controls)
                {
                    UpdateControlsColor(control, PrimaryBackgroundColor, PrimaryTextColor);
                }

                treeViewFolderTree.BackColor = SecondaryBackgroundColor;

                UpdateControlsColor(contextMenuStripListView, PrimaryBackgroundColor, PrimaryTextColor);
                UpdateControlsColor(contextMenuStripListViewItem, PrimaryBackgroundColor, PrimaryTextColor);
                UpdateControlsColor(contextMenuStripTreeView, PrimaryBackgroundColor, PrimaryTextColor);

                btnBack.Image = Properties.Resources.Icon_Back_DarkMode;
                btnRefresh.Image = Properties.Resources.Icon_Refresh_DarkMode;

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
                    UpdateControlsColor(control, PrimaryBackgroundColor, PrimaryTextColor);
                }
                treeViewFolderTree.BackColor = SecondaryBackgroundColor;

                UpdateControlsColor(contextMenuStripListView, PrimaryBackgroundColor, PrimaryTextColor);
                UpdateControlsColor(contextMenuStripListViewItem, PrimaryBackgroundColor, PrimaryTextColor);
                UpdateControlsColor(contextMenuStripTreeView, PrimaryBackgroundColor, PrimaryTextColor);

                btnBack.Image = Properties.Resources.Icon_Back;
                btnRefresh.Image = Properties.Resources.Icon_Refresh;
                this.Refresh();
            }

        }

        /// <summary>
        /// Recursively change the background and foreground color of a control and its sub-controls
        /// </summary>
        /// <param name="control"></param>
        /// <param name="BackColor"></param>
        /// <param name="ForeColor"></param>
        public void UpdateControlsColor(Control control, Color BackColor, Color ForeColor)
        {
            control.BackColor = BackColor;
            control.ForeColor = ForeColor;
            foreach (Control subControl in control.Controls)
            {
                UpdateControlsColor(subControl, BackColor, ForeColor);
            }
        }


        #endregion


        #region App feature: Tabs control

        /// <summary>
        /// Delete tab if user has clicked the close sign on tab header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabWindow_MouseDown(object sender, MouseEventArgs e)
        {
            int imageSize = 16;
            for (var i = 0; i < tabWindow.TabPages.Count; i++)
            {
                var tabHeaderRect = tabWindow.GetTabRect(i);
                var imageRect = new Rectangle(
                    (tabHeaderRect.Right - imageSize - 4),
                    tabHeaderRect.Top + (tabHeaderRect.Height - imageSize) / 2,
                    imageSize,
                    imageSize);

                if (imageRect.Contains(e.Location))
                {
                    tabWindow.TabPages.RemoveAt(i);
                    tabPagePathList.RemoveAt(i);
                    break;
                }
            }
        }

        private void tabWindow_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // If clicked on the last tab header (tab with the plus sign), create a new tab
            if (e.TabPageIndex == tabWindow.TabCount - 1)
            {
                int lastTabIndex = tabWindow.TabCount - 1;
                tabWindow.TabPages.Insert(lastTabIndex, new TabPage("My Computer" + spaceText));
                tabPagePathList.Insert(lastTabIndex, "My Computer");
                tabWindow.SelectedIndex = lastTabIndex;
            }
            else
            {
                string tabPath = tabPagePathList[e.TabPageIndex];
                e.TabPage.Controls.Add(listViewFolderContent);
                e.TabPage.Controls.Add(tableLayoutFirstPage);
                if (tabPath == "My Computer")
                {
                    tableLayoutFirstPage.Visible = true;
                    listViewFolderContent.Visible = false;
                }
                else
                {
                    clsTreeListView.ShowFolderContent(
                        listViewFolderContent, tabPagePathList[e.TabPageIndex]);
                    tableLayoutFirstPage.Visible = false;
                    listViewFolderContent.Visible = true;
                }
                tscmbPath.Text = tabPath;
            }
        }
        #endregion


        #region TreeView design


        /// <summary>
        /// Load folder tree onto treeView and show listViewFolderContent
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
                if (!clsTreeListView.ShowFolderTree(treeViewFolderTree, currentNode, isSpecialFolder, SpecialFolderPath)) return;

                if (currentNode.Text == "My Computer" && currentNode.Parent == null)
                {
                    tableLayoutFirstPage.Visible = true;
                    listViewFolderContent.Visible = false;
                    tscmbPath.Text = currentNode.Text;
                }
                else
                {
                    if (currentNode.Text == "Easy Access" && currentNode.Parent == null)
                    {
                        currentNode.Expand();
                        return;
                    }
                    if (SpecialFolderPath == "")
                    {
                        clsTreeListView.ShowFolderContent(listViewFolderContent, currentNode);
                        tscmbPath.Text = HelperMethods.GetApproriatePath(currentNode.FullPath);
                    }
                    else
                    {
                        clsTreeListView.ShowFolderContent(listViewFolderContent, SpecialFolderPath);
                        tscmbPath.Text = SpecialFolderPath;
                    }
                    tableLayoutFirstPage.Visible = false;
                    listViewFolderContent.Visible = true;
                }

                currentPath = tscmbPath.Text;

                tabPagePathList[tabWindow.SelectedIndex] = currentPath;
                tabWindow.TabPages[tabWindow.SelectedIndex].Text =
                    HelperMethods.GetFileFolderName(currentPath) + spaceText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                g.FillRectangle(new SolidBrush(HoverColor), e.Bounds);

            // Change node's background color and move the small purple panel when selected
            if (e.Node.IsSelected)
            {
                Brush selectBrush;
                if (e.Node.TreeView.Focused)
                    selectBrush = new SolidBrush(FocusedSelectColor);
                else
                    selectBrush = new SolidBrush(UnfocusedSelectColor);
                g.FillRectangle(selectBrush, e.Bounds);

                Rectangle smallPanel = new Rectangle(e.Bounds.Right - 10, e.Bounds.Y, 10, e.Bounds.Height);
                g.FillRectangle(new SolidBrush(Color.BlueViolet), smallPanel);
            }

            // Draw expand/collapse chevrons
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.IsExpanded)
                    g.DrawImage(
                        Properties.Resources.Icon_ExpandChevron,
                        nodeRect.X - 40,
                        nodeRect.Y + 16, 16, 16);
                else
                    g.DrawImage(
                        Properties.Resources.Icon_NormalChevron,
                        nodeRect.X - 40,
                        nodeRect.Y + 16, 16, 16);
            }

            //Draw node icon
            g.DrawImage(
                HelperMethods.GetNodeTypeIcon(e.Node),
                nodeRect.Location.X - 14,
                nodeRect.Location.Y + 8, 30, 30);

            //Draw text
            if (e.Node.Bounds.X != 0)
                TextRenderer.DrawText(g, e.Node.Text,
                    ((TreeView)sender).Font, new Point(nodeRect.Location.X + 20, nodeRect.Location.Y + 8), PrimaryTextColor);
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
                treeViewFolderTree.SelectedNode = treeViewFolderTree.GetNodeAt(e.Location);
                if (treeViewFolderTree.SelectedNode != null)
                    contextMenuStripTreeView.Show((TreeView)sender, e.Location);
            }
        }


        /// <summary>
        /// Pin folder to easy access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PinFolderEvent(object sender, EventArgs e)
        {
            if (treeViewFolderTree.Focused)
            {
                if (treeViewFolderTree.SelectedNode != null && treeViewFolderTree.SelectedNode.Parent != null && clsTreeListView.GetTreeNodeRoot(treeViewFolderTree.SelectedNode).Text != "Easy Access")
                {
                    string NodeToAddPath = HelperMethods.GetApproriatePath(treeViewFolderTree.SelectedNode.FullPath);
                    if (clsTreeListView.EasyAccessFolderPathList.Any(EasyAccessFolderPath => EasyAccessFolderPath == NodeToAddPath)) return;

                    clsTreeListView.EasyAccessFolderPathList.Add(NodeToAddPath);

                    treeViewFolderTree.Nodes[1].Nodes.Add(treeViewFolderTree.SelectedNode.Text);
                }
                treeViewFolderTree.Nodes[1].Expand();
            }
            else if (listViewFolderContent.Focused)
            {
                if (listViewFolderContent.SelectedItems.Count != 0)
                {
                    foreach (ListViewItem item in listViewFolderContent.SelectedItems)
                    {
                        string itemPath = HelperMethods.GetApproriatePath(item.SubItems[5].Text);
                        // If a folder already exists in "easy access" node then return
                        if (item.SubItems[1].Text != "Folder" || clsTreeListView.EasyAccessFolderPathList.Any(EasyAccessFolderPath => EasyAccessFolderPath == itemPath)) return;

                        clsTreeListView.EasyAccessFolderPathList.Add(itemPath);
                        treeViewFolderTree.Nodes[1].Nodes.Add(item.SubItems[0].Text);
                    }
                    treeViewFolderTree.Refresh();
                }
            }
        }


        /// <summary>
        /// Unpin folder from easy access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnpinFolderEvent(object sender, EventArgs e)
        {
            if (treeViewFolderTree.SelectedNode != null && clsTreeListView.GetTreeNodeRoot(treeViewFolderTree.SelectedNode).Text == "Easy Access")
            {
                clsTreeListView.EasyAccessFolderPathList.RemoveAt(treeViewFolderTree.SelectedNode.Index);
                treeViewFolderTree.Nodes[1].Nodes.RemoveAt(treeViewFolderTree.SelectedNode.Index);
            }
        }

        #endregion


        #region ListView design

        /// <summary>
        /// Set listViewFolderContent display to large icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLarge_Click(object sender, EventArgs e)
        {
            listViewFolderContent.OwnerDraw = true;
            listViewFolderContent.View = View.LargeIcon;
            clsTreeListView.SetListViewItemSizeLargeIcon(listViewFolderContent, 70, 70);
        }


        /// <summary>
        /// Set listViewFolderContent display to small icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSmall_Click(object sender, EventArgs e)
        {
            listViewFolderContent.OwnerDraw = true;
            listViewFolderContent.View = View.SmallIcon;
            clsTreeListView.SetListViewItemSizeSmallIcon(listViewFolderContent, 100, 30);
        }


        /// <summary>
        /// Set listViewFolderContent display to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuList_Click(object sender, EventArgs e)
        {
            listViewFolderContent.OwnerDraw = true;
            listViewFolderContent.View = View.List;
        }


        /// <summary>
        /// Set listViewFolderContent display to details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDetails_Click(object sender, EventArgs e)
        {
            listViewFolderContent.OwnerDraw = true;
            listViewFolderContent.View = View.Details;
        }


        /// <summary>
        /// Customize appearance of listViewFolderContent column headers to developer's need
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
            Pen BorderPen = new Pen(Color.FromArgb(186, 186, 186), 1.5f);
            e.Graphics.DrawLine(BorderPen, new Point(e.Bounds.X + 25, e.Bounds.Y - 5 + e.Bounds.Height), new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y - 5 + e.Bounds.Height));
        }


        /// <summary>
        ///  Customize appearance of listViewFolderContent items to developer's need
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Rectangle itemRect = e.Item.Bounds;
            Graphics g = e.Graphics;

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

            // Specify how to draw listViewFolderContent items in each view mode
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

        /*            if (e.State == ListViewItemStates.Hot)
            {
                Brush hoverBrush = new SolidBrush(HoverColor);
                g.FillRectangle(hoverBrush, e.Bounds);
            }
        */
        /// <summary>
        /// Customize appearance of listViewFolderContent subitems to developer's need
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {

            ListView listViewIdentifier = sender as ListView;
            bool isListViewRecentAccessFiles = false;
            int SubItemPathIndex = 5;
            if (listViewIdentifier.Columns.Count == 2) isListViewRecentAccessFiles = true;

            Rectangle itemRect = e.Item.Bounds;
            Graphics g = e.Graphics;
            if (isListViewRecentAccessFiles) SubItemPathIndex = 1;
            if (e.Item.SubItems[1].Text == "Folder")
            {
                g.DrawImage(Properties.Resources.Icon_Folder, e.Item.Bounds.X + 20, e.Item.Bounds.Y, 30, 30);
            }
            else
            {
                FileInfo itemPath = new FileInfo(e.Item.SubItems[SubItemPathIndex].Text);
                g.DrawImage(HelperMethods.GetFileTypeIcon(itemPath), e.Item.Bounds.X + 20, e.Item.Bounds.Y, 30, 30);
            }

            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis
                | TextFormatFlags.ExpandTabs | TextFormatFlags.SingleLine
                | TextFormatFlags.VerticalCenter;

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
        /// Show approriate contextMenuStrip when right clicking on listViewFolderContent
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
            clsTreeListView.ClickItem(listViewFolderContent, listViewFolderContent.SelectedItems[0], tscmbPath, false);
            clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
            currentPath = tscmbPath.Text;
        }

        /// <summary>
        /// Fix the "listViewFolderContent last column's white area in DarkMode" when resizing a column header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == listViewFolderContent.Columns.Count - 1)
            {
                e.NewWidth = -2;
            }
            else
            {
                listViewFolderContent.Columns[listViewFolderContent.Columns.Count - 1].Width = -2;
            }
        }


        /// <summary>
        /// Fix the "listViewFolderContent last column's white area in DarkMode" when resizing a column header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewRecentFiles_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == listViewRecentFiles.Columns.Count - 1)
            {
                e.NewWidth = -2;
            }
            else
            {
                listViewRecentFiles.Columns[listViewRecentFiles.Columns.Count - 1].Width = -2;
            }
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
            clsTreeListView.ShowRecentAccessedFiles(listViewRecentFiles);
            btnRefresh.PerformClick();
        }

        /// <summary>
        /// Change background color of hovered drive panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drivePanel_MouseEnter(object sender, EventArgs e)
        {
            Control drivePanelChildControls = sender as Control;
            Panel drivePanel = (Panel)drivePanelChildControls.Parent;
            foreach (Control child in drivePanel.Controls)
            {
                child.BackColor = UnfocusedSelectColor;
            }
            drivePanel.BackColor = UnfocusedSelectColor;
            Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Change background color of unhovered drive panels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drivePanel_MouseLeave(object sender, EventArgs e)
        {
            Control drivePanelChildControls = sender as Control;
            Panel drivePanel = (Panel)drivePanelChildControls.Parent;
            if (!drivePanel.ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                foreach (Control Child in drivePanel.Controls)
                {
                    Child.BackColor = PrimaryBackgroundColor;
                }
            }
            drivePanel.BackColor = PrimaryBackgroundColor;
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Go to the approriate hard disk when clicking on a drive panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drivePanel_Click(object sender, EventArgs e)
        {
            Control drivePanelChildControls = sender as Control;
            Panel drivePanel = (Panel)drivePanelChildControls.Parent;
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drivePanel.Controls[1].Text.Contains(drive.Name.ToString().Replace("\\", "")))
                {
                    currentPath = drive.Name;
                    tscmbPath.Text = drive.Name;
                    tabPagePathList[tabWindow.SelectedIndex] = currentPath;
                    tabWindow.TabPages[tabWindow.SelectedIndex].Text = HelperMethods.GetFileFolderName(currentPath) + spaceText;
                    clsTreeListView.ShowFolderContent(listViewFolderContent, currentPath);
                    tableLayoutFirstPage.Visible = false;
                    listViewFolderContent.Visible = true;
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
            statusLblItemNum.Text = listViewFolderContent.Items.Count.ToString() + " items";
            if (currentPath == "My Computer")
            {
                foreach (Panel drivePanel in drivePanelList)
                {

                    foreach (Control control in drivePanel.Controls)
                    {
                        control.MouseEnter += drivePanel_MouseEnter;
                        control.MouseLeave += drivePanel_MouseLeave;
                        control.Click += drivePanel_Click;
                    }
                }
            }

            tabWindow.TabPages[tabWindow.SelectedIndex].Text = HelperMethods.GetFileFolderName(tabPagePathList[tabWindow.SelectedIndex]) + spaceText;
        }


        /// <summary>
        /// Show number of selected listViewFolderContent items on status strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            statusLblNumSelect.Text = listViewFolderContent.SelectedItems.Count.ToString() + " items selected   ";
        }








        #endregion

    }
}
