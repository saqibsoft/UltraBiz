namespace Invoicing
{
    partial class Sale_Recovery__Invoice_Wise_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale_Recovery__Invoice_Wise_));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtGrossRecieved = new System.Windows.Forms.TextBox();
            this.TxtTotalDiscount = new System.Windows.Forms.TextBox();
            this.TxtTotalRecovered = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSalesman = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recievables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recovered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSector = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSMName = new System.Windows.Forms.TextBox();
            this.TxtSMID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRecoveryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtoSaleID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtfromSaleID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker1.TabIndex = 396;
            // 
            // TxtGrossRecieved
            // 
            this.TxtGrossRecieved.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtGrossRecieved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtGrossRecieved.Location = new System.Drawing.Point(628, 552);
            this.TxtGrossRecieved.Name = "TxtGrossRecieved";
            this.TxtGrossRecieved.Size = new System.Drawing.Size(87, 20);
            this.TxtGrossRecieved.TabIndex = 392;
            // 
            // TxtTotalDiscount
            // 
            this.TxtTotalDiscount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTotalDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalDiscount.Location = new System.Drawing.Point(532, 552);
            this.TxtTotalDiscount.Name = "TxtTotalDiscount";
            this.TxtTotalDiscount.Size = new System.Drawing.Size(90, 20);
            this.TxtTotalDiscount.TabIndex = 391;
            // 
            // TxtTotalRecovered
            // 
            this.TxtTotalRecovered.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTotalRecovered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalRecovered.Location = new System.Drawing.Point(437, 552);
            this.TxtTotalRecovered.Name = "TxtTotalRecovered";
            this.TxtTotalRecovered.Size = new System.Drawing.Size(88, 20);
            this.TxtTotalRecovered.TabIndex = 390;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 389;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnSalesman
            // 
            this.BtnSalesman.Location = new System.Drawing.Point(96, 164);
            this.BtnSalesman.Name = "BtnSalesman";
            this.BtnSalesman.Size = new System.Drawing.Size(25, 20);
            this.BtnSalesman.TabIndex = 388;
            this.BtnSalesman.Text = "...";
            this.BtnSalesman.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleID,
            this.CustomerID,
            this.CustomerName,
            this.SectorTown,
            this.Recievables,
            this.Recovered,
            this.Disc,
            this.Balance});
            this.dataGridView1.Location = new System.Drawing.Point(12, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(723, 287);
            this.dataGridView1.TabIndex = 387;
            // 
            // SaleID
            // 
            this.SaleID.HeaderText = "SaleID";
            this.SaleID.Name = "SaleID";
            this.SaleID.ReadOnly = true;
            this.SaleID.Width = 60;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 90;
            // 
            // SectorTown
            // 
            this.SectorTown.HeaderText = "Sector&Town";
            this.SectorTown.Name = "SectorTown";
            this.SectorTown.ReadOnly = true;
            this.SectorTown.Width = 90;
            // 
            // Recievables
            // 
            this.Recievables.HeaderText = "Receivables";
            this.Recievables.Name = "Recievables";
            this.Recievables.ReadOnly = true;
            this.Recievables.Width = 80;
            // 
            // Recovered
            // 
            this.Recovered.HeaderText = "Recovered";
            this.Recovered.Name = "Recovered";
            this.Recovered.ReadOnly = true;
            // 
            // Disc
            // 
            this.Disc.HeaderText = "Disc";
            this.Disc.Name = "Disc";
            this.Disc.ReadOnly = true;
            this.Disc.Width = 80;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(327, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 386;
            this.label2.Text = "Town Name";
            // 
            // CmbTown
            // 
            this.CmbTown.FormattingEnabled = true;
            this.CmbTown.Location = new System.Drawing.Point(330, 165);
            this.CmbTown.Name = "CmbTown";
            this.CmbTown.Size = new System.Drawing.Size(183, 21);
            this.CmbTown.TabIndex = 385;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(516, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 384;
            this.label1.Text = "Sector Name";
            // 
            // CmbSector
            // 
            this.CmbSector.FormattingEnabled = true;
            this.CmbSector.Location = new System.Drawing.Point(519, 164);
            this.CmbSector.Name = "CmbSector";
            this.CmbSector.Size = new System.Drawing.Size(188, 21);
            this.CmbSector.TabIndex = 383;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(122, 148);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 13);
            this.label33.TabIndex = 380;
            this.label33.Text = "Salesmen Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 379;
            this.label7.Text = "Salesmen ID";
            // 
            // TxtSMName
            // 
            this.TxtSMName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSMName.Enabled = false;
            this.TxtSMName.Location = new System.Drawing.Point(125, 164);
            this.TxtSMName.Name = "TxtSMName";
            this.TxtSMName.Size = new System.Drawing.Size(181, 20);
            this.TxtSMName.TabIndex = 378;
            // 
            // TxtSMID
            // 
            this.TxtSMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSMID.Location = new System.Drawing.Point(13, 164);
            this.TxtSMID.Name = "TxtSMID";
            this.TxtSMID.Size = new System.Drawing.Size(83, 20);
            this.TxtSMID.TabIndex = 377;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(85, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 376;
            this.label6.Text = "Recovery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 375;
            this.label4.Text = "Recovery ID";
            // 
            // TxtRecoveryID
            // 
            this.TxtRecoveryID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtRecoveryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRecoveryID.Location = new System.Drawing.Point(12, 117);
            this.TxtRecoveryID.Name = "TxtRecoveryID";
            this.TxtRecoveryID.Size = new System.Drawing.Size(70, 20);
            this.TxtRecoveryID.TabIndex = 374;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(166, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 398;
            this.label5.Text = "To Sale ID";
            // 
            // TxtoSaleID
            // 
            this.TxtoSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtoSaleID.Location = new System.Drawing.Point(169, 220);
            this.TxtoSaleID.Name = "TxtoSaleID";
            this.TxtoSaleID.Size = new System.Drawing.Size(137, 20);
            this.TxtoSaleID.TabIndex = 397;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(9, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 400;
            this.label8.Text = "From Sale ID";
            // 
            // TxtfromSaleID
            // 
            this.TxtfromSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtfromSaleID.Location = new System.Drawing.Point(13, 220);
            this.TxtfromSaleID.Name = "TxtfromSaleID";
            this.TxtfromSaleID.Size = new System.Drawing.Size(131, 20);
            this.TxtfromSaleID.TabIndex = 399;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(625, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 401;
            this.label3.Text = "Gross Recieved";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(529, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 402;
            this.label9.Text = "Discount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(434, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 403;
            this.label10.Text = "Net Recieved";
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(472, 578);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 26);
            this.CmdClose.TabIndex = 408;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(404, 579);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(63, 25);
            this.CmdSelect.TabIndex = 407;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(203, 579);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 25);
            this.CmdSave.TabIndex = 404;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(336, 579);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(63, 25);
            this.CmdDelete.TabIndex = 406;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(271, 579);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 25);
            this.CmdClear.TabIndex = 405;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(118, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(520, 39);
            this.label11.TabIndex = 409;
            this.label11.Text = "Sales Recovery (Invoice Wise)";
            // 
            // Sale_Recovery__Invoice_Wise_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackgroundImage = global::Invoicing.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(788, 619);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtfromSaleID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtoSaleID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtGrossRecieved);
            this.Controls.Add(this.TxtTotalDiscount);
            this.Controls.Add(this.TxtTotalRecovered);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSalesman);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbTown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSector);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSMName);
            this.Controls.Add(this.TxtSMID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRecoveryID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sale_Recovery__Invoice_Wise_";
            this.Text = "Sale_Recovery__Invoice_Wise_";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtGrossRecieved;
        private System.Windows.Forms.TextBox TxtTotalDiscount;
        private System.Windows.Forms.TextBox TxtTotalRecovered;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSalesman;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSector;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSMName;
        private System.Windows.Forms.TextBox TxtSMID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRecoveryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtoSaleID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtfromSaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recievables;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recovered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label label11;
    }
}