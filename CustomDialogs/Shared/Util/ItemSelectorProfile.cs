using System;

namespace CustomDialogs {
    public class ItemSelectorProfile {
        public virtual bool SingleSelection { get; set; } = true;

        public virtual Func<object, bool> SelectedItemValidator { get; set; }
        public virtual Func<object, string> ItemNameCreator { get; set; }
        public virtual Func<object, bool> DoubleClickValidator { get; set; }
        public virtual Func<object, INode> NodeCreator { get; set; }
    }
}
