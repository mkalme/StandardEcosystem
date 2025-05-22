using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class DateListViewer : Form {
        public IEnumerable<DateTime> Dates { get; set; }
        public Image Image { get; set; }

        public DateListViewer(IEnumerable<DateTime> dates, Image image, string title, string columnHeaderText) {
            InitializeComponent();

            Dates = dates;
            Image = image;
            Text = title;
            DateColumn.HeaderText = columnHeaderText;

            Icon = ImageToIconConverter.Convert(Image, 64, 64);

            LoadDialog();
        }

        private void LoadDialog() {
            GridView.Rows.Clear();

            Image image = Image.Resize(18, 18);

            int count = Dates.Count();
            for (int i = 0; i < count; i++) {
                DateTime date = Dates.ElementAt(count - i - 1);

                GridView.Rows.Add(date, (DateTime.Now - date).ToRelativeTimeString());
                GridView.Rows[GridView.Rows.Count - 1].DisplayImage(DateColumn, image, 25);

            }

            EntriesCountLabel.Text = $"Entries: {count}";
        }

        private void UpdateHistoryViewer_Load(object sender, EventArgs e) {
            GridView.ClearSelection();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
