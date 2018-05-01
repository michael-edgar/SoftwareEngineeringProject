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
            this.btnRecordRejects = new System.Windows.Forms.Button();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstRejectItems = new System.Windows.Forms.ListBox();
            this.btnSaveRejects = new System.Windows.Forms.Button();
            this.txtRejectID = new System.Windows.Forms.TextBox();
            this.lblRejectID = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddReject = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lstRejectAmount = new System.Windows.Forms.ListBox();
            this.lstAmount = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.mnuUpdateLinen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(742, 24);
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
            this.txtOrderID.TabIndex = 22;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRecordRejects
            // 
            this.btnRecordRejects.Location = new System.Drawing.Point(411, 63);
            this.btnRecordRejects.Name = "btnRecordRejects";
            this.btnRecordRejects.Size = new System.Drawing.Size(161, 23);
            this.btnRecordRejects.TabIndex = 18;
            this.btnRecordRejects.Text = "Get Orders";
            this.btnRecordRejects.UseVisualStyleBackColor = true;
            this.btnRecordRejects.Click += new System.EventHandler(this.btnRecordRejects_Click);
            // 
            // grdOrders
            // 
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustID,
            this.Company,
            this.Customer,
            this.PhoneNo});
            this.grdOrders.Location = new System.Drawing.Point(105, 131);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(550, 109);
            this.grdOrders.TabIndex = 24;
            this.grdOrders.Visible = false;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Order Details";
            this.label3.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(651, 325);
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
            this.lstRejectItems.Location = new System.Drawing.Point(431, 294);
            this.lstRejectItems.Name = "lstRejectItems";
            this.lstRejectItems.Size = new System.Drawing.Size(80, 186);
            this.lstRejectItems.TabIndex = 27;
            // 
            // btnSaveRejects
            // 
            this.btnSaveRejects.Location = new System.Drawing.Point(305, 512);
            this.btnSaveRejects.Name = "btnSaveRejects";
            this.btnSaveRejects.Size = new System.Drawing.Size(211, 22);
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
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "Phone No";
            this.PhoneNo.Name = "PhoneNo";
            // 
            // btnAddReject
            // 
            this.btnAddReject.Location = new System.Drawing.Point(269, 363);
            this.btnAddReject.Name = "btnAddReject";
            this.btnAddReject.Size = new System.Drawing.Size(74, 22);
            this.btnAddReject.TabIndex = 36;
            this.btnAddReject.Text = "Add";
            this.btnAddReject.UseVisualStyleBackColor = true;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(34, 294);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(83, 186);
            this.lstItems.TabIndex = 35;
            // 
            // lstRejectAmount
            // 
            this.lstRejectAmount.FormattingEnabled = true;
            this.lstRejectAmount.Location = new System.Drawing.Point(533, 294);
            this.lstRejectAmount.Name = "lstRejectAmount";
            this.lstRejectAmount.Size = new System.Drawing.Size(93, 186);
            this.lstRejectAmount.TabIndex = 37;
            // 
            // lstAmount
            // 
            this.lstAmount.FormattingEnabled = true;
            this.lstAmount.Location = new System.Drawing.Point(137, 294);
            this.lstAmount.Name = "lstAmount";
            this.lstAmount.Size = new System.Drawing.Size(65, 186);
            this.lstAmount.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 311);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(232, 314);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 13);
            this.lblQty.TabIndex = 40;
            this.lblQty.Text = "Quantity:";
            // 
            // frmRecordRejects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 559);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstAmount);
            this.Controls.Add(this.lstRejectAmount);
            this.Controls.Add(this.btnAddReject);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.txtRejectID);
            this.Controls.Add(this.lblRejectID);
            this.Controls.Add(this.btnSaveRejects);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstRejectItems);
            this.Controls.Add(this.grdOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecordRejects);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmRecordRejects";
            this.Text = "RecordRejects";
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecordRejects;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstRejectItems;
        private System.Windows.Forms.Button btnSaveRejects;
        private System.Windows.Forms.TextBox txtRejectID;
        private System.Windows.Forms.Label lblRejectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.Button btnAddReject;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.ListBox lstRejectAmount;
        private System.Windows.Forms.ListBox lstAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblQty;
    }
}