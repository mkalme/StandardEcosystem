using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtilities {
    public class ZipOperation : ZOperation {
        public IEnumerable<string> Folders { get; set; } = new string[0];
        public IEnumerable<string> Files { get; set; } = new string[0];

        public string OutputArchivePath { get; set; }
        public string Password { get; set; }

        public override string CreateArguments() {
            StringBuilder arguments = new StringBuilder("a -bsp1");

            if (!string.IsNullOrEmpty(Password)) {
                arguments.Append($" \"-p{Password}\" -mhe=on");
            }

            arguments.Append($" \"{OutputArchivePath}\"");

            foreach (var source in Folders) {
                arguments.Append($" \"{source}\\\"");
            }

            foreach (var source in Files) {
                arguments.Append($" \"{source}\"");
            }

            return arguments.ToString();
        }
    }
}
