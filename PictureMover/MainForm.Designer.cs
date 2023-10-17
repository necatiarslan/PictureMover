namespace PictureMover
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.DestinationFolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectSourceFolderButton = new System.Windows.Forms.Button();
            this.SelectDestinationFolderButton = new System.Windows.Forms.Button();
            this.DiscoverButton = new System.Windows.Forms.Button();
            this.FilesDataGridView = new System.Windows.Forms.DataGridView();
            this.GridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartButton = new System.Windows.Forms.Button();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.FilesDataGridViewSummaryLabel = new System.Windows.Forms.Label();
            this.DestinationFormatComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExistsInTheTargetRadioButton = new System.Windows.Forms.RadioButton();
            this.NotExistsInTargetRadioButton = new System.Windows.Forms.RadioButton();
            this.OptionsTabPage = new System.Windows.Forms.TabPage();
            this.ExcludeTextBox = new System.Windows.Forms.TextBox();
            this.IncludeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceFolderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationFolderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistsOnDestinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationFilePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileCopiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderComparisonTabPage = new System.Windows.Forms.TabPage();
            this.DublicateFileTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGridView)).BeginInit();
            this.GridContextMenuStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OptionsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Tag = "";
            this.label2.Text = "Destination :";
            // 
            // SourceFolderTextBox
            // 
            this.SourceFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceFolderTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SourceFolderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceFolderTextBox.Location = new System.Drawing.Point(79, 16);
            this.SourceFolderTextBox.Name = "SourceFolderTextBox";
            this.SourceFolderTextBox.ReadOnly = true;
            this.SourceFolderTextBox.Size = new System.Drawing.Size(943, 22);
            this.SourceFolderTextBox.TabIndex = 3;
            this.SourceFolderTextBox.Click += new System.EventHandler(this.SourceFolderTextBox_Click);
            // 
            // DestinationFolderTextBox
            // 
            this.DestinationFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationFolderTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DestinationFolderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationFolderTextBox.Location = new System.Drawing.Point(79, 46);
            this.DestinationFolderTextBox.Name = "DestinationFolderTextBox";
            this.DestinationFolderTextBox.ReadOnly = true;
            this.DestinationFolderTextBox.Size = new System.Drawing.Size(943, 22);
            this.DestinationFolderTextBox.TabIndex = 4;
            this.DestinationFolderTextBox.Click += new System.EventHandler(this.DestinationFolderTextBox_Click);
            // 
            // SelectSourceFolderButton
            // 
            this.SelectSourceFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSourceFolderButton.Location = new System.Drawing.Point(1028, 13);
            this.SelectSourceFolderButton.Name = "SelectSourceFolderButton";
            this.SelectSourceFolderButton.Size = new System.Drawing.Size(24, 23);
            this.SelectSourceFolderButton.TabIndex = 5;
            this.SelectSourceFolderButton.Text = "...";
            this.SelectSourceFolderButton.UseVisualStyleBackColor = true;
            this.SelectSourceFolderButton.Click += new System.EventHandler(this.SelectSourceFolderButton_Click);
            // 
            // SelectDestinationFolderButton
            // 
            this.SelectDestinationFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectDestinationFolderButton.Location = new System.Drawing.Point(1028, 44);
            this.SelectDestinationFolderButton.Name = "SelectDestinationFolderButton";
            this.SelectDestinationFolderButton.Size = new System.Drawing.Size(24, 23);
            this.SelectDestinationFolderButton.TabIndex = 6;
            this.SelectDestinationFolderButton.Text = "...";
            this.SelectDestinationFolderButton.UseVisualStyleBackColor = true;
            this.SelectDestinationFolderButton.Click += new System.EventHandler(this.SelectDestinationFolderButton_Click);
            // 
            // DiscoverButton
            // 
            this.DiscoverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscoverButton.Location = new System.Drawing.Point(79, 72);
            this.DiscoverButton.Name = "DiscoverButton";
            this.DiscoverButton.Size = new System.Drawing.Size(75, 23);
            this.DiscoverButton.TabIndex = 7;
            this.DiscoverButton.Text = "Discover";
            this.DiscoverButton.UseVisualStyleBackColor = true;
            this.DiscoverButton.Click += new System.EventHandler(this.DiscoverButton_Click);
            // 
            // FilesDataGridView
            // 
            this.FilesDataGridView.AllowUserToAddRows = false;
            this.FilesDataGridView.AllowUserToOrderColumns = true;
            this.FilesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameColumn,
            this.SourceFolderColumn,
            this.DestinationFolderColumn,
            this.DateColumn,
            this.ExistsOnDestinationColumn,
            this.DestinationFilePathColumn,
            this.FileCopiedColumn});
            this.FilesDataGridView.ContextMenuStrip = this.GridContextMenuStrip;
            this.FilesDataGridView.Location = new System.Drawing.Point(79, 133);
            this.FilesDataGridView.Name = "FilesDataGridView";
            this.FilesDataGridView.ReadOnly = true;
            this.FilesDataGridView.Size = new System.Drawing.Size(973, 434);
            this.FilesDataGridView.TabIndex = 8;
            // 
            // GridContextMenuStrip
            // 
            this.GridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.DeleteAllToolStripMenuItem});
            this.GridContextMenuStrip.Name = "GridContextMenuStrip";
            this.GridContextMenuStrip.Size = new System.Drawing.Size(125, 48);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // DeleteAllToolStripMenuItem
            // 
            this.DeleteAllToolStripMenuItem.Name = "DeleteAllToolStripMenuItem";
            this.DeleteAllToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DeleteAllToolStripMenuItem.Text = "Delete All";
            this.DeleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllToolStripMenuItem_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(980, 573);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextBox.Enabled = false;
            this.FilterTextBox.Location = new System.Drawing.Point(161, 75);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(673, 20);
            this.FilterTextBox.TabIndex = 11;
            this.FilterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterTextBox_KeyDown);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.MainTabPage);
            this.MainTabControl.Controls.Add(this.OptionsTabPage);
            this.MainTabControl.Controls.Add(this.FolderComparisonTabPage);
            this.MainTabControl.Controls.Add(this.DublicateFileTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(14, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1066, 628);
            this.MainTabControl.TabIndex = 12;
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.FilesDataGridViewSummaryLabel);
            this.MainTabPage.Controls.Add(this.DestinationFormatComboBox);
            this.MainTabPage.Controls.Add(this.panel1);
            this.MainTabPage.Controls.Add(this.SourceFolderTextBox);
            this.MainTabPage.Controls.Add(this.label1);
            this.MainTabPage.Controls.Add(this.StartButton);
            this.MainTabPage.Controls.Add(this.FilterTextBox);
            this.MainTabPage.Controls.Add(this.label2);
            this.MainTabPage.Controls.Add(this.DestinationFolderTextBox);
            this.MainTabPage.Controls.Add(this.SelectSourceFolderButton);
            this.MainTabPage.Controls.Add(this.FilesDataGridView);
            this.MainTabPage.Controls.Add(this.SelectDestinationFolderButton);
            this.MainTabPage.Controls.Add(this.DiscoverButton);
            this.MainTabPage.Location = new System.Drawing.Point(4, 22);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(1058, 602);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Files";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // FilesDataGridViewSummaryLabel
            // 
            this.FilesDataGridViewSummaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilesDataGridViewSummaryLabel.AutoSize = true;
            this.FilesDataGridViewSummaryLabel.Location = new System.Drawing.Point(79, 574);
            this.FilesDataGridViewSummaryLabel.Name = "FilesDataGridViewSummaryLabel";
            this.FilesDataGridViewSummaryLabel.Size = new System.Drawing.Size(38, 13);
            this.FilesDataGridViewSummaryLabel.TabIndex = 14;
            this.FilesDataGridViewSummaryLabel.Text = "Ready";
            // 
            // DestinationFormatComboBox
            // 
            this.DestinationFormatComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationFormatComboBox.FormattingEnabled = true;
            this.DestinationFormatComboBox.Items.AddRange(new object[] {
            "2023/08-August/15/Files",
            "2023/08-August/Files",
            "2023/08/15/Files",
            "2023/08/Files"});
            this.DestinationFormatComboBox.Location = new System.Drawing.Point(840, 75);
            this.DestinationFormatComboBox.Name = "DestinationFormatComboBox";
            this.DestinationFormatComboBox.Size = new System.Drawing.Size(212, 21);
            this.DestinationFormatComboBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExistsInTheTargetRadioButton);
            this.panel1.Controls.Add(this.NotExistsInTargetRadioButton);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(79, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 26);
            this.panel1.TabIndex = 12;
            // 
            // ExistsInTheTargetRadioButton
            // 
            this.ExistsInTheTargetRadioButton.AutoSize = true;
            this.ExistsInTheTargetRadioButton.Location = new System.Drawing.Point(82, 4);
            this.ExistsInTheTargetRadioButton.Name = "ExistsInTheTargetRadioButton";
            this.ExistsInTheTargetRadioButton.Size = new System.Drawing.Size(52, 17);
            this.ExistsInTheTargetRadioButton.TabIndex = 1;
            this.ExistsInTheTargetRadioButton.Text = "Exists";
            this.ExistsInTheTargetRadioButton.UseVisualStyleBackColor = true;
            // 
            // NotExistsInTargetRadioButton
            // 
            this.NotExistsInTargetRadioButton.AutoSize = true;
            this.NotExistsInTargetRadioButton.Checked = true;
            this.NotExistsInTargetRadioButton.Location = new System.Drawing.Point(3, 3);
            this.NotExistsInTargetRadioButton.Name = "NotExistsInTargetRadioButton";
            this.NotExistsInTargetRadioButton.Size = new System.Drawing.Size(72, 17);
            this.NotExistsInTargetRadioButton.TabIndex = 0;
            this.NotExistsInTargetRadioButton.TabStop = true;
            this.NotExistsInTargetRadioButton.Text = "Not Exists";
            this.NotExistsInTargetRadioButton.UseVisualStyleBackColor = true;
            // 
            // OptionsTabPage
            // 
            this.OptionsTabPage.Controls.Add(this.ExcludeTextBox);
            this.OptionsTabPage.Controls.Add(this.IncludeTextBox);
            this.OptionsTabPage.Controls.Add(this.label4);
            this.OptionsTabPage.Controls.Add(this.label3);
            this.OptionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.OptionsTabPage.Name = "OptionsTabPage";
            this.OptionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTabPage.Size = new System.Drawing.Size(1058, 602);
            this.OptionsTabPage.TabIndex = 1;
            this.OptionsTabPage.Text = "Options";
            this.OptionsTabPage.UseVisualStyleBackColor = true;
            // 
            // ExcludeTextBox
            // 
            this.ExcludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcludeTextBox.Location = new System.Drawing.Point(60, 90);
            this.ExcludeTextBox.Name = "ExcludeTextBox";
            this.ExcludeTextBox.Size = new System.Drawing.Size(663, 20);
            this.ExcludeTextBox.TabIndex = 3;
            // 
            // IncludeTextBox
            // 
            this.IncludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncludeTextBox.Location = new System.Drawing.Point(60, 9);
            this.IncludeTextBox.Multiline = true;
            this.IncludeTextBox.Name = "IncludeTextBox";
            this.IncludeTextBox.Size = new System.Drawing.Size(663, 75);
            this.IncludeTextBox.TabIndex = 2;
            this.IncludeTextBox.Text = "*.jpg, *..jpeg, *.png, *.gif, *.bmp, *.tif, *.tiff, *.raw, *.psd, *.svg, *.webp, " +
    "*.heic, *.mp4, *.avi, *.mkv, *.mov, *.wmv, *.flv, *.m4v, *.3gp,*. mpg, *.webm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Exclude :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Include :";
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.DataPropertyName = "FileName";
            this.FileNameColumn.HeaderText = "File Name";
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            // 
            // SourceFolderColumn
            // 
            this.SourceFolderColumn.DataPropertyName = "Folder";
            this.SourceFolderColumn.HeaderText = "Source";
            this.SourceFolderColumn.Name = "SourceFolderColumn";
            this.SourceFolderColumn.ReadOnly = true;
            // 
            // DestinationFolderColumn
            // 
            this.DestinationFolderColumn.DataPropertyName = "Destination";
            this.DestinationFolderColumn.HeaderText = "Destination";
            this.DestinationFolderColumn.Name = "DestinationFolderColumn";
            this.DestinationFolderColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "Date";
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // ExistsOnDestinationColumn
            // 
            this.ExistsOnDestinationColumn.DataPropertyName = "ExistsOnDestination";
            this.ExistsOnDestinationColumn.HeaderText = "ExistsOnDestination";
            this.ExistsOnDestinationColumn.Name = "ExistsOnDestinationColumn";
            this.ExistsOnDestinationColumn.ReadOnly = true;
            // 
            // DestinationFilePathColumn
            // 
            this.DestinationFilePathColumn.DataPropertyName = "DestinationFilePath";
            this.DestinationFilePathColumn.HeaderText = "DestinationFilePath";
            this.DestinationFilePathColumn.Name = "DestinationFilePathColumn";
            this.DestinationFilePathColumn.ReadOnly = true;
            // 
            // FileCopiedColumn
            // 
            this.FileCopiedColumn.DataPropertyName = "FileCopied";
            this.FileCopiedColumn.HeaderText = "FileCopied";
            this.FileCopiedColumn.Name = "FileCopiedColumn";
            this.FileCopiedColumn.ReadOnly = true;
            // 
            // FolderComparisonTabPage
            // 
            this.FolderComparisonTabPage.Location = new System.Drawing.Point(4, 22);
            this.FolderComparisonTabPage.Name = "FolderComparisonTabPage";
            this.FolderComparisonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FolderComparisonTabPage.Size = new System.Drawing.Size(1058, 602);
            this.FolderComparisonTabPage.TabIndex = 2;
            this.FolderComparisonTabPage.Text = "Folder Comparison";
            this.FolderComparisonTabPage.UseVisualStyleBackColor = true;
            // 
            // DublicateFileTabPage
            // 
            this.DublicateFileTabPage.Location = new System.Drawing.Point(4, 22);
            this.DublicateFileTabPage.Name = "DublicateFileTabPage";
            this.DublicateFileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DublicateFileTabPage.Size = new System.Drawing.Size(1058, 602);
            this.DublicateFileTabPage.TabIndex = 3;
            this.DublicateFileTabPage.Text = "DublicateFiles";
            this.DublicateFileTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 652);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "PictureMover";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGridView)).EndInit();
            this.GridContextMenuStrip.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.MainTabPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OptionsTabPage.ResumeLayout(false);
            this.OptionsTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceFolderTextBox;
        private System.Windows.Forms.TextBox DestinationFolderTextBox;
        private System.Windows.Forms.Button SelectSourceFolderButton;
        private System.Windows.Forms.Button SelectDestinationFolderButton;
        private System.Windows.Forms.Button DiscoverButton;
        private System.Windows.Forms.DataGridView FilesDataGridView;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ContextMenuStrip GridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllToolStripMenuItem;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabPage OptionsTabPage;
        private System.Windows.Forms.TextBox ExcludeTextBox;
        private System.Windows.Forms.TextBox IncludeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ExistsInTheTargetRadioButton;
        private System.Windows.Forms.RadioButton NotExistsInTargetRadioButton;
        private System.Windows.Forms.ComboBox DestinationFormatComboBox;
        private System.Windows.Forms.Label FilesDataGridViewSummaryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceFolderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationFolderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistsOnDestinationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationFilePathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileCopiedColumn;
        private System.Windows.Forms.TabPage FolderComparisonTabPage;
        private System.Windows.Forms.TabPage DublicateFileTabPage;
    }
}

