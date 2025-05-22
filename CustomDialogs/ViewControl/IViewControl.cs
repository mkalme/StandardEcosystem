using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public interface IViewControl {
        Control Control { get; }
        void UpdateControl(IView view);
    }
}
