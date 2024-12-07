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
            tableLayoutPanel2 = new TableLayoutPanel();
            ProfilesDataGridView = new DataGridView();
            DeleteProfileButton = new Button();
            AddProfileButton = new Button();
            label1 = new Label();
            SaveButton = new Button();
            profileEditor1 = new ProfileEditor();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1026, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { QuitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 21);
            fileToolStripMenuItem.Text = "&File";
            // 
            // QuitToolStripMenuItem
            // 
            QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            QuitToolStripMenuItem.Size = new Size(100, 22);
            QuitToolStripMenuItem.Text = "&Quit";
            QuitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.BorderStyle = BorderStyle.FixedSingle;
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(0, 25);
            MainSplitContainer.Margin = new Padding(2);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(tableLayoutPanel2);
            MainSplitContainer.Panel1.Padding = new Padding(2);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(profileEditor1);
            MainSplitContainer.Size = new Size(1026, 613);
            MainSplitContainer.SplitterDistance = 394;
            MainSplitContainer.SplitterWidth = 3;
            MainSplitContainer.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(DeleteProfileButton, 2, 1);
            tableLayoutPanel2.Controls.Add(ProfilesDataGridView, 0, 2);
            tableLayoutPanel2.Controls.Add(AddProfileButton, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(SaveButton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(388, 607);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // ProfilesDataGridView
            // 
            ProfilesDataGridView.AllowUserToAddRows = false;
            ProfilesDataGridView.AllowUserToDeleteRows = false;
            ProfilesDataGridView.AllowUserToOrderColumns = true;
            ProfilesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProfilesDataGridView.BackgroundColor = SystemColors.Control;
            ProfilesDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ProfilesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(ProfilesDataGridView, 3);
            ProfilesDataGridView.Dock = DockStyle.Fill;
            ProfilesDataGridView.Location = new Point(0, 70);
            ProfilesDataGridView.Margin = new Padding(0, 2, 0, 0);
            ProfilesDataGridView.Name = "ProfilesDataGridView";
            ProfilesDataGridView.ReadOnly = true;
            ProfilesDataGridView.RowHeadersVisible = false;
            ProfilesDataGridView.RowHeadersWidth = 51;
            ProfilesDataGridView.RowTemplate.Height = 29;
            ProfilesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProfilesDataGridView.Size = new Size(388, 537);
            ProfilesDataGridView.TabIndex = 2;
            ProfilesDataGridView.CellContentClick += ProfilesDataGridView_CellContentClick;
            ProfilesDataGridView.RowsAdded += ProfilesDataGridView_RowsAdded;
            ProfilesDataGridView.SelectionChanged += ProfilesDataGridView_SelectionChanged;
            // 
            // DeleteProfileButton
            // 
            DeleteProfileButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeleteProfileButton.Enabled = false;
            DeleteProfileButton.Location = new Point(260, 36);
            DeleteProfileButton.Margin = new Padding(2);
            DeleteProfileButton.Name = "DeleteProfileButton";
            DeleteProfileButton.Size = new Size(126, 30);
            DeleteProfileButton.TabIndex = 1;
            DeleteProfileButton.Text = "Delete Profiles...";
            DeleteProfileButton.UseVisualStyleBackColor = true;
            DeleteProfileButton.Click += DeleteProfileButton_Click;
            // 
            // AddProfileButton
            // 
            AddProfileButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddProfileButton.Location = new Point(131, 36);
            AddProfileButton.Margin = new Padding(2);
            AddProfileButton.Name = "AddProfileButton";
            AddProfileButton.Size = new Size(125, 30);
            AddProfileButton.TabIndex = 0;
            AddProfileButton.Text = "New Profile";
            AddProfileButton.UseVisualStyleBackColor = true;
            AddProfileButton.Click += AddProfileButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(2, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "Profiles";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.Location = new Point(2, 36);
            SaveButton.Margin = new Padding(2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(125, 30);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // profileEditor1
            // 
            profileEditor1.Dock = DockStyle.Fill;
            profileEditor1.Location = new Point(0, 0);
            profileEditor1.Margin = new Padding(3, 4, 3, 4);
            profileEditor1.Name = "profileEditor1";
            profileEditor1.Size = new Size(627, 611);
            profileEditor1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 638);
            Controls.Add(MainSplitContainer);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Yuki Daemon";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem QuitToolStripMenuItem;
        private SplitContainer MainSplitContainer;
        private Button AddProfileButton;
        private Button DeleteProfileButton;
        private Label label1;
        private Button SaveButton;
        private DataGridView ProfilesDataGridView;
        private ProfileEditor profileEditor1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
