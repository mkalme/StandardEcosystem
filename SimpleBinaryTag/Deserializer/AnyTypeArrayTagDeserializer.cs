using System;

namespace SimpleBinaryTag {
    public class AnyTypeArrayTagDeserializer : ITagDeserializer<AnyTypeArrayTag> {
        public ITagDeserializer<Tag> TagDeserializer { get; set; }

        public AnyTypeArrayTagDeserializer(ITagDeserializer<Tag> tagDeserializer) {
            TagDeserializer = tagDeserializer;
        }

        public AnyTypeArrayTag Deserialize(IReader reader) {
            int length = reader.ReadInt32();

            Tag[] tagArray = new Tag[length];
            for (int i = 0; i < length; i++) {
                tagArray[i] = TagDeserializer.Deserialize(reader);
            }

            return tagArray;
        }
    }
}
