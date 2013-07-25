using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WalshPM_v2 {
    public class browse_files : Control {

        public string Directory {
            get { return (string)ViewState["DIR"]; }
            set { ViewState["DIR"] = value; }
        }

        protected override void Render(HtmlTextWriter writer) {
            
        }


    }
}
