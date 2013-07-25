using System;
using System.Collections.Generic;
using System.Text;

namespace WalshApp.Queue {
    public abstract class ITask {

        public enum Status {
            Waiting, Processing, Finished
        }

        private Status my_status = Status.Waiting;

        public Status CurrentStatus {
            get { return my_status; }
        }

        internal void SetStatus(Status newStatus) {
            this.my_status = newStatus;
        }

        public abstract void DoubleClick(System.Windows.Forms.Form owner);

        public abstract void Start();
        public abstract void Join();
        public abstract void Abort();
        public abstract string GetName();
        public abstract void SetName(string newName);
        public abstract string GetStatusText();
        public abstract int GetImageIndex();
    }
}
