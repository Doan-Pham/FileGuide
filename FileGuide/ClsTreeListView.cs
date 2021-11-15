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

namespace FileGuide
{
    class ClsTreeListView
    {
        // Each type of drive is paired with respective number from DriveType enum 
        const int RemovableDisk = 2;
        const int LocalDisk = 3;
        const int NetworkDisk = 4;
        const int CDDisk = 5;

        /// <summary>
        /// Initialize treeView
        /// </summary>
        /// <param name="treeView"></param>
        public void CreateTreeView(TreeView treeView)
        {  
            // Create root treenode: My Computer and add to treeView
            TreeNode tnMyComputer = new TreeNode("My Computer", 0, 0);
            treeView.Nodes.Clear();
            treeView.Nodes.Add(tnMyComputer);

            // Select all drives into a collection 
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();

            Button DriveButton = new Button();
            // For each drive, assign the approriate image index, create a treenode + add to the root node's collection
            foreach(ManagementObject mo in queryCollection)
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
            ShowFolderTree(treeView, tnMyComputer);
        }

        public void ShowListViewFirstPage(FlowLayoutPanel flowLayoutPanelDrives)
        {
            // For each drive, assign the approriate image index, create a treenode + add to the root node's collection
            foreach (var drive in DriveInfo.GetDrives())
            {
                long freeSpace = drive.TotalFreeSpace;
                long totalSpace = drive.TotalSize;
                double percentFree = freeSpace * 100.0 / totalSpace;
              
                Panel DrivePanel = new Panel();
                PictureBox DrivePicture = new PictureBox();
                Label DriveName = new Label();
                Label DriveStorageInfo = new Label();
                ProgressBar DriveStorageBar = new ProgressBar();

                DrivePanel.BorderStyle = BorderStyle.FixedSingle;
                DrivePanel.Width = 365;
                DrivePanel.Height = 105;
                DrivePanel.Margin = new Padding(3,10,20,10);

                switch (drive.DriveType.ToString())
                {
                    case "Removable":
                        {
                            DrivePicture.Image = Properties.Resources.FloppyDisk;
                        }
                        break;

                    case "Fixed":
                        {
                            DrivePicture.Image = Properties.Resources.HardDisk;
                        }
                        break;

                    case "CDRom":
                        {
                            DrivePicture.Image = Properties.Resources.CDDisk;
                        }
                        break;

                    case "Network":
                        {
                            DrivePicture.Image = Properties.Resources.NetworkDrive;
                        }
                        break;

                    default:
                        {
                            DrivePicture.Image = Properties.Resources.HardDisk;
                        }
                        break;
                }

                DriveStorageBar.Dock = DockStyle.Left;
                DriveStorageBar.Width = 250;
                DriveStorageBar.Height = 25;
                DriveStorageBar.Style = ProgressBarStyle.Continuous;
                DriveStorageBar.ForeColor = Color.FromArgb(205, 232, 255);
                DriveStorageBar.Value = 100 - (int)percentFree;
                DrivePanel.Controls.Add(DriveStorageBar);

                DriveName.Dock = DockStyle.Top;
                DriveName.Height = 40;
                DriveName.TextAlign = ContentAlignment.BottomLeft;
                DriveName.Text = drive.VolumeLabel.ToString() + " (" + drive.Name.ToString() + ")";
                DrivePanel.Controls.Add(DriveName);

                DriveStorageInfo.Dock = DockStyle.Bottom;
                DriveStorageInfo.Height = 36;
                DriveStorageInfo.Text = FormatStorageLengthBytes(freeSpace) + " free of " + FormatStorageLengthBytes(totalSpace);
                DrivePanel.Controls.Add(DriveStorageInfo);

                DrivePicture.SizeMode = PictureBoxSizeMode.Zoom;
                DrivePicture.Width = 80;
                DrivePicture.Dock = DockStyle.Left;
                DrivePanel.Controls.Add(DrivePicture);
                flowLayoutPanelDrives.Controls.Add(DrivePanel);
            }
        
        }

