using System;

namespace SimpleBinaryTag {
    public interface IWriter {
        void WriteUnsignedByte(byte value);
        void WriteUnsignedByteArray(byte[] array);

        void WriteInt16(short value);
        void WriteInt16Array(short[] array);

        void WriteInt32(int value);
        void WriteInt32Array(int[] array);

        void WriteInt64(long value);
        void WriteInt64Array(long[] array);

        void WriteSingle(float value);
        void WriteSingleArray(float[] array);

        void WriteDouble(double value);
        void WriteDoubleArray(double[] array);

        void WriteBoolean(bool value);
        void WriteBooleanArray(bool[] array);
        
        void WriteChar(char value);
        void WriteCharArray(char[] array);

        void WriteString(string value);
        void WriteStringArray(string[] array);

        void WriteDateTime(DateTime dateTime);
        void WriteDateTimeArray(DateTime[] array);
    }
}
