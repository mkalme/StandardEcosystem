using System;

namespace SimpleBinaryTag {
    public class ValueTagDeserializer : IIdTagDeserializer<ValueTag> {
        public ValueTag Deserialize(IReader reader, TagID id) {
            switch (id) {
                case TagID.UnsignedByte: return reader.ReadUnsignedByte();
                case TagID.Int16: return reader.ReadInt16();
                case TagID.Int32: return reader.ReadInt32();
                case TagID.Int64: return reader.ReadInt64();
                case TagID.Single: return reader.ReadSingle();
                case TagID.Double: return reader.ReadDouble();
                case TagID.Boolean: return reader.ReadBoolean();
                case TagID.Char: return reader.ReadChar();
                case TagID.String: return reader.ReadString();
                case TagID.DateTime: return reader.ReadDateTime();
                default: return null;
            }
        }
    }
}
