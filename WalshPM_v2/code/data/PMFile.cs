using System;
using DevExpress.Xpo;
using System.IO;

namespace WalshPM_v2.code.data {

    public class PMFile : XPObject {
        public PMFile()
            : base() {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PMFile(Session session)
            : base(session) {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction() {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        public string Name;
        public string FullName;
        public long Size;
        public string Type;
        public string Guid;
        public string Link;
        public string Preview_Link;
        public DateTime LastModified;

        public void setUp(FileInfo fi, System.Web.UI.Page p) {
            Name = fi.Name;
            FullName = fi.FullName;
            Size = fi.Length;
            Type = fi.Extension;
            LastModified = fi.LastAccessTime;

            Guid = System.Guid.NewGuid().ToString("N");
            p.Cache.Add(Guid, fi.FullName, null, DateTime.Now.AddHours(1),
                System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);

            string ftol = Type.ToLower();
            Link = "download_file.aspx?id=" + Guid;
            if (ftol.EndsWith("docx") || ftol.EndsWith("doc") || 
                ftol.EndsWith("mht") || ftol.EndsWith("odf") || 
                ftol.EndsWith("rtf") || ftol.EndsWith("jpg") ||
                ftol.EndsWith("gif") || ftol.EndsWith("pdf") ) {
                Preview_Link = "view_word.aspx?id=" + Guid;
            }
        }

    }

}