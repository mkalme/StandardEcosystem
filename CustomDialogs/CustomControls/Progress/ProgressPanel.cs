using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class ProgressPanel : UserControl {
        public string OriginalActivityTypeText { get; set; } = "";
        public string ActivityTypeText => UploadingLabel.Text;
        
        public Color ProgressColor {
            get => ProgressContainer.BackColor;
            set => ProgressContainer.BackColor = value;
        }

        public ProgressPanel() {
            InitializeComponent();
        }

        public void Update(IProgressReport report) {
            OriginalActivityTypeText = report.ActivityType;

            ProgressContainer.Width = (int)(report.Percentage * ProgressBar.Width);
            MessageLabel.Text = report.Message;
            PercentageLabel.Text = $"{((double)(report.Percentage * 100)).ToString("0.##")}%";
        }
        public void SetText(string text) {
            UploadingLabel.Text = text;
        }
    }
}
