
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
            this.imglstLarge = new System.Windows.Forms.ImageList(this.components);
            this.imglstSmall = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDropView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsMenuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPath = new System.Windows.Forms.ToolStrip();
            this.tslbPath = new System.Windows.Forms.ToolStripLabel();
            this.tscmbPath = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.tsPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer.Location = new System.Drawing.Point(0, 89);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listView);
            this.splitContainer.Size = new System.Drawing.Size(718, 368);
            this.splitContainer.SplitterDistance = 220;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imglstTreeView;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(221, 437);
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
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(495, 368);
            this.listView.SmallImageList = this.imglstSmall;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 80;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date created";
            this.colDateCreated.Width = 100;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Date modified";
            this.colDateModified.Width = 100;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRename,
            this.menuDelete,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 22);
            this.menuFile.Text = "&File";
            // 
            // menuRename
            // 
            this.menuRename.Name = "menuRename";
            this.menuRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuRename.Size = new System.Drawing.Size(136, 22);
            this.menuRename.Text = "&Rename";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDelete.Size = new System.Drawing.Size(136, 22);
            this.menuDelete.Text = "&Delete";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(136, 22);
            this.menuExit.Text = "E&xit";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopy,
            this.menuCut,
            this.menuPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 22);
            this.menuEdit.Text = "&Edit";
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopy.Size = new System.Drawing.Size(144, 22);
            this.menuCopy.Text = "&Copy";
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuCut.Size = new System.Drawing.Size(144, 22);
            this.menuCut.Text = "&Cut";
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuPaste.Size = new System.Drawing.Size(144, 22);
            this.menuPaste.Text = "&Paste";
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLarge,
            this.menuSmall,
            this.menuList,
            this.menuDetails});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 22);
            this.menuView.Text = "&View";
            // 
            // menuLarge
            // 
            this.menuLarge.Name = "menuLarge";
            this.menuLarge.Size = new System.Drawing.Size(134, 22);
            this.menuLarge.Text = "Lar&ge Icons";
            // 
            // menuSmall
            // 
            this.menuSmall.Name = "menuSmall";
            this.menuSmall.Size = new System.Drawing.Size(134, 22);
            this.menuSmall.Text = "S&mall Icons";
            // 
            // menuList
            // 
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(134, 22);
            this.menuList.Text = "&List";
            // 
            // menuDetails
            // 
            this.menuDetails.Name = "menuDetails";
            this.menuDetails.Size = new System.Drawing.Size(134, 22);
            this.menuDetails.Text = "&Details";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 22);
            this.menuHelp.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(107, 22);
            this.menuAbout.Text = "A&bout";
            // 
            // toolBar
            // 
            this.toolBar.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnBack,
            this.tsbtnRefresh,
            this.toolStripSeparator1,
            this.tsbtnCopy,
            this.tsbtnCut,
            this.tsbtnPaste,
            this.tsbtnDelete,
            this.toolStripSeparator2,
            this.tsDropView});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(718, 37);
            this.toolBar.TabIndex = 2;
            this.toolBar.Text = "toolStrip1";
            // 
            // tsbtnBack
            // 
            this.tsbtnBack.Image = global::WindowExplorer.Properties.Resources.FolderBack;
            this.tsbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBack.Name = "tsbtnBack";
            this.tsbtnBack.Size = new System.Drawing.Size(66, 34);
            this.tsbtnBack.Text = "Back";
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = global::WindowExplorer.Properties.Resources.Refresh;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(80, 34);
            this.tsbtnRefresh.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.Image = global::WindowExplorer.Properties.Resources.Copy;
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(69, 34);
            this.tsbtnCopy.Text = "Copy";
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.Image = global::WindowExplorer.Properties.Resources.Cut;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(60, 34);
            this.tsbtnCut.Text = "Cut";
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.Image = global::WindowExplorer.Properties.Resources.Paste;
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(69, 34);
            this.tsbtnPaste.Text = "Paste";
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = global::WindowExplorer.Properties.Resources.Delete;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(74, 34);
            this.tsbtnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsDropView
            // 
            this.tsDropView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuLarge,
            this.tsMenuSmall,
            this.tsMenuList,
            this.tsMenuDetails});
            this.tsDropView.Image = global::WindowExplorer.Properties.Resources.View;
            this.tsDropView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropView.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsDropView.Name = "tsDropView";
            this.tsDropView.Size = new System.Drawing.Size(75, 34);
            this.tsDropView.Text = "View";
            // 
            // tsMenuLarge
            // 
            this.tsMenuLarge.Name = "tsMenuLarge";
            this.tsMenuLarge.Size = new System.Drawing.Size(134, 22);
            this.tsMenuLarge.Text = "Large Icons";
            // 
            // tsMenuSmall
            // 
            this.tsMenuSmall.Name = "tsMenuSmall";
            this.tsMenuSmall.Size = new System.Drawing.Size(134, 22);
            this.tsMenuSmall.Text = "Small Icons";
            // 
            // tsMenuList
            // 
            this.tsMenuList.Name = "tsMenuList";
            this.tsMenuList.Size = new System.Drawing.Size(134, 22);
            this.tsMenuList.Text = "List";
            // 
            // tsMenuDetails
            // 
            this.tsMenuDetails.Name = "tsMenuDetails";
            this.tsMenuDetails.Size = new System.Drawing.Size(134, 22);
            this.tsMenuDetails.Text = "Details";
            // 
            // tsPath
            // 
            this.tsPath.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbPath,
            this.tscmbPath});
            this.tsPath.Location = new System.Drawing.Point(0, 61);
            this.tsPath.Name = "tsPath";
            this.tsPath.Size = new System.Drawing.Size(718, 25);
            this.tsPath.TabIndex = 3;
            this.tsPath.Text = "toolStrip1";
            // 
            // tslbPath
            // 
            this.tslbPath.Margin = new System.Windows.Forms.Padding(60, 1, 0, 2);
            this.tslbPath.Name = "tslbPath";
            this.tslbPath.Size = new System.Drawing.Size(34, 22);
            this.tslbPath.Text = "Path:";
            // 
            // tscmbPath
            // 
            this.tscmbPath.Name = "tscmbPath";
            this.tscmbPath.Size = new System.Drawing.Size(500, 25);
            this.tscmbPath.Enter += new System.EventHandler(this.tscmbPath_Enter);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(718, 457);
            this.Controls.Add(this.tsPath);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Guide";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.tsPath.ResumeLayout(false);
            this.tsPath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuRename;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuLarge;
        private System.Windows.Forms.ToolStripMenuItem menuSmall;
        private System.Windows.Forms.ToolStripMenuItem menuList;
        private System.Windows.Forms.ToolStripMenuItem menuDetails;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton tsbtnBack;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsDropView;
        private System.Windows.Forms.ToolStripMenuItem tsMenuLarge;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSmall;
        private System.Windows.Forms.ToolStripMenuItem tsMenuList;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDetails;
        private System.Windows.Forms.ToolStrip tsPath;
        private System.Windows.Forms.ToolStripLabel tslbPath;
        private System.Windows.Forms.ToolStripComboBox tscmbPath;
    }
}

