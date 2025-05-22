using System;
using System.Drawing;

namespace CustomDialogs {
    public class ProgramInformationPanel : IInformationPanel {
        public virtual string HeaderText { get; set; }
        public virtual Image Icon { get; set; }

        public virtual string ProgramName { get; set; }
        public virtual string ProgramCreated { get; set; }
        public virtual string ProgramLocatedIn { get; set; }
    }
}
