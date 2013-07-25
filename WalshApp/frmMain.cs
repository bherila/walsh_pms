using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Security.Permissions;
using System.Threading;
using System.Collections;
using System.IO;
using WalshApp.WalshSoap;

using DevExpress.XtraBars;
using DevExpress.XtraTreeList;
using DevExpress.XtraBars.Ribbon;
using WalshWeb.Shared;
using WalshApp.Queue;
using DevExpress.XtraEditors;

namespace WalshApp {

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class frmMain : RibbonForm {

        const string TreeNodeLoadingText = "Loading...";
        private WalshSoap.WalshSoap Soap;
        public string user_token = "na";

        public frmMain() {
            InitializeComponent();
        }

        #region Tree Stuff

        public void LoadTree() {
            tree.BeginUpdate();
            tree.Nodes.Clear();
            LoadNodes(tree.Nodes, 0);
            tree.Sort();
            tree.EndUpdate();
        }



        /// <summary>
        /// Loads child nodes from the database.
        /// </summary>
        /// <param name="children"></param>
        /// <param name="parentID"></param>
        private void LoadNodes(TreeNodeCollection children, uint parentID) {
            try {
                children.Clear();
                List<ObjectTreeData> data = new List<ObjectTreeData>(Soap.GetSubitems(parentID, user_token));
                foreach (ObjectTreeData d in data) {
                    TreeNode n = new TreeNode(d.object_name);
                    UpdateNodeWithData(n, d, true);
                    children.Add(n);
                }
            }
            catch (Exception x) {
                MessageBox.Show("The operation failed. Try reloading the tree again.\n\n" + x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNodeWithData(TreeNode node, ObjectTreeData data, bool resetChildren) {
            TreeNodeTag tt = new TreeNodeTag();
            node.ImageIndex = node.SelectedImageIndex = (int)data.object_type;
            tt.objectType = data.object_type;
            tt.objectID = data.object_id;
            tt.parentID = data.parent_object_id;
            tt.objectName = data.object_name;
            node.Text = data.object_name;
            node.Tag = tt;
            switch (data.object_type) {
                case 0:
                    tt.canAddChildren = true;
                    goto folder;
                case 14:
                    tt.canAddChildren = true;
                    goto folder;
                case 15:
                    tt.canAddChildren = false;
                    goto folder;
                case 16:
                    tt.canAddChildren = true;
                    goto folder;
                case 17:
                    tt.canAddChildren = true;
                    goto folder;
                default:
                    return;
            }
        folder:
            if (resetChildren)
                ResetParentNode(node);
            tt.hasChildren = true;
        }

        private void ResetParentNode(TreeNode n) {
            n.Nodes.Clear();
            n.Nodes.Add(TreeNodeLoadingText);
        }

        private void tree_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            LoadNodes(e.Node.Nodes, ((TreeNodeTag)e.Node.Tag).objectID);
        }

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {

            tree.SelectedNode = e.Node;

            if (e.Button != MouseButtons.Right)
                return;

            if (((TreeNodeTag)tree.SelectedNode.Tag).objectType == 0)
                cmTree.ShowPopup(MousePosition);
                //cmFolderNode.Show(MousePosition.X, MousePosition.Y);

        }

        private void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            string url = null;
            string title = null;
            if (e.Node.ImageIndex == 14 || e.Node.ImageIndex == 0) {
                viewingNode = e.Node;
                url = (PMS.URL_Root + string.Format("/ViewFolder.aspx?client=1&object_id={0}&user_token={1}",
                    getNodeTag(e.Node).objectID,
                    user_token
                    ));
                title = getNodeTag(e.Node).objectName;
            }
            else if (e.Node.ImageIndex == 16) {
                url = (PMS.URL_Root + "/Users.aspx?user_token=" + user_token);
                title = "User Management";
            }
            else {
                viewingNode = e.Node;
                url = (PMS.URL_Root + string.Format("/ViewFile.aspx?client=1&object_name={0}&parent={2}&user_token={1}",
                    System.Web.HttpUtility.UrlEncode(getNodeTag(e.Node).objectName),
                    user_token,
                    getNodeTag(e.Node).parentID
                    ));
                title = getNodeTag(e.Node).objectName;
            }
            if (url != null && title != null) {
                new frmBrowser(title, url, this);
            }
        }


        private void getMissingObjectIDsInTree() {
            getMissingObjectIDsInTree(tree.Nodes);
        }

        private void getMissingObjectIDsInTree(TreeNodeCollection root) {
            foreach (TreeNode node in root) {
                TreeNodeTag tt = ((TreeNodeTag)node.Tag);
                if (tt == null)
                    continue;
                if (tt.objectID == 0) {
                    uint parentID = 0;
                    if (node.Parent != null)
                        parentID = ((TreeNodeTag)node.Parent.Tag).objectID;
                    uint objectID = Soap.FindObjectID(user_token, node.Text, parentID);
                    tt.objectID = objectID;
                    node.Tag = tt;
                }
                if (node.Nodes.Count > 0)
                    getMissingObjectIDsInTree(node.Nodes);
            }
        }


        #endregion

        #region Form Events

        private void frmMain_Load(object sender, EventArgs e) {

            this.Soap = new WalshApp.WalshSoap.WalshSoap();
            this.Soap.CreateDirCompleted += new WalshApp.WalshSoap.CreateDirCompletedEventHandler(Soap_CreateDirCompleted);
            this.Soap.CreateFileCompleted += new WalshApp.WalshSoap.CreateFileCompletedEventHandler(Soap_CreateFileCompleted);

            tree.TreeViewNodeSorter = (IComparer)(new Sorter());
            //wb.Navigate("http://www.google.com");
            LoadTree();

        }

        void Soap_CreateFileCompleted(object sender, WalshApp.WalshSoap.CreateFileCompletedEventArgs e) {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            //if (PMS.OpenEditors.Count > 0) {
            //    frmStillOpen f = new frmStillOpen();
            //    f.ShowDialog();
            //    e.Cancel = true;
            //    return;
            //}
            //for (int i = PMS.OpenEditors.Count - 1; i >= 0; i--) {
            //    PMS.OpenEditors[i].Dispose();
            //}
            Application.ExitThread();
        }

        #endregion

        #region SOAP Events

        void Soap_CreateDirCompleted(object sender, WalshApp.WalshSoap.CreateDirCompletedEventArgs e) {
            if (e.Result) {
                Thread t = new Thread(new ThreadStart(getMissingObjectIDsInTree));
                t.Priority = ThreadPriority.Lowest;
                t.Start();
            }
        }

        #endregion

        #region Menu Events

        private void subfolderToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        #endregion

        #region WebBrowser Stuff

        private void axDocumentV1_BeforeNavigate(string URL, int Flags, string TargetFrameName, ref object PostData, string Headers, ref bool Processed) {
            Console.WriteLine("BeforeNavigateURL= {0}", URL);
            //false= allow navigate to continue. 
            //true= cancel navigation. 
            Processed = false;
        }

        public void OpenDocument(string url, uint object_id, string file_name, string user_token, uint parent_object_id) {
            FileEditor edit = new FileEditor(System.Web.HttpUtility.UrlDecode(url), object_id, System.Web.HttpUtility.UrlDecode(file_name), System.Web.HttpUtility.UrlDecode(user_token), parent_object_id);
            edit.StartEdit(this); // this will run in its own thread and cleans up after itself!
            PMS.OpenEditors.Add(edit);
        }

        TreeNode viewingNode = null;
        public void RefreshNode(uint object_id) {
            if (viewingNode != null)
                UpdateNodeWithData(viewingNode, Soap.GetItem(user_token, object_id), false);
        }

        #endregion

        private TreeNodeTag getNodeTag(TreeNode node) {
            return (TreeNodeTag)(node.Tag);
        }

        private bool isContainerType(uint objectType) {
            return (objectType == 14 || objectType == 0);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadNodes(tree.SelectedNode.Nodes, getNodeTag(tree.SelectedNode).objectID);
            tree.SelectedNode.Expand();
        }

        private void mnuFileUpload_ItemClick(object sender, ItemClickEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK) {
                this.Enabled = false;
                uint parentID = 0;

                TreeNode node;
                if (tree.SelectedNode == null)
                    return;
                uint cOT = getNodeTag(tree.SelectedNode).objectType;
                if (isContainerType(cOT)) {
                    parentID = getNodeTag(tree.SelectedNode).objectID;
                    node = tree.SelectedNode;
                }
                else if (tree.SelectedNode.Parent != null) {
                    parentID = getNodeTag(tree.SelectedNode.Parent).objectID;
                    node = tree.SelectedNode.Parent;
                }
                else {
                    MessageBox.Show("Cannot create documents at the root level.");
                    return;
                }

                foreach (string str in ofd.FileNames) {
                    UploadFileTask up = new UploadFileTask(user_token, parentID, str);
                    //FileUploader up = new FileUploader(user_token, parentID, str, true, true);
                    //LoadNodes(node.Nodes, parentID);
                    Program.Tasks.Add(up);
                }

                this.Enabled = true;
                this.Activate();
                this.BringToFront();
            }
        }

        private void mnuNewSubfolder_ItemClick(object sender, ItemClickEventArgs e) {
            if (tree.SelectedNode.ImageIndex != 0) // not a folder
                return; // folders can only be subfolders of folders

            uint parentID = 0;
            parentID = ((TreeNodeTag)tree.SelectedNode.Tag).objectID;

            frmFolderProperties frm = new frmFolderProperties();
            frm.IsTemplatePossible = false;
            if (frm.ShowDialog() == DialogResult.OK) {

                Soap.CreateDirAsync(parentID, "na", frm.FolderName, false);
                //LoadNodes(tree.SelectedNode.Nodes, parentID);

                TreeNode n = new TreeNode(frm.FolderName);
                TreeNodeTag tag = new TreeNodeTag();
                tag.objectID = 0; // indicates a needed object id
                tag.hasChildren = true;
                tag.objectType = 0;
                n.Tag = tag;
                n.ImageIndex = n.SelectedImageIndex = 0;
                tree.SelectedNode.Nodes.Add(n);
                tree.Sort();



            }
        }

        private void NoFeature() {
            XtraMessageBox.Show("This feature is not yet available.", "TODO", MessageBoxButtons.OK);
        }

        private void mnuFileFromTemplate_ItemClick(object sender, ItemClickEventArgs e) {
            //TODO: file from template
            NoFeature();
            return;
        }

        private void mnuNewProjectFromTemplate_ItemClick(object sender, ItemClickEventArgs e) {
            frmNewProjectFromTemplate fnp = new frmNewProjectFromTemplate();
            for (int i = 0; i < tree.Nodes.Count; i++) {
                TreeNode n = tree.Nodes[i];
                if (n.ImageIndex == 14) {
                    fnp.AddProject(n.Text, getNodeTag(n).objectID);
                }
            }
            try {
                if (fnp.ShowDialog() == DialogResult.OK) {
                    if (Soap.CreateDir(0, user_token, fnp.ProjectName, false)) {
                        uint newID = Soap.FindObjectID(user_token, fnp.ProjectName, 0);
                        uint oldID = fnp.SelectedTemplateId;
                        if (oldID > 0) {
                            Soap.CopyItemAsync(user_token, oldID, newID, false);
                            tray.ShowBalloonTip(1000,
                                "Creating project",
                                "The server is currently copying the template data into your new project. "
                                + "It may be a few minutes before all new files are available.", 
                                ToolTipIcon.Info);
                        }
                    }
                }
                LoadTree();
            }
            catch (Exception x) {
                MessageBox.Show(x.Message);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e) {
            uint parentID = 0;
            string old_name = tree.SelectedNode.Text;
            if (tree.SelectedNode.Parent != null)
                parentID = getNodeTag(tree.SelectedNode.Parent).objectID;
            DialogResult dlg = MessageBox.Show(
                    "Are you sure you want to delete '" + old_name + "' and all its revisions?", 
                    "Confirm Item Delete",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button2);
            if (dlg == DialogResult.Yes ) {
                tree.SelectedNode.Remove();
                //Soap.DeleteItemAsync(user_token, parentID, old_name);
                DeleteFileTask del = new DeleteFileTask(user_token, old_name, parentID);
                Program.Tasks.Add(del);
            }
            //tray.ShowBalloonTip(
            //    1000,
            //    old_name + " being deleted", 
            //    "Please allow a few seconds for the server to completely remove the item.", 
            //    ToolTipIcon.Info);
            return;
        }

        private void btnRename_ItemClick(object sender, ItemClickEventArgs e) {
            string old_name = tree.SelectedNode.Text;
            string new_name = frmNewName.GetNewName(old_name);
            uint parentID = 0;
            if (tree.SelectedNode.Parent != null)
                parentID = getNodeTag(tree.SelectedNode.Parent).objectID;
            if (old_name != new_name) {
                tree.SelectedNode.Text = new_name;
                TreeNodeTag tt = getNodeTag(tree.SelectedNode);
                tt.objectName = new_name;
                tree.SelectedNode.Tag = tt;
                ((TreeNodeTag)tree.SelectedNode.Tag).UpdateObjectIdAsync();
                Soap.RenameItem(user_token, parentID, old_name, new_name);
                // reload the item
                tree_NodeMouseDoubleClick(sender, 
                    new TreeNodeMouseClickEventArgs(
                        tree.SelectedNode, 
                        MouseButtons.Left, 2, 0, 0));
            }
        }



        private void btnUpdate_ItemClick(object sender, ItemClickEventArgs e) {
            if (viewingNode != null)
                RefreshNode(getNodeTag(viewingNode).objectID);
        }

        private void btnSendByEmail_ItemClick(object sender, ItemClickEventArgs e) {
            if (tree.SelectedNode == null)
                return;
            if (tree.SelectedNode.ImageIndex < 1 || tree.SelectedNode.ImageIndex > 12)
                return;
            TreeNodeTag tt = getNodeTag(tree.SelectedNode);
            FileData fd = Soap.RetrieveFileData(user_token, tt.objectID, false, true);
            FileEditor fe = new FileEditor(
                fd.tempURL, tt.objectID, fd.objectName, user_token, fd.parentId);
            fe.SendEmail(this);
        }

        private void btnSwitchToRevision_ItemClick(object sender, ItemClickEventArgs e) {
            //TODO: rename item
            NoFeature();
            return;
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e) {
            EnableMenus();
        }

        private void EnableMenus() {
            int imageIndex = -1;
            if (tree.SelectedNode != null)
                imageIndex = tree.SelectedNode.ImageIndex;
            bool isFileObject = (imageIndex >= 0 && imageIndex <= 14);
            mnuNewSubfolder.Enabled 
                = mnuNew.Enabled 
                = mnuFileFromTemplate.Enabled 
                = mnuFileUpload.Enabled
                = btnSendByEmail.Enabled
                = btnSwitchToRevision.Enabled
                = btnFulfillRFI.Enabled
                = isFileObject;
            btnSendByEmail.Enabled = (imageIndex > 0 && imageIndex < 14);
            btnDelete.Enabled
                = btnUpdate.Enabled
                = (isFileObject);
            btnRename.Enabled = (imageIndex == 0 || imageIndex == 14);
        }

        private void tree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            EnableMenus();
            UpdateTasks();
        }

        private void UpdateTasks() {
            while (lstTasks.Items.Count > Program.Tasks.Count) {
                lstTasks.Items.RemoveAt(0);
            }
            while (lstTasks.Items.Count < Program.Tasks.Count) {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add("");
                lstTasks.Items.Add(item);
            }
            int activeTasks = 0;
            Queue<int> WaitingTasks = new Queue<int>();
            for (int i = 0; i < Program.Tasks.Count; i++) {
                if (Program.Tasks[i].CurrentStatus == ITask.Status.Processing)
                    activeTasks += 1;
                else if (Program.Tasks[i].CurrentStatus == ITask.Status.Waiting)
                    WaitingTasks.Enqueue(i);
                string txt = Program.Tasks[i].GetName();
                string txt2 = Program.Tasks[i].GetStatusText();
                if (txt != lstTasks.Items[i].Text)
                    lstTasks.Items[i].Text = txt;
                if (lstTasks.Items[i].SubItems[1].Text != txt2)
                    lstTasks.Items[i].SubItems[1].Text = txt2;
            }
            while (activeTasks < 4 && WaitingTasks.Count > 0) {
                int nextTask = WaitingTasks.Dequeue();
                activeTasks += 1;
                Program.Tasks[nextTask].Start();
            }
        }

        private void tree_AfterCollapse(object sender, TreeViewEventArgs e) {

        }

        private void mnuRefreshTree_ItemClick(object sender, ItemClickEventArgs e) {
            LoadTree();
        }

        private void mnuFolderFromComputer_ItemClick(object sender, ItemClickEventArgs e) {
            if (viewingNode != null && getNodeTag(viewingNode) != null)
                frmUploadFolder._DoUpload(getNodeTag(viewingNode).objectID, null, user_token);
            else
                XtraMessageBox.Show(
                    "No folder selected. Dobule-click a folder to select it, then try again to upload files into this folder.",
                    "No folder selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void mnuProjectFromComputer_ItemClick(object sender, ItemClickEventArgs e) {
            frmUploadFolder._DoUpload(0, null, user_token);
        }

        private void tree_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Menu)
                cmTree.ShowPopup(tree.PointToScreen(Point.Empty));
        }

        private void lstTasks_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e) {
            ListViewItem item = new ListViewItem();
            ITask task = Program.Tasks[e.ItemIndex];
            item.Text = task.GetName();
            item.SubItems.Add(task.GetStatusText());
            e.Item = item;
        }

        private void lstTasks_ItemActivate(object sender, EventArgs e) {
            try {
                if (lstTasks.SelectedItems.Count == 0)
                    return;
                Program.Tasks[lstTasks.SelectedItems[0].Index].DoubleClick(this);
            }
            catch {
                XtraMessageBox.Show("An error occurred. Try again, please.");
            }
        }

        private void mnuClearCompletedItems_ItemClick(object sender, ItemClickEventArgs e) {
            for (int i = Program.Tasks.Count - 1; i >= 0; i--) {
                if (Program.Tasks[i].CurrentStatus == ITask.Status.Finished)
                    Program.Tasks.RemoveAt(i);
            }
        }

        private void tree_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void tree_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                btnDelete_ItemClick(sender, null);
            }
        }

    }
}
