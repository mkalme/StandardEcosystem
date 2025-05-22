using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class MouseControl {
        public IList<Control> Controls { get; set; }
        public IList<Control> IgnoreClick { get; set; }

        public MouseColors Colors {
            get => _colors;
            set {
                _colors = value;
                SetColor(Colors.BackgroundColor);
            }
        }
        private MouseColors _colors = new MouseColors();

        public event EventHandler Click;

        public MouseControl(Control parent, params Control[] ignoreClick) {
            Controls = new List<Control>() { parent };
            IgnoreClick = new List<Control>(ignoreClick);
            AddControls(parent, Controls);

            foreach (var control in Controls) {
                control.MouseEnter += MouseEnter;
                control.MouseLeave += MouseLeave;

                if (!IgnoreClick.Contains(control)) {
                    control.MouseDown += MouseDown;
                    control.MouseUp += MouseUp;
                    control.MouseClick += MouseClick;
                }
            }
        }
        private void AddControls(Control control, IList<Control> controls) {
            foreach (Control child in control.Controls) {
                AddControls(child, controls);
                controls.Add(child);
            }
        }

        private void MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) return;

            SetColor(Colors.MouseDownColor);
        }
        private void MouseUp(object sender, MouseEventArgs e) {
            bool hover = false;

            foreach (var control in Controls) {
                if (!hover) hover = control.ClientRectangle.Contains(control.PointToClient(Cursor.Position));
            }

            SetColor(hover ? Colors.HoverColor : Colors.BackgroundColor);
        }

        private void MouseEnter(object sender, EventArgs e) {
            SetColor(Colors.HoverColor);
        }
        private void MouseLeave(object sender, EventArgs e) {
            SetColor(Colors.BackgroundColor);
        }

        private void MouseClick(object sender, EventArgs e) {
            if (Click != null) Click(this, EventArgs.Empty);
        }

        private void SetColor(Color color) {
            foreach (var control in Controls) {
                control.BackColor = color;
            }
        }
    }
}
