
namespace MyShortcut.Forms
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ShortcutsPage = new System.Windows.Forms.TabPage();
            this.PluginsPage = new System.Windows.Forms.TabPage();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.ShortcutsViewPanel = new System.Windows.Forms.Panel();
            this.groupsBox = new System.Windows.Forms.GroupBox();
            this.GroupsCombo = new System.Windows.Forms.ComboBox();
            this.ShortcutsEditPanel = new System.Windows.Forms.Panel();
            this.ShortcutsDataGrid = new System.Windows.Forms.DataGridView();
            this.ColGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.ShortcutsPage.SuspendLayout();
            this.ShortcutsViewPanel.SuspendLayout();
            this.groupsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShortcutsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ShortcutsPage);
            this.tabControl1.Controls.Add(this.PluginsPage);
            this.tabControl1.Controls.Add(this.SettingsPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // ShortcutsPage
            // 
            this.ShortcutsPage.Controls.Add(this.ShortcutsEditPanel);
            this.ShortcutsPage.Controls.Add(this.ShortcutsViewPanel);
            this.ShortcutsPage.Location = new System.Drawing.Point(4, 25);
            this.ShortcutsPage.Name = "ShortcutsPage";
            this.ShortcutsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShortcutsPage.Size = new System.Drawing.Size(792, 421);
            this.ShortcutsPage.TabIndex = 0;
            this.ShortcutsPage.Text = "Shortcuts";
            this.ShortcutsPage.UseVisualStyleBackColor = true;
            // 
            // PluginsPage
            // 
            this.PluginsPage.Location = new System.Drawing.Point(4, 25);
            this.PluginsPage.Name = "PluginsPage";
            this.PluginsPage.Padding = new System.Windows.Forms.Padding(3);
            this.PluginsPage.Size = new System.Drawing.Size(792, 421);
            this.PluginsPage.TabIndex = 1;
            this.PluginsPage.Text = "Plugins";
            this.PluginsPage.UseVisualStyleBackColor = true;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Location = new System.Drawing.Point(4, 25);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(792, 421);
            this.SettingsPage.TabIndex = 2;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // ShortcutsViewPanel
            // 
            this.ShortcutsViewPanel.Controls.Add(this.ShortcutsDataGrid);
            this.ShortcutsViewPanel.Controls.Add(this.groupsBox);
            this.ShortcutsViewPanel.Location = new System.Drawing.Point(145, 18);
            this.ShortcutsViewPanel.Name = "ShortcutsViewPanel";
            this.ShortcutsViewPanel.Size = new System.Drawing.Size(463, 190);
            this.ShortcutsViewPanel.TabIndex = 2;
            // 
            // groupsBox
            // 
            this.groupsBox.Controls.Add(this.GroupsCombo);
            this.groupsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupsBox.Location = new System.Drawing.Point(0, 0);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(463, 61);
            this.groupsBox.TabIndex = 1;
            this.groupsBox.TabStop = false;
            this.groupsBox.Text = "Groups";
            // 
            // GroupsCombo
            // 
            this.GroupsCombo.DisplayMember = "Name";
            this.GroupsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupsCombo.FormattingEnabled = true;
            this.GroupsCombo.Location = new System.Drawing.Point(6, 21);
            this.GroupsCombo.Name = "GroupsCombo";
            this.GroupsCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GroupsCombo.Size = new System.Drawing.Size(186, 24);
            this.GroupsCombo.TabIndex = 0;
            this.GroupsCombo.ValueMember = "Id";
            // 
            // ShortcutsEditPanel
            // 
            this.ShortcutsEditPanel.Location = new System.Drawing.Point(151, 278);
            this.ShortcutsEditPanel.Name = "ShortcutsEditPanel";
            this.ShortcutsEditPanel.Size = new System.Drawing.Size(200, 100);
            this.ShortcutsEditPanel.TabIndex = 3;
            // 
            // ShortcutsDataGrid
            // 
            this.ShortcutsDataGrid.AllowUserToAddRows = false;
            this.ShortcutsDataGrid.AllowUserToDeleteRows = false;
            this.ShortcutsDataGrid.AllowUserToResizeRows = false;
            this.ShortcutsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShortcutsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ShortcutsDataGrid.CausesValidation = false;
            this.ShortcutsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShortcutsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGroup,
            this.ColName,
            this.ColAction,
            this.ColTags,
            this.ColType,
            this.ColEdit});
            this.ShortcutsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortcutsDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.ShortcutsDataGrid.Location = new System.Drawing.Point(0, 61);
            this.ShortcutsDataGrid.MultiSelect = false;
            this.ShortcutsDataGrid.Name = "ShortcutsDataGrid";
            this.ShortcutsDataGrid.ReadOnly = true;
            this.ShortcutsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ShortcutsDataGrid.RowHeadersVisible = false;
            this.ShortcutsDataGrid.RowHeadersWidth = 51;
            this.ShortcutsDataGrid.RowTemplate.Height = 24;
            this.ShortcutsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShortcutsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShortcutsDataGrid.Size = new System.Drawing.Size(463, 129);
            this.ShortcutsDataGrid.TabIndex = 3;
            this.ShortcutsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShortcutsDataGrid_CellClick);
            // 
            // ColGroup
            // 
            this.ColGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColGroup.DataPropertyName = "Group";
            this.ColGroup.HeaderText = "Group";
            this.ColGroup.MinimumWidth = 6;
            this.ColGroup.Name = "ColGroup";
            this.ColGroup.ReadOnly = true;
            this.ColGroup.Width = 65;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.DataPropertyName = "Name";
            this.ColName.FillWeight = 20F;
            this.ColName.HeaderText = "Name";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColAction
            // 
            this.ColAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAction.DataPropertyName = "Action";
            this.ColAction.FillWeight = 35F;
            this.ColAction.HeaderText = "Action";
            this.ColAction.MinimumWidth = 6;
            this.ColAction.Name = "ColAction";
            this.ColAction.ReadOnly = true;
            // 
            // ColTags
            // 
            this.ColTags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTags.DataPropertyName = "Tags";
            this.ColTags.FillWeight = 10F;
            this.ColTags.HeaderText = "Tags";
            this.ColTags.MinimumWidth = 6;
            this.ColTags.Name = "ColTags";
            this.ColTags.ReadOnly = true;
            // 
            // ColType
            // 
            this.ColType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColType.DataPropertyName = "Type";
            this.ColType.FillWeight = 96.16031F;
            this.ColType.HeaderText = "Type";
            this.ColType.MinimumWidth = 6;
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            this.ColType.Width = 60;
            // 
            // ColEdit
            // 
            this.ColEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColEdit.FillWeight = 96.16031F;
            this.ColEdit.HeaderText = "Edit";
            this.ColEdit.Image = ((System.Drawing.Image)(resources.GetObject("ColEdit.Image")));
            this.ColEdit.MinimumWidth = 6;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEdit.ToolTipText = "Edit shortcut";
            this.ColEdit.Width = 30;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.ShortcutsPage.ResumeLayout(false);
            this.ShortcutsViewPanel.ResumeLayout(false);
            this.groupsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShortcutsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ShortcutsPage;
        private System.Windows.Forms.TabPage PluginsPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Panel ShortcutsViewPanel;
        private System.Windows.Forms.GroupBox groupsBox;
        private System.Windows.Forms.ComboBox GroupsCombo;
        private System.Windows.Forms.Panel ShortcutsEditPanel;
        private System.Windows.Forms.DataGridView ShortcutsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewImageColumn ColEdit;
    }
}