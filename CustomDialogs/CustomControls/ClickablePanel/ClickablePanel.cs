using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public class ClickablePanel : UserControl {
        public event EventHandler UserClick;

        public MouseControl MouseControl { get; set; }

        protected void CallUserClick(object sender, EventArgs e) {
            if (UserClick != null) UserClick(sender, e);
        }
    }
}
