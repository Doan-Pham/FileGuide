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
                tnEasyAccess.Nodes.Add(GetFileFolderName(folderPath));
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
                if (!Directory.Exists(GetApproriatePath(currentNode.FullPath)) && !isSpecialFolder)
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
                        strDirectories = Directory.GetDirectories(GetApproriatePath(currentNode.FullPath));
                    }
                    else
                    {
                        strDirectories = Directory.GetDirectories(SpecialFolderPath);
                    }
                    foreach (string stringDir in strDirectories)
                    {
                        string strName = GetFileFolderName(stringDir);
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
                MessageBox.Show(e.ToString(), "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(e.ToString(), "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(e.ToString(), "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            item[2] = "";//FormatStorageLengthBytes(GetFolderSize(folder.FullName));
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
            item[1] = GetFileType(file);
            item[2] = FormatStorageLengthBytes(file.Length);
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
        public void ShowFirstPage(FlowLayoutPanel flowLayoutPanelDrives, ListView RecentFiles, List<Guna2Panel> DrivePanel)
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

                DrivePanel.Add(new Guna2Panel());
                DrivePanel[driveCount].BorderRadius = 10;
                DrivePanel[driveCount].Margin = new Padding(10);
                DrivePanel[driveCount].Padding = new Padding(10);
                DrivePanel[driveCount].BorderThickness = 2;
                DrivePanel[driveCount].BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                DrivePanel[driveCount].BorderColor = Color.Silver;
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
                DriveStorageInfo.Text = FormatStorageLengthBytes(freeSpace) + " free of " + FormatStorageLengthBytes(totalSpace);
                DrivePanel[driveCount].Controls.Add(DriveStorageInfo);

                DrivePicture.SizeMode = PictureBoxSizeMode.Zoom;
                DrivePicture.Width = 80;
                DrivePicture.Dock = DockStyle.Left;
                DrivePanel[driveCount].Controls.Add(DrivePicture);

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
                items[0] = GetFileFolderName(ItemPath);
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
                        tscmbPath.Text = GetApproriatePath(path);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }


        #endregion


        #region General Helper Methods

        /// <summary>
        /// Return a approriate path for use in a directory structure
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public string GetApproriatePath(string strPath)
        {
            return strPath.Replace("My Computer\\", "").Replace("\\\\", "\\");
        }


        /// <summary>
        /// Return name of a file, directory (Remove parent directories)
        /// </summary>
        /// <param name="strPath">The path of the file/folder that needs modifying</param>
        /// <returns></returns>
        public string GetFileFolderName(string strPath)
        {
            string[] strSplit = strPath.Split('\\');
            if (strSplit.Length == 2 && strSplit[1] == "") return strSplit[0] + "\\";
            return strSplit[strSplit.Length - 1];
        }


        /// <summary>
        /// Return icon image respective to a file's extension
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public Image GetFileTypeIcon(FileInfo file)
        {
            switch (file.Extension.ToUpper())
            {
                case ".MDB":
                    return Properties.Resources.Logo_Database;

                case ".DOC":
                case ".DOCX":
                    return Properties.Resources.Logo_WORD;

                case ".EXE":
                    return Properties.Resources.Logo_EXE;

                case ".HTM":
                case ".HTML":
                    return Properties.Resources.Logo_HTML;

                case ".MP3":
                case ".WAV":
                case ".WMV":
                case ".ASF":
                case ".MPEG":
                case ".AVI":
                    return Properties.Resources.Logo_Music;

                case ".PDF":
                    return Properties.Resources.Logo_PDF;

                case ".JPG":
                case ".PNG":
                case ".BMP":
                case ".GIF":
                    return Image.FromFile(file.FullName);
                        //Properties.Resources.Logo_PNG;

                case ".PPT":
                case ".PPTX":
                    return Properties.Resources.Logo_PPT;

                case ".RAR":
                case ".ZIP":
                    return Properties.Resources.Logo_RAR;

                case ".SWF":
                case ".FLV":
                case ".FLA":
                    return Properties.Resources.Logo_FLASH ;

                case ".TXT":
                case ".DIZ":
                case ".LOG":
                    return Properties.Resources.Logo_Text ;

                case ".XLS":
                case ".XLSX":
                    return Properties.Resources.Logo_EXCEL;

                default:
                    return Properties.Resources.Logo_UnknownFile;

            }
        }

        public Image GetNodeTypeIcon(TreeNode node)
        {
            if (node.Parent == null)
            { 
                switch (node.Text)
                {
                    case "My Computer": return Properties.Resources.Icon_MyComputer;
                    case "Easy Access": return Properties.Resources.Icon_EasyAccess;
                    case "Desktop": return Properties.Resources.Icon_Desktop;
                    case "Downloads": return Properties.Resources.Icon_Downloads;
                    case "Documents": return Properties.Resources.Icon_Documents;
                    default: return Properties.Resources.Icon_Folder;
                }
            }
            return Properties.Resources.Icon_Folder;
        }

        /// <summary>
        /// Return a string representing the file type
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string GetFileType(FileInfo file)
        {
            switch (file.Extension.ToUpper())
            {
                case ".MDB":
                    return "Database File";

                case ".DOC":
                case ".DOCX":
                    return "Microsoft Word Document";

                case ".EXE":
                    return "Application";

                case ".HTM":
                case ".HTML":
                    return "HTML Document";

                case ".MP3":
                case ".WAV":
                case ".WMV":
                case ".ASF":
                case ".MPEG":
                case ".AVI":
                    return "Media File";

                case ".PDF":
                    return "PDF Document File";

                case ".JPG":
                case ".PNG":
                case ".BMP":
                case ".GIF":
                    return "Image File";

                case ".PPT":
                case ".PPTX":
                    return "Microsoft Powerpoint File";

                case ".RAR":
                case ".ZIP":
                    return "Compressed Folder";

                case ".SWF":
                case ".FLV":
                case ".FLA":
                    return "Flash File";

                case ".TXT":
                case ".DIZ":
                case ".LOG":
                    return "Text File";

                case ".XLS":
                case ".XLSX":
                    return "Microsoft Excel File";

                default:
                    return "File";

            }
        }


        /// <summary>
        /// Get the parent directory's path of a file/folder
        /// </summary>
        /// <param name="path">The full path of a file/folder</param>
        /// <returns></returns>
        public string GetParentDirectoryPath(string path)
        {
            string[] strList = path.Split('\\');
            if (strList.GetValue(1).ToString() == "" || strList.GetValue(1).ToString() == null) return "My Computer";
            string strPath = strList.GetValue(0).ToString();
            if (strList.Length == 2) return strPath + "\\";
            for (int i = 1; i < strList.Length - 1; i++)
            {
                strPath += "\\" + strList.GetValue(i);
            }
            return strPath;
        }


        /// <summary>
        /// Convert bytes to KB, MB, GB, TB
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public string FormatStorageLengthBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB", "PB" };
            int i;
            double Result = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                Result = bytes / 1024.0;
            }
            return Result.ToString("0.##") + " " + Suffix[i];
        }


        /// <summary>
        /// Get a folder's size in bytes
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public long GetFolderSize(string folderPath)
        {
            long size = 0;
            try
            {
                string[] fileNames = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
                foreach (string name in fileNames)
                {
                    FileInfo fileInfo = new FileInfo(name);
                    size += fileInfo.Length;
                }
            }
            catch (UnauthorizedAccessException)
            {
                size = 0;
            }
            catch (IOException)
            {
                size = 0;
            }
            return size;
        }

        public void CreateEntryFromAny(ZipArchive archive, string sourceName, string entryName = "")
        {
            var fileName = Path.GetFileName(sourceName);
            if (File.GetAttributes(sourceName).HasFlag(FileAttributes.Directory))
            {
                CreateEntryFromDirectory(archive, sourceName, Path.Combine(entryName, fileName));
            }
            else
            {
                archive.CreateEntryFromFile(sourceName, Path.Combine(entryName, fileName), CompressionLevel.Fastest);
            }
        }
        
        public void CreateEntryFromDirectory(ZipArchive archive, string sourceDirName, string entryName = "")
        {
            string[] ChildFileFolderArray = Directory.GetFiles(sourceDirName).Concat(Directory.GetDirectories(sourceDirName)).ToArray();
            if (entryName != Path.GetFileName(sourceDirName))
                archive.CreateEntry(Path.Combine(entryName, Path.GetFileName(sourceDirName)));
            foreach (var ChildFileFolderPath in ChildFileFolderArray)
            {
                CreateEntryFromAny(archive, ChildFileFolderPath, entryName);
            }
            foreach (var item in archive.Entries)
            {
                if (!item.FullName.EndsWith("/") && item.Name.Equals(entryName))
                {
                    item.Delete();
                    break;
                }
            }
        }
        #endregion
    }
}

