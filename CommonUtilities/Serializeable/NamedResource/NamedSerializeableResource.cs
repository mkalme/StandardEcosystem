using System;

namespace CommonUtilities {
    public abstract class NamedSerializeableResource : SerializeableResource {
        public NamedSerializeableResource(string name, INamedStreamProviderController controller) : base(controller.GetStreamProvider(name)) {
            controller.RegisterResource(this);
        }
    }
}
