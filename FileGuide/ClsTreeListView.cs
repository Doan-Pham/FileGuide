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
using Guna.UI2.WinForms;
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
        public List<string> ListRecentFiles = new List<string>();
        public List<string> EasyAccessFolderPathList = new List<string>();


        #region TreeView Main Methods

        /// <summary>
        /// Initialize treeView
        /// </summary>
        /// <param name="treeView"></param>
        public void CreateTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();

            // Create root treenode: My Computer and add to treeView
            TreeNode tnMyComputer = new TreeNode("My Computer", 0, 0);
            treeView.Nodes.Add(tnMyComputer);

            // Select all drives into a collection then create a treenode for each drive
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();

            foreach (ManagementObject mo in queryCollection)
            {
                int DiskImageIndex, DiskSelectIndex;

                switch (int.Parse(mo["DriveType"].ToString()))
                {
                    case RemovableDisk:
                        {
                            DiskImageIndex = 1;
                            DiskSelectIndex = 1;
                        }
                        break;

                    case LocalDisk:
                        {
                            DiskImageIndex = 2;
                            DiskSelectIndex = 2;
                        }
                        break;

                    case CDDisk:
                        {
                            DiskImageIndex = 3;
                            DiskSelectIndex = 3;
                        }
                        break;

                    case NetworkDisk:
                        {
                            DiskImageIndex = 4;
                            DiskSelectIndex = 4;
                        }
                        break;

                    default:
                        {
                            DiskImageIndex = 5;
                            DiskSelectIndex = 6;
                        }
                        break;

                }

                TreeNode diskTreeNode = new TreeNode(mo["Name"].ToString() + "\\", DiskImageIndex, DiskSelectIndex);
                tnMyComputer.Nodes.Add(diskTreeNode);
            }

            // Add all the special folders to treeView
            TreeNode tnEasyAccess = new TreeNode("Easy Access");
            treeView.Nodes.Add(tnEasyAccess);
            treeView.Nodes.Add("Desktop");
            treeView.Nodes.Add("Downloads");
            treeView.Nodes.Add("Documents");

            //Read list of folders in easy access into a list, then foreach of these, add a node to easy access
            string DebugDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string EasyAccessDirectory = Path.Combine(DebugDirectory, "EasyAccess");
            string EasyAccessFoldersTxt = Path.Combine(EasyAccessDirectory, "EasyAccessFolders.txt");
            if (File.Exists(EasyAccessFoldersTxt))
                EasyAccessFolderPathList.AddRange(File.ReadAllLines(EasyAccessFoldersTxt));

            foreach (string folderPath in EasyAccessFolderPathList)
            {
                tnEasyAccess.Nodes.Add(HelperMethods.GetFileFolderName(folderPath));
            }
        }


        /// <summary>
        /// Show computer's folder tree onto treeView
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="currentNode">The treenode at which to show folder tree</param>
        /// <returns></returns>
        public bool ShowFolderTree(TreeView treeView, TreeNode currentNode, bool isSpecialFolder, string SpecialFolderPath)
        {
            // My Computer and its children are already created in CreatTreeView func, recreating will cause an error
            if (currentNode.Text == GetTreeNodeRoot(currentNode).Text || GetTreeNodeRoot(currentNode).Text == "Easy Access") return true;
            try
            {
                if (!Directory.Exists(HelperMethods.GetApproriatePath(currentNode.FullPath)) && !isSpecialFolder)
                {
                    MessageBox.Show("Directory not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    // Add all child directories of the current's node to treeView 
                    string[] strDirectories;
                    if (!isSpecialFolder)
                    {
                        strDirectories = Directory.GetDirectories(HelperMethods.GetApproriatePath(currentNode.FullPath));
                    }
                    else
                    {
                        strDirectories = Directory.GetDirectories(SpecialFolderPath);
                    }
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
        /// Return the root node of a treeView node
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
        /// Return a DirectoryInfo from a treeView node
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
        /// <param name="currentNode">The treenode at which to show content</param>
        public void ShowListView(ListView listView, TreeNode currentNode)
        {
            try
            {
                if (currentNode.Text == "Easy Access" && GetTreeNodeRoot(currentNode).Text == "Easy Access") return;
                // Clear listView to show content
                listView.Items.Clear();

                // Get Directory Info from the current node, if existing, add directory and its children to listView
                ListViewItem item;
                DirectoryInfo directory = GetDirectoryInfoFromNode(currentNode);
                if (!directory.Exists)
                {
                    MessageBox.Show("Folder does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DirectoryInfo folder in directory.GetDirectories())
                {
                    item = GetListViewItem(folder);
                    listView.Items.Add(item);
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    item = GetListViewItem(file);
                    listView.Items.Add(item);
                };

            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured  \n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Show a folder's content onto listView 
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="strPath">The directory's path at which to show content</param>
        public void ShowListView(ListView listView, string strPath)
        {
            try
            {
                ListViewItem item;
                DirectoryInfo directory = new DirectoryInfo(strPath);
                listView.Items.Clear();
                foreach (DirectoryInfo folder in directory.GetDirectories())
                {
                    item = GetListViewItem(folder);
                    listView.Items.Add(item);
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    item = GetListViewItem(file);
                    listView.Items.Add(item);
                };
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
        /// Show the listView first page whenever the root node-My Computer is focused
        /// </summary>
        /// <param name="flowLayoutPanelDrives"></param>
        public void ShowFirstPage(FlowLayoutPanel flowLayoutPanelDrives, ListView RecentFiles, List<Panel> DrivePanel)
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
                Guna2ProgressBar DriveStorageBar = new Guna2ProgressBar();
                Panel EmptySpaceFillPanel = new Panel();

                DrivePanel.Add(new Panel());
                DrivePanel[driveCount].Margin = new Padding(10);
                DrivePanel[driveCount].BorderStyle = BorderStyle.FixedSingle;
                DrivePanel[driveCount].Padding = new Padding(10);
                DrivePanel[driveCount].Width = 390;
                DrivePanel[driveCount].Height = 125;
                DrivePanel[driveCount].Margin = new Padding(3, 10, 20, 10);

                switch (drive.DriveType.ToString())
                {
                    case "Removable":
                        {
                            DrivePicture.Image = Properties.Resources.Icon_FloppyDisk;
                        }
                        break;

                    case "Fixed":
                        {
                            DrivePicture.Image = Properties.Resources.Icon_HardDisk;
                        }
                        break;

                    case "CDRom":
                        {
                            DrivePicture.Image = Properties.Resources.Icon_CDDisk;
                        }
                        break;

                    case "Network":
                        {
                            DrivePicture.Image = Properties.Resources.Icon_NetworkDrive;
                        }
                        break;

                    default:
                        {
                            DrivePicture.Image = Properties.Resources.Icon_HardDisk;
                        }
                        break;
                }

                DriveStorageBar.Dock = DockStyle.Left;
                DriveStorageBar.BorderRadius = 5;
                DriveStorageBar.Width = 250;
                DriveStorageBar.Height = 15;
                DriveStorageBar.Style = ProgressBarStyle.Continuous;
                DriveStorageBar.ProgressColor = FrmMain.PrimaryThemeColor;
                DriveStorageBar.ProgressColor2 = FrmMain.SecondaryThemeColor;
                DriveStorageBar.Value = 100 - (int)percentFree;
                DrivePanel[driveCount].Controls.Add(DriveStorageBar);

                DriveName.Dock = DockStyle.Top;
                DriveName.Height = 40;
                DriveName.TextAlign = ContentAlignment.MiddleLeft;
                DriveName.Text = drive.VolumeLabel.ToString() + " (" + drive.Name.ToString() + ")";
                DrivePanel[driveCount].Controls.Add(DriveName);

                DriveStorageInfo.Dock = DockStyle.Bottom;
                DriveStorageInfo.TextAlign = ContentAlignment.MiddleLeft;
                DriveStorageInfo.Height = 45;
                DriveStorageInfo.Text = HelperMethods.FormatStorageLengthBytes(freeSpace) + " free of " + HelperMethods.FormatStorageLengthBytes(totalSpace);
                DrivePanel[driveCount].Controls.Add(DriveStorageInfo);

                DrivePicture.SizeMode = PictureBoxSizeMode.Zoom;
                DrivePicture.Width = 80;
                DrivePicture.Dock = DockStyle.Left;
                DrivePanel[driveCount].Controls.Add(DrivePicture);

                EmptySpaceFillPanel.Width = DrivePanel[driveCount].Width - DriveStorageBar.Width - DrivePicture.Width;
                EmptySpaceFillPanel.Dock = DockStyle.Right;
                DrivePanel[driveCount].Controls.Add(EmptySpaceFillPanel);

                flowLayoutPanelDrives.Controls.Add(DrivePanel[driveCount]);
                driveCount++;
            }
            ShowRecentAccessedFiles(RecentFiles);
        }


        /// <summary>
        /// Show list of recent accessed files onto listView first page
        /// </summary>
        /// <param name="RecentFiles"></param>
        public void ShowRecentAccessedFiles(ListView RecentFiles)
        {
            // Read list of recent accessed files into a list
            string DebugDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string RecentDirectory = Path.Combine(DebugDirectory, "RecentAccessesFiles");
            string RecentFilesTxt = Path.Combine(RecentDirectory, "RecentAccessedFiles.txt");
            if (File.Exists(RecentFilesTxt)) ListRecentFiles.AddRange(File.ReadAllLines(RecentFilesTxt));

            RecentFiles.Items.Clear();
            foreach (string ItemPath in ListRecentFiles)
            {
                string[] items = new string[2];
                items[0] = HelperMethods.GetFileFolderName(ItemPath);
                items[1] = ItemPath;
                ListViewItem item = new ListViewItem(items);
                RecentFiles.Items.Add(item);
            }
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
                    if (ListRecentFiles.Count != 0 && path == ListRecentFiles[0]) return true;
                    if (ListRecentFiles.Count >= MaxRecentFilesShown) ListRecentFiles.RemoveAt(ListRecentFiles.Count - 1);
                    ListRecentFiles.Insert(0, path);

                    string DebugDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string RecentDirectory = Path.Combine(DebugDirectory, "RecentAccessesFiles");
                    if (!Directory.Exists(RecentDirectory))
                        Directory.CreateDirectory(RecentDirectory);
                    using (StreamWriter OutputFile = new StreamWriter(RecentDirectory + @"RecentAccessedFiles.txt"))
                    {
                        foreach (string filePath in ListRecentFiles)
                            OutputFile.WriteLine(filePath);
                    }
                }
                else
                {
                    if (!isRecenFilesListView)
                    {
                        ShowListView(listView, path);
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

