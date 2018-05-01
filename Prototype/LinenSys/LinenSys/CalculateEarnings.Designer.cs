namespace LinenSys
{
    partial class frmCalculateEarnings
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
            this.mnuUpdateLinen = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculateEarnings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEarnings = new System.Windows.Forms.TextBox();
            this.mnuUpdateLinen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(284, 24);
            this.mnuUpdateLinen.TabIndex = 9;
            this.mnuUpdateLinen.Text = "mnuUpdateLinen";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // btnCalculateEarnings
            // 
            this.btnCalculateEarnings.Location = new System.Drawing.Point(81, 57);
            this.btnCalculateEarnings.Name = "btnCalculateEarnings";
            this.btnCalculateEarnings.Size = new System.Drawing.Size(117, 23);
            this.btnCalculateEarnings.TabIndex = 10;
            this.btnCalculateEarnings.Text = "Calculate Earnings";
            this.btnCalculateEarnings.UseVisualStyleBackColor = true;
            this.btnCalculateEarnings.Click += new System.EventHandler(this.btnCalculateEarnings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Earnings:";
            this.label1.Visible = false;
            // 
            // txtEarnings
            // 
            this.txtEarnings.Enabled = false;
            this.txtEarnings.Location = new System.Drawing.Point(113, 151);
            this.txtEarnings.Name = "txtEarnings";
            this.txtEarnings.Size = new System.Drawing.Size(85, 20);
            this.txtEarnings.TabIndex = 12;
            this.txtEarnings.Visible = false;
            // 
            // frmCalculateEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtEarnings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateEarnings);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmCalculateEarnings";
            this.Text = "CalculateEarnings";
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Button btnCalculateEarnings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEarnings;
    }
}