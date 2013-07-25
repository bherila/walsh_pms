using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WalshApp {
    public partial class frmFile : DevExpress.XtraEditors.XtraForm {
        public frmFile() {
            InitializeComponent();
        }

        public string MemoText {
            get { return memoEdit1.Text; }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.Activate();
        }

        private void frmFile_Load(object sender, EventArgs e) {
            memoEdit1.Text = string.Format("Updated by {0}.", Environment.UserName);
            memoEdit1.Focus();
        }
    }
}