        /// <summary>
        /// Show computer's folder tree onto treeView
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="currentNode">The treenode at which to show folder tree</param>
        /// <returns></returns>
        public bool ShowFolderTree(TreeView treeView, TreeNode currentNode)
        {
            // My Computer and its children are already created in CreatTreeView func, recreating will cause an error
            if (currentNode.Text != "My Computer")
            {
                try
                {
                    if (!Directory.Exists(GetApproriatePath(currentNode.FullPath)))
                    {
                        MessageBox.Show("Directory not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        // Add all child directories of the current's node to treeView 
                        string[] strDirectories = Directory.GetDirectories(GetApproriatePath(currentNode.FullPath));

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
                    MessageBox.Show("Directory does not exist","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You might not have permission to access this directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }         
            }
            return false;
        }


        /// <summary>
        /// Show a folder's content onto listView
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="currentNode">The treenode at which to show content</param>
        public void ShowListView(ListView listView, TreeNode currentNode)
        {
            try
            {
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
                MessageBox.Show(e.ToString());
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
                MessageBox.Show(e.ToString());
            }
        }


        /// <summary>
        /// Process an item: Run if a file, open if a folder
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="CurrentItem"></param>
        /// <returns></returns>
        public bool ClickItem(ListView listView, ListViewItem CurrentItem)
        {
            try
            {
                string path = CurrentItem.SubItems[4].Text;
                FileInfo fi = new FileInfo(path);

                if (fi.Exists)
                {
                    Process.Start(path);
                }
                else
                {
                    ShowListView(listView, path);  
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return false;
        }

        /// <summary>
        /// Delete a listView item
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="item"></param>
        public void DeleteItem(ListView listView, ListViewItem item)
        {
            try
            {
                string path = item.SubItems[4].Text;

                if (item.SubItems[1].Text == "Folder")
                {
                    DirectoryInfo directory = new DirectoryInfo(path);
                    if (!directory.Exists)
                    {
                        MessageBox.Show("Folder might not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else 
                    {
                        DialogResult dialog = MessageBox.Show("Are you sure you want to delete this folder ? \n" + item.Text.ToString(), "Delete folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dialog == DialogResult.Yes)
                        {
                            directory.Delete(true);
                        }
                        else return;

                        string pathFolder = GetParentDirectoryPath(path);
                        ShowListView(listView, pathFolder);
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
                        DialogResult dialog = MessageBox.Show("Are you sure you want to delete this file ? \n" + item.Text.ToString(), "Delete file", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dialog == DialogResult.Yes)
                        {
                            file.Delete();
                        }
                        else return;

                        string pathFolder = GetParentDirectoryPath(path);
                        ShowListView(listView, pathFolder);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Return a listViewItem from a folder
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public ListViewItem GetListViewItem(DirectoryInfo folder)
        {
            string[] item = new string[5];
            item[0] = folder.Name;
            item[1] = "Folder";
            item[2] = folder.CreationTime.ToString();
            item[3] = folder.LastWriteTime.ToString();
            item[4] = folder.FullName;

            ListViewItem newItem = new ListViewItem(item);
            newItem.ImageIndex = 4;
            return newItem;
        }


        /// <summary>
        /// Return a listViewItem from a file
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public ListViewItem GetListViewItem(FileInfo file)
        {
            string[] item = new string[5];
            item[0] = file.Name;
            item[1] = (file.Length/1024).ToString() + " KB";
            item[2] = file.CreationTime.ToString();
            item[3] = file.LastWriteTime.ToString();
            item[4] = file.FullName;

            ListViewItem newItem = new ListViewItem(item);
            newItem.ImageIndex = GetImageIndex(file);
            return newItem;
        }

        
        /// <summary>
        /// Modify a path for displaying
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
            return strSplit[strSplit.Length - 1];
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


        /// <summary>
        /// Return image index respective to a file's extension
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public int GetImageIndex(FileInfo file)
        {
            switch(file.Extension.ToUpper())
            {
                case ".MDB":
                    return 0;

                case ".DOC":
                case ".DOCX":
                    return 1;

                case ".EXE":
                    return 2;

                case ".HTM":
                case ".HTML":
                    return 5;

                case ".MP3":
                case ".WAV":
                case ".WMV":
                case ".ASF":
                case ".MPEG":
                case ".AVI":
                    return 6;

                case ".PDF":
                    return 7;

                case ".JPG":
                case ".PNG":
                case ".BMP":
                case ".GIF":
                    return 8;

                case ".PPT":
                case ".PPTX":
                    return 9;

                case ".RAR":
                case ".ZIP":
                    return 10;

                case ".SWF":
                case ".FLV":
                case ".FLA":
                    return 11;

                case ".TXT":
                case ".DIZ":
                case ".LOG":
                    return 12;

                case ".XLS":
                case ".XLSX":
                    return 13;

                default:
                    return 3;

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
            string strPath = strList.GetValue(0).ToString();
            //if (strList.GetValue(1).ToString() == "") return "My Computer";
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
            return  Result.ToString("0.##") + " " + Suffix[i];
        }
    }
}

