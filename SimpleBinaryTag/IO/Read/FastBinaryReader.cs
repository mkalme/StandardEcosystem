using System;
using System.Text;
using SimpleBinaryTag.IO;

namespace SimpleBinaryTag {
    public class FastBinaryReader : BinaryReaderBase, IReader {
        public bool BigEndian { get; set; } = true;

        public FastBinaryReader(BufferProvider bufferReader) : base(bufferReader) { }

        public byte ReadUnsignedByte() {
            SetBuffer(1);

            return Buffer[Index];
        }
        public unsafe byte[] ReadUnsignedByteArray(int length) {
            SetBuffer(length);

            byte[] output = new byte[length];
            if (length == 0) return output;

            fixed (byte* o = output) {
                MemoryCopy(o, length);
            }

            return output;
        }

        public unsafe short ReadInt16() {
            SetBuffer(sizeof(short));

            fixed (byte* p = &Buffer[Index]) {
                if (!BitConverter.IsLittleEndian == BigEndian) return *(short*)p;

                return (short)(*(p + 1) | (*p << 8));
            }
        }
        public unsafe short[] ReadInt16Array(int length) {
            short[] output = new short[length];
            if (length == 0) return output;

            int bufferSize = length * sizeof(short);
            SetBuffer(bufferSize);

            fixed (byte* p = &Buffer[Index])
            fixed (short* v = output) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    System.Buffer.MemoryCopy(p, v, bufferSize, bufferSize);
                } else {
                    for (int i = 0; i < output.Length; i++) {
                        int off = i * 2;
                        byte* intPtr = (byte*)(v + i);

                        intPtr[0] = *(p + off + 1);
                        intPtr[1] = *(p + off);
                    }
                }
            }

