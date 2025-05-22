using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class DataGridViewUserControl : UserControl {
        public DataGridViewControl GridViewControl { get; private set; }

        public DataGridViewUserControl() {
            InitializeComponent();
        }

        public void Initialize(DataGridViewControl dataGridViewControl) {
            GridViewControl = dataGridViewControl;

            Controls.Add(GridViewControl.DataGridView);
        }
    }
}
