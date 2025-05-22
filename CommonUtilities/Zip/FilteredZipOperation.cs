using System;
using System.Text;
using CommonUtilities;

namespace CommonUtilities {
    public class FilteredZipOperation : ZOperation {
        public string FolderPath { get; set; } = "";
        public string Filter { get; set; } = "*";
        public bool Exclude { get; set; } = false;
        public bool CaseSensitive { get; set; } = false;

        public string OutputArchivePath { get; set; } = "";
        public string Password { get; set; } = "";

        public override string CreateArguments() {
            StringBuilder arguments = new StringBuilder("a -bsp1");

            if (!string.IsNullOrEmpty(Password)) {
                arguments.Append($" \"-p{Password}\" -mhe=on");
            }

            arguments.Append($" \"{OutputArchivePath}\"");

            if (!Exclude) {
                foreach (string filter in Filter.Split("|")) {
                    arguments.Append($" \"{FolderPath}\\{filter}\"");
                }

                if(CaseSensitive) arguments.Append(" -ssc");
            } else {
                arguments.Append($" \"{FolderPath}\\*\"");

                foreach (string filter in Filter.Split("|")) {
                    arguments.Append($" -x!\"{filter}\"");
                }

                if(CaseSensitive) arguments.Append(" -ssc");
            }

            arguments.Append($" -r");

            return arguments.ToString();
        }
    }
}
