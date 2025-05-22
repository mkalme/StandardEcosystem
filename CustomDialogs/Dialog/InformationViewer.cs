using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class InformationViewer : Form {
        public BuildInformationPanel BuildInformationPanel { get; set; }
        public KeyInformationPanel KeyInformationPanel { get; set; }
        public ProgramInformationPanel ProgramInformationPanel { get; set; }

        public InformationViewer(BuildInformationPanel buildPanel, KeyInformationPanel keyPanel, ProgramInformationPanel programPanel) {
            InitializeComponent();

            BuildInformationPanel = buildPanel;
            KeyInformationPanel = keyPanel;
            ProgramInformationPanel = programPanel;

            LoadDialog();
        }

        private void GlobalContainer_Paint(object sender, PaintEventArgs e) {
            KeyGridView.ClearSelection();
        }

        private void LoadDialog() {
            //Build
            BuildLabel.Text = BuildInformationPanel.HeaderText;
            BuildPictureBox.Image = BuildInformationPanel.Icon;

            NameTextBox.Text = BuildInformationPanel.Name;
            VersionTextBox.Text = BuildInformationPanel.Version;
            VersionReleasedTextBox.Text = BuildInformationPanel.VersionReleased;

            //Key
            KeyLabel.Text = KeyInformationPanel.HeaderText;
            KeyPictureBox.Image = KeyInformationPanel.Icon;
            CurrentKeyTextBox.Text = KeyInformationPanel.CurrentKeySince;
            LoadGridView();

            //Program
            ProgramCreatedLabel.Text = $"{ProgramInformationPanel.ProgramName} created:";
            ProgramLabel.Text = ProgramInformationPanel.HeaderText;
            ProgramPictureBox.Image = ProgramInformationPanel.Icon;

            ProviderCreatedTextBox.Text = ProgramInformationPanel.ProgramCreated;
            LocatedInTextBox.Text = ProgramInformationPanel.ProgramLocatedIn;
            LocatedInTextBox.SetCursor(0);
        }
        private static string FormatFileVersion(string version) {
            string[] n = version.Split(".");

            return $"{n[0]}.{n[1]}.{n[2]}";
        }

        private void LoadGridView() {
            KeyGridView.ClearSelection();

            for (int i = 0; i < KeyInformationPanel.KeyHistory.Count(); i++) {
                DateTime date = KeyInformationPanel.KeyHistory.ElementAt(i);

                KeyGridView.Rows.Add(date);
                DisplayImageInCell(i, KeyInformationPanel.KeyCellIcon, 0, 22);
            }
        }
        private void DisplayImageInCell(int rowIndex, Image image, int columnIndex, int padding) {
            ((TextAndImageCell)KeyGridView.Rows[rowIndex].Cells[columnIndex]).Image = image;

            KeyGridView.Rows[rowIndex].Cells[columnIndex].Style.Padding = new Padding(padding, 0, 0, 0);
        }

        private void CopyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            StringBuilder builder = new StringBuilder();

            foreach (DateTime date in KeyInformationPanel.KeyHistory) {
                builder.AppendLine(date.ToString());
            }

            Clipboard.SetText(builder.ToString());
        }
        private void OpenInFileExplorerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("explorer.exe", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        private void FullViewButton_Click(object sender, EventArgs e) {
            CustomDialog.ShowDateListViewer(KeyInformationPanel.KeyHistory, Properties.Resources._64pxKey, "Key history", "Key changed");
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
