using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class DarkLabel : Label {
        public DarkLabel() {
            ForeColor = SystemColors.HighlightText;
            AutoSize = true;
        }
    }
}
