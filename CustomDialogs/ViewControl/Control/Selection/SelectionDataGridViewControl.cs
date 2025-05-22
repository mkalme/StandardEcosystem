using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public class SelectionDataGridViewControl : DataGridViewControl {
        public IDataGridViewSelectionControl SelectionControl { get; set; }

        public event EventHandler ItemDoubleClick;

        public SelectionDataGridViewControl(IDataGridViewSelectionControl selectionControl) {
            SelectionControl = selectionControl;

            Initialize();
            SelectionControl.DataGridView = DataGridView;
        }

        public override DataGridViewColumn[] CreateColumns() {
            return SelectionControl.CreateColumns();
        }
        protected override bool SetRow(DataGridViewRow row, object item) {
            if (!SelectionControl.ViewableItemValidator(item)) return false;

            SelectionControl.SetRow(row, item);
            return true;
        }
        protected override void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            if (e.RowIndex < 0) return;
            ItemDoubleClick?.Invoke(DataGridView.Rows[e.RowIndex].Tag, EventArgs.Empty);

            SelectionControl.GridDoubleClick(e, item);
        }
    }
}
