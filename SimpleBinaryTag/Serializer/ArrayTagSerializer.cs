using System;

namespace SimpleBinaryTag {
    public class ArrayTagSerializer : ITagSerializer<ArrayTag> {
        public ITagSerializer<ObjectTag> ObjectTagSerializer { get; set; }

        public ArrayTagSerializer(ITagSerializer<ObjectTag> objectTagSerializer) {
            ObjectTagSerializer = objectTagSerializer;
        }

        public void Serialize(ArrayTag tag, IWriter writer) {
            writer.WriteInt32(tag.Length);

            switch (tag.ID) {
                case TagID.UnsignedByteArray: writer.WriteUnsignedByteArray(tag); return;
                case TagID.Int16Array: writer.WriteInt16Array(tag); return;
                case TagID.Int32Array: writer.WriteInt32Array(tag); return;
                case TagID.Int64Array: writer.WriteInt64Array(tag); return;
                case TagID.SingleArray: writer.WriteSingleArray(tag); return;
                case TagID.DoubleArray: writer.WriteDoubleArray(tag); return;
                case TagID.BooleanArray: writer.WriteBooleanArray(tag); return;
                case TagID.CharArray: writer.WriteCharArray(tag); return;
                case TagID.StringArray: writer.WriteStringArray(tag); return;
                case TagID.DateTimeArray: writer.WriteDateTimeArray(tag); return;
                case TagID.ObjectArray:
                    ObjectTag[] objectArray = tag;
                    for (int i = 0; i < objectArray.Length; i++) {
                        ObjectTagSerializer.Serialize(objectArray[i], writer);
                    }
                    break;
            }
        }
    }
}
