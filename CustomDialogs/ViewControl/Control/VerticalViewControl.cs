using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomDialogs {
    public class VerticalViewControl : IViewControl {
        public Control Control {
            get => Panel;
        }
        protected TableLayoutPanel Panel;

        public IReadOnlyCollection<(RowStyle, IViewControl)> Rows {
            get => _rows.AsReadOnly();
        }
        private List<(RowStyle, IViewControl)> _rows;

        public VerticalViewControl() {
            Panel = new TableLayoutPanel() {
                Margin = new Padding(0)
            };
            _rows = new List<(RowStyle, IViewControl)>();
        }

        public void AddRow(RowStyle rowStyle, IViewControl viewControl) {
            Panel.RowCount++;
            Panel.Controls.Add(viewControl.Control, 0, Panel.RowCount - 1);

            _rows.Add((rowStyle, viewControl));
        }
        public void UpdateControl(IView view) {
            foreach (var row in _rows) {
                row.Item2.UpdateControl(view);
            }
        }
    }
}
