using System;
using System.IO;

namespace SimpleBinaryTag.IO {
    public class StreamBufferProvider : BufferProvider {
        public Stream BaseStream { get; set; }

        public StreamBufferProvider(Stream baseStream) {
            BaseStream = baseStream;
        }

        public override void SetBuffer(int length, out byte[] buffer, out int index) {
            byte[] output = new byte[length];

            BaseStream.Read(output, 0, length);

            buffer = output;
            index = 0;
        }
    }
}
