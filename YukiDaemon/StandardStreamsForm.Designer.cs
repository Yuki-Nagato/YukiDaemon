namespace YukiDaemon {
    partial class StandardStreamsForm {
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label4 = new Label();
            StdoutEncodingComboBox = new ComboBox();
            StdoutTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label5 = new Label();
            StderrEncodingComboBox = new ComboBox();
            StderrTextBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            StdinTextBox = new TextBox();
            SendButton = new Button();
            StdinInputTextBox = new TextBox();
            StdinInputEncodingComboBox = new ComboBox();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer1.Size = new Size(1262, 673);
            splitContainer1.SplitterDistance = 840;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer2.Size = new Size(840, 673);
            splitContainer2.SplitterDistance = 418;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(StdoutEncodingComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(StdoutTextBox, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(414, 669);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(408, 20);
            label1.TabIndex = 0;
            label1.Text = "Standard Output";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 44);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 1;
            label4.Text = "Encoding";
            // 
            // StdoutEncodingComboBox
            // 
            StdoutEncodingComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StdoutEncodingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StdoutEncodingComboBox.FormattingEnabled = true;
            StdoutEncodingComboBox.Location = new Point(86, 40);
            StdoutEncodingComboBox.Name = "StdoutEncodingComboBox";
            StdoutEncodingComboBox.Size = new Size(325, 28);
            StdoutEncodingComboBox.TabIndex = 2;
            StdoutEncodingComboBox.SelectedIndexChanged += StdoutEncodingComboBox_SelectedIndexChanged;
            // 
            // StdoutTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(StdoutTextBox, 2);
            StdoutTextBox.Dock = DockStyle.Fill;
            StdoutTextBox.Location = new Point(3, 75);
            StdoutTextBox.Multiline = true;
            StdoutTextBox.Name = "StdoutTextBox";
            StdoutTextBox.ReadOnly = true;
            StdoutTextBox.ScrollBars = ScrollBars.Vertical;
            StdoutTextBox.Size = new Size(408, 591);
            StdoutTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(StderrEncodingComboBox, 1, 1);
            tableLayoutPanel2.Controls.Add(StderrTextBox, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(414, 669);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            tableLayoutPanel2.SetColumnSpan(label2, 2);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(408, 20);
            label2.TabIndex = 0;
            label2.Text = "Standard Error";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 44);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 1;
            label5.Text = "Encoding";
            // 
            // StderrEncodingComboBox
            // 
            StderrEncodingComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StderrEncodingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StderrEncodingComboBox.FormattingEnabled = true;
            StderrEncodingComboBox.Location = new Point(86, 40);
            StderrEncodingComboBox.Name = "StderrEncodingComboBox";
            StderrEncodingComboBox.Size = new Size(325, 28);
            StderrEncodingComboBox.TabIndex = 2;
            StderrEncodingComboBox.SelectedIndexChanged += StderrEncodingComboBox_SelectedIndexChanged;
            // 
            // StderrTextBox
            // 
            tableLayoutPanel2.SetColumnSpan(StderrTextBox, 2);
            StderrTextBox.Dock = DockStyle.Fill;
            StderrTextBox.Location = new Point(3, 75);
            StderrTextBox.Multiline = true;
            StderrTextBox.Name = "StderrTextBox";
            StderrTextBox.ReadOnly = true;
            StderrTextBox.ScrollBars = ScrollBars.Vertical;
            StderrTextBox.Size = new Size(408, 591);
            StderrTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(StdinTextBox, 0, 1);
            tableLayoutPanel3.Controls.Add(SendButton, 1, 3);
            tableLayoutPanel3.Controls.Add(StdinInputTextBox, 0, 3);
            tableLayoutPanel3.Controls.Add(StdinInputEncodingComboBox, 0, 2);
            tableLayoutPanel3.Controls.Add(CloseButton, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(414, 669);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            tableLayoutPanel3.SetColumnSpan(label3, 2);
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(408, 20);
            label3.TabIndex = 0;
            label3.Text = "Standard Input";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StdinTextBox
            // 
            tableLayoutPanel3.SetColumnSpan(StdinTextBox, 2);
            StdinTextBox.Dock = DockStyle.Fill;
            StdinTextBox.Location = new Point(3, 39);
            StdinTextBox.Multiline = true;
            StdinTextBox.Name = "StdinTextBox";
            StdinTextBox.ReadOnly = true;
            StdinTextBox.ScrollBars = ScrollBars.Vertical;
            StdinTextBox.Size = new Size(408, 392);
            StdinTextBox.TabIndex = 1;
            // 
            // SendButton
            // 
            SendButton.Dock = DockStyle.Fill;
            SendButton.Location = new Point(317, 473);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 193);
            SendButton.TabIndex = 4;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // StdinInputTextBox
            // 
            StdinInputTextBox.Dock = DockStyle.Fill;
            StdinInputTextBox.Location = new Point(3, 473);
            StdinInputTextBox.Multiline = true;
            StdinInputTextBox.Name = "StdinInputTextBox";
            StdinInputTextBox.ScrollBars = ScrollBars.Vertical;
            StdinInputTextBox.Size = new Size(308, 193);
            StdinInputTextBox.TabIndex = 2;
            StdinInputTextBox.KeyUp += StdinInputTextBox_KeyUp;
            // 
            // StdinInputEncodingComboBox
            // 
            StdinInputEncodingComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StdinInputEncodingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StdinInputEncodingComboBox.FormattingEnabled = true;
            StdinInputEncodingComboBox.Location = new Point(3, 438);
            StdinInputEncodingComboBox.Name = "StdinInputEncodingComboBox";
            StdinInputEncodingComboBox.Size = new Size(308, 28);
            StdinInputEncodingComboBox.TabIndex = 3;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CloseButton.Location = new Point(317, 437);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 5;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // StandardStreamsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(splitContainer1);
            Name = "StandardStreamsForm";
            Text = "Standard Streams - Profile";
            Load += StandardStreamsForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label4;
        private ComboBox StdoutEncodingComboBox;
        private TextBox StdoutTextBox;
        private Label label2;
        private Label label5;
        private ComboBox StderrEncodingComboBox;
        private TextBox StderrTextBox;
        private Label label3;
        private TextBox StdinTextBox;
        private ComboBox StdinInputEncodingComboBox;
        private Button SendButton;
        private TextBox StdinInputTextBox;
        private Button CloseButton;
    }
}