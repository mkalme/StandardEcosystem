using System;
using System.Windows.Forms;

namespace CloudServiceProvider.GoogleCloud.Common {
    public partial class CredentialsEditor : Form {
        public Credentials Credentials { get; private set; }

        public CredentialsEditor(Credentials credentials) {
            InitializeComponent();

            Credentials = credentials;

            LoadDialog();
        }

        private void LoadDialog() {
            RichTextBox.Text = Credentials.CredentialsJsonString;
            BucketNameTextBox.Text = Credentials.BucketName;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Credentials.ApplyUpdateMode();

            Credentials.CredentialsJsonString = RichTextBox.Text;
            Credentials.BucketName = BucketNameTextBox.Text;

            Credentials.SuspendUpdateMode();

            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
