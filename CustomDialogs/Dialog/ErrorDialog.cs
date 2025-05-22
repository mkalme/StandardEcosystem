using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class ErrorDialog : Form {
        public string ErrorMessage { get; set; }
        public string ErrorBody { get; set; }

        public bool ShowBorders { get; set; }

        public ErrorDialog(string errorMessage, string errorBody, bool showBorders) {
            InitializeComponent();

            PictureBox.Image = SystemIcons.Error.ToBitmap();
            Icon = SystemIcons.Error;

            ErrorMessage = errorMessage;
            ErrorBody = errorBody;
            ShowBorders = showBorders;

            RichTextBoxPanel.BorderStyle = ShowBorders ? BorderStyle.FixedSingle : BorderStyle.None;
        }

        private void ErrorDialog_Load(object sender, EventArgs e) {
            LoadDialog();
        }
        private void LoadDialog() {
            Text = ErrorMessage;
            RichTextBox.Text = ErrorBody;

            SetDimensions();
        }

        private void SetDimensions() {
            Graphics graphics = CreateGraphics();

            Width = ((int)graphics.MeasureString(ErrorBody, RichTextBox.Font).Width + 100).Clamp(300, 600);
            Height = ((int)graphics.MeasureString(ErrorBody, RichTextBox.Font, RichTextBox.Width).Height + 110).Clamp(150, 600);

            CenterToScreen();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
