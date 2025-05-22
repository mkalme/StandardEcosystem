using System;

namespace SimpleBinaryTag {
    public class ValueTagSerializer : ITagSerializer<ValueTag> {
        public void Serialize(ValueTag tag, IWriter writer) {
            switch (tag.ID) {
                case TagID.UnsignedByte: writer.WriteUnsignedByte(tag); return;
                case TagID.Int16: writer.WriteInt16(tag); return;
                case TagID.Int32: writer.WriteInt32(tag); return;
                case TagID.Int64: writer.WriteInt64(tag); return;
                case TagID.Single: writer.WriteSingle(tag); return;
                case TagID.Double: writer.WriteDouble(tag); return;
                case TagID.Boolean: writer.WriteBoolean(tag); return;
                case TagID.Char: writer.WriteChar(tag); return;
                case TagID.String: writer.WriteString(tag); return;
                case TagID.DateTime: writer.WriteDateTime(tag); return;
            }
        }
    }
}
