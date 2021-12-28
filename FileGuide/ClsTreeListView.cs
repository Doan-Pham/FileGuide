using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows;
using System.Reflection;

using System.IO.Compression;

namespace FileGuide
{
    class ClsTreeListView
    {
        // Each type of drive is paired with respective number from DriveType enum 
        const int RemovableDisk = 2;
        const int LocalDisk = 3;
        const int NetworkDisk = 4;
        const int CDDisk = 5;
        const int MaxRecentFilesShown = 10;
        public List<string> RecentFilesPathList = new List<string>();
        public List<string> EasyAccessFolderPathList = new List<string>();


        #region TreeView Main Methods

        /// <summary>
        /// Initialize treeViewFolderTree
        /// </summary>
        /// <param name="treeViewFolderTree"></param>
        public void CreateTreeView(TreeView treeViewFolderTree)
        {
            treeViewFolderTree.Nodes.Clear();

            // Create root treeNode - My Computer and add to treeViewFolderTree
            TreeNode tnMyComputer = new TreeNode("My Computer");
            treeViewFolderTree.Nodes.Add(tnMyComputer);

            // Create a treeNode for each drive on computer then add to root treeNode
            foreach (var drive in DriveInfo.GetDrives())
                tnMyComputer.Nodes.Add(new TreeNode(drive.Name, 0, 0));

            // Add all the special folders to treeViewFolderTree
            TreeNode tnEasyAccess = new TreeNode("Easy Access");
            treeViewFolderTree.Nodes.Add(tnEasyAccess);
            treeViewFolderTree.Nodes.Add("Desktop");
            treeViewFolderTree.Nodes.Add("Downloads");
            treeViewFolderTree.Nodes.Add("Documents");

            //Read list of folders in easy access into a list, then foreach of these, add a node to easy access
            string DebugDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string EasyAccessDirectory = Path.Combine(DebugDirectory, "EasyAccess");
            string EasyAccessFoldersTxt = Path.Combine(EasyAccessDirectory, "EasyAccessFolders.txt");

            if (File.Exists(EasyAccessFoldersTxt))
            {
                EasyAccessFolderPathList.Clear();
                EasyAccessFolderPathList.AddRange(File.ReadAllLines(EasyAccessFoldersTxt));
            }

            foreach (string folderPath in EasyAccessFolderPathList)
                tnEasyAccess.Nodes.Add(HelperMethods.GetFileFolderName(folderPath));
        }


