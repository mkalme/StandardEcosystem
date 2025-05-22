using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class DarkContextMenuStrip : ContextMenuStrip {
        public CustomToolStripRenderer CustomRenderer { get; set; } = new CustomToolStripRenderer();

        public Point CursorWhenOpened { get; private set; }

        public DarkContextMenuStrip() {
            InitializeComponent(this);

            Opening += DarkContextMenuStrip_Opening;
        }
        public DarkContextMenuStrip(IContainer container) : base(container) {
            InitializeComponent(this);

            Opening += DarkContextMenuStrip_Opening;
        }

        private void DarkContextMenuStrip_Opening(object sender, EventArgs e) {
            CursorWhenOpened = Cursor.Position;
        }

        private void InitializeComponent(ToolStripDropDown dropDown) {
            dropDown.BackColor = CustomRenderer.Colors.BackColor;
            dropDown.ForeColor = SystemColors.HighlightText;

            dropDown.Renderer = CustomRenderer;
            dropDown.ItemAdded += ToolStripDropDown_ItemAdded;
        }

        private void ToolStripDropDown_ItemAdded(object sender, ToolStripItemEventArgs e) {
            if (e.Item.GetType() == typeof(ToolStripMenuItem)) {
                InitializeComponent(((ToolStripMenuItem)e.Item).DropDown);
            }
        }
    }
}
