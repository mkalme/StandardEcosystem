
namespace CustomDialogs {
    partial class HeaderToolBarControl {
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
            this.components = new System.ComponentModel.Container();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.PathPanelContainer = new System.Windows.Forms.Panel();
            this.PathPanel = new CustomDialogs.PathNodePanel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GlobalContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.PathPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.AutoSize = true;
            this.GlobalContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GlobalContainer.ColumnCount = 2;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.ButtonPanel, 0, 0);
            this.GlobalContainer.Controls.Add(this.PathPanelContainer, 1, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 1;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Size = new System.Drawing.Size(129, 31);
            this.GlobalContainer.TabIndex = 4;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.RefreshButton);
            this.ButtonPanel.Controls.Add(this.ForwardButton);
            this.ButtonPanel.Controls.Add(this.PrevButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(85, 31);
            this.ButtonPanel.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::CustomDialogs.Properties.Resources.Refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RefreshButton.Location = new System.Drawing.Point(59, 1);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 23);
            this.RefreshButton.TabIndex = 2;
            this.ToolTip.SetToolTip(this.RefreshButton, "Refresh");
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = global::CustomDialogs.Properties.Resources._512pxRightArrow;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ForwardButton.Location = new System.Drawing.Point(24, 1);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(23, 23);
            this.ForwardButton.TabIndex = 1;
            this.ToolTip.SetToolTip(this.ForwardButton, "Go forward");
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.BackgroundImage = global::CustomDialogs.Properties.Resources._512pxLeftArrow;
            this.PrevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrevButton.FlatAppearance.BorderSize = 0;
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PrevButton.Location = new System.Drawing.Point(0, 1);
            this.PrevButton.Margin = new System.Windows.Forms.Padding(0);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(23, 23);
            this.PrevButton.TabIndex = 0;
            this.ToolTip.SetToolTip(this.PrevButton, "Go to the parent\'s group");
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // PathPanelContainer
            // 
            this.PathPanelContainer.Controls.Add(this.PathPanel);
            this.PathPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanelContainer.Location = new System.Drawing.Point(85, 0);
            this.PathPanelContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.PathPanelContainer.Name = "PathPanelContainer";
            this.PathPanelContainer.Size = new System.Drawing.Size(44, 25);
            this.PathPanelContainer.TabIndex = 1;
            // 
            // PathPanel
            // 
            this.PathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanel.Location = new System.Drawing.Point(0, 0);
            this.PathPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Size = new System.Drawing.Size(44, 25);
            this.PathPanel.TabIndex = 0;
            // 
            // HeaderToolBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.GlobalContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HeaderToolBarControl";
            this.Size = new System.Drawing.Size(129, 31);
            this.GlobalContainer.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.PathPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Panel PathPanelContainer;
        private PathNodePanel PathPanel;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
