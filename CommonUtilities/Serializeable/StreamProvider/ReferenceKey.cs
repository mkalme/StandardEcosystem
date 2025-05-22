using System;

namespace CommonUtilities {
    public class ReferenceKey : IEquatable<ReferenceKey> {
        public byte[] Key { get; set; }

        public static implicit operator ReferenceKey(byte[] key) => new ReferenceKey(key);
        public static implicit operator byte[](ReferenceKey key) => key.Key;

        public ReferenceKey(byte[] key) {
            Key = key;
        }

        public ReferenceKey Clone() {
            byte[] key = new byte[Key.Length];
            Array.Copy(Key, 0, key, 0, Key.Length);

            return key;
        }

        public bool Equals(ReferenceKey other) {
            if (Key.Length != other.Key.Length) return false;

            for (int i = 0; i < Key.Length; i++) {
                if (Key[i] != other.Key[i]) return false;
            }

            return true;
        }
    }
}
