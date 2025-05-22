using System;
using System.Text;

namespace SimpleBinaryTag.IO {
    public class BinaryReader : BinaryReaderBase, IReader {
        public bool BigEndian { get; set; } = true;

        public BinaryReader(BufferProvider bufferReader) : base(bufferReader) { }

        public byte ReadUnsignedByte() {
            SetBuffer(1);
            return Buffer[Index];
        }
        public byte[] ReadUnsignedByteArray(int length) {
            SetBuffer(length);

            byte[] output = new byte[length];
            System.Buffer.BlockCopy(Buffer, Index, output, 0, length);

            return output;
        }

        public short ReadInt16() {
            SetBuffer(sizeof(short));

            return BitConverter.ToInt16(CreateBigEndianArray(sizeof(short)));
        }
        public short[] ReadInt16Array(int length) {
            int bufferLength = length * sizeof(short);

            SetBuffer(bufferLength);

            short[] output = new short[length];
            for (int i = 0; i < length; i++) {
                output[i] = BitConverter.ToInt16(CreateBigEndianArray(sizeof(short)));
                Index += sizeof(short);
            }

            return output;
        }

        public int ReadInt32() {
            SetBuffer(sizeof(int));
            return BitConverter.ToInt32(CreateBigEndianArray(sizeof(int)));
        }
        public int[] ReadInt32Array(int length) {
            int bufferLength = length * sizeof(int);

            SetBuffer(bufferLength);

            int[] output = new int[length];
            for (int i = 0; i < length; i++) {
                output[i] = BitConverter.ToInt32(CreateBigEndianArray(sizeof(int)));
                Index += sizeof(int);
            }

            return output;
        }

        public long ReadInt64() {
            SetBuffer(sizeof(long));

            return BitConverter.ToInt64(CreateBigEndianArray(sizeof(long)));
        }
        public long[] ReadInt64Array(int length) {
            SetBuffer(length * sizeof(long));

            long[] output = new long[length];
            for (int i = 0; i < length; i++) {
                output[i] = BitConverter.ToInt64(CreateBigEndianArray(sizeof(long)));

                Index += sizeof(long);
            }

            return output;
        }

        public float ReadSingle() {
            SetBuffer(sizeof(float));

            return BitConverter.ToSingle(CreateBigEndianArray(sizeof(float)));
        }
        public float[] ReadSingleArray(int length) {
            SetBuffer(length * sizeof(float));

            float[] output = new float[length];
            for (int i = 0; i < length; i++) {
                output[i] = BitConverter.ToSingle(CreateBigEndianArray(sizeof(float)));
                Index += sizeof(float);
            }

            return output;
        }

        public double ReadDouble() {
            SetBuffer(sizeof(double));

            return BitConverter.ToDouble(CreateBigEndianArray(sizeof(double)));
        }
        public double[] ReadDoubleArray(int length) {
            SetBuffer(length * sizeof(double));

            double[] output = new double[length];
            for (int i = 0; i < length; i++) {
                output[i] = BitConverter.ToDouble(CreateBigEndianArray(sizeof(double)));

                Index += sizeof(double);
            }

            return output;
        }

        public bool ReadBoolean() {
            SetBuffer(1);
            return Buffer[Index] == 1;
        }
        public bool[] ReadBooleanArray(int length) {
            SetBuffer(length);

            bool[] output = new bool[length];
            for (int i = 0; i < length; i++) {
                output[i] = Buffer[Index + i] == 1;
            }

            return output;
        }

        public char ReadChar() {
            SetBuffer(sizeof(char));
            return BitConverter.ToChar(CreateBigEndianArray(sizeof(char)));
        }
        public char[] ReadCharArray(int length) {
            int bufferLength = length * sizeof(char);

            SetBuffer(bufferLength);

            char[] output = new char[length];
            for (int i = 0; i < length; i++) {
                output[i] = BitConverter.ToChar(CreateBigEndianArray(sizeof(char)));
                Index += sizeof(char);
            }

            return output;
        }

        public string ReadString() {
            int size = ReadInt32();
            SetBuffer(size);

            return Encoding.UTF8.GetString(Buffer, Index, size);
        }
        public string[] ReadStringArray(int length) {
            string[] output = new string[length];

            for (int i = 0; i < length; i++) {
                output[i] = ReadString();
            }

            return output;
        }

        public DateTime ReadDateTime() {
            return DateTime.UnixEpoch.AddTicks(ReadInt64() * 10L).ToLocalTime();
        }
        public DateTime[] ReadDateTimeArray(int length) {
            long[] longArray = ReadInt64Array(length);

            DateTime[] output = new DateTime[length];
            for (int i = 0; i < length; i++) {
                output[i] = DateTime.UnixEpoch.AddTicks(longArray[i] * 10L).ToLocalTime();
            }

            return output;
        }

        private byte[] CreateBigEndianArray(int length) {
            byte[] output = new byte[length];

            if (!BitConverter.IsLittleEndian == BigEndian) {
                for (int i = 0; i < length; i++) {
                    output[i] = Buffer[Index + i];
                }
            } else {
                for (int i = 0; i < length; i++) {
                    output[i] = Buffer[Index + length - i - 1];
                }
            }

            return output;
        }
    }
}
