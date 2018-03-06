namespace LinenSys
{
    partial class frmUpdateLinen
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
            this.txtLinenCode = new System.Windows.Forms.TextBox();
            this.lblLinenCode = new System.Windows.Forms.Label();
            this.btnGetLinen = new System.Windows.Forms.Button();
            this.cboLinenNames = new System.Windows.Forms.ComboBox();
            this.lblLinenNames = new System.Windows.Forms.Label();
            this.grpLinen = new System.Windows.Forms.GroupBox();
            this.txtPackSize = new System.Windows.Forms.TextBox();
            this.btnUpdateLinen = new System.Windows.Forms.Button();
            this.lblPackSize = new System.Windows.Forms.Label();
            this.txtRejectPrice = new System.Windows.Forms.TextBox();
            this.txtCleaningPrice = new System.Windows.Forms.TextBox();
            this.txtHirePrice = new System.Windows.Forms.TextBox();
            this.txtLinenName = new System.Windows.Forms.TextBox();
            this.lblRejectPrice = new System.Windows.Forms.Label();
            this.lblCleaningPrice = new System.Windows.Forms.Label();
            this.lblHirePrice = new System.Windows.Forms.Label();
            this.lblLinenName = new System.Windows.Forms.Label();
            this.mnuUpdateLinen = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLinenCodeForUpdate = new System.Windows.Forms.TextBox();
            this.grpLinen.SuspendLayout();
            this.mnuUpdateLinen.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLinenCode
            // 
            this.txtLinenCode.Location = new System.Drawing.Point(163, 53);
            this.txtLinenCode.Name = "txtLinenCode";
            this.txtLinenCode.Size = new System.Drawing.Size(123, 20);
            this.txtLinenCode.TabIndex = 0;
            // 
            // lblLinenCode
            // 
            this.lblLinenCode.AutoSize = true;
            this.lblLinenCode.Location = new System.Drawing.Point(62, 56);
            this.lblLinenCode.Name = "lblLinenCode";
            this.lblLinenCode.Size = new System.Drawing.Size(61, 13);
            this.lblLinenCode.TabIndex = 1;
            this.lblLinenCode.Text = "Linen Code";
            // 
            // btnGetLinen
            // 
            this.btnGetLinen.Location = new System.Drawing.Point(301, 53);
            this.btnGetLinen.Name = "btnGetLinen";
            this.btnGetLinen.Size = new System.Drawing.Size(75, 23);
            this.btnGetLinen.TabIndex = 2;
            this.btnGetLinen.Text = "Get Linen";
            this.btnGetLinen.UseVisualStyleBackColor = true;
            this.btnGetLinen.Click += new System.EventHandler(this.btnGetLinen_Click);
            // 
            // cboLinenNames
            // 
            this.cboLinenNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLinenNames.FormattingEnabled = true;
            this.cboLinenNames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboLinenNames.Location = new System.Drawing.Point(163, 203);
            this.cboLinenNames.Name = "cboLinenNames";
            this.cboLinenNames.Size = new System.Drawing.Size(123, 21);
            this.cboLinenNames.TabIndex = 3;
            this.cboLinenNames.Visible = false;
            this.cboLinenNames.SelectedIndexChanged += new System.EventHandler(this.cboLinenNames_SelectedIndexChanged);
            // 
            // lblLinenNames
            // 
            this.lblLinenNames.AutoSize = true;
            this.lblLinenNames.Location = new System.Drawing.Point(62, 206);
            this.lblLinenNames.Name = "lblLinenNames";
            this.lblLinenNames.Size = new System.Drawing.Size(69, 13);
            this.lblLinenNames.TabIndex = 5;
            this.lblLinenNames.Text = "Linen Names";
            this.lblLinenNames.Visible = false;
            // 
            // grpLinen
            // 
            this.grpLinen.Controls.Add(this.txtPackSize);
            this.grpLinen.Controls.Add(this.btnUpdateLinen);
            this.grpLinen.Controls.Add(this.lblPackSize);
            this.grpLinen.Controls.Add(this.txtRejectPrice);
            this.grpLinen.Controls.Add(this.txtCleaningPrice);
            this.grpLinen.Controls.Add(this.txtHirePrice);
            this.grpLinen.Controls.Add(this.txtLinenName);
            this.grpLinen.Controls.Add(this.lblRejectPrice);
            this.grpLinen.Controls.Add(this.lblCleaningPrice);
            this.grpLinen.Controls.Add(this.lblHirePrice);
            this.grpLinen.Controls.Add(this.lblLinenName);
            this.grpLinen.Location = new System.Drawing.Point(457, 53);
            this.grpLinen.Name = "grpLinen";
            this.grpLinen.Size = new System.Drawing.Size(273, 263);
            this.grpLinen.TabIndex = 6;
            this.grpLinen.TabStop = false;
            this.grpLinen.Text = "Linen";
            this.grpLinen.Visible = false;
            // 
            // txtPackSize
            // 
            this.txtPackSize.Location = new System.Drawing.Point(121, 186);
            this.txtPackSize.Name = "txtPackSize";
            this.txtPackSize.Size = new System.Drawing.Size(146, 20);
            this.txtPackSize.TabIndex = 16;
            // 
            // btnUpdateLinen
            // 
            this.btnUpdateLinen.Location = new System.Drawing.Point(93, 234);
            this.btnUpdateLinen.Name = "btnUpdateLinen";
            this.btnUpdateLinen.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateLinen.TabIndex = 7;
            this.btnUpdateLinen.Text = "Save";
            this.btnUpdateLinen.UseVisualStyleBackColor = true;
            this.btnUpdateLinen.Click += new System.EventHandler(this.btnUpdateLinen_Click);
            // 
            // lblPackSize
            // 
            this.lblPackSize.AutoSize = true;
            this.lblPackSize.Location = new System.Drawing.Point(6, 189);
            this.lblPackSize.Name = "lblPackSize";
            this.lblPackSize.Size = new System.Drawing.Size(58, 13);
            this.lblPackSize.TabIndex = 15;
            this.lblPackSize.Text = "Pack Size:";
            // 
            // txtRejectPrice
            // 
            this.txtRejectPrice.Location = new System.Drawing.Point(121, 146);
            this.txtRejectPrice.Name = "txtRejectPrice";
            this.txtRejectPrice.Size = new System.Drawing.Size(146, 20);
            this.txtRejectPrice.TabIndex = 14;
            // 
            // txtCleaningPrice
            // 
            this.txtCleaningPrice.Location = new System.Drawing.Point(121, 104);
            this.txtCleaningPrice.Name = "txtCleaningPrice";
            this.txtCleaningPrice.Size = new System.Drawing.Size(146, 20);
            this.txtCleaningPrice.TabIndex = 13;
            // 
            // txtHirePrice
            // 
            this.txtHirePrice.Location = new System.Drawing.Point(121, 54);
            this.txtHirePrice.Name = "txtHirePrice";
            this.txtHirePrice.Size = new System.Drawing.Size(146, 20);
            this.txtHirePrice.TabIndex = 12;
            // 
            // txtLinenName
            // 
            this.txtLinenName.Location = new System.Drawing.Point(121, 13);
            this.txtLinenName.Name = "txtLinenName";
            this.txtLinenName.Size = new System.Drawing.Size(146, 20);
            this.txtLinenName.TabIndex = 10;
            // 
            // lblRejectPrice
            // 
            this.lblRejectPrice.AutoSize = true;
            this.lblRejectPrice.Location = new System.Drawing.Point(6, 149);
            this.lblRejectPrice.Name = "lblRejectPrice";
            this.lblRejectPrice.Size = new System.Drawing.Size(68, 13);
            this.lblRejectPrice.TabIndex = 9;
            this.lblRejectPrice.Text = "Reject Price:";
            // 
            // lblCleaningPrice
            // 
            this.lblCleaningPrice.AutoSize = true;
            this.lblCleaningPrice.Location = new System.Drawing.Point(6, 107);
            this.lblCleaningPrice.Name = "lblCleaningPrice";
            this.lblCleaningPrice.Size = new System.Drawing.Size(78, 13);
            this.lblCleaningPrice.TabIndex = 8;
            this.lblCleaningPrice.Text = "Cleaning Price:";
            // 
            // lblHirePrice
            // 
            this.lblHirePrice.AutoSize = true;
            this.lblHirePrice.Location = new System.Drawing.Point(6, 57);
            this.lblHirePrice.Name = "lblHirePrice";
            this.lblHirePrice.Size = new System.Drawing.Size(56, 13);
            this.lblHirePrice.TabIndex = 7;
            this.lblHirePrice.Text = "Hire Price:";
            // 
            // lblLinenName
            // 
            this.lblLinenName.AutoSize = true;
            this.lblLinenName.Location = new System.Drawing.Point(6, 16);
            this.lblLinenName.Name = "lblLinenName";
            this.lblLinenName.Size = new System.Drawing.Size(67, 13);
            this.lblLinenName.TabIndex = 5;
            this.lblLinenName.Text = "Linen Name:";
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(795, 24);
            this.mnuUpdateLinen.TabIndex = 8;
            this.mnuUpdateLinen.Text = "mnuUpdateLinen";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // txtLinenCodeForUpdate
            // 
            this.txtLinenCodeForUpdate.Location = new System.Drawing.Point(578, 360);
            this.txtLinenCodeForUpdate.Name = "txtLinenCodeForUpdate";
            this.txtLinenCodeForUpdate.Size = new System.Drawing.Size(146, 20);
            this.txtLinenCodeForUpdate.TabIndex = 12;
            this.txtLinenCodeForUpdate.Visible = false;
            // 
            // frmUpdateLinen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.txtLinenCodeForUpdate);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Controls.Add(this.grpLinen);
            this.Controls.Add(this.lblLinenNames);
            this.Controls.Add(this.cboLinenNames);
            this.Controls.Add(this.btnGetLinen);
            this.Controls.Add(this.lblLinenCode);
            this.Controls.Add(this.txtLinenCode);
            this.Name = "frmUpdateLinen";
            this.Text = "UpdateLinen";
            this.Load += new System.EventHandler(this.frmUpdateLinen_Load);
            this.grpLinen.ResumeLayout(false);
            this.grpLinen.PerformLayout();
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinenCode;
        private System.Windows.Forms.Label lblLinenCode;
        private System.Windows.Forms.Button btnGetLinen;
        private System.Windows.Forms.ComboBox cboLinenNames;
        private System.Windows.Forms.Label lblLinenNames;
        private System.Windows.Forms.GroupBox grpLinen;
        private System.Windows.Forms.TextBox txtPackSize;
        private System.Windows.Forms.Label lblPackSize;
        private System.Windows.Forms.TextBox txtRejectPrice;
        private System.Windows.Forms.TextBox txtCleaningPrice;
        private System.Windows.Forms.TextBox txtHirePrice;
        private System.Windows.Forms.TextBox txtLinenName;
        private System.Windows.Forms.Label lblRejectPrice;
        private System.Windows.Forms.Label lblCleaningPrice;
        private System.Windows.Forms.Label lblHirePrice;
        private System.Windows.Forms.Label lblLinenName;
        private System.Windows.Forms.Button btnUpdateLinen;
        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLinenCodeForUpdate;
    }
}