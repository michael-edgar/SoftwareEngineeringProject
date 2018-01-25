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
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
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
            this.txtNextClientID.Location = new System.Drawing.Point(303, 411);
            this.txtNextClientID.Name = "txtNextClientID";
            this.txtNextClientID.Size = new System.Drawing.Size(100, 20);
            this.txtNextClientID.TabIndex = 3;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(246, 414);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 13);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.Text = "Client ID:";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 485);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.txtNextClientID);
            this.Controls.Add(this.rdoForename);
            this.Controls.Add(this.rdoClientID);
            this.Controls.Add(this.grdData);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.RadioButton rdoClientID;
        private System.Windows.Forms.RadioButton rdoForename;
        private System.Windows.Forms.TextBox txtNextClientID;
        private System.Windows.Forms.Label lblClientID;
    }
}

