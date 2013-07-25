using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WalshApp {

    public partial class frmBrowser : DevExpress.XtraEditors.XtraForm {
        
        private frmBrowser() {
            InitializeComponent();
        }

        public frmBrowser(string title, string url, Form mdiParent) {
            frmBrowser fb = new frmBrowser();
            fb.wb.ObjectForScripting = mdiParent;
            fb.Text = title;
            fb.wb.Navigate(url);
            fb.MdiParent = mdiParent;
            fb.Show();
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            groupControl1.Visible = false;
        }

        private void wb_FileDownload(object sender, EventArgs e) {
            this.Enabled = true;
        }

        private void wb_Navigating(object sender, WebBrowserNavigatingEventArgs e) {
            if (e.Url.ToString().Contains("javascript:void(0)")) {
                e.Cancel = true;
                return;
            }
            //this.Enabled = false;
        }

        private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e) {
            this.Enabled = true;
        }

        private void wb_NewWindow(object sender, CancelEventArgs e) {
            e.Cancel = true;
        }

    }
}