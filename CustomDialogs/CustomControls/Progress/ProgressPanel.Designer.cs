
namespace CustomDialogs {
    partial class ProgressPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UploadingLabel = new CustomDialogs.DarkLabel();
            this.PercentageLabel = new CustomDialogs.DarkLabel();
            this.MessageLabel = new CustomDialogs.DarkLabel();
            this.ProgressBar = new System.Windows.Forms.Panel();
            this.ProgressContainer = new System.Windows.Forms.Panel();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.MessageContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ProgressBar.SuspendLayout();
            this.GlobalContainer.SuspendLayout();
            this.MessageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // UploadingLabel
            // 
            this.UploadingLabel.AutoSize = false;
            this.UploadingLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UploadingLabel.Location = new System.Drawing.Point(0, 0);
            this.UploadingLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.UploadingLabel.Name = "UploadingLabel";
            this.UploadingLabel.Size = new System.Drawing.Size(451, 15);
            this.UploadingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UploadingLabel.TabIndex = 8;
            this.UploadingLabel.UseMnemonic = false;
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PercentageLabel.Location = new System.Drawing.Point(0, 3);
            this.PercentageLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(23, 15);
            this.PercentageLabel.TabIndex = 7;
            this.PercentageLabel.Text = "0%";
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MessageLabel.Location = new System.Drawing.Point(452, 3);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 15);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.UseMnemonic = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgressBar.Controls.Add(this.ProgressContainer);
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBar.Location = new System.Drawing.Point(3, 32);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(446, 21);
            this.ProgressBar.TabIndex = 5;
            // 
            // ProgressContainer
            // 
            this.ProgressContainer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ProgressContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProgressContainer.Location = new System.Drawing.Point(0, 0);
            this.ProgressContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressContainer.Name = "ProgressContainer";
            this.ProgressContainer.Size = new System.Drawing.Size(0, 19);
            this.ProgressContainer.TabIndex = 0;
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.AutoSize = true;
            this.GlobalContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.MessageContainer, 0, 2);
            this.GlobalContainer.Controls.Add(this.UploadingLabel, 0, 0);
            this.GlobalContainer.Controls.Add(this.ProgressBar, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 3;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(452, 71);
            this.GlobalContainer.TabIndex = 9;
            // 
            // MessageContainer
            // 
            this.MessageContainer.AutoSize = true;
            this.MessageContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MessageContainer.ColumnCount = 2;
            this.MessageContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MessageContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessageContainer.Controls.Add(this.MessageLabel, 1, 0);
            this.MessageContainer.Controls.Add(this.PercentageLabel, 0, 0);
            this.MessageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageContainer.Location = new System.Drawing.Point(0, 53);
            this.MessageContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MessageContainer.Name = "MessageContainer";
            this.MessageContainer.RowCount = 1;
            this.MessageContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessageContainer.Size = new System.Drawing.Size(452, 18);
            this.MessageContainer.TabIndex = 0;
            // 
            // ProgressPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.GlobalContainer);
            this.Name = "ProgressPanel";
            this.Size = new System.Drawing.Size(452, 63);
            this.ProgressBar.ResumeLayout(false);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.MessageContainer.ResumeLayout(false);
            this.MessageContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkLabel UploadingLabel;
        private CustomDialogs.DarkLabel PercentageLabel;
        private CustomDialogs.DarkLabel MessageLabel;
        private System.Windows.Forms.Panel ProgressBar;
        private System.Windows.Forms.Panel ProgressContainer;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel MessageContainer;
    }
}
