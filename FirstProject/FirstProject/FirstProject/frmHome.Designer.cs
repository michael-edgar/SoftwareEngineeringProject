namespace FirstProject
{
    partial class frmHome
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.rdoClientID = new System.Windows.Forms.RadioButton();
            this.rdoForename = new System.Windows.Forms.RadioButton();
            this.txtNextClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.grpNewClient = new System.Windows.Forms.GroupBox();
            this.btnNewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.grpNewClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(44, 43);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(642, 275);
            this.grdData.TabIndex = 0;
            // 
            // rdoClientID
            // 
            this.rdoClientID.AutoSize = true;
            this.rdoClientID.Checked = true;
            this.rdoClientID.Location = new System.Drawing.Point(160, 343);
            this.rdoClientID.Name = "rdoClientID";
            this.rdoClientID.Size = new System.Drawing.Size(65, 17);
            this.rdoClientID.TabIndex = 1;
            this.rdoClientID.TabStop = true;
            this.rdoClientID.Text = "Client ID";
            this.rdoClientID.UseVisualStyleBackColor = true;
            // 
            // rdoForename
            // 
            this.rdoForename.AutoSize = true;
            this.rdoForename.Location = new System.Drawing.Point(497, 343);
            this.rdoForename.Name = "rdoForename";
            this.rdoForename.Size = new System.Drawing.Size(72, 17);
            this.rdoForename.TabIndex = 2;
            this.rdoForename.Text = "Forename";
            this.rdoForename.UseVisualStyleBackColor = true;
            this.rdoForename.CheckedChanged += new System.EventHandler(this.rdoForename_CheckedChanged);
            // 
            // txtNextClientID
            // 
            this.txtNextClientID.Enabled = false;
            this.txtNextClientID.Location = new System.Drawing.Point(69, 34);
            this.txtNextClientID.Name = "txtNextClientID";
            this.txtNextClientID.Size = new System.Drawing.Size(100, 20);
            this.txtNextClientID.TabIndex = 3;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(12, 37);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 13);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.Text = "Client ID:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 85);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(69, 82);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(12, 136);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 8;
            this.lblForename.Text = "Forename:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(69, 133);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 7;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(196, 81);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 10;
            this.lblTown.Text = "Town:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(253, 78);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(100, 20);
            this.txtTown.TabIndex = 9;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(196, 136);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 12;
            this.lblCounty.Text = "County:";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(253, 133);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(100, 20);
            this.txtCounty.TabIndex = 11;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(196, 37);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 14;
            this.lblStreet.Text = "Street:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(253, 34);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 13;
            // 
            // grpNewClient
            // 
            this.grpNewClient.Controls.Add(this.btnNewClient);
            this.grpNewClient.Controls.Add(this.txtNextClientID);
            this.grpNewClient.Controls.Add(this.lblStreet);
            this.grpNewClient.Controls.Add(this.lblClientID);
            this.grpNewClient.Controls.Add(this.txtStreet);
            this.grpNewClient.Controls.Add(this.lblCounty);
            this.grpNewClient.Controls.Add(this.txtSurname);
            this.grpNewClient.Controls.Add(this.txtCounty);
            this.grpNewClient.Controls.Add(this.lblSurname);
            this.grpNewClient.Controls.Add(this.lblTown);
            this.grpNewClient.Controls.Add(this.txtForename);
            this.grpNewClient.Controls.Add(this.txtTown);
            this.grpNewClient.Controls.Add(this.lblForename);
            this.grpNewClient.Location = new System.Drawing.Point(176, 393);
            this.grpNewClient.Name = "grpNewClient";
            this.grpNewClient.Size = new System.Drawing.Size(359, 209);
            this.grpNewClient.TabIndex = 15;
            this.grpNewClient.TabStop = false;
            this.grpNewClient.Text = "New Client";
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(139, 169);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(94, 23);
            this.btnNewClient.TabIndex = 15;
            this.btnNewClient.Text = "Add New Client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 614);
            this.Controls.Add(this.grpNewClient);
            this.Controls.Add(this.rdoForename);
            this.Controls.Add(this.rdoClientID);
            this.Controls.Add(this.grdData);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.grpNewClient.ResumeLayout(false);
            this.grpNewClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.RadioButton rdoClientID;
        private System.Windows.Forms.RadioButton rdoForename;
        private System.Windows.Forms.TextBox txtNextClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.GroupBox grpNewClient;
        private System.Windows.Forms.Button btnNewClient;
    }
}

