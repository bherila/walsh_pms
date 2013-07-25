namespace WalshApp {
    partial class frmUploadFolder {
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.lblChooseFolder = new System.Windows.Forms.Label();
            this.grpWarning = new DevExpress.XtraEditors.GroupControl();
            this.lblWarningFileOverwrite = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkNotifyComplete = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowProgress = new DevExpress.XtraEditors.CheckEdit();
            this.chkIncludeSubfolders = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.lblFilesSelected = new System.Windows.Forms.Label();
            this.dlgFolders = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpWarning)).BeginInit();
            this.grpWarning.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNotifyComplete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeSubfolders.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdit1.Location = new System.Drawing.Point(15, 53);
            this.buttonEdit1.Name = "buttonEdit1";
            toolTipTitleItem1.Appearance.Image = global::WalshApp.Properties.Resources.folder;
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = global::WalshApp.Properties.Resources.folder;
            toolTipTitleItem1.Text = "Browse for folder";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Select a folder on your computer that contains the files you want to add. ";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "B&rowse...", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, global::WalshApp.Properties.Resources.folder, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)), serializableAppearanceObject1, "", null, superToolTip1)});
            this.buttonEdit1.Size = new System.Drawing.Size(560, 22);
            this.buttonEdit1.TabIndex = 0;
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            this.buttonEdit1.EditValueChanged += new System.EventHandler(this.buttonEdit1_EditValueChanged);
            this.buttonEdit1.Leave += new System.EventHandler(this.buttonEdit1_Leave);
            this.buttonEdit1.TextChanged += new System.EventHandler(this.buttonEdit1_TextChanged);
            // 
            // lblChooseFolder
            // 
            this.lblChooseFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChooseFolder.Location = new System.Drawing.Point(15, 15);
            this.lblChooseFolder.Name = "lblChooseFolder";
            this.lblChooseFolder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblChooseFolder.Size = new System.Drawing.Size(560, 38);
            this.lblChooseFolder.TabIndex = 4;
            this.lblChooseFolder.Text = "Choose the folder on your computer that contains the files you want to add:";
            // 
            // grpWarning
            // 
            this.grpWarning.AppearanceCaption.Image = global::WalshApp.Properties.Resources.exclamation;
            this.grpWarning.AppearanceCaption.Options.UseImage = true;
            this.grpWarning.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.grpWarning.Controls.Add(this.lblWarningFileOverwrite);
            this.grpWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpWarning.Location = new System.Drawing.Point(10, 232);
            this.grpWarning.Name = "grpWarning";
            this.grpWarning.Size = new System.Drawing.Size(180, 87);
            this.grpWarning.TabIndex = 5;
            this.grpWarning.Text = "Warning";
            // 
            // lblWarningFileOverwrite
            // 
            this.lblWarningFileOverwrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarningFileOverwrite.Location = new System.Drawing.Point(2, 20);
            this.lblWarningFileOverwrite.Name = "lblWarningFileOverwrite";
            this.lblWarningFileOverwrite.Size = new System.Drawing.Size(176, 65);
            this.lblWarningFileOverwrite.TabIndex = 0;
            this.lblWarningFileOverwrite.Text = "Any files that exist in the destination will be updated to match the imported cop" +
                "y.";
            this.lblWarningFileOverwrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkNotifyComplete);
            this.panel1.Controls.Add(this.chkShowProgress);
            this.panel1.Controls.Add(this.chkIncludeSubfolders);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.grpWarning);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(375, 75);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(200, 329);
            this.panel1.TabIndex = 6;
            // 
            // chkNotifyComplete
            // 
            this.chkNotifyComplete.EditValue = true;
            this.chkNotifyComplete.Location = new System.Drawing.Point(26, 66);
            this.chkNotifyComplete.Name = "chkNotifyComplete";
            this.chkNotifyComplete.Properties.Caption = "&Notify When Completed";
            this.chkNotifyComplete.Size = new System.Drawing.Size(161, 18);
            this.chkNotifyComplete.TabIndex = 10;
            // 
            // chkShowProgress
            // 
            this.chkShowProgress.Location = new System.Drawing.Point(26, 42);
            this.chkShowProgress.Name = "chkShowProgress";
            this.chkShowProgress.Properties.Caption = "Show &Progress For Each File";
            this.chkShowProgress.Size = new System.Drawing.Size(161, 18);
            this.chkShowProgress.TabIndex = 9;
            // 
            // chkIncludeSubfolders
            // 
            this.chkIncludeSubfolders.EditValue = true;
            this.chkIncludeSubfolders.Location = new System.Drawing.Point(26, 18);
            this.chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            this.chkIncludeSubfolders.Properties.Caption = "Include &Subfolders";
            this.chkIncludeSubfolders.Size = new System.Drawing.Size(141, 18);
            this.chkIncludeSubfolders.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Image = global::WalshApp.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(58, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            toolTipItem2.Text = "Cancels the file import process. You will lose any settings made in this dialog.";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnCancel.SuperTip = superToolTip2;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.Enabled = false;
            this.btnOk.Image = global::WalshApp.Properties.Resources.accept;
            this.btnOk.Location = new System.Drawing.Point(58, 131);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 30);
            toolTipItem3.Text = "Uploads the selected files immediately.";
            superToolTip3.Items.Add(toolTipItem3);
            this.btnOk.SuperTip = superToolTip3;
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "O&K";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstFiles);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 75);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel2.Size = new System.Drawing.Size(360, 329);
            this.panel2.TabIndex = 7;
            // 
            // lstFiles
            // 
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.Location = new System.Drawing.Point(0, 42);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(360, 287);
            this.lstFiles.TabIndex = 1;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File name";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 83;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalSize);
            this.panel3.Controls.Add(this.lblFilesSelected);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 22);
            this.panel3.TabIndex = 0;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalSize.Location = new System.Drawing.Point(332, 0);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(28, 13);
            this.lblTotalSize.TabIndex = 1;
            this.lblTotalSize.Text = "0 KB";
            // 
            // lblFilesSelected
            // 
            this.lblFilesSelected.AutoSize = true;
            this.lblFilesSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFilesSelected.Location = new System.Drawing.Point(0, 0);
            this.lblFilesSelected.Name = "lblFilesSelected";
            this.lblFilesSelected.Size = new System.Drawing.Size(75, 13);
            this.lblFilesSelected.TabIndex = 0;
            this.lblFilesSelected.Text = "Files selected:";
            // 
            // dlgFolders
            // 
            this.dlgFolders.Description = "Select Folder";
            this.dlgFolders.ShowNewFolderButton = false;
            // 
            // frmUploadFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.lblChooseFolder);
            this.MinimumSize = new System.Drawing.Size(359, 390);
            this.Name = "frmUploadFolder";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Import Folder";
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpWarning)).EndInit();
            this.grpWarning.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkNotifyComplete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeSubfolders.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraEditors.GroupControl grpWarning;
        private System.Windows.Forms.Label lblWarningFileOverwrite;
        private System.Windows.Forms.Label lblChooseFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Label lblFilesSelected;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.FolderBrowserDialog dlgFolders;
        private DevExpress.XtraEditors.CheckEdit chkShowProgress;
        private DevExpress.XtraEditors.CheckEdit chkIncludeSubfolders;
        private DevExpress.XtraEditors.CheckEdit chkNotifyComplete;
    }
}