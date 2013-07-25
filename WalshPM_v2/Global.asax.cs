using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using DevExpress.Xpo;
using WalshPM_v2.code.data;

namespace Jobaphiles {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            // Code that runs on the application startup
            // Specify the connection string, which is used to open a database. 
            // It's supposed that you've already created the Comments database within the App_Data folder.
            //string path = Server.MapPath("/App_Data/Data.mdb");
#if DEBUG
            string conn = DevExpress.Xpo.DB.AccessConnectionProvider.GetConnectionString(Server.MapPath("/App_Data/pm_data.mdb"));
#else
            string conn = DevExpress.Xpo.DB.MySqlConnectionProvider.GetConnectionString("127.0.0.1", "jobaphiles", "eggbert", "jobaphiles");
#endif
            //using (UpdateSchema updateSchema = new UpdateSchema(conn)) {
            //    bool result = updateSchema.Update(typeof(code.Page).Assembly);
            //}

            DevExpress.Xpo.Metadata.XPDictionary dict = new DevExpress.Xpo.Metadata.ReflectionDictionary();
            // Initialize the XPO dictionary.
            dict.GetDataStoreSchema(typeof(XPIdentity).Assembly);
            DevExpress.Xpo.XpoDefault.Session = null;
            DevExpress.Xpo.DB.IDataStore store = DevExpress.Xpo.XpoDefault.GetConnectionProvider(conn, DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            DevExpress.Xpo.XpoDefault.DataLayer = new DevExpress.Xpo.ThreadSafeDataLayer(dict, store);
            XpoDefault.Session = new Session();
        }

        protected void Session_Start(object sender, EventArgs e) {

        }



        protected void Application_BeginRequest(Object sender, EventArgs e) {
            //ThunderMain.URLRewriter.Rewriter.Process();
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {
        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }

    }
}