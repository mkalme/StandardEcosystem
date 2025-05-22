using System;
using System.IO;

namespace CommonUtilities {
    public class MemoryStreamProvider : IStreamProvider {
        public Stream Stream { get; set; }

        public bool CanRead() {
            bool isNull = Stream == null;
            if(isNull) Stream = new MemoryStream();
            
            return !isNull;
        }
        public Stream ProvideInputStream() {
            return Stream;
        }
        public void NotifyFinishedReading() {
            Stream.Close();
        }

        public Stream ProvideOutputStream() {
            Stream = new MemoryStream();
            return Stream;
        }
        public void NotifyFinishedWriting() {
            Stream.Close();
        }
    }
}
