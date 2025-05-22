using System;
using System.IO;

namespace CommonUtilities {
    public abstract class SerializeableResource {
        public IStreamProvider StreamProvider { get; set; }

        public SerializeableResource(IStreamProvider streamProvider) { 
            StreamProvider = streamProvider;
        }

        public virtual void Load() {
            if (StreamProvider.CanRead()) {
                SetState(StreamProvider.ProvideInputStream());
                StreamProvider.NotifyFinishedReading();
            } else {
                SetDefaultState();
                Save();
            }
        }
        public virtual void Save() {
            Serialize(StreamProvider.ProvideOutputStream());
            StreamProvider.NotifyFinishedWriting();
        }

        protected abstract void SetDefaultState();
        protected abstract void SetState(Stream inputStream);
        protected abstract void Serialize(Stream outputStream);
    }
}
