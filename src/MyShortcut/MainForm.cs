using MyShortcut.FormModifications;
using MyShortcut.Forms;
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
        private readonly IServiceConfiguration configService;
        public MainForm()
        {
            InitializeComponent();

            formFader = new FormFader(this);
            configService = ConfigurationManager.GetConfigurationService();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeFormSize();
            formFader.Initialize();
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

        private void ConfigurationButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm frm = new ConfigurationForm(configService);
            // Show the form while the user edits the settins
            formFader.PauseFading();
            frm.ShowDialog();
            formFader.ResumeFading();
        }
    }
}
