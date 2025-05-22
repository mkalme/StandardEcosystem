using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class DarkLinkLabel : LinkLabel {
        public Color DefaultColor { get; set; } = Color.FromArgb(205, 205, 205);

        public bool Clickable {
            get => _clickable;
            set {
                _clickable = value;
                if (_clickable) {
                    LinkColor = DefaultColor;
                    LinkBehavior = LinkBehavior.SystemDefault;
                    _cursor = Cursors.Hand;
                } else {
                    LinkColor = DisabledLinkColor;
                    LinkBehavior = LinkBehavior.NeverUnderline;
                    _cursor = Cursors.Arrow;
                }
            }
        }
        private bool _clickable = true;

        private Cursor _cursor = Cursors.Arrow;

        protected override void OnMouseEnter(EventArgs e) {
            base.OnMouseEnter(e);
            OverrideCursor = _cursor;
        }
        protected override void OnMouseLeave(EventArgs e) {
            base.OnMouseLeave(e);
            OverrideCursor = null;
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            OverrideCursor = _cursor;
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            if(Clickable) base.OnMouseDown(e);
        }
    }
}
