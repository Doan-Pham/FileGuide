
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
            this.delteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new FileGuide.BufferedTreeView();
            this.treeViewContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.pinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpingFromEasyAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutFirstPage = new System.Windows.Forms.TableLayoutPanel();
            this.tableLblDrives = new System.Windows.Forms.Label();
            this.tableLblRecent = new System.Windows.Forms.Label();
            this.flowLayoutPanelDrives = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.driveName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.listViewRecentFiles = new System.Windows.Forms.ListView();
            this.listViewColRecentPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView = new System.Windows.Forms.ListView();
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
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripListView.SuspendLayout();
            this.contextMenuStripListViewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.treeViewContextMenuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutFirstPage.SuspendLayout();
            this.flowLayoutPanelDrives.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tsPath.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Font = new System.Drawing.Font("Questrial", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLblItemNum,
            this.statusLblNumSelect});
            this.statusStrip1.Location = new System.Drawing.Point(0, 807);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1578, 37);
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
            this.contextMenuStripListView.Size = new System.Drawing.Size(199, 160);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.newToolStripMenuItem.Text = "New";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Image = global::FileGuide.Properties.Resources.Icon_Folder;
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Image = global::FileGuide.Properties.Resources.Logo_UnknownFile;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
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
            this.mainSplitContainer.Panel2.Controls.Add(this.tabControl);
            this.mainSplitContainer.Panel2.Controls.Add(this.tsPath);
            this.mainSplitContainer.Panel2.Controls.Add(this.toolBar);
            this.mainSplitContainer.Size = new System.Drawing.Size(1578, 807);
            this.mainSplitContainer.SplitterDistance = 351;
            this.mainSplitContainer.TabIndex = 5;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.ContextMenuStrip = this.treeViewContextMenuStrip;
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
            this.treeView.Size = new System.Drawing.Size(351, 807);
            this.treeView.TabIndex = 1;
            this.treeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView_DrawNode);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.MouseLeave += new System.EventHandler(this.treeView_MouseLeave);
            this.treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseMove);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseUp);
            // 
            // treeViewContextMenuStrip
            // 
            this.treeViewContextMenuStrip.BackColor = System.Drawing.Color.White;
            this.treeViewContextMenuStrip.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.treeViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinToolStripMenuItem,
            this.unpingFromEasyAccessToolStripMenuItem});
            this.treeViewContextMenuStrip.Name = "treeViewContextMenuStrip";
            this.treeViewContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.treeViewContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.treeViewContextMenuStrip.RenderStyle.ColorTable = null;
            this.treeViewContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.treeViewContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.treeViewContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.treeViewContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.treeViewContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.treeViewContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.treeViewContextMenuStrip.Size = new System.Drawing.Size(302, 76);
            // 
            // pinToolStripMenuItem
            // 
            this.pinToolStripMenuItem.Name = "pinToolStripMenuItem";
            this.pinToolStripMenuItem.Size = new System.Drawing.Size(301, 36);
            this.pinToolStripMenuItem.Text = "Pin to Easy Access";
            this.pinToolStripMenuItem.Click += new System.EventHandler(this.pinToolStripMenuItem_Click);
            // 
            // unpingFromEasyAccessToolStripMenuItem
            // 
            this.unpingFromEasyAccessToolStripMenuItem.Name = "unpingFromEasyAccessToolStripMenuItem";
            this.unpingFromEasyAccessToolStripMenuItem.Size = new System.Drawing.Size(301, 36);
            this.unpingFromEasyAccessToolStripMenuItem.Text = "Unpin from Easy Access";
            this.unpingFromEasyAccessToolStripMenuItem.Click += new System.EventHandler(this.unpingFromEasyAccessToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPlus);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 174);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1223, 633);
            this.tabControl.TabIndex = 4;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutFirstPage);
            this.tabPage1.Controls.Add(this.listView);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1215, 590);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tableLayoutFirstPage.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutFirstPage.Name = "tableLayoutFirstPage";
            this.tableLayoutFirstPage.RowCount = 5;
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFirstPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFirstPage.Size = new System.Drawing.Size(1209, 584);
            this.tableLayoutFirstPage.TabIndex = 1;
            // 
            // tableLblDrives
            // 
            this.tableLblDrives.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLblDrives.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLblDrives.Location = new System.Drawing.Point(3, 0);
            this.tableLblDrives.Name = "tableLblDrives";
            this.tableLblDrives.Size = new System.Drawing.Size(1203, 51);
            this.tableLblDrives.TabIndex = 0;
            this.tableLblDrives.Text = "Drives";
            this.tableLblDrives.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLblRecent
            // 
            this.tableLblRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLblRecent.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLblRecent.Location = new System.Drawing.Point(3, 225);
            this.tableLblRecent.Name = "tableLblRecent";
            this.tableLblRecent.Size = new System.Drawing.Size(1203, 56);
            this.tableLblRecent.TabIndex = 1;
            this.tableLblRecent.Text = "Recent files";
            this.tableLblRecent.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanelDrives
            // 
            this.flowLayoutPanelDrives.AutoScroll = true;
            this.flowLayoutPanelDrives.Controls.Add(this.guna2Panel1);
            this.flowLayoutPanelDrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDrives.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutPanelDrives.Name = "flowLayoutPanelDrives";
            this.flowLayoutPanelDrives.Size = new System.Drawing.Size(1203, 163);
            this.flowLayoutPanelDrives.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 10;
            this.guna2Panel1.Controls.Add(this.driveName);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.guna2ProgressBar1);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.ShadowDecoration.BorderRadius = 10;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(392, 114);
            this.guna2Panel1.TabIndex = 0;
            // 
            // driveName
            // 
            this.driveName.Dock = System.Windows.Forms.DockStyle.Top;
            this.driveName.Location = new System.Drawing.Point(297, 10);
            this.driveName.Name = "driveName";
            this.driveName.Size = new System.Drawing.Size(85, 31);
            this.driveName.TabIndex = 1;
            this.driveName.Text = "Windows SSD (C:)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(297, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.BorderRadius = 10;
            this.guna2ProgressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(10, 10);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(199)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(192)))), ((int)(((byte)(228)))));
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(287, 94);
            this.guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.guna2ProgressBar1.TabIndex = 0;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.Value = 80;
            // 
            // listViewRecentFiles
            // 
            this.listViewRecentFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRecentFiles.BackColor = System.Drawing.Color.White;
            this.listViewRecentFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRecentFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewColRecentPath,
            this.Path});
            this.listViewRecentFiles.FullRowSelect = true;
            this.listViewRecentFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRecentFiles.HideSelection = false;
            this.listViewRecentFiles.Location = new System.Drawing.Point(3, 284);
            this.listViewRecentFiles.Name = "listViewRecentFiles";
            this.listViewRecentFiles.OwnerDraw = true;
            this.listViewRecentFiles.Size = new System.Drawing.Size(1203, 276);
            this.listViewRecentFiles.TabIndex = 3;
            this.listViewRecentFiles.UseCompatibleStateImageBehavior = false;
            this.listViewRecentFiles.View = System.Windows.Forms.View.Details;
            this.listViewRecentFiles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_DrawColumnHeader);
            this.listViewRecentFiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_DrawItem);
            this.listViewRecentFiles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_DrawSubItem);
            this.listViewRecentFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRecentFiles_MouseDoubleClick);
            // 
            // listViewColRecentPath
            // 
            this.listViewColRecentPath.Text = "Name";
            this.listViewColRecentPath.Width = 500;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 600;
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
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(1209, 584);
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
            this.colDateModified.Width = 338;
            // 
            // tabPlus
            // 
            this.tabPlus.Location = new System.Drawing.Point(4, 39);
            this.tabPlus.Name = "tabPlus";
            this.tabPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlus.Size = new System.Drawing.Size(1215, 590);
            this.tabPlus.TabIndex = 0;
            this.tabPlus.Text = " ";
            this.tabPlus.UseVisualStyleBackColor = true;
            // 
            // tsPath
            // 
            this.tsPath.AutoSize = false;
            this.tsPath.BackColor = System.Drawing.Color.White;
            this.tsPath.Font = new System.Drawing.Font("Questrial", 9F);
            this.tsPath.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPath.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnRefresh,
            this.tslbPath,
            this.tscmbPath});
            this.tsPath.Location = new System.Drawing.Point(0, 123);
            this.tsPath.Name = "tsPath";
            this.tsPath.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsPath.Size = new System.Drawing.Size(1223, 51);
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
            this.tslbPath.Size = new System.Drawing.Size(54, 48);
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
            // toolBar
            // 
            this.toolBar.AutoSize = false;
            this.toolBar.BackColor = System.Drawing.Color.White;
            this.toolBar.Font = new System.Drawing.Font("Questrial", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbtnCopy,
            this.tsbtnCut,
            this.tsbtnPaste,
            this.tsbtnDelete,
            this.tsbtnRename,
            this.toolStripSeparator2,
            this.tsDropView,
            this.tsDropNew});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolBar.Size = new System.Drawing.Size(1223, 123);
            this.toolBar.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 123);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.AutoSize = false;
            this.tsbtnCopy.Image = global::FileGuide.Properties.Resources.Icon_Copy;
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
            this.tsbtnCut.Image = global::FileGuide.Properties.Resources.Icon_Cut;
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
            this.tsbtnPaste.Image = global::FileGuide.Properties.Resources.Icon_Paste;
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
            this.tsbtnDelete.Image = global::FileGuide.Properties.Resources.Icon_Delete;
            this.tsbtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnDelete.Margin = new System.Windows.Forms.Padding(8, 2, 0, 3);
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(100, 100);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.tsbtnRename.Click += new System.EventHandler(this.menuRename_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 123);
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
            this.tsDropView.Margin = new System.Windows.Forms.Padding(8, 1, 0, 2);
            this.tsDropView.Name = "tsDropView";
            this.tsDropView.Size = new System.Drawing.Size(100, 100);
            this.tsDropView.Text = "View";
            this.tsDropView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsMenuLarge
            // 
            this.tsMenuLarge.Name = "tsMenuLarge";
            this.tsMenuLarge.Size = new System.Drawing.Size(270, 36);
            this.tsMenuLarge.Text = "Large Icons";
            this.tsMenuLarge.Click += new System.EventHandler(this.menuLarge_Click);
            // 
            // tsMenuSmall
            // 
            this.tsMenuSmall.Name = "tsMenuSmall";
            this.tsMenuSmall.Size = new System.Drawing.Size(270, 36);
            this.tsMenuSmall.Text = "Small Icons";
            this.tsMenuSmall.Click += new System.EventHandler(this.menuSmall_Click);
            // 
            // tsMenuList
            // 
            this.tsMenuList.Name = "tsMenuList";
            this.tsMenuList.Size = new System.Drawing.Size(270, 36);
            this.tsMenuList.Text = "List";
            this.tsMenuList.Click += new System.EventHandler(this.menuList_Click);
            // 
            // tsMenuDetails
            // 
            this.tsMenuDetails.Name = "tsMenuDetails";
            this.tsMenuDetails.Size = new System.Drawing.Size(270, 36);
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
            this.tsDropNew.Margin = new System.Windows.Forms.Padding(8, 1, 0, 2);
            this.tsDropNew.Name = "tsDropNew";
            this.tsDropNew.Size = new System.Drawing.Size(100, 100);
            this.tsDropNew.Text = "New";
            this.tsDropNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItemFolder
            // 
            this.toolStripMenuItemFolder.Name = "toolStripMenuItemFolder";
            this.toolStripMenuItemFolder.Size = new System.Drawing.Size(270, 36);
            this.toolStripMenuItemFolder.Text = "Folder";
            this.toolStripMenuItemFolder.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(270, 36);
            this.toolStripMenuItemFile.Text = "File";
            this.toolStripMenuItemFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripListView.ResumeLayout(false);
            this.contextMenuStripListViewItem.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.treeViewContextMenuStrip.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutFirstPage.ResumeLayout(false);
            this.flowLayoutPanelDrives.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tsPath.ResumeLayout(false);
            this.tsPath.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateModified;
        private System.Windows.Forms.ToolStrip toolBar;
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
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPlus;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label driveName;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip treeViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpingFromEasyAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton tsbtnRename;
        private System.Windows.Forms.ToolStripDropDownButton tsDropNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
    }
}

