using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class PasswordGeneratorDialog : Form {
        public string Title { get; set; }
        public string Message { get; set; }
        public Image Image { get; set; }

        public string Password {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }
        public string InputName { get; set; } = "Password";

        public IPasswordGenerator PasswordGenerator { get; set; }
        public Func<string, bool> Validator { get; set; }

        public bool DialogClosed { get; private set; } = true;

        public PasswordGeneratorDialog(Image image, string title, string message, string password = "") {
            InitializeComponent();

            Image = image;
            Title = title;
            Message = message;
            Password = password;

            ToolTip.SetToolTip(CopyButton, "Copy key");
            ToolTip.SetToolTip(PasteButton, "Paste key");

            SetTextBoxChar(true);

            TextBox.Select();
        }

        private void PasswordGeneratorDialog_Load(object sender, EventArgs e) {
            LoadDialog();
        }
        private void LoadDialog() {
            Icon = ImageToIconConverter.Convert(Image, 64, 64);
            PictureBox.Image = Image;
            GeneratePasswordButton.Image = Image.Resize(16, 16, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);

            Text = Title;
            MessageLabel.Text = Message;

            FormatLabel.Text = PasswordGenerator.Format;
            NumericUpDown.Visible = !PasswordGenerator.SetLength;

            GeneratePasswordButton.Text = $"Generate random {InputName.ToLower()}";
            PasswordVisibleCheckBox.Text = $"{InputName} visible";

            SetButtonDimensions();
        }
        private void SetButtonDimensions() {
            int width = (int)CreateGraphics().MeasureString(GeneratePasswordButton.Text, GeneratePasswordButton.Font).Width;
            width += 21;

            GeneratePasswordButton.Width = width;
        }

        private void TextBox_InputChanged(object sender, EventArgs e) {
            CharactersLabel.Text = $"{TextBox.Text.Length} characters";
        }

        private void KeyVisibleCheckBox_CheckedChanged(object sender, EventArgs e) {
            SetTextBoxChar(PasswordVisibleCheckBox.Checked);
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

        private void GeneratePasswordButton_Click(object sender, EventArgs e) {
            Password = PasswordGenerator.Generate((int)NumericUpDown.Value);
        }

        private void CopyButton_Click(object sender, EventArgs e) {
            string text = TextBox.Text;
            if (string.IsNullOrEmpty(text)) text = " ";

            Clipboard.SetText(text);
        }
        private void PasteButton_Click(object sender, EventArgs e) {
            TextBox.Text = Clipboard.GetText();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            if (!Validator(Password)) return;

            DialogClosed = false;
            Close();
        }
    }
}
