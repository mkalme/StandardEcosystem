using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public class View : IView {
        public IViewNode ViewNode { get; }
        public ICollection<object> SelectedItems { get; private set; } = new List<object>();

        public event EventHandler Update;
        public event EventHandler Removed;
        public event EventHandler Replaced;

        public View(IViewNode viewNode) {
            SelectedItems = new List<object>();

            ViewNode = viewNode;
            ViewNode.ContentsChanged += CallUpdate;
            ViewNode.Removed += CallRemoved;
        }

        private void CallUpdate(object sender, EventArgs e) {
            ICollection<object> items = ViewNode.Items;

            List<object> selectedItems = new List<object>();
            foreach (var selectedItem in SelectedItems) {
                if (items.Contains(selectedItem)) selectedItems.Add(selectedItem);
            }
            SelectedItems = selectedItems;

            Update?.Invoke(this, EventArgs.Empty);
        }
        private void CallRemoved(object sender, EventArgs e) {
            Removed?.Invoke(ViewNode.Node, EventArgs.Empty);
        }

        public void RaiseReplaced() {
            Replaced?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose() {
            ViewNode.ContentsChanged -= CallUpdate;
            ViewNode.Removed -= CallRemoved;

            ViewNode.Dispose();
        }
    }
}
