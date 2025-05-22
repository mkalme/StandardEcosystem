using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class BrowserDialog : Form {
        public BrowseType BrowseType { get; set; }
        public string FileFilter { get; set; }
        public string SelectedPath {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }

        public bool DialogClosed { get; private set; } = true;

        public BrowserDialog(BrowseType browseType, string fileFilter, string selectedPath = "") {
            InitializeComponent();

            BrowseType = browseType;
            FileFilter = fileFilter;
            SelectedPath = selectedPath;

            ToolTip.SetToolTip(CopyButton, "Copy path");
            ToolTip.SetToolTip(PasteButton, "Paste path");

            OpenFileDialog.Filter = fileFilter;
            SaveFileDialog.Filter = fileFilter;

            TextBox.Select();
        }

        private void BrowserDialog_Load(object sender, EventArgs e) {
            LoadDialog();
        }
        private void BrowserDialog_Shown(object sender, EventArgs e) {
            Thread thread = new Thread(() => {
                Thread.Sleep(50);

                Invoke(new Action(() => {
                    SelectedPath = OpenBrowser();
                }));
            });

            thread.Start();
        }

        private void LoadDialog() {
            string displayText = GetDisplayText();
            Text = displayText;
            BrowseLabel.Text = displayText;

            Image image = GetImage();
            BrowseButton.Image = image;
            Icon = ImageToIconConverter.Convert(image, image.Width, image.Height);
        }

        private string GetDisplayText() {
            switch (BrowseType) {
                case BrowseType.BrowseFolder:
                    return "Browse for a folder.";
                case BrowseType.OpenFile:
                    return "Open a file.";
                case BrowseType.SaveFile:
                    return "Save file to.";
                default:
                    return "";
            }
        }
        private Image GetImage() {
            switch (BrowseType) {
                case BrowseType.BrowseFolder:
                    return Properties.Resources._16pxFolderClosed;
                case BrowseType.OpenFile:
                    return Properties.Resources._16pxOpenFile;
                case BrowseType.SaveFile:
                default:
                    return Properties.Resources._16pxDocument;
            }
        }
        private string OpenBrowser() {
            switch (BrowseType) {
                case BrowseType.BrowseFolder:
                    FolderBrowserDialog.ShowDialog();

                    return FolderBrowserDialog.SelectedPath;
                case BrowseType.OpenFile:
                    OpenFileDialog.InitialDirectory = Path.GetDirectoryName(SelectedPath);
                    OpenFileDialog.FileName = SelectedPath;
                    OpenFileDialog.ShowDialog();

                    return OpenFileDialog.FileName;
                case BrowseType.SaveFile:
                    SaveFileDialog.InitialDirectory = Path.GetDirectoryName(SelectedPath);
                    SaveFileDialog.FileName = SelectedPath;
                    SaveFileDialog.ShowDialog();

                    return SaveFileDialog.FileName;
                default:
                    return "";
            }
        }

        private void CopyButton_Click(object sender, EventArgs e) {
            string text = SelectedPath;
            if (string.IsNullOrEmpty(text)) text = " ";

            Clipboard.SetText(text);
        }
        private void PasteButton_Click(object sender, EventArgs e) {
            SelectedPath = Clipboard.GetText();
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            SelectedPath = OpenBrowser();
        }
        private void DoneButton_Click(object sender, EventArgs e) {
            DialogClosed = false;
            Close();
        }
    }
}
