using System;

namespace SimpleBinaryTag {
    public class ObjectTagDeserializer : ITagDeserializer<ObjectTag> {
        public ITagDeserializer<Tag> TagDeserializer { get; set; }

        public ObjectTagDeserializer(ITagDeserializer<Tag> tagDeserializer) {
            TagDeserializer = tagDeserializer;
        }

        public ObjectTag Deserialize(IReader reader) {
            int size = reader.ReadInt32();

            ObjectTag output = new ObjectTag(size);
            for (int i = 0; i < size; i++) {
                string name = reader.ReadString();
                Tag tag = TagDeserializer.Deserialize(reader);

                output.Add(name, tag);
            }

            return output;
        }
    }
}
