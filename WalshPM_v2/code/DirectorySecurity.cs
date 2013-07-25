using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WalshPM_v2.code {

    [Serializable]
    public struct DirectorySecurityEntry {
        public bool canRead;
        public bool canWrite;
        public bool canChangePermissions;
        public bool canViewPermissions;

        public static DirectorySecurityEntry Default(bool gotAccess) {
            DirectorySecurityEntry ent;
            ent.canChangePermissions = gotAccess;
            ent.canRead = gotAccess;
            ent.canViewPermissions = gotAccess;
            ent.canWrite = gotAccess;
            return ent;
        }


    }

    public class DirectorySecurity {

        public DirectorySecurity(DirectoryInfo di) {
            m_entries = new Dictionary<Guid, DirectorySecurityEntry>();
            m_dir = di;
            load();
        }

        public DirectorySecurityEntry this[Guid i] {
            get {
                DirectorySecurity cur = this;
                while (cur != null && !cur.m_entries.ContainsKey(i))
                    cur = cur.Parent;
                if (cur == null)
                    return DirectorySecurityEntry.Default(true);
                else
                    return cur.m_entries[i];
            }
        }

        public DirectorySecurity Parent {
            get {
                if (m_dir.Parent == null)
                    return null;
                else
                    return new DirectorySecurity(m_dir.Parent);
            }
        }

        private DirectoryInfo m_dir;
        private Dictionary<Guid, DirectorySecurityEntry> m_entries;

        private string m_metadataFilename {
            get { return Path.Combine(m_dir.FullName, "pm.security"); }
        }

        private void save() {
            BinaryFormatter bf = new BinaryFormatter();
            List<string> data = new List<string>(m_entries.Count);
            Dictionary<Guid, DirectorySecurityEntry>.Enumerator e = m_entries.GetEnumerator();
            while (e.MoveNext()) {
                string dat;
                using (MemoryStream ms = new MemoryStream(5000)) {
                    bf.Serialize(ms, e.Current.Value);
                    dat = Convert.ToBase64String(ms.ToArray());
                }
                string s = e.Current.Key.ToString("N") + ' ' + dat;
                data.Add(s);
            }
            File.WriteAllLines(m_metadataFilename, data.ToArray());
        }

        private void load() {
            m_entries.Clear();
            if (!File.Exists(m_metadataFilename))
                return;
            BinaryFormatter bf = new BinaryFormatter();
            List<string> data = new List<string>(File.ReadAllLines(m_metadataFilename));
            foreach (string s in data) {
                string[] pts = s.Split(new char[] { ' ' }, 2);
                if (pts.Length == 2) {
                    using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(pts[1].Trim()))) {
                        m_entries.Add(
                            new Guid(pts[0].Trim()),
                            (DirectorySecurityEntry)(bf.Deserialize(ms)));
                    }
                }
            }
        }

    }
}
