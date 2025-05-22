using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleCloud.Common {
    public class CredentialsSerializer : IObjectSerializer<Credentials> {
        public Tag Serialize(Credentials item) {
            return new ObjectTag() {
                { "Credentials", item.CredentialsJsonString },
                { "BucketName", item.BucketName }
            };
        }
    }
}
