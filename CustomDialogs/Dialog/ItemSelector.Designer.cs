
namespace CustomDialogs {
    partial class ItemSelector {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSelector));
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SelectedItemsTextBox = new CustomDialogs.DarkTextBox();
            this.ViewControl = new CustomDialogs.ViewControl();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalContainer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.SelectButton, 0, 2);
            this.GlobalContainer.Controls.Add(this.SelectedItemsTextBox, 0, 1);
            this.GlobalContainer.Controls.Add(this.ViewControl, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.GlobalContainer.RowCount = 3;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalContainer.Size = new System.Drawing.Size(548, 344);
            this.GlobalContainer.TabIndex = 1;
            // 
            // SelectButton
            // 
            this.SelectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectButton.Location = new System.Drawing.Point(10, 316);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(65, 23);
            this.SelectButton.TabIndex = 8;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // SelectedItemsTextBox
            // 
            this.SelectedItemsTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectedItemsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SelectedItemsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedItemsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemsTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectedItemsTextBox.Location = new System.Drawing.Point(10, 286);
            this.SelectedItemsTextBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SelectedItemsTextBox.Name = "SelectedItemsTextBox";
            this.SelectedItemsTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.SelectedItemsTextBox.PasswordChar = '\0';
            this.SelectedItemsTextBox.ReadOnly = true;
            this.SelectedItemsTextBox.Size = new System.Drawing.Size(528, 25);
            this.SelectedItemsTextBox.TabIndex = 10;
            this.SelectedItemsTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedItemsTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectedItemsTextBox.XOffset = 0;
            this.SelectedItemsTextBox.YOffset = 0;
            // 
            // ViewControl
            // 
            this.ViewControl.AutoSize = true;
            this.ViewControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewControl.Location = new System.Drawing.Point(10, 6);
            this.ViewControl.Margin = new System.Windows.Forms.Padding(0);
            this.ViewControl.Name = "ViewControl";
            this.ViewControl.Size = new System.Drawing.Size(528, 275);
            this.ViewControl.TabIndex = 11;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(106, 26);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // SelectMenuItem
            // 
            this.SelectMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectMenuItem.Name = "SelectMenuItem";
            this.SelectMenuItem.Size = new System.Drawing.Size(105, 22);
            this.SelectMenuItem.Text = "Select";
            this.SelectMenuItem.Click += new System.EventHandler(this.SelectMenuItem_Click);
            // 
            // ItemSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(548, 344);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item selector";
            this.Load += new System.EventHandler(this.ItemSelector_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.Button SelectButton;
        private DarkTextBox SelectedItemsTextBox;
        private ViewControl ViewControl;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SelectMenuItem;
    }
}