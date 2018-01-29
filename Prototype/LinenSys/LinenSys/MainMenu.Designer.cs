namespace LinenSys
{
    partial class frmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLinenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateLinenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLinenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectLaundryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateEarningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateCustomerEarningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordRejectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackRejectCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linenToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linenToolStripMenuItem
            // 
            this.linenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLinenToolStripMenuItem,
            this.updateLinenToolStripMenuItem,
            this.removeLinenToolStripMenuItem});
            this.linenToolStripMenuItem.Name = "linenToolStripMenuItem";
            this.linenToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.linenToolStripMenuItem.Text = "Linen";
            // 
            // addLinenToolStripMenuItem
            // 
            this.addLinenToolStripMenuItem.Name = "addLinenToolStripMenuItem";
            this.addLinenToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addLinenToolStripMenuItem.Text = "Add Linen";
            this.addLinenToolStripMenuItem.Click += new System.EventHandler(this.addLinenToolStripMenuItem_Click);
            // 
            // updateLinenToolStripMenuItem
            // 
            this.updateLinenToolStripMenuItem.Name = "updateLinenToolStripMenuItem";
            this.updateLinenToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.updateLinenToolStripMenuItem.Text = "Update Linen";
            this.updateLinenToolStripMenuItem.Click += new System.EventHandler(this.updateLinenToolStripMenuItem_Click);
            // 
            // removeLinenToolStripMenuItem
            // 
            this.removeLinenToolStripMenuItem.Name = "removeLinenToolStripMenuItem";
            this.removeLinenToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeLinenToolStripMenuItem.Text = "Remove Linen";
            this.removeLinenToolStripMenuItem.Click += new System.EventHandler(this.removeLinenToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.removeCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.removeCustomerToolStripMenuItem.Text = "Remove Customer";
            this.removeCustomerToolStripMenuItem.Click += new System.EventHandler(this.removeCustomerToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOrderToolStripMenuItem,
            this.cancelOrderToolStripMenuItem,
            this.dispatchDeliveryToolStripMenuItem,
            this.collectLaundryToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // logOrderToolStripMenuItem
            // 
            this.logOrderToolStripMenuItem.Name = "logOrderToolStripMenuItem";
            this.logOrderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.logOrderToolStripMenuItem.Text = "Log Order";
            this.logOrderToolStripMenuItem.Click += new System.EventHandler(this.logOrderToolStripMenuItem_Click);
            // 
            // cancelOrderToolStripMenuItem
            // 
            this.cancelOrderToolStripMenuItem.Name = "cancelOrderToolStripMenuItem";
            this.cancelOrderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cancelOrderToolStripMenuItem.Text = "Cancel Order";
            this.cancelOrderToolStripMenuItem.Click += new System.EventHandler(this.cancelOrderToolStripMenuItem_Click);
            // 
            // dispatchDeliveryToolStripMenuItem
            // 
            this.dispatchDeliveryToolStripMenuItem.Name = "dispatchDeliveryToolStripMenuItem";
            this.dispatchDeliveryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.dispatchDeliveryToolStripMenuItem.Text = "Dispatch Delivery";
            this.dispatchDeliveryToolStripMenuItem.Click += new System.EventHandler(this.dispatchDeliveryToolStripMenuItem_Click);
            // 
            // collectLaundryToolStripMenuItem
            // 
            this.collectLaundryToolStripMenuItem.Name = "collectLaundryToolStripMenuItem";
            this.collectLaundryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.collectLaundryToolStripMenuItem.Text = "Collect Laundry";
            this.collectLaundryToolStripMenuItem.Click += new System.EventHandler(this.collectLaundryToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateEarningsToolStripMenuItem,
            this.calculateCustomerEarningsToolStripMenuItem,
            this.recordRejectsToolStripMenuItem,
            this.trackRejectCostToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // calculateEarningsToolStripMenuItem
            // 
            this.calculateEarningsToolStripMenuItem.Name = "calculateEarningsToolStripMenuItem";
            this.calculateEarningsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.calculateEarningsToolStripMenuItem.Text = "Calculate Earnings";
            this.calculateEarningsToolStripMenuItem.Click += new System.EventHandler(this.calculateEarningsToolStripMenuItem_Click);
            // 
            // calculateCustomerEarningsToolStripMenuItem
            // 
            this.calculateCustomerEarningsToolStripMenuItem.Name = "calculateCustomerEarningsToolStripMenuItem";
            this.calculateCustomerEarningsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.calculateCustomerEarningsToolStripMenuItem.Text = "Calculate Customer Earnings";
            this.calculateCustomerEarningsToolStripMenuItem.Click += new System.EventHandler(this.calculateCustomerEarningsToolStripMenuItem_Click);
            // 
            // recordRejectsToolStripMenuItem
            // 
            this.recordRejectsToolStripMenuItem.Name = "recordRejectsToolStripMenuItem";
            this.recordRejectsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.recordRejectsToolStripMenuItem.Text = "Record Rejects";
            this.recordRejectsToolStripMenuItem.Click += new System.EventHandler(this.recordRejectsToolStripMenuItem_Click);
            // 
            // trackRejectCostToolStripMenuItem
            // 
            this.trackRejectCostToolStripMenuItem.Name = "trackRejectCostToolStripMenuItem";
            this.trackRejectCostToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.trackRejectCostToolStripMenuItem.Text = "Track Reject Cost";
            this.trackRejectCostToolStripMenuItem.Click += new System.EventHandler(this.trackRejectCostToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 388);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLinenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateLinenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLinenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispatchDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectLaundryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateEarningsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateCustomerEarningsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordRejectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackRejectCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}