
namespace CustomDialogs {
    partial class InformationViewer {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationViewer));
            this.CloseButton = new CustomDialogs.DarkButton();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BuildLabel = new CustomDialogs.DarkLabel();
            this.BuildSeperator = new System.Windows.Forms.Panel();
            this.BuildContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BuildInformationContainer = new System.Windows.Forms.TableLayoutPanel();
            this.VersionReleasedTextBox = new CustomDialogs.DarkTextBox();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.VersionLabel = new CustomDialogs.DarkLabel();
            this.NameLabel = new CustomDialogs.DarkLabel();
            this.VersionTextBox = new CustomDialogs.DarkTextBox();
            this.VersionReleasedLabel = new CustomDialogs.DarkLabel();
            this.BuildPictureBoxPanel = new System.Windows.Forms.Panel();
            this.BuildPictureBox = new System.Windows.Forms.PictureBox();
            this.KeyLabel = new CustomDialogs.DarkLabel();
            this.KeyContainer = new System.Windows.Forms.TableLayoutPanel();
            this.KeyPictureBox = new System.Windows.Forms.PictureBox();
            this.KeyInformationContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CopyPanel = new System.Windows.Forms.Panel();
            this.FullViewButton = new System.Windows.Forms.Button();
            this.CopyLink = new System.Windows.Forms.LinkLabel();
            this.CurrentKeyContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentKeyTextBox = new CustomDialogs.DarkTextBox();
            this.CurrentKeySinceLabel = new CustomDialogs.DarkLabel();
            this.KeyHistoryPanel = new System.Windows.Forms.Panel();
            this.KeyHistoryLabel = new CustomDialogs.DarkLabel();
            this.KeyGridViewPanel = new System.Windows.Forms.Panel();
            this.KeyGridView = new CustomDialogs.DarkDataGridView();
            this.ProgramLabel = new CustomDialogs.DarkLabel();
            this.KeySeperator = new System.Windows.Forms.Panel();
            this.CloudProviderSeperator = new System.Windows.Forms.Panel();
            this.ProgramContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ProgramPictureBox = new System.Windows.Forms.PictureBox();
            this.CloudProviderInformationContainer = new System.Windows.Forms.TableLayoutPanel();
            this.OpenInFileExplorerPanel = new System.Windows.Forms.Panel();
            this.OpenInFileExplorerLink = new System.Windows.Forms.LinkLabel();
            this.ProgramInformationContainer = new System.Windows.Forms.TableLayoutPanel();
            this.LocatedInLabel = new CustomDialogs.DarkLabel();
            this.ProgramCreatedLabel = new CustomDialogs.DarkLabel();
            this.ProviderCreatedTextBox = new CustomDialogs.DarkTextBox();
            this.LocatedInTextBox = new CustomDialogs.DarkTextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DatesCol = new CustomDialogs.TextAndImageColumn();
            this.GlobalContainer.SuspendLayout();
            this.BuildContainer.SuspendLayout();
            this.BuildInformationContainer.SuspendLayout();
            this.BuildPictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuildPictureBox)).BeginInit();
            this.KeyContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).BeginInit();
            this.KeyInformationContainer.SuspendLayout();
            this.CopyPanel.SuspendLayout();
            this.CurrentKeyContainer.SuspendLayout();
            this.KeyHistoryPanel.SuspendLayout();
            this.KeyGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyGridView)).BeginInit();
            this.ProgramContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramPictureBox)).BeginInit();
            this.CloudProviderInformationContainer.SuspendLayout();
            this.OpenInFileExplorerPanel.SuspendLayout();
            this.ProgramInformationContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(11, 462);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 24);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BuildLabel, 0, 0);
            this.GlobalContainer.Controls.Add(this.CloseButton, 0, 11);
            this.GlobalContainer.Controls.Add(this.BuildSeperator, 0, 1);
            this.GlobalContainer.Controls.Add(this.BuildContainer, 0, 2);
            this.GlobalContainer.Controls.Add(this.KeyLabel, 0, 3);
            this.GlobalContainer.Controls.Add(this.KeyContainer, 0, 6);
            this.GlobalContainer.Controls.Add(this.ProgramLabel, 0, 7);
            this.GlobalContainer.Controls.Add(this.KeySeperator, 0, 4);
            this.GlobalContainer.Controls.Add(this.CloudProviderSeperator, 0, 8);
            this.GlobalContainer.Controls.Add(this.ProgramContainer, 0, 9);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(11, 16, 11, 11);
            this.GlobalContainer.RowCount = 12;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(559, 497);
            this.GlobalContainer.TabIndex = 1;
            this.GlobalContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.GlobalContainer_Paint);
            // 
            // BuildLabel
            // 
            this.BuildLabel.AutoSize = true;
            this.BuildLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuildLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BuildLabel.Location = new System.Drawing.Point(11, 16);
            this.BuildLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BuildLabel.Name = "BuildLabel";
            this.BuildLabel.Size = new System.Drawing.Size(35, 15);
            this.BuildLabel.TabIndex = 1;
            this.BuildLabel.Text = "Build";
            // 
            // BuildSeperator
            // 
            this.BuildSeperator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuildSeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BuildSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildSeperator.Location = new System.Drawing.Point(14, 33);
            this.BuildSeperator.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BuildSeperator.Name = "BuildSeperator";
            this.BuildSeperator.Size = new System.Drawing.Size(531, 1);
            this.BuildSeperator.TabIndex = 2;
            // 
            // BuildContainer
            // 
            this.BuildContainer.AutoSize = true;
            this.BuildContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuildContainer.ColumnCount = 2;
            this.BuildContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.BuildContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BuildContainer.Controls.Add(this.BuildInformationContainer, 1, 0);
            this.BuildContainer.Controls.Add(this.BuildPictureBoxPanel, 0, 0);
            this.BuildContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildContainer.Location = new System.Drawing.Point(14, 42);
            this.BuildContainer.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.BuildContainer.Name = "BuildContainer";
            this.BuildContainer.RowCount = 1;
            this.BuildContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BuildContainer.Size = new System.Drawing.Size(531, 80);
            this.BuildContainer.TabIndex = 3;
            // 
            // BuildInformationContainer
            // 
            this.BuildInformationContainer.AutoSize = true;
            this.BuildInformationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuildInformationContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.BuildInformationContainer.ColumnCount = 2;
            this.BuildInformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.BuildInformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BuildInformationContainer.Controls.Add(this.VersionReleasedTextBox, 0, 2);
            this.BuildInformationContainer.Controls.Add(this.NameTextBox, 1, 0);
            this.BuildInformationContainer.Controls.Add(this.VersionLabel, 0, 1);
            this.BuildInformationContainer.Controls.Add(this.NameLabel, 0, 0);
            this.BuildInformationContainer.Controls.Add(this.VersionTextBox, 1, 1);
            this.BuildInformationContainer.Controls.Add(this.VersionReleasedLabel, 0, 2);
            this.BuildInformationContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildInformationContainer.Location = new System.Drawing.Point(90, 0);
            this.BuildInformationContainer.Margin = new System.Windows.Forms.Padding(0);
            this.BuildInformationContainer.Name = "BuildInformationContainer";
            this.BuildInformationContainer.RowCount = 3;
            this.BuildInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BuildInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BuildInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BuildInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BuildInformationContainer.Size = new System.Drawing.Size(441, 79);
            this.BuildInformationContainer.TabIndex = 1;
            // 
            // VersionReleasedTextBox
            // 
            this.VersionReleasedTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VersionReleasedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.VersionReleasedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionReleasedTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VersionReleasedTextBox.Location = new System.Drawing.Point(112, 53);
            this.VersionReleasedTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.VersionReleasedTextBox.Name = "VersionReleasedTextBox";
            this.VersionReleasedTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.VersionReleasedTextBox.PasswordChar = '\0';
            this.VersionReleasedTextBox.ReadOnly = true;
            this.VersionReleasedTextBox.Size = new System.Drawing.Size(328, 25);
            this.VersionReleasedTextBox.TabIndex = 8;
            this.VersionReleasedTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VersionReleasedTextBox.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.VersionReleasedTextBox.XOffset = 0;
            this.VersionReleasedTextBox.YOffset = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(112, 1);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(328, 25);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 1;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VersionLabel.Location = new System.Drawing.Point(4, 31);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(51, 15);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(4, 5);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VersionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.VersionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VersionTextBox.Location = new System.Drawing.Point(112, 27);
            this.VersionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.VersionTextBox.PasswordChar = '\0';
            this.VersionTextBox.ReadOnly = true;
            this.VersionTextBox.Size = new System.Drawing.Size(328, 25);
            this.VersionTextBox.TabIndex = 7;
            this.VersionTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VersionTextBox.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.VersionTextBox.XOffset = 0;
            this.VersionTextBox.YOffset = 1;
            // 
            // VersionReleasedLabel
            // 
            this.VersionReleasedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionReleasedLabel.AutoSize = true;
            this.VersionReleasedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionReleasedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VersionReleasedLabel.Location = new System.Drawing.Point(4, 57);
            this.VersionReleasedLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.VersionReleasedLabel.Name = "VersionReleasedLabel";
            this.VersionReleasedLabel.Size = new System.Drawing.Size(102, 15);
            this.VersionReleasedLabel.TabIndex = 2;
            this.VersionReleasedLabel.Text = "Version released:";
            // 
            // BuildPictureBoxPanel
            // 
            this.BuildPictureBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BuildPictureBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuildPictureBoxPanel.Controls.Add(this.BuildPictureBox);
            this.BuildPictureBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.BuildPictureBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BuildPictureBoxPanel.Name = "BuildPictureBoxPanel";
            this.BuildPictureBoxPanel.Padding = new System.Windows.Forms.Padding(5);
            this.BuildPictureBoxPanel.Size = new System.Drawing.Size(80, 80);
            this.BuildPictureBoxPanel.TabIndex = 2;
            // 
            // BuildPictureBox
            // 
            this.BuildPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BuildPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildPictureBox.Location = new System.Drawing.Point(5, 5);
            this.BuildPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.BuildPictureBox.Name = "BuildPictureBox";
            this.BuildPictureBox.Size = new System.Drawing.Size(68, 68);
            this.BuildPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BuildPictureBox.TabIndex = 0;
            this.BuildPictureBox.TabStop = false;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeyLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyLabel.Location = new System.Drawing.Point(11, 141);
            this.KeyLabel.Margin = new System.Windows.Forms.Padding(0, 19, 0, 2);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(28, 15);
            this.KeyLabel.TabIndex = 4;
            this.KeyLabel.Text = "Key";
            // 
            // KeyContainer
            // 
            this.KeyContainer.AutoSize = true;
            this.KeyContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KeyContainer.ColumnCount = 2;
            this.KeyContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.KeyContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KeyContainer.Controls.Add(this.KeyPictureBox, 0, 0);
            this.KeyContainer.Controls.Add(this.KeyInformationContainer, 1, 0);
            this.KeyContainer.Location = new System.Drawing.Point(14, 167);
            this.KeyContainer.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.KeyContainer.Name = "KeyContainer";
            this.KeyContainer.RowCount = 1;
            this.KeyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KeyContainer.Size = new System.Drawing.Size(531, 153);
            this.KeyContainer.TabIndex = 6;
            // 
            // KeyPictureBox
            // 
            this.KeyPictureBox.Location = new System.Drawing.Point(0, 0);
            this.KeyPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.KeyPictureBox.Name = "KeyPictureBox";
            this.KeyPictureBox.Size = new System.Drawing.Size(27, 27);
            this.KeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KeyPictureBox.TabIndex = 0;
            this.KeyPictureBox.TabStop = false;
            // 
            // KeyInformationContainer
            // 
            this.KeyInformationContainer.AutoSize = true;
            this.KeyInformationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KeyInformationContainer.ColumnCount = 1;
            this.KeyInformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KeyInformationContainer.Controls.Add(this.CopyPanel, 0, 3);
            this.KeyInformationContainer.Controls.Add(this.CurrentKeyContainer, 0, 0);
            this.KeyInformationContainer.Controls.Add(this.KeyHistoryPanel, 0, 1);
            this.KeyInformationContainer.Controls.Add(this.KeyGridViewPanel, 0, 2);
            this.KeyInformationContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeyInformationContainer.Location = new System.Drawing.Point(90, 0);
            this.KeyInformationContainer.Margin = new System.Windows.Forms.Padding(0);
            this.KeyInformationContainer.Name = "KeyInformationContainer";
            this.KeyInformationContainer.RowCount = 4;
            this.KeyInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KeyInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KeyInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KeyInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KeyInformationContainer.Size = new System.Drawing.Size(441, 153);
            this.KeyInformationContainer.TabIndex = 1;
            // 
            // CopyPanel
            // 
            this.CopyPanel.AutoSize = true;
            this.CopyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CopyPanel.Controls.Add(this.FullViewButton);
            this.CopyPanel.Controls.Add(this.CopyLink);
            this.CopyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyPanel.Location = new System.Drawing.Point(0, 134);
            this.CopyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CopyPanel.Name = "CopyPanel";
            this.CopyPanel.Size = new System.Drawing.Size(441, 19);
            this.CopyPanel.TabIndex = 6;
            // 
            // FullViewButton
            // 
            this.FullViewButton.FlatAppearance.BorderSize = 0;
            this.FullViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullViewButton.Image = global::CustomDialogs.Properties.Resources._16pxZoom;
            this.FullViewButton.Location = new System.Drawing.Point(422, 3);
            this.FullViewButton.Margin = new System.Windows.Forms.Padding(0);
            this.FullViewButton.Name = "FullViewButton";
            this.FullViewButton.Size = new System.Drawing.Size(16, 16);
            this.FullViewButton.TabIndex = 4;
            this.ToolTip.SetToolTip(this.FullViewButton, "Open extended key history view");
            this.FullViewButton.UseVisualStyleBackColor = true;
            this.FullViewButton.Click += new System.EventHandler(this.FullViewButton_Click);
            // 
            // CopyLink
            // 
            this.CopyLink.ActiveLinkColor = System.Drawing.SystemColors.GrayText;
            this.CopyLink.AutoSize = true;
            this.CopyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyLink.Location = new System.Drawing.Point(-3, -1);
            this.CopyLink.Margin = new System.Windows.Forms.Padding(0);
            this.CopyLink.Name = "CopyLink";
            this.CopyLink.Size = new System.Drawing.Size(34, 15);
            this.CopyLink.TabIndex = 3;
            this.CopyLink.TabStop = true;
            this.CopyLink.Text = "Copy";
            this.CopyLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLink_LinkClicked);
            // 
            // CurrentKeyContainer
            // 
            this.CurrentKeyContainer.AutoSize = true;
            this.CurrentKeyContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CurrentKeyContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CurrentKeyContainer.ColumnCount = 2;
            this.CurrentKeyContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.CurrentKeyContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrentKeyContainer.Controls.Add(this.CurrentKeyTextBox, 0, 0);
            this.CurrentKeyContainer.Controls.Add(this.CurrentKeySinceLabel, 0, 0);
            this.CurrentKeyContainer.Location = new System.Drawing.Point(0, 0);
            this.CurrentKeyContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentKeyContainer.Name = "CurrentKeyContainer";
            this.CurrentKeyContainer.RowCount = 1;
            this.CurrentKeyContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CurrentKeyContainer.Size = new System.Drawing.Size(441, 27);
            this.CurrentKeyContainer.TabIndex = 1;
            // 
            // CurrentKeyTextBox
            // 
            this.CurrentKeyTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CurrentKeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CurrentKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentKeyTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CurrentKeyTextBox.Location = new System.Drawing.Point(112, 1);
            this.CurrentKeyTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentKeyTextBox.Name = "CurrentKeyTextBox";
            this.CurrentKeyTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.CurrentKeyTextBox.PasswordChar = '\0';
            this.CurrentKeyTextBox.ReadOnly = true;
            this.CurrentKeyTextBox.Size = new System.Drawing.Size(328, 25);
            this.CurrentKeyTextBox.TabIndex = 9;
            this.CurrentKeyTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentKeyTextBox.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.CurrentKeyTextBox.XOffset = 0;
            this.CurrentKeyTextBox.YOffset = 1;
            // 
            // CurrentKeySinceLabel
            // 
            this.CurrentKeySinceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentKeySinceLabel.AutoSize = true;
            this.CurrentKeySinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentKeySinceLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CurrentKeySinceLabel.Location = new System.Drawing.Point(4, 5);
            this.CurrentKeySinceLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.CurrentKeySinceLabel.Name = "CurrentKeySinceLabel";
            this.CurrentKeySinceLabel.Size = new System.Drawing.Size(103, 15);
            this.CurrentKeySinceLabel.TabIndex = 3;
            this.CurrentKeySinceLabel.Text = "Current key since:";
            // 
            // KeyHistoryPanel
            // 
            this.KeyHistoryPanel.AutoSize = true;
            this.KeyHistoryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KeyHistoryPanel.Controls.Add(this.KeyHistoryLabel);
            this.KeyHistoryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KeyHistoryPanel.Location = new System.Drawing.Point(0, 36);
            this.KeyHistoryPanel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.KeyHistoryPanel.Name = "KeyHistoryPanel";
            this.KeyHistoryPanel.Size = new System.Drawing.Size(441, 15);
            this.KeyHistoryPanel.TabIndex = 3;
            // 
            // KeyHistoryLabel
            // 
            this.KeyHistoryLabel.AutoSize = true;
            this.KeyHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyHistoryLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyHistoryLabel.Location = new System.Drawing.Point(-3, 0);
            this.KeyHistoryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.KeyHistoryLabel.Name = "KeyHistoryLabel";
            this.KeyHistoryLabel.Size = new System.Drawing.Size(65, 15);
            this.KeyHistoryLabel.TabIndex = 2;
            this.KeyHistoryLabel.Text = "Key history";
            // 
            // KeyGridViewPanel
            // 
            this.KeyGridViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyGridViewPanel.Controls.Add(this.KeyGridView);
            this.KeyGridViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeyGridViewPanel.Location = new System.Drawing.Point(0, 55);
            this.KeyGridViewPanel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.KeyGridViewPanel.Name = "KeyGridViewPanel";
            this.KeyGridViewPanel.Size = new System.Drawing.Size(441, 79);
            this.KeyGridViewPanel.TabIndex = 5;
            // 
            // KeyGridView
            // 
            this.KeyGridView.AllowUserToAddRows = false;
            this.KeyGridView.AllowUserToDeleteRows = false;
            this.KeyGridView.AllowUserToOrderColumns = true;
            this.KeyGridView.AllowUserToResizeRows = false;
            this.KeyGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KeyGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyGridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KeyGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.KeyGridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyGridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.KeyGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KeyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.KeyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KeyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatesCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KeyGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.KeyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyGridView.EnableHeadersVisualStyles = false;
            this.KeyGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.KeyGridView.Location = new System.Drawing.Point(0, 0);
            this.KeyGridView.Margin = new System.Windows.Forms.Padding(0);
            this.KeyGridView.Name = "KeyGridView";
            this.KeyGridView.ReadOnly = true;
            this.KeyGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KeyGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.KeyGridView.RowTemplate.Height = 23;
            this.KeyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KeyGridView.Size = new System.Drawing.Size(439, 77);
            this.KeyGridView.TabIndex = 0;
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgramLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProgramLabel.Location = new System.Drawing.Point(11, 339);
            this.ProgramLabel.Margin = new System.Windows.Forms.Padding(0, 19, 0, 2);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(55, 15);
            this.ProgramLabel.TabIndex = 7;
            this.ProgramLabel.Text = "Program";
            // 
            // KeySeperator
            // 
            this.KeySeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.KeySeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeySeperator.Location = new System.Drawing.Point(14, 158);
            this.KeySeperator.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.KeySeperator.Name = "KeySeperator";
            this.KeySeperator.Size = new System.Drawing.Size(531, 1);
            this.KeySeperator.TabIndex = 8;
            // 
            // CloudProviderSeperator
            // 
            this.CloudProviderSeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CloudProviderSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloudProviderSeperator.Location = new System.Drawing.Point(14, 356);
            this.CloudProviderSeperator.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.CloudProviderSeperator.Name = "CloudProviderSeperator";
            this.CloudProviderSeperator.Size = new System.Drawing.Size(531, 1);
            this.CloudProviderSeperator.TabIndex = 9;
            // 
            // ProgramContainer
            // 
            this.ProgramContainer.AutoSize = true;
            this.ProgramContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProgramContainer.ColumnCount = 2;
            this.ProgramContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ProgramContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProgramContainer.Controls.Add(this.ProgramPictureBox, 0, 0);
            this.ProgramContainer.Controls.Add(this.CloudProviderInformationContainer, 1, 0);
            this.ProgramContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgramContainer.Location = new System.Drawing.Point(14, 365);
            this.ProgramContainer.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.ProgramContainer.Name = "ProgramContainer";
            this.ProgramContainer.RowCount = 1;
            this.ProgramContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProgramContainer.Size = new System.Drawing.Size(531, 67);
            this.ProgramContainer.TabIndex = 10;
            // 
            // ProgramPictureBox
            // 
            this.ProgramPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ProgramPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramPictureBox.Name = "ProgramPictureBox";
            this.ProgramPictureBox.Size = new System.Drawing.Size(27, 27);
            this.ProgramPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProgramPictureBox.TabIndex = 1;
            this.ProgramPictureBox.TabStop = false;
            // 
            // CloudProviderInformationContainer
            // 
            this.CloudProviderInformationContainer.AutoSize = true;
            this.CloudProviderInformationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloudProviderInformationContainer.ColumnCount = 1;
            this.CloudProviderInformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CloudProviderInformationContainer.Controls.Add(this.OpenInFileExplorerPanel, 0, 1);
            this.CloudProviderInformationContainer.Controls.Add(this.ProgramInformationContainer, 0, 0);
            this.CloudProviderInformationContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloudProviderInformationContainer.Location = new System.Drawing.Point(90, 0);
            this.CloudProviderInformationContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CloudProviderInformationContainer.Name = "CloudProviderInformationContainer";
            this.CloudProviderInformationContainer.RowCount = 2;
            this.CloudProviderInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CloudProviderInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CloudProviderInformationContainer.Size = new System.Drawing.Size(441, 67);
            this.CloudProviderInformationContainer.TabIndex = 11;
            // 
            // OpenInFileExplorerPanel
            // 
            this.OpenInFileExplorerPanel.AutoSize = true;
            this.OpenInFileExplorerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenInFileExplorerPanel.Controls.Add(this.OpenInFileExplorerLink);
            this.OpenInFileExplorerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpenInFileExplorerPanel.Location = new System.Drawing.Point(0, 52);
            this.OpenInFileExplorerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.OpenInFileExplorerPanel.Name = "OpenInFileExplorerPanel";
            this.OpenInFileExplorerPanel.Size = new System.Drawing.Size(441, 15);
            this.OpenInFileExplorerPanel.TabIndex = 7;
            // 
            // OpenInFileExplorerLink
            // 
            this.OpenInFileExplorerLink.ActiveLinkColor = System.Drawing.SystemColors.GrayText;
            this.OpenInFileExplorerLink.AutoSize = true;
            this.OpenInFileExplorerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenInFileExplorerLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenInFileExplorerLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.OpenInFileExplorerLink.Location = new System.Drawing.Point(-3, 0);
            this.OpenInFileExplorerLink.Margin = new System.Windows.Forms.Padding(0);
            this.OpenInFileExplorerLink.Name = "OpenInFileExplorerLink";
            this.OpenInFileExplorerLink.Size = new System.Drawing.Size(117, 15);
            this.OpenInFileExplorerLink.TabIndex = 3;
            this.OpenInFileExplorerLink.TabStop = true;
            this.OpenInFileExplorerLink.Text = "Open in file explorer";
            this.OpenInFileExplorerLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.OpenInFileExplorerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenInFileExplorerLink_LinkClicked);
            // 
            // ProgramInformationContainer
            // 
            this.ProgramInformationContainer.AutoSize = true;
            this.ProgramInformationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProgramInformationContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ProgramInformationContainer.ColumnCount = 2;
            this.ProgramInformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.ProgramInformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProgramInformationContainer.Controls.Add(this.LocatedInLabel, 0, 1);
            this.ProgramInformationContainer.Controls.Add(this.ProgramCreatedLabel, 0, 0);
            this.ProgramInformationContainer.Controls.Add(this.ProviderCreatedTextBox, 1, 0);
            this.ProgramInformationContainer.Controls.Add(this.LocatedInTextBox, 1, 1);
            this.ProgramInformationContainer.Location = new System.Drawing.Point(0, 0);
            this.ProgramInformationContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ProgramInformationContainer.Name = "ProgramInformationContainer";
            this.ProgramInformationContainer.RowCount = 2;
            this.ProgramInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ProgramInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ProgramInformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ProgramInformationContainer.Size = new System.Drawing.Size(441, 52);
            this.ProgramInformationContainer.TabIndex = 2;
            // 
            // LocatedInLabel
            // 
            this.LocatedInLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocatedInLabel.AutoSize = true;
            this.LocatedInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocatedInLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocatedInLabel.Location = new System.Drawing.Point(4, 30);
            this.LocatedInLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.LocatedInLabel.Name = "LocatedInLabel";
            this.LocatedInLabel.Size = new System.Drawing.Size(67, 15);
            this.LocatedInLabel.TabIndex = 2;
            this.LocatedInLabel.Text = "Located in:";
            // 
            // ProgramCreatedLabel
            // 
            this.ProgramCreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProgramCreatedLabel.AutoSize = true;
            this.ProgramCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramCreatedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProgramCreatedLabel.Location = new System.Drawing.Point(4, 5);
            this.ProgramCreatedLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.ProgramCreatedLabel.Name = "ProgramCreatedLabel";
            this.ProgramCreatedLabel.Size = new System.Drawing.Size(102, 15);
            this.ProgramCreatedLabel.TabIndex = 1;
            this.ProgramCreatedLabel.Text = "Program created:";
            // 
            // ProviderCreatedTextBox
            // 
            this.ProviderCreatedTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProviderCreatedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProviderCreatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProviderCreatedTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProviderCreatedTextBox.Location = new System.Drawing.Point(112, 1);
            this.ProviderCreatedTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProviderCreatedTextBox.Name = "ProviderCreatedTextBox";
            this.ProviderCreatedTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.ProviderCreatedTextBox.PasswordChar = '\0';
            this.ProviderCreatedTextBox.ReadOnly = true;
            this.ProviderCreatedTextBox.Size = new System.Drawing.Size(328, 24);
            this.ProviderCreatedTextBox.TabIndex = 10;
            this.ProviderCreatedTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderCreatedTextBox.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.ProviderCreatedTextBox.XOffset = 0;
            this.ProviderCreatedTextBox.YOffset = 1;
            // 
            // LocatedInTextBox
            // 
            this.LocatedInTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LocatedInTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LocatedInTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocatedInTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocatedInTextBox.Location = new System.Drawing.Point(112, 26);
            this.LocatedInTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.LocatedInTextBox.Name = "LocatedInTextBox";
            this.LocatedInTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.LocatedInTextBox.PasswordChar = '\0';
            this.LocatedInTextBox.ReadOnly = true;
            this.LocatedInTextBox.Size = new System.Drawing.Size(328, 25);
            this.LocatedInTextBox.TabIndex = 11;
            this.LocatedInTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocatedInTextBox.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.LocatedInTextBox.XOffset = 0;
            this.LocatedInTextBox.YOffset = 1;
            // 
            // DatesCol
            // 
            this.DatesCol.AlignmentToRight = false;
            this.DatesCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatesCol.HeaderText = "Date";
            this.DatesCol.Image = null;
            this.DatesCol.Name = "DatesCol";
            this.DatesCol.ReadOnly = true;
            // 
            // InformationViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(559, 497);
            this.Controls.Add(this.GlobalContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InformationViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BuildContainer.ResumeLayout(false);
            this.BuildContainer.PerformLayout();
            this.BuildInformationContainer.ResumeLayout(false);
            this.BuildInformationContainer.PerformLayout();
            this.BuildPictureBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuildPictureBox)).EndInit();
            this.KeyContainer.ResumeLayout(false);
            this.KeyContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).EndInit();
            this.KeyInformationContainer.ResumeLayout(false);
            this.KeyInformationContainer.PerformLayout();
            this.CopyPanel.ResumeLayout(false);
            this.CopyPanel.PerformLayout();
            this.CurrentKeyContainer.ResumeLayout(false);
            this.CurrentKeyContainer.PerformLayout();
            this.KeyHistoryPanel.ResumeLayout(false);
            this.KeyHistoryPanel.PerformLayout();
            this.KeyGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyGridView)).EndInit();
            this.ProgramContainer.ResumeLayout(false);
            this.ProgramContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramPictureBox)).EndInit();
            this.CloudProviderInformationContainer.ResumeLayout(false);
            this.CloudProviderInformationContainer.PerformLayout();
            this.OpenInFileExplorerPanel.ResumeLayout(false);
            this.OpenInFileExplorerPanel.PerformLayout();
            this.ProgramInformationContainer.ResumeLayout(false);
            this.ProgramInformationContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkLabel BuildLabel;
        private System.Windows.Forms.Panel BuildSeperator;
        private System.Windows.Forms.TableLayoutPanel BuildContainer;
        private System.Windows.Forms.PictureBox BuildPictureBox;
        private System.Windows.Forms.TableLayoutPanel BuildInformationContainer;
        private CustomDialogs.DarkLabel NameLabel;
        private CustomDialogs.DarkLabel VersionReleasedLabel;
        private CustomDialogs.DarkLabel VersionLabel;
        private CustomDialogs.DarkTextBox NameTextBox;
        private CustomDialogs.DarkTextBox VersionReleasedTextBox;
        private CustomDialogs.DarkTextBox VersionTextBox;
        private CustomDialogs.DarkLabel KeyLabel;
        private System.Windows.Forms.TableLayoutPanel KeyContainer;
        private System.Windows.Forms.PictureBox KeyPictureBox;
        private System.Windows.Forms.TableLayoutPanel CurrentKeyContainer;
        private CustomDialogs.DarkTextBox CurrentKeyTextBox;
        private CustomDialogs.DarkLabel CurrentKeySinceLabel;
        private System.Windows.Forms.TableLayoutPanel KeyInformationContainer;
        private System.Windows.Forms.Panel KeyHistoryPanel;
        private CustomDialogs.DarkLabel KeyHistoryLabel;
        private System.Windows.Forms.Panel KeyGridViewPanel;
        private System.Windows.Forms.Panel CopyPanel;
        private System.Windows.Forms.LinkLabel CopyLink;
        private CustomDialogs.DarkLabel ProgramLabel;
        private System.Windows.Forms.Panel KeySeperator;
        private System.Windows.Forms.Panel CloudProviderSeperator;
        private System.Windows.Forms.TableLayoutPanel ProgramContainer;
        private System.Windows.Forms.PictureBox ProgramPictureBox;
        private System.Windows.Forms.TableLayoutPanel ProgramInformationContainer;
        private CustomDialogs.DarkLabel LocatedInLabel;
        private CustomDialogs.DarkLabel ProgramCreatedLabel;
        private CustomDialogs.DarkTextBox LocatedInTextBox;
        private CustomDialogs.DarkTextBox ProviderCreatedTextBox;
        private System.Windows.Forms.TableLayoutPanel CloudProviderInformationContainer;
        private System.Windows.Forms.Panel OpenInFileExplorerPanel;
        private System.Windows.Forms.LinkLabel OpenInFileExplorerLink;
        private System.Windows.Forms.Button FullViewButton;
        private System.Windows.Forms.Panel BuildPictureBoxPanel;
        private System.Windows.Forms.ToolTip ToolTip;
        private DarkDataGridView KeyGridView;
        private TextAndImageColumn DatesCol;
    }
}