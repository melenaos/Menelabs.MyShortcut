using MyShortcut.FormModifications;
using MyShortcut.Forms;
using MyShortcut.Library.Repository.Model;
using MyShortcut.Library.Services;
using MyShortcut.Library.Services.Abstruct;
using MyShortcut.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShortcut
{
    public partial class MainForm : Form
    {
        private static int MARGIN_SIZE = 6;
        private readonly FormFader formFader;
        private readonly MovingForm movingForm;
        private readonly IServiceConfiguration configService;
        private readonly IExecuteShortcuts shortcutExecutor;
        AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();


        public MainForm()
        {
            InitializeComponent();

            formFader = new FormFader(this);
            movingForm = new MovingForm(this);
            configService = ConfigurationManager.GetConfigurationService();
            shortcutExecutor = ConfigurationManager.GetShortcutExecutor();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           await configService.LoadSettings();
            InitializeFormSettings();
            InitializeFormSize();
            formFader.Initialize();
            movingForm.Initialize(configService.GetFormLocation());
            BindAutoComplete();
        }

        private void InitializeFormSettings()
        {
            this.ShowInTaskbar = configService.ShowInTaskbar;
            this.TopMost= configService.WindowOnTop;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var location = movingForm.RecordWindowPosition();
            if (location.HasValue)
                configService.SetFormLocation(location.Value);
        }

        private void InitializeFormSize()
        {
            UserCommandTextBox.Top = MARGIN_SIZE;
            UserCommandTextBox.Left = MARGIN_SIZE;

            ConfigurationButton.Top = MARGIN_SIZE;
            ConfigurationButton.Left = UserCommandTextBox.Right + MARGIN_SIZE;
            ConfigurationButton.Height = ConfigurationButton.Width = UserCommandTextBox.Height;

            ShutDownButton.Top = MARGIN_SIZE;
            ShutDownButton.Left = ConfigurationButton.Right + MARGIN_SIZE;
            ShutDownButton.Height = ConfigurationButton.Width = UserCommandTextBox.Height;

            this.Height = UserCommandTextBox.Height + MARGIN_SIZE * 2;
            this.Width = ShutDownButton.Right + MARGIN_SIZE;
        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BindAutoComplete()
        {
            configService.LoadShortcuts();
            foreach (var item in configService.Shortcuts)
            {
                autoCompleteSource.Add(item.Name);
                foreach (var tags in item.TagsList)
                {
                    autoCompleteSource.Add(tags.Trim() + " : " + item.Name);
                }

                foreach (var alternative in item.AlternativeNamesList)
                {
                    autoCompleteSource.Add(alternative);
                }
            }

            UserCommandTextBox.AutoCompleteCustomSource = autoCompleteSource;
            UserCommandTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            UserCommandTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ConfigurationButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm frm = new ConfigurationForm(configService);
            // Show the form while the user edits the settins
            PauseFading(true);
            frm.ShowDialog();
            PauseFading(false);

            // Reload shortcuts
            BindAutoComplete();
            // and initialize formsettings
            InitializeFormSettings();
        }

        private void PauseFading(bool pause)
        {
            if (pause)
            {
                formFader.PauseFading();
                TopMost = false;
            }
            else
            {
                formFader.ResumeFading();
                TopMost = true;
            }
        }

        private void UserCommandTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && !string.IsNullOrEmpty(UserCommandTextBox.Text))
            {
                ShortcutModel shortcut = configService.FindShortcut(UserCommandTextBox.Text);
                if (shortcut != null)
                {
                    if (shortcutExecutor.Execute(shortcut))
                    {
                        UserCommandTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("The Process cannot be started", "Shortcut exception");
                    }
                }
                else
                {
                    MessageBox.Show("The shortcut does not exists", "Shortcut not found");
                }

            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            UserCommandTextBox.Focus();
        }
    }
}
