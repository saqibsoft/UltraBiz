namespace Defination
{
    partial class OpeningStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningStock));
            this.CmbGroups = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSchProducts = new System.Windows.Forms.Button();
            this.fmTotalQty = new System.Windows.Forms.GroupBox();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.txtTotalPurchase = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtNetValue = new System.Windows.Forms.TextBox();
            this.txtPack = new System.Windows.Forms.TextBox();
            this.CmbPackName = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQtyL = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.fmStores = new System.Windows.Forms.GroupBox();
            this.GridSNo = new System.Windows.Forms.DataGridView();
            this.Stores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQtyLoose = new System.Windows.Forms.TextBox();
            this.txtQtyP = new System.Windows.Forms.TextBox();
            this.CmbStores = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fmTotalQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.fmStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSNo)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbGroups
            // 
            this.CmbGroups.FormattingEnabled = true;
            this.CmbGroups.Location = new System.Drawing.Point(41, 188);
            this.CmbGroups.Name = "CmbGroups";
            this.CmbGroups.Size = new System.Drawing.Size(150, 21);
            this.CmbGroups.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(38, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Group:";
            // 
            // CmbFilter
            // 
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Location = new System.Drawing.Point(41, 150);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(220, 21);
            this.CmbFilter.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(38, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Company:";
            // 
            // btnSchProducts
            // 
            this.btnSchProducts.Location = new System.Drawing.Point(276, 148);
            this.btnSchProducts.Name = "btnSchProducts";
            this.btnSchProducts.Size = new System.Drawing.Size(62, 23);
            this.btnSchProducts.TabIndex = 158;
            this.btnSchProducts.Text = "Product..";
            this.btnSchProducts.UseVisualStyleBackColor = true;
            // 
            // fmTotalQty
            // 
            this.fmTotalQty.BackColor = System.Drawing.Color.Transparent;
            this.fmTotalQty.Controls.Add(this.txtTotalSale);
            this.fmTotalQty.Controls.Add(this.txtTotalPurchase);
            this.fmTotalQty.Controls.Add(this.label19);
            this.fmTotalQty.Controls.Add(this.label20);
            this.fmTotalQty.Location = new System.Drawing.Point(260, 188);
            this.fmTotalQty.Name = "fmTotalQty";
            this.fmTotalQty.Size = new System.Drawing.Size(191, 61);
            this.fmTotalQty.TabIndex = 159;
            this.fmTotalQty.TabStop = false;
            this.fmTotalQty.Text = "Total Qty";
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSale.Location = new System.Drawing.Point(102, 36);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(83, 20);
            this.txtTotalSale.TabIndex = 162;
            this.txtTotalSale.TabStop = false;
            // 
            // txtTotalPurchase
            // 
            this.txtTotalPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPurchase.Location = new System.Drawing.Point(8, 37);
            this.txtTotalPurchase.Name = "txtTotalPurchase";
            this.txtTotalPurchase.ReadOnly = true;
            this.txtTotalPurchase.Size = new System.Drawing.Size(88, 20);
            this.txtTotalPurchase.TabIndex = 161;
            this.txtTotalPurchase.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(9, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 106;
            this.label19.Text = "Purchased";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(101, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 108;
            this.label20.Text = "Sold";
            // 
            // TxtProductID
            // 
            this.TxtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductID.Location = new System.Drawing.Point(62, 289);
            this.TxtProductID.MaxLength = 25;
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(76, 20);
            this.TxtProductID.TabIndex = 120;
            this.TxtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(62, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Prod.D:";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(499, 288);
            this.txtQty.MaxLength = 25;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(58, 20);
            this.txtQty.TabIndex = 117;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(344, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Pack Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(138, 289);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(208, 20);
            this.txtProductName.TabIndex = 116;
            this.txtProductName.TabStop = false;
            // 
            // txtNetValue
            // 
            this.txtNetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetValue.Location = new System.Drawing.Point(670, 288);
            this.txtNetValue.Name = "txtNetValue";
            this.txtNetValue.ReadOnly = true;
            this.txtNetValue.Size = new System.Drawing.Size(109, 20);
            this.txtNetValue.TabIndex = 160;
            this.txtNetValue.TabStop = false;
            // 
            // txtPack
            // 
            this.txtPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPack.Location = new System.Drawing.Point(437, 288);
            this.txtPack.Name = "txtPack";
            this.txtPack.ReadOnly = true;
            this.txtPack.Size = new System.Drawing.Size(62, 20);
            this.txtPack.TabIndex = 161;
            this.txtPack.TabStop = false;
            // 
            // CmbPackName
            // 
            this.CmbPackName.FormattingEnabled = true;
            this.CmbPackName.Location = new System.Drawing.Point(346, 288);
            this.CmbPackName.Name = "CmbPackName";
            this.CmbPackName.Size = new System.Drawing.Size(91, 21);
            this.CmbPackName.TabIndex = 162;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(611, 288);
            this.txtPrice.MaxLength = 25;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(59, 20);
            this.txtPrice.TabIndex = 163;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtyL
            // 
            this.txtQtyL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyL.Location = new System.Drawing.Point(557, 288);
            this.txtQtyL.MaxLength = 25;
            this.txtQtyL.Name = "txtQtyL";
            this.txtQtyL.Size = new System.Drawing.Size(54, 20);
            this.txtQtyL.TabIndex = 164;
            this.txtQtyL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.ProductID,
            this.ProductName,
            this.PName,
            this.Pack,
            this.QtyP,
            this.QtyL,
            this.Price,
            this.Value});
            this.Grid.Location = new System.Drawing.Point(12, 311);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(767, 323);
            this.Grid.TabIndex = 165;
            // 
            // SrNo
            // 
            this.SrNo.DataPropertyName = "Sr #";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SrNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.SrNo.HeaderText = "Sr#";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.Width = 25;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 70;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 210;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "P.Name";
            this.PName.HeaderText = "P.Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 90;
            // 
            // Pack
            // 
            this.Pack.DataPropertyName = "Pack";
            this.Pack.HeaderText = "Pack";
            this.Pack.Name = "Pack";
            this.Pack.ReadOnly = true;
            this.Pack.Width = 65;
            // 
            // QtyP
            // 
            this.QtyP.DataPropertyName = "Qty(P)";
            this.QtyP.HeaderText = "Qty(P)";
            this.QtyP.Name = "QtyP";
            this.QtyP.ReadOnly = true;
            this.QtyP.Width = 57;
            // 
            // QtyL
            // 
            this.QtyL.DataPropertyName = "Qty(L)";
            this.QtyL.HeaderText = "Qty(L)";
            this.QtyL.Name = "QtyL";
            this.QtyL.ReadOnly = true;
            this.QtyL.Width = 57;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 57;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "NetValue";
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(138, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 166;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(434, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 167;
            this.label3.Text = "Pack";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(497, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 168;
            this.label6.Text = "Qty(P)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(556, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 169;
            this.label8.Text = "Qty(L)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(613, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 170;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(672, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 171;
            this.label10.Text = "NetValue";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(357, 650);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 174;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(186, 650);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(87, 23);
            this.CmdDelete.TabIndex = 173;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(506, 650);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 172;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(432, 650);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 175;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // fmStores
            // 
            this.fmStores.BackColor = System.Drawing.Color.Transparent;
            this.fmStores.Controls.Add(this.GridSNo);
            this.fmStores.Controls.Add(this.label11);
            this.fmStores.Controls.Add(this.label12);
            this.fmStores.Controls.Add(this.txtQtyLoose);
            this.fmStores.Controls.Add(this.txtQtyP);
            this.fmStores.Controls.Add(this.CmbStores);
            this.fmStores.Controls.Add(this.label13);
            this.fmStores.Location = new System.Drawing.Point(506, 132);
            this.fmStores.Name = "fmStores";
            this.fmStores.Size = new System.Drawing.Size(273, 137);
            this.fmStores.TabIndex = 163;
            this.fmStores.TabStop = false;
            this.fmStores.Visible = false;
            // 
            // GridSNo
            // 
            this.GridSNo.AllowUserToAddRows = false;
            this.GridSNo.AllowUserToDeleteRows = false;
            this.GridSNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stores,
            this.Qty,
            this.QtyLo});
            this.GridSNo.Location = new System.Drawing.Point(6, 54);
            this.GridSNo.Name = "GridSNo";
            this.GridSNo.ReadOnly = true;
            this.GridSNo.RowHeadersWidth = 30;
            this.GridSNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSNo.Size = new System.Drawing.Size(263, 77);
            this.GridSNo.TabIndex = 182;
            // 
            // Stores
            // 
            this.Stores.DataPropertyName = "Stores";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Stores.DefaultCellStyle = dataGridViewCellStyle3;
            this.Stores.HeaderText = "Stores";
            this.Stores.Name = "Stores";
            this.Stores.ReadOnly = true;
            this.Stores.Width = 90;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty(P)";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle4;
            this.Qty.HeaderText = "Qty(P)";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 70;
            // 
            // QtyLo
            // 
            this.QtyLo.DataPropertyName = "Qty(L)";
            this.QtyLo.HeaderText = "Qty(L)";
            this.QtyLo.Name = "QtyLo";
            this.QtyLo.ReadOnly = true;
            this.QtyLo.Width = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 181;
            this.label11.Text = "Qty(L)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 180;
            this.label12.Text = "Qty(P)";
            // 
            // txtQtyLoose
            // 
            this.txtQtyLoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyLoose.Location = new System.Drawing.Point(197, 32);
            this.txtQtyLoose.MaxLength = 25;
            this.txtQtyLoose.Name = "txtQtyLoose";
            this.txtQtyLoose.Size = new System.Drawing.Size(72, 20);
            this.txtQtyLoose.TabIndex = 179;
            this.txtQtyLoose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtyP
            // 
            this.txtQtyP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyP.Location = new System.Drawing.Point(125, 32);
            this.txtQtyP.MaxLength = 25;
            this.txtQtyP.Name = "txtQtyP";
            this.txtQtyP.Size = new System.Drawing.Size(72, 20);
            this.txtQtyP.TabIndex = 178;
            this.txtQtyP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmbStores
            // 
            this.CmbStores.FormattingEnabled = true;
            this.CmbStores.Location = new System.Drawing.Point(6, 32);
            this.CmbStores.Name = "CmbStores";
            this.CmbStores.Size = new System.Drawing.Size(118, 21);
            this.CmbStores.TabIndex = 177;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 176;
            this.label13.Text = "Stores";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(167, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 36);
            this.label14.TabIndex = 176;
            this.label14.Text = "Opening Stock";
            // 
            // OpeningStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(792, 679);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fmStores);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtQtyL);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.CmbPackName);
            this.Controls.Add(this.txtPack);
            this.Controls.Add(this.txtNetValue);
            this.Controls.Add(this.TxtProductID);
            this.Controls.Add(this.fmTotalQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSchProducts);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.CmbGroups);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpeningStock";
            this.Text = "OpeningStock";
            this.Load += new System.EventHandler(this.OpeningStock_Load);
            this.fmTotalQty.ResumeLayout(false);
            this.fmTotalQty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.fmStores.ResumeLayout(false);
            this.fmStores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbGroups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSchProducts;
        private System.Windows.Forms.GroupBox fmTotalQty;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.TextBox txtTotalPurchase;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtNetValue;
        private System.Windows.Forms.TextBox txtPack;
        private System.Windows.Forms.ComboBox CmbPackName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQtyL;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyP;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.GroupBox fmStores;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQtyLoose;
        private System.Windows.Forms.TextBox txtQtyP;
        private System.Windows.Forms.ComboBox CmbStores;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView GridSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyLo;
        private System.Windows.Forms.Label label14;
    }
}