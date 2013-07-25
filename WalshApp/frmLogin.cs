using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WalshApp {
    public partial class frmLogin : Form {

        /// <summary>
        /// Performs a login. 
        /// </summary>
        /// <returns>auth_key if succeeded, null if failed/cancelled</returns>
        public static string _doLogin() {
            frmLogin log = new frmLogin();
            log.ShowDialog();
            if (log.Tag == null)
                return null;
            else
                return log.Tag.ToString();
        }
        
        private  frmLogin() {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            textBox1.Text = Environment.UserName;
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void label1_Enter(object sender, EventArgs e) {
            textBox1.Focus();
        }

        private void label2_Enter(object sender, EventArgs e) {
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                this.Enabled = false;
                Application.DoEvents();
                using (WalshSoap.WalshSoap soap = new WalshApp.WalshSoap.WalshSoap()) {
                    string str = soap.LoginUser(textBox1.Text, textBox2.Text);
                    if (str != null && str.Length > 0) {
                        this.DialogResult = DialogResult.OK;
                        this.Tag = str;
                        this.Close();
                    }
                    else {
                        XtraMessageBox.Show("Incorrect user name or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception x) {
                XtraMessageBox.Show(x.Message, "Error - press CTRL+C to copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                this.Enabled = true;
            }
        }
    }
}
