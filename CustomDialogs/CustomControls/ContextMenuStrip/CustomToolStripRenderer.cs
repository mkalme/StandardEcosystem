using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class CustomToolStripRenderer : ToolStripProfessionalRenderer {
        public CustomMenuStripColors Colors { get; }
        public IDictionary<ToolStripItem, Point> ImageOffsets { get; } = new Dictionary<ToolStripItem, Point>();

        public CustomToolStripRenderer() : base(CustomMenuStripColors.Default) {
            Colors = CustomMenuStripColors.Default;
        }
        public CustomToolStripRenderer(CustomMenuStripColors colors) : base(colors) {
            Colors = colors;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e) {
            var menuItem = e.Item as ToolStripMenuItem;
            if (menuItem != null) e.ArrowColor = Colors.ArrowColor;
            
            base.OnRenderArrow(e);
        }
        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e) {            
            var rect = e.ImageRectangle;
            rect.Offset(new Point(6, 0));

            if (ImageOffsets.TryGetValue(e.Item, out Point offset)) rect.Offset(offset);

            base.OnRenderItemImage(new ToolStripItemImageRenderEventArgs(e.Graphics, e.Item, e.Image, rect));
        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) {
            base.OnRenderToolStripBorder(e);

            Rectangle rect = e.AffectedBounds;
            rect.Offset(1, 1);

            e.Graphics.DrawRectangle(new Pen(Colors.InnerBorderColor), new Rectangle(rect.Location, e.AffectedBounds.Size - new Size(3, 3)));
            e.Graphics.DrawRectangle(new Pen(Colors.BorderColor), new Rectangle(e.AffectedBounds.Location, e.AffectedBounds.Size - new Size(1, 1)));
        }
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e) {
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)e.Item;
            int width = toolStripSeparator.Width, height = toolStripSeparator.Height;

            Color foreColor = Colors.BorderColor;
            Color backColor = Colors.BackColor;

            e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);
            e.Graphics.DrawLine(new Pen(foreColor), 4, height / 2, width - 5, height / 2);
        }
    }
}
