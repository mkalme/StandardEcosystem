using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public interface IView : IDisposable {
        IViewNode ViewNode { get; }
        ICollection<object> SelectedItems { get; }

        event EventHandler Update;
        event EventHandler Removed;
        event EventHandler Replaced;

        void RaiseReplaced();
    }
}
