using System;

namespace SimpleBinaryTag {
    public interface IReader {
        byte ReadUnsignedByte();
        byte[] ReadUnsignedByteArray(int length);

        short ReadInt16();
        short[] ReadInt16Array(int length);

        int ReadInt32();
        int[] ReadInt32Array(int length);

        long ReadInt64();
        long[] ReadInt64Array(int length);

        float ReadSingle();
        float[] ReadSingleArray(int length);

        double ReadDouble();
        double[] ReadDoubleArray(int length);

        bool ReadBoolean();
        bool[] ReadBooleanArray(int length);

        char ReadChar();
        char[] ReadCharArray(int length);

        string ReadString();
        string[] ReadStringArray(int length);

        DateTime ReadDateTime();
        DateTime[] ReadDateTimeArray(int length);
    }
}
