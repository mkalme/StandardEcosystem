using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class ViewControl : UserControl {
        public ViewController ViewController { get; private set; }
        public IViewControl Control { get; private set; }

        public event EventHandler BeginUpdate;
        public event EventHandler Updated;

        public ViewControl() {
            InitializeComponent();
        }

        public void Initialize(ViewController controller, IViewControl viewControl) {
            ViewController = controller;
            ViewController.Update += (sender, e) => UpdateView();

            Control = viewControl;
            Controls.Add(viewControl.Control);
        }
        public void UpdateView() {
            Invoke(new Action(() => {
                BeginUpdate?.Invoke(this, EventArgs.Empty);

                Control.UpdateControl(ViewController.CurrentView);

                Updated?.Invoke(this, EventArgs.Empty);
            }));
        }
    }
}
