using System;
using SimpleBinaryTag;

namespace CommonUtilities {
    public class DateTimeHistoryDeserializer : IObjectDeserializer<DateTimeHistory> {
        public DateTimeHistory Deserialize(Tag tag) {
            DateTime[] datetimeArray = tag;

            return new DateTimeHistory(datetimeArray);
        }
    }
}
