using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class PathNodePanel : Panel {
        public event EventHandler ButtonClick;

        private IList<NodePanel> _buttons;
        private INode _node;

        private NodeProfile _currentProfile;
        private int _x = 0;

        public PathNodePanel() {
            BorderStyle = BorderStyle.FixedSingle;

            Margin = new Padding(0);
            Dock = DockStyle.Fill;

            _buttons = new List<NodePanel>();
        }

        public void Load(INode node) {
            _node = node;
            AddAllButtons();
        }

        private void AddAllButtons() {
            NodeProfile newProfile = NodeProfile.FromNode(_node);

            if (_currentProfile != null) {
                int uncommonIndex = newProfile.GetFirstUncommonIndex(_currentProfile);
                if (uncommonIndex > -1) {
                    RemoveButtons(uncommonIndex);
                }
            }

            if (newProfile.NodeComponents.Count < _buttons.Count) {
                RemoveButtons(newProfile.NodeComponents.Count - 1);
            }
            if (newProfile.NodeComponents.Count == _buttons.Count) {
                _currentProfile = newProfile;
                return;
            }

            int addBy = newProfile.NodeComponents.Count - _buttons.Count;
            for (int i = 0; i < addBy; i++) {
                if (_buttons.Count > 0) {
                    Label label = CreateArrowLabel();
                    label.Location = new Point(_x - 2, 4);

                    Controls.Add(label);

                    _x += 10;
                }

                INode node = newProfile.NodeComponents[_buttons.Count].Node;
                node.DisplayedTextChanged += OnNodeDisplayedTextChanged;

                NodePanel button = new NodePanel(node);
                button.MouseClick += OnButtonClick;

                if (_buttons.Count == 0) {
                    button.Width += 4;
                    button.Padding = new Padding(2, 0, 0, 0);
                }

                button.Location = new Point(_x, 0);
                
                Controls.Add(button);
                _buttons.Add(button);

                _x += button.Width;

                button.BringToFront();
            }

            _currentProfile = newProfile;
        }
        private void RemoveButtons(int index) {
            while (index < _buttons.Count) {
                RemoveButton(_buttons[_buttons.Count - 1]);

                Controls.Remove(_buttons[_buttons.Count - 1]);
                if(Controls.Count > 0) Controls.RemoveAt(Controls.Count - 1);

                _x -= _buttons[_buttons.Count - 1].Width;
                _x -= _buttons.Count > 1 ? 10 : 0;
                _buttons.RemoveAt(_buttons.Count - 1);
            }
        }
        private void RemoveButton(NodePanel button) {
            button.MouseClick -= OnButtonClick;
            button.Node.DisplayedTextChanged -= OnNodeDisplayedTextChanged;
            button.Node.Dispose();
        }

        private static Label CreateArrowLabel() { 
            return new Label() {
                Text = ">",
                ForeColor = Color.FromArgb(128, 128, 128),
                Font = new Font("Consolas", 9, FontStyle.Bold),
                AutoSize = true
            };
        }

        private void OnButtonClick(object sender, EventArgs e) {
            ButtonClick.Invoke(sender, e);
        }
        private void OnNodeDisplayedTextChanged(object sender, EventArgs e) {
            Load(_node);
        }
    }
}
