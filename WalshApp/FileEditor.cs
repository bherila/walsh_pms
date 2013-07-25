using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WalshApp {
    public class FileEditor : IDisposable {

        private string url;
        private uint fileId;
        private uint parentId;
        private string userToken;
        private string fileName;
        private string tmpFileName;
        private bool editing = false;
        private Process proc;
        private frmProgress prog;
        private WebClient wc;
        private Thread worker;
        private bool stop = false;
        private string procName = string.Empty;

        public string processName {
            get { return procName; }
        }

        public FileEditor(string url, uint object_id, string file_name, string user_token, uint parentId) {
            this.url = url;
            this.fileId = object_id;
            this.parentId = parentId;
            this.userToken = user_token;
            this.fileName = file_name;
            this.tmpFileName = Path.GetTempFileName();
            File.Delete(this.tmpFileName);
            this.tmpFileName += "-" + (new Random()).Next(0, 10000).ToString() + "-" + file_name;
        }

        public void StartEdit(System.Windows.Forms.Form ownerForm) {
            if (editing)
                throw new InvalidOperationException("Already editing this file.");
            stop = false;

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            prog = new frmProgress();
            if (ownerForm != null) {
                ownerForm.AddOwnedForm(prog);
            }
            prog.Show();
            System.Windows.Forms.Application.DoEvents();
            wc = new WebClient();

            wc.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            wc.DownloadFileAsync(new Uri(this.url), this.tmpFileName);

        }

        public void SendEmail(System.Windows.Forms.Form ownerForm) {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            prog = new frmProgress();
            if (ownerForm != null) {
                ownerForm.AddOwnedForm(prog);
            }
            prog.Show();
            System.Windows.Forms.Application.DoEvents();
            wc = new WebClient();

            wc.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(wc_DownloadFileCompletedSendMail);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            wc.DownloadFileAsync(new Uri(this.url), this.tmpFileName);

        }


        private void wc_DownloadFileCompletedSendMail(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            prog.Close();
            SendFileTo.MAPI m = new SendFileTo.MAPI();
            m.AddAttachment(this.tmpFileName);
            m.SendMailPopup("Emailing: " + this.fileName, this.fileName + " is attached to this e-mail.");
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            try {
                prog.setProgress(e.BytesReceived, e.TotalBytesToReceive);
            }
            finally {
                System.Windows.Forms.Application.DoEvents();
                Thread.Sleep(0);
            }
        }

        private void wc_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            prog.Close();
            retry:
            try {
                ProcessStartInfo p = new ProcessStartInfo(tmpFileName);
                proc = Process.Start(p);
                Thread.Sleep(2000);
                procName = proc.ProcessName;

                Thread runner = new Thread(new ThreadStart(run));
                runner.Priority = ThreadPriority.Lowest;
                runner.Start();
            }
            catch (Exception x) {
                if (XtraMessageBox.Show("This program cannot be monitored for changes. \n\n"
                    + "To save a new revision in the system, use the program's "
                    + "Save As command to save your changes in a new file. "
                    + "Double-click the file in the Project Management system "
                    + "and upload your file as a new revision from there.\n\n"
                    + "More information about this error:\n" + x.ToString(),
                                      "Can't Hook Program",
                                      MessageBoxButtons.RetryCancel,
                                      MessageBoxIcon.Information,
                                      MessageBoxDefaultButton.Button1) == DialogResult.Retry)
                    goto retry;
            }
        }


        private void run() {
            FileInfo fi = new FileInfo(tmpFileName);
            DateTime orig = fi.LastWriteTime;
            try {
                while (!stop) {
                    fi = new FileInfo(tmpFileName);
                    if (fi.LastWriteTime.CompareTo(orig) != 0) {
                        orig = fi.LastWriteTime;
                        frmGrayOut g = new frmGrayOut();
                        g.TopMost = true;
                        frmFile f = new frmFile();
                        f.TopMost = true;
                        g.AddOwnedForm(f);
                        f.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        g.Show();
                        g.Activate();
                        if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                            try {
                                FileStream fs = new FileStream(this.tmpFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                                byte[] b = new byte[fs.Length];
                                fs.Read(b, 0, b.Length);
                                fs.Close();
                                string desc = f.MemoText;
                                //TODO: Use a CreateFileTask instead
                                using (WalshSoap.WalshSoap s = new WalshApp.WalshSoap.WalshSoap()) {
                                    s.CreateFileFromBytes(parentId, userToken, fileName, b, desc);
                                }
                            }
                            catch (Exception x) {
                                g.Hide();
                                MessageBox.Show(x.ToString(), "Commit Failure", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        g.Close();
                        f.Dispose();
                        g.Dispose();
                        f = null;
                        g = null;
                    }

                    bool found = false;
                    foreach (Process p in Process.GetProcesses()) {
                        if (p.ProcessName == procName) {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        stop = true;

                    Thread.Sleep(0);
                    Thread.Sleep(500);
                }
            }
            catch (Exception x) {
                MessageBox.Show("Failure:\n" + x.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, false);
                MessageBox.Show("Use the Save As feature of your software program to save an extra copy of your data in case not all data might have been transferred.", "Advisory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // no need for this anymore
            try {
                prog.Dispose();
                wc.Dispose();
            }
            catch { }
            finally {
                proc = null;
                prog = null;
                wc = null;
            }
            editing = false;
            if (!disposing)
                this.Dispose();
        }



        private bool disposing = false;
        public void Dispose() {
            disposing = true;
            stop = true;
            if (worker != null) {
                worker.Join();
                worker = null;
            }
            if (PMS.OpenEditors.Contains(this))
                PMS.OpenEditors.Remove(this);
            try {
                prog.Dispose();
                wc.Dispose();
            }
            catch { }
            finally {
                proc = null;
                prog = null;
                wc = null;
            }
        }
    }
}
