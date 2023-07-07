namespace Locker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lockButton = new System.Windows.Forms.Button();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.monitorLabel = new System.Windows.Forms.Label();
            this.monitorsDropdown = new System.Windows.Forms.ComboBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.yBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.deleteSelectedProfile = new System.Windows.Forms.Button();
            this.saveProfileBox = new System.Windows.Forms.TextBox();
            this.saveProfile = new System.Windows.Forms.Button();
            this.saveProfileLabel = new System.Windows.Forms.Label();
            this.profilesText = new System.Windows.Forms.Label();
            this.profileDropdown = new System.Windows.Forms.ComboBox();
            this.key = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.minimize = new System.Windows.Forms.CheckBox();
            this.b = new System.Windows.Forms.TextBox();
            this.g = new System.Windows.Forms.TextBox();
            this.pickColor = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.showMonitors = new System.Windows.Forms.Button();
            this.settingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lockButton
            // 
            this.lockButton.Location = new System.Drawing.Point(12, 19);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(231, 31);
            this.lockButton.TabIndex = 0;
            this.lockButton.Text = "Lock";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.LockClicked);
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.showMonitors);
            this.settingsGroup.Controls.Add(this.monitorLabel);
            this.settingsGroup.Controls.Add(this.monitorsDropdown);
            this.settingsGroup.Controls.Add(this.yLabel);
            this.settingsGroup.Controls.Add(this.yBox);
            this.settingsGroup.Controls.Add(this.xLabel);
            this.settingsGroup.Controls.Add(this.xBox);
            this.settingsGroup.Controls.Add(this.deleteSelectedProfile);
            this.settingsGroup.Controls.Add(this.saveProfileBox);
            this.settingsGroup.Controls.Add(this.saveProfile);
            this.settingsGroup.Controls.Add(this.saveProfileLabel);
            this.settingsGroup.Controls.Add(this.profilesText);
            this.settingsGroup.Controls.Add(this.profileDropdown);
            this.settingsGroup.Controls.Add(this.key);
            this.settingsGroup.Controls.Add(this.keyBox);
            this.settingsGroup.Controls.Add(this.minimize);
            this.settingsGroup.Controls.Add(this.b);
            this.settingsGroup.Controls.Add(this.g);
            this.settingsGroup.Controls.Add(this.pickColor);
            this.settingsGroup.Controls.Add(this.color);
            this.settingsGroup.Controls.Add(this.r);
            this.settingsGroup.Controls.Add(this.width);
            this.settingsGroup.Controls.Add(this.widthBox);
            this.settingsGroup.Controls.Add(this.height);
            this.settingsGroup.Controls.Add(this.heightBox);
            this.settingsGroup.Controls.Add(this.lockButton);
            this.settingsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsGroup.Location = new System.Drawing.Point(0, 0);
            this.settingsGroup.Margin = new System.Windows.Forms.Padding(10);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Padding = new System.Windows.Forms.Padding(10);
            this.settingsGroup.Size = new System.Drawing.Size(306, 376);
            this.settingsGroup.TabIndex = 1;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // monitorLabel
            // 
            this.monitorLabel.AutoSize = true;
            this.monitorLabel.Location = new System.Drawing.Point(128, 235);
            this.monitorLabel.Name = "monitorLabel";
            this.monitorLabel.Size = new System.Drawing.Size(42, 13);
            this.monitorLabel.TabIndex = 25;
            this.monitorLabel.Text = "Monitor";
            // 
            // monitorsDropdown
            // 
            this.monitorsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorsDropdown.FormattingEnabled = true;
            this.monitorsDropdown.Location = new System.Drawing.Point(131, 251);
            this.monitorsDropdown.Name = "monitorsDropdown";
            this.monitorsDropdown.Size = new System.Drawing.Size(113, 21);
            this.monitorsDropdown.TabIndex = 24;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(128, 99);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 23;
            this.yLabel.Text = "Y";
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(131, 115);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(112, 20);
            this.yBox.TabIndex = 22;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(128, 55);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 21;
            this.xLabel.Text = "X";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(131, 71);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(112, 20);
            this.xBox.TabIndex = 20;
            // 
            // deleteSelectedProfile
            // 
            this.deleteSelectedProfile.Location = new System.Drawing.Point(131, 298);
            this.deleteSelectedProfile.Name = "deleteSelectedProfile";
            this.deleteSelectedProfile.Size = new System.Drawing.Size(112, 23);
            this.deleteSelectedProfile.TabIndex = 19;
            this.deleteSelectedProfile.Text = "Delete";
            this.deleteSelectedProfile.UseVisualStyleBackColor = true;
            this.deleteSelectedProfile.Click += new System.EventHandler(this.DeleteSelectedProfileClicked);
            // 
            // saveProfileBox
            // 
            this.saveProfileBox.Location = new System.Drawing.Point(12, 343);
            this.saveProfileBox.Name = "saveProfileBox";
            this.saveProfileBox.Size = new System.Drawing.Size(112, 20);
            this.saveProfileBox.TabIndex = 18;
            // 
            // saveProfile
            // 
            this.saveProfile.Location = new System.Drawing.Point(131, 343);
            this.saveProfile.Name = "saveProfile";
            this.saveProfile.Size = new System.Drawing.Size(112, 23);
            this.saveProfile.TabIndex = 17;
            this.saveProfile.Text = "Save";
            this.saveProfile.UseVisualStyleBackColor = true;
            this.saveProfile.Click += new System.EventHandler(this.SaveProfileClicked);
            // 
            // saveProfileLabel
            // 
            this.saveProfileLabel.AutoSize = true;
            this.saveProfileLabel.Location = new System.Drawing.Point(9, 327);
            this.saveProfileLabel.Name = "saveProfileLabel";
            this.saveProfileLabel.Size = new System.Drawing.Size(64, 13);
            this.saveProfileLabel.TabIndex = 16;
            this.saveProfileLabel.Text = "Save Profile";
            // 
            // profilesText
            // 
            this.profilesText.AutoSize = true;
            this.profilesText.Location = new System.Drawing.Point(9, 284);
            this.profilesText.Name = "profilesText";
            this.profilesText.Size = new System.Drawing.Size(41, 13);
            this.profilesText.TabIndex = 14;
            this.profilesText.Text = "Profiles";
            // 
            // profileDropdown
            // 
            this.profileDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileDropdown.FormattingEnabled = true;
            this.profileDropdown.Location = new System.Drawing.Point(12, 300);
            this.profileDropdown.Name = "profileDropdown";
            this.profileDropdown.Size = new System.Drawing.Size(113, 21);
            this.profileDropdown.TabIndex = 13;
            this.profileDropdown.SelectionChangeCommitted += new System.EventHandler(this.ProfileDropdownSelectionChangeCommitted);
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Location = new System.Drawing.Point(9, 235);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(25, 13);
            this.key.TabIndex = 12;
            this.key.Text = "Key";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(12, 251);
            this.keyBox.MaxLength = 1;
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(29, 20);
            this.keyBox.TabIndex = 11;
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Location = new System.Drawing.Point(12, 212);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(113, 17);
            this.minimize.TabIndex = 10;
            this.minimize.Text = "Minimize Windows";
            this.minimize.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(218, 160);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(25, 20);
            this.b.TabIndex = 9;
            // 
            // g
            // 
            this.g.Location = new System.Drawing.Point(113, 160);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(25, 20);
            this.g.TabIndex = 8;
            // 
            // pickColor
            // 
            this.pickColor.Location = new System.Drawing.Point(12, 186);
            this.pickColor.Name = "pickColor";
            this.pickColor.Size = new System.Drawing.Size(231, 20);
            this.pickColor.TabIndex = 7;
            this.pickColor.Text = "Pick";
            this.pickColor.UseVisualStyleBackColor = true;
            this.pickColor.Click += new System.EventHandler(this.PickColorPressed);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(9, 144);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(31, 13);
            this.color.TabIndex = 6;
            this.color.Text = "Color";
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(12, 160);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(25, 20);
            this.r.TabIndex = 5;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(9, 99);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(35, 13);
            this.width.TabIndex = 4;
            this.width.Text = "Width";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(12, 115);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(112, 20);
            this.widthBox.TabIndex = 3;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(9, 55);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(38, 13);
            this.height.TabIndex = 2;
            this.height.Text = "Height";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(12, 71);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(112, 20);
            this.heightBox.TabIndex = 1;
            // 
            // showMonitors
            // 
            this.showMonitors.Location = new System.Drawing.Point(47, 235);
            this.showMonitors.Name = "showMonitors";
            this.showMonitors.Size = new System.Drawing.Size(77, 36);
            this.showMonitors.TabIndex = 26;
            this.showMonitors.Text = "Show Monitors";
            this.showMonitors.UseVisualStyleBackColor = true;
            this.showMonitors.Click += new System.EventHandler(this.ShowMonitorsClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 376);
            this.Controls.Add(this.settingsGroup);
            this.Name = "MainForm";
            this.Text = "Device Locker";
            this.Load += new System.EventHandler(this.FormLoad);
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Button pickColor;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox g;
        private System.Windows.Forms.CheckBox minimize;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label profilesText;
        private System.Windows.Forms.ComboBox profileDropdown;
        private System.Windows.Forms.Button deleteSelectedProfile;
        private System.Windows.Forms.TextBox saveProfileBox;
        private System.Windows.Forms.Button saveProfile;
        private System.Windows.Forms.Label saveProfileLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label monitorLabel;
        private System.Windows.Forms.ComboBox monitorsDropdown;
        private System.Windows.Forms.Button showMonitors;
    }
}

