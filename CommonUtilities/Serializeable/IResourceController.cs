using System;

namespace CommonUtilities {
    public interface IResourceController {
        void AddResource(SerializeableResource resource);
        void RemoveResource(SerializeableResource resource);
        void SaveAll();
    }
}
