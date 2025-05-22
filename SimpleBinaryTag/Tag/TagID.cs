using System;

namespace SimpleBinaryTag {
    public enum TagID : byte {
        UnsignedByte = 1,
        UnsignedByteArray = 2,
        Int16 = 3,
        Int16Array = 4,
        Int32 = 5,
        Int32Array = 6,
        Int64 = 7,
        Int64Array = 8,
        Single = 9,
        SingleArray = 10,
        Double = 11,
        DoubleArray = 12,
        Boolean = 13,
        BooleanArray = 14,
        Char = 15,
        CharArray = 16,
        String = 17,
        StringArray = 18,
        DateTime = 19,
        DateTimeArray = 20,
        Object = 21,
        ObjectArray = 22,
        AnyTypeArray = 23
    }
}
