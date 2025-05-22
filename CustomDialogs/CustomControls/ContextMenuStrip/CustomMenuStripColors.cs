using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class CustomMenuStripColors : ProfessionalColorTable {
        public Color BorderColor { get; set; } = Color.FromArgb(170, 170, 170);
        public Color InnerBorderColor { get; set; } = Color.FromArgb(80, 80, 80);

        public Color BackColor { get; set; } = Color.FromArgb(45, 45, 45);
        public Color HoverColor { get; set; } = Color.FromArgb(80, 80, 80);
        public Color DisabledHoverColor { get; set; } = Color.FromArgb(100, 100, 100);

        public Color ArrowColor { get; set; } = Color.FromArgb(170, 170, 170);

        public static CustomMenuStripColors Default {
            get {
                return new CustomMenuStripColors();
            }
        }

        public override Color MenuItemBorder => DisabledHoverColor;

        public override Color MenuItemSelected => HoverColor;
        public override Color MenuItemSelectedGradientBegin => HoverColor;
        public override Color MenuItemSelectedGradientEnd => HoverColor;

        public override Color ImageMarginGradientBegin => BackColor;
        public override Color ImageMarginGradientMiddle => BackColor;
        public override Color ImageMarginGradientEnd => BackColor;
    }
}
