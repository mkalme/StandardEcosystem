using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CommonUtilities {
    public class ObservableDictionary<TKey, TValue> : ObservableCollection<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue> {
        private IDictionary<TKey, TValue> _dictionary;

        public TValue this[TKey key] {
            get => _dictionary[key];
            set {
                TValue oldItem = _dictionary[key];
                _dictionary[key] = value;

                CallEvents(false, new KeyValuePair<TKey, TValue>(key, oldItem));
                CallEvents(true, new KeyValuePair<TKey, TValue>(key, value));
            }
        }

        public ICollection<TKey> Keys => _dictionary.Keys;
        public ICollection<TValue> Values => _dictionary.Values;

        public ObservableDictionary() : this(new Dictionary<TKey, TValue>()) { }
        public ObservableDictionary(int capacity) : this(new Dictionary<TKey, TValue>(capacity)) { }
        public ObservableDictionary(IDictionary<TKey, TValue> dictionary, bool useThisReference) : this(useThisReference ? dictionary : new Dictionary<TKey, TValue>(dictionary)) {
            _dictionary = dictionary;
        }
        public ObservableDictionary(IDictionary<TKey, TValue>  dictionary) : base(dictionary) {
            _dictionary = dictionary;
        }

        public void Add(TKey key, TValue value) {
            _dictionary.Add(key, value);
            CallEvents(true, new KeyValuePair<TKey, TValue>(key, value));
        }

        public bool ContainsKey(TKey key) {
            return _dictionary.ContainsKey(key);
        }
        public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value) {
            return _dictionary.TryGetValue(key, out value);
        }

        public bool Remove(TKey key) {
            if (_dictionary.TryGetValue(key, out TValue value)) {
                _dictionary.Remove(key);
                CallEvents(false, new KeyValuePair<TKey, TValue>(key, value));

                return true;
            }

            return false;
        }
    }
}
