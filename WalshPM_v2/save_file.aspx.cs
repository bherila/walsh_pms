using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalshPM_v2 {
    public partial class save_file : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string filename = Cache[Request["id"]].ToString();
            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.AddHeader("content-disposition", "attachment;filename=" + System.IO.Path.GetFileName(filename));
            Response.WriteFile(filename);
            Response.End();
        }
    }
}
