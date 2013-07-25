using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WalshApp {
    public partial class frmNewProjectFromTemplate : DevExpress.XtraEditors.XtraForm {

        public frmNewProjectFromTemplate() {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e) {
            simpleButton1.Enabled = textEdit1.Text.Length > 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            if (textEdit1.Text.Length < 1) {
                MessageBox.Show("Project name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmNewProjectFromTemplate_Load(object sender, EventArgs e) {
            this.treeList1.Nodes[0].Selected = true;
        }


        private Dictionary<string, uint> nameToId = new Dictionary<string,uint>();

        public void AddProject(string text, uint id) {
            if (nameToId.ContainsKey(text))
                return;
            this.treeList1.AppendNode(new object[] {text}, -1);
            nameToId.Add(text, id);
        }

        public string ProjectName {
            get { return textEdit1.Text; }
            set { this.textEdit1.Text = value; }
        }

        public string SelectedTemplateName {
            get {
                for (int i = 0; i < treeList1.Nodes.Count; i++) {
                    if (treeList1.Nodes[i].Selected) {
                        return treeList1.Nodes[i][0].ToString();
                    }
                }
                return string.Empty;
            }
        }

        public uint SelectedTemplateId {
            get {
                if (nameToId.ContainsKey(SelectedTemplateName))
                    return nameToId[SelectedTemplateName];
                else
                    return 0;
            }
        }



    }
}