using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WalshApp {
    class Sorter : IComparer {

        public int Compare(object x, object y) {
            try {
                TreeNode xx = (TreeNode)x;
                TreeNode yy = (TreeNode)y;
                if (xx.ImageIndex == 0 && yy.ImageIndex != 0)
                    return -1;
                if (xx.ImageIndex != 0 && yy.ImageIndex == 0)
                    return 1;
                else
                    return (new CaseInsensitiveComparer()).Compare(xx.Text, yy.Text);
            }
            catch {
                return 0;
            }
        }

    }
}
