using System;
using System.Windows.Forms;

namespace CustomDialogs {
    public partial class HeaderToolBarControl : UserControl, IViewControl {
        public ViewController ViewController { get; set; }
        public Func<object, INode> NodeCreator { get; set; }
        public Action RefreshView { get; set; }

        public Control Control => this;

        public HeaderToolBarControl() {
            InitializeComponent();

            PathPanel.SetDoubleBuffering();
            PathPanel.ButtonClick += PathPanel_ButtonClick;
        }

        //Update
        public void UpdateControl(IView view) {
            PathPanel.Load(NodeCreator(view.ViewNode.Node));

            bool canGoBack = view.ViewNode.Parent != null;
            PrevButton.BackgroundImage = canGoBack ? Properties.Resources._512pxLeftArrow : Properties.Resources._512pxLeftArrowDark;
            PrevButton.Enabled = canGoBack;

            bool canGoForwards = ViewController.Index < ViewController.Views.Count - 1;
            ForwardButton.BackgroundImage = canGoForwards ? Properties.Resources._512pxRightArrow : Properties.Resources._512pxRightArrowDark;
            ForwardButton.Enabled = canGoForwards;
        }
        private void PathPanel_ButtonClick(object sender, EventArgs e) {
            ViewController.OpenParent(((NodePanel)sender).Node.Node);
        }

        //Header buttons
        private void PrevButton_Click(object sender, EventArgs e) {
            ViewController.Prev();
        }
        private void ForwardButton_Click(object sender, EventArgs e) {
            ViewController.Next();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            RefreshView();
        }
    }
}
