using System;

namespace SimpleBinaryTag {
    public interface IIdTagDeserializer<ITag> where ITag : Tag {
        ITag Deserialize(IReader reader, TagID id);
    }
}
