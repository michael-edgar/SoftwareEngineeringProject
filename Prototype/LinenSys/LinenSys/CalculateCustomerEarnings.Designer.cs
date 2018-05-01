namespace LinenSys
{
    partial class frmCalculateCustomerEarnings
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
            this.txtEarnings = new System.Windows.Forms.TextBox();
            this.lblCustomerEarnings = new System.Windows.Forms.Label();
            this.btnCalculateEarnings = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCustomerID = new System.Windows.Forms.ComboBox();
            this.lblCustomerIDs = new System.Windows.Forms.Label();
            this.mnuUpdateLinen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(290, 24);
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
            // txtEarnings
            // 
            this.txtEarnings.Enabled = false;
            this.txtEarnings.Location = new System.Drawing.Point(124, 283);
            this.txtEarnings.Name = "txtEarnings";
            this.txtEarnings.Size = new System.Drawing.Size(136, 20);
            this.txtEarnings.TabIndex = 15;
            this.txtEarnings.Visible = false;
            // 
            // lblCustomerEarnings
            // 
            this.lblCustomerEarnings.AutoSize = true;
            this.lblCustomerEarnings.Location = new System.Drawing.Point(15, 286);
            this.lblCustomerEarnings.Name = "lblCustomerEarnings";
            this.lblCustomerEarnings.Size = new System.Drawing.Size(98, 13);
            this.lblCustomerEarnings.TabIndex = 14;
            this.lblCustomerEarnings.Text = "Customer Earnings:";
            this.lblCustomerEarnings.Visible = false;
            // 
            // btnCalculateEarnings
            // 
            this.btnCalculateEarnings.Location = new System.Drawing.Point(56, 228);
            this.btnCalculateEarnings.Name = "btnCalculateEarnings";
            this.btnCalculateEarnings.Size = new System.Drawing.Size(161, 23);
            this.btnCalculateEarnings.TabIndex = 13;
            this.btnCalculateEarnings.Text = "Calculate Customer Earnings";
            this.btnCalculateEarnings.UseVisualStyleBackColor = true;
            this.btnCalculateEarnings.Visible = false;
            this.btnCalculateEarnings.Click += new System.EventHandler(this.btnCalculateEarnings_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(86, 66);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 17;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(12, 69);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(68, 13);
            this.lblCustID.TabIndex = 16;
            this.lblCustID.Text = "Customer ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(86, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 22);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCustomerID
            // 
            this.cboCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerID.FormattingEnabled = true;
            this.cboCustomerID.Items.AddRange(new object[] {
            "BM Bath Mat",
            "BS Bath Sheet",
            "HT Hand Towel"});
            this.cboCustomerID.Location = new System.Drawing.Point(86, 152);
            this.cboCustomerID.Name = "cboCustomerID";
            this.cboCustomerID.Size = new System.Drawing.Size(131, 21);
            this.cboCustomerID.TabIndex = 20;
            this.cboCustomerID.Visible = false;
            this.cboCustomerID.SelectedIndexChanged += new System.EventHandler(this.cboCustomerID_SelectedIndexChanged);
            // 
            // lblCustomerIDs
            // 
            this.lblCustomerIDs.AutoSize = true;
            this.lblCustomerIDs.Location = new System.Drawing.Point(15, 155);
            this.lblCustomerIDs.Name = "lblCustomerIDs";
            this.lblCustomerIDs.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerIDs.TabIndex = 18;
            this.lblCustomerIDs.Text = "Customer ID";
            this.lblCustomerIDs.Visible = false;
            // 
            // frmCalculateCustomerEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 332);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboCustomerID);
            this.Controls.Add(this.lblCustomerIDs);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.txtEarnings);
            this.Controls.Add(this.lblCustomerEarnings);
            this.Controls.Add(this.btnCalculateEarnings);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmCalculateCustomerEarnings";
            this.Text = "CalculateCustomerEarnings";
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEarnings;
        private System.Windows.Forms.Label lblCustomerEarnings;
        private System.Windows.Forms.Button btnCalculateEarnings;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboCustomerID;
        private System.Windows.Forms.Label lblCustomerIDs;
    }
}