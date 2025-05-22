using System;

namespace CustomDialogs {
    public interface IPasswordGenerator {
        bool SetLength { get; }

        string Format { get; }
        string Generate(int length);
    }
}
