
namespace FileGuide
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imglstTreeView = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglstSmall = new System.Windows.Forms.ImageList(this.components);
            this.imglstLarge = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listView);
            this.splitContainer.Size = new System.Drawing.Size(978, 644);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imglstTreeView;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(300, 644);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imglstTreeView
            // 
            this.imglstTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTreeView.ImageStream")));
            this.imglstTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTreeView.Images.SetKeyName(0, "MyComputer.png");
            this.imglstTreeView.Images.SetKeyName(1, "FloppyDisk.png");
            this.imglstTreeView.Images.SetKeyName(2, "HardDisk.png");
            this.imglstTreeView.Images.SetKeyName(3, "CDDisk.png");
            this.imglstTreeView.Images.SetKeyName(4, "NetworkDrive.png");
            this.imglstTreeView.Images.SetKeyName(5, "Folder.png");
            this.imglstTreeView.Images.SetKeyName(6, "FolderOpen.png");
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colDateCreated,
            this.colDateModified});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imglstLarge;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(673, 644);
            this.listView.SmallImageList = this.imglstSmall;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSize.Width = 80;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date created";
            this.colDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDateCreated.Width = 100;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Date modified";
            this.colDateModified.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDateModified.Width = 100;
            // 
            // imglstSmall
            // 
            this.imglstSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstSmall.ImageStream")));
            this.imglstSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstSmall.Images.SetKeyName(0, "database.png");
            this.imglstSmall.Images.SetKeyName(1, "doc.png");
            this.imglstSmall.Images.SetKeyName(2, "exe.png");
            this.imglstSmall.Images.SetKeyName(3, "file.png");
            this.imglstSmall.Images.SetKeyName(4, "Folder.png");
            this.imglstSmall.Images.SetKeyName(5, "html.png");
            this.imglstSmall.Images.SetKeyName(6, "music.png");
            this.imglstSmall.Images.SetKeyName(7, "pdf.png");
            this.imglstSmall.Images.SetKeyName(8, "png.png");
            this.imglstSmall.Images.SetKeyName(9, "ppt.jpg");
            this.imglstSmall.Images.SetKeyName(10, "rar.jpg");
            this.imglstSmall.Images.SetKeyName(11, "swf.png");
            this.imglstSmall.Images.SetKeyName(12, "txt.png");
            this.imglstSmall.Images.SetKeyName(13, "xls.jpg");
            // 
            // imglstLarge
            // 
            this.imglstLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstLarge.ImageStream")));
            this.imglstLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstLarge.Images.SetKeyName(0, "database.png");
            this.imglstLarge.Images.SetKeyName(1, "doc.png");
            this.imglstLarge.Images.SetKeyName(2, "exe.png");
            this.imglstLarge.Images.SetKeyName(3, "file.png");
            this.imglstLarge.Images.SetKeyName(4, "Folder.png");
            this.imglstLarge.Images.SetKeyName(5, "html.png");
            this.imglstLarge.Images.SetKeyName(6, "music.png");
            this.imglstLarge.Images.SetKeyName(7, "pdf.png");
            this.imglstLarge.Images.SetKeyName(8, "png.png");
            this.imglstLarge.Images.SetKeyName(9, "ppt.jpg");
            this.imglstLarge.Images.SetKeyName(10, "rar.jpg");
            this.imglstLarge.Images.SetKeyName(11, "swf.png");
            this.imglstLarge.Images.SetKeyName(12, "txt.png");
            this.imglstLarge.Images.SetKeyName(13, "xls.jpg");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Guide";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imglstTreeView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateModified;
        private System.Windows.Forms.ImageList imglstLarge;
        private System.Windows.Forms.ImageList imglstSmall;
    }
}

