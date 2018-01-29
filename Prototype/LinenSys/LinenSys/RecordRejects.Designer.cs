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
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLinen = new System.Windows.Forms.ComboBox();
            this.btnSaveRejects = new System.Windows.Forms.Button();
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
            this.mnuUpdateLinen.Size = new System.Drawing.Size(892, 24);
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
            this.txtOrderID.Location = new System.Drawing.Point(129, 65);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(136, 20);
            this.txtOrderID.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order ID:";
            // 
            // btnRecordRejects
            // 
            this.btnRecordRejects.Location = new System.Drawing.Point(68, 116);
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
            this.CustID,
            this.Surname,
            this.Forename,
            this.Phone});
            this.grdOrders.Location = new System.Drawing.Point(105, 184);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(467, 109);
            this.grdOrders.TabIndex = 24;
            this.grdOrders.Visible = false;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellClick);
            // 
            // CustID
            // 
            this.CustID.HeaderText = "Customer ID";
            this.CustID.Name = "CustID";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Linen Name";
            this.Surname.Name = "Surname";
            // 
            // Forename
            // 
            this.Forename.HeaderText = "Linen Amount";
            this.Forename.Name = "Forename";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Price";
            this.Phone.Name = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Order Details";
            this.label3.Visible = false;
            // 
            // grpDetails
            // 
            this.grpDetails.Location = new System.Drawing.Point(23, 344);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(493, 93);
            this.grpDetails.TabIndex = 25;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Reject Details";
            this.grpDetails.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(796, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 22);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(579, 344);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(211, 186);
            this.lstItems.TabIndex = 27;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(418, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 22);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(327, 380);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(64, 20);
            this.txtQty.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 28;
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
            this.cboLinen.Location = new System.Drawing.Point(50, 380);
            this.cboLinen.Name = "cboLinen";
            this.cboLinen.Size = new System.Drawing.Size(228, 21);
            this.cboLinen.TabIndex = 26;
            // 
            // btnSaveRejects
            // 
            this.btnSaveRejects.Location = new System.Drawing.Point(166, 508);
            this.btnSaveRejects.Name = "btnSaveRejects";
            this.btnSaveRejects.Size = new System.Drawing.Size(211, 22);
            this.btnSaveRejects.TabIndex = 32;
            this.btnSaveRejects.Text = "Save Rejects";
            this.btnSaveRejects.UseVisualStyleBackColor = true;
            this.btnSaveRejects.Click += new System.EventHandler(this.btnSaveRejects_Click);
            // 
            // frmRecordRejects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 559);
            this.Controls.Add(this.btnSaveRejects);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLinen);
            this.Controls.Add(this.grpDetails);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLinen;
        private System.Windows.Forms.Button btnSaveRejects;
    }
}