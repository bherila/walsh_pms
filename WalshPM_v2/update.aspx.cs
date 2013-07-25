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
    public partial class update : System.Web.UI.Page {

        private Session s;
        int count = 0;
        private const string updateScript = "<script>prog('{0}', {1});</script>";
        
        protected void Page_Load(object sender, EventArgs e) {
            DirectoryInfo root = new DirectoryInfo(Config.RootDir);
            Response.Clear();
            Response.Write(@"
<div id='cur_file'>Initializing</div>
<script>
function prog(filename, num) {
document.getElementById('cur_file').innerHtml = (num + ' --- Processing ' + filename);
}
</script>");

            using (s = new Session()) {
                recur(root, Guid.Empty);
            }

        }

        public void recur(Session s, DirectoryInfo dir, Guid parentId) {

            Response.Write(string.Format(updateScript, dir.FullName, count++));
            Response.Flush();

            string guidfile = Path.Combine(dir.FullName, "wpmMetadata");
            Guid dirGuid;
            try {
                if (File.Exists(guidfile)) {
                    dirGuid = new Guid(File.ReadAllText(guidfile));
                }
                else {
                    goto newguid;
                }
            }
            catch {
                goto newguid;
            }
            goto ngdone;
        newguid:
            dirGuid = Guid.NewGuid();
            File.WriteAllText(guidfile, dirGuid.ToString());
            File.SetAttributes(guidfile, FileAttributes.Hidden | FileAttributes.NotContentIndexed | FileAttributes.System);
        ngdone:


            PMFilesystem fsitem = new PMFilesystem(s);
            fsitem.Oid = dirGuid;
            fsitem.FullName = dir.FullName;
            fsitem.IsDir = true;
            fsitem.ParentId = dirGuid;
            fsitem.Size = 0;
            fsitem.Filename = dir.Name;
            fsitem.Save();

            foreach (DirectoryInfo di in dir.GetDirectories()) {
                recur(s, di, dirGuid);
            }

            s.BeginTransaction();
            foreach (FileInfo fi in dir.GetFiles()) {
                PMFilesystem ffitem = new PMFilesystem();
                ffitem.FullName = fi.FullName;
                ffitem.Filename = fi.Name;
                ffitem.Size = fi.Length;
                ffitem.ParentId = dirGuid;
                ffitem.IsDir = false;
                ffitem.Save();
            }
            s.CommitTransaction();
        }

    }
}
