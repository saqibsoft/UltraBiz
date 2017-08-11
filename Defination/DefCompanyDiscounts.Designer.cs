namespace Defination
{
    partial class DefCompanyDiscounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefCompanyDiscounts));
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTownName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSectorName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(85, 460);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 52;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(221, 460);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 51;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(289, 460);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 50;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(153, 460);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 49;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.SaleDisc});
            this.Grid.Location = new System.Drawing.Point(54, 179);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(324, 275);
            this.Grid.TabIndex = 91;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CompanyName.DefaultCellStyle = dataGridViewCellStyle1;
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 190;
            // 
            // SaleDisc
            // 
            this.SaleDisc.DataPropertyName = "SaleDisc(%)";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SaleDisc.DefaultCellStyle = dataGridViewCellStyle2;
            this.SaleDisc.HeaderText = "Sale.Disc(%)";
            this.SaleDisc.Name = "SaleDisc";
            this.SaleDisc.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(150, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 170;
            this.label2.Text = "Customer Name:";
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCustomerID.Location = new System.Drawing.Point(51, 115);
            this.TxtCustomerID.MaxLength = 25;
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.Size = new System.Drawing.Size(102, 20);
            this.TxtCustomerID.TabIndex = 168;
            this.TxtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 169;
            this.label1.Text = "Customer ID:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(153, 115);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(226, 20);
            this.txtCustomerName.TabIndex = 167;
            this.txtCustomerName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(51, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 172;
            this.label3.Text = "Town:";
            // 
            // txtTownName
            // 
            this.txtTownName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownName.Location = new System.Drawing.Point(54, 153);
            this.txtTownName.Name = "txtTownName";
            this.txtTownName.ReadOnly = true;
            this.txtTownName.Size = new System.Drawing.Size(161, 20);
            this.txtTownName.TabIndex = 171;
            this.txtTownName.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(212, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 174;
            this.label4.Text = "Sector";
            // 
            // txtSectorName
            // 
            this.txtSectorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectorName.Location = new System.Drawing.Point(215, 153);
            this.txtSectorName.Name = "txtSectorName";
            this.txtSectorName.ReadOnly = true;
            this.txtSectorName.Size = new System.Drawing.Size(164, 20);
            this.txtSectorName.TabIndex = 173;
            this.txtSectorName.TabStop = false;
            // 
            // DefCompanyDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSectorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTownName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefCompanyDiscounts";
            this.Text = "Company Discounts";
            this.Load += new System.EventHandler(this.DefCompanyDiscounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTownName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDisc;
    }
}