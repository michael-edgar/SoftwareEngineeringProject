namespace LinenSys
{
    partial class frmUpdateCustomer
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
            this.lblCompanyNames = new System.Windows.Forms.Label();
            this.cboCompanyNames = new System.Windows.Forms.ComboBox();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.txtRejects = new System.Windows.Forms.TextBox();
            this.lblRejects = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCustomerIDDisplay = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCustomerIDDisplay = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.mnuUpdateLinen.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(1104, 24);
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
            // lblCompanyNames
            // 
            this.lblCompanyNames.AutoSize = true;
            this.lblCompanyNames.Location = new System.Drawing.Point(12, 207);
            this.lblCompanyNames.Name = "lblCompanyNames";
            this.lblCompanyNames.Size = new System.Drawing.Size(87, 13);
            this.lblCompanyNames.TabIndex = 14;
            this.lblCompanyNames.Text = "Company Names";
            this.lblCompanyNames.Visible = false;
            // 
            // cboCompanyNames
            // 
            this.cboCompanyNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompanyNames.FormattingEnabled = true;
            this.cboCompanyNames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCompanyNames.Location = new System.Drawing.Point(113, 204);
            this.cboCompanyNames.Name = "cboCompanyNames";
            this.cboCompanyNames.Size = new System.Drawing.Size(123, 21);
            this.cboCompanyNames.TabIndex = 13;
            this.cboCompanyNames.Visible = false;
            this.cboCompanyNames.SelectedIndexChanged += new System.EventHandler(this.cboCompanyNames_SelectedIndexChanged_1);
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(100, 136);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnGetCustomer.TabIndex = 12;
            this.btnGetCustomer.Text = "Get Customer";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(50, 88);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 11;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(151, 85);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(61, 20);
            this.txtCustomerID.TabIndex = 10;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnUpdateCustomer);
            this.grpCustomer.Controls.Add(this.txtRejects);
            this.grpCustomer.Controls.Add(this.lblRejects);
            this.grpCustomer.Controls.Add(this.txtEircode);
            this.grpCustomer.Controls.Add(this.lblEircode);
            this.grpCustomer.Controls.Add(this.txtCounty);
            this.grpCustomer.Controls.Add(this.lblCounty);
            this.grpCustomer.Controls.Add(this.txtTown);
            this.grpCustomer.Controls.Add(this.txtCustomerIDDisplay);
            this.grpCustomer.Controls.Add(this.lblTown);
            this.grpCustomer.Controls.Add(this.txtStreet);
            this.grpCustomer.Controls.Add(this.txtEmail);
            this.grpCustomer.Controls.Add(this.txtCompanyName);
            this.grpCustomer.Controls.Add(this.lblCustomerIDDisplay);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.txtContactNumber);
            this.grpCustomer.Controls.Add(this.lblStreet);
            this.grpCustomer.Controls.Add(this.lblEmail);
            this.grpCustomer.Controls.Add(this.lblCustomerName);
            this.grpCustomer.Controls.Add(this.lblContactNumber);
            this.grpCustomer.Controls.Add(this.lblCompanyName);
            this.grpCustomer.Location = new System.Drawing.Point(266, 54);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(826, 292);
            this.grpCustomer.TabIndex = 16;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            this.grpCustomer.Visible = false;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(395, 263);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 22;
            this.btnUpdateCustomer.Text = "Save";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click_1);
            // 
            // txtRejects
            // 
            this.txtRejects.Location = new System.Drawing.Point(583, 205);
            this.txtRejects.MaxLength = 8;
            this.txtRejects.Name = "txtRejects";
            this.txtRejects.Size = new System.Drawing.Size(102, 20);
            this.txtRejects.TabIndex = 20;
            // 
            // lblRejects
            // 
            this.lblRejects.AutoSize = true;
            this.lblRejects.Location = new System.Drawing.Point(519, 208);
            this.lblRejects.Name = "lblRejects";
            this.lblRejects.Size = new System.Drawing.Size(46, 13);
            this.lblRejects.TabIndex = 21;
            this.lblRejects.Text = "Rejects:";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(583, 158);
            this.txtEircode.MaxLength = 8;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(102, 20);
            this.txtEircode.TabIndex = 7;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(519, 161);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(46, 13);
            this.lblEircode.TabIndex = 19;
            this.lblEircode.Text = "Eircode:";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(582, 115);
            this.txtCounty.MaxLength = 10;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(123, 20);
            this.txtCounty.TabIndex = 6;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(519, 114);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 17;
            this.lblCounty.Text = "County:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(582, 66);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(233, 20);
            this.txtTown.TabIndex = 5;
            // 
            // txtCustomerIDDisplay
            // 
            this.txtCustomerIDDisplay.Enabled = false;
            this.txtCustomerIDDisplay.Location = new System.Drawing.Point(122, 19);
            this.txtCustomerIDDisplay.MaxLength = 3;
            this.txtCustomerIDDisplay.Name = "txtCustomerIDDisplay";
            this.txtCustomerIDDisplay.Size = new System.Drawing.Size(53, 20);
            this.txtCustomerIDDisplay.TabIndex = 0;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(518, 69);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 15;
            this.lblTown.Text = "Town:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(582, 23);
            this.txtStreet.MaxLength = 20;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(233, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 158);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(122, 70);
            this.txtCompanyName.MaxLength = 20;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(232, 20);
            this.txtCompanyName.TabIndex = 0;
            // 
            // lblCustomerIDDisplay
            // 
            this.lblCustomerIDDisplay.AutoSize = true;
            this.lblCustomerIDDisplay.Location = new System.Drawing.Point(7, 22);
            this.lblCustomerIDDisplay.Name = "lblCustomerIDDisplay";
            this.lblCustomerIDDisplay.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerIDDisplay.TabIndex = 6;
            this.lblCustomerIDDisplay.Text = "Customer ID:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(121, 113);
            this.txtCustomerName.MaxLength = 20;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(233, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(122, 205);
            this.txtContactNumber.MaxLength = 10;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(122, 20);
            this.txtContactNumber.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(519, 26);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 9;
            this.lblStreet.Text = "Street:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 161);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(6, 116);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(7, 208);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 6;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(7, 73);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 380);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.lblCompanyNames);
            this.Controls.Add(this.cboCompanyNames);
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmUpdateCustomer";
            this.Text = "UpdateCustomer";
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblCompanyNames;
        private System.Windows.Forms.ComboBox cboCompanyNames;
        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtRejects;
        private System.Windows.Forms.Label lblRejects;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCustomerIDDisplay;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCustomerIDDisplay;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnUpdateCustomer;
    }
}