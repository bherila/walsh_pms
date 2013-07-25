using System;
using DevExpress.Xpo;

namespace WalshPM_v2.code.data {

    public class PMGroup : XPIdentity {
        public PMGroup()
            : base() {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PMGroup(Session session)
            : base(session) {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction() {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}