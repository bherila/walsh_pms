using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using DevExpress.Xpo;
using WalshPM_v2.code.data;

namespace WalshPM_v2 {
    public partial class browse_list : System.Web.UI.UserControl {

        public string Directory {
            get { return (string)ViewState["DIR"]; }
            set { ViewState["DIR"] = value; }
        }

        XPCollection<PMFile> FileList;

        protected void Page_PreRender(object sender, EventArgs e) {
            FileList = new XPCollection<PMFile>();
            DirectoryInfo di = new DirectoryInfo(Directory);
            foreach (FileInfo fi in di.GetFiles()) {
                if ((fi.Attributes & FileAttributes.Hidden) > 0)
                    continue;
                PMFile pmf = new PMFile();
                pmf.setUp(fi, Page);
                FileList.Add(pmf);
            }
            ASPxGridView1.DataSource = FileList;
            ASPxGridView1.DataBind();
        }

    }
}