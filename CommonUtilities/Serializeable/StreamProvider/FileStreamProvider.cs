using System;
using System.IO;

namespace CommonUtilities {
    public class FileStreamProvider : IStreamProvider {
        public string FilePath { get; private set; }
        public Stream FileStream { get; private set; }

        public FileStreamProvider(string filePath) {
            FilePath = filePath;

            if (!Directory.Exists(Path.GetDirectoryName(FilePath))) Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
        }

        public bool CanRead() {
            return File.Exists(FilePath);
        }
        public Stream ProvideInputStream() {
            FileStream = File.OpenRead(FilePath);
            return FileStream;
        }
        public void NotifyFinishedReading() {
            FileStream.Dispose();
        }

        public Stream ProvideOutputStream() {
            FileStream = File.Create(FilePath);
            return FileStream;
        }
        public void NotifyFinishedWriting() {
            FileStream.Flush();
            FileStream.Dispose();
        }
    }
}
