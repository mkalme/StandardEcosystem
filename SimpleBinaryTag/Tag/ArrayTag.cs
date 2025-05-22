using System;
using System.Linq;

namespace SimpleBinaryTag {
    public sealed class ArrayTag : Tag {
        public Array InternalArray { get; private set; }
        public int Length => InternalArray.Length;

        public static implicit operator ArrayTag(byte[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(short[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(int[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(long[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(float[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(double[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(bool[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(char[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(string[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(DateTime[] array) => new ArrayTag(array);
        public static implicit operator ArrayTag(ObjectTag[] array) => new ArrayTag(array);

        public static implicit operator byte[](ArrayTag array) => (byte[])array.InternalArray;
        public static implicit operator short[](ArrayTag array) => (short[])array.InternalArray;
        public static implicit operator int[](ArrayTag array) => (int[])array.InternalArray;
        public static implicit operator long[](ArrayTag array) => (long[])array.InternalArray;
        public static implicit operator float[](ArrayTag array) => (float[])array.InternalArray;
        public static implicit operator double[](ArrayTag array) => (double[])array.InternalArray;
        public static implicit operator bool[](ArrayTag array) => (bool[])array.InternalArray;
        public static implicit operator char[](ArrayTag array) => (char[])array.InternalArray;
        public static implicit operator string[](ArrayTag array) => (string[])array.InternalArray;
        public static implicit operator DateTime[](ArrayTag array) => (DateTime[])array.InternalArray;
        public static implicit operator ObjectTag[](ArrayTag array) => (ObjectTag[])array.InternalArray;

        public ArrayTag(byte[] array) : base(TagID.UnsignedByteArray) {
            InternalArray = array;
        }
        public ArrayTag(short[] array) : base(TagID.Int16Array) {
            InternalArray = array;
        }
        public ArrayTag(int[] array) : base(TagID.Int32Array) {
            InternalArray = array;
        }
        public ArrayTag(long[] array) : base(TagID.Int64Array) {
            InternalArray = array;
        }
        public ArrayTag(float[] array) : base(TagID.SingleArray) {
            InternalArray = array;
        }
        public ArrayTag(double[] array) : base(TagID.DoubleArray) {
            InternalArray = array;
        }
        public ArrayTag(bool[] array) : base(TagID.BooleanArray) {
            InternalArray = array;
        }
        public ArrayTag(char[] array) : base(TagID.CharArray) {
            InternalArray = array;
        }
        public ArrayTag(string[] array) : base(TagID.StringArray) {
            InternalArray = array;
        }
        public ArrayTag(DateTime[] array) : base(TagID.DateTimeArray) {
            InternalArray = array;
        }
        public ArrayTag(ObjectTag[] array) : base(TagID.ObjectArray) {
            InternalArray = array;
        }

        public override Tag Clone() {
            switch (ID) {
                case TagID.UnsignedByteArray: return CloneArray((byte[])InternalArray);
                case TagID.Int16Array: return CloneArray((short[])InternalArray);
                case TagID.Int32Array: return CloneArray((int[])InternalArray);
                case TagID.Int64Array: return CloneArray((long[])InternalArray);
                case TagID.SingleArray: return CloneArray((float[])InternalArray);
                case TagID.DoubleArray: return CloneArray((double[])InternalArray);
                case TagID.BooleanArray: return CloneArray((bool[])InternalArray);
                case TagID.CharArray: return CloneArray((char[])InternalArray);
                case TagID.StringArray: return CloneArray((string[])InternalArray);
                case TagID.DateTimeArray: return CloneArray((DateTime[])InternalArray);
                case TagID.ObjectArray:
                    ObjectTag[] objArray = (ObjectTag[]) InternalArray;
                    ObjectTag[] output = new ObjectTag[Length];

                    for (int i = 0; i < Length; i++) {
                        output[i] = (ObjectTag)objArray[i].Clone();
                    }

                    return output;
                default: return null;
            }
        }
        private static T[] CloneArray<T>(T[] array) {
            T[] t = new T[array.Length];

            Array.Copy(array, t, t.Length);

            return t;
        }

        public override bool Equals(Tag other) {
            if (other.ID != ID) return false;

            switch (ID) {
                case TagID.UnsignedByteArray: return ArrayEquals<byte>(this, (ArrayTag)other);
                case TagID.Int16Array: return ArrayEquals<short>(this, (ArrayTag)other);
                case TagID.Int32Array: return ArrayEquals<int>(this, (ArrayTag)other);
                case TagID.Int64Array: return ArrayEquals<long>(this, (ArrayTag)other);
                case TagID.SingleArray: return ArrayEquals<float>(this, (ArrayTag)other);
                case TagID.DoubleArray: return ArrayEquals<double>(this, (ArrayTag)other);
                case TagID.BooleanArray: return ArrayEquals<bool>(this, (ArrayTag)other);
                case TagID.CharArray: return ArrayEquals<char>(this, (ArrayTag)other);
                case TagID.StringArray: return ArrayEquals<string>(this, (ArrayTag)other);
                case TagID.DateTimeArray: return ArrayEquals<DateTime>(this, (ArrayTag)other);
                case TagID.ObjectArray:
                    ObjectTag[] thisArray = (ObjectTag[])InternalArray;
                    ObjectTag[] otherArray = (ObjectTag[])((ArrayTag)other).InternalArray;

                    if (thisArray.Length != otherArray.Length) return false;
                    for (int i = 0; i < thisArray.Length; i++) {
                        if (!thisArray[i].Equals(otherArray[i])) return false;
                    }

                    return true;
                default: return false;
            }
        }
        private static bool ArrayEquals<T>(ArrayTag left, ArrayTag right) {
            return Enumerable.SequenceEqual((T[])left.InternalArray, (T[])right.InternalArray);
        }
    }
}
