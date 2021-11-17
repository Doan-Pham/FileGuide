
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
            this.imglstTreeView = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutFirstPage = new System.Windows.Forms.TableLayoutPanel();
            this.tableLblDrives = new System.Windows.Forms.Label();
            this.tableLblRecent = new System.Windows.Forms.Label();
            this.flowLayoutPanelDrives = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewRecentFiles = new System.Windows.Forms.ListView();
            this.listViewColRecentPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglstLarge = new System.Windows.Forms.ImageList(this.components);
            this.imglstSmall = new System.Windows.Forms.ImageList(this.components);
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLblItemNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLblNumSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripListViewItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new FileGuide.BufferedTreeView();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutFirstPage.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.tsPath.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripListView.SuspendLayout();
            this.contextMenuStripListViewItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(0, 184);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutFirstPage);
            this.splitContainer.Panel2.Controls.Add(this.listView);
            this.splitContainer.Size = new System.Drawing.Size(1165, 518);
            this.splitContainer.SplitterDistance = 356;
            this.splitContainer.TabIndex = 0;
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
            // tableLayoutFirstPage
            // 
            this.tableLayoutFirstPage.BackColor = System.Drawing.Color.White;
            this.tableLayoutFirstPage.ColumnCount = 1;
            this.tableLayoutFirstPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFirstPage.Controls.Add(this.tableLblDrives, 0, 0);
            this.tableLayoutFirstPage.Controls.Add(this.tableLblRecent, 0, 2);
            this.tableLayoutFirstPage.Controls.Add(this.flowLayoutPanelDrives, 0, 1);
            this.tableLayoutFirstPage.Controls.Add(this.listViewRecentFiles, 0, 3);
            this.tableLayoutFirstPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFirstPage.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutFirstPage.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutFirstPage.Name = "tableLayoutFirstPage";
            this.tableLayoutFirstPage.RowCount = 4;
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFirstPage.Size = new System.Drawing.Size(805, 518);
            this.tableLayoutFirstPage.TabIndex = 1;
            // 
            // tableLblDrives
            // 
            this.tableLblDrives.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLblDrives.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLblDrives.Location = new System.Drawing.Point(3, 0);
            this.tableLblDrives.Name = "tableLblDrives";
            this.tableLblDrives.Size = new System.Drawing.Size(799, 51);
            this.tableLblDrives.TabIndex = 0;
            this.tableLblDrives.Text = "Drives";
            this.tableLblDrives.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLblRecent
            // 
            this.tableLblRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLblRecent.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLblRecent.Location = new System.Drawing.Point(3, 206);
            this.tableLblRecent.Name = "tableLblRecent";
            this.tableLblRecent.Size = new System.Drawing.Size(799, 51);
            this.tableLblRecent.TabIndex = 1;
            this.tableLblRecent.Text = "Recent files";
            this.tableLblRecent.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanelDrives
            // 
            this.flowLayoutPanelDrives.AutoScroll = true;
            this.flowLayoutPanelDrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDrives.Location = new System.Drawing.Point(3, 54);
            this.flowLayoutPanelDrives.Name = "flowLayoutPanelDrives";
            this.flowLayoutPanelDrives.Size = new System.Drawing.Size(799, 149);
            this.flowLayoutPanelDrives.TabIndex = 2;
            // 
            // listViewRecentFiles
            // 
            this.listViewRecentFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRecentFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewColRecentPath,
            this.Path});
            this.listViewRecentFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRecentFiles.HideSelection = false;
            this.listViewRecentFiles.Location = new System.Drawing.Point(3, 260);
            this.listViewRecentFiles.Name = "listViewRecentFiles";
            this.listViewRecentFiles.Size = new System.Drawing.Size(799, 255);
            this.listViewRecentFiles.TabIndex = 3;
            this.listViewRecentFiles.UseCompatibleStateImageBehavior = false;
            this.listViewRecentFiles.View = System.Windows.Forms.View.Details;
            // 
            // listViewColRecentPath
            // 
            this.listViewColRecentPath.Text = "Name";
            this.listViewColRecentPath.Width = 379;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 421;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colDateCreated,
            this.colDateModified});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.LabelEdit = true;
            this.listView.LargeImageList = this.imglstLarge;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(805, 518);
            this.listView.SmallImageList = this.imglstSmall;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_AfterLabelEdit);
            this.listView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_DrawColumnHeader);
            this.listView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_DrawItem);
            this.listView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_DrawSubItem);
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            this.listView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView_KeyPress);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            this.listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_MouseUp);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 250;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 150;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date created";
            this.colDateCreated.Width = 200;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Date modified";
            this.colDateModified.Width = 200;
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
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.Font = new System.Drawing.Font("Questrial", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBar.ImageScalingSize = new System.Drawing.Size(50, 50);
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
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolBar.Size = new System.Drawing.Size(1165, 105);
            this.toolBar.TabIndex = 2;
            // 
            // tsbtnBack
            // 
            this.tsbtnBack.AutoSize = false;
            this.tsbtnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbtnBack.Image = global::FileGuide.Properties.Resources.FolderBack;
            this.tsbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnBack.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnBack.Name = "tsbtnBack";
            this.tsbtnBack.Size = new System.Drawing.Size(100, 100);
            this.tsbtnBack.Text = "Back";
            this.tsbtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnBack.Click += new System.EventHandler(this.tsbtnBack_Click);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.AutoSize = false;
            this.tsbtnRefresh.Image = global::FileGuide.Properties.Resources.Refresh;
            this.tsbtnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(100, 100);
            this.tsbtnRefresh.Text = "Refresh";
            this.tsbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 105);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.AutoSize = false;
            this.tsbtnCopy.Image = global::FileGuide.Properties.Resources.Copy;
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(100, 100);
            this.tsbtnCopy.Text = "Copy";
            this.tsbtnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.AutoSize = false;
            this.tsbtnCut.Image = global::FileGuide.Properties.Resources.Cut;
            this.tsbtnCut.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(100, 100);
            this.tsbtnCut.Text = "Cut";
            this.tsbtnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.AutoSize = false;
            this.tsbtnPaste.Enabled = false;
            this.tsbtnPaste.Image = global::FileGuide.Properties.Resources.Paste;
            this.tsbtnPaste.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(100, 100);
            this.tsbtnPaste.Text = "Paste";
            this.tsbtnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.AutoSize = false;
            this.tsbtnDelete.Image = global::FileGuide.Properties.Resources.Delete;
            this.tsbtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnDelete.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(100, 100);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 105);
            // 
            // tsDropView
            // 
            this.tsDropView.AutoSize = false;
            this.tsDropView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuLarge,
            this.tsMenuSmall,
            this.tsMenuList,
            this.tsMenuDetails});
            this.tsDropView.Image = global::FileGuide.Properties.Resources.View;
            this.tsDropView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsDropView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropView.Margin = new System.Windows.Forms.Padding(8, 1, 0, 2);
            this.tsDropView.Name = "tsDropView";
            this.tsDropView.Size = new System.Drawing.Size(100, 100);
            this.tsDropView.Text = "View";
            this.tsDropView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsMenuLarge
            // 
            this.tsMenuLarge.Name = "tsMenuLarge";
            this.tsMenuLarge.Size = new System.Drawing.Size(209, 36);
            this.tsMenuLarge.Text = "Large Icons";
            this.tsMenuLarge.Click += new System.EventHandler(this.menuLarge_Click);
            // 
            // tsMenuSmall
            // 
            this.tsMenuSmall.Name = "tsMenuSmall";
            this.tsMenuSmall.Size = new System.Drawing.Size(209, 36);
            this.tsMenuSmall.Text = "Small Icons";
            this.tsMenuSmall.Click += new System.EventHandler(this.menuSmall_Click);
            // 
            // tsMenuList
            // 
            this.tsMenuList.Name = "tsMenuList";
            this.tsMenuList.Size = new System.Drawing.Size(209, 36);
            this.tsMenuList.Text = "List";
            this.tsMenuList.Click += new System.EventHandler(this.menuList_Click);
            // 
            // tsMenuDetails
            // 
            this.tsMenuDetails.Name = "tsMenuDetails";
            this.tsMenuDetails.Size = new System.Drawing.Size(209, 36);
            this.tsMenuDetails.Text = "Details";
            this.tsMenuDetails.Click += new System.EventHandler(this.menuDetails_Click);
            // 
            // tsPath
            // 
            this.tsPath.AutoSize = false;
            this.tsPath.Font = new System.Drawing.Font("Questrial", 9F);
            this.tsPath.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbPath,
            this.tscmbPath});
            this.tsPath.Location = new System.Drawing.Point(0, 105);
            this.tsPath.Name = "tsPath";
            this.tsPath.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsPath.Size = new System.Drawing.Size(1165, 42);
            this.tsPath.TabIndex = 3;
            this.tsPath.Text = "toolStrip1";
            // 
            // tslbPath
            // 
            this.tslbPath.Margin = new System.Windows.Forms.Padding(60, 1, 0, 2);
            this.tslbPath.Name = "tslbPath";
            this.tslbPath.Size = new System.Drawing.Size(54, 39);
            this.tslbPath.Text = "Path:";
            // 
            // tscmbPath
            // 
            this.tscmbPath.AutoSize = false;
            this.tscmbPath.Name = "tscmbPath";
            this.tscmbPath.Size = new System.Drawing.Size(748, 33);
            this.tscmbPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscmbPath_KeyPress);
            this.tscmbPath.TextChanged += new System.EventHandler(this.tscmbPath_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Questrial", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLblItemNum,
            this.statusLblNumSelect});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1165, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLblItemNum
            // 
            this.statusLblItemNum.Name = "statusLblItemNum";
            this.statusLblItemNum.Size = new System.Drawing.Size(0, 15);
            // 
            // statusLblNumSelect
            // 
            this.statusLblNumSelect.Margin = new System.Windows.Forms.Padding(20, 4, 0, 3);
            this.statusLblNumSelect.Name = "statusLblNumSelect";
            this.statusLblNumSelect.Size = new System.Drawing.Size(0, 15);
            // 
            // contextMenuStripListView
            // 
            this.contextMenuStripListView.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripListView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.refreshToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStripListView.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStripListView.Name = "contextMenuStripListView";
            this.contextMenuStripListView.Size = new System.Drawing.Size(241, 193);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.largeIconsToolStripMenuItem.Text = "Large Icons";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.menuLarge_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.menuSmall_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.menuList_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.menuDetails_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.newToolStripMenuItem.Text = "New";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Image = global::FileGuide.Properties.Resources.Folder;
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Image = global::FileGuide.Properties.Resources.file;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // contextMenuStripListViewItem
            // 
            this.contextMenuStripListViewItem.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripListViewItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripListViewItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.toolStripMenuItem4,
            this.renameToolStripMenuItem,
            this.delteToolStripMenuItem});
            this.contextMenuStripListViewItem.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStripListViewItem.Name = "contextMenuStripListViewItem";
            this.contextMenuStripListViewItem.Size = new System.Drawing.Size(162, 196);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(158, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(158, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.menuRename_Click);
            // 
            // delteToolStripMenuItem
            // 
            this.delteToolStripMenuItem.Name = "delteToolStripMenuItem";
            this.delteToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.delteToolStripMenuItem.Text = "Delete";
            this.delteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.White;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeView.Font = new System.Drawing.Font("Questrial", 9.999999F);
            this.treeView.ForeColor = System.Drawing.Color.Black;
            this.treeView.FullRowSelect = true;
            this.treeView.HotTracking = true;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imglstTreeView;
            this.treeView.Indent = 20;
            this.treeView.ItemHeight = 46;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.ShowLines = false;
            this.treeView.Size = new System.Drawing.Size(356, 518);
            this.treeView.TabIndex = 1;
            this.treeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView_DrawNode);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.MouseLeave += new System.EventHandler(this.treeView_MouseLeave);
            this.treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseMove);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1165, 728);
            this.Controls.Add(this.tsPath);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  File Guide";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_Resize);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutFirstPage.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.tsPath.ResumeLayout(false);
            this.tsPath.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripListView.ResumeLayout(false);
            this.contextMenuStripListViewItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imglstTreeView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateModified;
        private System.Windows.Forms.ImageList imglstLarge;
        private System.Windows.Forms.ImageList imglstSmall;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLblItemNum;
        private System.Windows.Forms.ToolStripStatusLabel statusLblNumSelect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListView;
        private BufferedTreeView treeView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFirstPage;
        private System.Windows.Forms.Label tableLblDrives;
        private System.Windows.Forms.Label tableLblRecent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDrives;
        private System.Windows.Forms.ListView listViewRecentFiles;
        private System.Windows.Forms.ColumnHeader listViewColRecentPath;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListViewItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

