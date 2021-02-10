
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.ConfigurationTabControl = new System.Windows.Forms.TabControl();
            this.ShortcutsPage = new System.Windows.Forms.TabPage();
            this.ShortcutsEditPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveShortcutButton = new System.Windows.Forms.Button();
            this.CancelShortcutButton = new System.Windows.Forms.Button();
            this.ShortcutTagsLabel = new System.Windows.Forms.Label();
            this.ShortcutTagsText = new System.Windows.Forms.TextBox();
            this.ShorcutTypeTabControl = new System.Windows.Forms.TabControl();
            this.ShortcutTypeApplicationPage = new System.Windows.Forms.TabPage();
            this.ShortcutApplicationAdminCheckbox = new System.Windows.Forms.CheckBox();
            this.ShortcutApplicationArgumentsLabel = new System.Windows.Forms.Label();
            this.ShortcutApplicationArgumentsText = new System.Windows.Forms.TextBox();
            this.ShortcutApplicationWorkingDirectoryButton = new System.Windows.Forms.Button();
            this.ShortcutApplicationWorkingDirectoryLabel = new System.Windows.Forms.Label();
            this.ShortcutApplicationWorkingDirectoryText = new System.Windows.Forms.TextBox();
            this.ShortcutApplicationPathButton = new System.Windows.Forms.Button();
            this.ShortcutApplicationPathLabel = new System.Windows.Forms.Label();
            this.ShortcutApplicationPathText = new System.Windows.Forms.TextBox();
            this.ShortcutTypeFolderPage = new System.Windows.Forms.TabPage();
            this.ShortcutFolderPathButton = new System.Windows.Forms.Button();
            this.ShortcutFolderPathLabel = new System.Windows.Forms.Label();
            this.ShortcutFolderPathText = new System.Windows.Forms.TextBox();
            this.ShortcutTypePluginPage = new System.Windows.Forms.TabPage();
            this.ShortcutGroupLabel = new System.Windows.Forms.Label();
            this.ShortcutGroupCombo = new System.Windows.Forms.ComboBox();
            this.ShortcutAlternativeNamesLabel = new System.Windows.Forms.Label();
            this.ShortcutAlternativeNamesText = new System.Windows.Forms.TextBox();
            this.ShortcutNameLabel = new System.Windows.Forms.Label();
            this.ShortcutNameText = new System.Windows.Forms.TextBox();
            this.ShortcutsViewPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewShortcutButton = new System.Windows.Forms.Button();
            this.ShortcutsDataGrid = new System.Windows.Forms.DataGridView();
            this.ColGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.GroupsBox = new System.Windows.Forms.GroupBox();
            this.ShortcutsExportGroupButton = new System.Windows.Forms.Button();
            this.ShortcutsImportGroupButton = new System.Windows.Forms.Button();
            this.ShortcutsEditGroupButton = new System.Windows.Forms.Button();
            this.ShortcutsNewGroupButton = new System.Windows.Forms.Button();
            this.ManageGroupsButton = new System.Windows.Forms.Button();
            this.GroupsCombo = new System.Windows.Forms.ComboBox();
            this.PluginsPage = new System.Windows.Forms.TabPage();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ConfigurationTabControl.SuspendLayout();
            this.ShortcutsPage.SuspendLayout();
            this.ShortcutsEditPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ShorcutTypeTabControl.SuspendLayout();
            this.ShortcutTypeApplicationPage.SuspendLayout();
            this.ShortcutTypeFolderPage.SuspendLayout();
            this.ShortcutsViewPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShortcutsDataGrid)).BeginInit();
            this.GroupsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigurationTabControl
            // 
            this.ConfigurationTabControl.Controls.Add(this.ShortcutsPage);
            this.ConfigurationTabControl.Controls.Add(this.PluginsPage);
            this.ConfigurationTabControl.Controls.Add(this.SettingsPage);
            this.ConfigurationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationTabControl.Location = new System.Drawing.Point(0, 0);
            this.ConfigurationTabControl.Name = "ConfigurationTabControl";
            this.ConfigurationTabControl.SelectedIndex = 0;
            this.ConfigurationTabControl.Size = new System.Drawing.Size(1354, 440);
            this.ConfigurationTabControl.TabIndex = 0;
            // 
            // ShortcutsPage
            // 
            this.ShortcutsPage.Controls.Add(this.ShortcutsEditPanel);
            this.ShortcutsPage.Controls.Add(this.ShortcutsViewPanel);
            this.ShortcutsPage.Location = new System.Drawing.Point(4, 25);
            this.ShortcutsPage.Name = "ShortcutsPage";
            this.ShortcutsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShortcutsPage.Size = new System.Drawing.Size(1346, 411);
            this.ShortcutsPage.TabIndex = 0;
            this.ShortcutsPage.Text = "Shortcuts";
            this.ShortcutsPage.UseVisualStyleBackColor = true;
            // 
            // ShortcutsEditPanel
            // 
            this.ShortcutsEditPanel.Controls.Add(this.panel2);
            this.ShortcutsEditPanel.Controls.Add(this.ShortcutTagsLabel);
            this.ShortcutsEditPanel.Controls.Add(this.ShortcutTagsText);
            this.ShortcutsEditPanel.Controls.Add(this.ShorcutTypeTabControl);
            this.ShortcutsEditPanel.Controls.Add(this.ShortcutGroupLabel);
            this.ShortcutsEditPanel.Controls.Add(this.ShortcutGroupCombo);
            this.ShortcutsEditPanel.Controls.Add(this.ShortcutAlternativeNamesLabel);
            this.ShortcutsEditPanel.Controls.Add(this.ShortcutAlternativeNamesText);
            this.ShortcutsEditPanel.Controls.Add(this.ShortcutNameLabel);
            this.ShortcutsEditPanel.Controls.Add(this.ShortcutNameText);
            this.ShortcutsEditPanel.Location = new System.Drawing.Point(632, 6);
            this.ShortcutsEditPanel.Name = "ShortcutsEditPanel";
            this.ShortcutsEditPanel.Size = new System.Drawing.Size(641, 375);
            this.ShortcutsEditPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveShortcutButton);
            this.panel2.Controls.Add(this.CancelShortcutButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 40);
            this.panel2.TabIndex = 13;
            // 
            // SaveShortcutButton
            // 
            this.SaveShortcutButton.Location = new System.Drawing.Point(12, 6);
            this.SaveShortcutButton.Name = "SaveShortcutButton";
            this.SaveShortcutButton.Size = new System.Drawing.Size(75, 30);
            this.SaveShortcutButton.TabIndex = 0;
            this.SaveShortcutButton.Text = "Save";
            this.SaveShortcutButton.UseVisualStyleBackColor = true;
            this.SaveShortcutButton.Click += new System.EventHandler(this.SaveShortcutButton_Click);
            // 
            // CancelShortcutButton
            // 
            this.CancelShortcutButton.Location = new System.Drawing.Point(93, 6);
            this.CancelShortcutButton.Name = "CancelShortcutButton";
            this.CancelShortcutButton.Size = new System.Drawing.Size(75, 30);
            this.CancelShortcutButton.TabIndex = 1;
            this.CancelShortcutButton.Text = "Cancel";
            this.CancelShortcutButton.UseVisualStyleBackColor = true;
            this.CancelShortcutButton.Click += new System.EventHandler(this.CancelShortcutButton_Click);
            // 
            // ShortcutTagsLabel
            // 
            this.ShortcutTagsLabel.AutoSize = true;
            this.ShortcutTagsLabel.Location = new System.Drawing.Point(227, 86);
            this.ShortcutTagsLabel.Name = "ShortcutTagsLabel";
            this.ShortcutTagsLabel.Size = new System.Drawing.Size(40, 17);
            this.ShortcutTagsLabel.TabIndex = 12;
            this.ShortcutTagsLabel.Text = "Tags";
            this.ToolTips.SetToolTip(this.ShortcutTagsLabel, "Alternative commands for executing the shortcut\r\nseperated with a comma or semico" +
        "lon. \',\'  or \';\'\r\n");
            // 
            // ShortcutTagsText
            // 
            this.ShortcutTagsText.Location = new System.Drawing.Point(227, 106);
            this.ShortcutTagsText.Name = "ShortcutTagsText";
            this.ShortcutTagsText.Size = new System.Drawing.Size(271, 22);
            this.ShortcutTagsText.TabIndex = 7;
            this.ToolTips.SetToolTip(this.ShortcutTagsText, "Alternative commands for executing the shortcut\r\nseperated with a comma or semico" +
        "lon. \',\'  or \';\'\r\n");
            // 
            // ShorcutTypeTabControl
            // 
            this.ShorcutTypeTabControl.Controls.Add(this.ShortcutTypeApplicationPage);
            this.ShorcutTypeTabControl.Controls.Add(this.ShortcutTypeFolderPage);
            this.ShorcutTypeTabControl.Controls.Add(this.ShortcutTypePluginPage);
            this.ShorcutTypeTabControl.Location = new System.Drawing.Point(12, 141);
            this.ShorcutTypeTabControl.Name = "ShorcutTypeTabControl";
            this.ShorcutTypeTabControl.SelectedIndex = 0;
            this.ShorcutTypeTabControl.Size = new System.Drawing.Size(606, 140);
            this.ShorcutTypeTabControl.TabIndex = 10;
            // 
            // ShortcutTypeApplicationPage
            // 
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationAdminCheckbox);
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationArgumentsLabel);
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationArgumentsText);
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationWorkingDirectoryButton);
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationWorkingDirectoryLabel);
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationWorkingDirectoryText);
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationPathButton);
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationPathLabel);
            this.ShortcutTypeApplicationPage.Controls.Add(this.ShortcutApplicationPathText);
            this.ShortcutTypeApplicationPage.Location = new System.Drawing.Point(4, 25);
            this.ShortcutTypeApplicationPage.Name = "ShortcutTypeApplicationPage";
            this.ShortcutTypeApplicationPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShortcutTypeApplicationPage.Size = new System.Drawing.Size(598, 111);
            this.ShortcutTypeApplicationPage.TabIndex = 0;
            this.ShortcutTypeApplicationPage.Text = "Application";
            this.ShortcutTypeApplicationPage.UseVisualStyleBackColor = true;
            // 
            // ShortcutApplicationAdminCheckbox
            // 
            this.ShortcutApplicationAdminCheckbox.AutoSize = true;
            this.ShortcutApplicationAdminCheckbox.Location = new System.Drawing.Point(315, 72);
            this.ShortcutApplicationAdminCheckbox.Name = "ShortcutApplicationAdminCheckbox";
            this.ShortcutApplicationAdminCheckbox.Size = new System.Drawing.Size(145, 21);
            this.ShortcutApplicationAdminCheckbox.TabIndex = 11;
            this.ShortcutApplicationAdminCheckbox.Text = "Need admin rights";
            this.ShortcutApplicationAdminCheckbox.UseVisualStyleBackColor = true;
            // 
            // ShortcutApplicationArgumentsLabel
            // 
            this.ShortcutApplicationArgumentsLabel.AutoSize = true;
            this.ShortcutApplicationArgumentsLabel.Location = new System.Drawing.Point(315, 7);
            this.ShortcutApplicationArgumentsLabel.Name = "ShortcutApplicationArgumentsLabel";
            this.ShortcutApplicationArgumentsLabel.Size = new System.Drawing.Size(76, 17);
            this.ShortcutApplicationArgumentsLabel.TabIndex = 10;
            this.ShortcutApplicationArgumentsLabel.Text = "Arguments";
            // 
            // ShortcutApplicationArgumentsText
            // 
            this.ShortcutApplicationArgumentsText.Location = new System.Drawing.Point(315, 27);
            this.ShortcutApplicationArgumentsText.Name = "ShortcutApplicationArgumentsText";
            this.ShortcutApplicationArgumentsText.Size = new System.Drawing.Size(277, 22);
            this.ShortcutApplicationArgumentsText.TabIndex = 9;
            // 
            // ShortcutApplicationWorkingDirectoryButton
            // 
            this.ShortcutApplicationWorkingDirectoryButton.Location = new System.Drawing.Point(210, 72);
            this.ShortcutApplicationWorkingDirectoryButton.Name = "ShortcutApplicationWorkingDirectoryButton";
            this.ShortcutApplicationWorkingDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.ShortcutApplicationWorkingDirectoryButton.TabIndex = 8;
            this.ShortcutApplicationWorkingDirectoryButton.Text = "Load";
            this.ShortcutApplicationWorkingDirectoryButton.UseVisualStyleBackColor = true;
            this.ShortcutApplicationWorkingDirectoryButton.Click += new System.EventHandler(this.ShortcutApplicationWorkingDirectoryButton_Click);
            // 
            // ShortcutApplicationWorkingDirectoryLabel
            // 
            this.ShortcutApplicationWorkingDirectoryLabel.AutoSize = true;
            this.ShortcutApplicationWorkingDirectoryLabel.Location = new System.Drawing.Point(6, 52);
            this.ShortcutApplicationWorkingDirectoryLabel.Name = "ShortcutApplicationWorkingDirectoryLabel";
            this.ShortcutApplicationWorkingDirectoryLabel.Size = new System.Drawing.Size(119, 17);
            this.ShortcutApplicationWorkingDirectoryLabel.TabIndex = 7;
            this.ShortcutApplicationWorkingDirectoryLabel.Text = "Working directory";
            // 
            // ShortcutApplicationWorkingDirectoryText
            // 
            this.ShortcutApplicationWorkingDirectoryText.Location = new System.Drawing.Point(6, 72);
            this.ShortcutApplicationWorkingDirectoryText.Name = "ShortcutApplicationWorkingDirectoryText";
            this.ShortcutApplicationWorkingDirectoryText.Size = new System.Drawing.Size(197, 22);
            this.ShortcutApplicationWorkingDirectoryText.TabIndex = 6;
            // 
            // ShortcutApplicationPathButton
            // 
            this.ShortcutApplicationPathButton.Location = new System.Drawing.Point(210, 27);
            this.ShortcutApplicationPathButton.Name = "ShortcutApplicationPathButton";
            this.ShortcutApplicationPathButton.Size = new System.Drawing.Size(75, 23);
            this.ShortcutApplicationPathButton.TabIndex = 5;
            this.ShortcutApplicationPathButton.Text = "Load";
            this.ShortcutApplicationPathButton.UseVisualStyleBackColor = true;
            this.ShortcutApplicationPathButton.Click += new System.EventHandler(this.ShortcutApplicationPathButton_Click);
            // 
            // ShortcutApplicationPathLabel
            // 
            this.ShortcutApplicationPathLabel.AutoSize = true;
            this.ShortcutApplicationPathLabel.Location = new System.Drawing.Point(6, 7);
            this.ShortcutApplicationPathLabel.Name = "ShortcutApplicationPathLabel";
            this.ShortcutApplicationPathLabel.Size = new System.Drawing.Size(37, 17);
            this.ShortcutApplicationPathLabel.TabIndex = 4;
            this.ShortcutApplicationPathLabel.Text = "Path";
            // 
            // ShortcutApplicationPathText
            // 
            this.ShortcutApplicationPathText.Location = new System.Drawing.Point(6, 27);
            this.ShortcutApplicationPathText.Name = "ShortcutApplicationPathText";
            this.ShortcutApplicationPathText.Size = new System.Drawing.Size(197, 22);
            this.ShortcutApplicationPathText.TabIndex = 0;
            // 
            // ShortcutTypeFolderPage
            // 
            this.ShortcutTypeFolderPage.Controls.Add(this.ShortcutFolderPathButton);
            this.ShortcutTypeFolderPage.Controls.Add(this.ShortcutFolderPathLabel);
            this.ShortcutTypeFolderPage.Controls.Add(this.ShortcutFolderPathText);
            this.ShortcutTypeFolderPage.Location = new System.Drawing.Point(4, 25);
            this.ShortcutTypeFolderPage.Name = "ShortcutTypeFolderPage";
            this.ShortcutTypeFolderPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShortcutTypeFolderPage.Size = new System.Drawing.Size(598, 111);
            this.ShortcutTypeFolderPage.TabIndex = 1;
            this.ShortcutTypeFolderPage.Text = "Folder";
            this.ShortcutTypeFolderPage.UseVisualStyleBackColor = true;
            // 
            // ShortcutFolderPathButton
            // 
            this.ShortcutFolderPathButton.Location = new System.Drawing.Point(210, 27);
            this.ShortcutFolderPathButton.Name = "ShortcutFolderPathButton";
            this.ShortcutFolderPathButton.Size = new System.Drawing.Size(75, 23);
            this.ShortcutFolderPathButton.TabIndex = 8;
            this.ShortcutFolderPathButton.Text = "Load";
            this.ShortcutFolderPathButton.UseVisualStyleBackColor = true;
            this.ShortcutFolderPathButton.Click += new System.EventHandler(this.ShortcutFolderPathButton_Click);
            // 
            // ShortcutFolderPathLabel
            // 
            this.ShortcutFolderPathLabel.AutoSize = true;
            this.ShortcutFolderPathLabel.Location = new System.Drawing.Point(6, 7);
            this.ShortcutFolderPathLabel.Name = "ShortcutFolderPathLabel";
            this.ShortcutFolderPathLabel.Size = new System.Drawing.Size(48, 17);
            this.ShortcutFolderPathLabel.TabIndex = 7;
            this.ShortcutFolderPathLabel.Text = "Folder";
            // 
            // ShortcutFolderPathText
            // 
            this.ShortcutFolderPathText.Location = new System.Drawing.Point(6, 27);
            this.ShortcutFolderPathText.Name = "ShortcutFolderPathText";
            this.ShortcutFolderPathText.Size = new System.Drawing.Size(197, 22);
            this.ShortcutFolderPathText.TabIndex = 6;
            // 
            // ShortcutTypePluginPage
            // 
            this.ShortcutTypePluginPage.Location = new System.Drawing.Point(4, 25);
            this.ShortcutTypePluginPage.Name = "ShortcutTypePluginPage";
            this.ShortcutTypePluginPage.Size = new System.Drawing.Size(598, 111);
            this.ShortcutTypePluginPage.TabIndex = 2;
            this.ShortcutTypePluginPage.Text = "Plugin";
            this.ShortcutTypePluginPage.UseVisualStyleBackColor = true;
            // 
            // ShortcutGroupLabel
            // 
            this.ShortcutGroupLabel.AutoSize = true;
            this.ShortcutGroupLabel.Location = new System.Drawing.Point(15, 86);
            this.ShortcutGroupLabel.Name = "ShortcutGroupLabel";
            this.ShortcutGroupLabel.Size = new System.Drawing.Size(48, 17);
            this.ShortcutGroupLabel.TabIndex = 7;
            this.ShortcutGroupLabel.Text = "Group";
            // 
            // ShortcutGroupCombo
            // 
            this.ShortcutGroupCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShortcutGroupCombo.FormattingEnabled = true;
            this.ShortcutGroupCombo.Location = new System.Drawing.Point(12, 106);
            this.ShortcutGroupCombo.Name = "ShortcutGroupCombo";
            this.ShortcutGroupCombo.Size = new System.Drawing.Size(187, 24);
            this.ShortcutGroupCombo.TabIndex = 6;
            // 
            // ShortcutAlternativeNamesLabel
            // 
            this.ShortcutAlternativeNamesLabel.AutoSize = true;
            this.ShortcutAlternativeNamesLabel.Location = new System.Drawing.Point(227, 36);
            this.ShortcutAlternativeNamesLabel.Name = "ShortcutAlternativeNamesLabel";
            this.ShortcutAlternativeNamesLabel.Size = new System.Drawing.Size(123, 17);
            this.ShortcutAlternativeNamesLabel.TabIndex = 5;
            this.ShortcutAlternativeNamesLabel.Text = "Alternative Names";
            this.ToolTips.SetToolTip(this.ShortcutAlternativeNamesLabel, "Alternative commands for executing the shortcut\r\nseperated with a comma or semico" +
        "lon. \',\'  or \';\'\r\n");
            // 
            // ShortcutAlternativeNamesText
            // 
            this.ShortcutAlternativeNamesText.Location = new System.Drawing.Point(227, 59);
            this.ShortcutAlternativeNamesText.Name = "ShortcutAlternativeNamesText";
            this.ShortcutAlternativeNamesText.Size = new System.Drawing.Size(271, 22);
            this.ShortcutAlternativeNamesText.TabIndex = 4;
            this.ToolTips.SetToolTip(this.ShortcutAlternativeNamesText, "Alternative commands for executing the shortcut\r\nseperated with a comma or semico" +
        "lon. \',\'  or \';\'\r\n");
            // 
            // ShortcutNameLabel
            // 
            this.ShortcutNameLabel.AutoSize = true;
            this.ShortcutNameLabel.Location = new System.Drawing.Point(12, 36);
            this.ShortcutNameLabel.Name = "ShortcutNameLabel";
            this.ShortcutNameLabel.Size = new System.Drawing.Size(45, 17);
            this.ShortcutNameLabel.TabIndex = 3;
            this.ShortcutNameLabel.Text = "Name";
            // 
            // ShortcutNameText
            // 
            this.ShortcutNameText.Location = new System.Drawing.Point(12, 59);
            this.ShortcutNameText.Name = "ShortcutNameText";
            this.ShortcutNameText.Size = new System.Drawing.Size(187, 22);
            this.ShortcutNameText.TabIndex = 2;
            // 
            // ShortcutsViewPanel
            // 
            this.ShortcutsViewPanel.Controls.Add(this.panel1);
            this.ShortcutsViewPanel.Controls.Add(this.ShortcutsDataGrid);
            this.ShortcutsViewPanel.Controls.Add(this.GroupsBox);
            this.ShortcutsViewPanel.Location = new System.Drawing.Point(8, 3);
            this.ShortcutsViewPanel.Name = "ShortcutsViewPanel";
            this.ShortcutsViewPanel.Size = new System.Drawing.Size(618, 373);
            this.ShortcutsViewPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewShortcutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 40);
            this.panel1.TabIndex = 4;
            // 
            // NewShortcutButton
            // 
            this.NewShortcutButton.Location = new System.Drawing.Point(12, 6);
            this.NewShortcutButton.Name = "NewShortcutButton";
            this.NewShortcutButton.Size = new System.Drawing.Size(137, 30);
            this.NewShortcutButton.TabIndex = 0;
            this.NewShortcutButton.Text = "New shortcut";
            this.NewShortcutButton.UseVisualStyleBackColor = true;
            this.NewShortcutButton.Click += new System.EventHandler(this.NewShortcutButton_Click);
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
            this.ShortcutsDataGrid.Location = new System.Drawing.Point(0, 100);
            this.ShortcutsDataGrid.MultiSelect = false;
            this.ShortcutsDataGrid.Name = "ShortcutsDataGrid";
            this.ShortcutsDataGrid.ReadOnly = true;
            this.ShortcutsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ShortcutsDataGrid.RowHeadersVisible = false;
            this.ShortcutsDataGrid.RowHeadersWidth = 51;
            this.ShortcutsDataGrid.RowTemplate.Height = 24;
            this.ShortcutsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShortcutsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShortcutsDataGrid.Size = new System.Drawing.Size(618, 273);
            this.ShortcutsDataGrid.TabIndex = 3;
            this.ShortcutsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShortcutsDataGrid_CellClick);
            this.ShortcutsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShortcutsDataGrid_CellDoubleClick);
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
            // GroupsBox
            // 
            this.GroupsBox.Controls.Add(this.ShortcutsExportGroupButton);
            this.GroupsBox.Controls.Add(this.ShortcutsImportGroupButton);
            this.GroupsBox.Controls.Add(this.ShortcutsEditGroupButton);
            this.GroupsBox.Controls.Add(this.ShortcutsNewGroupButton);
            this.GroupsBox.Controls.Add(this.ManageGroupsButton);
            this.GroupsBox.Controls.Add(this.GroupsCombo);
            this.GroupsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupsBox.Location = new System.Drawing.Point(0, 0);
            this.GroupsBox.Name = "GroupsBox";
            this.GroupsBox.Size = new System.Drawing.Size(618, 100);
            this.GroupsBox.TabIndex = 1;
            this.GroupsBox.TabStop = false;
            this.GroupsBox.Text = "Groups";
            // 
            // ShortcutsExportGroupButton
            // 
            this.ShortcutsExportGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortcutsExportGroupButton.Location = new System.Drawing.Point(524, 62);
            this.ShortcutsExportGroupButton.Name = "ShortcutsExportGroupButton";
            this.ShortcutsExportGroupButton.Size = new System.Drawing.Size(87, 30);
            this.ShortcutsExportGroupButton.TabIndex = 5;
            this.ShortcutsExportGroupButton.Text = "Export";
            this.ShortcutsExportGroupButton.UseVisualStyleBackColor = true;
            // 
            // ShortcutsImportGroupButton
            // 
            this.ShortcutsImportGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortcutsImportGroupButton.Location = new System.Drawing.Point(431, 62);
            this.ShortcutsImportGroupButton.Name = "ShortcutsImportGroupButton";
            this.ShortcutsImportGroupButton.Size = new System.Drawing.Size(87, 30);
            this.ShortcutsImportGroupButton.TabIndex = 4;
            this.ShortcutsImportGroupButton.Text = "Import";
            this.ShortcutsImportGroupButton.UseVisualStyleBackColor = true;
            // 
            // ShortcutsEditGroupButton
            // 
            this.ShortcutsEditGroupButton.Location = new System.Drawing.Point(149, 62);
            this.ShortcutsEditGroupButton.Name = "ShortcutsEditGroupButton";
            this.ShortcutsEditGroupButton.Size = new System.Drawing.Size(137, 30);
            this.ShortcutsEditGroupButton.TabIndex = 3;
            this.ShortcutsEditGroupButton.Text = "Edit group";
            this.ShortcutsEditGroupButton.UseVisualStyleBackColor = true;
            this.ShortcutsEditGroupButton.Click += new System.EventHandler(this.ShortcutsEditGroupButton_Click);
            // 
            // ShortcutsNewGroupButton
            // 
            this.ShortcutsNewGroupButton.Location = new System.Drawing.Point(6, 62);
            this.ShortcutsNewGroupButton.Name = "ShortcutsNewGroupButton";
            this.ShortcutsNewGroupButton.Size = new System.Drawing.Size(137, 30);
            this.ShortcutsNewGroupButton.TabIndex = 2;
            this.ShortcutsNewGroupButton.Text = "New group";
            this.ShortcutsNewGroupButton.UseVisualStyleBackColor = true;
            this.ShortcutsNewGroupButton.Click += new System.EventHandler(this.ShortcutsNewGroupButton_Click);
            // 
            // ManageGroupsButton
            // 
            this.ManageGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageGroupsButton.Location = new System.Drawing.Point(475, 17);
            this.ManageGroupsButton.Name = "ManageGroupsButton";
            this.ManageGroupsButton.Size = new System.Drawing.Size(137, 30);
            this.ManageGroupsButton.TabIndex = 1;
            this.ManageGroupsButton.Text = "Manage groups ▼";
            this.ManageGroupsButton.UseVisualStyleBackColor = true;
            this.ManageGroupsButton.Click += new System.EventHandler(this.ManageGroupsButton_Click);
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
            this.GroupsCombo.SelectedIndexChanged += new System.EventHandler(this.GroupsCombo_SelectedIndexChanged);
            // 
            // PluginsPage
            // 
            this.PluginsPage.Location = new System.Drawing.Point(4, 25);
            this.PluginsPage.Name = "PluginsPage";
            this.PluginsPage.Padding = new System.Windows.Forms.Padding(3);
            this.PluginsPage.Size = new System.Drawing.Size(1346, 411);
            this.PluginsPage.TabIndex = 1;
            this.PluginsPage.Text = "Plugins";
            this.PluginsPage.UseVisualStyleBackColor = true;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Location = new System.Drawing.Point(4, 25);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(1346, 411);
            this.SettingsPage.TabIndex = 2;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "Executable files (*.exe)|*.exe|Batch files (*.bat)|*.bat";
            this.OpenFile.Title = "Select shortcut file";
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 440);
            this.Controls.Add(this.ConfigurationTabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.ConfigurationTabControl.ResumeLayout(false);
            this.ShortcutsPage.ResumeLayout(false);
            this.ShortcutsEditPanel.ResumeLayout(false);
            this.ShortcutsEditPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ShorcutTypeTabControl.ResumeLayout(false);
            this.ShortcutTypeApplicationPage.ResumeLayout(false);
            this.ShortcutTypeApplicationPage.PerformLayout();
            this.ShortcutTypeFolderPage.ResumeLayout(false);
            this.ShortcutTypeFolderPage.PerformLayout();
            this.ShortcutsViewPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShortcutsDataGrid)).EndInit();
            this.GroupsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ConfigurationTabControl;
        private System.Windows.Forms.TabPage ShortcutsPage;
        private System.Windows.Forms.TabPage PluginsPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Panel ShortcutsViewPanel;
        private System.Windows.Forms.GroupBox GroupsBox;
        private System.Windows.Forms.ComboBox GroupsCombo;
        private System.Windows.Forms.Panel ShortcutsEditPanel;
        private System.Windows.Forms.DataGridView ShortcutsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewImageColumn ColEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewShortcutButton;
        private System.Windows.Forms.Button CancelShortcutButton;
        private System.Windows.Forms.Button SaveShortcutButton;
        private System.Windows.Forms.Label ShortcutNameLabel;
        private System.Windows.Forms.TextBox ShortcutNameText;
        private System.Windows.Forms.Label ShortcutAlternativeNamesLabel;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.TextBox ShortcutAlternativeNamesText;
        private System.Windows.Forms.Label ShortcutGroupLabel;
        private System.Windows.Forms.ComboBox ShortcutGroupCombo;
        private System.Windows.Forms.TabControl ShorcutTypeTabControl;
        private System.Windows.Forms.TabPage ShortcutTypeApplicationPage;
        private System.Windows.Forms.TabPage ShortcutTypeFolderPage;
        private System.Windows.Forms.TabPage ShortcutTypePluginPage;
        private System.Windows.Forms.Button ShortcutApplicationPathButton;
        private System.Windows.Forms.Label ShortcutApplicationPathLabel;
        private System.Windows.Forms.TextBox ShortcutApplicationPathText;
        private System.Windows.Forms.Label ShortcutApplicationArgumentsLabel;
        private System.Windows.Forms.TextBox ShortcutApplicationArgumentsText;
        private System.Windows.Forms.Button ShortcutApplicationWorkingDirectoryButton;
        private System.Windows.Forms.Label ShortcutApplicationWorkingDirectoryLabel;
        private System.Windows.Forms.TextBox ShortcutApplicationWorkingDirectoryText;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label ShortcutTagsLabel;
        private System.Windows.Forms.TextBox ShortcutTagsText;
        private System.Windows.Forms.Button ShortcutFolderPathButton;
        private System.Windows.Forms.Label ShortcutFolderPathLabel;
        private System.Windows.Forms.TextBox ShortcutFolderPathText;
        private System.Windows.Forms.CheckBox ShortcutApplicationAdminCheckbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ManageGroupsButton;
        private System.Windows.Forms.Button ShortcutsExportGroupButton;
        private System.Windows.Forms.Button ShortcutsImportGroupButton;
        private System.Windows.Forms.Button ShortcutsEditGroupButton;
        private System.Windows.Forms.Button ShortcutsNewGroupButton;
    }
}