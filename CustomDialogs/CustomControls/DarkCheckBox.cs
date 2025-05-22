using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class DarkCheckBox : CheckBox {
        public Color BoxBorderColor { get; set; } = Color.FromArgb(100, 100, 100);

        public Color BoxBackColor { get; set; } = Color.Transparent;
        public Color BoxHoverBackColor { get; set; } = Color.FromArgb(45, 45, 45);
        public Color BoxMouseDownBackColor { get; set; } = Color.FromArgb(70, 70, 70);

        public DarkCheckBox() {
            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            TextAlign = ContentAlignment.MiddleRight;
            FlatAppearance.BorderSize = 0;
            AutoSize = false;
            Height = 15;

            ForeColor = SystemColors.HighlightText;
        }

        protected override void OnPaint(PaintEventArgs pevent) {
            pevent.Graphics.Clear(BackColor);

            using (SolidBrush brush = new SolidBrush(ForeColor)) {
                pevent.Graphics.DrawString(Text, Font, brush, 18, -1);
            }

            Rectangle rect = new Rectangle(new Point(1, 1), new Size(12, 12));

            Color boxBackcolor = MouseIsOverControl() ? BoxHoverBackColor : BoxBackColor;
            if (MouseButtons == MouseButtons.Left) {
                boxBackcolor = BoxMouseDownBackColor;
            }

            pevent.Graphics.FillRectangle(new SolidBrush(boxBackcolor), rect);
            pevent.Graphics.DrawRectangle(new Pen(BoxBorderColor), rect);

            if (Checked) {
                using (Font wing = new Font("Wingdings", 14f))
                using (SolidBrush brush = new SolidBrush(ForeColor)) {
                    pevent.Graphics.DrawString("ü", wing, brush, -1, -2);
                }
            }
        }

        private bool MouseIsOverControl() {
            return ClientRectangle.Contains(PointToClient(Cursor.Position));
        }
    }
}
