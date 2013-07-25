using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

namespace WalshPM_v2 {
    public partial class browse_tile_generator : System.Web.UI.Page {

        private string Directory { get { return Request["dir"]; } }

        protected void Page_Load(object sender, EventArgs e) {

            Response.Clear();

            List<FileInfo> files = new List<FileInfo>();

            DirectoryInfo di = new DirectoryInfo(Directory);
            files.AddRange(di.GetFiles());

            StringBuilder sb = new StringBuilder();
            foreach (FileInfo fi in files) {
                sb.Append("<div id=\"").Append(fi.Name.GetHashCode()).Append("\" style=\"width:");
                string ctag = "\">";
                string lname = fi.Name.ToLower();
                if (lname.EndsWith("jpg") || lname.EndsWith("bmp")
                    || lname.EndsWith("tif")) {
                    // image
                    sb.Append("width: 150px; height: 150px;");
                    sb.Append(ctag);
                }
                else {
                    // regular document
                    sb.Append("width: 150px; height: 50px;");
                    sb.Append(ctag);
                }
                sb.Append(fi.Name);
                sb.Append("</div>");
                sb.AppendLine();
            }
            Response.Write(sb.ToString());

            Response.End();
        }
    }
}
