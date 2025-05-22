using System;
using System.Collections.Generic;

namespace CommonUtilities {
    public sealed class DateTimeHistory {
        public ObservableList<DateTime> Dates { get; private set; }

        public event EventHandler OnContentsChanged;

        public DateTimeHistory(IEnumerable<DateTime> dates) {
            Dates = new ObservableList<DateTime>(new List<DateTime>(dates));

            Dates.OnItemsAdd += (sender, items) => {
                CallContentsChanged();
            };
            Dates.OnItemsRemove += (sender, items) => {
                CallContentsChanged();
            };
        }

        private void CallContentsChanged() { 
            OnContentsChanged?.Invoke(this, EventArgs.Empty);
        }

        public DateTimeHistory Clone() {
            return new DateTimeHistory(Dates);
        }
        public bool Equals(DateTimeHistory datetimeHistory) {
            if (Dates.Count != datetimeHistory.Dates.Count) return false;

            for (int i = 0; i < Dates.Count; i++) {
                if (Dates[i] != datetimeHistory.Dates[i]) return false;
            }

            return true;
        }
    }
}
