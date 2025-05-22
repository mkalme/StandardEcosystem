using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class ItemSelector : Form {
        public ViewController ViewController { get; set; }
        public IView CurrentView => ViewController.CurrentView;
        public IViewNode CurrentNode => CurrentView.ViewNode;

        public IList<object> SelectedItems { get; private set; } = new List<object>();
        public bool DialogClosed { get; private set; } = true;

        public ItemSelectorProfile Profile { get; set; }

        public IDataGridViewSelectionControl GridViewControl { get; }

        public ItemSelector(ViewController viewController, IDataGridViewSelectionControl gridViewControl, ItemSelectorProfile profile) {
            InitializeComponent();

            ViewController = viewController;
            GridViewControl = gridViewControl;
            Profile = profile;

            SelectionDataGridViewControl selectionControl = new SelectionDataGridViewControl(gridViewControl);
            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, selectionControl);
            ViewControl.Initialize(viewController, viewControl);

            MenuStrip.Renderer = new CustomToolStripRenderer();
            GridViewControl.DataGridView.ContextMenuStrip = MenuStrip;

            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = Profile.NodeCreator;

            ViewControl.BeginUpdate += ViewController_BeginUpdate;
            ViewControl.Updated += ViewController_Updated;

            selectionControl.ItemDoubleClick += ItemDoubleClick;
            GridViewControl.DataGridView.SelectionChanged += GridView_SelectionChanged;

            GridViewControl.DataGridView.MultiSelect = !profile.SingleSelection;
        }

        private void ItemSelector_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }

        private void ItemDoubleClick(object sender, EventArgs e) {
            if (Profile.DoubleClickValidator(sender)) {
                DialogClosed = false;
                Close();
            }
        }
        private void SelectButton_Click(object sender, EventArgs e) {
            DialogClosed = false;
            Close();
        }

        //Update
        private bool _inUpdate = false;

        private void ViewController_BeginUpdate(object sender, EventArgs e) {
            _inUpdate = true;
        }
        private void ViewController_Updated(object sender, EventArgs e) {            
            SetSelectedItems();
            DisplaySelectedItems();
            _inUpdate = false;
        }

        private void DisplaySelectedItems() {
            StringBuilder builder = new StringBuilder();

            int count = SelectedItems.Count();
            for (int i = 0; i < count; i++) {
                builder.Append(Profile.ItemNameCreator(SelectedItems.ElementAt(i)));

                if (i < count - 1) builder.Append("; ");
            }

            SelectedItemsTextBox.Text = builder.ToString();
        }

        private void GridView_SelectionChanged(object sender, EventArgs e) {
            if (_inUpdate) return;

            CurrentView.SelectedItems.Clear();

            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in GridViewControl.DataGridView.SelectedRows) {
                selectedRows.Add(row);
            }
            
            foreach (DataGridViewRow row in selectedRows.OrderBy(x => x.Index)) {
                CurrentView.SelectedItems.Add(row.Tag);
            }

            SetSelectedItems();
            DisplaySelectedItems();
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            int rowIndex = GetRowIndexFromPoint(MenuStrip.Bounds.Location);
            object item;

            if (rowIndex > -1) item = GridViewControl.DataGridView.Rows[rowIndex].Tag;
            else item = CurrentNode.Node;

            SelectMenuItem.Enabled = Profile.SelectedItemValidator(item);
        }
        private void SelectMenuItem_Click(object sender, EventArgs e) {
            int rowIndex = GetRowIndexFromPoint(MenuStrip.Bounds.Location);
            SelectedItems = new List<object>() { GridViewControl.DataGridView.Rows[rowIndex].Tag };

            DialogClosed = false;
            Close();
        }

        //Functions
        private int GetRowIndexFromPoint(Point point) {
            Point rPoint = GridViewControl.DataGridView.PointToClient(point);
            return GridViewControl.DataGridView.HitTest(rPoint.X, rPoint.Y).RowIndex;
        }

        private void SetSelectedItems() {
            List<object> items = new List<object>();
            items.AddRange(CurrentView.SelectedItems);

            if (!Profile.SingleSelection || CurrentView.SelectedItems.Count < 1) {
                items.Add(CurrentView.ViewNode.Node);
            }

            List<object> selectedItems = new List<object>(items.Count);
            foreach (var item in items) {
                if (Profile.SelectedItemValidator(item)) selectedItems.Add(item);
            }

            SelectedItems = selectedItems;
        }
    }
}
