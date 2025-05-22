namespace CloudServiceProvider.GoogleCloud.Common {
    partial class CredentialsEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredentialsEditor));
            this.BrowseLabel = new System.Windows.Forms.Label();
            this.BucketNameTextBox = new CustomDialogs.DarkTextBox();
            this.BucketNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.RichTetxBoxContainer = new System.Windows.Forms.Panel();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.RichTetxBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseLabel
            // 
            this.BrowseLabel.AutoSize = true;
            this.BrowseLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseLabel.Location = new System.Drawing.Point(10, 12);
            this.BrowseLabel.Name = "BrowseLabel";
            this.BrowseLabel.Size = new System.Drawing.Size(91, 15);
            this.BrowseLabel.TabIndex = 0;
            this.BrowseLabel.Text = "Credentials json";
            // 
            // BucketNameTextBox
            // 
            this.BucketNameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BucketNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BucketNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BucketNameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameTextBox.Location = new System.Drawing.Point(14, 189);
            this.BucketNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BucketNameTextBox.Name = "BucketNameTextBox";
            this.BucketNameTextBox.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.BucketNameTextBox.PasswordChar = '\0';
            this.BucketNameTextBox.ReadOnly = false;
            this.BucketNameTextBox.Size = new System.Drawing.Size(451, 23);
            this.BucketNameTextBox.TabIndex = 3;
            this.BucketNameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BucketNameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameTextBox.XOffset = 0;
            this.BucketNameTextBox.YOffset = 0;
            // 
            // BucketNameLabel
            // 
            this.BucketNameLabel.AutoSize = true;
            this.BucketNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BucketNameLabel.Location = new System.Drawing.Point(10, 171);
            this.BucketNameLabel.Name = "BucketNameLabel";
            this.BucketNameLabel.Size = new System.Drawing.Size(76, 15);
            this.BucketNameLabel.TabIndex = 4;
            this.BucketNameLabel.Text = "Bucket name";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(14, 253);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(102, 253);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RichTetxBoxContainer
            // 
            this.RichTetxBoxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RichTetxBoxContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTetxBoxContainer.Controls.Add(this.RichTextBox);
            this.RichTetxBoxContainer.Location = new System.Drawing.Point(14, 30);
            this.RichTetxBoxContainer.Name = "RichTetxBoxContainer";
            this.RichTetxBoxContainer.Padding = new System.Windows.Forms.Padding(3);
            this.RichTetxBoxContainer.Size = new System.Drawing.Size(451, 124);
            this.RichTetxBoxContainer.TabIndex = 7;
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RichTextBox.Location = new System.Drawing.Point(3, 3);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(443, 116);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            // 
            // CredentialsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(474, 293);
            this.Controls.Add(this.RichTetxBoxContainer);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BucketNameLabel);
            this.Controls.Add(this.BucketNameTextBox);
            this.Controls.Add(this.BrowseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CredentialsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credentials & bucket";
            this.RichTetxBoxContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BrowseLabel;
        private CustomDialogs.DarkTextBox BucketNameTextBox;
        private System.Windows.Forms.Label BucketNameLabel;
        private CustomDialogs.DarkButton SaveButton;
        private CustomDialogs.DarkButton CancelButton;
        private System.Windows.Forms.Panel RichTetxBoxContainer;
        private System.Windows.Forms.RichTextBox RichTextBox;
    }
}