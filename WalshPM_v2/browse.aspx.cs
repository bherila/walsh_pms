using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WalshPM_v2 {
    public partial class Browse : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                browse_list1.Directory = Config.RootDir;
            }
        }

        protected void browse_dir_tree1_DirChanged(browse_dir_tree sender, string dirName) {
            if (dirName == null)
                return;
            browse_list1.Directory = dirName;
        }

    }
}
