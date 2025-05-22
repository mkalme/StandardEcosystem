using System;

namespace CommonUtilities {
    public interface INamedStreamProviderController {
        IStreamProvider GetStreamProvider(string name);
        void RemoveStreamProvider(string name);

        void RegisterResource(SerializeableResource resource);
    }
}
