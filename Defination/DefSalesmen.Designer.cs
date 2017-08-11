namespace Defination
{
    partial class DefSalesmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefSalesmen));
            this.label16 = new System.Windows.Forms.Label();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.SalesmanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtCommisionRatio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkStaff = new System.Windows.Forms.CheckBox();
            this.chkStockHolder = new System.Windows.Forms.CheckBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtPrefix = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbOffice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(333, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 92;
            this.label16.Text = "Name :";
            // 
            // TxtFilter
            // 
            this.TxtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFilter.Location = new System.Drawing.Point(376, 132);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(252, 20);
            this.TxtFilter.TabIndex = 91;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesmanID,
            this.SalesmanName});
            this.Grid.Location = new System.Drawing.Point(304, 155);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(324, 348);
            this.Grid.TabIndex = 90;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // SalesmanID
            // 
            this.SalesmanID.DataPropertyName = "SalesmanID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SalesmanID.DefaultCellStyle = dataGridViewCellStyle1;
            this.SalesmanID.HeaderText = "SalesmenID";
            this.SalesmanID.Name = "SalesmanID";
            this.SalesmanID.ReadOnly = true;
            // 
            // SalesmanName
            // 
            this.SalesmanName.DataPropertyName = "SalesmanName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SalesmanName.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalesmanName.HeaderText = "SalesmenName";
            this.SalesmanName.Name = "SalesmanName";
            this.SalesmanName.ReadOnly = true;
            this.SalesmanName.Width = 190;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(9, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 112;
            this.label9.Text = "NIC No:";
            // 
            // txtNIC
            // 
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIC.Location = new System.Drawing.Point(10, 445);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(286, 20);
            this.txtNIC.TabIndex = 102;
            // 
            // txtCommisionRatio
            // 
            this.txtCommisionRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommisionRatio.Location = new System.Drawing.Point(10, 483);
            this.txtCommisionRatio.Name = "txtCommisionRatio";
            this.txtCommisionRatio.Size = new System.Drawing.Size(118, 20);
            this.txtCommisionRatio.TabIndex = 119;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(9, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 120;
            this.label10.Text = "Commission(%):";
            // 
            // chkStaff
            // 
            this.chkStaff.AutoSize = true;
            this.chkStaff.BackColor = System.Drawing.Color.Transparent;
            this.chkStaff.Location = new System.Drawing.Point(236, 483);
            this.chkStaff.Name = "chkStaff";
            this.chkStaff.Size = new System.Drawing.Size(59, 17);
            this.chkStaff.TabIndex = 122;
            this.chkStaff.Text = "Is Staff";
            this.chkStaff.UseVisualStyleBackColor = false;
            // 
            // chkStockHolder
            // 
            this.chkStockHolder.AutoSize = true;
            this.chkStockHolder.BackColor = System.Drawing.Color.Transparent;
            this.chkStockHolder.Location = new System.Drawing.Point(134, 484);
            this.chkStockHolder.Name = "chkStockHolder";
            this.chkStockHolder.Size = new System.Drawing.Size(99, 17);
            this.chkStockHolder.TabIndex = 121;
            this.chkStockHolder.Text = "Is Stock Holder";
            this.chkStockHolder.UseVisualStyleBackColor = false;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(413, 524);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 23);
            this.CmdClose.TabIndex = 127;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(345, 524);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(63, 23);
            this.CmdSelect.TabIndex = 126;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            this.CmdSelect.Click += new System.EventHandler(this.CmdSelect_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(144, 524);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 23);
            this.CmdSave.TabIndex = 123;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(277, 524);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(63, 23);
            this.CmdDelete.TabIndex = 125;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(212, 524);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 23);
            this.CmdClear.TabIndex = 124;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // txtDesignation
            // 
            this.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesignation.Location = new System.Drawing.Point(154, 132);
            this.txtDesignation.MaxLength = 100;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(141, 20);
            this.txtDesignation.TabIndex = 144;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(153, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 145;
            this.label14.Text = "Designation:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(12, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 143;
            this.label11.Text = "SalesmanID:";
            // 
            // TxtID
            // 
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtID.Location = new System.Drawing.Point(69, 132);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(72, 20);
            this.TxtID.TabIndex = 142;
            // 
            // TxtPrefix
            // 
            this.TxtPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrefix.Location = new System.Drawing.Point(15, 132);
            this.TxtPrefix.Name = "TxtPrefix";
            this.TxtPrefix.ReadOnly = true;
            this.TxtPrefix.Size = new System.Drawing.Size(55, 20);
            this.TxtPrefix.TabIndex = 141;
            this.TxtPrefix.TabStop = false;
            this.TxtPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(153, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 139;
            this.label15.Text = "Mobile No:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(9, 387);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 138;
            this.label17.Text = "Phone Nos:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(5, 348);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 137;
            this.label18.Text = "City:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(5, 278);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 136;
            this.label19.Text = "Address:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(13, 202);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 135;
            this.label20.Text = "Name :";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Location = new System.Drawing.Point(154, 402);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(142, 20);
            this.txtMobileNo.TabIndex = 132;
            // 
            // txtPhone1
            // 
            this.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone1.Location = new System.Drawing.Point(8, 402);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(142, 20);
            this.txtPhone1.TabIndex = 131;
            // 
            // TxtCity
            // 
            this.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCity.Location = new System.Drawing.Point(8, 364);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(288, 20);
            this.TxtCity.TabIndex = 130;
            // 
            // TxtAddress
            // 
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddress.Location = new System.Drawing.Point(8, 291);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(288, 54);
            this.TxtAddress.TabIndex = 129;
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Location = new System.Drawing.Point(8, 216);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(288, 20);
            this.TxtName.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 149;
            this.label2.Text = "Office Name:";
            // 
            // CmbOffice
            // 
            this.CmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOffice.FormattingEnabled = true;
            this.CmbOffice.Location = new System.Drawing.Point(8, 171);
            this.CmbOffice.Name = "CmbOffice";
            this.CmbOffice.Size = new System.Drawing.Size(214, 21);
            this.CmbOffice.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(128, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 36);
            this.label3.TabIndex = 150;
            this.label3.Text = "Staff And Salesman";
            // 
            // DefSalesmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(633, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbOffice);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtPrefix);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.chkStaff);
            this.Controls.Add(this.chkStockHolder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCommisionRatio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefSalesmen";
            this.Text = "Staff & Salesmen";
            this.Load += new System.EventHandler(this.DefSalesmen_Load);
            this.Click += new System.EventHandler(this.Grid_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtCommisionRatio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkStaff;
        private System.Windows.Forms.CheckBox chkStockHolder;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtPrefix;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbOffice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanName;
    }
}