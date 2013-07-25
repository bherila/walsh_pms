using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxTreeList;
using System.IO;
using WalshPM_v2.code;

namespace WalshPM_v2 {
    public class browse_dir_tree : CompositeControl {

        public delegate void DirChangedDelegate(browse_dir_tree sender, string dirName);
        public event DirChangedDelegate DirChanged;

        protected override void CreateChildControls() {

            if (DesignMode) {
                return;
            }

            ASPxTreeList tl = new ASPxTreeList();
            tl.Columns.Add(new TreeListDataColumn("field"));
            tl.EnableCallbacks = false;
            tl.Width = Unit.Percentage(100);
            tl.Settings.ShowColumnHeaders = false;
            tl.SettingsBehavior.ExpandCollapseAction = TreeListExpandCollapseAction.NodeClick;

            TreeListDataColumn pathCol = new TreeListDataColumn("Path");
            pathCol.Visible = false;
            tl.Columns.Add(pathCol);

            //tl.NodeExpanding += new TreeListNodeCancelEventHandler(tl_NodeExpanding);
            //tl.ClearNodes();
            tl.SettingsBehavior.AllowFocusedNode = true;
            tl.VirtualModeNodeCreating += new TreeListVirtualModeNodeCreatingEventHandler(tl_VirtualModeNodeCreating);
            tl.VirtualModeCreateChildren += new TreeListVirtualModeCreateChildrenEventHandler(tl_VirtualModeCreateChildren);
            //Guid user = Config.getUserId(Page);

            tl.FocusedNodeChanged += new EventHandler(tl_FocusedNodeChanged);
            tl.SettingsBehavior.ProcessFocusedNodeChangedOnServer = true;

            Controls.Add(tl);
        }

        void tl_FocusedNodeChanged(object sender, EventArgs e) {
            if (DirChanged != null) {
                string path = (sender as ASPxTreeList).FocusedNode.GetValue("Path").ToString();
                DirChanged(this, path);
            }
        }

        void tl_VirtualModeCreateChildren(object sender, TreeListVirtualModeCreateChildrenEventArgs e) {
            Guid user = Config.getUserId(Page);
            string path = (e.NodeObject == null ? Config.RootDir : e.NodeObject.ToString());
            List<string> children = new List<string>();
            if (Directory.Exists(path)) {
                DirectoryInfo root = new DirectoryInfo(path);
                foreach (DirectoryInfo di in root.GetDirectories()) {
                    DirectorySecurity sec = new DirectorySecurity(di);
                    DirectorySecurityEntry ent = sec[user];
                    if (ent.canRead) {
                        children.Add(di.FullName);
                    }
                }
            }
            e.Children = children;
        }

        void tl_VirtualModeNodeCreating(object sender, TreeListVirtualModeNodeCreatingEventArgs e) {
            string nodePath = e.NodeObject.ToString();
            e.NodeKeyValue = GetNodeGuid(nodePath);
            e.IsLeaf = (!Directory.Exists(nodePath) || Directory.GetDirectories(nodePath).Length == 0);
            e.SetNodeValue("field", Path.GetFileName(nodePath));
            e.SetNodeValue("Path", nodePath);
        }

        Guid GetNodeGuid(string path) {
            if (!Map.ContainsKey(path))
                Map[path] = Guid.NewGuid();
            return Map[path];
        }
        Dictionary<string, Guid> Map {
            get {
                const string key = "DX_PATH_GUID_MAP";
                if (Page.Session[key] == null)
                    Page.Session[key] = new Dictionary<string, Guid>();
                return Page.Session[key] as Dictionary<string, Guid>;
            }
        }

        //void addDir(ASPxTreeList tl, TreeListNode parent, DirectoryInfo root, Guid user) {
        //    foreach (DirectoryInfo di in root.GetDirectories()) {
        //        DirectorySecurity sec = new DirectorySecurity(di);
        //        DirectorySecurityEntry ent = sec[user];
        //        if (ent.canRead) {
        //            TreeListNode node;
        //            if (parent == null)
        //                node = tl.AppendNode(di.FullName);
        //            else
        //                node = tl.AppendNode(di.FullName, parent);
        //            node["field"] = di.Name;

        //            tl.AppendNode(node.Key + Guid.NewGuid().ToString(), node);
        //        }
        //    }
        //}

        //void tl_NodeExpanding(object sender, TreeListNodeCancelEventArgs e) {
        //    if (e.Node.ChildNodes.Count == 1) {
        //        (sender as ASPxTreeList).DeleteNode(e.Node.ChildNodes[0].Key);
        //    }
        //    Guid user = Config.getUserId(Page);
        //    DirectoryInfo di = new DirectoryInfo(e.Node.Key);
        //    addDir(sender as ASPxTreeList, e.Node, di, user);
        //}


    }
}
