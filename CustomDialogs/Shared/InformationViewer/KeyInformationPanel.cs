using System;
using System.Collections.Generic;
using System.Drawing;

namespace CustomDialogs {
    public class KeyInformationPanel : IInformationPanel {
        public virtual string HeaderText { get; set; } = "Key";
        public virtual Image Icon { get; set; } = Properties.Resources._64pxKey;

        public virtual string CurrentKeySince { get; set; }
        public virtual IEnumerable<DateTime> KeyHistory { get; set; }
        public virtual Image KeyCellIcon { get; set; }
    }
}
