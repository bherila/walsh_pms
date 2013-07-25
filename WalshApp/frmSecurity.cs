using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WalshApp {
    public partial class frmSecurity : DevExpress.XtraEditors.XtraForm {
        public frmSecurity() {
            InitializeComponent();
        }

        private void pm_securityBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.pm_securityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pm_security);

        }

        private void frmSecurity_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'pm_security._pm_security' table. You can move, or remove it, as needed.
            this.pm_securityTableAdapter.Fill(this.pm_security._pm_security);
        }
    }
}