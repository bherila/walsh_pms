using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using DevExpress.XtraEditors;

namespace WalshApp.Queue {
    class DeleteFileTask : ITask, IDisposable {

        private uint parentId;
        private bool busy = false;
        private string userToken;
        private string status = "Waiting";
        private object userState = null;

        WalshSoap.WalshSoap soap = null;

        public DeleteFileTask(string userToken, string fileName, uint parentId) {
            SetStatus(Status.Waiting);
            this.userToken = userToken;
            this.fileName = fileName;
            this.parentId = parentId;
        }

        public override void Start() {
            if (soap == null) {
                status = "Processing";
                SetStatus(Status.Processing);
                soap = new WalshApp.WalshSoap.WalshSoap();
                soap.DeleteItemCompleted += new WalshApp.WalshSoap.DeleteItemCompletedEventHandler(soap_DeleteItemCompleted);
                busy = true;
                soap.DeleteItemAsync(userToken, parentId, fileName);
            }
        }

        void soap_DeleteItemCompleted(object sender, WalshApp.WalshSoap.DeleteItemCompletedEventArgs e) {
            busy = false;
            if (e.Error != null) {
                status = e.Error.Message;
            }
            else {
                if (e.Result) {
                    status = "Completed";
                }
                else {
                    status = "Failed";
                }
            }
            SetStatus(Status.Finished);
            soap.Dispose();
            soap = null;
        }

        public override void Join() {
            while (busy) {
                Thread.Sleep(0);
            }
        }

        public override void Abort() {
            soap.CancelAsync(userState);
        }

        public override string GetName() {
            return "Delete " + fileName;
        }

        string fileName = "file";

        public override void SetName(string newName) {
            fileName = newName;
        }

        public override string GetStatusText() {
            return status;
        }

        public override int GetImageIndex() {
            return -1;
        }


        #region IDisposable Members

        public void Dispose() {
            if (soap != null)
                soap.Dispose();
        }

        #endregion

        public override void DoubleClick(System.Windows.Forms.Form owner) {
        }
    }

}
