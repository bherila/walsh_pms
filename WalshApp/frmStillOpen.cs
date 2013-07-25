using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WalshApp {
    public partial class frmStillOpen : Form {
        public frmStillOpen() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (PMS.OpenEditors.Count == 0)
                Application.Exit();
            else {
                Process[] procs = Process.GetProcesses();
                for (int i = PMS.OpenEditors.Count - 1; i >= 0; i--) {
                    bool found = false;
                    string threadName = PMS.OpenEditors[i].processName;
                    try {
                        foreach (Process proc in procs)
                            if (proc.ProcessName == threadName) {
                                found = true; 
                                break;
                            }
                    }
                    catch {
                    }
                    if (!found) {
                        PMS.OpenEditors.RemoveAt(i);
                        if (!listBox1.Items.Contains(threadName)) 
                            listBox1.Items.Remove(threadName);
                    }
                    else 
                        if (!listBox1.Items.Contains(threadName))
                            listBox1.Items.Add(threadName);
                }
            }
        }
    }
}
