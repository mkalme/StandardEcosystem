using System;
using SimpleBinaryTag;

namespace CommonUtilities {
    public interface IObjectSerializer<TObject> {
        Tag Serialize(TObject item);
    }
}
