using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public interface IDataGridViewControl {
        DataGridView DataGridView { get; }

        bool SetRow(DataGridViewRow row, object item);
    }
}
