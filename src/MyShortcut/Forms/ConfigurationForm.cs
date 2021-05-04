using MyShortcut.Library.Repository.Model;
using MyShortcut.Library.Services.Abstruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShortcut.Forms
{
    public partial class ConfigurationForm : Form
    {
        private ShortcutModel shortcutEdit = null;

        private bool manageGroupOpened = false;
        private int manageGroupPanelHeightClosed = 50;
        private int manageGroupPanelHeightOpened = 82;

        private readonly IServiceConfiguration configService;
        public ConfigurationForm(IServiceConfiguration configService)
        {
            InitializeComponent();
            this.configService = configService;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Initialize Layout before Configuration (AutogenerateColumns = false before adding the datasources)
            InitializeLayout();
            InitializeConfiguration();

            
        }

        private void InitializeLayout()
        {
            this.Size = new Size(500, 350);
            InitializeShortcutsLayout();
            InitializeGroupsLayout();
            InitializeAboutLayout();
        }

        private void InitializeAboutLayout()
        {
            var version = Assembly.GetEntryAssembly().GetName().Version;
            AboutVersionLabel.Text = $"v{version.Major}.{version.Minor}";
        }

        private void InitializeGroupsLayout()
        {
            GroupsBox.Height = manageGroupPanelHeightClosed;
        }

        private void InitializeConfiguration()
        {
            LoadShortcuts();
            LoadPlugins();
            LoadSettings();
        }




        #region Shortcuts
        private void SetShortcutLayout(bool edit)
        {
            ShortcutsViewPanel.Visible = !edit;
            ShortcutsEditPanel.Visible = edit;

            // Clear edit shortcut
            if (!edit)
            {
                shortcutEdit = null;
            }
            // fill the data in the textboxes
            else if (shortcutEdit != null)
            {
                DataBindShortcut(true);
            }

        }

        private void DataBindShortcut(bool load)
        {
            if (load)
            {
                ShortcutNameText.Text = shortcutEdit.Name;
                ShortcutAlternativeNamesText.Text = shortcutEdit.AlternativeNames;
                ShortcutTagsText.Text = shortcutEdit.Tags;

                ShortcutGroupCombo.DataSource = configService.Groups.Select(u => u.Name).ToArray();
                ShortcutGroupCombo.SelectedItem = shortcutEdit.Group;

                ShorcutTypeTabControl.SelectedIndex = (int)shortcutEdit.Type;
                switch (shortcutEdit.Type)
                {
                    case ShortcutType.Application:
                        ShortcutApplicationPathText.Text = shortcutEdit.Command;
                        ShortcutApplicationWorkingDirectoryText.Text = shortcutEdit.WorkingDir;
                        ShortcutApplicationArgumentsText.Text = shortcutEdit.Arguments;
                        ShortcutApplicationAdminCheckbox.Checked = shortcutEdit.AdminRights;
                        break;
                    case ShortcutType.Folder:
                        ShortcutFolderPathText.Text = shortcutEdit.Command;
                        break;
                    case ShortcutType.Plugin:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                shortcutEdit.Name = ShortcutNameText.Text;
                shortcutEdit.AlternativeNames = ShortcutAlternativeNamesText.Text;
                shortcutEdit.Tags = ShortcutTagsText.Text;

                shortcutEdit.Group = ShortcutGroupCombo.SelectedItem as string;

                shortcutEdit.Type = (ShortcutType)ShorcutTypeTabControl.SelectedIndex;
                switch (shortcutEdit.Type)
                {
                    case ShortcutType.Application:
                        shortcutEdit.Command = ShortcutApplicationPathText.Text;
                        shortcutEdit.WorkingDir = ShortcutApplicationWorkingDirectoryText.Text;
                        shortcutEdit.Arguments = ShortcutApplicationArgumentsText.Text;
                        shortcutEdit.AdminRights = ShortcutApplicationAdminCheckbox.Checked;
                        break;
                    case ShortcutType.Folder:
                        shortcutEdit.Command = ShortcutFolderPathText.Text;
                        break;
                    case ShortcutType.Plugin:
                        break;
                    default:
                        break;
                }
            }
        }

        private void LoadShortcuts()
        {
            configService.LoadShortcuts();
            UpdateShortcuts();
        }

        private void UpdateShortcuts()
        {
            UpdateGroupsCombo();
            UpdateShortcutsDataGrid();
        }

        private void UpdateGroupsCombo()
        {
            // Store temporary the selected group because it will change when the datasource been reseted
            var selectedGroup = configService.SelectedGroup;

            GroupsCombo.DataSource = null;
            GroupsCombo.DataSource = configService.Groups;
            GroupsCombo.DisplayMember = "Name";

            configService.SelectedGroup = selectedGroup ?? configService.SelectedGroup;
            GroupsCombo.SelectedItem = configService.SelectedGroup;
        }

        private void InitializeShortcutsLayout()
        {
            ShortcutsDataGrid.AutoGenerateColumns = false;
            ShortcutsEditPanel.Dock = DockStyle.Fill;
            ShortcutsViewPanel.Dock = DockStyle.Fill;

            SetShortcutLayout(false);
        }

        private void ShortcutsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex >= 0 && e.ColumnIndex < ShortcutsDataGrid.Columns.Count)
            {
                // Get the Shortcut and edit it
                if (ShortcutsDataGrid.Rows[e.RowIndex].DataBoundItem is ShortcutModel currentShortcut)
                {
                    shortcutEdit = currentShortcut;
                    SetShortcutLayout(true);
                }
            }
        }

        private void ShortcutsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // If the user pressed on the edit column
            if (e.ColumnIndex >= 0 && e.ColumnIndex < ShortcutsDataGrid.Columns.Count)
            {
                if (ShortcutsDataGrid.Columns[e.ColumnIndex].Name == "ColEdit")
                {
                    // Get the Shortcut and edit it
                    if (ShortcutsDataGrid.Rows[e.RowIndex].DataBoundItem is ShortcutModel currentShortcut)
                    {
                        shortcutEdit = currentShortcut;
                        SetShortcutLayout(true);
                    }
                }
            }
        }
        private void GroupsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupsCombo.SelectedItem is GroupModel group)
            {
                configService.SelectedGroup = group;
                UpdateShortcutsDataGrid();
                ShortcutsEditGroupButton.Enabled = !configService.SelectedGroup.IsAll;
            }
        }

        private void UpdateShortcutsDataGrid()
        {
            ShortcutsDataGrid.DataSource = configService.SelectedGroupShortcuts;

            // Hide Group column if specific group is selected
            ShortcutsDataGrid.Columns[0].Visible = configService.SelectedGroup.IsAll;

            ShortcutsDataGrid.Update();
            ShortcutsDataGrid.Refresh();
        }

        private void NewShortcutButton_Click(object sender, EventArgs e)
        {
            shortcutEdit = configService.AddNewShortcut();
            UpdateShortcutsDataGrid();
            SetShortcutLayout(true);

        }
        private void SaveShortcutButton_Click(object sender, EventArgs e)
        {
            DataBindShortcut(false);
            configService.SaveShortcuts();
            SetShortcutLayout(false);
        }

        private void CancelShortcutButton_Click(object sender, EventArgs e)
        {
            SetShortcutLayout(false);
        }

        private void ShortcutApplicationPathButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ShortcutApplicationPathText.Text))
            {
                OpenFile.FileName = ShortcutApplicationPathText.Text;
            }
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                ShortcutApplicationPathText.Text = OpenFile.FileName;
            }
        }
        private void ShortcutApplicationWorkingDirectoryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ShortcutApplicationWorkingDirectoryText.Text))
            {
                FolderBrowser.SelectedPath = ShortcutApplicationWorkingDirectoryText.Text;
            }
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                ShortcutApplicationWorkingDirectoryText.Text = FolderBrowser.SelectedPath;
            }
        }

        private void ShortcutFolderPathButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ShortcutFolderPathText.Text))
            {
                FolderBrowser.SelectedPath = ShortcutFolderPathText.Text;
            }
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                ShortcutFolderPathText.Text = FolderBrowser.SelectedPath;
            }
        }


        #region Groups
        private void ShortcutsNewGroupButton_Click(object sender, EventArgs e)
        {
            configService.AddNewGroup();
            UpdateShortcuts();
            //Edit new group's name
            ShortcutsEditGroupButton_Click(sender, e);
        }

        private void ShortcutsEditGroupButton_Click(object sender, EventArgs e)
        {
            // Don't allow to change or delete All group
            if (configService.SelectedGroup.IsAll)
                return;

            EditGroupForm form = new EditGroupForm(configService.SelectedGroup.Name);
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                configService.UpdateSelectedGroupName(form.GroupNameText.Text);
                UpdateShortcuts();
            }
            else if (dialogResult == DialogResult.Abort)
            {
                if (MessageBox.Show($"Are you sure you want to delete group {configService.SelectedGroup.Name}? All group's shortcuts will be transferd to `All` group.", "Delete group", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    configService.DeleteSelectedGroup();
                    UpdateShortcuts();
                }
            }
        }

        private void ManageGroupsButton_Click(object sender, EventArgs e)
        {
            manageGroupOpened = !manageGroupOpened;
            ManageGroupsButton.Text = manageGroupOpened ? "Manage groups ▲" : "Manage groups ▼";
            GroupsBox.Height = manageGroupOpened ? manageGroupPanelHeightOpened : manageGroupPanelHeightClosed;
        }
        #endregion


        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

  


        private void LoadPlugins()
        {
            // Currently there are no plugins supported
            ConfigurationTabControl.TabPages.Remove(PluginsPage);
            ShorcutTypeTabControl.TabPages.Remove(ShortcutTypePluginPage);
        }

        private void MenelabsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://menelabs.com/");
            Process.Start(sInfo);
        }

        private void GDrakosLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/gdrakos79");
            Process.Start(sInfo);
        }

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/melenaos/Menelabs.MyShortcut");
            Process.Start(sInfo);
        }

        #region configuration
        private void LoadSettings()
        {
            configService.LoadSettings();
            UpdateSettings();
        }

        private void UpdateSettings()
        {
            ShowInTaskbarCheckBox.Checked = configService.ShowInTaskbar;
            StayOnTopCheckBox.Checked = configService.WindowOnTop;
        }

        private void StayOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            configService.WindowOnTop = StayOnTopCheckBox.Checked;
        }

        private void ShowInTaskbarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            configService.ShowInTaskbar = ShowInTaskbarCheckBox.Checked;

        }
        #endregion
    }
}
