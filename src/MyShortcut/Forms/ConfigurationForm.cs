using MyShortcut.Library.Repository.Model;
using MyShortcut.Library.Services.Abstruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShortcut.Forms
{
    public partial class ConfigurationForm : Form
    {
        private ShortcutModel shortcutEdit = null;

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

        private void InitializeConfiguration()
        {
            LoadShortcuts();
            LoadPlugins();
            LoadSettings();
        }

        private void InitializeLayout()
        {
            InitializeShortcutsLayout();
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

                ShortcutGroupCombo.DataSource = configService.Groups.Select(u => u.Name).ToArray();
                ShortcutGroupCombo.SelectedItem = shortcutEdit.Group;

                ShorcutTypeTabControl.SelectedIndex = (int)shortcutEdit.Type;
            }
            else
            {

            }
        }

        private void LoadShortcuts()
        {

            GroupsCombo.DataSource = configService.Groups;
            GroupsCombo.SelectedItem = configService.SelectedGroup;

            UpdateShortcutsDataGrid();
        }

        private void InitializeShortcutsLayout()
        {
            ShortcutsDataGrid.AutoGenerateColumns = false;
            ShortcutsEditPanel.Dock = DockStyle.Fill;
            ShortcutsViewPanel.Dock = DockStyle.Fill;

            SetShortcutLayout(false);
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
            configService.AddNewShortcut();
            UpdateShortcutsDataGrid();

        }
        private void SaveShortcutButton_Click(object sender, EventArgs e)
        {

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
                FolderBrowser.SelectedPath= ShortcutApplicationWorkingDirectoryText.Text;
            }
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                ShortcutApplicationWorkingDirectoryText.Text = FolderBrowser.SelectedPath;
            }
        }
        #endregion


        private void LoadSettings()
        {
        }

        private void LoadPlugins()
        {
        }

     
    }
}
