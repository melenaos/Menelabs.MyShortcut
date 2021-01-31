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
        private Guid? shortcutEditId = null;

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

        }

        private void LoadShortcuts()
        {

            GroupsCombo.DataSource = configService.Groups;
            GroupsCombo.SelectedItem = configService.SelectedGroup;

            ShortcutsDataGrid.DataSource = configService.SelectedGroupShortcuts;
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

            //I suposed you want to handle the event for column at index 1
            if (e.ColumnIndex >= 0 && e.ColumnIndex < ShortcutsDataGrid.Columns.Count)
            {
                if (ShortcutsDataGrid.Columns[e.ColumnIndex].Name == "ColEdit")
                    MessageBox.Show("Clicked!");
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
