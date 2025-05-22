using System;
using System.IO;

namespace CommonUtilities {
    public class NamedStreamProviderController : INamedStreamProviderController {
        public string Directory { get; set; }

        public ReferenceKey Key { get; set; }
        public IResourceController ResourceController { get; set; }

        public NamedStreamProviderController(string directory, ReferenceKey key, IResourceController resourceController) {
            Directory = directory;
            Key = key;
            ResourceController = resourceController;
        }

        public IStreamProvider GetStreamProvider(string name) {
            return new EncryptedStreamProvider(new FileStreamProvider($"{Directory}\\{name}"), Key);
        }
        public void RemoveStreamProvider(string name) {
            string path = $"{Directory}\\{name}";

            if (File.Exists(path)) File.Delete(path);
        }

        public void RegisterResource(SerializeableResource resource) {
            ResourceController.AddResource(resource);
        }
    }
}
