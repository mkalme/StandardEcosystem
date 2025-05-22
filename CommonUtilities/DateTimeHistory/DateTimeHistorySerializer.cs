using System;
using System.Linq;
using SimpleBinaryTag;

namespace CommonUtilities {
    public class DateTimeHistorySerializer : IObjectSerializer<DateTimeHistory> {
        public Tag Serialize(DateTimeHistory item) {
            return item.Dates.ToArray();
        }
    }
}
