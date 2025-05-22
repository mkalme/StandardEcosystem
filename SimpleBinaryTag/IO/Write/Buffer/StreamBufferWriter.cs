using System;
using System.IO;

namespace SimpleBinaryTag.IO {
    public class StreamBufferWriter : BufferWriter {
        public Stream BaseStream { get; set; }

        public StreamBufferWriter(Stream baseStream) {
            BaseStream = baseStream;
        }

        public override void WriteBuffer(byte[] buffer) {
            BaseStream.Write(buffer, 0, buffer.Length);
        }
    }
}
