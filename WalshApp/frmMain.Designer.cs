namespace WalshApp {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.tree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmFolderNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.cmTree = new DevExpress.XtraBars.PopupMenu(this.components);
            this.mnuNew = new DevExpress.XtraBars.BarSubItem();
            this.mnuFileUpload = new DevExpress.XtraBars.BarButtonItem();
            this.mnuNewSubfolder = new DevExpress.XtraBars.BarButtonItem();
            this.mnuFileFromTemplate = new DevExpress.XtraBars.BarButtonItem();
            this.mnuFolderFromComputer = new DevExpress.XtraBars.BarButtonItem();
            this.mnuNewProjectFromTemplate = new DevExpress.XtraBars.BarButtonItem();
            this.mnuProjectFromComputer = new DevExpress.XtraBars.BarButtonItem();
            this.btnRename = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSwitchToRevision = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.mnuRefreshTree = new DevExpress.XtraBars.BarButtonItem();
            this.mnuChangeUser = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSendByEmail = new DevExpress.XtraBars.BarButtonItem();
            this.btnFulfillRFI = new DevExpress.XtraBars.BarButtonItem();
            this.mnuClearCompletedItems = new DevExpress.XtraBars.BarButtonItem();
            this.pageGeneral = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lstTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.cmQueue = new DevExpress.XtraBars.PopupMenu(this.components);
            this.cmNewSubmenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.cmFolderNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmNewSubmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.FullRowSelect = true;
            this.tree.HideSelection = false;
            this.tree.ImageIndex = 0;
            this.tree.ImageList = this.imageList1;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.ribbonControl1.SetPopupContextMenu(this.tree, this.cmTree);
            this.tree.SelectedImageIndex = 0;
            this.tree.Size = new System.Drawing.Size(194, 223);
            this.tree.TabIndex = 0;
            this.tree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseDoubleClick);
            this.tree.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterCollapse);
            this.tree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tree_AfterLabelEdit);
            this.tree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tree_BeforeExpand);
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            this.tree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tree_KeyPress);
            this.tree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tree_KeyUp);
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            this.tree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tree_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "page_white.png");
            this.imageList1.Images.SetKeyName(2, "page_white_acrobat.png");
            this.imageList1.Images.SetKeyName(3, "page_white_excel.png");
            this.imageList1.Images.SetKeyName(4, "page_white_add.png");
            this.imageList1.Images.SetKeyName(5, "page_white_camera.png");
            this.imageList1.Images.SetKeyName(6, "page_white_compressed.png");
            this.imageList1.Images.SetKeyName(7, "page_white_office.png");
            this.imageList1.Images.SetKeyName(8, "page_white_picture.png");
            this.imageList1.Images.SetKeyName(9, "page_white_powerpoint.png");
            this.imageList1.Images.SetKeyName(10, "page_white_ruby.png");
            this.imageList1.Images.SetKeyName(11, "page_white_text.png");
            this.imageList1.Images.SetKeyName(12, "page_white_word.png");
            this.imageList1.Images.SetKeyName(13, "database.png");
            this.imageList1.Images.SetKeyName(14, "package.png");
            this.imageList1.Images.SetKeyName(15, "folder_user.png");
            this.imageList1.Images.SetKeyName(16, "folder_user.png");
            this.imageList1.Images.SetKeyName(17, "folder_user.png");
            this.imageList1.Images.SetKeyName(18, "user.png");
            this.imageList1.Images.SetKeyName(19, "group.png");
            // 
            // cmFolderNode
            // 
            this.cmFolderNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem3,
            this.deleteToolStripMenuItem1,
            this.propertiesToolStripMenuItem});
            this.cmFolderNode.Name = "cmFolderNode";
            this.cmFolderNode.Size = new System.Drawing.Size(128, 76);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::WalshApp.Properties.Resources.arrow_refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 6);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = global::WalshApp.Properties.Resources.delete;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.KeyTip = "";
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.KeyTip = "";
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonKeyTip = "";
            this.ribbonControl1.ApplicationCaption = "The Walsh Company";
            this.ribbonControl1.ApplicationIcon = global::WalshApp.Properties.Resources.folder_remote;
            this.ribbonControl1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("New Items", new System.Guid("dba05bf9-2a22-4e22-8a1e-a13515e3d343")),
            new DevExpress.XtraBars.BarManagerCategory("File Operations", new System.Guid("ff2773f7-32d5-40d7-88d8-2b9fe5a588c7"))});
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuChangeUser,
            this.mnuExit,
            this.mnuNewSubfolder,
            this.mnuNewProjectFromTemplate,
            this.mnuFileUpload,
            this.mnuFileFromTemplate,
            this.mnuNew,
            this.btnDelete,
            this.btnRename,
            this.btnUpdate,
            this.btnSendByEmail,
            this.btnFulfillRFI,
            this.btnSwitchToRevision,
            this.mnuRefreshTree,
            this.mnuFolderFromComputer,
            this.mnuProjectFromComputer,
            this.mnuClearCompletedItems});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 25;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageGeneral});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbonControl1.SelectedPage = this.pageGeneral;
            this.ribbonControl1.Size = new System.Drawing.Size(767, 148);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.mnuNewSubfolder);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.mnuFileUpload);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btnUpdate);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btnSendByEmail);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.mnuClearCompletedItems);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // cmTree
            // 
            this.cmTree.ItemLinks.Add(this.mnuNew);
            this.cmTree.ItemLinks.Add(this.btnRename);
            this.cmTree.ItemLinks.Add(this.btnDelete);
            this.cmTree.ItemLinks.Add(this.btnSwitchToRevision);
            this.cmTree.ItemLinks.Add(this.btnUpdate, true);
            this.cmTree.ItemLinks.Add(this.mnuRefreshTree);
            this.cmTree.Name = "cmTree";
            this.cmTree.Ribbon = this.ribbonControl1;
            // 
            // mnuNew
            // 
            this.mnuNew.Caption = "New";
            this.mnuNew.Id = 9;
            this.mnuNew.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuFileUpload),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuNewSubfolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuFileFromTemplate),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuFolderFromComputer),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuNewProjectFromTemplate),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuProjectFromComputer)});
            this.mnuNew.Name = "mnuNew";
            // 
            // mnuFileUpload
            // 
            this.mnuFileUpload.Caption = "File from Computer";
            this.mnuFileUpload.CategoryGuid = new System.Guid("dba05bf9-2a22-4e22-8a1e-a13515e3d343");
            this.mnuFileUpload.Glyph = global::WalshApp.Properties.Resources.page_add;
            this.mnuFileUpload.Id = 7;
            this.mnuFileUpload.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.mnuFileUpload.LargeGlyph = global::WalshApp.Properties.Resources.document_new;
            this.mnuFileUpload.Name = "mnuFileUpload";
            this.mnuFileUpload.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            toolTipTitleItem1.Text = "File Upload";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Transfers a file from your computer to the file management system. ";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.mnuFileUpload.SuperTip = superToolTip1;
            this.mnuFileUpload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuFileUpload_ItemClick);
            // 
            // mnuNewSubfolder
            // 
            this.mnuNewSubfolder.Caption = "Subfolder";
            this.mnuNewSubfolder.CategoryGuid = new System.Guid("dba05bf9-2a22-4e22-8a1e-a13515e3d343");
            this.mnuNewSubfolder.Glyph = global::WalshApp.Properties.Resources.folder_add;
            this.mnuNewSubfolder.Id = 5;
            this.mnuNewSubfolder.Name = "mnuNewSubfolder";
            this.mnuNewSubfolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuNewSubfolder_ItemClick);
            // 
            // mnuFileFromTemplate
            // 
            this.mnuFileFromTemplate.Caption = "File From Template";
            this.mnuFileFromTemplate.CategoryGuid = new System.Guid("dba05bf9-2a22-4e22-8a1e-a13515e3d343");
            this.mnuFileFromTemplate.Glyph = global::WalshApp.Properties.Resources.application_add;
            this.mnuFileFromTemplate.Id = 8;
            this.mnuFileFromTemplate.Name = "mnuFileFromTemplate";
            this.mnuFileFromTemplate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuFileFromTemplate_ItemClick);
            // 
            // mnuFolderFromComputer
            // 
            this.mnuFolderFromComputer.Caption = "Folder from Computer";
            this.mnuFolderFromComputer.Glyph = global::WalshApp.Properties.Resources.folder_add;
            this.mnuFolderFromComputer.Id = 22;
            this.mnuFolderFromComputer.Name = "mnuFolderFromComputer";
            this.mnuFolderFromComputer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuFolderFromComputer_ItemClick);
            // 
            // mnuNewProjectFromTemplate
            // 
            this.mnuNewProjectFromTemplate.Caption = "Project";
            this.mnuNewProjectFromTemplate.CategoryGuid = new System.Guid("dba05bf9-2a22-4e22-8a1e-a13515e3d343");
            this.mnuNewProjectFromTemplate.Glyph = global::WalshApp.Properties.Resources.package_add;
            this.mnuNewProjectFromTemplate.Id = 6;
            this.mnuNewProjectFromTemplate.Name = "mnuNewProjectFromTemplate";
            this.mnuNewProjectFromTemplate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuNewProjectFromTemplate_ItemClick);
            // 
            // mnuProjectFromComputer
            // 
            this.mnuProjectFromComputer.Caption = "Project From Computer";
            this.mnuProjectFromComputer.Glyph = global::WalshApp.Properties.Resources.package_add;
            this.mnuProjectFromComputer.Id = 23;
            this.mnuProjectFromComputer.Name = "mnuProjectFromComputer";
            this.mnuProjectFromComputer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuProjectFromComputer_ItemClick);
            // 
            // btnRename
            // 
            this.btnRename.Caption = "&Rename";
            this.btnRename.Glyph = global::WalshApp.Properties.Resources.pencil;
            this.btnRename.Id = 16;
            this.btnRename.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnRename.Name = "btnRename";
            this.btnRename.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRename_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "&Delete";
            this.btnDelete.Glyph = global::WalshApp.Properties.Resources.delete;
            this.btnDelete.Id = 12;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSwitchToRevision
            // 
            this.btnSwitchToRevision.Caption = "Switch to Re&vision...";
            this.btnSwitchToRevision.Glyph = global::WalshApp.Properties.Resources.hourglass;
            this.btnSwitchToRevision.Id = 20;
            this.btnSwitchToRevision.Name = "btnSwitchToRevision";
            this.btnSwitchToRevision.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSwitchToRevision_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "&Update";
            this.btnUpdate.Glyph = global::WalshApp.Properties.Resources.arrow_refresh;
            this.btnUpdate.Id = 17;
            this.btnUpdate.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // mnuRefreshTree
            // 
            this.mnuRefreshTree.Caption = "&Reload Tree";
            this.mnuRefreshTree.Glyph = global::WalshApp.Properties.Resources.arrow_refresh;
            this.mnuRefreshTree.Id = 21;
            this.mnuRefreshTree.Name = "mnuRefreshTree";
            this.mnuRefreshTree.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuRefreshTree_ItemClick);
            // 
            // mnuChangeUser
            // 
            this.mnuChangeUser.Caption = "Change &User...";
            this.mnuChangeUser.Id = 2;
            this.mnuChangeUser.Name = "mnuChangeUser";
            // 
            // mnuExit
            // 
            this.mnuExit.Caption = "E&xit";
            this.mnuExit.Id = 3;
            this.mnuExit.Name = "mnuExit";
            // 
            // btnSendByEmail
            // 
            this.btnSendByEmail.Caption = "Send by E-&Mail";
            this.btnSendByEmail.Glyph = global::WalshApp.Properties.Resources.attach;
            this.btnSendByEmail.Id = 18;
            this.btnSendByEmail.Name = "btnSendByEmail";
            this.btnSendByEmail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSendByEmail_ItemClick);
            // 
            // btnFulfillRFI
            // 
            this.btnFulfillRFI.Caption = "Fulfill RFI";
            this.btnFulfillRFI.Enabled = false;
            this.btnFulfillRFI.Glyph = global::WalshApp.Properties.Resources.accept;
            this.btnFulfillRFI.Id = 19;
            this.btnFulfillRFI.Name = "btnFulfillRFI";
            // 
            // mnuClearCompletedItems
            // 
            this.mnuClearCompletedItems.Caption = "Clear Completed Queue Items";
            this.mnuClearCompletedItems.Glyph = global::WalshApp.Properties.Resources.accept;
            this.mnuClearCompletedItems.Id = 24;
            this.mnuClearCompletedItems.Name = "mnuClearCompletedItems";
            toolTipItem2.Text = "Removes items that have finished processing from the Queue.";
            superToolTip2.Items.Add(toolTipItem2);
            this.mnuClearCompletedItems.SuperTip = superToolTip2;
            this.mnuClearCompletedItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuClearCompletedItems_ItemClick);
            // 
            // pageGeneral
            // 
            this.pageGeneral.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.pageGeneral.KeyTip = "F";
            this.pageGeneral.Name = "pageGeneral";
            this.pageGeneral.Text = "Object Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuNewSubfolder);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuNewProjectFromTemplate);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuFileFromTemplate);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuFileUpload);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuFolderFromComputer);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuProjectFromComputer);
            this.ribbonPageGroup1.KeyTip = "";
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "New Items";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRename);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSendByEmail);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnFulfillRFI);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSwitchToRevision);
            this.ribbonPageGroup3.KeyTip = "";
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Selected Item";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 530);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(767, 23);
            // 
            // lstTasks
            // 
            this.lstTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTasks.FullRowSelect = true;
            this.lstTasks.GridLines = true;
            this.lstTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstTasks.Location = new System.Drawing.Point(0, 0);
            this.lstTasks.Name = "lstTasks";
            this.ribbonControl1.SetPopupContextMenu(this.lstTasks, this.cmQueue);
            this.lstTasks.Size = new System.Drawing.Size(761, 95);
            this.lstTasks.TabIndex = 0;
            this.lstTasks.UseCompatibleStateImageBehavior = false;
            this.lstTasks.View = System.Windows.Forms.View.Details;
            this.lstTasks.ItemActivate += new System.EventHandler(this.lstTasks_ItemActivate);
            this.lstTasks.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.lstTasks_RetrieveVirtualItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 150;
            // 
            // cmQueue
            // 
            this.cmQueue.ItemLinks.Add(this.mnuClearCompletedItems);
            this.cmQueue.Name = "cmQueue";
            this.cmQueue.Ribbon = this.ribbonControl1;
            // 
            // cmNewSubmenu
            // 
            this.cmNewSubmenu.ItemLinks.Add(this.mnuNewSubfolder);
            this.cmNewSubmenu.ItemLinks.Add(this.mnuFileUpload);
            this.cmNewSubmenu.ItemLinks.Add(this.mnuFileFromTemplate);
            this.cmNewSubmenu.ItemLinks.Add(this.mnuNewProjectFromTemplate);
            this.cmNewSubmenu.Name = "cmNewSubmenu";
            this.cmNewSubmenu.Ribbon = this.ribbonControl1;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2,
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel2.ID = new System.Guid("6f521f33-e39c-4647-a706-b9c8c4d679cf");
            this.dockPanel2.Location = new System.Drawing.Point(0, 403);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.Size = new System.Drawing.Size(767, 127);
            this.dockPanel2.Text = "Queue";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.lstTasks);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(761, 95);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("f8c14f5f-61ce-4df8-ab07-77bc2a7673a3");
            this.dockPanel1.Location = new System.Drawing.Point(0, 148);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(200, 255);
            this.dockPanel1.Text = "Explorer Tree";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.tree);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(194, 223);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.BottomPaneControlContainer = null;
            this.applicationMenu1.ItemLinks.Add(this.mnuChangeUser);
            this.applicationMenu1.ItemLinks.Add(this.mnuExit);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            this.applicationMenu1.RightPaneControlContainer = null;
            this.applicationMenu1.RightPaneWidth = 240;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tray
            // 
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "The Walsh Company";
            this.tray.Visible = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 553);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "The Walsh Company";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.cmFolderNode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmNewSubmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ContextMenuStrip cmFolderNode;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem mnuChangeUser;
        private DevExpress.XtraBars.BarButtonItem mnuExit;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem mnuNewSubfolder;
        private DevExpress.XtraBars.BarButtonItem mnuNewProjectFromTemplate;
        private DevExpress.XtraBars.BarButtonItem mnuFileUpload;
        private DevExpress.XtraBars.BarButtonItem mnuFileFromTemplate;
        private DevExpress.XtraBars.PopupMenu cmTree;
        private DevExpress.XtraBars.PopupMenu cmNewSubmenu;
        private DevExpress.XtraBars.BarSubItem mnuNew;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageGeneral;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRename;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnSendByEmail;
        private DevExpress.XtraBars.BarButtonItem btnFulfillRFI;
        private DevExpress.XtraBars.BarButtonItem btnSwitchToRevision;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon tray;
        private DevExpress.XtraBars.BarButtonItem mnuRefreshTree;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem mnuFolderFromComputer;
        private DevExpress.XtraBars.BarButtonItem mnuProjectFromComputer;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private System.Windows.Forms.ListView lstTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraBars.BarButtonItem mnuClearCompletedItems;
        private DevExpress.XtraBars.PopupMenu cmQueue;
    }
}

