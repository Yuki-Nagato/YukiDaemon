namespace YukiDaemon {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            QuitToolStripMenuItem = new ToolStripMenuItem();
            MainSplitContainer = new SplitContainer();
            ProfilesDataGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddProfileButton = new Button();
            DeleteProfileButton = new Button();
            SaveButton = new Button();
            label1 = new Label();
            profileEditor1 = new ProfileEditor();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilesDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1905, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { QuitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(65, 32);
            fileToolStripMenuItem.Text = "&File";
            // 
            // QuitToolStripMenuItem
            // 
            QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            QuitToolStripMenuItem.Size = new Size(173, 40);
            QuitToolStripMenuItem.Text = "&Quit";
            QuitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.BorderStyle = BorderStyle.FixedSingle;
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(0, 38);
            MainSplitContainer.Margin = new Padding(4);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(ProfilesDataGridView);
            MainSplitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            MainSplitContainer.Panel1.Controls.Add(label1);
            MainSplitContainer.Panel1.Padding = new Padding(4);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(profileEditor1);
            MainSplitContainer.Size = new Size(1905, 1013);
            MainSplitContainer.SplitterDistance = 732;
            MainSplitContainer.SplitterWidth = 6;
            MainSplitContainer.TabIndex = 1;
            // 
            // ProfilesDataGridView
            // 
            ProfilesDataGridView.AllowUserToAddRows = false;
            ProfilesDataGridView.AllowUserToDeleteRows = false;
            ProfilesDataGridView.AllowUserToOrderColumns = true;
            ProfilesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProfilesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProfilesDataGridView.BackgroundColor = SystemColors.Control;
            ProfilesDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ProfilesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfilesDataGridView.Location = new Point(4, 94);
            ProfilesDataGridView.Margin = new Padding(0, 4, 0, 0);
            ProfilesDataGridView.Name = "ProfilesDataGridView";
            ProfilesDataGridView.ReadOnly = true;
            ProfilesDataGridView.RowHeadersVisible = false;
            ProfilesDataGridView.RowHeadersWidth = 51;
            ProfilesDataGridView.RowTemplate.Height = 29;
            ProfilesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProfilesDataGridView.Size = new Size(722, 909);
            ProfilesDataGridView.TabIndex = 2;
            ProfilesDataGridView.CellContentClick += ProfilesDataGridView_CellContentClick;
            ProfilesDataGridView.RowsAdded += ProfilesDataGridView_RowsAdded;
            ProfilesDataGridView.SelectionChanged += ProfilesDataGridView_SelectionChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(AddProfileButton, 1, 0);
            tableLayoutPanel1.Controls.Add(DeleteProfileButton, 2, 0);
            tableLayoutPanel1.Controls.Add(SaveButton, 0, 0);
            tableLayoutPanel1.Location = new Point(4, 36);
            tableLayoutPanel1.Margin = new Padding(0, 4, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(722, 53);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // AddProfileButton
            // 
            AddProfileButton.Dock = DockStyle.Fill;
            AddProfileButton.Location = new Point(244, 4);
            AddProfileButton.Margin = new Padding(4);
            AddProfileButton.Name = "AddProfileButton";
            AddProfileButton.Size = new Size(232, 45);
            AddProfileButton.TabIndex = 0;
            AddProfileButton.Text = "New Profile";
            AddProfileButton.UseVisualStyleBackColor = true;
            AddProfileButton.Click += AddProfileButton_Click;
            // 
            // DeleteProfileButton
            // 
            DeleteProfileButton.Dock = DockStyle.Fill;
            DeleteProfileButton.Enabled = false;
            DeleteProfileButton.Location = new Point(484, 4);
            DeleteProfileButton.Margin = new Padding(4);
            DeleteProfileButton.Name = "DeleteProfileButton";
            DeleteProfileButton.Size = new Size(234, 45);
            DeleteProfileButton.TabIndex = 1;
            DeleteProfileButton.Text = "Delete Profiles...";
            DeleteProfileButton.UseVisualStyleBackColor = true;
            DeleteProfileButton.Click += DeleteProfileButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Location = new Point(4, 4);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(232, 45);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 0;
            label1.Text = "Profiles";
            // 
            // profileEditor1
            // 
            profileEditor1.Dock = DockStyle.Fill;
            profileEditor1.Location = new Point(0, 0);
            profileEditor1.Margin = new Padding(6);
            profileEditor1.Name = "profileEditor1";
            profileEditor1.Size = new Size(1165, 1011);
            profileEditor1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1905, 1051);
            Controls.Add(MainSplitContainer);
            Controls.Add(menuStrip1);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Yuki Daemon";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel1.PerformLayout();
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProfilesDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem QuitToolStripMenuItem;
        private SplitContainer MainSplitContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddProfileButton;
        private Button DeleteProfileButton;
        private Label label1;
        private Button SaveButton;
        private DataGridView ProfilesDataGridView;
        private ProfileEditor profileEditor1;
    }
}
