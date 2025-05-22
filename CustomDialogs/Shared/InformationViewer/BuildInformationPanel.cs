using System;
using System.Drawing;

namespace CustomDialogs {
    public class BuildInformationPanel : IInformationPanel {
        public virtual string HeaderText { get; set; } = "Build";
        public virtual Image Icon { get; set; }

        public virtual string Name { get; set; }
        public virtual string Version { get; set; }
        public virtual string VersionReleased { get; set; }
    }
}
