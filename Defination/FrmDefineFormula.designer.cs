namespace Defination
{
    partial class FrmDefineFormula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDefineFormula));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.GridBody = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQtyL = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.CmbPacking = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPQty = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAvgRate = new System.Windows.Forms.TextBox();
            this.CmbPackingHP = new System.Windows.Forms.ComboBox();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.TxtTTLValue = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtExceedId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExceedInvoice = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridBody)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(618, 573);
            this.shapeContainer1.TabIndex = 42;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 4;
            this.lineShape1.X2 = 606;
            this.lineShape1.Y1 = 204;
            this.lineShape1.Y2 = 204;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(146, 539);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 48;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(282, 539);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 47;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(418, 539);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 46;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(214, 539);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 45;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(350, 539);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(62, 23);
            this.CmdOpen.TabIndex = 44;
            this.CmdOpen.Text = "Select";
            this.CmdOpen.UseVisualStyleBackColor = true;
            // 
            // GridBody
            // 
            this.GridBody.AllowUserToAddRows = false;
            this.GridBody.AllowUserToDeleteRows = false;
            this.GridBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Packing,
            this.Size,
            this.PQty,
            this.LQty,
            this.Price,
            this.Value});
            this.GridBody.Location = new System.Drawing.Point(16, 253);
            this.GridBody.Name = "GridBody";
            this.GridBody.ReadOnly = true;
            this.GridBody.RowHeadersWidth = 30;
            this.GridBody.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBody.Size = new System.Drawing.Size(586, 278);
            this.GridBody.TabIndex = 166;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 140;
            // 
            // Packing
            // 
            this.Packing.DataPropertyName = "Packing";
            this.Packing.HeaderText = "Packing";
            this.Packing.Name = "Packing";
            this.Packing.ReadOnly = true;
            this.Packing.Width = 80;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 65;
            // 
            // PQty
            // 
            this.PQty.DataPropertyName = "P Qty";
            this.PQty.HeaderText = "P Qty";
            this.PQty.Name = "PQty";
            this.PQty.ReadOnly = true;
            this.PQty.Width = 57;
            // 
            // LQty
            // 
            this.LQty.DataPropertyName = "L Qty";
            this.LQty.HeaderText = "L Qty";
            this.LQty.Name = "LQty";
            this.LQty.ReadOnly = true;
            this.LQty.Width = 55;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(500, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 187;
            this.label11.Text = "TotalAmount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(441, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 186;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(384, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 185;
            this.label13.Text = "Qty(L)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(325, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 184;
            this.label14.Text = "Qty(P)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(262, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 183;
            this.label15.Text = "Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(72, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 182;
            this.label16.Text = "Product Name:";
            // 
            // txtQtyL
            // 
            this.txtQtyL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyL.Location = new System.Drawing.Point(385, 226);
            this.txtQtyL.MaxLength = 25;
            this.txtQtyL.Name = "txtQtyL";
            this.txtQtyL.Size = new System.Drawing.Size(54, 20);
            this.txtQtyL.TabIndex = 181;
            this.txtQtyL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(439, 226);
            this.txtPrice.MaxLength = 25;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(59, 20);
            this.txtPrice.TabIndex = 180;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmbPacking
            // 
            this.CmbPacking.FormattingEnabled = true;
            this.CmbPacking.Location = new System.Drawing.Point(192, 227);
            this.CmbPacking.Name = "CmbPacking";
            this.CmbPacking.Size = new System.Drawing.Size(73, 21);
            this.CmbPacking.TabIndex = 179;
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSize.Location = new System.Drawing.Point(265, 226);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(62, 20);
            this.txtSize.TabIndex = 178;
            this.txtSize.TabStop = false;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(498, 226);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(103, 20);
            this.txtTotalAmount.TabIndex = 177;
            this.txtTotalAmount.TabStop = false;
            // 
            // TxtProductID
            // 
            this.TxtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductID.Location = new System.Drawing.Point(16, 227);
            this.TxtProductID.MaxLength = 25;
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(56, 20);
            this.TxtProductID.TabIndex = 175;
            this.TxtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(13, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 176;
            this.label17.Text = "Prod.ID:";
            // 
            // txtPQty
            // 
            this.txtPQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPQty.Location = new System.Drawing.Point(327, 226);
            this.txtPQty.MaxLength = 25;
            this.txtPQty.Name = "txtPQty";
            this.txtPQty.Size = new System.Drawing.Size(58, 20);
            this.txtPQty.TabIndex = 173;
            this.txtPQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(191, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 174;
            this.label18.Text = "Paking:";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(72, 227);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(119, 20);
            this.txtProductName.TabIndex = 172;
            this.txtProductName.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(470, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 203;
            this.label4.Text = "TotalValue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(418, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 202;
            this.label5.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(356, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 200;
            this.label7.Text = "Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(293, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 199;
            this.label8.Text = "Multiplier:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(71, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 198;
            this.label9.Text = "Product Name:";
            // 
            // txtAvgRate
            // 
            this.txtAvgRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAvgRate.Location = new System.Drawing.Point(416, 177);
            this.txtAvgRate.MaxLength = 25;
            this.txtAvgRate.Name = "txtAvgRate";
            this.txtAvgRate.Size = new System.Drawing.Size(59, 20);
            this.txtAvgRate.TabIndex = 196;
            this.txtAvgRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmbPackingHP
            // 
            this.CmbPackingHP.FormattingEnabled = true;
            this.CmbPackingHP.Location = new System.Drawing.Point(223, 176);
            this.CmbPackingHP.Name = "CmbPackingHP";
            this.CmbPackingHP.Size = new System.Drawing.Size(73, 21);
            this.CmbPackingHP.TabIndex = 195;
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultiplier.Location = new System.Drawing.Point(296, 177);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.ReadOnly = true;
            this.txtMultiplier.Size = new System.Drawing.Size(62, 20);
            this.txtMultiplier.TabIndex = 194;
            this.txtMultiplier.TabStop = false;
            // 
            // TxtTTLValue
            // 
            this.TxtTTLValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTTLValue.Location = new System.Drawing.Point(475, 177);
            this.TxtTTLValue.Name = "TxtTTLValue";
            this.TxtTTLValue.ReadOnly = true;
            this.TxtTTLValue.Size = new System.Drawing.Size(103, 20);
            this.TxtTTLValue.TabIndex = 193;
            this.TxtTTLValue.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(15, 176);
            this.textBox6.MaxLength = 25;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 20);
            this.textBox6.TabIndex = 191;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(12, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 192;
            this.label10.Text = "Prod.ID:";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(358, 177);
            this.txtQty.MaxLength = 25;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(58, 20);
            this.txtQty.TabIndex = 189;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(222, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 190;
            this.label19.Text = "Paking:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(71, 176);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(151, 20);
            this.textBox8.TabIndex = 188;
            this.textBox8.TabStop = false;
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentStock.Location = new System.Drawing.Point(513, 129);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.ReadOnly = true;
            this.txtCurrentStock.Size = new System.Drawing.Size(88, 20);
            this.txtCurrentStock.TabIndex = 205;
            this.txtCurrentStock.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(514, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 204;
            this.label1.Text = "Curr.StockP-L";
            // 
            // TxtExceedId
            // 
            this.TxtExceedId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtExceedId.Location = new System.Drawing.Point(14, 131);
            this.TxtExceedId.MaxLength = 25;
            this.TxtExceedId.Name = "TxtExceedId";
            this.TxtExceedId.Size = new System.Drawing.Size(86, 20);
            this.TxtExceedId.TabIndex = 209;
            this.TxtExceedId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 208;
            this.label2.Text = "ID";
            // 
            // dtpExceedInvoice
            // 
            this.dtpExceedInvoice.CustomFormat = "dd/MMM/yyyy";
            this.dtpExceedInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExceedInvoice.Location = new System.Drawing.Point(101, 130);
            this.dtpExceedInvoice.Name = "dtpExceedInvoice";
            this.dtpExceedInvoice.Size = new System.Drawing.Size(106, 20);
            this.dtpExceedInvoice.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(98, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 206;
            this.label3.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(105, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 36);
            this.label6.TabIndex = 210;
            this.label6.Text = "Define Formula";
            // 
            // FrmDefineFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 573);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtExceedId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpExceedInvoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAvgRate);
            this.Controls.Add(this.CmbPackingHP);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.TxtTTLValue);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtQtyL);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.CmbPacking);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.TxtProductID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPQty);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.GridBody);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDefineFormula";
            this.Text = "Define Formula";
            this.Load += new System.EventHandler(this.FrmDefineFormula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.DataGridView GridBody;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQtyL;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox CmbPacking;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPQty;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAvgRate;
        private System.Windows.Forms.ComboBox CmbPackingHP;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.TextBox TxtTTLValue;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn LQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TextBox TxtExceedId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpExceedInvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}