namespace Locker {
    partial class MonitorIndicator {
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
            this.monitorNum = new System.Windows.Forms.Label();
            this.Esc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monitorNum
            // 
            this.monitorNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitorNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.monitorNum.Location = new System.Drawing.Point(0, 0);
            this.monitorNum.Name = "monitorNum";
            this.monitorNum.Size = new System.Drawing.Size(422, 295);
            this.monitorNum.TabIndex = 0;
            this.monitorNum.Text = "Mon";
            this.monitorNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Esc
            // 
            this.Esc.AutoSize = true;
            this.Esc.Location = new System.Drawing.Point(12, 9);
            this.Esc.Name = "Esc";
            this.Esc.Size = new System.Drawing.Size(66, 13);
            this.Esc.TabIndex = 1;
            this.Esc.Text = "Esc to Close";
            // 
            // MonitorIndicator
            // 
            this.ClientSize = new System.Drawing.Size(422, 295);
            this.Controls.Add(this.Esc);
            this.Controls.Add(this.monitorNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonitorIndicator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monitorNum;
        private System.Windows.Forms.Label Esc;
    }
}