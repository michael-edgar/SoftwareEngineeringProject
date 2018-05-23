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
            this.txtCustomerIDDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rejects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.lstAmount = new System.Windows.Forms.ListBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.mnuUpdateLinen.SuspendLayout();
            this.grpLinen.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.grpOrder.SuspendLayout();
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
            this.btnDelete.Location = new System.Drawing.Point(310, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 22);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(349, 184);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(211, 22);
            this.btnCompleteOrder.TabIndex = 37;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Visible = false;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(17, 29);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(83, 186);
            this.lstItems.TabIndex = 36;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
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
            this.grpLinen.Visible = false;
            this.grpLinen.VisibleChanged += new System.EventHandler(this.grpLinen_VisibleChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(385, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 22);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(308, 24);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(64, 20);
            this.txtQty.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Packs";
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
            this.cboLinen.SelectedIndexChanged += new System.EventHandler(this.cboLinen_SelectedIndexChanged);
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtCustomerIDDisplay);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Location = new System.Drawing.Point(26, 236);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(167, 69);
            this.grpCustomer.TabIndex = 34;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Selected Customer";
            this.grpCustomer.Visible = false;
            // 
            // txtCustomerIDDisplay
            // 
            this.txtCustomerIDDisplay.Enabled = false;
            this.txtCustomerIDDisplay.Location = new System.Drawing.Point(87, 23);
            this.txtCustomerIDDisplay.Name = "txtCustomerIDDisplay";
            this.txtCustomerIDDisplay.Size = new System.Drawing.Size(64, 20);
            this.txtCustomerIDDisplay.TabIndex = 3;
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
            this.Company,
            this.Customers,
            this.Phone,
            this.Rejects});
            this.grdCustomers.Location = new System.Drawing.Point(15, 110);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(549, 109);
            this.grdCustomers.TabIndex = 33;
            this.grdCustomers.Visible = false;
            this.grdCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellClick);
            // 
            // CustID
            // 
            this.CustID.HeaderText = "Cust ID";
            this.CustID.Name = "CustID";
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Customers
            // 
            this.Customers.HeaderText = "Customer";
            this.Customers.Name = "Customers";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone No";
            this.Phone.Name = "Phone";
            // 
            // Rejects
            // 
            this.Rejects.HeaderText = "Rejects";
            this.Rejects.Name = "Rejects";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(217, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 22);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(113, 79);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(80, 20);
            this.txtCustomerID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Enter Customer ID";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(90, 34);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(64, 20);
            this.txtOrderId.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Order ID";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Location = new System.Drawing.Point(267, 34);
            this.txtOrderDate.MaxLength = 6;
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(76, 20);
            this.txtOrderDate.TabIndex = 40;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(204, 37);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 39;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.txtTotalPrice);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Controls.Add(this.lstPrice);
            this.grpOrder.Controls.Add(this.lstAmount);
            this.grpOrder.Controls.Add(this.dtpDeliveryDate);
            this.grpOrder.Controls.Add(this.lblDeliveryDate);
            this.grpOrder.Controls.Add(this.lstItems);
            this.grpOrder.Controls.Add(this.btnDelete);
            this.grpOrder.Controls.Add(this.btnCompleteOrder);
            this.grpOrder.Location = new System.Drawing.Point(26, 312);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(631, 223);
            this.grpOrder.TabIndex = 41;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            this.grpOrder.Visible = false;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(417, 140);
            this.txtTotalPrice.MaxLength = 3;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(64, 20);
            this.txtTotalPrice.TabIndex = 44;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(346, 143);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 13);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "Total Price:";
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.Location = new System.Drawing.Point(219, 29);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(85, 186);
            this.lstPrice.TabIndex = 42;
            this.lstPrice.SelectedIndexChanged += new System.EventHandler(this.lstPrice_SelectedIndexChanged);
            // 
            // lstAmount
            // 
            this.lstAmount.FormattingEnabled = true;
            this.lstAmount.Location = new System.Drawing.Point(120, 29);
            this.lstAmount.Name = "lstAmount";
            this.lstAmount.Size = new System.Drawing.Size(85, 186);
            this.lstAmount.TabIndex = 41;
            this.lstAmount.SelectedIndexChanged += new System.EventHandler(this.lstAmount_SelectedIndexChanged);
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(417, 103);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliveryDate.TabIndex = 40;
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(337, 109);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(74, 13);
            this.lblDeliveryDate.TabIndex = 39;
            this.lblDeliveryDate.Text = "Delivery Date:";
            // 
            // frmCollectLaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 561);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.grpLinen);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmCollectLaundry";
            this.Text = "CollectLaundry";
            this.Load += new System.EventHandler(this.frmCollectLaundry_Load);
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.grpLinen.ResumeLayout(false);
            this.grpLinen.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCustomerIDDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rejects;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ListBox lstAmount;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryDate;
    }
}