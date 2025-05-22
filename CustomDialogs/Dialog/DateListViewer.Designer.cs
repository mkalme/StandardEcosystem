
namespace CustomDialogs {
    partial class DateListViewer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BottomContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new CustomDialogs.DarkButton();
            this.EntriesPanel = new System.Windows.Forms.Panel();
            this.EntriesLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EntriesCountLabel = new CustomDialogs.DarkLabel();
            this.GridView = new CustomDialogs.DarkDataGridView();
            this.DateColumn = new CustomDialogs.TextAndImageColumn();
            this.WhenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlobalContainer.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.EntriesPanel.SuspendLayout();
            this.EntriesLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BottomContainer, 0, 1);
            this.GlobalContainer.Controls.Add(this.GridView, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(10, 10);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(524, 268);
            this.GlobalContainer.TabIndex = 0;
            // 
            // BottomContainer
            // 
            this.BottomContainer.AutoSize = true;
            this.BottomContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomContainer.ColumnCount = 2;
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.Controls.Add(this.CloseButton, 0, 0);
            this.BottomContainer.Controls.Add(this.EntriesPanel, 1, 0);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(0, 233);
            this.BottomContainer.Margin = new System.Windows.Forms.Padding(0);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.RowCount = 1;
            this.BottomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.Size = new System.Drawing.Size(524, 35);
            this.BottomContainer.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(0, 10);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 25);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EntriesPanel
            // 
            this.EntriesPanel.AutoSize = true;
            this.EntriesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EntriesPanel.Controls.Add(this.EntriesLayoutPanel);
            this.EntriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntriesPanel.Location = new System.Drawing.Point(75, 0);
            this.EntriesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EntriesPanel.Name = "EntriesPanel";
            this.EntriesPanel.Size = new System.Drawing.Size(449, 35);
            this.EntriesPanel.TabIndex = 1;
            // 
            // EntriesLayoutPanel
            // 
            this.EntriesLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntriesLayoutPanel.AutoSize = true;
            this.EntriesLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EntriesLayoutPanel.ColumnCount = 1;
            this.EntriesLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EntriesLayoutPanel.Controls.Add(this.EntriesCountLabel, 0, 0);
            this.EntriesLayoutPanel.Location = new System.Drawing.Point(407, 1);
            this.EntriesLayoutPanel.Name = "EntriesLayoutPanel";
            this.EntriesLayoutPanel.RowCount = 1;
            this.EntriesLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EntriesLayoutPanel.Size = new System.Drawing.Size(45, 20);
            this.EntriesLayoutPanel.TabIndex = 0;
            // 
            // EntriesCountLabel
            // 
            this.EntriesCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntriesCountLabel.AutoSize = true;
            this.EntriesCountLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EntriesCountLabel.Location = new System.Drawing.Point(0, 5);
            this.EntriesCountLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.EntriesCountLabel.Name = "EntriesCountLabel";
            this.EntriesCountLabel.Size = new System.Drawing.Size(45, 15);
            this.EntriesCountLabel.TabIndex = 1;
            this.EntriesCountLabel.Text = "Entries:";
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.GridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.WhenCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Margin = new System.Windows.Forms.Padding(0);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(524, 233);
            this.GridView.TabIndex = 3;
            // 
            // DateColumn
            // 
            this.DateColumn.AlignmentToRight = false;
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateColumn.HeaderText = "Update date";
            this.DateColumn.Image = null;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // WhenCol
            // 
            this.WhenCol.HeaderText = "When";
            this.WhenCol.Name = "WhenCol";
            this.WhenCol.ReadOnly = true;
            // 
            // DateListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(544, 288);
            this.Controls.Add(this.GlobalContainer);
            this.Name = "DateListViewer";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update history";
            this.Load += new System.EventHandler(this.UpdateHistoryViewer_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BottomContainer.ResumeLayout(false);
            this.BottomContainer.PerformLayout();
            this.EntriesPanel.ResumeLayout(false);
            this.EntriesPanel.PerformLayout();
            this.EntriesLayoutPanel.ResumeLayout(false);
            this.EntriesLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.TableLayoutPanel BottomContainer;
        private CustomDialogs.DarkLabel EntriesCountLabel;
        private System.Windows.Forms.Panel EntriesPanel;
        private System.Windows.Forms.TableLayoutPanel EntriesLayoutPanel;
        private DarkDataGridView GridView;
        private TextAndImageColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhenCol;
    }
}