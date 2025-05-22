using System;

namespace CommonUtilities {
    public enum ExitCode {
        NoError = 0,
        Warning = 1,
        FatalError = 2,
        CommandLineError = 7,
        NotEnoughMemoryForOperation = 8,
        UserStoppedTheProcess = 255
    }
}
