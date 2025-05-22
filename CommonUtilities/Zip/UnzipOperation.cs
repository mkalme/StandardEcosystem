using System;

namespace CommonUtilities {
    public class UnzipOperation : ZOperation {
        public string ArchivePath { get; set; }
        public string OutputDirectory { get; set; }
        public string Password { get; set; }

        public override string CreateArguments() {
            return $"x -bsp1 \"{ArchivePath}\" \"-o{OutputDirectory}\" {(string.IsNullOrEmpty(Password) ? "" : $" \"-p{Password}\"")}";
        }
    }
}
