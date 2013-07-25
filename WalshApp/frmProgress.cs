using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WalshApp {
    public partial class frmProgress : Form {
        public frmProgress() {
            InitializeComponent();
        }


        public void setStatusText(string text) {
            try {
                label1.Text = text;
                Application.DoEvents();
            }
            catch { }
        }

        public void setProgress(long total, long max) {
            double prg = (double)total / (double)max * 100.0;
            progressBar1.Value = (int)Math.Floor(prg);
            label2.Text = string.Format("{0:###}%", prg);
            Application.DoEvents();
        }

        private void frmProgress_Load(object sender, EventArgs e) {

        }
    }
}
