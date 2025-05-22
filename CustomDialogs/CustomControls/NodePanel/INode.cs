using System;

namespace CustomDialogs {
    public interface INode : IDisposable {
        INode Parent { get; }

        object Node { get; }
        string DisplayedText { get; }

        event EventHandler DisplayedTextChanged;
    }
}
