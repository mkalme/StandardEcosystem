using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public class ViewController<T> {
        public List<View<T>> Views { get; set; }
        public int Index { get; set; }
        public View<T> CurrentView => Views[Index];

        public IViewNode<T> ViewNode { get; set; }

        public event EventHandler Update;

        public ViewController(IViewNode<T> viewNode) {
            ViewNode = viewNode;
            
            Views = new List<View<T>>() { CreateView(viewNode) };
            Index = 0;
        }

        public void OpenChild(T child) {
            if (Index >= Views.Count - 1) {
                Views.Add(CreateView(ViewNode.CreateNode(child)));
            } else if (!ReferenceEquals(Views[Index + 1].Node, child)) {
                RemoveRange(Index + 1);

                Views.Add(CreateView(ViewNode.CreateNode(child)));
            }

            Index++;
            CallUpdate();
        }
        public void OpenParent(T parent) {
            int index = Views.FindIndex(x => ReferenceEquals(x.Node, parent));

            if (index < 0) {
                T group = Views[0].ViewNode.Parent;

                while (true) {
                    Views.Insert(0, CreateView(ViewNode.CreateNode(group)));

                    if (ReferenceEquals(group, parent)) break;
                    group = Views[0].ViewNode.Parent;
                }

                Index = 0;
            } else {
                Index = index;
            }

            CallUpdate();
        }

        public void Prev() {
            T parent = CurrentView.ViewNode.Parent;
            if (parent == null) return;

            if (Index > 0 && ReferenceEquals(parent, Views[Index - 1].Node)) {
                Index--;
            } else {
                Views.Insert(Index, CreateView(CurrentView.ViewNode.CreateNode(parent)));
            }

            CallUpdate();
        }
        public void Next() {
            if (Index >= Views.Count - 1) return;

            Index++;
            CallUpdate();
        }

        private View<T> CreateView(IViewNode<T> group) {
            View<T> view = new View<T>(group);
            view.Update += CallObjectUpdate;
            view.ViewNode.Removed += OnNodeRemove;

            return view;
        }

        private void CallUpdate() {
            if (Update != null) Update.Invoke(this, EventArgs.Empty);
        }
        private void CallObjectUpdate(object sender, EventArgs e) {
            CallUpdate();
        }

        private void OnNodeRemove(object sender, EventArgs e) {
            RemoveRange(Views.FindIndex(x => ReferenceEquals(x.Node, sender)));
        }

        private void RemoveRange(int index) {
            if (index < 0) return;

            for (int i = 0; i <= Views.Count - index; i++) {
                View<T> view = Views[index];
                view.ViewNode.Removed -= OnNodeRemove;

                Views.RemoveAt(index);
            }
        }
    }
}
