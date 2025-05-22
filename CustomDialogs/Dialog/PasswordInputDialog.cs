using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class PasswordInputDialog : Form {
        public string Title { get; set; }
        public string Message { get; set; }
        public string KeyVisibleName { get; set; }

        public string Password {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }
        public Func<string, bool> Validator { get; set; }

        public bool DialogClosed { get; set; } = true;

        public PasswordInputDialog(string title, string message, string keyVisibleName, string password = "") {
            InitializeComponent();

            Title = title;
            Message = message;

            Password = password;
            Validator = p => true;

            Text = Title;
            MessageLabel.Text = Message;
            KeyVisibleName = keyVisibleName;

            SetTextBoxChar(false);
            KeyVisibleCheckBox.Text = $"{KeyVisibleName} visible";

            ToolTip.SetToolTip(CopyButton, "Copy key");
            ToolTip.SetToolTip(PasteButton, "Paste key");

            TextBox.Select();
        }

        private void CopyButton_Click(object sender, EventArgs e) {
            string text = TextBox.Text;
            if (string.IsNullOrEmpty(text)) text = " ";

            Clipboard.SetText(text);
        }
        private void PasteButton_Click(object sender, EventArgs e) {
            TextBox.Text = Clipboard.GetText();
        }

        private void TextBox_InputChanged(object sender, EventArgs e) {
            CharactersLabel.Text = $"{TextBox.Text.Length} characters";
        }

        private void KeyVisibleCheckBox_CheckedChanged(object sender, EventArgs e) {
            SetTextBoxChar(KeyVisibleCheckBox.Checked);
        }
        private void SetTextBoxChar(bool keyVisible) {
            if (keyVisible) {
                TextBox.PasswordChar = '\0';
                TextBox.YOffset = 0;
            } else {
                TextBox.PasswordChar = '\u25CF';
                TextBox.YOffset = -2;
            }
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            if (!Validator(Password)) return;

            DialogClosed = false;
            Close();
        }
    }
}
