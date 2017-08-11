namespace Invoicing
{
    partial class FrmCompanyDiscountCustomerWise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyDiscountCustomerWise));
            this.dtpRecoveryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRecoveryID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalesman = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSMName = new System.Windows.Forms.TextBox();
            this.TxtSMID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbSector = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbPartyType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbPartyGroup = new System.Windows.Forms.ComboBox();
            this.ChkSMSEnabled = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTotalRecievables = new System.Windows.Forms.TextBox();
            this.TxtTotalBalance = new System.Windows.Forms.TextBox();
            this.TxtTotalDiscount = new System.Windows.Forms.TextBox();
            this.TxtTotalRecovered = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRecovered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label31 = new System.Windows.Forms.Label();
            this.TxtNarration = new System.Windows.Forms.TextBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label41 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpRecoveryDate
            // 
            this.dtpRecoveryDate.CustomFormat = "dd/MMM/yy";
            this.dtpRecoveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRecoveryDate.Location = new System.Drawing.Point(85, 135);
            this.dtpRecoveryDate.Name = "dtpRecoveryDate";
            this.dtpRecoveryDate.Size = new System.Drawing.Size(81, 20);
            this.dtpRecoveryDate.TabIndex = 400;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(82, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 399;
            this.label6.Text = "Recovery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 398;
            this.label4.Text = "Discount ID";
            // 
            // TxtRecoveryID
            // 
            this.TxtRecoveryID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtRecoveryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRecoveryID.Location = new System.Drawing.Point(9, 135);
            this.TxtRecoveryID.Name = "TxtRecoveryID";
            this.TxtRecoveryID.Size = new System.Drawing.Size(76, 20);
            this.TxtRecoveryID.TabIndex = 397;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(271, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 402;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(169, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 404;
            this.label1.Text = "From";
            // 
            // BtnSalesman
            // 
            this.BtnSalesman.Location = new System.Drawing.Point(442, 133);
            this.BtnSalesman.Name = "BtnSalesman";
            this.BtnSalesman.Size = new System.Drawing.Size(26, 23);
            this.BtnSalesman.TabIndex = 409;
            this.BtnSalesman.Text = "...";
            this.BtnSalesman.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(470, 119);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(82, 13);
            this.label33.TabIndex = 408;
            this.label33.Text = "Company Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(375, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 407;
            this.label7.Text = "Company ID";
            // 
            // TxtSMName
            // 
            this.TxtSMName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSMName.Enabled = false;
            this.TxtSMName.Location = new System.Drawing.Point(469, 134);
            this.TxtSMName.Name = "TxtSMName";
            this.TxtSMName.Size = new System.Drawing.Size(152, 20);
            this.TxtSMName.TabIndex = 406;
            // 
            // TxtSMID
            // 
            this.TxtSMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSMID.Location = new System.Drawing.Point(378, 135);
            this.TxtSMID.Name = "TxtSMID";
            this.TxtSMID.Size = new System.Drawing.Size(64, 20);
            this.TxtSMID.TabIndex = 405;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 413;
            this.label3.Text = "Town Name";
            // 
            // CmbTown
            // 
            this.CmbTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTown.FormattingEnabled = true;
            this.CmbTown.Location = new System.Drawing.Point(11, 181);
            this.CmbTown.Name = "CmbTown";
            this.CmbTown.Size = new System.Drawing.Size(132, 21);
            this.CmbTown.TabIndex = 412;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(141, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 411;
            this.label5.Text = "Sector Name";
            // 
            // CmbSector
            // 
            this.CmbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSector.FormattingEnabled = true;
            this.CmbSector.Location = new System.Drawing.Point(143, 181);
            this.CmbSector.Name = "CmbSector";
            this.CmbSector.Size = new System.Drawing.Size(136, 21);
            this.CmbSector.TabIndex = 410;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(545, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 417;
            this.label9.Text = "Party Type";
            // 
            // CmbPartyType
            // 
            this.CmbPartyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPartyType.FormattingEnabled = true;
            this.CmbPartyType.Location = new System.Drawing.Point(547, 181);
            this.CmbPartyType.Name = "CmbPartyType";
            this.CmbPartyType.Size = new System.Drawing.Size(160, 21);
            this.CmbPartyType.TabIndex = 416;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(416, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 419;
            this.label10.Text = "City";
            // 
            // CmbCity
            // 
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(415, 181);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(132, 21);
            this.CmbCity.TabIndex = 418;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(280, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 421;
            this.label11.Text = "Party Group";
            // 
            // CmbPartyGroup
            // 
            this.CmbPartyGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPartyGroup.FormattingEnabled = true;
            this.CmbPartyGroup.Location = new System.Drawing.Point(279, 181);
            this.CmbPartyGroup.Name = "CmbPartyGroup";
            this.CmbPartyGroup.Size = new System.Drawing.Size(136, 21);
            this.CmbPartyGroup.TabIndex = 420;
            // 
            // ChkSMSEnabled
            // 
            this.ChkSMSEnabled.AutoSize = true;
            this.ChkSMSEnabled.BackColor = System.Drawing.Color.Transparent;
            this.ChkSMSEnabled.Location = new System.Drawing.Point(13, 496);
            this.ChkSMSEnabled.Name = "ChkSMSEnabled";
            this.ChkSMSEnabled.Size = new System.Drawing.Size(49, 17);
            this.ChkSMSEnabled.TabIndex = 428;
            this.ChkSMSEnabled.Text = "SMS";
            this.ChkSMSEnabled.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(271, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 427;
            this.label12.Text = "Total:";
            // 
            // TxtTotalRecievables
            // 
            this.TxtTotalRecievables.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTotalRecievables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalRecievables.Location = new System.Drawing.Point(306, 489);
            this.TxtTotalRecievables.Name = "TxtTotalRecievables";
            this.TxtTotalRecievables.Size = new System.Drawing.Size(105, 20);
            this.TxtTotalRecievables.TabIndex = 426;
            // 
            // TxtTotalBalance
            // 
            this.TxtTotalBalance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTotalBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalBalance.Location = new System.Drawing.Point(609, 489);
            this.TxtTotalBalance.Name = "TxtTotalBalance";
            this.TxtTotalBalance.Size = new System.Drawing.Size(98, 20);
            this.TxtTotalBalance.TabIndex = 425;
            // 
            // TxtTotalDiscount
            // 
            this.TxtTotalDiscount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTotalDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalDiscount.Location = new System.Drawing.Point(507, 489);
            this.TxtTotalDiscount.Name = "TxtTotalDiscount";
            this.TxtTotalDiscount.Size = new System.Drawing.Size(102, 20);
            this.TxtTotalDiscount.TabIndex = 424;
            // 
            // TxtTotalRecovered
            // 
            this.TxtTotalRecovered.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTotalRecovered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalRecovered.Location = new System.Drawing.Point(411, 489);
            this.TxtTotalRecovered.Name = "TxtTotalRecovered";
            this.TxtTotalRecovered.Size = new System.Drawing.Size(96, 20);
            this.TxtTotalRecovered.TabIndex = 423;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.TotalSale,
            this.TotalRecovered,
            this.Disc,
            this.DiscVal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 287);
            this.dataGridView1.TabIndex = 422;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Cus.ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // TotalSale
            // 
            this.TotalSale.HeaderText = "Total Sale";
            this.TotalSale.Name = "TotalSale";
            this.TotalSale.ReadOnly = true;
            this.TotalSale.Width = 120;
            // 
            // TotalRecovered
            // 
            this.TotalRecovered.HeaderText = "Total Recovered";
            this.TotalRecovered.Name = "TotalRecovered";
            this.TotalRecovered.ReadOnly = true;
            this.TotalRecovered.Width = 110;
            // 
            // Disc
            // 
            this.Disc.HeaderText = "Disc %";
            this.Disc.Name = "Disc";
            this.Disc.ReadOnly = true;
            this.Disc.Width = 110;
            // 
            // DiscVal
            // 
            this.DiscVal.HeaderText = "Disc.Val";
            this.DiscVal.Name = "DiscVal";
            this.DiscVal.ReadOnly = true;
            this.DiscVal.Width = 110;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(12, 519);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 13);
            this.label31.TabIndex = 430;
            this.label31.Text = "Narration";
            // 
            // TxtNarration
            // 
            this.TxtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNarration.Location = new System.Drawing.Point(12, 535);
            this.TxtNarration.Name = "TxtNarration";
            this.TxtNarration.Size = new System.Drawing.Size(695, 20);
            this.TxtNarration.TabIndex = 429;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(449, 569);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 26);
            this.CmdClose.TabIndex = 435;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(381, 570);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(63, 25);
            this.CmdSelect.TabIndex = 434;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(180, 570);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 25);
            this.CmdSave.TabIndex = 431;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(248, 570);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 25);
            this.CmdClear.TabIndex = 432;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(313, 570);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(63, 25);
            this.CmdDelete.TabIndex = 433;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(635, 133);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 23);
            this.btnRefresh.TabIndex = 436;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MMM/yy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(274, 135);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(98, 20);
            this.dtpTo.TabIndex = 437;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MMM/yy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(172, 135);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(96, 20);
            this.dtpFrom.TabIndex = 438;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(1, 27);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(736, 39);
            this.label41.TabIndex = 439;
            this.label41.Text = "Company Special Discount(Customer Wise)";
            // 
            // FrmCompanyDiscountCustomerWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Defination.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(736, 602);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.TxtNarration);
            this.Controls.Add(this.ChkSMSEnabled);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtTotalRecievables);
            this.Controls.Add(this.TxtTotalBalance);
            this.Controls.Add(this.TxtTotalDiscount);
            this.Controls.Add(this.TxtTotalRecovered);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmbPartyGroup);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbPartyType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbTown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbSector);
            this.Controls.Add(this.BtnSalesman);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSMName);
            this.Controls.Add(this.TxtSMID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpRecoveryDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRecoveryID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompanyDiscountCustomerWise";
            this.Text = "Company Discount (Customer Wise)";
            this.Load += new System.EventHandler(this.FrmCompanyDiscountCustomerWise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRecoveryDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRecoveryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalesman;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSMName;
        private System.Windows.Forms.TextBox TxtSMID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbSector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbPartyType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbPartyGroup;
        private System.Windows.Forms.CheckBox ChkSMSEnabled;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTotalRecievables;
        private System.Windows.Forms.TextBox TxtTotalBalance;
        private System.Windows.Forms.TextBox TxtTotalDiscount;
        private System.Windows.Forms.TextBox TxtTotalRecovered;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox TxtNarration;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRecovered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscVal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label41;
    }
}