
namespace CustomDialogs {
    partial class PasswordInputDialog {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordInputDialog));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MessageLabel = new CustomDialogs.DarkLabel();
            this.DoneButton = new CustomDialogs.DarkButton();
            this.CopyButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TextBox = new CustomDialogs.DarkTextBox();
            this.CharactersLabel = new CustomDialogs.DarkLabel();
            this.CharactersContainer = new System.Windows.Forms.TableLayoutPanel();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.KeyVisibleCheckBox = new CustomDialogs.DarkCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.CharactersContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::CustomDialogs.Properties.Resources._64pxKey;
            this.PictureBox.Location = new System.Drawing.Point(12, 26);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(27, 27);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MessageLabel.Location = new System.Drawing.Point(8, 9);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(53, 15);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Message";
            this.MessageLabel.UseMnemonic = false;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 85);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 24);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CopyButton.Image = global::CustomDialogs.Properties.Resources._16pxCopyLongText;
            this.CopyButton.Location = new System.Drawing.Point(355, 86);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(23, 23);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PasteButton.Image = global::CustomDialogs.Properties.Resources._16pxPaste;
            this.PasteButton.Location = new System.Drawing.Point(384, 86);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(23, 23);
            this.PasteButton.TabIndex = 4;
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox.Location = new System.Drawing.Point(45, 27);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.TextBox.PasswordChar = '●';
            this.TextBox.ReadOnly = false;
            this.TextBox.Size = new System.Drawing.Size(362, 27);
            this.TextBox.TabIndex = 5;
            this.TextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox.XOffset = 0;
            this.TextBox.YOffset = -2;
            this.TextBox.InputChanged += new System.EventHandler(this.TextBox_InputChanged);
            // 
            // CharactersLabel
            // 
            this.CharactersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CharactersLabel.AutoSize = true;
            this.CharactersLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CharactersLabel.Location = new System.Drawing.Point(107, 0);
            this.CharactersLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CharactersLabel.Name = "CharactersLabel";
            this.CharactersLabel.Size = new System.Drawing.Size(70, 15);
            this.CharactersLabel.TabIndex = 6;
            this.CharactersLabel.Text = "0 characters";
            // 
            // CharactersContainer
            // 
            this.CharactersContainer.ColumnCount = 1;
            this.CharactersContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CharactersContainer.Controls.Add(this.CharactersLabel, 0, 0);
            this.CharactersContainer.Location = new System.Drawing.Point(233, 57);
            this.CharactersContainer.Name = "CharactersContainer";
            this.CharactersContainer.RowCount = 1;
            this.CharactersContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CharactersContainer.Size = new System.Drawing.Size(177, 17);
            this.CharactersContainer.TabIndex = 7;
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.FormatLabel.Location = new System.Drawing.Point(346, 11);
            this.FormatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(62, 12);
            this.FormatLabel.TabIndex = 8;
            this.FormatLabel.Text = "ASCII Format";
            // 
            // KeyVisibleCheckBox
            // 
            this.KeyVisibleCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.KeyVisibleCheckBox.BoxBackColor = System.Drawing.Color.Transparent;
            this.KeyVisibleCheckBox.BoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.KeyVisibleCheckBox.BoxHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KeyVisibleCheckBox.BoxMouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.KeyVisibleCheckBox.FlatAppearance.BorderSize = 0;
            this.KeyVisibleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyVisibleCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyVisibleCheckBox.Location = new System.Drawing.Point(44, 57);
            this.KeyVisibleCheckBox.Name = "KeyVisibleCheckBox";
            this.KeyVisibleCheckBox.Size = new System.Drawing.Size(141, 15);
            this.KeyVisibleCheckBox.TabIndex = 9;
            this.KeyVisibleCheckBox.Text = "Key visible";
            this.KeyVisibleCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KeyVisibleCheckBox.UseVisualStyleBackColor = true;
            this.KeyVisibleCheckBox.CheckedChanged += new System.EventHandler(this.KeyVisibleCheckBox_CheckedChanged);
            // 
            // PasswordInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(418, 122);
            this.Controls.Add(this.KeyVisibleCheckBox);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.CharactersContainer);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input key";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.CharactersContainer.ResumeLayout(false);
            this.CharactersContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private DarkLabel MessageLabel;
        private DarkButton DoneButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private DarkTextBox TextBox;
        private DarkLabel CharactersLabel;
        private System.Windows.Forms.TableLayoutPanel CharactersContainer;
        private System.Windows.Forms.Label FormatLabel;
        private DarkCheckBox KeyVisibleCheckBox;
    }
}