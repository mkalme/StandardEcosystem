using System;
using SimpleBinaryTag;

namespace CommonUtilities {
    public interface IObjectDeserializer<TObject> {
        TObject Deserialize(Tag tag);
    }
}
