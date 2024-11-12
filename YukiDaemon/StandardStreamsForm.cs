using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YukiDaemon {
    public partial class StandardStreamsForm : Form {
        private readonly ConcurrentQueue<byte[]>? stdoutBytesQueue;
        private readonly ConcurrentQueue<byte[]>? stderrBytesQueue;
        private readonly List<string>? stdinList;
        public Stream? Stdin { get; set; }
        private readonly EncodingInfo[] encodings = Encoding.GetEncodings();

        public StandardStreamsForm() {
            InitializeComponent();
        }

        public StandardStreamsForm(ConcurrentQueue<byte[]>? stdoutBytesQueue, ConcurrentQueue<byte[]>? stderrBytesQueue, List<string>? stdinList, Stream? stdin) : this() {
            this.stdoutBytesQueue = stdoutBytesQueue;
            this.stderrBytesQueue = stderrBytesQueue;
            this.stdinList = stdinList;
            this.Stdin = stdin;
        }

        private void StandardStreamsForm_Load(object sender, EventArgs e) {
            StdoutEncodingComboBox.DisplayMember = nameof(EncodingInfo.DisplayName);
            StdoutEncodingComboBox.Items.AddRange(encodings);
            StdoutEncodingComboBox.SelectedItem = encodings.First(encoding => encoding.CodePage == 65001);
            StderrEncodingComboBox.DisplayMember = nameof(EncodingInfo.DisplayName);
            StderrEncodingComboBox.Items.AddRange(encodings);
            StderrEncodingComboBox.SelectedItem = encodings.First(encoding => encoding.CodePage == 65001);
            StdinInputEncodingComboBox.DisplayMember = nameof(EncodingInfo.DisplayName);
            StdinInputEncodingComboBox.Items.AddRange(encodings);
            StdinInputEncodingComboBox.SelectedItem = encodings.First(encoding => encoding.CodePage == 65001);
            if (stdinList != null) {
                StdinTextBox.Text = string.Join("", stdinList);
            }
        }

        public void UpdateStdout() {
            if (stdoutBytesQueue == null) {
                return;
            }
            EncodingInfo encoding = (EncodingInfo)StdoutEncodingComboBox.SelectedItem;
            MemoryStream memoryStream = new();
            foreach (byte[] bytes in stdoutBytesQueue) {
                memoryStream.Write(bytes);
            }
            StdoutTextBox.Text = encoding.GetEncoding().GetString(memoryStream.ToArray());
        }

        public void UpdateStderr() {
            if (stderrBytesQueue == null) {
                return;
            }
            EncodingInfo encoding = (EncodingInfo)StderrEncodingComboBox.SelectedItem;
            MemoryStream memoryStream = new();
            foreach (byte[] bytes in stderrBytesQueue) {
                memoryStream.Write(bytes);
            }
            StderrTextBox.Text = encoding.GetEncoding().GetString(memoryStream.ToArray());
        }

        public void UpdateStdin() {
            if (stdinList == null) {
                return;
            }
            StdinTextBox.Text = string.Join("", stdinList);
        }

        private void StdoutEncodingComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateStdout();
        }

        private void StderrEncodingComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateStderr();
        }

        private void SendButton_Click(object sender, EventArgs e) {
            EncodingInfo encoding = (EncodingInfo)StdinInputEncodingComboBox.SelectedItem;
            byte[] bytes = encoding.GetEncoding().GetBytes(StdinInputTextBox.Text);
            Stdin?.Write(bytes);
            Stdin?.Flush();
            stdinList?.Add(StdinInputTextBox.Text);
            StdinTextBox.AppendText(StdinInputTextBox.Text);
            StdinInputTextBox.Clear();
        }


        private void StdinInputTextBox_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                SendButton_Click(sender, e);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Stdin?.Dispose();
        }
    }
}
