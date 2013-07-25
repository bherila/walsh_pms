using System;
using DevExpress.Xpo;

namespace WalshPM_v2.code.data {

    public class PMUser : XPIdentity {
        public PMUser()
            : base() {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PMUser(Session session)
            : base(session) {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction() {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        public string Username {
            get;
            set;
        }

        public string Password {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }

        public bool IsAdmin {
            get;
            set;
        }

    }

}