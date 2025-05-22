using System;

namespace SimpleBinaryTag.IO {
    public abstract class BinaryWriterBase {
        public BufferWriter BufferWriter { get; set; }

        public BinaryWriterBase(BufferWriter bufferWriter) {
            BufferWriter = bufferWriter;
        }

        protected void WriteBuffer(byte[] buffer) {
            BufferWriter.WriteBuffer(buffer);
        }
    }
}
