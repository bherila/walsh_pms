using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WalshApp {
    public partial class Excel : UserControl, WDocument {
        public Excel() {
            InitializeComponent();
        }

        public void OpenFile(string filename) {
            string connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;"
                + "Data Source={0};Extended Properties=\"Excel 8.0;\"", filename);
            DataSet ds = new DataSet();
            OleDbDataAdapter a = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connStr);
            a.TableMappings.Add("Table", "ExcelTest");
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

    }
}
