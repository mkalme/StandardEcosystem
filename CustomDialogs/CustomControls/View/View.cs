using System;
using System.Collections.Generic;

namespace CustomDialogs {    
    public class View<T> {
        public T Node { get; set; }
        public IList<object> SelectedItems { get; set; }

        public IViewNode<T> ViewNode { get; set; }

        public event EventHandler Update;

        public View(IViewNode<T> viewNode) {
            Node = viewNode.Node;
            SelectedItems = new List<object>();

            ViewNode = viewNode;
            ViewNode.ContentsChanged += CallUpdate;
        }

        private void CallUpdate(object sender, EventArgs e) {
            if (Update != null) Update(this, EventArgs.Empty);
        }
    }
}
