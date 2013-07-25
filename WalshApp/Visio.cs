using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WalshApp {
    public partial class Visio : UserControl, WDocument {
        public Visio() {
            InitializeComponent();
        }

        #region WDocument Members

        public void OpenFile(string filename) {
            axViewer1.Load(filename);
        }

        #endregion
    }
}
