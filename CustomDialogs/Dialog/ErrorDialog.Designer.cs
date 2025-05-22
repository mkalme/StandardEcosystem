
namespace CustomDialogs {
    partial class ErrorDialog {
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
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.OkButton = new CustomDialogs.DarkButton();
            this.InformationContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.RichTextBoxPanel = new System.Windows.Forms.Panel();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.GlobalContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.InformationContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.RichTextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.ButtonPanel, 0, 1);
            this.GlobalContainer.Controls.Add(this.InformationContainer, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(584, 269);
            this.GlobalContainer.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoSize = true;
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtonPanel.Controls.Add(this.OkButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 230);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(584, 39);
            this.ButtonPanel.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OkButton.Location = new System.Drawing.Point(499, 8);
            this.OkButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 24);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // InformationContainer
            // 
            this.InformationContainer.ColumnCount = 2;
            this.InformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InformationContainer.Controls.Add(this.PictureBox, 0, 0);
            this.InformationContainer.Controls.Add(this.RichTextBoxPanel, 1, 0);
            this.InformationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationContainer.Location = new System.Drawing.Point(0, 0);
            this.InformationContainer.Margin = new System.Windows.Forms.Padding(0);
            this.InformationContainer.Name = "InformationContainer";
            this.InformationContainer.RowCount = 1;
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InformationContainer.Size = new System.Drawing.Size(584, 230);
            this.InformationContainer.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(10, 10);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(40, 40);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // RichTextBoxPanel
            // 
            this.RichTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxPanel.Controls.Add(this.RichTextBox);
            this.RichTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxPanel.Location = new System.Drawing.Point(60, 10);
            this.RichTextBoxPanel.Margin = new System.Windows.Forms.Padding(10);
            this.RichTextBoxPanel.Name = "RichTextBoxPanel";
            this.RichTextBoxPanel.Padding = new System.Windows.Forms.Padding(3);
            this.RichTextBoxPanel.Size = new System.Drawing.Size(514, 210);
            this.RichTextBoxPanel.TabIndex = 1;
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RichTextBox.Location = new System.Drawing.Point(3, 3);
            this.RichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(506, 202);
            this.RichTextBox.TabIndex = 1;
            this.RichTextBox.Text = "";
            // 
            // ErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(584, 269);
            this.Controls.Add(this.GlobalContainer);
            this.Name = "ErrorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.ErrorDialog_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.InformationContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.RichTextBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.TableLayoutPanel InformationContainer;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Panel RichTextBoxPanel;
        private DarkButton OkButton;
    }
}