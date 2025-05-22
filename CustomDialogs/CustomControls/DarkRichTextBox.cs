using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class DarkRichTextBox : RichTextBox {
        public Color DisabledBackColor { get; set; } = Color.FromArgb(52, 52, 52);
        public Color NonDisabledBackColor { get; set; } = Color.FromArgb(45, 45, 45);

        public Color DisabledForeColor { get; set; } = Color.FromArgb(170, 170, 170);
        public Color NonDisabledForeColor { get; set; } = SystemColors.HighlightText;

        public new bool ReadOnly {
            get => base.ReadOnly;
            set {
                base.ReadOnly = value;
                BackColor = value ? DisabledBackColor : NonDisabledBackColor;
                ForeColor = value ? DisabledForeColor : NonDisabledForeColor;
            }
        }

        public DarkRichTextBox() {
            BackColor = NonDisabledBackColor;
            ForeColor = NonDisabledForeColor;
        }
    }
}
