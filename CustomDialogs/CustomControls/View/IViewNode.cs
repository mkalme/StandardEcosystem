using System;

namespace CustomDialogs {
    public interface IViewNode<T> {
        T Node { get; }
        T Parent { get; }

        event EventHandler ContentsChanged;
        event EventHandler Removed;

        IViewNode<T> CreateNode(T node);
    }
}