            return output;
        }

        public unsafe int ReadInt32() {
            SetBuffer(sizeof(int));

            fixed (byte* p = &Buffer[Index]) {
                if (!BitConverter.IsLittleEndian == BigEndian) return *(int*)p;

                return *(p + 3) | (*(p + 2) << 8) | (*(p + 1) << 16) | (*p << 24);
            }
        }
        public unsafe int[] ReadInt32Array(int length) {
            int[] output = new int[length];
            if (length == 0) return output;

            int bufferSize = length * sizeof(int);
            SetBuffer(bufferSize);

            fixed (byte* p = &Buffer[Index])
            fixed (int* v = output) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    System.Buffer.MemoryCopy(p, v, bufferSize, bufferSize);
                } else {
                    for (int i = 0; i < output.Length; i++) {
                        int off = i * 4;
                        byte* intPtr = (byte*)(v + i);

                        intPtr[0] = *(p + off + 3);
                        intPtr[1] = *(p + off + 2);
                        intPtr[2] = *(p + off + 1);
                        intPtr[3] = *(p + off);
                    }
                }
            }

            return output;
        }

        public unsafe long ReadInt64() {
            SetBuffer(sizeof(long));

            fixed (byte* p = &Buffer[Index]) {
                if (!BitConverter.IsLittleEndian == BigEndian) return *(long*)p;

                uint l = (uint)(*(p + 7) | (*(p + 6) << 8) | (*(p + 5) << 16) | (*(p + 4) << 24));
                uint h = (uint)(*(p + 3) | (*(p + 2) << 8) | (*(p + 1) << 16) | (*p << 24));

                return (long)(l | (ulong)h << 32);
            }
        }
        public unsafe long[] ReadInt64Array(int length) {
            long[] output = new long[length];
            if (length == 0) return output;

            int bufferSize = length * sizeof(long);
            SetBuffer(bufferSize);

            fixed (byte* b = &Buffer[Index])
            fixed (long* l = output) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    System.Buffer.MemoryCopy(b, l, bufferSize, bufferSize);
                } else {
                    for (int i = 0; i < output.Length; i++) {
                        int off = i * 8;
                        byte* longPtr = (byte*)(l + i);

                        longPtr[0] = *(b + off + 7);
                        longPtr[1] = *(b + off + 6);
                        longPtr[2] = *(b + off + 5);
                        longPtr[3] = *(b + off + 4);
                        longPtr[4] = *(b + off + 3);
                        longPtr[5] = *(b + off + 2);
                        longPtr[6] = *(b + off + 1);
                        longPtr[7] = *(b + off);
                    }
                }
            }

            return output;
        }

        public unsafe float ReadSingle() {
            SetBuffer(sizeof(float));

            fixed (byte* p = &Buffer[Index]) {
                if (!BitConverter.IsLittleEndian == BigEndian) return *(float*)p;

                int value = *(p + 3) | (*(p + 2) << 8) | (*(p + 1) << 16) | (*p << 24);
                return *(float*)&value;
            }
        }
        public unsafe float[] ReadSingleArray(int length) {
            float[] output = new float[length];
            if (length == 0) return output;

            int bufferSize = length * sizeof(float);
            SetBuffer(bufferSize);

            fixed (byte* p = &Buffer[Index])
            fixed (float* v = output) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    System.Buffer.MemoryCopy(p, v, bufferSize, bufferSize);
                } else {
                    for (int i = 0; i < output.Length; i++) {
                        int off = i * 4;
                        byte* intPtr = (byte*)(v + i);

                        intPtr[0] = *(p + off + 3);
                        intPtr[1] = *(p + off + 2);
                        intPtr[2] = *(p + off + 1);
                        intPtr[3] = *(p + off);
                    }
                }
            }

            return output;
        }

        public unsafe double ReadDouble() {
            SetBuffer(sizeof(double));

            fixed (byte* p = &Buffer[Index]) {
                if (!BitConverter.IsLittleEndian == BigEndian) return *(double*)p;

                uint l = (uint)(*(p + 7) | (*(p + 6) << 8) | (*(p + 5) << 16) | (*(p + 4) << 24));
                uint h = (uint)(*(p + 3) | (*(p + 2) << 8) | (*(p + 1) << 16) | (*p << 24));

                long value = (long)(l | (ulong)h << 32);
                return *(double*)&value;
            }
        }
        public unsafe double[] ReadDoubleArray(int length) {
            double[] output = new double[length];
            if (length == 0) return output;

            int bufferSize = length * sizeof(double);
            SetBuffer(bufferSize);

            fixed (byte* b = &Buffer[Index])
            fixed (double* l = output) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    System.Buffer.MemoryCopy(b, l, bufferSize, bufferSize);
                } else {
                    for (int i = 0; i < output.Length; i++) {
                        int off = i * 8;
                        byte* longPtr = (byte*)(l + i);

                        longPtr[0] = *(b + off + 7);
                        longPtr[1] = *(b + off + 6);
                        longPtr[2] = *(b + off + 5);
                        longPtr[3] = *(b + off + 4);
                        longPtr[4] = *(b + off + 3);
                        longPtr[5] = *(b + off + 2);
                        longPtr[6] = *(b + off + 1);
                        longPtr[7] = *(b + off);
                    }
                }
            }

            return output;
        }

        public bool ReadBoolean() {
            SetBuffer(1);

            return Buffer[Index] == 1;
        }
        public unsafe bool[] ReadBooleanArray(int length) {
            SetBuffer(length);

            bool[] output = new bool[length];
            if (length == 0) return output;

            fixed (bool* o = output) {
                MemoryCopy(o, length);
            }

            return output;
        }

        public unsafe char ReadChar() {
            SetBuffer(sizeof(short));

            fixed (byte* p = &Buffer[Index]) {
                if (!BitConverter.IsLittleEndian == BigEndian) return *(char*)p;

                return (char)(*(p + 1) | (*p << 8));
            }
        }
        public unsafe char[] ReadCharArray(int length) {
            char[] output = new char[length];
            if (length == 0) return output;

            int bufferSize = length * sizeof(char);
            SetBuffer(bufferSize);

            fixed (byte* p = &Buffer[Index])
            fixed (char* v = output) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    System.Buffer.MemoryCopy(p, v, bufferSize, bufferSize);
                } else {
                    for (int i = 0; i < output.Length; i++) {
                        int off = i * 2;
                        byte* intPtr = (byte*)(v + i);

                        intPtr[0] = *(p + off + 1);
                        intPtr[1] = *(p + off);
                    }
                }
            }

            return output;
        }

        public unsafe string ReadString() {
            int length = ReadInt32();
            SetBuffer(length);

            fixed (byte* b = &Buffer[Index]) {
                return Encoding.UTF8.GetString(b, length);
            }
        }
        public string[] ReadStringArray(int length) {
            string[] output = new string[length];

            for (long i = 0; i < length; i++) {
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

        private unsafe void MemoryCopy(void* output, long sizeInBytes) {
            fixed (byte* p = &Buffer[Index]) {
                System.Buffer.MemoryCopy(p, output, sizeInBytes, sizeInBytes);
            }
        }
    }
}
