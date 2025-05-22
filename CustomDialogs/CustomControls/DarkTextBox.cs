using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class DarkTextBox : UserControl {
        public override Color BackColor {
            get => base.BackColor;
            set {
                base.BackColor = value;
                TextBox.BackColor = value;
            }
        }
        public Color TextForeColor {
            get => TextBox.ForeColor;
            set => TextBox.ForeColor = value;
        }
        public override string Text {
            get => TextBox.Text;
            set {
                TextBox.Text = value;

                if (value == null) return;
                TextBox.Select(value.Length, 0);
            }
        }
        public bool ReadOnly {
            get => TextBox.ReadOnly;
            set => TextBox.ReadOnly = value;
        }
        public char PasswordChar {
            get => TextBox.PasswordChar;
            set => TextBox.PasswordChar = value;
        }

        public BorderStyle TextBoxBorderStyle {
            get => BorderStyle;
            set => BorderStyle = value;
        }

        public event EventHandler InputChanged {
            add {
                TextBox.TextChanged += value;
            }
            remove {
                TextBox.TextChanged -= value;
            }
        }

        public int XOffset {
            get => _xOffset;
            set {
                _xOffset = value;
                SetTextPosition();
            }
        }
        public int YOffset {
            get => _yOffset;
            set {
                _yOffset = value;
                SetTextPosition();
            }
        }

        private int _xOffset = 0, _yOffset = 0;

        public DarkTextBox() {
            InitializeComponent();

            SetTextPosition();
        }

        public void SetCursor(int position) {
            TextBox.SelectionStart = position;
            TextBox.SelectionLength = 0;
        }
        public void SetCursorAtTheEnd() {
            SetCursor(TextBox.Text.Length);
        }

        private void SetTextPosition() {
            int height = TextBox.Font.Height;
            int top = (int)Math.Ceiling((Height - 2 - height) / 2F);

            Padding = new Padding(Padding.Left + XOffset, top + YOffset, Padding.Right, Padding.Bottom);
        }

        private void CustomTextBox_SizeChanged(object sender, EventArgs e) {
            SetTextPosition();
        }

        private void HintLabel_MouseDown(object sender, MouseEventArgs e) {
            HintLabel.Visible = false;
            TextBox.Focus();
        }
        private void TextBox_MouseDown(object sender, MouseEventArgs e) {
            HintLabel.Visible = false;
            TextBox.Focus();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.CapsLock) e.SuppressKeyPress = true;
        }

        private void TextBox_Leave(object sender, EventArgs e) {
            HintLabel.Visible = string.IsNullOrEmpty(TextBox.Text);
        }
    }
}
