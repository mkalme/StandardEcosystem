using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class ClickablePanelContainer : UserControl {
        public event EventHandler PanelClick;

        private MouseColors _unselectedColors = new MouseColors();
        private MouseColors _selectedColors = new MouseColors() {
            BackgroundColor = Color.FromArgb(65, 65, 65),
            HoverColor = Color.FromArgb(80, 80, 80),
            MouseDownColor = Color.FromArgb(100, 100, 100)
        };

        private TableLayoutPanel _panel;
        public IReadOnlyCollection<ClickablePanel> CustomPanels;

        public ClickablePanelContainer(IEnumerable<ClickablePanel> customPanels) {
            InitializeComponent();

            ScrollablePanel.AutoScroll = true;

            _panel = new TableLayoutPanel();
            _panel.RowCount = customPanels.Count();
            _panel.Dock = DockStyle.Top;
            _panel.Margin = new Padding(0);
            _panel.AutoSize = true;

            CustomPanels = new ReadOnlyCollection<ClickablePanel>(customPanels.ToList());
            AddPanels(_panel);

            ScrollablePanel.Controls.Add(_panel);
        }

        private void AddPanels(TableLayoutPanel output) {
            foreach (var panel in CustomPanels) {
                CustomizePanel(panel);

                output.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                output.Controls.Add(panel, 0, output.Controls.Count);
            }
        }
        private void CustomizePanel(ClickablePanel panel) {
            panel.UserClick += CallPanelClick;
            panel.Dock = DockStyle.Top;
        }

        private void CallPanelClick(object sender, EventArgs e) {
            if (PanelClick != null) PanelClick(sender, e);
        }

        public void AddPanel(ClickablePanel panel) {
            CustomPanels = new ReadOnlyCollection<ClickablePanel>(CustomPanels.Append(panel).ToList());

            CustomizePanel(panel);

            _panel.RowStyles.Add(new RowStyle(SizeType.Absolute, panel.Height));
            _panel.Controls.Add(panel, 0, _panel.Controls.Count);
        }

        public void SelectPanel(ClickablePanel panel) {
            Deselect();

            panel.MouseControl.Colors = _selectedColors;
        }
        public void Deselect() {
            foreach (var control in CustomPanels) {
                control.MouseControl.Colors = _unselectedColors;
            }
        }
    }
}
