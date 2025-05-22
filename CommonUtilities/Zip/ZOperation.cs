using System;

namespace CommonUtilities {
    public abstract class ZOperation {
        public virtual IProgress<float> Progress { get; set; }

        public virtual ExitCode Execute(Zip zip) {
            return zip.CallZipExe(CreateArguments(), Progress != null ? Progress : new Progress<float>());
        }
        public abstract string CreateArguments();
    }
}
