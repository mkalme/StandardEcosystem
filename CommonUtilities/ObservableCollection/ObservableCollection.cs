using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CommonUtilities {
    public class ObservableCollection<T> : ICollection<T> {
        private ICollection<T> _collection;

        public int Count => _collection.Count;
        public bool IsReadOnly => _collection.IsReadOnly;

        public event EventHandler<T[]> OnItemsAdd;
        public event EventHandler<T[]> OnItemsRemove;

        public ObservableCollection(ICollection<T> collection) {
            _collection = collection;
        }

        protected void CallEvents(bool added, params T[] items) {
            if (added) {
                OnItemsAdd?.Invoke(this, items);
            } else {
                OnItemsRemove?.Invoke(this, items);
            }
        }

        public void Add(T item) {
            _collection.Add(item);
            CallEvents(true, item);
        }

        public bool Contains(T item) {
            return _collection.Contains(item);
        }
        public void CopyTo(T[] array, int arrayIndex) {
            _collection.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item) {
            bool exists = _collection.Remove(item);

            if (exists) {
                CallEvents(false, item);
            }

            return exists;
        }
        public void Clear() {
            T[] copy = _collection.ToArray();
            _collection.Clear();

            if (copy.Length > 0) CallEvents(false, copy);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return _collection.GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator() {
            return _collection.GetEnumerator();
        }
    }
}
