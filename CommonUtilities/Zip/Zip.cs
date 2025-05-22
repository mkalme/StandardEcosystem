using System;
using System.Diagnostics;

namespace CommonUtilities {
    public class Zip {
        public string FileName { get; set; } = "7z.exe";

        public ExitCode CallZipExe(string arguments) {
            return CallZipExe(arguments, new Progress<float>());
        }
        public ExitCode CallZipExe(string arguments, IProgress<float> progress) {
            using (Process process = new Process()) {
                process.StartInfo.FileName = FileName;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.OutputDataReceived += (sender, args) => OutputReceived(args, progress);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.PriorityClass = ProcessPriorityClass.High;
                process.WaitForExit();

                return (ExitCode)process.ExitCode;
            }
        }

        private static void OutputReceived(DataReceivedEventArgs args, IProgress<float> progress) {
            try {
                if (string.IsNullOrEmpty(args.Data)) return;

                string parse = args.Data.Trim();
                int index = parse.IndexOf('%');

                int percentage = int.Parse(parse.Substring(0, index));

                progress.Report(percentage / 100F);
            } catch {

            }
        }
    }
}
