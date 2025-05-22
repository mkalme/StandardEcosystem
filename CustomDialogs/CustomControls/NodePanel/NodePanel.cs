using System;
using System.Windows.Forms;
using System.Drawing;

namespace CustomDialogs {
    public class NodePanel : Panel {
        public INode Node { get; set; }

        public MouseColors MouseColors { get; set; } = new MouseColors() {
            BackgroundColor = Color.FromArgb(35, 35, 35),
            HoverColor = Color.FromArgb(48, 48, 48),
            MouseDownColor = Color.FromArgb(110, 110, 110)
        };
        public MouseControl MouseControl { get; set; }

        public new event EventHandler MouseClick {
            add {
                base.MouseClick += Control_MouseClick;
                _label.MouseClick += Control_MouseClick;

                _mouseClick += value;
            }
            remove {
                base.MouseClick -= Control_MouseClick;
                _label.MouseClick -= Control_MouseClick;

                _mouseClick -= value;

            }
        }
        private event EventHandler _mouseClick;

        private Label _label;

        public NodePanel(INode node) {
            Node = node;

            BackColor = MouseColors.BackgroundColor;
            ForeColor = SystemColors.HighlightText;

            _label = new Label() {
                AutoSize = true,
                Text = node.DisplayedText,
                Location = new Point(2, 4),
                UseMnemonic = false
            };

            Controls.Add(_label);
            Width = _label.Width + 3;

            MouseControl = new MouseControl(this) {
                Colors = MouseColors
            };
        }

        private void Control_MouseClick(object sender, EventArgs e) {
            _mouseClick(this, e);
        }
    }
}
