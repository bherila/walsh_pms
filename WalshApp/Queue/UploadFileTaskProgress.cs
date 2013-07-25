using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WalshApp.Queue {
    public partial class UploadFileTaskProgress : DevExpress.XtraEditors.XtraForm {

        public UploadFileTask task;

        public UploadFileTaskProgress() {
            InitializeComponent();
        }

        private void UploadFileTaskProgress_Load(object sender, EventArgs e) {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            task.Abort();
            this.Close();
        }
    }
}