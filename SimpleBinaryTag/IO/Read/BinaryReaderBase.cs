using System;

namespace SimpleBinaryTag.IO {
    public abstract class BinaryReaderBase {
        public BufferProvider BufferProvider { get; set; }

        public byte[] Buffer { get; protected set; }
        public int Index { get; protected set; }

        public BinaryReaderBase(BufferProvider bufferProvider) {
            BufferProvider = bufferProvider;
        }

        protected void SetBuffer(int length) {
            BufferProvider.SetBuffer(length, out byte[] buffer, out int index);

            Buffer = buffer;
            Index = index;
        }
    }
}
