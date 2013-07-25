using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WalshApp {
    public partial class frmNewName : DevExpress.XtraEditors.XtraForm {
        private frmNewName() {
            InitializeComponent();
        }

        public static string GetNewName(string old_name) {
            return GetNewName(old_name, null);
        }

        public static string GetNewName(string old_name, string prompt) {
            frmNewName fnn = new frmNewName();
            if (prompt != null)
                fnn.labelControl1.Text = prompt;
            fnn.textEdit1.Text = old_name;
            fnn.textEdit1.SelectAll();
            fnn.textEdit1.Focus();
            if (fnn.ShowDialog() == DialogResult.OK) {
                return fnn.textEdit1.Text;
            }
            return old_name;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            if (dxValidationProvider1.Validate()) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}