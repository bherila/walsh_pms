using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WalshApp {
    class FileUploader {

        //public string result;
        //WebClient wc;
        //frmProgress prog;
        //string filename;
        //bool busy;

        public double progress = 1.0;

        /// <summary>
        /// Sets up and executes a new file uploader object.
        /// </summary>
        /// <param name="user_token">The user authentication token.</param>
        /// <param name="parent_id">Parent id of item to receive new file.</param>
        /// <param name="filename">Local path and file name.</param>
        /// <param name="wait">True to make this method block until the upload is completed.</param>
        public FileUploader(string user_token, uint parent_id, string filename, bool wait, bool showprogress) {




            //using (wc = new WebClient()) {
            //    wc.UploadProgressChanged += new UploadProgressChangedEventHandler(wc_UploadProgressChanged);
            //    wc.UploadFileCompleted += new UploadFileCompletedEventHandler(wc_UploadFileCompleted);
            //    using (prog = new frmProgress()) {
            //        prog.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //        if (showprogress)
            //            prog.Show();
            //        this.filename = filename;
            //        Uri url = new Uri(PMS.URL_Root + string.Format(
            //                                            "/SVC/CreateFile.aspx?parent_id={0}&user_token={1}&filename={2}&description={3}",
            //                                            parent_id,
            //                                            user_token,
            //                                            Path.GetFileName(filename),
            //                                            ""
            //                                            )
            //                       );
            //        //if (showprogress) {
            //            wc.UploadFileAsync(
            //                url,
            //                filename);
            //            try {
            //                busy = true;
            //                while (wait && wc.IsBusy) {
            //                    try {
            //                        Thread.Sleep(0);
            //                        Thread.Sleep(600);
            //                    }
            //                    catch {
            //                    }
            //                }
            //            }
            //            catch { }
            //        //}
            //        //else {
            //        //    byte[] result = wc.UploadFile(url, filename);
            //        //    this.result = System.Text.Encoding.ASCII.GetString(result);
            //        //}
            //    }
            //}
        }

        //void wc_UploadFileCompleted(object sender, UploadFileCompletedEventArgs e) {
        //    string result = System.Text.Encoding.ASCII.GetString(e.Result);
        //    this.result = result;
        //    if (!result.ToLower().StartsWith("ok"))
        //        XtraMessageBox.Show(
        //            result,
        //            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //    try {
        //        prog.Close();
        //        prog.Dispose();
        //        wc.Dispose();
        //        busy = false;
        //    }
        //    catch { }
        //}

        //void wc_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e) {
        //    try {
        //        progress = e.TotalBytesToSend / e.BytesSent;
        //        prog.setStatusText("Uploading " + filename);
        //        prog.setProgress(e.TotalBytesToSend, e.BytesSent);
        //        try {
        //            Application.DoEvents();
        //        }
        //        catch { }
        //    }
        //    catch { }
        //}


        


    }
}
