using System;
using System.IO;
using SimpleBinaryTag.IO;

namespace SimpleBinaryTag {
    public abstract class Tag : IEquatable<Tag> {
        public TagID ID { get; }

        public static implicit operator Tag(byte value) => new ValueTag(value);
        public static implicit operator Tag(byte[] array) => new ArrayTag(array);
        public static implicit operator Tag(short value) => new ValueTag(value);
        public static implicit operator Tag(short[] array) => new ArrayTag(array);
        public static implicit operator Tag(int value) => new ValueTag(value);
        public static implicit operator Tag(int[] array) => new ArrayTag(array);
        public static implicit operator Tag(long value) => new ValueTag(value);
        public static implicit operator Tag(long[] array) => new ArrayTag(array);
        public static implicit operator Tag(float value) => new ValueTag(value);
        public static implicit operator Tag(float[] array) => new ArrayTag(array);
        public static implicit operator Tag(double value) => new ValueTag(value);
        public static implicit operator Tag(double[] array) => new ArrayTag(array);
        public static implicit operator Tag(bool value) => new ValueTag(value);
        public static implicit operator Tag(bool[] array) => new ArrayTag(array);
        public static implicit operator Tag(char value) => new ValueTag(value);
        public static implicit operator Tag(char[] array) => new ArrayTag(array);
        public static implicit operator Tag(string value) => new ValueTag(value);
        public static implicit operator Tag(string[] array) => new ArrayTag(array);
        public static implicit operator Tag(DateTime value) => new ValueTag(value);
        public static implicit operator Tag(DateTime[] array) => new ArrayTag(array);
        public static implicit operator Tag(ObjectTag[] array) => new ArrayTag(array);
        public static implicit operator Tag(Tag[] array) => new AnyTypeArrayTag(array);

        public static implicit operator byte(Tag tag) => (ValueTag)tag;
        public static implicit operator byte[](Tag tag) => (ArrayTag)tag;
        public static implicit operator short(Tag tag) => (ValueTag)tag;
        public static implicit operator short[](Tag tag) => (ArrayTag)tag;
        public static implicit operator int(Tag tag) => (ValueTag)tag;
        public static implicit operator int[](Tag tag) => (ArrayTag)tag;
        public static implicit operator long(Tag tag) => (ValueTag)tag;
        public static implicit operator long[](Tag tag) => (ArrayTag)tag;
        public static implicit operator float(Tag tag) => (ValueTag)tag;
        public static implicit operator float[](Tag tag) => (ArrayTag)tag;
        public static implicit operator double(Tag tag) => (ValueTag)tag;
        public static implicit operator double[](Tag tag) => (ArrayTag)tag;
        public static implicit operator bool(Tag tag) => (ValueTag)tag;
        public static implicit operator bool[](Tag tag) => (ArrayTag)tag;
        public static implicit operator char(Tag tag) => (ValueTag)tag;
        public static implicit operator char[](Tag tag) => (ArrayTag)tag;
        public static implicit operator string(Tag tag) => (ValueTag)tag;
        public static implicit operator string[](Tag tag) => (ArrayTag)tag;
        public static implicit operator DateTime(Tag tag) => (ValueTag)tag;
        public static implicit operator DateTime[](Tag tag) => (ArrayTag)tag;
        public static implicit operator ObjectTag[](Tag tag) => (ArrayTag)tag;
        public static implicit operator Tag[](Tag tag) => (AnyTypeArrayTag)tag;

        internal Tag(TagID id) {
            ID = id;
        }

        public static Tag FromBytes(byte[] bytes, int index = 0) {
            IO.BinaryReader reader = new IO.BinaryReader(new SimpleBufferProvider(bytes, index));
            return FromReader(reader);
        }
        public static Tag FromStream(Stream inputStream) {
            IO.BinaryReader reader = new IO.BinaryReader(new StreamBufferProvider(inputStream));
            return FromReader(reader);
        }
        public static Tag FromReader(IReader reader) {
            return new TagDeserializer().Deserialize(reader);
        }

        public byte[] ToBytes() {
            using (MemoryStream outputStream = new MemoryStream()) {
                WriteToStream(outputStream);
                return outputStream.ToArray();
            }
        }
        public void WriteToStream(Stream outputStream) {
            IO.BinaryWriter writer = new IO.BinaryWriter(new StreamBufferWriter(outputStream));
            new TagSerializer().Serialize(this, writer);
        }

        public abstract Tag Clone();
        public abstract bool Equals(Tag other);
    }
}
