using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class DarkGroupBox : GroupBox {
        public Color BorderColor { get; set; } = Color.FromArgb(105, 105, 105);

        protected override void OnPaint(PaintEventArgs e) {
            Size tSize = TextRenderer.MeasureText(Text, Font);

            Rectangle borderRect = e.ClipRectangle;
            borderRect.Y = borderRect.Y + tSize.Height / 2;
            borderRect.Height = borderRect.Height - tSize.Height / 2;
            ControlPaint.DrawBorder(e.Graphics, borderRect, BorderColor, ButtonBorderStyle.Solid);

            Rectangle textRect = e.ClipRectangle;
            textRect.X = textRect.X + 3;
            textRect.Width = tSize.Width + 2;
            textRect.Height = tSize.Height;
            e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(textRect.Location.X + 1, textRect.Location.Y, textRect.Width - 4, textRect.Height));
            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textRect);
        }
    }
}
