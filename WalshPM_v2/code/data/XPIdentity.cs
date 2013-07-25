using System;
using System.Data;
using System.ComponentModel;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.Metadata;
namespace WalshPM_v2.code.data {
    [NonPersistent, MemberDesignTimeVisibility(false), Serializable]
    public abstract class XPIdentity : XPCustomObject {

        public const string COL_OWNER = "Owner";


        public static bool IsIdentity(Type type) {
            return typeof(XPIdentity).IsAssignableFrom(type);
        }

        protected XPIdentity() : base() {
            _oid = Guid.Empty;
        }

        protected XPIdentity(Session session)
            : base(session) {
            _oid = Guid.Empty;
        }

        protected XPIdentity(Session session, XPClassInfo classInfo)
            : base(session, classInfo) {
            _oid = Guid.Empty;
        }

        public const string IdentityFieldName = "Oid";
        private Guid _oid;


        [Browsable(false)]
        [Key(AutoGenerate = true), Persistent(IdentityFieldName)]
        public Guid Oid {
            get { return _oid; }
            set {
                Guid oid = Oid;
                if (oid != value) {
                    _oid = value;
                    OnChanged(IdentityFieldName, oid, value);
                }
            }
        }

        public static OperandProperty OidOperand { get { return new OperandProperty(IdentityFieldName); } }
        public const string COL_OID = "Oid";

    }
}
