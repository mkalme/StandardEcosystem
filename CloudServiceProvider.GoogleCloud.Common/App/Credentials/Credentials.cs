using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleCloud.Common {
    public class Credentials : ObservableResource {
        public string CredentialsJsonString {
            get => _credentialsJsonString;
            set {
                if (_credentialsJsonString == value) return;

                _credentialsJsonString = value;
                RaiseOnContentsChanged();
                OnCredentialsJsonStringChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private string _credentialsJsonString;

        public string BucketName {
            get => _bucketName;
            set {
                if (_bucketName == value) return;

                _bucketName = value;
                RaiseOnContentsChanged();
            }
        }
        private string _bucketName;

        public event EventHandler OnCredentialsJsonStringChanged;

        public Credentials() {
            CredentialsJsonString = string.Empty;
            BucketName = string.Empty;
        }
    }
}
