using System;

namespace CustomDialogs {
    public interface IProgressReport {
        public float Percentage { get; }
        public string Message { get; }
        public string ActivityType { get; }
    }
}
