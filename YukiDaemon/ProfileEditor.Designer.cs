namespace YukiDaemon {
    partial class ProfileEditor {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            ArgumentsTextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            NameTextBox = new TextBox();
            FileNameTextBox = new TextBox();
            FileNameSelectButton = new Button();
            label4 = new Label();
            WorkingDirectoryTextBox = new TextBox();
            WorkingDirectoryBrowseButton = new Button();
            label5 = new Label();
            EnvironmentDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ValueColumn = new DataGridViewTextBoxColumn();
            AutoStartCheckBox = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            StartButton = new Button();
            KillButton = new Button();
            StateLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            UseShellExecuteCheckBox = new CheckBox();
            CreateNoWindowCheckBox = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label7 = new Label();
            AfterStoppedComboBox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            DelayForSecondsNumericUpDown = new NumericUpDown();
            StandardStreamsButton = new Button();
            CountdownTimer = new System.Windows.Forms.Timer(components);
            FileNameOpenFileDialog = new OpenFileDialog();
            WorkingDirectoryFolderBrowserDialog = new FolderBrowserDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EnvironmentDataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DelayForSecondsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(ArgumentsTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(NameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(FileNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(FileNameSelectButton, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(WorkingDirectoryTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(WorkingDirectoryBrowseButton, 2, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(EnvironmentDataGridView, 1, 4);
            tableLayoutPanel1.Controls.Add(AutoStartCheckBox, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 8);
            tableLayoutPanel1.Controls.Add(StateLabel, 0, 9);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 7);
            tableLayoutPanel1.Controls.Add(StandardStreamsButton, 2, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(622, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ArgumentsTextBox
            // 
            ArgumentsTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(ArgumentsTextBox, 2);
            ArgumentsTextBox.Location = new Point(121, 73);
            ArgumentsTextBox.Margin = new Padding(2, 3, 2, 3);
            ArgumentsTextBox.Name = "ArgumentsTextBox";
            ArgumentsTextBox.Size = new Size(499, 23);
            ArgumentsTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(2, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 5;
            label3.Text = "Arguments";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(2, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "Profile Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(2, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "File Name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(NameTextBox, 2);
            NameTextBox.Location = new Point(121, 5);
            NameTextBox.Margin = new Padding(2, 3, 2, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(499, 23);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FileNameTextBox.Location = new Point(121, 39);
            FileNameTextBox.Margin = new Padding(2, 3, 2, 3);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(327, 23);
            FileNameTextBox.TabIndex = 3;
            // 
            // FileNameSelectButton
            // 
            FileNameSelectButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FileNameSelectButton.AutoSize = true;
            FileNameSelectButton.Location = new Point(452, 37);
            FileNameSelectButton.Margin = new Padding(2, 3, 2, 3);
            FileNameSelectButton.Name = "FileNameSelectButton";
            FileNameSelectButton.Size = new Size(168, 28);
            FileNameSelectButton.TabIndex = 4;
            FileNameSelectButton.Text = "Select...";
            FileNameSelectButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(2, 110);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 17);
            label4.TabIndex = 6;
            label4.Text = "Working Directory";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WorkingDirectoryTextBox
            // 
            WorkingDirectoryTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            WorkingDirectoryTextBox.Location = new Point(121, 107);
            WorkingDirectoryTextBox.Margin = new Padding(2, 3, 2, 3);
            WorkingDirectoryTextBox.Name = "WorkingDirectoryTextBox";
            WorkingDirectoryTextBox.Size = new Size(327, 23);
            WorkingDirectoryTextBox.TabIndex = 8;
            // 
            // WorkingDirectoryBrowseButton
            // 
            WorkingDirectoryBrowseButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            WorkingDirectoryBrowseButton.AutoSize = true;
            WorkingDirectoryBrowseButton.Location = new Point(452, 105);
            WorkingDirectoryBrowseButton.Margin = new Padding(2, 3, 2, 3);
            WorkingDirectoryBrowseButton.Name = "WorkingDirectoryBrowseButton";
            WorkingDirectoryBrowseButton.Size = new Size(168, 28);
            WorkingDirectoryBrowseButton.TabIndex = 9;
            WorkingDirectoryBrowseButton.Text = "Browse...";
            WorkingDirectoryBrowseButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(2, 229);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 10;
            label5.Text = "Environment";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EnvironmentDataGridView
            // 
            EnvironmentDataGridView.AllowUserToOrderColumns = true;
            EnvironmentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EnvironmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EnvironmentDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ValueColumn });
            tableLayoutPanel1.SetColumnSpan(EnvironmentDataGridView, 2);
            EnvironmentDataGridView.Dock = DockStyle.Fill;
            EnvironmentDataGridView.Location = new Point(121, 139);
            EnvironmentDataGridView.Margin = new Padding(2, 3, 2, 3);
            EnvironmentDataGridView.Name = "EnvironmentDataGridView";
            EnvironmentDataGridView.RowHeadersWidth = 51;
            EnvironmentDataGridView.RowTemplate.Height = 29;
            EnvironmentDataGridView.Size = new Size(499, 198);
            EnvironmentDataGridView.TabIndex = 11;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            // 
            // ValueColumn
            // 
            ValueColumn.HeaderText = "Value";
            ValueColumn.MinimumWidth = 6;
            ValueColumn.Name = "ValueColumn";
            // 
            // AutoStartCheckBox
            // 
            AutoStartCheckBox.Anchor = AnchorStyles.Left;
            AutoStartCheckBox.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(AutoStartCheckBox, 3);
            AutoStartCheckBox.Location = new Point(2, 380);
            AutoStartCheckBox.Margin = new Padding(2, 3, 2, 3);
            AutoStartCheckBox.Name = "AutoStartCheckBox";
            AutoStartCheckBox.Size = new Size(244, 21);
            AutoStartCheckBox.TabIndex = 13;
            AutoStartCheckBox.Text = "Auto start after Yuki Daemon started.";
            AutoStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(StartButton, 0, 0);
            tableLayoutPanel2.Controls.Add(KillButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 442);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(622, 34);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // StartButton
            // 
            StartButton.Dock = DockStyle.Fill;
            StartButton.Location = new Point(2, 3);
            StartButton.Margin = new Padding(2, 3, 2, 3);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(307, 28);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // KillButton
            // 
            KillButton.Dock = DockStyle.Fill;
            KillButton.Enabled = false;
            KillButton.Location = new Point(313, 3);
            KillButton.Margin = new Padding(2, 3, 2, 3);
            KillButton.Name = "KillButton";
            KillButton.Size = new Size(307, 28);
            KillButton.TabIndex = 1;
            KillButton.Text = "Kill";
            KillButton.UseVisualStyleBackColor = true;
            KillButton.Click += KillButton_Click;
            // 
            // StateLabel
            // 
            StateLabel.Anchor = AnchorStyles.Left;
            StateLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(StateLabel, 2);
            StateLabel.Location = new Point(2, 484);
            StateLabel.Margin = new Padding(2, 0, 2, 0);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(114, 17);
            StateLabel.TabIndex = 16;
            StateLabel.Text = "State: Not started.";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(UseShellExecuteCheckBox, 0, 0);
            tableLayoutPanel3.Controls.Add(CreateNoWindowCheckBox, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 340);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(622, 34);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // UseShellExecuteCheckBox
            // 
            UseShellExecuteCheckBox.Anchor = AnchorStyles.Left;
            UseShellExecuteCheckBox.AutoSize = true;
            UseShellExecuteCheckBox.Location = new Point(2, 6);
            UseShellExecuteCheckBox.Margin = new Padding(2, 3, 2, 3);
            UseShellExecuteCheckBox.Name = "UseShellExecuteCheckBox";
            UseShellExecuteCheckBox.Size = new Size(128, 21);
            UseShellExecuteCheckBox.TabIndex = 0;
            UseShellExecuteCheckBox.Text = "Use Shell Execute";
            UseShellExecuteCheckBox.UseVisualStyleBackColor = true;
            UseShellExecuteCheckBox.CheckedChanged += UseShellExecuteCheckBox_CheckedChanged;
            // 
            // CreateNoWindowCheckBox
            // 
            CreateNoWindowCheckBox.Anchor = AnchorStyles.Left;
            CreateNoWindowCheckBox.AutoSize = true;
            CreateNoWindowCheckBox.Checked = true;
            CreateNoWindowCheckBox.CheckState = CheckState.Checked;
            CreateNoWindowCheckBox.Location = new Point(134, 6);
            CreateNoWindowCheckBox.Margin = new Padding(2, 3, 2, 3);
            CreateNoWindowCheckBox.Name = "CreateNoWindowCheckBox";
            CreateNoWindowCheckBox.Size = new Size(138, 21);
            CreateNoWindowCheckBox.TabIndex = 1;
            CreateNoWindowCheckBox.Text = "Create No Window";
            CreateNoWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 3);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Controls.Add(AfterStoppedComboBox, 1, 0);
            tableLayoutPanel4.Controls.Add(label8, 2, 0);
            tableLayoutPanel4.Controls.Add(label9, 4, 0);
            tableLayoutPanel4.Controls.Add(DelayForSecondsNumericUpDown, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 408);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(622, 34);
            tableLayoutPanel4.TabIndex = 18;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(2, 8);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 0;
            label7.Text = "After stopped";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AfterStoppedComboBox
            // 
            AfterStoppedComboBox.Anchor = AnchorStyles.Left;
            AfterStoppedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AfterStoppedComboBox.FormattingEnabled = true;
            AfterStoppedComboBox.Items.AddRange(new object[] { "do nothing", "restart" });
            AfterStoppedComboBox.Location = new Point(95, 4);
            AfterStoppedComboBox.Margin = new Padding(2, 3, 2, 3);
            AfterStoppedComboBox.Name = "AfterStoppedComboBox";
            AfterStoppedComboBox.Size = new Size(149, 25);
            AfterStoppedComboBox.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(248, 8);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 17);
            label8.TabIndex = 2;
            label8.Text = ", delay for";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(423, 8);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 3;
            label9.Text = "seconds.";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DelayForSecondsNumericUpDown
            // 
            DelayForSecondsNumericUpDown.Anchor = AnchorStyles.Left;
            DelayForSecondsNumericUpDown.Location = new Point(319, 5);
            DelayForSecondsNumericUpDown.Margin = new Padding(2, 3, 2, 3);
            DelayForSecondsNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            DelayForSecondsNumericUpDown.Name = "DelayForSecondsNumericUpDown";
            DelayForSecondsNumericUpDown.Size = new Size(100, 23);
            DelayForSecondsNumericUpDown.TabIndex = 4;
            DelayForSecondsNumericUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // StandardStreamsButton
            // 
            StandardStreamsButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StandardStreamsButton.AutoSize = true;
            StandardStreamsButton.Location = new Point(452, 479);
            StandardStreamsButton.Margin = new Padding(2, 3, 2, 3);
            StandardStreamsButton.Name = "StandardStreamsButton";
            StandardStreamsButton.Size = new Size(168, 28);
            StandardStreamsButton.TabIndex = 19;
            StandardStreamsButton.Text = "Standard Streams...";
            StandardStreamsButton.UseVisualStyleBackColor = true;
            StandardStreamsButton.Click += StandardStreamsButton_Click;
            // 
            // CountdownTimer
            // 
            CountdownTimer.Interval = 1000;
            CountdownTimer.Tick += CountdownTimer_Tick;
            // 
            // ProfileEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ProfileEditor";
            Size = new Size(622, 510);
            Load += ProfileEditor_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EnvironmentDataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DelayForSecondsNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox NameTextBox;
        private TextBox FileNameTextBox;
        private Button FileNameSelectButton;
        private Label label3;
        private Label label4;
        private TextBox ArgumentsTextBox;
        private TextBox WorkingDirectoryTextBox;
        private Button WorkingDirectoryBrowseButton;
        private Label label5;
        private DataGridView EnvironmentDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ValueColumn;
        private CheckBox AutoStartCheckBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button StartButton;
        private Button KillButton;
        private Label StateLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox UseShellExecuteCheckBox;
        private CheckBox CreateNoWindowCheckBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private ComboBox AfterStoppedComboBox;
        private Label label8;
        private Label label9;
        private NumericUpDown DelayForSecondsNumericUpDown;
        private Button StandardStreamsButton;
        private System.Windows.Forms.Timer CountdownTimer;
        private OpenFileDialog FileNameOpenFileDialog;
        private FolderBrowserDialog WorkingDirectoryFolderBrowserDialog;
    }
}
