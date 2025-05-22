using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public class ViewController : IDisposable {
        public List<IView> Views { get; set; }
        public int Index { get; set; }
        public IView CurrentView => Views[Index];

        public IViewNode ViewNode { get; set; }

        public event EventHandler Update;

        private bool _disposed;

        public ViewController(IViewNode viewNode) {
            ViewNode = viewNode;

            Views = new List<IView>();
            CreateParents(ViewNode);
        }

        private void CreateParents(IViewNode viewNode) {
            IViewNode parent = viewNode;
            
            while (true) {
                Views.Insert(0, CreateView(parent));
                Index = Views.Count - 1;

                if (parent.Parent == null) return;

                parent = parent.CreateNode(parent.Parent);
            }
        }

        public void OpenChild(object child) {
            if (Index >= Views.Count - 1) {
                Views.Add(CreateView(ViewNode.CreateNode(child)));
            } else if (!ReferenceEquals(Views[Index + 1].ViewNode.Node, child)) {
                RemoveRange(Index + 1);

                Views.Add(CreateView(ViewNode.CreateNode(child)));
            }

            Index++;
            CallUpdate();
        }
        public void OpenParent(object parent) {
            int index = Views.FindIndex(x => ReferenceEquals(x.ViewNode.Node, parent));

            if (index < 0) {
                object group = Views[0].ViewNode.Parent;

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
            object parent = CurrentView.ViewNode.Parent;
            if (parent == null) return;

            if (Index > 0 && ReferenceEquals(parent, Views[Index - 1].ViewNode.Node)) {
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

        private IView CreateView(IViewNode group) {
            IView view = new View(group);
            view.Update += CallObjectUpdate;
            view.Removed += OnNodeRemove;

            return view;
        }

        private void CallUpdate() {
            Update?.Invoke(this, EventArgs.Empty);
        }
        private void CallObjectUpdate(object sender, EventArgs e) {
            if (CurrentView == sender as IView) CallUpdate();
        }

        private void OnNodeRemove(object sender, EventArgs e) {
            RemoveRange(Views.FindIndex(x => ReferenceEquals(x.ViewNode.Node, sender)));
        }

        private void RemoveRange(int index) {
            if (index < 0) return;

            int remove = Views.Count - index;
            for (int i = 0; i < remove; i++) {
                IView view = Views[index];
                view.Update -= CallObjectUpdate;
                view.Removed -= OnNodeRemove;
                view.RaiseReplaced();

                Views.RemoveAt(index);
                
                view.Dispose();
            }

            Index = Index >= Views.Count ? Views.Count - 1 : Index;
        }

        public void Dispose() {
            if (!_disposed) {
                foreach (var view in Views) {
                    view.Update -= CallObjectUpdate;
                    view.Removed -= OnNodeRemove;
                    view.Dispose();
                }

                Views.Clear();

                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }
    }
}
