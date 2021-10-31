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
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

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
                        FileInfo file = new FileInfo(tscmbPath.Text.Trim());
                        // Kiểm tra 
                        if (file.Exists)
                        {
                            System.Diagnostics.Process.Start(tscmbPath.Text.Trim());
                            DirectoryInfo parent = file.Directory;
                            tscmbPath.Text = parent.FullName;
                        }
                        // Nếu không tìm thấy đường dẫn thì báo lỗi
                        else
                        {
                            clsTreeListView.ShowContent(this.listView, tscmbPath.Text);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fuck you");
                }
            }
        }
    }
}
