using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleCloud.Common {
    public class ProviderApplication {
        public CredentialsResource CredentialsResource { get; private set; }
        public Credentials Credentials => CredentialsResource.Credentials;

        public INamedStreamProviderController NamedStreamProviderController { get; set; }

        public ProviderApplication(INamedStreamProviderController namedStreamProviderController) {
            NamedStreamProviderController = namedStreamProviderController;

            CredentialsResource = new CredentialsResource("Credentials", NamedStreamProviderController);
            CredentialsResource.Load();

            Credentials.OnContentsChanged += Credentials_OnContentsChanged;
        }

        private void Credentials_OnContentsChanged(object sender, EventArgs e) {
            CredentialsResource.Save();
        }
    }
}
