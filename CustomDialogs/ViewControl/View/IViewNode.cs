using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public interface IViewNode : IDisposable {
        object Node { get; }
        object Parent { get; }
        ICollection<object> Items { get; }

        event EventHandler ContentsChanged;
        event EventHandler Removed;

        IViewNode CreateNode(object node);
    }
}
