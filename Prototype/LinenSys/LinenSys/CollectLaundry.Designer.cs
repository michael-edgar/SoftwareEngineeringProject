namespace LinenSys
{
    partial class frmCollectLaundry
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.grpLinen = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLinen = new System.Windows.Forms.ComboBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuUpdateLinen.SuspendLayout();
            this.grpLinen.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(710, 24);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 355);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 22);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(251, 522);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(211, 22);
            this.btnCompleteOrder.TabIndex = 37;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(26, 326);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(211, 186);
            this.lstItems.TabIndex = 36;
            // 
            // grpLinen
            // 
            this.grpLinen.Controls.Add(this.btnAdd);
            this.grpLinen.Controls.Add(this.txtQty);
            this.grpLinen.Controls.Add(this.label4);
            this.grpLinen.Controls.Add(this.cboLinen);
            this.grpLinen.Location = new System.Drawing.Point(217, 236);
            this.grpLinen.Name = "grpLinen";
            this.grpLinen.Size = new System.Drawing.Size(477, 69);
            this.grpLinen.TabIndex = 35;
            this.grpLinen.TabStop = false;
            this.grpLinen.Text = "Linen";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(385, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 22);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(294, 24);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(64, 20);
            this.txtQty.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Qty";
            // 
            // cboLinen
            // 
            this.cboLinen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLinen.FormattingEnabled = true;
            this.cboLinen.Items.AddRange(new object[] {
            "BM Bath Mat",
            "BS Bath Sheet",
            "HT Hand Towel"});
            this.cboLinen.Location = new System.Drawing.Point(17, 24);
            this.cboLinen.Name = "cboLinen";
            this.cboLinen.Size = new System.Drawing.Size(228, 21);
            this.cboLinen.TabIndex = 11;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtCustomerID);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Location = new System.Drawing.Point(26, 236);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(167, 69);
            this.grpCustomer.TabIndex = 34;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Selected Customer";
            this.grpCustomer.Visible = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(87, 23);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(64, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.Surname,
            this.Forename,
            this.Phone});
            this.grdCustomers.Location = new System.Drawing.Point(15, 110);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(467, 109);
            this.grdCustomers.TabIndex = 33;
            this.grdCustomers.Visible = false;
            // 
            // CustID
            // 
            this.CustID.HeaderText = "Cust ID";
            this.CustID.Name = "CustID";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // Forename
            // 
            this.Forename.HeaderText = "Forename";
            this.Forename.Name = "Forename";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone No";
            this.Phone.Name = "Phone";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(397, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 22);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(192, 79);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(178, 20);
            this.txtCustomerName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Enter Customer Name (or part of)";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(65, 27);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(64, 20);
            this.txtOrderId.TabIndex = 29;
            this.txtOrderId.Text = "0156";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Order ID";
            // 
            // frmCollectLaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.grpLinen);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmCollectLaundry";
            this.Text = "CollectLaundry";
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.grpLinen.ResumeLayout(false);
            this.grpLinen.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.GroupBox grpLinen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLinen;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label1;
    }
}