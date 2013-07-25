namespace WalshApp {
    partial class frmSecurity {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurity));
            this.pm_security = new WalshApp.pm_security();
            this.pm_securityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pm_securityTableAdapter = new WalshApp.pm_securityTableAdapters.pm_securityTableAdapter();
            this.tableAdapterManager = new WalshApp.pm_securityTableAdapters.TableAdapterManager();
            this.pm_securityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pm_securityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pm_securityGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobject_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccessor_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccessor_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_read = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colax_write = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_view_info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_comment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_read_historical = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_manage_historical = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_rename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_copy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_chmod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colax_chown = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_security)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_securityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_securityBindingNavigator)).BeginInit();
            this.pm_securityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pm_securityGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pm_security
            // 
            this.pm_security.DataSetName = "pm_security";
            this.pm_security.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pm_securityBindingSource
            // 
            this.pm_securityBindingSource.DataMember = "pm_security";
            this.pm_securityBindingSource.DataSource = this.pm_security;
            // 
            // pm_securityTableAdapter
            // 
            this.pm_securityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pm_securityTableAdapter = this.pm_securityTableAdapter;
            this.tableAdapterManager.UpdateOrder = WalshApp.pm_securityTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pm_securityBindingNavigator
            // 
            this.pm_securityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pm_securityBindingNavigator.BindingSource = this.pm_securityBindingSource;
            this.pm_securityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pm_securityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pm_securityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pm_securityBindingNavigatorSaveItem});
            this.pm_securityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pm_securityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pm_securityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pm_securityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pm_securityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pm_securityBindingNavigator.Name = "pm_securityBindingNavigator";
            this.pm_securityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pm_securityBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.pm_securityBindingNavigator.TabIndex = 0;
            this.pm_securityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pm_securityBindingNavigatorSaveItem
            // 
            this.pm_securityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pm_securityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pm_securityBindingNavigatorSaveItem.Image")));
            this.pm_securityBindingNavigatorSaveItem.Name = "pm_securityBindingNavigatorSaveItem";
            this.pm_securityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pm_securityBindingNavigatorSaveItem.Text = "Save Data";
            this.pm_securityBindingNavigatorSaveItem.Click += new System.EventHandler(this.pm_securityBindingNavigatorSaveItem_Click);
            // 
            // pm_securityGridControl
            // 
            this.pm_securityGridControl.DataSource = this.pm_securityBindingSource;
            this.pm_securityGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pm_securityGridControl.EmbeddedNavigator.Name = "";
            this.pm_securityGridControl.FormsUseDefaultLookAndFeel = false;
            this.pm_securityGridControl.Location = new System.Drawing.Point(0, 25);
            this.pm_securityGridControl.MainView = this.gridView1;
            this.pm_securityGridControl.Name = "pm_securityGridControl";
            this.pm_securityGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemCheckEdit1});
            this.pm_securityGridControl.Size = new System.Drawing.Size(643, 349);
            this.pm_securityGridControl.TabIndex = 1;
            this.pm_securityGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colobject_id,
            this.colaccessor_id,
            this.colaccessor_type,
            this.gridColumn2,
            this.colax_read,
            this.colax_write,
            this.colax_view_info,
            this.colax_comment,
            this.colax_read_historical,
            this.colax_manage_historical,
            this.colax_rename,
            this.colax_delete,
            this.colax_copy,
            this.colax_chmod,
            this.colax_chown});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(670, 326, 208, 191);
            this.gridView1.GridControl = this.pm_securityGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 29;
            // 
            // colobject_id
            // 
            this.colobject_id.FieldName = "object_id";
            this.colobject_id.Name = "colobject_id";
            this.colobject_id.Width = 20;
            // 
            // colaccessor_id
            // 
            this.colaccessor_id.Caption = "accessor_id";
            this.colaccessor_id.FieldName = "accessor_id";
            this.colaccessor_id.Name = "colaccessor_id";
            this.colaccessor_id.Width = 20;
            // 
            // colaccessor_type
            // 
            this.colaccessor_type.Caption = "accessor_type";
            this.colaccessor_type.FieldName = "accessor_type";
            this.colaccessor_type.Name = "colaccessor_type";
            this.colaccessor_type.Width = 20;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Accessor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 100;
            // 
            // colax_read
            // 
            this.colax_read.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_read.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_read.Caption = "R";
            this.colax_read.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_read.FieldName = "ax_read";
            this.colax_read.Name = "colax_read";
            this.colax_read.Visible = true;
            this.colax_read.VisibleIndex = 2;
            this.colax_read.Width = 25;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 3;
            this.repositoryItemCheckEdit1.ValueGrayed = 5;
            this.repositoryItemCheckEdit1.ValueUnchecked = 1;
            // 
            // colax_write
            // 
            this.colax_write.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_write.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_write.Caption = "W";
            this.colax_write.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_write.FieldName = "ax_write";
            this.colax_write.Name = "colax_write";
            this.colax_write.Visible = true;
            this.colax_write.VisibleIndex = 3;
            this.colax_write.Width = 25;
            // 
            // colax_view_info
            // 
            this.colax_view_info.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_view_info.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_view_info.Caption = "i";
            this.colax_view_info.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_view_info.FieldName = "ax_view_info";
            this.colax_view_info.Name = "colax_view_info";
            this.colax_view_info.Visible = true;
            this.colax_view_info.VisibleIndex = 4;
            this.colax_view_info.Width = 25;
            // 
            // colax_comment
            // 
            this.colax_comment.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_comment.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_comment.Caption = "c";
            this.colax_comment.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_comment.FieldName = "ax_comment";
            this.colax_comment.Name = "colax_comment";
            this.colax_comment.Visible = true;
            this.colax_comment.VisibleIndex = 5;
            this.colax_comment.Width = 25;
            // 
            // colax_read_historical
            // 
            this.colax_read_historical.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_read_historical.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_read_historical.Caption = "H/r";
            this.colax_read_historical.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_read_historical.FieldName = "ax_read_historical";
            this.colax_read_historical.Name = "colax_read_historical";
            this.colax_read_historical.Visible = true;
            this.colax_read_historical.VisibleIndex = 6;
            this.colax_read_historical.Width = 25;
            // 
            // colax_manage_historical
            // 
            this.colax_manage_historical.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_manage_historical.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_manage_historical.Caption = "H/w";
            this.colax_manage_historical.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_manage_historical.FieldName = "ax_manage_historical";
            this.colax_manage_historical.Name = "colax_manage_historical";
            this.colax_manage_historical.Visible = true;
            this.colax_manage_historical.VisibleIndex = 7;
            this.colax_manage_historical.Width = 25;
            // 
            // colax_rename
            // 
            this.colax_rename.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_rename.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_rename.Caption = "ren";
            this.colax_rename.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_rename.FieldName = "ax_rename";
            this.colax_rename.Name = "colax_rename";
            this.colax_rename.Visible = true;
            this.colax_rename.VisibleIndex = 8;
            this.colax_rename.Width = 25;
            // 
            // colax_delete
            // 
            this.colax_delete.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_delete.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_delete.Caption = "del";
            this.colax_delete.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_delete.FieldName = "ax_delete";
            this.colax_delete.Name = "colax_delete";
            this.colax_delete.Visible = true;
            this.colax_delete.VisibleIndex = 9;
            this.colax_delete.Width = 25;
            // 
            // colax_copy
            // 
            this.colax_copy.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_copy.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_copy.Caption = "cp";
            this.colax_copy.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_copy.FieldName = "ax_copy";
            this.colax_copy.Name = "colax_copy";
            this.colax_copy.Visible = true;
            this.colax_copy.VisibleIndex = 10;
            this.colax_copy.Width = 25;
            // 
            // colax_chmod
            // 
            this.colax_chmod.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_chmod.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_chmod.Caption = "pm";
            this.colax_chmod.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_chmod.FieldName = "ax_chmod";
            this.colax_chmod.Name = "colax_chmod";
            this.colax_chmod.Visible = true;
            this.colax_chmod.VisibleIndex = 11;
            this.colax_chmod.Width = 25;
            // 
            // colax_chown
            // 
            this.colax_chown.AppearanceHeader.Options.UseTextOptions = true;
            this.colax_chown.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.colax_chown.Caption = "own";
            this.colax_chown.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colax_chown.FieldName = "ax_chown";
            this.colax_chown.Name = "colax_chown";
            this.colax_chown.Visible = true;
            this.colax_chown.VisibleIndex = 12;
            this.colax_chown.Width = 53;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // frmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 374);
            this.Controls.Add(this.pm_securityGridControl);
            this.Controls.Add(this.pm_securityBindingNavigator);
            this.Name = "frmSecurity";
            this.Text = "Object Security";
            this.Load += new System.EventHandler(this.frmSecurity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pm_security)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_securityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_securityBindingNavigator)).EndInit();
            this.pm_securityBindingNavigator.ResumeLayout(false);
            this.pm_securityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pm_securityGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pm_security pm_security;
        private System.Windows.Forms.BindingSource pm_securityBindingSource;
        private WalshApp.pm_securityTableAdapters.pm_securityTableAdapter pm_securityTableAdapter;
        private WalshApp.pm_securityTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pm_securityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pm_securityBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl pm_securityGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colobject_id;
        private DevExpress.XtraGrid.Columns.GridColumn colaccessor_id;
        private DevExpress.XtraGrid.Columns.GridColumn colaccessor_type;
        private DevExpress.XtraGrid.Columns.GridColumn colax_read;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colax_write;
        private DevExpress.XtraGrid.Columns.GridColumn colax_view_info;
        private DevExpress.XtraGrid.Columns.GridColumn colax_comment;
        private DevExpress.XtraGrid.Columns.GridColumn colax_read_historical;
        private DevExpress.XtraGrid.Columns.GridColumn colax_manage_historical;
        private DevExpress.XtraGrid.Columns.GridColumn colax_rename;
        private DevExpress.XtraGrid.Columns.GridColumn colax_delete;
        private DevExpress.XtraGrid.Columns.GridColumn colax_copy;
        private DevExpress.XtraGrid.Columns.GridColumn colax_chmod;
        private DevExpress.XtraGrid.Columns.GridColumn colax_chown;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;

    }
}