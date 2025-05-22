using System;

namespace SimpleBinaryTag {
    public class TagSerializer : ITagSerializer<Tag> {
        public ITagSerializer<ValueTag> ValueTagSerializer { get; set; }
        public ITagSerializer<ArrayTag> ArrayTagSerializer { get; set; }
        public ITagSerializer<AnyTypeArrayTag> AnyTypeArrayTagSerializer { get; set; }
        public ITagSerializer<ObjectTag> ObjectTagSerializer { get; set; }

        public TagSerializer() {
            ValueTagSerializer = new ValueTagSerializer();
            ObjectTagSerializer = new ObjectTagSerializer(this);
            ArrayTagSerializer = new ArrayTagSerializer(ObjectTagSerializer);
            AnyTypeArrayTagSerializer = new AnyTypeArrayTagSerializer(this);
        }

        public void Serialize(Tag tag, IWriter writer) {
            writer.WriteUnsignedByte((byte)tag.ID);

            switch (tag.ID) {
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
                    ValueTagSerializer.Serialize(tag as ValueTag, writer);
                    break;
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
                    ArrayTagSerializer.Serialize(tag as ArrayTag, writer);
                    break;
                case TagID.Object:
                    ObjectTagSerializer.Serialize(tag as ObjectTag, writer);
                    break;
                case TagID.AnyTypeArray:
                    AnyTypeArrayTagSerializer.Serialize(tag as AnyTypeArrayTag, writer);
                    break;
            }
        }
    }
}
