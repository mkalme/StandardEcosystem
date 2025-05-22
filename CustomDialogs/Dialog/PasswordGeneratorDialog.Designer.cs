
namespace CustomDialogs {
    partial class PasswordGeneratorDialog {
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MessageLabel = new CustomDialogs.DarkLabel();
            this.TextBox = new CustomDialogs.DarkTextBox();
            this.PasteButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DoneButton = new CustomDialogs.DarkButton();
            this.GeneratePasswordButton = new CustomDialogs.DarkButton();
            this.CharactersLabel = new CustomDialogs.DarkLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PasswordVisibleCheckBox = new CustomDialogs.DarkCheckBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.FormatContainer = new System.Windows.Forms.TableLayoutPanel();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GeneratePasswordContainer = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.FormatContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.GeneratePasswordContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
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
            this.MessageLabel.Size = new System.Drawing.Size(132, 15);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Enter the new password";
            this.MessageLabel.UseMnemonic = false;
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
            this.TextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.TextBox.PasswordChar = '\0';
            this.TextBox.ReadOnly = false;
            this.TextBox.Size = new System.Drawing.Size(362, 27);
            this.TextBox.TabIndex = 2;
            this.TextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox.XOffset = 0;
            this.TextBox.YOffset = 0;
            this.TextBox.InputChanged += new System.EventHandler(this.TextBox_InputChanged);
            // 
            // PasteButton
            // 
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PasteButton.Image = global::CustomDialogs.Properties.Resources._16pxPaste;
            this.PasteButton.Location = new System.Drawing.Point(384, 116);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(23, 23);
            this.PasteButton.TabIndex = 8;
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CopyButton.Image = global::CustomDialogs.Properties.Resources._16pxCopyLongText;
            this.CopyButton.Location = new System.Drawing.Point(355, 116);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(23, 23);
            this.CopyButton.TabIndex = 7;
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 115);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 24);
            this.DoneButton.TabIndex = 9;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.GeneratePasswordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.GeneratePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneratePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneratePasswordButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GeneratePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GeneratePasswordButton.Location = new System.Drawing.Point(0, 0);
            this.GeneratePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(164, 24);
            this.GeneratePasswordButton.TabIndex = 10;
            this.GeneratePasswordButton.Text = "Generate random password";
            this.GeneratePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneratePasswordButton.UseVisualStyleBackColor = false;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // CharactersLabel
            // 
            this.CharactersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CharactersLabel.AutoSize = true;
            this.CharactersLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CharactersLabel.Location = new System.Drawing.Point(295, 0);
            this.CharactersLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CharactersLabel.Name = "CharactersLabel";
            this.CharactersLabel.Size = new System.Drawing.Size(70, 15);
            this.CharactersLabel.TabIndex = 6;
            this.CharactersLabel.Text = "0 characters";
            // 
            // PasswordVisibleCheckBox
            // 
            this.PasswordVisibleCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PasswordVisibleCheckBox.BoxBackColor = System.Drawing.Color.Transparent;
            this.PasswordVisibleCheckBox.BoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.PasswordVisibleCheckBox.BoxHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordVisibleCheckBox.BoxMouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PasswordVisibleCheckBox.Checked = true;
            this.PasswordVisibleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PasswordVisibleCheckBox.FlatAppearance.BorderSize = 0;
            this.PasswordVisibleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordVisibleCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordVisibleCheckBox.Location = new System.Drawing.Point(44, 85);
            this.PasswordVisibleCheckBox.Name = "PasswordVisibleCheckBox";
            this.PasswordVisibleCheckBox.Size = new System.Drawing.Size(141, 15);
            this.PasswordVisibleCheckBox.TabIndex = 12;
            this.PasswordVisibleCheckBox.Text = "Password visible";
            this.PasswordVisibleCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PasswordVisibleCheckBox.UseVisualStyleBackColor = true;
            this.PasswordVisibleCheckBox.CheckedChanged += new System.EventHandler(this.KeyVisibleCheckBox_CheckedChanged);
            // 
            // FormatLabel
            // 
            this.FormatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.FormatLabel.Location = new System.Drawing.Point(100, 5);
            this.FormatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(36, 12);
            this.FormatLabel.TabIndex = 13;
            this.FormatLabel.Text = "Format";
            this.FormatLabel.UseMnemonic = false;
            // 
            // FormatContainer
            // 
            this.FormatContainer.ColumnCount = 1;
            this.FormatContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FormatContainer.Controls.Add(this.FormatLabel, 0, 0);
            this.FormatContainer.Location = new System.Drawing.Point(272, 6);
            this.FormatContainer.Name = "FormatContainer";
            this.FormatContainer.RowCount = 1;
            this.FormatContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FormatContainer.Size = new System.Drawing.Size(136, 17);
            this.FormatContainer.TabIndex = 14;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NumericUpDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NumericUpDown.Location = new System.Drawing.Point(176, 0);
            this.NumericUpDown.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(45, 23);
            this.NumericUpDown.TabIndex = 15;
            // 
            // GeneratePasswordContainer
            // 
            this.GeneratePasswordContainer.ColumnCount = 3;
            this.GeneratePasswordContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GeneratePasswordContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GeneratePasswordContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GeneratePasswordContainer.Controls.Add(this.CharactersLabel, 2, 0);
            this.GeneratePasswordContainer.Controls.Add(this.GeneratePasswordButton, 0, 0);
            this.GeneratePasswordContainer.Controls.Add(this.NumericUpDown, 1, 0);
            this.GeneratePasswordContainer.Location = new System.Drawing.Point(45, 58);
            this.GeneratePasswordContainer.Name = "GeneratePasswordContainer";
            this.GeneratePasswordContainer.RowCount = 1;
            this.GeneratePasswordContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GeneratePasswordContainer.Size = new System.Drawing.Size(365, 25);
            this.GeneratePasswordContainer.TabIndex = 16;
            // 
            // PasswordGeneratorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(418, 152);
            this.Controls.Add(this.GeneratePasswordContainer);
            this.Controls.Add(this.FormatContainer);
            this.Controls.Add(this.PasswordVisibleCheckBox);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordGeneratorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New password";
            this.Load += new System.EventHandler(this.PasswordGeneratorDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.FormatContainer.ResumeLayout(false);
            this.FormatContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.GeneratePasswordContainer.ResumeLayout(false);
            this.GeneratePasswordContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private DarkLabel MessageLabel;
        private DarkTextBox TextBox;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button CopyButton;
        private DarkButton DoneButton;
        private DarkButton GeneratePasswordButton;
        private DarkLabel CharactersLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private DarkCheckBox PasswordVisibleCheckBox;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.TableLayoutPanel FormatContainer;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.TableLayoutPanel GeneratePasswordContainer;
    }
}