using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Threading;

namespace WalshApp {
    public partial class frmUploadFolder : DevExpress.XtraEditors.XtraForm {
       
        private uint parentId;
        private string userToken;

        private frmUploadFolder() {
            InitializeComponent();
        }

        /// <summary>
        /// Sets up a new instance of frmUploadFolder, sets the mdiParent and 
        /// opens the window. Everything else is self managed. The upload process
        /// gets its own thread to prevent things from blocking.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="mdiParent"></param>
        public static void _DoUpload(uint parent, Form mdiParent, string userToken) {
            frmUploadFolder ff = new frmUploadFolder();
            if (mdiParent != null)
                ff.MdiParent = mdiParent;
            ff.Show();
            ff.parentId = parent;
            ff.userToken = userToken;
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if (dlgFolders.ShowDialog() == DialogResult.OK) {
                buttonEdit1.Text = dlgFolders.SelectedPath;
                buttonEdit1_Leave(sender, EventArgs.Empty);
            }
        }

        private const int max_cnt = 1000;
        private int cnt = 0;
        private List<FileInfo> getFiles(DirectoryInfo path) {
            if (cnt > max_cnt)
                return new List<FileInfo>();
            List<FileInfo> files = new List<FileInfo>();
            foreach (DirectoryInfo dir in path.GetDirectories()) {
                cnt += 1;
                files.AddRange(getFiles(dir));
            }
            cnt += path.GetFiles().Length;
            files.AddRange(path.GetFiles());
            return files;
        }

        private uint createOrSelectDir(uint destinationId, string name, WalshApp.WalshSoap.WalshSoap soap) {
            uint id = soap.FindDir(userToken, destinationId, name);
            if (id == 0) {
                if (soap.CreateDir(destinationId, userToken, name, false))
                    id = soap.FindDir(userToken, destinationId, name);
                else
                    throw new Exception("Failed to create directory.");
            }
            if (id == 0)
                throw new Exception("Failed to select directory.");
            return id;
        }

        private void uploadFiles(DirectoryInfo path, uint destinationId, WalshApp.WalshSoap.WalshSoap soap) {
            List<FileInfo> files = new List<FileInfo>();
            foreach (DirectoryInfo dir in path.GetDirectories()) {
                try {
                    uint id = createOrSelectDir(destinationId, dir.Name, soap);
                    uploadFiles(dir, id, soap);
                }
                catch (Exception x) {
                    XtraMessageBox.Show(x.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            foreach (FileInfo fi in path.GetFiles()) {
                if (fi.Name.ToLower() == "thumbs.db")
                    continue; 
                //FileUploader fup = new FileUploader(
                //    userToken, 
                //    destinationId, 
                //    fi.FullName, 
                //    true, 
                //    chkShowProgress.Checked);
                WalshApp.Queue.UploadFileTask up = new WalshApp.Queue.UploadFileTask(
                    userToken,
                    destinationId,
                    fi.FullName);
                Program.Tasks.Add(up);
            }
        }

        private void FileUploadThread() {
            bool shownotify = chkNotifyComplete.Checked;
            using (WalshSoap.WalshSoap soap = new WalshApp.WalshSoap.WalshSoap()) {
                try {
                    uint id = createOrSelectDir(parentId, (new DirectoryInfo(buttonEdit1.Text)).Name, soap);
                    uploadFiles(new DirectoryInfo(buttonEdit1.Text), id, soap);
                }
                catch (Exception x) {
                    XtraMessageBox.Show(x.ToString(), "Error in frmUploadFolder.cs:104", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (shownotify)
                XtraMessageBox.Show(
                    "The file upload is now complete. Reload the tree view to see your new files.",
                    "File Import Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Hide();
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(new ThreadStart(FileUploadThread));
            th.Start();
        }

        private void buttonEdit1_TextChanged(object sender, EventArgs e) {

        }

        private void buttonEdit1_Leave(object sender, EventArgs e) {
            cnt = 0;
            if (buttonEdit1.Tag == null || buttonEdit1.Tag.ToString() != buttonEdit1.Text) {
                try {
                    lstFiles.Items.Clear();
                    List<FileInfo> files = getFiles(new DirectoryInfo(buttonEdit1.Text));
                    long size = 0;
                    foreach (FileInfo fi in files) {
                        size += fi.Length;
                        ListViewItem item = new ListViewItem();
                        item.Text = fi.Name;
                        item.SubItems.Add(string.Format("{0:#,###} KB", fi.Length / 1024));
                        lstFiles.Items.Add(item);
                    }
                    lblTotalSize.Text = string.Format("{0:#,###} MB", size / 1048576);
                    if (cnt >= max_cnt) {
                        lblTotalSize.Text = ">" + lblTotalSize.Text;
                        XtraMessageBox.Show(
                            "This folder has more than 1,000 files. For best performance, upload "
                            + " a smaller number of files at a time.",
                            "Large File Count", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch { }
            }
            buttonEdit1.Tag = buttonEdit1.Text;
            btnOk.Enabled = lstFiles.Items.Count > 0;
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e) {

        }

    }
}