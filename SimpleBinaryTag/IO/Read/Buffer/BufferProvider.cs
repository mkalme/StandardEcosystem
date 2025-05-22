using System;

namespace SimpleBinaryTag.IO {
    public abstract class BufferProvider {
        public abstract void SetBuffer(int length, out byte[] buffer, out int index);
    }
}
