using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.UI;

namespace WalshPM_v2 {
    public class Config {

        public static Guid getUserId(Page p) {
            object obj = p.Session["USERID"];
            if (obj == null)
                return Guid.Empty;
            return new Guid(obj.ToString());
        }

        public static string RootDir {
            get {
                return ConfigurationManager.AppSettings["PMRoot"];
            }
        }

    }
}
