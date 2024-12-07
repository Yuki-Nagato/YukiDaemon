using Maroquio;
using Newtonsoft.Json;
using System.Text;

namespace YukiDaemon {
    public partial class MainForm : Form {
        private readonly ProfileEditor nullProfileEditor;
        private readonly SortableBindingList<ProfileEditor> profileEditors = new();
        private readonly string configFilePath = "yuki-daemon-config.json";

        public MainForm() {
            InitializeComponent();
            nullProfileEditor = new ProfileEditor();
            foreach (Control control in nullProfileEditor.Controls) {
                control.Enabled = false;
            }
        }

        private void ReplaceProfileEditor(ProfileEditor? profileEditor) {
            MainSplitContainer.Panel2.Controls.Clear();
            MainSplitContainer.Panel2.Controls.Add(profileEditor ?? nullProfileEditor);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // ProfileEditor
            profileEditor1.Parent = null;
            profileEditor1.Dispose();
            ReplaceProfileEditor(null);
            // Config
            if (File.Exists(configFilePath)) {
                string content = File.ReadAllText(configFilePath, Encoding.UTF8);
                Config config = JsonConvert.DeserializeObject<Config>(content) ?? throw new Exception("Reading config error.");
                foreach (Profile profile in config.Profiles) {
                    ProfileEditor profileEditor = new(profile);
                    profileEditors.Add(profileEditor);
                }
            }
            // ProfilesDataGridView
            ProfilesDataGridView.AutoGenerateColumns = false;
            ProfilesDataGridView.Columns.Add(new() {
                HeaderText = "Name",
                DataPropertyName = nameof(ProfileEditor.ProfileName),
                CellTemplate = new DataGridViewTextBoxCell(),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            ProfilesDataGridView.Columns.Add(new() {
                HeaderText = "State",
                DataPropertyName = nameof(ProfileEditor.State),
                CellTemplate = new DataGridViewTextBoxCell(),
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            ProfilesDataGridView.DataSource = profileEditors;
        }

        private void AddProfileButton_Click(object sender, EventArgs e) {
            ProfileEditor profileEditor = new("New Profile");
            profileEditors.Add(profileEditor);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
                return;
            }
            while (profileEditors.Count > 0) {
                int lastIndex = profileEditors.Count - 1;
                profileEditors[lastIndex].Dispose();
                profileEditors.RemoveAt(lastIndex);
            }
            nullProfileEditor.Dispose();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Config config = new(profileEditors.Select(profileEditor => profileEditor.Profile).ToList());
            string content = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(configFilePath, content, Encoding.UTF8);
        }

        private void ProfilesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void ProfilesDataGridView_SelectionChanged(object sender, EventArgs e) {
            ReplaceProfileEditor(ProfilesDataGridView.SelectedRows.Count == 1 ? (ProfileEditor)ProfilesDataGridView.SelectedRows[0].DataBoundItem : null);
            DeleteProfileButton.Enabled = ProfilesDataGridView.SelectedRows.Count > 0;
        }

        private void ProfilesDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            for (int i = 0; i < ProfilesDataGridView.Rows.Count; i++) {
                ProfilesDataGridView.Rows[i].Selected = i == e.RowIndex;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            foreach (ProfileEditor profileEditor in profileEditors) {
                if (profileEditor.AutoStart) {
                    profileEditor.StartProcess();
                }
            }
        }

        private void DeleteProfileButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Delete " + ProfilesDataGridView.SelectedRows.Count + " profiles?", "Delete Profiles - Yuki Daemon", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK) {
                return;
            }
            foreach (DataGridViewRow row in ProfilesDataGridView.SelectedRows) {
                ProfileEditor profileEditor = (ProfileEditor)row.DataBoundItem;
                profileEditor.Dispose();
                profileEditors.Remove(profileEditor);
            }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
