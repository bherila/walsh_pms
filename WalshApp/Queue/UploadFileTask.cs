using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using DevExpress.XtraEditors;

namespace WalshApp.Queue {
    public class UploadFileTask : ITask {

        UploadFileTaskProgress utp = null;
        string userToken;
        uint parentId;
        string fileName;
        string status = "Initializing";
        //FileUploader fup;

        public override void DoubleClick(System.Windows.Forms.Form owner) {
            if (utp != null && !utp.IsDisposed) {
                utp.Show();
                utp.Activate();
            }
            else {
                utp = new UploadFileTaskProgress();
                utp.task = this;
                owner.AddOwnedForm(utp);
                utp.Show();
                utp.Activate();
            }
        }

        public UploadFileTask(string userToken, uint parentId, string fileName) {
            this.userToken = userToken;
            this.parentId = parentId;
            this.fileName = fileName;
            SetStatus(Status.Waiting);
        }

        private void TaskThread() {
            //fup = new FileUploader(userToken, parentId, fileName, true, false);
            SetStatus(Status.Processing);
            status = "Pre-processing file...";
            List<string> parts = SplitFile(fileName, 200000);
            WalshSoap.WalshSoap soap = new WalshApp.WalshSoap.WalshSoap();
            soap.Timeout = int.MaxValue;
            server_parts = new List<string>();
            for (int i = 0; i < parts.Count; i++) {
                if (utp != null) {
                    System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                    utp.progressBarControl1.Position = (int)((double)i / (double)parts.Count *100.0);
                    utp.labelControl1.Text = "Uploading chunk " + i.ToString() + " of " + parts.Count.ToString();
                    utp.Text = "Upload " + Path.GetFileName(fileName);
                }
                status = "Uploading " + i.ToString() + " of " + parts.Count.ToString();
                server_parts.Add(soap.UploadFilePart(File.ReadAllBytes(parts[i]), null)); // TODO: Checksum
                File.Delete(parts[i]);
            }
            status = "Waiting for server to finish processing";
            if (utp != null) {
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                utp.progressBarControl1.Position = 100;
                utp.labelControl1.Text = status;
            }
            soap.CreateFile(parentId, userToken, Path.GetFileName(fileName), "File uploaded by " + Environment.UserName,
                server_parts.ToArray(), null); // TODO: original file checksum
            SetStatus(Status.Finished);
            CloseUTP();
        }

        #region ITask Members

        private Thread th;
        List<string> server_parts;
        public override void Start() {
            SetStatus(Status.Processing);
            if (th != null && th.IsAlive)
                return;
            th = new Thread(new ThreadStart(TaskThread));
            th.Start();
        }

        public override void Join() {
            if (th != null && th.IsAlive)
                th.Join();
        }

        private void CloseUTP() {
            if (utp != null) {
                if (utp.Visible)
                    utp.Close();
                if (!utp.IsDisposed)
                    utp.Dispose();
                utp = null;
            }
        }

        public override void Abort() {
            CloseUTP();

            if (th != null && th.IsAlive) {
                th.Abort();
            }
            WalshSoap.WalshSoap s = new WalshApp.WalshSoap.WalshSoap();
            s.CleanTempFiles();
        }

        public override string GetName() {
            return "Upload " + Path.GetFileName(this.fileName);
        }

        public override void SetName(string newName) {
            this.fileName = newName;
        }

        public override string GetStatusText() {
            switch (this.CurrentStatus) {
                case Status.Waiting:
                    return "Waiting";
                case Status.Processing:
                    return status;// +(fup == null ? "0%" : fup.progress.ToString());
                case Status.Finished:
                    return "Finished";
            }
            return "Unknown";
        }

        public override int GetImageIndex() {
            return 0;
        }


        #endregion

        private List<string> SplitFile(string FileInputPath /*, string FolderOutputPath */, int partSize) {
            // Store the file in a byte array
            Byte[] byteSource;
            gRetry:
            try {
                byteSource = System.IO.File.ReadAllBytes(FileInputPath);
            }
            catch (Exception x) {
                if (XtraMessageBox.Show(x.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.RetryCancel, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Retry)
                    goto gRetry;
                else
                    return new List<string>();
            }
            // Get file info
            FileInfo fiSource = new FileInfo(FileInputPath);
            // Calculate the size of each part
            // int partSize = (int)Math.Ceiling((double)(fiSource.Length / OutputFiles));
            List<string> filenames = new List<string>();


            // The offset at which to start reading from the source file
            int fileOffset = 0;

            // Stores the name of each file part
            string currPartPath;
            // The file stream that will hold each file part
            FileStream fsPart;
            // Stores the remaining byte length to write to other files
            int sizeRemaining = (int)fiSource.Length;

            // Loop through as many times we need to create the partial files
            //for (int i = 0; i < OutputFiles; i++) {
            int i = 0;
            while (fileOffset < byteSource.Length) {
                // Store the path of the new part
                currPartPath = Path.GetTempFileName(); //Path.Combine(FolderOutputPath, fiSource.Name + "." + String.Format(@"{0:D4}", i) + ".part");
                // A filestream for the path
                if (File.Exists(currPartPath))
                    File.Delete(currPartPath);
                if (!File.Exists(currPartPath)) {
                    filenames.Add(currPartPath);
                    fsPart = new FileStream(currPartPath, FileMode.CreateNew);
                    // Calculate the remaining size of the whole file
                    sizeRemaining = (int)fiSource.Length - (i * partSize);
                    // The size of the last part file might differ because a file doesn't always split equally
                    if (sizeRemaining < partSize) {
                        partSize = sizeRemaining;
                    }
                    // Write the byte chunk to the part file
                    fsPart.Write(byteSource, fileOffset, partSize);
                    // Close the file stream
                    fsPart.Close();
                    // Set the new offset
                    fileOffset += partSize;
                }
                i++;
            }

            return filenames;
        }
    }
}
