namespace LinenSys
{
    partial class frmTrackRejectCost
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
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCalculateRejectCost = new System.Windows.Forms.Button();
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
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(125, 167);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(136, 20);
            this.txtCost.TabIndex = 15;
            this.txtCost.Visible = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(24, 170);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(58, 13);
            this.lblTotalCost.TabIndex = 14;
            this.lblTotalCost.Text = "Total Cost:";
            this.lblTotalCost.Visible = false;
            // 
            // btnCalculateRejectCost
            // 
            this.btnCalculateRejectCost.Location = new System.Drawing.Point(93, 73);
            this.btnCalculateRejectCost.Name = "btnCalculateRejectCost";
            this.btnCalculateRejectCost.Size = new System.Drawing.Size(117, 23);
            this.btnCalculateRejectCost.TabIndex = 13;
            this.btnCalculateRejectCost.Text = "Calculate Reject Cost";
            this.btnCalculateRejectCost.UseVisualStyleBackColor = true;
            this.btnCalculateRejectCost.Click += new System.EventHandler(this.btnCalculateRejectCost_Click);
            // 
            // frmTrackRejectCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnCalculateRejectCost);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmTrackRejectCost";
            this.Text = "TrackRejectCost";
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCalculateRejectCost;
    }
}