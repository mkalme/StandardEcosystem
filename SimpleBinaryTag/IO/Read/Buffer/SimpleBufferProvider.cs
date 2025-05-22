using System;

namespace SimpleBinaryTag.IO {
    public class SimpleBufferProvider : BufferProvider {
        public byte[] SimpleBuffer { get; set; }
        public int Index { get; set; }

        public SimpleBufferProvider(byte[] buffer, int index = 0) {
            SimpleBuffer = buffer;
            Index = index;
        }

        public override void SetBuffer(int length, out byte[] buffer, out int index) {
            buffer = SimpleBuffer;
            index = Index;

            Index += length;
        }
    }
}
