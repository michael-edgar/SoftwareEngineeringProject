namespace LinenSys
{
    partial class frmRemoveCustomer
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
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.lblCompanyNames = new System.Windows.Forms.Label();
            this.cboCompanyNames = new System.Windows.Forms.ComboBox();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.mnuUpdateLinen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(298, 24);
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
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(87, 258);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveCustomer.TabIndex = 21;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Visible = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click_1);
            // 
            // lblCompanyNames
            // 
            this.lblCompanyNames.AutoSize = true;
            this.lblCompanyNames.Location = new System.Drawing.Point(37, 209);
            this.lblCompanyNames.Name = "lblCompanyNames";
            this.lblCompanyNames.Size = new System.Drawing.Size(87, 13);
            this.lblCompanyNames.TabIndex = 20;
            this.lblCompanyNames.Text = "Company Names";
            this.lblCompanyNames.Visible = false;
            // 
            // cboCompanyNames
            // 
            this.cboCompanyNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompanyNames.FormattingEnabled = true;
            this.cboCompanyNames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCompanyNames.Location = new System.Drawing.Point(138, 206);
            this.cboCompanyNames.Name = "cboCompanyNames";
            this.cboCompanyNames.Size = new System.Drawing.Size(123, 21);
            this.cboCompanyNames.TabIndex = 19;
            this.cboCompanyNames.Visible = false;
            this.cboCompanyNames.SelectedIndexChanged += new System.EventHandler(this.cboCompanyNames_SelectedIndexChanged);
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(87, 107);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(105, 23);
            this.btnGetCustomer.TabIndex = 18;
            this.btnGetCustomer.Text = "Get Customers";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click_1);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(37, 59);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 17;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(138, 56);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(123, 20);
            this.txtCustomerID.TabIndex = 16;
            // 
            // frmRemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 324);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.lblCompanyNames);
            this.Controls.Add(this.cboCompanyNames);
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmRemoveCustomer";
            this.Text = "RemoveCustomer";
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Label lblCompanyNames;
        private System.Windows.Forms.ComboBox cboCompanyNames;
        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
    }
}