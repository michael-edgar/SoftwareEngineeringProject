namespace LinenSys
{
    partial class frmAddLinen
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
            this.grpLinen = new System.Windows.Forms.GroupBox();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.lblPackSize = new System.Windows.Forms.Label();
            this.txtRejectPrice = new System.Windows.Forms.TextBox();
            this.txtCleaningPrice = new System.Windows.Forms.TextBox();
            this.txtHirePrice = new System.Windows.Forms.TextBox();
            this.txtLinenCode = new System.Windows.Forms.TextBox();
            this.txtLinenName = new System.Windows.Forms.TextBox();
            this.lblRejectPrice = new System.Windows.Forms.Label();
            this.lblCleaningPrice = new System.Windows.Forms.Label();
            this.lblHirePrice = new System.Windows.Forms.Label();
            this.lblLinenCode = new System.Windows.Forms.Label();
            this.lblLinenName = new System.Windows.Forms.Label();
            this.btnAddLinen = new System.Windows.Forms.Button();
            this.mnuAddLinen = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLinen.SuspendLayout();
            this.mnuAddLinen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLinen
            // 
            this.grpLinen.Controls.Add(this.txtPackSize);
            this.grpLinen.Controls.Add(this.lblPackSize);
            this.grpLinen.Controls.Add(this.txtRejectPrice);
            this.grpLinen.Controls.Add(this.txtCleaningPrice);
            this.grpLinen.Controls.Add(this.txtHirePrice);
            this.grpLinen.Controls.Add(this.txtLinenCode);
            this.grpLinen.Controls.Add(this.txtLinenName);
            this.grpLinen.Controls.Add(this.lblRejectPrice);
            this.grpLinen.Controls.Add(this.lblCleaningPrice);
            this.grpLinen.Controls.Add(this.lblHirePrice);
            this.grpLinen.Controls.Add(this.lblLinenCode);
            this.grpLinen.Controls.Add(this.lblLinenName);
            this.grpLinen.Location = new System.Drawing.Point(12, 27);
            this.grpLinen.Name = "grpLinen";
            this.grpLinen.Size = new System.Drawing.Size(361, 286);
            this.grpLinen.TabIndex = 5;
            this.grpLinen.TabStop = false;
            this.grpLinen.Text = "Linen";
            this.grpLinen.Enter += new System.EventHandler(this.grpLinen_Enter);
            // 
            // txtPackSize
            // 
            this.txtPackSize.Location = new System.Drawing.Point(121, 245);
            this.txtPackSize.MaxLength = 3;
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.Size = new System.Drawing.Size(42, 20);
            this.txtPackSize.TabIndex = 5;
            // 
            // lblPackSize
            // 
            this.lblPackSize.AutoSize = true;
            this.lblPackSize.Location = new System.Drawing.Point(6, 248);
            this.lblPackSize.Name = "lblPackSize";
            this.lblPackSize.Size = new System.Drawing.Size(58, 13);
            this.lblPackSize.TabIndex = 15;
            this.lblPackSize.Text = "Pack Size:";
            // 
            // txtRejectPrice
            // 
            this.txtRejectPrice.Location = new System.Drawing.Point(121, 205);
            this.txtRejectPrice.MaxLength = 7;
            this.txtRejectPrice.Name = "txtRejectPrice";
            this.txtRejectPrice.Size = new System.Drawing.Size(75, 20);
            this.txtRejectPrice.TabIndex = 4;
            this.txtRejectPrice.Text = "0.00";
            this.txtRejectPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCleaningPrice
            // 
            this.txtCleaningPrice.Location = new System.Drawing.Point(121, 163);
            this.txtCleaningPrice.MaxLength = 7;
            this.txtCleaningPrice.Name = "txtCleaningPrice";
            this.txtCleaningPrice.Size = new System.Drawing.Size(75, 20);
            this.txtCleaningPrice.TabIndex = 3;
            this.txtCleaningPrice.Text = "0.00";
            this.txtCleaningPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHirePrice
            // 
            this.txtHirePrice.Location = new System.Drawing.Point(121, 113);
            this.txtHirePrice.MaxLength = 7;
            this.txtHirePrice.Name = "txtHirePrice";
            this.txtHirePrice.Size = new System.Drawing.Size(75, 20);
            this.txtHirePrice.TabIndex = 2;
            this.txtHirePrice.Text = "0.00";
            this.txtHirePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLinenCode
            // 
            this.txtLinenCode.Location = new System.Drawing.Point(121, 10);
            this.txtLinenCode.MaxLength = 3;
            this.txtLinenCode.Name = "txtLinenCode";
            this.txtLinenCode.Size = new System.Drawing.Size(42, 20);
            this.txtLinenCode.TabIndex = 0;
            // 
            // txtLinenName
            // 
            this.txtLinenName.Location = new System.Drawing.Point(121, 61);
            this.txtLinenName.MaxLength = 30;
            this.txtLinenName.Name = "txtLinenName";
            this.txtLinenName.Size = new System.Drawing.Size(234, 20);
            this.txtLinenName.TabIndex = 1;
            // 
            // lblRejectPrice
            // 
            this.lblRejectPrice.AutoSize = true;
            this.lblRejectPrice.Location = new System.Drawing.Point(6, 208);
            this.lblRejectPrice.Name = "lblRejectPrice";
            this.lblRejectPrice.Size = new System.Drawing.Size(68, 13);
            this.lblRejectPrice.TabIndex = 9;
            this.lblRejectPrice.Text = "Reject Price:";
            // 
            // lblCleaningPrice
            // 
            this.lblCleaningPrice.AutoSize = true;
            this.lblCleaningPrice.Location = new System.Drawing.Point(6, 166);
            this.lblCleaningPrice.Name = "lblCleaningPrice";
            this.lblCleaningPrice.Size = new System.Drawing.Size(78, 13);
            this.lblCleaningPrice.TabIndex = 8;
            this.lblCleaningPrice.Text = "Cleaning Price:";
            // 
            // lblHirePrice
            // 
            this.lblHirePrice.AutoSize = true;
            this.lblHirePrice.Location = new System.Drawing.Point(6, 116);
            this.lblHirePrice.Name = "lblHirePrice";
            this.lblHirePrice.Size = new System.Drawing.Size(56, 13);
            this.lblHirePrice.TabIndex = 7;
            this.lblHirePrice.Text = "Hire Price:";
            // 
            // lblLinenCode
            // 
            this.lblLinenCode.AutoSize = true;
            this.lblLinenCode.Location = new System.Drawing.Point(6, 13);
            this.lblLinenCode.Name = "lblLinenCode";
            this.lblLinenCode.Size = new System.Drawing.Size(64, 13);
            this.lblLinenCode.TabIndex = 6;
            this.lblLinenCode.Text = "Linen Code:";
            // 
            // lblLinenName
            // 
            this.lblLinenName.AutoSize = true;
            this.lblLinenName.Location = new System.Drawing.Point(6, 64);
            this.lblLinenName.Name = "lblLinenName";
            this.lblLinenName.Size = new System.Drawing.Size(67, 13);
            this.lblLinenName.TabIndex = 5;
            this.lblLinenName.Text = "Linen Name:";
            // 
            // btnAddLinen
            // 
            this.btnAddLinen.Location = new System.Drawing.Point(21, 322);
            this.btnAddLinen.Name = "btnAddLinen";
            this.btnAddLinen.Size = new System.Drawing.Size(352, 23);
            this.btnAddLinen.TabIndex = 6;
            this.btnAddLinen.Text = "Save";
            this.btnAddLinen.UseVisualStyleBackColor = true;
            this.btnAddLinen.Click += new System.EventHandler(this.btnAddLinen_Click);
            // 
            // mnuAddLinen
            // 
            this.mnuAddLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuAddLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuAddLinen.Name = "mnuAddLinen";
            this.mnuAddLinen.Size = new System.Drawing.Size(398, 24);
            this.mnuAddLinen.TabIndex = 7;
            this.mnuAddLinen.Text = "mnuAddLinen";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmAddLinen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 378);
            this.Controls.Add(this.btnAddLinen);
            this.Controls.Add(this.grpLinen);
            this.Controls.Add(this.mnuAddLinen);
            this.MainMenuStrip = this.mnuAddLinen;
            this.Name = "frmAddLinen";
            this.Text = "Add Linen";
            this.Load += new System.EventHandler(this.frmAddLinen_Load);
            this.grpLinen.ResumeLayout(false);
            this.grpLinen.PerformLayout();
            this.mnuAddLinen.ResumeLayout(false);
            this.mnuAddLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLinen;
        private System.Windows.Forms.TextBox txtRejectPrice;
        private System.Windows.Forms.TextBox txtCleaningPrice;
        private System.Windows.Forms.TextBox txtHirePrice;
        private System.Windows.Forms.TextBox txtLinenCode;
        private System.Windows.Forms.TextBox txtLinenName;
        private System.Windows.Forms.Label lblRejectPrice;
        private System.Windows.Forms.Label lblCleaningPrice;
        private System.Windows.Forms.Label lblHirePrice;
        private System.Windows.Forms.Label lblLinenCode;
        private System.Windows.Forms.Label lblLinenName;
        private System.Windows.Forms.Button btnAddLinen;
        private System.Windows.Forms.MenuStrip mnuAddLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPackSize;
        private System.Windows.Forms.Label lblPackSize;
    }
}

