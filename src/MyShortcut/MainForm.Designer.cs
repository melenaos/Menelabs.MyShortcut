
namespace MyShortcut
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UserCommandTextBox = new System.Windows.Forms.TextBox();
            this.ShutDownButton = new System.Windows.Forms.Button();
            this.ConfigurationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserCommandTextBox
            // 
            this.UserCommandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserCommandTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCommandTextBox.Location = new System.Drawing.Point(4, 5);
            this.UserCommandTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserCommandTextBox.Name = "UserCommandTextBox";
            this.UserCommandTextBox.Size = new System.Drawing.Size(239, 34);
            this.UserCommandTextBox.TabIndex = 3;
            this.UserCommandTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserCommandTextBox_KeyDown);
            // 
            // ShutDownButton
            // 
            this.ShutDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShutDownButton.BackgroundImage")));
            this.ShutDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutDownButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ShutDownButton.FlatAppearance.BorderSize = 0;
            this.ShutDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ShutDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutDownButton.Location = new System.Drawing.Point(281, 0);
            this.ShutDownButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShutDownButton.Name = "ShutDownButton";
            this.ShutDownButton.Size = new System.Drawing.Size(41, 39);
            this.ShutDownButton.TabIndex = 2;
            this.ShutDownButton.UseVisualStyleBackColor = true;
            this.ShutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
            // 
            // ConfigurationButton
            // 
            this.ConfigurationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfigurationButton.BackgroundImage")));
            this.ConfigurationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfigurationButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ConfigurationButton.FlatAppearance.BorderSize = 0;
            this.ConfigurationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ConfigurationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConfigurationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigurationButton.Location = new System.Drawing.Point(246, 5);
            this.ConfigurationButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfigurationButton.Name = "ConfigurationButton";
            this.ConfigurationButton.Size = new System.Drawing.Size(34, 34);
            this.ConfigurationButton.TabIndex = 1;
            this.ConfigurationButton.UseVisualStyleBackColor = true;
            this.ConfigurationButton.Click += new System.EventHandler(this.ConfigurationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 55);
            this.ControlBox = false;
            this.Controls.Add(this.ConfigurationButton);
            this.Controls.Add(this.ShutDownButton);
            this.Controls.Add(this.UserCommandTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "[";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserCommandTextBox;
        private System.Windows.Forms.Button ShutDownButton;
        private System.Windows.Forms.Button ConfigurationButton;
    }
}

