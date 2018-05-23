namespace LinenSys
{
    partial class frmRecordRejects
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstRejectItems = new System.Windows.Forms.ListBox();
            this.btnSaveRejects = new System.Windows.Forms.Button();
            this.txtRejectID = new System.Windows.Forms.TextBox();
            this.lblRejectID = new System.Windows.Forms.Label();
            this.btnAddReject = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lstAmount = new System.Windows.Forms.ListBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.grpAddReject = new System.Windows.Forms.GroupBox();
            this.cboQty = new System.Windows.Forms.ComboBox();
            this.txtOrderIDDisplay = new System.Windows.Forms.TextBox();
            this.lblOrderIDDisplay = new System.Windows.Forms.Label();
            this.grpRejects = new System.Windows.Forms.GroupBox();
            this.lstRejectAmount = new System.Windows.Forms.ListBox();
            this.mnuUpdateLinen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.grpAddReject.SuspendLayout();
            this.grpRejects.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(889, 24);
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
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(280, 66);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(82, 20);
            this.txtOrderID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order ID:";
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(430, 66);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(161, 23);
            this.btnGetOrders.TabIndex = 2;
            this.btnGetOrders.Text = "Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // grdOrders
            // 
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustID,
            this.OrderStatus,
            this.OrderType,
            this.TotalPrice});
            this.grdOrders.Location = new System.Drawing.Point(105, 131);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(550, 109);
            this.grdOrders.TabIndex = 24;
            this.grdOrders.Visible = false;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellClick);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.Name = "OrderID";
            // 
            // CustID
            // 
            this.CustID.HeaderText = "Customer ID";
            this.CustID.Name = "CustID";
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Order Status";
            this.OrderStatus.Name = "OrderStatus";
            // 
            // OrderType
            // 
            this.OrderType.HeaderText = "Order Type";
            this.OrderType.Name = "OrderType";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Location = new System.Drawing.Point(21, 131);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(68, 13);
            this.lblOrderDetails.TabIndex = 23;
            this.lblOrderDetails.Text = "Order Details";
            this.lblOrderDetails.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(266, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 22);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstRejectItems
            // 
            this.lstRejectItems.FormattingEnabled = true;
            this.lstRejectItems.Location = new System.Drawing.Point(24, 35);
            this.lstRejectItems.Name = "lstRejectItems";
            this.lstRejectItems.Size = new System.Drawing.Size(101, 186);
            this.lstRejectItems.TabIndex = 27;
            this.lstRejectItems.SelectedIndexChanged += new System.EventHandler(this.lstRejectItems_SelectedIndexChanged);
            // 
            // btnSaveRejects
            // 
            this.btnSaveRejects.Location = new System.Drawing.Point(34, 260);
            this.btnSaveRejects.Name = "btnSaveRejects";
            this.btnSaveRejects.Size = new System.Drawing.Size(134, 22);
            this.btnSaveRejects.TabIndex = 32;
            this.btnSaveRejects.Text = "Save Rejects";
            this.btnSaveRejects.UseVisualStyleBackColor = true;
            this.btnSaveRejects.Click += new System.EventHandler(this.btnSaveRejects_Click);
            // 
            // txtRejectID
            // 
            this.txtRejectID.Enabled = false;
            this.txtRejectID.Location = new System.Drawing.Point(88, 66);
            this.txtRejectID.Name = "txtRejectID";
            this.txtRejectID.Size = new System.Drawing.Size(82, 20);
            this.txtRejectID.TabIndex = 34;
            // 
            // lblRejectID
            // 
            this.lblRejectID.AutoSize = true;
            this.lblRejectID.Location = new System.Drawing.Point(14, 69);
            this.lblRejectID.Name = "lblRejectID";
            this.lblRejectID.Size = new System.Drawing.Size(55, 13);
            this.lblRejectID.TabIndex = 33;
            this.lblRejectID.Text = "Reject ID:";
            // 
            // btnAddReject
            // 
            this.btnAddReject.Location = new System.Drawing.Point(258, 165);
            this.btnAddReject.Name = "btnAddReject";
            this.btnAddReject.Size = new System.Drawing.Size(74, 22);
            this.btnAddReject.TabIndex = 36;
            this.btnAddReject.Text = "Add";
            this.btnAddReject.UseVisualStyleBackColor = true;
            this.btnAddReject.Click += new System.EventHandler(this.btnAddReject_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(23, 96);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(83, 186);
            this.lstItems.TabIndex = 35;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // lstAmount
            // 
            this.lstAmount.FormattingEnabled = true;
            this.lstAmount.Location = new System.Drawing.Point(126, 96);
            this.lstAmount.Name = "lstAmount";
            this.lstAmount.Size = new System.Drawing.Size(65, 186);
            this.lstAmount.TabIndex = 38;
            this.lstAmount.SelectedIndexChanged += new System.EventHandler(this.lstAmount_SelectedIndexChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(221, 116);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 13);
            this.lblQty.TabIndex = 40;
            this.lblQty.Text = "Quantity:";
            // 
            // grpAddReject
            // 
            this.grpAddReject.Controls.Add(this.cboQty);
            this.grpAddReject.Controls.Add(this.txtOrderIDDisplay);
            this.grpAddReject.Controls.Add(this.lblOrderIDDisplay);
            this.grpAddReject.Controls.Add(this.lstAmount);
            this.grpAddReject.Controls.Add(this.lblQty);
            this.grpAddReject.Controls.Add(this.lstItems);
            this.grpAddReject.Controls.Add(this.btnAddReject);
            this.grpAddReject.Location = new System.Drawing.Point(12, 248);
            this.grpAddReject.Name = "grpAddReject";
            this.grpAddReject.Size = new System.Drawing.Size(429, 299);
            this.grpAddReject.TabIndex = 41;
            this.grpAddReject.TabStop = false;
            this.grpAddReject.Text = "AddReject";
            this.grpAddReject.Visible = false;
            // 
            // cboQty
            // 
            this.cboQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQty.FormattingEnabled = true;
            this.cboQty.Items.AddRange(new object[] {
            "BM Bath Mat",
            "BS Bath Sheet",
            "HT Hand Towel"});
            this.cboQty.Location = new System.Drawing.Point(276, 113);
            this.cboQty.Name = "cboQty";
            this.cboQty.Size = new System.Drawing.Size(92, 21);
            this.cboQty.TabIndex = 43;
            // 
            // txtOrderIDDisplay
            // 
            this.txtOrderIDDisplay.Enabled = false;
            this.txtOrderIDDisplay.Location = new System.Drawing.Point(109, 35);
            this.txtOrderIDDisplay.Name = "txtOrderIDDisplay";
            this.txtOrderIDDisplay.Size = new System.Drawing.Size(82, 20);
            this.txtOrderIDDisplay.TabIndex = 42;
            // 
            // lblOrderIDDisplay
            // 
            this.lblOrderIDDisplay.AutoSize = true;
            this.lblOrderIDDisplay.Location = new System.Drawing.Point(34, 38);
            this.lblOrderIDDisplay.Name = "lblOrderIDDisplay";
            this.lblOrderIDDisplay.Size = new System.Drawing.Size(50, 13);
            this.lblOrderIDDisplay.TabIndex = 41;
            this.lblOrderIDDisplay.Text = "Order ID:";
            // 
            // grpRejects
            // 
            this.grpRejects.Controls.Add(this.lstRejectAmount);
            this.grpRejects.Controls.Add(this.lstRejectItems);
            this.grpRejects.Controls.Add(this.btnDelete);
            this.grpRejects.Controls.Add(this.btnSaveRejects);
            this.grpRejects.Location = new System.Drawing.Point(487, 248);
            this.grpRejects.Name = "grpRejects";
            this.grpRejects.Size = new System.Drawing.Size(352, 299);
            this.grpRejects.TabIndex = 42;
            this.grpRejects.TabStop = false;
            this.grpRejects.Text = "Rejects";
            this.grpRejects.Visible = false;
            // 
            // lstRejectAmount
            // 
            this.lstRejectAmount.FormattingEnabled = true;
            this.lstRejectAmount.Location = new System.Drawing.Point(146, 35);
            this.lstRejectAmount.Name = "lstRejectAmount";
            this.lstRejectAmount.Size = new System.Drawing.Size(101, 186);
            this.lstRejectAmount.TabIndex = 33;
            this.lstRejectAmount.SelectedIndexChanged += new System.EventHandler(this.lstRejectAmount_SelectedIndexChanged);
            // 
            // frmRecordRejects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 559);
            this.Controls.Add(this.grpRejects);
            this.Controls.Add(this.grpAddReject);
            this.Controls.Add(this.txtRejectID);
            this.Controls.Add(this.lblRejectID);
            this.Controls.Add(this.grdOrders);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetOrders);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmRecordRejects";
            this.Text = "RecordRejects";
            this.Load += new System.EventHandler(this.frmRecordRejects_Load);
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.grpAddReject.ResumeLayout(false);
            this.grpAddReject.PerformLayout();
            this.grpRejects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstRejectItems;
        private System.Windows.Forms.Button btnSaveRejects;
        private System.Windows.Forms.TextBox txtRejectID;
        private System.Windows.Forms.Label lblRejectID;
        private System.Windows.Forms.Button btnAddReject;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.ListBox lstAmount;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.GroupBox grpAddReject;
        private System.Windows.Forms.GroupBox grpRejects;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.TextBox txtOrderIDDisplay;
        private System.Windows.Forms.Label lblOrderIDDisplay;
        private System.Windows.Forms.ComboBox cboQty;
        private System.Windows.Forms.ListBox lstRejectAmount;
    }
}