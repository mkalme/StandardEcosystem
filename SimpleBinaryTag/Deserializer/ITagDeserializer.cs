using System;

namespace SimpleBinaryTag {
    public interface ITagDeserializer<ITag> where ITag : Tag {
        ITag Deserialize(IReader reader);
    }
}
