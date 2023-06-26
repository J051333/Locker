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
            this.settingsGroup.Size = new System.Drawing.Size(250, 277);
            this.settingsGroup.TabIndex = 1;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
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
            this.widthBox.Size = new System.Drawing.Size(231, 20);
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
            this.heightBox.Size = new System.Drawing.Size(231, 20);
            this.heightBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 277);
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
    }
}

