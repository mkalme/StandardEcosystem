using System;

namespace CustomDialogs {
    public static class TimeSpanExtensions {
        private static (double, string)[] _timeNames = new (double, string)[] {
            (TimeSpan.FromDays(365).TotalSeconds, "year"),
            (TimeSpan.FromDays(30).TotalSeconds, "month"),
            (TimeSpan.FromDays(7).TotalSeconds, "week"),
            (TimeSpan.FromDays(1).TotalSeconds, "day"),
            (3600, "hour"),
            (60, "minute"),
            (1, "second")
        };

        public static string ToRelativeTimeString(this TimeSpan span) {
            long seconds = (long)span.TotalSeconds;
            if (seconds < 5) return "Just now";

            long n = 0;
            string name = "";

            foreach ((double t, string tn) in _timeNames) {
                if (seconds >= (long)t) {
                    n = (long)(seconds / t);
                    name = tn;

                    break;
                }
            }
            if (n > 1) name = $"{name}s";

            return $"{n} {name} ago";
        }
    }
}
