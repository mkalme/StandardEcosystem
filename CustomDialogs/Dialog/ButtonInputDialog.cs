using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class ButtonInputDialog : Form {
        public string Title { get; set; }
        public string Message { get; set; }
        public string[] Buttons { get; set; }
        public Image Image { get; set; }

        public string Result { get; private set; }
        public bool DialogClosed { get; private set; } = true;

        public ButtonInputDialog(string title, string message, params string[] buttons) {
            InitializeComponent();

            Title = title;
            Message = message;
            Buttons = buttons;
        }

        private void DialogButtonInput_Load(object sender, EventArgs e) {
            LoadDialog();
        }
        private void LoadDialog() {
            if (Image != null) {
                Icon = ImageToIconConverter.Convert(Image, 32, 32);
                PictureBox.Image = Image;
            } else {
                PictureBox.Visible = false;
            }
            
            Text = Title;
            MessageRichTextBox.Text = Message;

            SetDimensions(AddButtons());
        }

        private int AddButtons() {
            ButtonContainer.ColumnCount = Buttons.Length;
            ButtonContainer.ColumnStyles.Clear();

            int buttonContainerWidth = 70;
            foreach (string buttonText in Buttons) {
                DarkButton button = new DarkButton() {
                    Text = buttonText,
                    Margin = new Padding(0, 1, 10, 0),
                    Height = 24,
                    TextAlign = ContentAlignment.TopCenter,
                    MaximumSize = new Size(1000, 24),
                    MinimumSize = new Size(75, 24),
                    AutoSize = true
                };
                button.Click += Button_Click;

                ButtonContainer.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                ButtonContainer.Controls.Add(button, ButtonContainer.Controls.Count, 0);

                buttonContainerWidth += button.Width + button.Margin.Right;
            }

            return buttonContainerWidth;
        } 
        private void SetDimensions(int buttonContainerWidth) {
            Graphics graphics = CreateGraphics();

            int textWidth = (int)(graphics.MeasureString(Message, MessageRichTextBox.Font).Width * 0.9525F) + 70 + (PictureBox.Visible ?  PictureBox.Width : 0);
            Width = Math.Max(buttonContainerWidth, textWidth).Clamp(250, 600);

            int textHeight = (int)graphics.MeasureString(Message, MessageRichTextBox.Font, Width).Height;
            Height = MessageRichTextBox.Location.Y + MessageRichTextBox.Height + 69 + textHeight;

            CenterToScreen();
        }

        private void Button_Click(object sender, EventArgs e) {
            Result = ((DarkButton)sender).Text;
            DialogClosed = false;

            Close();
        }
    }
}
