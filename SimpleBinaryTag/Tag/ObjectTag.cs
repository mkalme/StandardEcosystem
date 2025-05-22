using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SimpleBinaryTag {
    public sealed class ObjectTag : Tag, IDictionary<string, Tag> {
        private Dictionary<string, Tag> _internalDictionary;

        public Tag this[string key] {
            get => _internalDictionary[key];
            set => _internalDictionary[key] = value;
        }

        public ICollection<string> Keys => _internalDictionary.Keys;
        public ICollection<Tag> Values => _internalDictionary.Values;

        public int Count => _internalDictionary.Count;
        public bool IsReadOnly => false;

        public ObjectTag() : base(TagID.Object) {
            _internalDictionary = new Dictionary<string, Tag>();
        }
        public ObjectTag(int capacity) : base(TagID.Object) {
            _internalDictionary = new Dictionary<string, Tag>(capacity);
        }
        public ObjectTag(IDictionary<string, Tag> dictionary) : base(TagID.Object) {
            _internalDictionary = new Dictionary<string, Tag>(dictionary);
        }

        public void Add(string key, Tag value) {
            _internalDictionary.Add(key, value);
        }
        public void Add(KeyValuePair<string, Tag> item) {
            _internalDictionary.Add(item.Key, item.Value);
        }

        public bool Contains(KeyValuePair<string, Tag> item) {
            return _internalDictionary.ContainsKey(item.Key);
        }
        public bool ContainsKey(string key) {
            return _internalDictionary.ContainsKey(key);
        }
        public bool TryGetValue(string key, [MaybeNullWhen(false)] out Tag value) {
            return _internalDictionary.TryGetValue(key, out value);
        }
        public void CopyTo(KeyValuePair<string, Tag>[] array, int arrayIndex) {
            ((IDictionary<string, Tag>)_internalDictionary).CopyTo(array, arrayIndex);
        }

        public bool Remove(string key) {
            return _internalDictionary.Remove(key);
        }
        public bool Remove(KeyValuePair<string, Tag> item) {
            return _internalDictionary.Remove(item.Key);
        }
        public void Clear() {
            _internalDictionary.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return _internalDictionary.GetEnumerator();
        }
        public IEnumerator<KeyValuePair<string, Tag>> GetEnumerator() {
            return _internalDictionary.GetEnumerator();
        }

        public override Tag Clone() {
            ObjectTag output = new ObjectTag(Count);

            foreach (KeyValuePair<string, Tag> childPair in _internalDictionary) {
                output.Add(childPair.Key, childPair.Value.Clone());
            }

            return output;
        }
        public override bool Equals(Tag other) {
            if (other.ID != TagID.Object) return false;

            ObjectTag objectTag = other as ObjectTag;
            if (objectTag.Count != _internalDictionary.Count) return false;

            SortedDictionary<string, Tag> left = new SortedDictionary<string, Tag>(_internalDictionary);
            SortedDictionary<string, Tag> right = new SortedDictionary<string, Tag>(objectTag._internalDictionary);

            for (int i = 0; i < Count; i++) {
                var leftPair = left.ElementAt(i);
                var rightPair = right.ElementAt(i);

                if (leftPair.Key != rightPair.Key) return false;
                if (!leftPair.Value.Equals(rightPair.Value)) return false;
            }

            return true;
        }
    }
}
