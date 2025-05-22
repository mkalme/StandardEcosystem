using System;

namespace SimpleBinaryTag {
    public class TagDeserializer : ITagDeserializer<Tag> {
        public IIdTagDeserializer<ValueTag> ValueTagDeserializer { get; set; }
        public IIdTagDeserializer<ArrayTag> ArrayTagDeserializer { get; set; }
        public ITagDeserializer<AnyTypeArrayTag> AnyTypeArrayTagDeserializer { get; set; }
        public ITagDeserializer<ObjectTag> ObjectTagDeserializer { get; set; }

        public TagDeserializer() {
            ValueTagDeserializer = new ValueTagDeserializer();
            ObjectTagDeserializer = new ObjectTagDeserializer(this);
            ArrayTagDeserializer = new ArrayTagDeserializer(ObjectTagDeserializer);
            AnyTypeArrayTagDeserializer = new AnyTypeArrayTagDeserializer(this);
        }

        public Tag Deserialize(IReader reader) {
            TagID id = (TagID)reader.ReadUnsignedByte();

            switch (id) {
                case TagID.UnsignedByte:
                case TagID.Int16:
                case TagID.Int32:
                case TagID.Int64:
                case TagID.Single:
                case TagID.Double:
                case TagID.Boolean:
                case TagID.Char:
                case TagID.String:
                case TagID.DateTime:
                    return ValueTagDeserializer.Deserialize(reader, id);
                case TagID.UnsignedByteArray:
                case TagID.Int16Array:
                case TagID.Int32Array:
                case TagID.Int64Array:
                case TagID.SingleArray:
                case TagID.DoubleArray:
                case TagID.BooleanArray:
                case TagID.CharArray:
                case TagID.StringArray:
                case TagID.DateTimeArray:
                case TagID.ObjectArray:
                    return ArrayTagDeserializer.Deserialize(reader, id);
                case TagID.Object:
                    return ObjectTagDeserializer.Deserialize(reader);
                case TagID.AnyTypeArray:
                    return AnyTypeArrayTagDeserializer.Deserialize(reader);
                default: return null;
            }
        }
    }
}
