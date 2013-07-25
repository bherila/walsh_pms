using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace WalshWeb.Shared {
    public class TreeNodeTag {
        public uint objectType = 0;
        public bool hasChildren = false;
        public bool canAddChildren = false;
        public uint objectID = 0;
        public uint parentID = 0;
        public string objectName = string.Empty;


        private WalshApp.WalshSoap.WalshSoap Soap = null;
        public void UpdateObjectIdAsync() {
            if (Soap != null)
                return;
            Soap = new WalshApp.WalshSoap.WalshSoap();
            Soap.FindObjectIDCompleted += new WalshApp.WalshSoap.FindObjectIDCompletedEventHandler(Soap_FindObjectIDCompleted);
        }

        private void Soap_FindObjectIDCompleted(object sender, WalshApp.WalshSoap.FindObjectIDCompletedEventArgs e) {
            if (e.Cancelled)
                return;
            this.objectID = e.Result;
            Soap.Dispose();
            Soap = null;
        }

        
    }
}
