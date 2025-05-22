using System;
using System.Collections.Generic;

namespace CommonUtilities {
    public class ObservableList<T> : ObservableCollection<T>, IList<T> {
        private IList<T> _list;

        public T this[int index] {
            get => _list[index];
            set {
                T oldItem = _list[index];
                _list[index] = value;

                CallEvents(false, oldItem);
                CallEvents(true, value);
            }
        }

        public ObservableList() : this(new List<T>()) {}
        public ObservableList(int capacity) : this(new List<T>(capacity)) {}
        public ObservableList(IList<T> list, bool useThisReference = false) : this(useThisReference ? list : new List<T>(list)) {}
        private ObservableList(IList<T> list) : base(list) {
            _list = list;
        }

        public void Insert(int index, T item) {
            _list.Insert(index, item);
            CallEvents(true, item);
        }
        public int IndexOf(T item) {
            return _list.IndexOf(item);
        }

        public void RemoveAt(int index) {
            T item = _list[index];
            _list.RemoveAt(index);

            CallEvents(false, item);
        }
    }
}
