using System;
using System.Collections.Generic;

namespace CommonUtilities {
    public class ResourceController : IResourceController {
        public IList<SerializeableResource> SerializeableResources { get; set; }

        public ResourceController() { 
            SerializeableResources = new List<SerializeableResource>();
        }

        public void AddResource(SerializeableResource resource) {
            SerializeableResources.Add(resource);
        }
        public void RemoveResource(SerializeableResource resource) {
            SerializeableResources.Remove(resource);
        }
        public void SaveAll() {
            foreach (SerializeableResource resource in SerializeableResources) { 
                resource.Save();
            }
        }
    }
}
