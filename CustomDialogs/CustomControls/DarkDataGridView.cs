using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs {
    public class DarkDataGridView : DataGridView {
        public DataGridViewSelection Selection { get; private set; }

        public Color CellBackColor {
            get => _cellBackColor;
            set {
                DefaultCellStyle.BackColor = value;
                ColumnHeadersDefaultCellStyle.BackColor = value;
                ColumnHeadersDefaultCellStyle.SelectionBackColor = value;

                _cellBackColor = value;
            }
        }
        private Color _cellBackColor = Color.FromArgb(45, 45, 45);

        public Color CellForeColor {
            get => _cellForeColor;
            set {
                DefaultCellStyle.ForeColor = value;
                DefaultCellStyle.SelectionForeColor = value;
                ColumnHeadersDefaultCellStyle.ForeColor = value;
                ColumnHeadersDefaultCellStyle.SelectionForeColor = value;

                _cellForeColor = value;
            }
        }
        private Color _cellForeColor = SystemColors.HighlightText;

        public Color CellGridColor {
            get => _cellGridColor;
            set {
                GridColor = value;

                _cellGridColor = value;
            }
        }
        private Color _cellGridColor = Color.FromArgb(100, 100, 100);

        public DarkDataGridView() {
            BackgroundColor = CellBackColor;
            GridColor = CellGridColor;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.None;

            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RowHeadersVisible = false;
            EnableHeadersVisualStyles = false;

            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = true;
            AllowUserToResizeColumns = true;
            AllowUserToResizeRows = false;

            ReadOnly = true;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DefaultCellStyle.BackColor = CellBackColor;
            DefaultCellStyle.ForeColor = _cellForeColor;
            DefaultCellStyle.SelectionForeColor = _cellForeColor;
            DefaultCellStyle.Padding = new Padding(3, 0, 0, 0);

            ColumnHeadersDefaultCellStyle.BackColor = CellBackColor;
            ColumnHeadersDefaultCellStyle.ForeColor = _cellForeColor;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = CellBackColor;
            ColumnHeadersDefaultCellStyle.SelectionForeColor = _cellForeColor;
            ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 4, 0, 4);

            RowTemplate.Height = 23;

            Selection = new DataGridViewSelection(this);
            this.SetDoubleBuffering();
        }
    }
}
