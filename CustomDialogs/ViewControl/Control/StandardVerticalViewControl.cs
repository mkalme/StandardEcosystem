using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public class StandardVerticalViewControl : VerticalViewControl {
        public HeaderToolBarControl HeaderToolBar { get; private set; }
        public DataGridViewControl DataGridViewControl { get; private set; }

        public StandardVerticalViewControl(ViewControl parent, DataGridViewControl dataGridViewControl) {
            HeaderToolBar = new HeaderToolBarControl() {
                Dock = DockStyle.Fill
            };
            HeaderToolBar.RefreshView = parent.UpdateView;

            DataGridViewControl = dataGridViewControl;

            AddRow(new RowStyle(SizeType.AutoSize), HeaderToolBar);
            AddRow(new RowStyle(SizeType.Percent, 100), DataGridViewControl);

            Panel.Dock = DockStyle.Fill;
        }
    }
}
