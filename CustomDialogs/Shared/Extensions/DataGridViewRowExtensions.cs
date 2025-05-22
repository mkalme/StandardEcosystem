using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public static class DataGridViewRowExtensions {
        public static void DisplayImage(this DataGridViewRow row, DataGridViewColumn column, Image image, int padding = 0) {
            ((TextAndImageCell)row.Cells[column.Index]).Image = image;

            row.Cells[column.Index].Style.Padding = new Padding(padding, 0, 0, 0);
        }
    }
}
