
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
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripListViewItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.zipFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unzipFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new FileGuide.BufferedTreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpingFromEasyAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabWindow = new FileGuide.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutFirstPage = new System.Windows.Forms.TableLayoutPanel();
            this.tableLblDrives = new System.Windows.Forms.Label();
            this.tableLblRecent = new System.Windows.Forms.Label();
            this.flowLayoutPanelDrives = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewRecentFiles = new FileGuide.DoubleBufferedListView();
            this.listViewColRecentPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView = new FileGuide.DoubleBufferedListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPlus = new System.Windows.Forms.TabPage();
            this.tsPath = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tslbPath = new System.Windows.Forms.ToolStripLabel();
            this.tscmbPath = new System.Windows.Forms.ToolStripComboBox();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.ShortcutKeysPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRename = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDropView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsMenuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDropNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonZip = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDarkMode = new System.Windows.Forms.ToolStripButton();
            this.ShortcutKeysMenu = new System.Windows.Forms.MenuStrip();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFoldẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLargeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.unpinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripListView.SuspendLayout();
            this.contextMenuStripListViewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.contextMenuStripTreeView.SuspendLayout();
            this.tabWindow.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutFirstPage.SuspendLayout();
            this.tsPath.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.ShortcutKeysPanel.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.ShortcutKeysMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Questrial", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLblItemNum,
            this.statusLblNumSelect});
            this.statusStrip1.Location = new System.Drawing.Point(0, 807);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1778, 37);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLblItemNum
            // 
            this.statusLblItemNum.Name = "statusLblItemNum";
            this.statusLblItemNum.Size = new System.Drawing.Size(0, 30);
            // 
            // statusLblNumSelect
            // 
            this.statusLblNumSelect.Margin = new System.Windows.Forms.Padding(20, 4, 0, 3);
            this.statusLblNumSelect.Name = "statusLblNumSelect";
            this.statusLblNumSelect.Size = new System.Drawing.Size(0, 30);
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
            this.contextMenuStripListView.Size = new System.Drawing.Size(209, 160);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.largeIconsToolStripMenuItem.Text = "Large Icons";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.menuLarge_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.menuSmall_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.menuList_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(290, 38);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.menuDetails_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.newToolStripMenuItem.Text = "New";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Image = global::FileGuide.Properties.Resources.Icon_Folder;
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(295, 38);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Image = global::FileGuide.Properties.Resources.Logo_UnknownFile;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(295, 38);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.btnPaste_Click);
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
            this.toolStripMenuItem5,
            this.zipFilesToolStripMenuItem,
            this.unzipFileToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.pinToolStripMenuItem1});
            this.contextMenuStripListViewItem.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStripListViewItem.Name = "contextMenuStripListViewItem";
            this.contextMenuStripListViewItem.ShowImageMargin = false;
            this.contextMenuStripListViewItem.Size = new System.Drawing.Size(278, 343);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(274, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(274, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.menuRename_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(274, 6);
            // 
            // zipFilesToolStripMenuItem
            // 
            this.zipFilesToolStripMenuItem.Name = "zipFilesToolStripMenuItem";
            this.zipFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.zipFilesToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.zipFilesToolStripMenuItem.Text = "Zip file(s)/folder(s)";
            this.zipFilesToolStripMenuItem.Click += new System.EventHandler(this.zipFilesToolStripMenuItem_Click);
            // 
            // unzipFileToolStripMenuItem
            // 
            this.unzipFileToolStripMenuItem.Name = "unzipFileToolStripMenuItem";
            this.unzipFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.unzipFileToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.unzipFileToolStripMenuItem.Text = "Unzip file";
            this.unzipFileToolStripMenuItem.Click += new System.EventHandler(this.unzipFileToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(277, 36);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pinToolStripMenuItem1
            // 
            this.pinToolStripMenuItem1.Name = "pinToolStripMenuItem1";
            this.pinToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pinToolStripMenuItem1.Size = new System.Drawing.Size(277, 36);
            this.pinToolStripMenuItem1.Text = "Pin";
            this.pinToolStripMenuItem1.Click += new System.EventHandler(this.pinToolStripMenuItem_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.Color.White;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.mainSplitContainer.Panel2.Controls.Add(this.tabWindow);
            this.mainSplitContainer.Panel2.Controls.Add(this.tsPath);
            this.mainSplitContainer.Panel2.Controls.Add(this.toolsPanel);
            this.mainSplitContainer.Size = new System.Drawing.Size(1778, 807);
            this.mainSplitContainer.SplitterDistance = 392;
            this.mainSplitContainer.TabIndex = 5;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.ContextMenuStrip = this.contextMenuStripTreeView;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeView.Font = new System.Drawing.Font("Questrial", 9.999999F);
            this.treeView.ForeColor = System.Drawing.Color.Black;
            this.treeView.FullRowSelect = true;
            this.treeView.HotTracking = true;
            this.treeView.Indent = 20;
            this.treeView.ItemHeight = 46;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.ShowLines = false;
            this.treeView.Size = new System.Drawing.Size(392, 807);
            this.treeView.TabIndex = 1;
            this.treeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView_DrawNode);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.MouseLeave += new System.EventHandler(this.treeView_MouseLeave);
            this.treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseMove);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseUp);
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.BackColor = System.Drawing.Color.White;
            this.contextMenuStripTreeView.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripTreeView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinToolStripMenuItem,
            this.unpingFromEasyAccessToolStripMenuItem});
            this.contextMenuStripTreeView.Name = "treeViewContextMenuStrip";
            this.contextMenuStripTreeView.ShowImageMargin = false;
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(397, 76);
            // 
            // pinToolStripMenuItem
            // 
            this.pinToolStripMenuItem.Name = "pinToolStripMenuItem";
            this.pinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pinToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.pinToolStripMenuItem.Text = "Pin to Easy Access";
            this.pinToolStripMenuItem.Click += new System.EventHandler(this.pinToolStripMenuItem_Click);
            // 
            // unpingFromEasyAccessToolStripMenuItem
            // 
            this.unpingFromEasyAccessToolStripMenuItem.Name = "unpingFromEasyAccessToolStripMenuItem";
            this.unpingFromEasyAccessToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.unpingFromEasyAccessToolStripMenuItem.Size = new System.Drawing.Size(396, 36);
            this.unpingFromEasyAccessToolStripMenuItem.Text = "Unpin from Easy Access";
            this.unpingFromEasyAccessToolStripMenuItem.Click += new System.EventHandler(this.unpingFromEasyAccessToolStripMenuItem_Click);
            // 
            // tabWindow
            // 
            this.tabWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabWindow.Controls.Add(this.tabPage1);
            this.tabWindow.Controls.Add(this.tabPlus);
            this.tabWindow.ItemSize = new System.Drawing.Size(200, 50);
            this.tabWindow.Location = new System.Drawing.Point(0, 206);
            this.tabWindow.Name = "tabWindow";
            this.tabWindow.SelectedIndex = 0;
            this.tabWindow.ShowToolTips = true;
            this.tabWindow.Size = new System.Drawing.Size(1391, 615);
            this.tabWindow.TabIndex = 4;
            this.tabWindow.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabWindow_Selecting);
            this.tabWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabWindow_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tableLayoutFirstPage);
            this.tabPage1.Controls.Add(this.listView);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1383, 557);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            // 
            // tableLayoutFirstPage
            // 
            this.tableLayoutFirstPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutFirstPage.BackColor = System.Drawing.Color.White;
            this.tableLayoutFirstPage.ColumnCount = 1;
            this.tableLayoutFirstPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFirstPage.Controls.Add(this.tableLblDrives, 0, 0);
            this.tableLayoutFirstPage.Controls.Add(this.tableLblRecent, 0, 2);
            this.tableLayoutFirstPage.Controls.Add(this.flowLayoutPanelDrives, 0, 1);
            this.tableLayoutFirstPage.Controls.Add(this.listViewRecentFiles, 0, 3);
            this.tableLayoutFirstPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFirstPage.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutFirstPage.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutFirstPage.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutFirstPage.Name = "tableLayoutFirstPage";
            this.tableLayoutFirstPage.RowCount = 5;
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFirstPage.Size = new System.Drawing.Size(1377, 551);
            this.tableLayoutFirstPage.TabIndex = 1;
            // 
            // tableLblDrives
            // 
            this.tableLblDrives.BackColor = System.Drawing.Color.White;
            this.tableLblDrives.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLblDrives.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLblDrives.ForeColor = System.Drawing.Color.Black;
            this.tableLblDrives.Location = new System.Drawing.Point(3, 0);
            this.tableLblDrives.Name = "tableLblDrives";
            this.tableLblDrives.Size = new System.Drawing.Size(1371, 51);
            this.tableLblDrives.TabIndex = 0;
            this.tableLblDrives.Text = "Drives";
            this.tableLblDrives.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLblRecent
            // 
            this.tableLblRecent.BackColor = System.Drawing.Color.White;
            this.tableLblRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLblRecent.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLblRecent.ForeColor = System.Drawing.Color.Black;
            this.tableLblRecent.Location = new System.Drawing.Point(3, 212);
            this.tableLblRecent.Name = "tableLblRecent";
            this.tableLblRecent.Size = new System.Drawing.Size(1371, 53);
            this.tableLblRecent.TabIndex = 1;
            this.tableLblRecent.Text = "Recent files";
            this.tableLblRecent.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanelDrives
            // 
            this.flowLayoutPanelDrives.AutoScroll = true;
            this.flowLayoutPanelDrives.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelDrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDrives.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelDrives.Location = new System.Drawing.Point(3, 56);
            this.flowLayoutPanelDrives.Name = "flowLayoutPanelDrives";
            this.flowLayoutPanelDrives.Size = new System.Drawing.Size(1371, 153);
            this.flowLayoutPanelDrives.TabIndex = 2;
            // 
            // listViewRecentFiles
            // 
            this.listViewRecentFiles.BackColor = System.Drawing.Color.White;
            this.listViewRecentFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRecentFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewColRecentPath,
            this.Path});
            this.listViewRecentFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRecentFiles.ForeColor = System.Drawing.Color.Black;
            this.listViewRecentFiles.FullRowSelect = true;
            this.listViewRecentFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRecentFiles.HideSelection = false;
            this.listViewRecentFiles.Location = new System.Drawing.Point(3, 268);
            this.listViewRecentFiles.Name = "listViewRecentFiles";
            this.listViewRecentFiles.OwnerDraw = true;
            this.listViewRecentFiles.Size = new System.Drawing.Size(1371, 259);
            this.listViewRecentFiles.TabIndex = 3;
            this.listViewRecentFiles.UseCompatibleStateImageBehavior = false;
            this.listViewRecentFiles.View = System.Windows.Forms.View.Details;
            this.listViewRecentFiles.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewRecentFiles_ColumnWidthChanging);
            this.listViewRecentFiles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_DrawColumnHeader);
            this.listViewRecentFiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_DrawItem);
            this.listViewRecentFiles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_DrawSubItem);
            this.listViewRecentFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRecentFiles_MouseDoubleClick);
            // 
            // listViewColRecentPath
            // 
            this.listViewColRecentPath.Text = "Name";
            this.listViewColRecentPath.Width = 641;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 650;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colType,
            this.colSize,
            this.colDateCreated,
            this.colDateModified});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.Color.Black;
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(1377, 551);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_AfterLabelEdit);
            this.listView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumnWidthChanging);
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
            this.colName.Width = 290;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 155;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 161;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date created";
            this.colDateCreated.Width = 271;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Date modified";
            this.colDateModified.Width = 420;
            // 
            // tabPlus
            // 
            this.tabPlus.Location = new System.Drawing.Point(4, 54);
            this.tabPlus.Name = "tabPlus";
            this.tabPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlus.Size = new System.Drawing.Size(1383, 557);
            this.tabPlus.TabIndex = 0;
            this.tabPlus.Text = " ";
            this.tabPlus.UseVisualStyleBackColor = true;
            // 
            // tsPath
            // 
            this.tsPath.AutoSize = false;
            this.tsPath.BackColor = System.Drawing.Color.White;
            this.tsPath.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPath.Font = new System.Drawing.Font("Questrial", 9F);
            this.tsPath.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPath.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnRefresh,
            this.tslbPath,
            this.tscmbPath});
            this.tsPath.Location = new System.Drawing.Point(0, 151);
            this.tsPath.Name = "tsPath";
            this.tsPath.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsPath.Size = new System.Drawing.Size(1387, 60);
            this.tsPath.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = global::FileGuide.Properties.Resources.Icon_Back;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Margin = new System.Windows.Forms.Padding(10, 2, 10, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 46);
            this.btnBack.Text = "toolStripButton2";
            this.btnBack.Click += new System.EventHandler(this.tsbtnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Font = new System.Drawing.Font("Questrial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::FileGuide.Properties.Resources.Icon_Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 2, 10, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 46);
            this.btnRefresh.Text = "toolStripButton1";
            this.btnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tslbPath
            // 
            this.tslbPath.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.tslbPath.Name = "tslbPath";
            this.tslbPath.Size = new System.Drawing.Size(54, 57);
            this.tslbPath.Text = "Path:";
            // 
            // tscmbPath
            // 
            this.tscmbPath.AutoSize = false;
            this.tscmbPath.Name = "tscmbPath";
            this.tscmbPath.Size = new System.Drawing.Size(400, 33);
            this.tscmbPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscmbPath_KeyPress);
            this.tscmbPath.TextChanged += new System.EventHandler(this.tscmbPath_TextChanged);
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.Color.White;
            this.toolsPanel.Controls.Add(this.ShortcutKeysPanel);
            this.toolsPanel.Controls.Add(this.toolBar);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(1382, 160);
            this.toolsPanel.TabIndex = 8;
            // 
            // ShortcutKeysPanel
            // 
            this.ShortcutKeysPanel.BackColor = System.Drawing.Color.White;
            this.ShortcutKeysPanel.Controls.Add(this.label10);
            this.ShortcutKeysPanel.Controls.Add(this.label9);
            this.ShortcutKeysPanel.Controls.Add(this.label8);
            this.ShortcutKeysPanel.Controls.Add(this.label7);
            this.ShortcutKeysPanel.Controls.Add(this.label6);
            this.ShortcutKeysPanel.Controls.Add(this.label5);
            this.ShortcutKeysPanel.Controls.Add(this.label4);
            this.ShortcutKeysPanel.Controls.Add(this.label3);
            this.ShortcutKeysPanel.Controls.Add(this.label2);
            this.ShortcutKeysPanel.Controls.Add(this.label1);
            this.ShortcutKeysPanel.Font = new System.Drawing.Font("Be Vietnam", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortcutKeysPanel.ForeColor = System.Drawing.Color.DimGray;
            this.ShortcutKeysPanel.Location = new System.Drawing.Point(0, 121);
            this.ShortcutKeysPanel.Name = "ShortcutKeysPanel";
            this.ShortcutKeysPanel.Size = new System.Drawing.Size(1301, 27);
            this.ShortcutKeysPanel.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(980, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 34);
            this.label10.TabIndex = 9;
            this.label10.Text = "(Ctrl+(Shift)+P)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(827, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 34);
            this.label9.TabIndex = 8;
            this.label9.Text = "(Alt+(Shift)+Z)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(1150, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "(Ctrl+D)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(684, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "(Ctrl+(Shift)+N)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(541, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "(Alt+(Shift)+V)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(448, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "(Ctrl+R)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(337, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "(Delete)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(230, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "(Ctrl+V)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(125, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Ctrl+X)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "(Ctrl+C)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.BackColor = System.Drawing.Color.White;
            this.toolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBar.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCopy,
            this.tsbtnCut,
            this.tsbtnPaste,
            this.tsbtnDelete,
            this.tsbtnRename,
            this.toolStripSeparator2,
            this.tsDropView,
            this.tsDropNew,
            this.toolStripButtonZip,
            this.toolStripButtonPin,
            this.toolStripButtonDarkMode});
            this.toolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolBar.Size = new System.Drawing.Size(1387, 148);
            this.toolBar.TabIndex = 2;
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.AutoSize = false;
            this.tsbtnCopy.Image = global::FileGuide.Properties.Resources.Icon_Copy;
            this.tsbtnCopy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Margin = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(100, 100);
            this.tsbtnCopy.Text = "Copy ";
            this.tsbtnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCopy.ToolTipText = "Copy (Ctrl+C)\r\n ";
            this.tsbtnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.AutoSize = false;
            this.tsbtnCut.Image = global::FileGuide.Properties.Resources.Icon_Cut;
            this.tsbtnCut.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(100, 100);
            this.tsbtnCut.Text = "Cut";
            this.tsbtnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCut.ToolTipText = "Cut (Ctrl+X)\r\n";
            this.tsbtnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.AutoSize = false;
            this.tsbtnPaste.Enabled = false;
            this.tsbtnPaste.Image = global::FileGuide.Properties.Resources.Icon_Paste;
            this.tsbtnPaste.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(100, 100);
            this.tsbtnPaste.Text = "Paste";
            this.tsbtnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnPaste.ToolTipText = "Paste (Ctrl+V)\r\n\r\n";
            this.tsbtnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.AutoSize = false;
            this.tsbtnDelete.Image = global::FileGuide.Properties.Resources.Icon_Delete;
            this.tsbtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnDelete.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(100, 100);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.ToolTipText = "Delete (Ctrl+D)\r\n";
            this.tsbtnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tsbtnRename
            // 
            this.tsbtnRename.AutoSize = false;
            this.tsbtnRename.Image = global::FileGuide.Properties.Resources.Icon_Rename;
            this.tsbtnRename.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnRename.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnRename.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnRename.Name = "tsbtnRename";
            this.tsbtnRename.Size = new System.Drawing.Size(100, 100);
            this.tsbtnRename.Text = "Rename";
            this.tsbtnRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRename.ToolTipText = "Rename (Ctrl+R)\r\n";
            this.tsbtnRename.Click += new System.EventHandler(this.menuRename_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 148);
            // 
            // tsDropView
            // 
            this.tsDropView.AutoSize = false;
            this.tsDropView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuLarge,
            this.tsMenuSmall,
            this.tsMenuList,
            this.tsMenuDetails});
            this.tsDropView.Image = global::FileGuide.Properties.Resources.Icon_View;
            this.tsDropView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsDropView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropView.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.tsDropView.Name = "tsDropView";
            this.tsDropView.Size = new System.Drawing.Size(100, 100);
            this.tsDropView.Text = "View";
            this.tsDropView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsMenuLarge
            // 
            this.tsMenuLarge.Name = "tsMenuLarge";
            this.tsMenuLarge.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.tsMenuLarge.Size = new System.Drawing.Size(337, 38);
            this.tsMenuLarge.Text = "Large Icons";
            this.tsMenuLarge.Click += new System.EventHandler(this.menuLarge_Click);
            // 
            // tsMenuSmall
            // 
            this.tsMenuSmall.Name = "tsMenuSmall";
            this.tsMenuSmall.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.tsMenuSmall.Size = new System.Drawing.Size(337, 38);
            this.tsMenuSmall.Text = "Small Icons";
            this.tsMenuSmall.Click += new System.EventHandler(this.menuSmall_Click);
            // 
            // tsMenuList
            // 
            this.tsMenuList.Name = "tsMenuList";
            this.tsMenuList.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
            this.tsMenuList.Size = new System.Drawing.Size(337, 38);
            this.tsMenuList.Text = "List";
            this.tsMenuList.Click += new System.EventHandler(this.menuList_Click);
            // 
            // tsMenuDetails
            // 
            this.tsMenuDetails.Name = "tsMenuDetails";
            this.tsMenuDetails.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.tsMenuDetails.Size = new System.Drawing.Size(337, 38);
            this.tsMenuDetails.Text = "Details";
            this.tsMenuDetails.Click += new System.EventHandler(this.menuDetails_Click);
            // 
            // tsDropNew
            // 
            this.tsDropNew.AutoSize = false;
            this.tsDropNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFolder,
            this.toolStripMenuItemFile});
            this.tsDropNew.Image = global::FileGuide.Properties.Resources.Icon_New;
            this.tsDropNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsDropNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropNew.Margin = new System.Windows.Forms.Padding(40, 1, 0, 2);
            this.tsDropNew.Name = "tsDropNew";
            this.tsDropNew.Size = new System.Drawing.Size(100, 100);
            this.tsDropNew.Text = "New";
            this.tsDropNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItemFolder
            // 
            this.toolStripMenuItemFolder.Name = "toolStripMenuItemFolder";
            this.toolStripMenuItemFolder.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemFolder.Size = new System.Drawing.Size(295, 38);
            this.toolStripMenuItemFolder.Text = "Folder";
            this.toolStripMenuItemFolder.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(295, 38);
            this.toolStripMenuItemFile.Text = "File";
            this.toolStripMenuItemFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripButtonZip
            // 
            this.toolStripButtonZip.AutoSize = false;
            this.toolStripButtonZip.Image = global::FileGuide.Properties.Resources.Logo_RAR;
            this.toolStripButtonZip.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonZip.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonZip.Margin = new System.Windows.Forms.Padding(20, 2, 0, 3);
            this.toolStripButtonZip.Name = "toolStripButtonZip";
            this.toolStripButtonZip.Size = new System.Drawing.Size(140, 100);
            this.toolStripButtonZip.Text = "Zip/Unzip";
            this.toolStripButtonZip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonZip.ToolTipText = "Zip/Unzip (Alt+(Shift)+Z)\r\n";
            // 
            // toolStripButtonPin
            // 
            this.toolStripButtonPin.AutoSize = false;
            this.toolStripButtonPin.Image = global::FileGuide.Properties.Resources.Icon_Pin;
            this.toolStripButtonPin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonPin.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonPin.Margin = new System.Windows.Forms.Padding(20, 2, 0, 3);
            this.toolStripButtonPin.Name = "toolStripButtonPin";
            this.toolStripButtonPin.Size = new System.Drawing.Size(140, 100);
            this.toolStripButtonPin.Text = "Pin";
            this.toolStripButtonPin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonPin.ToolTipText = "Pin (Ctrl+P)\r\n";
            this.toolStripButtonPin.Click += new System.EventHandler(this.pinToolStripMenuItem_Click);
            // 
            // toolStripButtonDarkMode
            // 
            this.toolStripButtonDarkMode.AutoSize = false;
            this.toolStripButtonDarkMode.Image = global::FileGuide.Properties.Resources.Icon_DarkMode;
            this.toolStripButtonDarkMode.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonDarkMode.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonDarkMode.Margin = new System.Windows.Forms.Padding(20, 2, 0, 3);
            this.toolStripButtonDarkMode.Name = "toolStripButtonDarkMode";
            this.toolStripButtonDarkMode.Size = new System.Drawing.Size(140, 100);
            this.toolStripButtonDarkMode.Text = "Dark Mode";
            this.toolStripButtonDarkMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDarkMode.ToolTipText = "DarkMode (Ctrl+D)\r\n";
            this.toolStripButtonDarkMode.Click += new System.EventHandler(this.toolStripButtonDarkMode_Click);
            // 
            // ShortcutKeysMenu
            // 
            this.ShortcutKeysMenu.AutoSize = false;
            this.ShortcutKeysMenu.BackColor = System.Drawing.Color.White;
            this.ShortcutKeysMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.ShortcutKeysMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ShortcutKeysMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ShortcutKeysMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1});
            this.ShortcutKeysMenu.Location = new System.Drawing.Point(532, 0);
            this.ShortcutKeysMenu.Name = "ShortcutKeysMenu";
            this.ShortcutKeysMenu.Size = new System.Drawing.Size(271, 10);
            this.ShortcutKeysMenu.TabIndex = 6;
            this.ShortcutKeysMenu.Text = "menuStrip1";
            this.ShortcutKeysMenu.Visible = false;
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.copyToolStripMenuItem2,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem1,
            this.newItemToolStripMenuItem,
            this.newFoldẻToolStripMenuItem,
            this.viewLargeIconToolStripMenuItem,
            this.viewDetailsToolStripMenuItem,
            this.darkModeToolStripMenuItem,
            this.zipToolStripMenuItem,
            this.unzipToolStripMenuItem,
            this.pinToolStripMenuItem2,
            this.unpinToolStripMenuItem});
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(70, 6);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Visible = false;
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(343, 34);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(343, 34);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // copyToolStripMenuItem2
            // 
            this.copyToolStripMenuItem2.Name = "copyToolStripMenuItem2";
            this.copyToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem2.Size = new System.Drawing.Size(343, 34);
            this.copyToolStripMenuItem2.Text = "Copy";
            this.copyToolStripMenuItem2.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(343, 34);
            this.renameToolStripMenuItem1.Text = "Rename";
            this.renameToolStripMenuItem1.Click += new System.EventHandler(this.menuRename_Click);
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.newItemToolStripMenuItem.Text = "New Item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newFoldẻToolStripMenuItem
            // 
            this.newFoldẻToolStripMenuItem.Name = "newFoldẻToolStripMenuItem";
            this.newFoldẻToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newFoldẻToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.newFoldẻToolStripMenuItem.Text = "New folder ";
            this.newFoldẻToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // viewLargeIconToolStripMenuItem
            // 
            this.viewLargeIconToolStripMenuItem.Name = "viewLargeIconToolStripMenuItem";
            this.viewLargeIconToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.viewLargeIconToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.viewLargeIconToolStripMenuItem.Text = "View Large Icon";
            this.viewLargeIconToolStripMenuItem.Click += new System.EventHandler(this.menuLarge_Click);
            this.viewLargeIconToolStripMenuItem.DoubleClick += new System.EventHandler(this.menuLarge_Click);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.menuDetails_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.darkModeToolStripMenuItem.Text = "DarkMode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonDarkMode_Click);
            // 
            // zipToolStripMenuItem
            // 
            this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
            this.zipToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.zipToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.zipToolStripMenuItem.Text = "Zip";
            this.zipToolStripMenuItem.Click += new System.EventHandler(this.zipFilesToolStripMenuItem_Click);
            // 
            // unzipToolStripMenuItem
            // 
            this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
            this.unzipToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.unzipToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.unzipToolStripMenuItem.Text = "Unzip";
            this.unzipToolStripMenuItem.Click += new System.EventHandler(this.unzipFileToolStripMenuItem_Click);
            // 
            // pinToolStripMenuItem2
            // 
            this.pinToolStripMenuItem2.Name = "pinToolStripMenuItem2";
            this.pinToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pinToolStripMenuItem2.Size = new System.Drawing.Size(343, 34);
            this.pinToolStripMenuItem2.Text = "Pin";
            this.pinToolStripMenuItem2.Click += new System.EventHandler(this.pinToolStripMenuItem_Click);
            // 
            // unpinToolStripMenuItem
            // 
            this.unpinToolStripMenuItem.Name = "unpinToolStripMenuItem";
            this.unpinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.unpinToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.unpinToolStripMenuItem.Text = "Unpin";
            this.unpinToolStripMenuItem.Click += new System.EventHandler(this.unpingFromEasyAccessToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1778, 844);
            this.Controls.Add(this.ShortcutKeysMenu);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.ShortcutKeysMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  File Guide";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.FrmMain_Resize);
            this.SizeChanged += new System.EventHandler(this.FrmMain_Resize);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripListView.ResumeLayout(false);
            this.contextMenuStripListViewItem.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.tabWindow.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutFirstPage.ResumeLayout(false);
            this.tsPath.ResumeLayout(false);
            this.tsPath.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.ShortcutKeysPanel.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ShortcutKeysMenu.ResumeLayout(false);
            this.ShortcutKeysMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FileGuide.DoubleBufferedListView listView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateModified;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
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
        private FileGuide.DoubleBufferedListView listViewRecentFiles;
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
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ColumnHeader colType;
        private FileGuide.CustomTabControl tabWindow;
        private System.Windows.Forms.TabPage tabPlus;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem pinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpingFromEasyAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton tsbtnRename;
        private System.Windows.Forms.ToolStripDropDownButton tsDropNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.MenuStrip ShortcutKeysMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFoldẻToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLargeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel ShortcutKeysPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem zipFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unzipFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonDarkMode;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton toolStripButtonZip;
        private System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonPin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem pinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pinToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem unpinToolStripMenuItem;
    }
}