        /// <summary>
        /// Show computer's folder tree onto treeViewFolderTree
        /// </summary>
        /// <param name="treeViewFolderTree"></param>
        /// <param name="currentNode">The treeNode at which to show folder tree</param>
        /// <returns></returns>
        public bool ShowFolderTree(TreeView treeViewFolderTree, TreeNode currentNode, 
            bool isSpecialFolder, string SpecialFolderPath)
        {
            // My Computer and its children are already created in CreateTreeView method, recreating will cause an error
            if (currentNode.Parent == null) return true;
            try
            {
                if (!Directory.Exists(HelperMethods.GetApproriatePath
                    (currentNode.FullPath)) && !isSpecialFolder)
                {
                    MessageBox.Show("Directory not found", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    currentNode.Nodes.Clear();
                    // Add all child directories of the current's node to treeViewFolderTree 
                    string[] strDirectories;
                    if (!isSpecialFolder)
                        strDirectories = Directory.GetDirectories
                            (HelperMethods.GetApproriatePath(currentNode.FullPath));
                    else
                        strDirectories = Directory.GetDirectories(SpecialFolderPath);
                    foreach (string stringDir in strDirectories)
                    {
                        string strName = HelperMethods.GetFileFolderName(stringDir);
                        TreeNode nodeDir = new TreeNode(strName, 5, 6);
                        currentNode.Nodes.Add(nodeDir);
                    }
                }
                return true;
            }
            catch (IOException)
            {
                MessageBox.Show("Directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You might not have permission to access this directory",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured \n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        #endregion

        #region TreeView Helper Methods

        /// <summary>
        /// Return the root node of a treeViewFolderTree node
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        public TreeNode GetTreeNodeRoot(TreeNode treeNode)
        {
            while (treeNode.Parent != null)
            {
                treeNode = treeNode.Parent;
            }
            return treeNode;
        }


        /// <summary>
        /// Return a DirectoryInfo from a treeViewFolderTree node
        /// </summary>
        /// <param name="currentNode"></param>
        /// <returns></returns>
        public DirectoryInfo GetDirectoryInfoFromNode(TreeNode currentNode)
        {
            string[] strList = currentNode.FullPath.Split('\\');
            string strPath = strList.GetValue(1).ToString();
            for (int i = 2; i < strList.Length; i++)
            {
                strPath += strList.GetValue(i) + "\\";
            }
            return new DirectoryInfo(strPath);
        }


        #endregion


        #region ListView Main Methods

        /// <summary>
        /// Show a folder's content onto listView
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="currentNode">The treeNode at which to show content</param>
        public void ShowFolderContent(ListView listView, TreeNode currentNode)
        {
            try
            {
                if (currentNode.Text == "Easy Access" && GetTreeNodeRoot(currentNode).Text == "Easy Access") return;
                DirectoryInfo directory = GetDirectoryInfoFromNode(currentNode);
                ShowFolderContent(listView, directory.FullName);
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured  \n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Show a folder's content onto listViewFolderContent 
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="strPath">The directory's path at which to show content</param>
        public void ShowFolderContent(ListView listView, string strPath)
        {
            try
            {
                listView.Items.Clear();
                DirectoryInfo directory = new DirectoryInfo(strPath);
                if (!directory.Exists)
                {
                    MessageBox.Show("Folder does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DirectoryInfo folder in directory.GetDirectories())
                    listView.Items.Add(GetListViewItem(folder));

                foreach (FileInfo file in directory.GetFiles())
                    listView.Items.Add(GetListViewItem(file));

                // Reset the last column's width to avoid the last-column-white-area bug in Dark Mode
                listView.Columns[listView.Columns.Count - 1].Width = -2;
            }

            catch (Exception e)
            {
                MessageBox.Show("An error has occured \n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region ListView Helper Methods


        /// <summary>
        /// Return a listViewItem from a folder
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public ListViewItem GetListViewItem(DirectoryInfo folder)
        {
            string[] item = new string[6];
            item[0] = folder.Name;
            item[1] = "Folder";
            item[2] = "";//HelperMethods.FormatStorageLengthBytes(GetFolderSize(folder.FullName));
            item[3] = folder.CreationTime.ToString();
            item[4] = folder.LastWriteTime.ToString();
            item[5] = folder.FullName;

            ListViewItem newItem = new ListViewItem(item);
            return newItem;
        }


        /// <summary>
        /// Return a listViewItem from a file
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public ListViewItem GetListViewItem(FileInfo file)
        {
            string[] item = new string[6];
            item[0] = file.Name;
            item[1] = HelperMethods.GetFileType(file);
            item[2] = HelperMethods.FormatStorageLengthBytes(file.Length);
            item[3] = file.CreationTime.ToString();
            item[4] = file.LastWriteTime.ToString();
            item[5] = file.FullName;

            ListViewItem newItem = new ListViewItem(item);
            return newItem;
        }


        /// <summary>
        /// Set width, height of listView item in large icon view mode
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="height"></param>
        /// 
        public void SetListViewItemSizeLargeIcon(ListView listView, int width, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(width, height);
            listView.LargeImageList = imgList;
        }


        /// <summary>
        /// Set width, height of listView item in small icon view mode
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="height"></param>
        /// 
        public void SetListViewItemSizeSmallIcon(ListView listView, int width, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(width, height);
            listView.SmallImageList = imgList;
        }


        #endregion


        #region FirstPage Main Methods

        /// <summary>
        /// Initialize first page
        /// </summary>
        /// <param name="flowLayoutPanelDrives"></param>
        /// <param name="listViewRecentFiles"></param>
        /// <param name="drivePanelList"></param>
        public void CreateFirstPage(FlowLayoutPanel flowLayoutPanelDrives, ListView listViewRecentFiles, List<Panel> drivePanelList)
        {     
            // Read list of recent accessed files from .txt file into a list
            string DebugDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string RecentDirectory = Path.Combine(DebugDirectory, "RecentAccessesFiles");
            string RecentFilesTxt = Path.Combine(RecentDirectory, "RecentAccessedFiles.txt");
            if (File.Exists(RecentFilesTxt))
            {
                RecentFilesPathList.Clear();
                RecentFilesPathList.AddRange(File.ReadAllLines(RecentFilesTxt));
            }

            ShowDrivePanels(flowLayoutPanelDrives, drivePanelList);
            ShowRecentAccessedFiles(listViewRecentFiles);
        }

        /// <summary>
        /// Show the listView first page whenever the root node-My Computer is focused
        /// </summary>
        /// <param name="flowLayoutDrivePanels"></param>
        public void ShowFirstPage(FlowLayoutPanel flowLayoutDrivePanels, ListView listViewRecentFiles, List<Panel> drivePanelList)
        {
            ShowDrivePanels(flowLayoutDrivePanels, drivePanelList);
            ShowRecentAccessedFiles(listViewRecentFiles);
        }

        public void ShowDrivePanels(FlowLayoutPanel flowLayoutDrivePanels, List<Panel> drivePanelList)
        {
            // For each drive, create a panel with icon, name, and storage information then add to listView first page
            int driveCount = 0;
            foreach (var drive in DriveInfo.GetDrives())
            {
                long freeSpace = drive.TotalFreeSpace;
                long totalSpace = drive.TotalSize;
                double percentFree = freeSpace * 100.0 / totalSpace;

                PictureBox DrivePicture = new PictureBox();
                Label DriveName = new Label();
                Label DriveStorageInfo = new Label();
                FileGuide.CustomControls.CustomProgressBar DriveStorageBar 
                    = new FileGuide.CustomControls.CustomProgressBar();
                Panel EmptySpaceFillPanel = new Panel();

                drivePanelList.Add(new Panel());
                drivePanelList[driveCount].Margin = new Padding(10);
                drivePanelList[driveCount].BorderStyle = BorderStyle.FixedSingle;
                drivePanelList[driveCount].Padding = new Padding(10);
                drivePanelList[driveCount].Width = 390;
                drivePanelList[driveCount].Height = 125;

                DriveStorageBar.Dock = DockStyle.Left;
                DriveStorageBar.Width = 250;
                DriveStorageBar.Height = 15;
                DriveStorageBar.Style = ProgressBarStyle.Continuous;
                DriveStorageBar.FirstColor = FrmMain.PrimaryThemeColor;
                DriveStorageBar.SecondColor = FrmMain.SecondaryThemeColor;
                DriveStorageBar.Value = 100 - (int)percentFree;
                drivePanelList[driveCount].Controls.Add(DriveStorageBar);

                DriveName.Dock = DockStyle.Top;
                DriveName.Height = 40;
                DriveName.TextAlign = ContentAlignment.MiddleLeft;
                DriveName.Text = drive.VolumeLabel.ToString() + " (" + drive.Name.ToString() + ")";
                drivePanelList[driveCount].Controls.Add(DriveName);

                DriveStorageInfo.Dock = DockStyle.Bottom;
                DriveStorageInfo.TextAlign = ContentAlignment.MiddleLeft;
                DriveStorageInfo.Height = 45;
                DriveStorageInfo.Text = HelperMethods.FormatStorageLengthBytes(freeSpace) + " free of " + HelperMethods.FormatStorageLengthBytes(totalSpace);
                drivePanelList[driveCount].Controls.Add(DriveStorageInfo);

                DrivePicture.Image = HelperMethods.GetDriveTypeIcon(drive);
                DrivePicture.SizeMode = PictureBoxSizeMode.Zoom;
                DrivePicture.Width = 80;
                DrivePicture.Dock = DockStyle.Left;
                drivePanelList[driveCount].Controls.Add(DrivePicture);

                EmptySpaceFillPanel.Width = drivePanelList[driveCount].Width - DriveStorageBar.Width - DrivePicture.Width;
                EmptySpaceFillPanel.Dock = DockStyle.Right;
                drivePanelList[driveCount].Controls.Add(EmptySpaceFillPanel);

                flowLayoutDrivePanels.Controls.Add(drivePanelList[driveCount]);
                driveCount++;
            }
        }

        /// <summary>
        /// Show list of recent accessed files onto listView first page
        /// </summary>
        /// <param name="RecentFiles"></param>
        public void ShowRecentAccessedFiles(ListView listViewRecentFiles)
        {
            listViewRecentFiles.Items.Clear();
            foreach (string ItemPath in RecentFilesPathList)
            {
                string[] items = new string[2];
                items[0] = HelperMethods.GetFileFolderName(ItemPath);
                items[1] = ItemPath;
                ListViewItem item = new ListViewItem(items);
                listViewRecentFiles.Items.Add(item);
            }
            listViewRecentFiles.Columns[listViewRecentFiles.Columns.Count - 1].Width = -2;
        }

        #endregion


        #region Features Methods


        /// <summary>
        /// Process an item: Run if a file, open if a folder
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="CurrentItem"></param>
        /// <returns></returns>
        public bool ClickItem(ListView listView, ListViewItem CurrentItem, ToolStripComboBox tscmbPath, bool isRecenFilesListView)
        {
            try
            {
                string path = CurrentItem.SubItems[CurrentItem.SubItems.Count - 1].Text;
                FileInfo fi = new FileInfo(path);

                if (fi.Exists)
                {
                    Process.Start(path);
                    RecentFilesPathList.Insert(0, path);


                    if (RecentFilesPathList.Count != 0 && path == RecentFilesPathList[0]) return true;
                    if (RecentFilesPathList.Count >= MaxRecentFilesShown) RecentFilesPathList.RemoveAt(RecentFilesPathList.Count - 1);
                }
                else
                {
                    if (!isRecenFilesListView)
                    {
                        ShowFolderContent(listView, path);
                        tscmbPath.Text = HelperMethods.GetApproriatePath(path);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured \n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        #endregion



    }
}

