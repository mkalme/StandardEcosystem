using System;
using System.IO;

namespace CommonUtilities {
    public interface IStreamProvider {
        bool CanRead();
        Stream ProvideInputStream();
        void NotifyFinishedReading();

        Stream ProvideOutputStream();
        void NotifyFinishedWriting();
    }
}
