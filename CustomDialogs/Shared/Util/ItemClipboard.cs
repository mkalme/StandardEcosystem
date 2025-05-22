using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public class ItemClipboard {
        public IList<object> CopiedItems { get; }

        public Action<object, EventHandler> AddEvent { get; }
        public Action<object, EventHandler> RemoveEvent { get; }

        public ItemClipboard(Action<object, EventHandler> addEvent, Action<object, EventHandler> removeEvent) {
            CopiedItems = new List<object>();

            AddEvent = addEvent;
            RemoveEvent = removeEvent;
        }

        public void Clear() {
            foreach (var item in CopiedItems) {
                RemoveEvent(item, Item_Deleted);
            }

            CopiedItems.Clear();
        }
        public void SetClipboard(IEnumerable<object> copiedItems) {
            Clear();

            foreach (var item in copiedItems) {
                CopiedItems.Add(item);

                AddEvent(item, Item_Deleted);
            }
        }

        private void Item_Deleted(object sender, EventArgs e) {
            RemoveEvent(sender, Item_Deleted);

            CopiedItems.Remove(sender);
        }
    }
}
