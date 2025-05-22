using System;

namespace SimpleBinaryTag {
    public sealed class ValueTag : Tag {
        public object InternalValue { get; private set; }

        public static implicit operator ValueTag(byte value) => new ValueTag(value);
        public static implicit operator ValueTag(short value) => new ValueTag(value);
        public static implicit operator ValueTag(int value) => new ValueTag(value);
        public static implicit operator ValueTag(long value) => new ValueTag(value);
        public static implicit operator ValueTag(float value) => new ValueTag(value);
        public static implicit operator ValueTag(double value) => new ValueTag(value);
        public static implicit operator ValueTag(bool value) => new ValueTag(value);
        public static implicit operator ValueTag(char value) => new ValueTag(value);
        public static implicit operator ValueTag(string value) => new ValueTag(value);
        public static implicit operator ValueTag(DateTime value) => new ValueTag(value);

        public static implicit operator byte(ValueTag valueTag) => (byte)valueTag.InternalValue;
        public static implicit operator short(ValueTag valueTag) => (short)valueTag.InternalValue;
        public static implicit operator int(ValueTag valueTag) => (int)valueTag.InternalValue;
        public static implicit operator long(ValueTag valueTag) => (long)valueTag.InternalValue;
        public static implicit operator float(ValueTag valueTag) => (float)valueTag.InternalValue;
        public static implicit operator double(ValueTag valueTag) => (double)valueTag.InternalValue;
        public static implicit operator bool(ValueTag valueTag) => (bool)valueTag.InternalValue;
        public static implicit operator char(ValueTag valueTag) => (char)valueTag.InternalValue;
        public static implicit operator string(ValueTag valueTag) => (string)valueTag.InternalValue;
        public static implicit operator DateTime(ValueTag valueTag) => (DateTime)valueTag.InternalValue;

        public ValueTag(byte value) : base(TagID.UnsignedByte) {
            InternalValue = value;
        }
        public ValueTag(short value) : base(TagID.Int16) {
            InternalValue = value;
        }
        public ValueTag(int value) : base(TagID.Int32) {
            InternalValue = value;
        }
        public ValueTag(long value) : base(TagID.Int64) {
            InternalValue = value;
        }
        public ValueTag(float value) : base(TagID.Single) {
            InternalValue = value;
        }
        public ValueTag(double value) : base(TagID.Double) {
            InternalValue = value;
        }
        public ValueTag(bool value) : base(TagID.Boolean) {
            InternalValue = value;
        }
        public ValueTag(char value) : base(TagID.Char) {
            InternalValue = value;
        }
        public ValueTag(string value) : base(TagID.String) {
            InternalValue = value;
        }
        public ValueTag(DateTime value) : base(TagID.DateTime) {
            InternalValue = value;
        }

        public override Tag Clone() {
            switch (ID) {
                case TagID.UnsignedByte: return (byte)InternalValue;
                case TagID.Int16: return (short)InternalValue;
                case TagID.Int32: return (int)InternalValue;
                case TagID.Int64: return (long)InternalValue;
                case TagID.Single: return (float)InternalValue;
                case TagID.Double: return (double)InternalValue;
                case TagID.Boolean: return (bool)InternalValue;
                case TagID.Char: return (char)InternalValue;
                case TagID.String: return (string)InternalValue;
                case TagID.DateTime: return (DateTime)InternalValue;
                default: return null;
            }
        }
        public override bool Equals(Tag other) {
            if (other.ID != ID) return false;

            return InternalValue.Equals(((ValueTag)other).InternalValue);
        }
    }
}
