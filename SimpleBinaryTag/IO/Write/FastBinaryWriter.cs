using System;
using System.Text;
using SimpleBinaryTag.IO;

namespace SimpleBinaryTag {
    public class FastBinaryWriter : BinaryWriterBase, IWriter {
        public bool BigEndian { get; set; } = true;

        public FastBinaryWriter(BufferWriter bufferWriter) : base(bufferWriter) {}

        public void WriteUnsignedByte(byte value) {
            WriteBuffer(new byte[] { value });
        }
        public void WriteUnsignedByteArray(byte[] array) {
            WriteBuffer(array);
        }

        public void WriteInt16(short value) {
            if (!BitConverter.IsLittleEndian == BigEndian) {
                WriteBuffer(new byte[] { (byte)(value & 255), (byte)(value >> 8) });
            } else {
                WriteBuffer(new byte[] { (byte)(value >> 8), (byte)(value & 255) });
            }
        }
        public unsafe void WriteInt16Array(short[] array) {
            byte[] output = new byte[array.Length * sizeof(short)];

            fixed (byte* p = output)
            fixed (short* v = array) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    Buffer.MemoryCopy(v, p, array.Length * sizeof(short), array.Length * sizeof(short));
                } else {
                    for (int i = 0; i < array.Length; i++) {
                        int off = i * 2;
                        byte* intPtr = (byte*)(v + i);

                        p[off] = intPtr[1];
                        p[off + 1] = intPtr[0];
                    }
                }
            }

            WriteBuffer(output);
        }

        public void WriteInt32(int value) {
            if (!BitConverter.IsLittleEndian == BigEndian) {
                WriteBuffer(new byte[] { (byte)(value >> 24), (byte)(value >> 16), (byte)(value >> 8), (byte)(value & 255) });
            } else {
                WriteBuffer(new byte[] { (byte)(value >> 24), (byte)(value >> 16), (byte)(value >> 8), (byte)(value & 255) });
            }
        }
        public unsafe void WriteInt32Array(int[] array) {
            byte[] output = new byte[array.Length * sizeof(int)];

            fixed (byte* p = output)
            fixed (int* v = array) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    Buffer.MemoryCopy(v, p, array.Length * sizeof(int), array.Length * sizeof(int));
                } else {
                    for (int i = 0; i < array.Length; i++) {
                        int off = i * 4;
                        byte* intPtr = (byte*)(v + i);

                        p[off] = intPtr[3];
                        p[off + 1] = intPtr[2];
                        p[off + 2] = intPtr[1];
                        p[off + 3] = intPtr[0];
                    }
                }
            }

            WriteBuffer(output);
        }

        public unsafe void WriteInt64(long value) {
            byte[] output = new byte[sizeof(long)];

            fixed (byte* p = output) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    *(long*)p = value;
                } else {
                    byte* longPtr = (byte*)&value;

                    for (int i = 0; i < 8; i++) {
                        *(p + i) = *(longPtr + 7 - i);
                    }
                }
            }

            WriteBuffer(output);
        }
        public unsafe void WriteInt64Array(long[] array) {
            byte[] output = new byte[array.Length * sizeof(long)];

            fixed (byte* p = output)
            fixed (long* l = array) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    Buffer.MemoryCopy(l, p, array.Length * sizeof(long), array.Length * sizeof(long));
                } else {
                    for (int i = 0; i < array.Length; i++) {
                        int off = i * 8;
                        byte* longPtr = (byte*)(l + i);

                        p[off] = *(longPtr + 7);
                        p[off + 1] = *(longPtr + 6);
                        p[off + 2] = *(longPtr + 5);
                        p[off + 3] = *(longPtr + 4);
                        p[off + 4] = *(longPtr + 3);
                        p[off + 5] = *(longPtr + 2);
                        p[off + 6] = *(longPtr + 1);
                        p[off + 7] = *longPtr;
                    }
                }
            }

            WriteBuffer(output);
        }

        public unsafe void WriteSingle(float value) {
            byte[] buffer = new byte[sizeof(float)];

            fixed (byte* p = buffer) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    *(float*)p = value;
                } else {
                    byte* f = (byte*)&value;

                    for (int i = 0; i < 4; i++) {
                        *(p + i) = *(f + 3 - i);
                    }
                }
            }

            WriteBuffer(buffer);
        }
        public unsafe void WriteSingleArray(float[] array) {
            byte[] output = new byte[array.Length * sizeof(float)];

            fixed (byte* p = output)
            fixed (float* v = array) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    Buffer.MemoryCopy(v, p, array.Length * sizeof(float), array.Length * sizeof(float));
                } else {
                    for (int i = 0; i < array.Length; i++) {
                        int off = i * 4;
                        byte* intPtr = (byte*)(v + i);

                        for (int j = 0; j < 4; j++) {
                            *(p + i * 4 + j) = *(intPtr + 3 - j);
                        }
                    }
                }
            }

            WriteBuffer(output);
        }

        public unsafe void WriteDouble(double value) {
            byte[] buffer = new byte[sizeof(double)];

            fixed (byte* p = buffer) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    *(double*)p = value;
                } else {
                    byte* d = (byte*)&value;

                    for (int i = 0; i < 8; i++) {
                        *(p + i) = *(d + 7 - i);
                    }
                }
            }

            WriteBuffer(buffer);
        }
        public unsafe void WriteDoubleArray(double[] array) {
            byte[] output = new byte[array.Length * sizeof(double)];

            fixed (byte* p = output)
            fixed (double* v = array) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    Buffer.MemoryCopy(v, p, array.Length * sizeof(double), array.Length * sizeof(double));
                } else {
                    for (int i = 0; i < array.Length; i++) {
                        int off = i * 4;
                        byte* intPtr = (byte*)(v + i);

                        for (int j = 0; j < 8; j++) {
                            *(p + i * 8 + j) = *(intPtr + 7 - j);
                        }
                    }
                }
            }

            WriteBuffer(output);
        }

        public void WriteBoolean(bool value) {
            WriteUnsignedByte(value ? (byte)1 : (byte)0);
        }
        public unsafe void WriteBooleanArray(bool[] array) {
            fixed (void* source = array) {
                WriteBuffer(MemoryCopy(source, array.Length));
            }
        }

        public void WriteChar(char value) {
            WriteInt16((short)value);
        }
        public unsafe void WriteCharArray(char[] array) {
            byte[] output = new byte[array.Length * sizeof(char)];

            fixed (byte* p = output)
            fixed (char* v = array) {
                if (!BitConverter.IsLittleEndian == BigEndian) {
                    Buffer.MemoryCopy(v, p, array.Length * sizeof(char), array.Length * sizeof(char));
                } else {
                    for (int i = 0; i < array.Length; i++) {
                        int off = i * 2;
                        byte* intPtr = (byte*)(v + i);

                        p[off] = intPtr[1];
                        p[off + 1] = intPtr[0];
                    }
                }
            }

            WriteBuffer(output);
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

        private static unsafe byte[] MemoryCopy(void* source, long sizeInBytes) {
            byte[] output = new byte[sizeInBytes];

            fixed (byte* o = output) {
                Buffer.MemoryCopy(source, o, output.Length, output.Length);
            }

            return output;
        }
    }
}
