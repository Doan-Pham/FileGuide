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
namespace FileGuide
{
    public partial class FrmMain : Form
    {
        private ClsTreeListView clsTreeListView = new ClsTreeListView();
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Khi load form, tạo treeview và listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            clsTreeListView.CreateTreeView(this.treeView);
            if (this.Width > 400)
                tscmbPath.Width = this.Width - 150;
        }

        /// <summary>
        /// Load cây thư mục vào treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currentNode = e.Node;
               clsTreeListView.ShowFolderTree(this.treeView,this.listView, currentNode);
            tscmbPath.Text = clsTreeListView.GetFullPath(currentNode.FullPath);
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listView.FocusedItem;
            clsTreeListView.ClickItem(this.listView, item);
            tscmbPath.Text = clsTreeListView.GetFullPath(item.SubItems[4].Text);
        }

        private void tscmbPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {    
                try
                {
                    // Chỉ xử lý khi đường dẫn không trống
                    if (tscmbPath.Text != "")
                    {
                        // Nếu đường dẫn trỏ đến file thì thực thi file
                        if (File.Exists(tscmbPath.Text.Trim()))
                        {
                            FileInfo file = new FileInfo(tscmbPath.Text.Trim());
                            System.Diagnostics.Process.Start(tscmbPath.Text.Trim());
                            DirectoryInfo parent = file.Directory;
                            tscmbPath.Text = parent.FullName;
                        }

                        // Nếu đường dẫn trỏ đến folder thì hiện nội dung folder lên listView
                        else if (Directory.Exists(tscmbPath.Text.Trim()))
                        {
                            clsTreeListView.ShowContent(this.listView, tscmbPath.Text);
                        }

                        // Nếu đường dẫn không tồn tại thì báo lỗi
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
            if (this.Width > 400)
            tscmbPath.Width = this.Width - 150;
        }

        private void listView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ListViewItem item = this.listView.FocusedItem;
                clsTreeListView.ClickItem(this.listView, item);
                tscmbPath.Text = clsTreeListView.GetFullPath(item.SubItems[4].Text);
            }    
        }
    }
}
