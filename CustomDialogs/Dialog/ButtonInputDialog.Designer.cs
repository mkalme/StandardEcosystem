
namespace CustomDialogs {
    partial class ButtonInputDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonInputDialog));
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.TextContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.RichTextBoxPanel = new System.Windows.Forms.Panel();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GlobalContainer.SuspendLayout();
            this.TextContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.RichTextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.ButtonContainer, 0, 1);
            this.GlobalContainer.Controls.Add(this.TextContainer, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(11, 0, 0, 2);
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(383, 109);
            this.GlobalContainer.TabIndex = 0;
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.ColumnCount = 1;
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonContainer.Location = new System.Drawing.Point(11, 73);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.RowCount = 1;
            this.ButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonContainer.Size = new System.Drawing.Size(372, 34);
            this.ButtonContainer.TabIndex = 0;
            // 
            // TextContainer
            // 
            this.TextContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TextContainer.ColumnCount = 2;
            this.TextContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TextContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextContainer.Controls.Add(this.PictureBox, 0, 0);
            this.TextContainer.Controls.Add(this.RichTextBoxPanel, 1, 0);
            this.TextContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextContainer.Location = new System.Drawing.Point(11, 0);
            this.TextContainer.Margin = new System.Windows.Forms.Padding(0);
            this.TextContainer.Name = "TextContainer";
            this.TextContainer.RowCount = 1;
            this.TextContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextContainer.Size = new System.Drawing.Size(372, 73);
            this.TextContainer.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(1, 14);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(1, 14, 6, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(40, 40);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // RichTextBoxPanel
            // 
            this.RichTextBoxPanel.Controls.Add(this.MessageRichTextBox);
            this.RichTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxPanel.Location = new System.Drawing.Point(50, 14);
            this.RichTextBoxPanel.Margin = new System.Windows.Forms.Padding(3, 14, 0, 0);
            this.RichTextBoxPanel.Name = "RichTextBoxPanel";
            this.RichTextBoxPanel.Size = new System.Drawing.Size(322, 59);
            this.RichTextBoxPanel.TabIndex = 1;
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MessageRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageRichTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageRichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MessageRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.MessageRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.Size = new System.Drawing.Size(322, 59);
            this.MessageRichTextBox.TabIndex = 1;
            this.MessageRichTextBox.Text = "";
            this.MessageRichTextBox.WordWrap = false;
            // 
            // ButtonInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(383, 109);
            this.Controls.Add(this.GlobalContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ButtonInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dialog input";
            this.Load += new System.EventHandler(this.DialogButtonInput_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.TextContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.RichTextBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel ButtonContainer;
        private System.Windows.Forms.TableLayoutPanel TextContainer;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.Panel RichTextBoxPanel;
    }
}