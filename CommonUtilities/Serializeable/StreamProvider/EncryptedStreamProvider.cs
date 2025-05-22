using System;
using System.IO;

namespace CommonUtilities {
    public class EncryptedStreamProvider : IStreamProvider {
        public IStreamProvider StreamProvider { get; set; }
        public ReferenceKey Key { get; set; }
        
        public EncryptedStreamProvider(IStreamProvider streamProvider, ReferenceKey key) {
            StreamProvider = streamProvider;
            Key = key;
        }

        public bool CanRead() {
            return StreamProvider.CanRead();
        }
        public Stream ProvideInputStream() {
            Stream inputStream = StreamProvider.ProvideInputStream();

            MemoryStream decryptedStream = new MemoryStream();
            AesEncryption.Decrypt(inputStream, decryptedStream, Key);

            decryptedStream.Position = 0;
            return decryptedStream;
        }
        public void NotifyFinishedReading() {
            StreamProvider.NotifyFinishedReading();
        }

        private Stream _originalOutputStream;
        private Stream _directOutputStream;

        public Stream ProvideOutputStream() {
            _originalOutputStream = StreamProvider.ProvideOutputStream();

            _directOutputStream = new MemoryStream();
            return _directOutputStream;
        }
        public void NotifyFinishedWriting() {
            _directOutputStream.Position = 0;
            AesEncryption.Encrypt(_directOutputStream, _originalOutputStream, Key);
            
            StreamProvider.NotifyFinishedWriting();
            _directOutputStream.Dispose();
        }
    }
}
