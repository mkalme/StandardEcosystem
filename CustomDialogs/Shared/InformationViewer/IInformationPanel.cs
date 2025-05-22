using System;
using System.Drawing;

namespace CustomDialogs {
    public interface IInformationPanel {
        public string HeaderText { get; }
        Image Icon { get; }
    }
}
