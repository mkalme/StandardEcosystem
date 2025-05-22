using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomDialogs {
    public abstract class DataGridViewControl : IViewControl {
        public DataGridView DataGridView { get; protected set; }
        public Control Control => DataGridView;

        public IView CurrentView { get; private set; }

        private ViewCache<int> _viewCache = new ViewCache<int>();

        public void Initialize() {
            DataGridView = new DarkDataGridView() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            DataGridView.Columns.AddRange(CreateColumns());

            DataGridView.CellDoubleClick += GridView_CellDoubleClick;
            DataGridView.SelectionChanged += GridView_SelectionChanged;
        }
        public abstract DataGridViewColumn[] CreateColumns();

        //Update
        private bool _inUpdate = false;
        public void UpdateControl(IView view) {
            _inUpdate = true;

            _viewCache.SetCache(CurrentView ?? view, DataGridView.FirstDisplayedScrollingRowIndex);
            int topRow = _viewCache.GetCache(view);

            CurrentView = view;
            DataGridView.ClearSelection();

            DataGridView.Rows.Clear();

            DataGridView.Rows.Add();
            DataGridViewRow clone = DataGridView.Rows[0];

            List<DataGridViewRow> rows = new List<DataGridViewRow>(view.ViewNode.Items.Count);
            List<object> items = new List<object>(view.ViewNode.Items.Count);

            for (int i = 0; i < view.ViewNode.Items.Count; i++) {
                DataGridViewRow row = clone.Clone() as DataGridViewRow;
                object item = view.ViewNode.Items.ElementAt(i);

                if (SetRow(row, item)) {
                    rows.Add(row);
                    items.Add(item);
                }
            }

            DataGridView.Rows.Clear();
            DataGridView.Rows.AddRange(rows.ToArray());

            for (int i = 0; i < rows.Count; i++) {
                rows[i].Tag = items[i];
                rows[i].Selected = view.SelectedItems.Contains(items[i]);
            }

            if (view.SelectedItems.Count == 0) DataGridView.ClearSelection();

            if (topRow > -1 && topRow < DataGridView.Rows.Count) {
                DataGridView.FirstDisplayedScrollingRowIndex = topRow;
            }

            _inUpdate = false;
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            GridDoubleClick(e, DataGridView.Rows[e.RowIndex].Tag);
        }
        private void GridView_SelectionChanged(object sender, EventArgs e) {
            if (_inUpdate) return;

            CurrentView.SelectedItems.Clear();

            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in DataGridView.SelectedRows) {
                selectedRows.Add(row);
            }

            foreach (DataGridViewRow row in selectedRows.OrderBy(x => x.Index)) {
                CurrentView.SelectedItems.Add(row.Tag);
            }
        }

        public void SelectRow(object item) {
            foreach (DataGridViewRow row in DataGridView.Rows) {
                if (row.Tag == item) {
                    row.Selected = true;
                    return;
                }
            }
        }
        public object GetItemFromPoint(Point point) {
            Point rPoint = DataGridView.PointToClient(point);
            int rowIndex = DataGridView.HitTest(rPoint.X, rPoint.Y).RowIndex;

            if (rowIndex < 0) return null;
            return DataGridView.Rows[rowIndex].Tag;
        }

        protected abstract bool SetRow(DataGridViewRow row, object item);
        protected abstract void GridDoubleClick(DataGridViewCellEventArgs e, object item);
    }
}
