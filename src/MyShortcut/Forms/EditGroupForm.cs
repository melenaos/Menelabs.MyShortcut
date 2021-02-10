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
    public partial class EditGroupForm : Form
    {
        public EditGroupForm(string name)
        {
            InitializeComponent();
            GroupNameText.Text = name;
        }

        private void DeleteGroupButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
