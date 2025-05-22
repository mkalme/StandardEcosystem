using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleCloud.Common {
    public class CredentialsDeserializer : IObjectDeserializer<Credentials> {
        public Credentials Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new Credentials() { 
                CredentialsJsonString = obj["Credentials"],
                BucketName = obj["BucketName"]
            };
        }
    }
}
