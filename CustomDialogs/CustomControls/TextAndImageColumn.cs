using System;
using System.Windows.Forms;
using System.Drawing;

namespace CustomDialogs{
    public class TextAndImageColumn : DataGridViewTextBoxColumn {
        private Image _imageValue;
        private Size _imageSize;

        public bool AlignmentToRight { get; set; }

        public Image Image {
            get => this._imageValue;
            set {
                if (this.Image != value) {
                    this._imageValue = value;
                    this._imageSize = value.Size;

                    if (this.InheritedStyle != null) {
                        Padding inheritedPadding = this.InheritedStyle.Padding;
                        this.DefaultCellStyle.Padding = new Padding(_imageSize.Width,
                        inheritedPadding.Top, inheritedPadding.Right,
                        inheritedPadding.Bottom);
                    }
                }
            }
        }
        private TextAndImageCell TextAndImageCellTemplate => this.CellTemplate as TextAndImageCell;
        internal Size ImageSize => _imageSize;

        public TextAndImageColumn() {
            this.CellTemplate = new TextAndImageCell();
        }

        public override object Clone() {
            TextAndImageColumn c = base.Clone() as TextAndImageColumn;
            c._imageValue = this._imageValue;
            c._imageSize = this._imageSize;
            return c;
        }
    }

    public class TextAndImageCell : DataGridViewTextBoxCell {
        private Image imageValue;
        private Size imageSize;

        public Image Image {
            get {
                if (this.OwningColumn == null ||
            this.OwningTextAndImageColumn == null) {

                    return imageValue;
                } else if (this.imageValue != null) {
                    return this.imageValue;
                } else {
                    return this.OwningTextAndImageColumn.Image;
                }
            }
            set {
                if (this.imageValue != value) {
                    this.imageValue = value;
                    this.imageSize = value.Size;
                }
            }
        }
        public int XOffet { get; set; } = 0;

        private TextAndImageColumn OwningTextAndImageColumn => this.OwningColumn as TextAndImageColumn;

        protected override void Paint(Graphics graphics, Rectangle clipBounds,
            Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
            object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts) {
            // Paint the base content
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
                value, formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts);

            if (this.Image != null) {
                // Draw the image clipped to the cell.
                System.Drawing.Drawing2D.GraphicsContainer container =
                graphics.BeginContainer();

                graphics.SetClip(cellBounds);

                int yPadding = (int)Math.Ceiling((cellBounds.Height - this.Image.Height) / 2F);
                int xPadding = OwningTextAndImageColumn.AlignmentToRight ? OwningTextAndImageColumn.Width - 23 : 5;

                Point point = new Point(cellBounds.Location.X + xPadding + XOffet, cellBounds.Location.Y + yPadding);
                graphics.DrawImageUnscaled(this.Image, point);

                graphics.EndContainer(container);
            }
        }

        public override object Clone() {
            TextAndImageCell c = base.Clone() as TextAndImageCell;
            c.imageValue = this.imageValue;
            c.imageSize = this.imageSize;
            return c;
        }
    }
}
