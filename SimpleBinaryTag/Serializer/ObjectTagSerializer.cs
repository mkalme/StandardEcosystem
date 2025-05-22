using System;
using System.Collections.Generic;

namespace SimpleBinaryTag {
    public class ObjectTagSerializer : ITagSerializer<ObjectTag> {
        public ITagSerializer<Tag> TagSerializer { get; set; }

        public ObjectTagSerializer(ITagSerializer<Tag> tagSerializer) {
            TagSerializer = tagSerializer;
        }

        public void Serialize(ObjectTag tag, IWriter writer) {
            writer.WriteInt32(tag.Count);

            foreach (KeyValuePair<string, Tag> child in tag) {
                writer.WriteString(child.Key);
                TagSerializer.Serialize(child.Value, writer);
            }
        }
    }
}
