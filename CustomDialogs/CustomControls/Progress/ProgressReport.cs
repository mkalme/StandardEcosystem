using System;

namespace CustomDialogs {
    public class ProgressReport : IProgressReport {
        public float Percentage { get; set; }
        public string Message { get; set; }
        public string ActivityType { get; set; }
    }
}
