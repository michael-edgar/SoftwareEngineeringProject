﻿namespace LinenSys
{
    partial class frmRemoveLinen
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
            this.lblLinenNames = new System.Windows.Forms.Label();
            this.cboLinenNames = new System.Windows.Forms.ComboBox();
            this.btnGetLinen = new System.Windows.Forms.Button();
            this.lblLinenCode = new System.Windows.Forms.Label();
            this.txtLinenCode = new System.Windows.Forms.TextBox();
            this.btnRemoveLinen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuUpdateLinen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuUpdateLinen
            // 
            this.mnuUpdateLinen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.mnuUpdateLinen.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateLinen.Name = "mnuUpdateLinen";
            this.mnuUpdateLinen.Size = new System.Drawing.Size(349, 24);
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
            // lblLinenNames
            // 
            this.lblLinenNames.AutoSize = true;
            this.lblLinenNames.Location = new System.Drawing.Point(66, 220);
            this.lblLinenNames.Name = "lblLinenNames";
            this.lblLinenNames.Size = new System.Drawing.Size(69, 13);
            this.lblLinenNames.TabIndex = 14;
            this.lblLinenNames.Text = "Linen Names";
            this.lblLinenNames.Visible = false;
            // 
            // cboLinenNames
            // 
            this.cboLinenNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLinenNames.FormattingEnabled = true;
            this.cboLinenNames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboLinenNames.Location = new System.Drawing.Point(167, 217);
            this.cboLinenNames.Name = "cboLinenNames";
            this.cboLinenNames.Size = new System.Drawing.Size(123, 21);
            this.cboLinenNames.TabIndex = 13;
            this.cboLinenNames.Visible = false;
            // 
            // btnGetLinen
            // 
            this.btnGetLinen.Location = new System.Drawing.Point(116, 118);
            this.btnGetLinen.Name = "btnGetLinen";
            this.btnGetLinen.Size = new System.Drawing.Size(75, 23);
            this.btnGetLinen.TabIndex = 12;
            this.btnGetLinen.Text = "Get Linen";
            this.btnGetLinen.UseVisualStyleBackColor = true;
            this.btnGetLinen.Click += new System.EventHandler(this.btnGetLinen_Click);
            // 
            // lblLinenCode
            // 
            this.lblLinenCode.AutoSize = true;
            this.lblLinenCode.Location = new System.Drawing.Point(66, 70);
            this.lblLinenCode.Name = "lblLinenCode";
            this.lblLinenCode.Size = new System.Drawing.Size(61, 13);
            this.lblLinenCode.TabIndex = 11;
            this.lblLinenCode.Text = "Linen Code";
            // 
            // txtLinenCode
            // 
            this.txtLinenCode.Location = new System.Drawing.Point(167, 67);
            this.txtLinenCode.Name = "txtLinenCode";
            this.txtLinenCode.Size = new System.Drawing.Size(123, 20);
            this.txtLinenCode.TabIndex = 10;
            // 
            // btnRemoveLinen
            // 
            this.btnRemoveLinen.Location = new System.Drawing.Point(116, 269);
            this.btnRemoveLinen.Name = "btnRemoveLinen";
            this.btnRemoveLinen.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveLinen.TabIndex = 15;
            this.btnRemoveLinen.Text = "Remove Linen";
            this.btnRemoveLinen.UseVisualStyleBackColor = true;
            this.btnRemoveLinen.Click += new System.EventHandler(this.btnRemoveLinen_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(167, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Linen Names";
            this.label1.Visible = false;
            // 
            // frmRemoveLinen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 367);
            this.Controls.Add(this.btnRemoveLinen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblLinenNames);
            this.Controls.Add(this.cboLinenNames);
            this.Controls.Add(this.btnGetLinen);
            this.Controls.Add(this.lblLinenCode);
            this.Controls.Add(this.txtLinenCode);
            this.Controls.Add(this.mnuUpdateLinen);
            this.Name = "frmRemoveLinen";
            this.Text = "RemoveLinen";
            this.mnuUpdateLinen.ResumeLayout(false);
            this.mnuUpdateLinen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateLinen;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblLinenNames;
        private System.Windows.Forms.ComboBox cboLinenNames;
        private System.Windows.Forms.Button btnGetLinen;
        private System.Windows.Forms.Label lblLinenCode;
        private System.Windows.Forms.TextBox txtLinenCode;
        private System.Windows.Forms.Button btnRemoveLinen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}