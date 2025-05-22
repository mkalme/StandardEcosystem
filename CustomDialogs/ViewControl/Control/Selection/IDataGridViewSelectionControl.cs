using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public interface IDataGridViewSelectionControl {
        DataGridView DataGridView { get; set; }
        Func<object, bool> ViewableItemValidator { get; }

        DataGridViewColumn[] CreateColumns();
        void SetRow(DataGridViewRow row, object item);
        void GridDoubleClick(DataGridViewCellEventArgs e, object item);
    }
}
