using System;

namespace SimpleBinaryTag {
    public class AnyTypeArrayTagSerializer : ITagSerializer<AnyTypeArrayTag> {
        public ITagSerializer<Tag> TagSerializer { get; set; }

        public AnyTypeArrayTagSerializer(ITagSerializer<Tag> tagSerializer) {
            TagSerializer = tagSerializer;
        }

        public void Serialize(AnyTypeArrayTag tag, IWriter writer) {
            writer.WriteInt32(tag.Length);

            for (int i = 0; i < tag.Length; i++) {
                TagSerializer.Serialize(tag.InternalArray[i], writer);
            }
        }
    }
}
