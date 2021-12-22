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
    class HelperMethods
    {

        /// <summary>
        /// Return a approriate path for use in a directory structure
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static string GetApproriatePath(string strPath)
        {
            return strPath.Replace("My Computer\\", "").Replace("\\\\", "\\").Replace("Easy Access\\","");
        }


        /// <summary>
        /// Return name of a file, directory (Remove parent directories)
        /// </summary>
        /// <param name="strPath">The path of the file/folder that needs modifying</param>
        /// <returns></returns>
        public static string GetFileFolderName(string strPath)
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
        public static Image GetFileTypeIcon(FileInfo file)
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

                case ".PPT":
                case ".PPTX":
                    return Properties.Resources.Logo_PPT;

                case ".RAR":
                case ".ZIP":
                    return Properties.Resources.Logo_RAR;

                case ".SWF":
                case ".FLV":
                case ".FLA":
                    return Properties.Resources.Logo_FLASH;

                case ".TXT":
                case ".DIZ":
                case ".LOG":
                    return Properties.Resources.Logo_Text;

                case ".XLS":
                case ".XLSX":
                    return Properties.Resources.Logo_EXCEL;

                default:
                    return Properties.Resources.Logo_UnknownFile;

            }
        }

        public static Image GetNodeTypeIcon(TreeNode node)
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
        public static string GetFileType(FileInfo file)
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
                    return "Unknown File";

            }
        }


        /// <summary>
        /// Get the parent directory's path of a file/folder
        /// </summary>
        /// <param name="path">The full path of a file/folder</param>
        /// <returns></returns>
        public static string GetParentDirectoryPath(string path)
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
        public static string FormatStorageLengthBytes(long bytes)
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
        public static long GetFolderSize(string folderPath)
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

        /// <summary>
        /// Create a zip archive entry from file/folder
        /// </summary>
        /// <param name="archive"></param>
        /// <param name="sourceName"></param>
        /// <param name="entryName"></param>
        public static void CreateEntryFromAny(ZipArchive archive, string sourceName, string entryName = "")
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

        /// <summary>
        /// Create a zip archive entry from folder
        /// </summary>
        /// <param name="archive"></param>
        /// <param name="sourceDirName"></param>
        /// <param name="entryName"></param>
        public static void CreateEntryFromDirectory(ZipArchive archive, string sourceDirName, string entryName = "")
        {
            string[] ChildFileFolderArray = Directory.GetFiles(sourceDirName).Concat(Directory.GetDirectories(sourceDirName)).ToArray();
            if (entryName != Path.GetFileName(sourceDirName))
                archive.CreateEntry(entryName + "\\");
            foreach (var ChildFileFolderPath in ChildFileFolderArray)
            {
                CreateEntryFromAny(archive, ChildFileFolderPath, entryName);
            }
        }


        /// <summary>
        /// Enum for deciding what to do when file/folder already exists when extracting zip file
        /// </summary>
        public enum Overwrite
        {
            Always,
            IfNewer,
            Never
        }

        public static void ImprovedExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Overwrite overwriteMethod = Overwrite.IfNewer)
        {
            using (ZipArchive archive = ZipFile.OpenRead(sourceArchiveFileName))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith("/"))
                        Directory.CreateDirectory(destinationDirectoryName);
                    else
                        ImprovedExtractToFile(entry, destinationDirectoryName, overwriteMethod);
                }
            }
        }


        public static void ImprovedExtractToFile(ZipArchiveEntry file, string destinationPath, Overwrite overwriteMethod = Overwrite.IfNewer)
        {
            //Gets the complete path for the destination file, including any
            //relative paths that were in the zip file
            string destinationFileName = Path.Combine(destinationPath, file.Name);

            //Gets just the new path, minus the file name so we can create the
            //directory if it does not exist
            string destinationFilePath = Path.GetDirectoryName(destinationFileName);

            //Creates the directory (if it doesn't exist) for the new path
            if (!File.Exists(destinationFilePath))
            

            //Determines what to do with the file based upon the
            //method of overwriting chosen
            switch (overwriteMethod)
            {
                case Overwrite.Always:
                    //Just put the file in and overwrite anything that is found
                    file.ExtractToFile(destinationFileName, true);
                    break;
                case Overwrite.IfNewer:
                    //Checks to see if the file exists, and if so, if it should
                    //be overwritten
                    if (!File.Exists(destinationFileName) || File.GetLastWriteTime(destinationFileName) < file.LastWriteTime)
                    {
                        //Either the file didn't exist or this file is newer, so
                        //we will extract it and overwrite any existing file
                        file.ExtractToFile(destinationFileName, true);
                    }
                    break;
                case Overwrite.Never:
                    //Put the file in if it is new but ignores the 
                    //file if it already exists
                    if (!File.Exists(destinationFileName))
                    {
                        file.ExtractToFile(destinationFileName);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
