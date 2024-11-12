using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace YukiDaemon {
    public partial class ProfileEditor : UserControl, INotifyPropertyChanged {
        private StandardStreamsForm? standardStreamsForm;
        private Process? process;
        private ConcurrentQueue<byte[]>? stdoutBytesQueue;
        private ConcurrentQueue<byte[]>? stderrBytesQueue;
        private List<string>? stdinList;
        private bool manuallyKilled = false;

        public ProfileEditor() {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Disposed += ProfileEditor_Disposed;
        }

        private void ProfileEditor_Disposed(object? sender, EventArgs e) {
            process?.Kill(true);
            process?.WaitForExit();
            //process?.Dispose();
            standardStreamsForm?.Dispose();
        }

        public ProfileEditor(string Name) : this() {
            NameTextBox.Text = Name;
        }

        public ProfileEditor(Profile profile) : this() {
            NameTextBox.Text = profile.Name;
            FileNameTextBox.Text = profile.FileName;
            ArgumentsTextBox.Text = profile.Arguments;
            WorkingDirectoryTextBox.Text = profile.WorkingDirectory;
            foreach (KeyValuePair<string, string> keyValuePair in profile.Environment) {
                EnvironmentDataGridView.Rows.Add(keyValuePair.Key, keyValuePair.Value);
            }
            UseShellExecuteCheckBox.Checked = profile.UseShellExecute;
            CreateNoWindowCheckBox.Checked = profile.CreateNoWindow;
            AutoStartCheckBox.Checked = profile.AutoStart;
            AfterStoppedComboBox.SelectedIndex = profile.AfterStopped;
            DelayForSecondsNumericUpDown.Value = profile.DelayForSeconds;
        }

        public Profile Profile => new(
            NameTextBox.Text,
            FileNameTextBox.Text,
            ArgumentsTextBox.Text,
            WorkingDirectoryTextBox.Text,
            EnvironmentDataGridView.Rows.Cast<DataGridViewRow>().Where(row => row.Cells["NameColumn"].Value != null).Select(row => new KeyValuePair<string, string>((string)row.Cells["NameColumn"].Value, (string)row.Cells["ValueColumn"].Value)).ToList(),
            UseShellExecuteCheckBox.Checked,
            CreateNoWindowCheckBox.Checked,
            AutoStartCheckBox.Checked,
            AfterStoppedComboBox.SelectedIndex,
            DelayForSecondsNumericUpDown.Value
        );

        public string ProfileName => NameTextBox.Text;

        public bool AutoStart => AutoStartCheckBox.Checked;

        public string State {
            get {
                if (process == null) {
                    return "Not started.";
                }
                else if (process.HasExited) {
                    if (CountdownTimer.Enabled) {
                        return $"Exited. PID: {process.Id}. Exit code: {process.ExitCode}. Countdown: {CountdownTimer.Tag}.";
                    }
                    else {
                        return $"Exited. PID: {process.Id}. Exit code: {process.ExitCode}.";
                    }
                }
                else {
                    return $"Running. PID: {process.Id}.";
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            // real OnPropertyChanged
            var work = () => {
                StateLabel.Text = "State: " + State;
                StartButton.Enabled = (process == null || process.HasExited) && !CountdownTimer.Enabled;
                KillButton.Enabled = process != null && !process.HasExited || CountdownTimer.Enabled;
            };
            if (propertyName == nameof(State)) {
                if (InvokeRequired) {
                    Invoke(work);
                }
                else {
                    work();
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e) {
            OnPropertyChanged(nameof(ProfileName));
        }

        private void StandardStreamsButton_Click(object sender, EventArgs e) {
            if (standardStreamsForm == null) {
                if (process != null && process.StartInfo.RedirectStandardInput) {
                    standardStreamsForm = new(stdoutBytesQueue, stderrBytesQueue, stdinList, process?.StandardInput.BaseStream);
                }
                else {
                    standardStreamsForm = new();
                }
                standardStreamsForm.FormClosing += (_, _) => standardStreamsForm = null;
                standardStreamsForm.Show(this);
            }
            else {
                standardStreamsForm.Activate();
            }
        }

        public void StartProcess() {
            manuallyKilled = false;

            if (process != null && !process.HasExited) {
                throw new Exception("Start process failed because the last process has not exited.");
            }
            process?.Dispose();

            ProcessStartInfo processStartInfo = new();
            processStartInfo.FileName = FileNameTextBox.Text;
            processStartInfo.Arguments = ArgumentsTextBox.Text;
            processStartInfo.WorkingDirectory = WorkingDirectoryTextBox.Text;
            foreach (DataGridViewRow row in EnvironmentDataGridView.Rows) {
                if (row.Cells["NameColumn"].Value != null) {
                    processStartInfo.Environment.Add((string)row.Cells["NameColumn"].Value, (string)row.Cells["ValueColumn"].Value);
                }
            }
            processStartInfo.UseShellExecute = UseShellExecuteCheckBox.Checked;
            processStartInfo.CreateNoWindow = CreateNoWindowCheckBox.Checked;
            processStartInfo.RedirectStandardInput = !UseShellExecuteCheckBox.Checked;
            processStartInfo.RedirectStandardOutput = !UseShellExecuteCheckBox.Checked;
            processStartInfo.RedirectStandardError = !UseShellExecuteCheckBox.Checked;
            try {
                process = Process.Start(processStartInfo);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error Starting Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (process == null) {
                MessageBox.Show("Starting process failed.", "Error Starting Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OnPropertyChanged(nameof(State));
            process.EnableRaisingEvents = true;
            process.Exited += Process_Exited;
            if (stdoutBytesQueue == null) {
                stdoutBytesQueue = new();
            }
            else {
                stdoutBytesQueue.Clear();
            }
            standardStreamsForm?.Invoke(standardStreamsForm.UpdateStdout);
            if (stderrBytesQueue == null) {
                stderrBytesQueue = new();
            }
            else {
                stderrBytesQueue.Clear();
            }
            standardStreamsForm?.Invoke(standardStreamsForm.UpdateStderr);
            if (stdinList == null) {
                stdinList = new();
            }
            else {
                stdinList.Clear();
            }
            standardStreamsForm?.Invoke(standardStreamsForm.UpdateStdin);
            if (processStartInfo.RedirectStandardOutput) {
                Task.Run(() => {
                    Stream stdout = process.StandardOutput.BaseStream;
                    byte[] buf = new byte[1024 * 1024];
                    int len;
                    while ((len = stdout.Read(buf)) > 0) {
                        byte[] copy = new byte[len];
                        Array.Copy(buf, copy, len);
                        stdoutBytesQueue.Enqueue(copy);
                        while (stdoutBytesQueue.Count > 10000) {
                            stdoutBytesQueue.TryDequeue(out _);
                        }
                        try {
                            standardStreamsForm?.Invoke(standardStreamsForm.UpdateStdout);
                        }
                        catch (ObjectDisposedException ex) {
                            Debug.WriteLine(ex.Message);
                        }
                    }
                });
            }
            if (processStartInfo.RedirectStandardError) {
                Task.Run(() => {
                    Stream stderr = process.StandardError.BaseStream;
                    byte[] buf = new byte[1024 * 1024];
                    int len;
                    while ((len = stderr.Read(buf)) > 0) {
                        byte[] copy = new byte[len];
                        Array.Copy(buf, copy, len);
                        stderrBytesQueue.Enqueue(copy);
                        while (stderrBytesQueue.Count > 10000) {
                            stderrBytesQueue.TryDequeue(out _);
                        }
                        try {
                            standardStreamsForm?.Invoke(standardStreamsForm.UpdateStderr);
                        }
                        catch (ObjectDisposedException ex) {
                            Debug.WriteLine(ex.Message);
                        }
                    }
                });
            }
            if (processStartInfo.RedirectStandardInput) {
                if (standardStreamsForm != null) {
                    standardStreamsForm.Stdin = process.StandardInput.BaseStream;
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e) {
            StartProcess();
        }

        private void Process_Exited(object? sender, EventArgs e) {
            if (InvokeRequired) {
                Invoke(Process_Exited, sender, e);
                return;
            }
            if (!manuallyKilled && AfterStoppedComboBox.SelectedIndex > 0) {
                CountdownTimer.Tag = DelayForSecondsNumericUpDown.Value;
                CountdownTimer.Start();
            }
            OnPropertyChanged(nameof(State));
        }

        private void ProfileEditor_Load(object sender, EventArgs e) {
            if (AfterStoppedComboBox.SelectedIndex == -1) {
                AfterStoppedComboBox.SelectedIndex = 0;
            }
        }

        private void KillButton_Click(object sender, EventArgs e) {
            manuallyKilled = true;
            process?.Kill(true);
            CountdownTimer.Stop();
            OnPropertyChanged(nameof(State));
        }

        private void CountdownTimer_Tick(object sender, EventArgs e) {
            CountdownTimer!.Tag = (decimal)CountdownTimer.Tag - 1;
            if ((decimal)CountdownTimer.Tag <= 0) {
                CountdownTimer.Stop();
                if (AfterStoppedComboBox.SelectedIndex == 1) {
                    StartProcess();
                }
            }
            else {
                OnPropertyChanged(nameof(State));
            }
        }

        private void UseShellExecuteCheckBox_CheckedChanged(object sender, EventArgs e) {
            CreateNoWindowCheckBox.Enabled = !UseShellExecuteCheckBox.Checked;
            StandardStreamsButton.Enabled = !UseShellExecuteCheckBox.Checked;
        }
    }
}
