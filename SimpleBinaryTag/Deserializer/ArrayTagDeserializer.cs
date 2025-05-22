using System;

namespace SimpleBinaryTag {
    public class ArrayTagDeserializer : IIdTagDeserializer<ArrayTag> {
        public ITagDeserializer<ObjectTag> ObjectTagDeserializer { get; set; }

        public ArrayTagDeserializer(ITagDeserializer<ObjectTag> objectTagDeserializer) {
            ObjectTagDeserializer = objectTagDeserializer;
        }

        public ArrayTag Deserialize(IReader reader, TagID id) {
            int length = reader.ReadInt32();

            switch (id) {
                case TagID.UnsignedByteArray: return reader.ReadUnsignedByteArray(length);
                case TagID.Int16Array: return reader.ReadInt16Array(length);
                case TagID.Int32Array: return reader.ReadInt32Array(length);
                case TagID.Int64Array: return reader.ReadInt64Array(length);
                case TagID.SingleArray: return reader.ReadSingleArray(length);
                case TagID.DoubleArray: return reader.ReadDoubleArray(length);
                case TagID.BooleanArray: return reader.ReadBooleanArray(length);
                case TagID.CharArray: return reader.ReadCharArray(length);
                case TagID.StringArray: return reader.ReadStringArray(length);
                case TagID.DateTimeArray: return reader.ReadDateTimeArray(length);
                case TagID.ObjectArray:
                    ObjectTag[] objectTagArray = new ObjectTag[length];
                    for (int i = 0; i < length; i++) {
                        objectTagArray[i] = ObjectTagDeserializer.Deserialize(reader);
                    }

                    return objectTagArray;
                default: return null;
            }
        }
    }
}
