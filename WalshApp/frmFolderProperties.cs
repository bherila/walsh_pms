using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WalshApp {
    public partial class frmFolderProperties : DevExpress.XtraEditors.XtraForm {
        public frmFolderProperties() {
            InitializeComponent();
        }


        public bool IsTemplatePossible {
            get { return checkEdit1.Visible; }
            set { checkEdit1.Visible = value; }
        }

        public bool TemplateSelected {
            get {
                if (!IsTemplatePossible)
                    return false;
                else
                    return checkEdit1.Checked;
            }
            set {
                checkEdit1.Checked = value;
            }
        }

        public string FolderName {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void frmFolderProperties_Load(object sender, EventArgs e) {
            textBox1.Focus();
        }
    }
}
