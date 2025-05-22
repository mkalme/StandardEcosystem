using System;
using System.Text;

namespace SimpleBinaryTag.IO {
    public class BinaryWriter : BinaryWriterBase, IWriter {
        public bool BigEndian { get; set; } = true;

        public BinaryWriter(BufferWriter bufferWriter) : base(bufferWriter) { }

        public void WriteUnsignedByte(byte value) {
            WriteBuffer(new byte[] { value });
        }
        public void WriteUnsignedByteArray(byte[] array) {
            WriteBuffer(array);
        }

        public void WriteInt16(short value) {
            byte[] bytes = BitConverter.GetBytes(value);
            
            WriteBuffer(SetEndianness(bytes));
        }
        public void WriteInt16Array(short[] array) {
            byte[] bytes = new byte[array.Length * sizeof(short)];

            for (int i = 0; i < array.Length; i++) {
                byte[] b = SetEndianness(BitConverter.GetBytes(array[i]));
                int index = i * sizeof(short);

                bytes[index] = b[0];
                bytes[index + 1] = b[1];
            }

            WriteBuffer(bytes);
        }

        public void WriteInt32(int value) {
            byte[] bytes = BitConverter.GetBytes(value);

            WriteBuffer(SetEndianness(bytes));
        }
        public void WriteInt32Array(int[] array) {
            byte[] bytes = new byte[array.Length * sizeof(int)];

            for (int i = 0; i < array.Length; i++) {
                byte[] b = SetEndianness(BitConverter.GetBytes(array[i]));
                int index = i * sizeof(int);

                bytes[index] = b[0];
                bytes[index + 1] = b[1];
                bytes[index + 2] = b[2];
                bytes[index + 3] = b[3];
            }

            WriteBuffer(bytes);
        }

        public void WriteInt64(long value) {
            byte[] bytes = BitConverter.GetBytes(value);

            WriteBuffer(SetEndianness(bytes));
        }
        public void WriteInt64Array(long[] array) {
            byte[] bytes = new byte[array.Length * sizeof(long)];

            for (int i = 0; i < array.Length; i++) {
                byte[] b = SetEndianness(BitConverter.GetBytes(array[i]));
                int index = i * sizeof(long);

                bytes[index] = b[0];
                bytes[index + 1] = b[1];
                bytes[index + 2] = b[2];
                bytes[index + 3] = b[3];
                bytes[index + 4] = b[4];
                bytes[index + 5] = b[5];
                bytes[index + 6] = b[6];
                bytes[index + 7] = b[7];
            }

            WriteBuffer(bytes);
        }

        public void WriteSingle(float value) {
            byte[] bytes = BitConverter.GetBytes(value);

            WriteBuffer(SetEndianness(bytes));
        }
        public void WriteSingleArray(float[] array) {
            byte[] bytes = new byte[array.Length * sizeof(float)];

            for (int i = 0; i < array.Length; i++) {
                byte[] b = SetEndianness(BitConverter.GetBytes(array[i]));
                int index = i * sizeof(float);

                bytes[index] = b[0];
                bytes[index + 1] = b[1];
                bytes[index + 2] = b[2];
                bytes[index + 3] = b[3];
            }

            WriteBuffer(bytes);
        }

        public void WriteDouble(double value) {
            byte[] bytes = BitConverter.GetBytes(value);

            WriteBuffer(SetEndianness(bytes));
        }
        public void WriteDoubleArray(double[] array) {
            byte[] bytes = new byte[array.Length * sizeof(double)];

            for (int i = 0; i < array.Length; i++) {
                byte[] b = SetEndianness(BitConverter.GetBytes(array[i]));
                int index = i * sizeof(double);

                bytes[index] = b[0];
                bytes[index + 1] = b[1];
                bytes[index + 2] = b[2];
                bytes[index + 3] = b[3];
                bytes[index + 4] = b[4];
                bytes[index + 5] = b[5];
                bytes[index + 6] = b[6];
                bytes[index + 7] = b[7];
            }

            WriteBuffer(bytes);
        }

        public void WriteBoolean(bool value) {
            WriteBuffer(new byte[] { value ? (byte)1 : (byte)0 });
        }
        public void WriteBooleanArray(bool[] array) {
            byte[] bytes = new byte[array.Length];

            for (int i = 0; i < array.Length; i++) {
                bytes[i] = array[i] ? (byte)1 : (byte)0;
            }

            WriteBuffer(bytes);
        }

        public void WriteChar(char value) {
            byte[] bytes = BitConverter.GetBytes(value);

            WriteBuffer(SetEndianness(bytes));
        }
        public void WriteCharArray(char[] array) {
            byte[] bytes = new byte[array.Length * sizeof(char)];

            for (int i = 0; i < array.Length; i++) {
                byte[] b = SetEndianness(BitConverter.GetBytes(array[i]));
                int index = i * sizeof(char);

                bytes[index] = b[0];
                bytes[index + 1] = b[1];
            }

            WriteBuffer(bytes);
        }

        public void WriteString(string value) {
            byte[] bytes = Encoding.UTF8.GetBytes(value);

            WriteInt32(bytes.Length);
            WriteBuffer(bytes);
        }
        public void WriteStringArray(string[] array) {
            for (int i = 0; i < array.Length; i++) {
                WriteString(array[i]);
            }
        }

        public void WriteDateTime(DateTime dateTime) {
            WriteInt64((dateTime.ToUniversalTime().Ticks - DateTime.UnixEpoch.Ticks) / 10L);
        }
        public void WriteDateTimeArray(DateTime[] array) {
            long[] longArray = new long[array.Length];

            for (int i = 0; i < array.Length; i++) {
                longArray[i] = (array[i].ToUniversalTime().Ticks - DateTime.UnixEpoch.Ticks) / 10L;
            }

            WriteInt64Array(longArray);
        }

        private byte[] SetEndianness(byte[] bytes) {
            if (!BitConverter.IsLittleEndian == BigEndian) return bytes;

            byte[] output = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++) {
                output[i] = bytes[bytes.Length - i - 1];
            }

            return output;
        }
    }
}
