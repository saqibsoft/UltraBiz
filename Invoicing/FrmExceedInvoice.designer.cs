namespace Invoicing
{
    partial class FrmExceedInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExceedInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCurrStock = new System.Windows.Forms.TextBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.TxtNarration = new System.Windows.Forms.TextBox();
            this.dtpExceedInvoice = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtTTLNetVal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CmbPackName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.TxtQtyL = new System.Windows.Forms.TextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(498, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 476;
            this.label1.Text = "Curr. Stock P-L";
            // 
            // TxtCurrStock
            // 
            this.TxtCurrStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtCurrStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCurrStock.Location = new System.Drawing.Point(499, 126);
            this.TxtCurrStock.Name = "TxtCurrStock";
            this.TxtCurrStock.Size = new System.Drawing.Size(81, 20);
            this.TxtCurrStock.TabIndex = 475;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(389, 532);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 23);
            this.CmdClose.TabIndex = 474;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(321, 532);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(63, 23);
            this.CmdSelect.TabIndex = 473;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(120, 532);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 23);
            this.CmdSave.TabIndex = 470;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(253, 532);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(63, 23);
            this.CmdDelete.TabIndex = 472;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(188, 532);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 23);
            this.CmdClear.TabIndex = 471;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(15, 484);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 13);
            this.label31.TabIndex = 469;
            this.label31.Text = "Narration";
            // 
            // TxtNarration
            // 
            this.TxtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNarration.Location = new System.Drawing.Point(15, 500);
            this.TxtNarration.Name = "TxtNarration";
            this.TxtNarration.Size = new System.Drawing.Size(563, 20);
            this.TxtNarration.TabIndex = 468;
            // 
            // dtpExceedInvoice
            // 
            this.dtpExceedInvoice.CustomFormat = "dd//MMM/yy";
            this.dtpExceedInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExceedInvoice.Location = new System.Drawing.Point(78, 127);
            this.dtpExceedInvoice.Name = "dtpExceedInvoice";
            this.dtpExceedInvoice.Size = new System.Drawing.Size(91, 20);
            this.dtpExceedInvoice.TabIndex = 467;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(75, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 466;
            this.label6.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 465;
            this.label4.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtID.Location = new System.Drawing.Point(13, 126);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(61, 20);
            this.TxtID.TabIndex = 464;
            // 
            // TxtQty
            // 
            this.TxtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQty.Location = new System.Drawing.Point(334, 175);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(64, 20);
            this.TxtQty.TabIndex = 463;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(508, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 462;
            this.label18.Text = "Total Amount";
            // 
            // TxtTTLNetVal
            // 
            this.TxtTTLNetVal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTTLNetVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTTLNetVal.Location = new System.Drawing.Point(511, 175);
            this.TxtTTLNetVal.Name = "TxtTTLNetVal";
            this.TxtTTLNetVal.Size = new System.Drawing.Size(67, 20);
            this.TxtTTLNetVal.TabIndex = 461;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(188, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 460;
            this.label20.Text = "Pack Name";
            // 
            // CmbPackName
            // 
            this.CmbPackName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPackName.FormattingEnabled = true;
            this.CmbPackName.Location = new System.Drawing.Point(193, 174);
            this.CmbPackName.Name = "CmbPackName";
            this.CmbPackName.Size = new System.Drawing.Size(78, 21);
            this.CmbPackName.TabIndex = 459;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(458, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 458;
            this.label17.Text = "Rate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(403, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 457;
            this.label16.Text = "L.Qty";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(328, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 456;
            this.label15.Text = "P.Qty";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(271, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 455;
            this.label14.Text = "Size";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(63, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 454;
            this.label12.Text = "Product Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(12, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 453;
            this.label11.Text = "Prod.ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Packing,
            this.Size,
            this.QtyP,
            this.QtyL,
            this.Price,
            this.NetAmount});
            this.dataGridView1.Location = new System.Drawing.Point(15, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 265);
            this.dataGridView1.TabIndex = 452;
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
            this.Packing.Width = 75;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 65;
            // 
            // QtyP
            // 
            this.QtyP.DataPropertyName = "QtyP";
            this.QtyP.HeaderText = "PQty";
            this.QtyP.Name = "QtyP";
            this.QtyP.ReadOnly = true;
            this.QtyP.Width = 58;
            // 
            // QtyL
            // 
            this.QtyL.DataPropertyName = "QtyL";
            this.QtyL.HeaderText = "LQty";
            this.QtyL.Name = "QtyL";
            this.QtyL.ReadOnly = true;
            this.QtyL.Width = 58;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 58;
            // 
            // NetAmount
            // 
            this.NetAmount.DataPropertyName = "NetAmount";
            this.NetAmount.HeaderText = "Value";
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.ReadOnly = true;
            this.NetAmount.Width = 80;
            // 
            // TxtPrice
            // 
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrice.Location = new System.Drawing.Point(453, 175);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(59, 20);
            this.TxtPrice.TabIndex = 451;
            // 
            // TxtSize
            // 
            this.TxtSize.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSize.Location = new System.Drawing.Point(272, 175);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(63, 20);
            this.TxtSize.TabIndex = 450;
            // 
            // TxtQtyL
            // 
            this.TxtQtyL.BackColor = System.Drawing.SystemColors.Window;
            this.TxtQtyL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQtyL.Enabled = false;
            this.TxtQtyL.Location = new System.Drawing.Point(397, 175);
            this.TxtQtyL.Name = "TxtQtyL";
            this.TxtQtyL.Size = new System.Drawing.Size(57, 20);
            this.TxtQtyL.TabIndex = 449;
            // 
            // TxtProductName
            // 
            this.TxtProductName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductName.Location = new System.Drawing.Point(58, 175);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(134, 20);
            this.TxtProductName.TabIndex = 448;
            this.TxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtProductID
            // 
            this.TxtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductID.Location = new System.Drawing.Point(13, 175);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(53, 20);
            this.TxtProductID.TabIndex = 447;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 39);
            this.label2.TabIndex = 477;
            this.label2.Text = "Exceed Invoice";
            // 
            // FrmExceedInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Defination.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(590, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCurrStock);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.TxtNarration);
            this.Controls.Add(this.dtpExceedInvoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtTTLNetVal);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CmbPackName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.TxtQtyL);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.TxtProductID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExceedInvoice";
            this.Text = "Exceed Invoice";
            this.Load += new System.EventHandler(this.FrmExceedInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCurrStock;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox TxtNarration;
        private System.Windows.Forms.DateTimePicker dtpExceedInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtTTLNetVal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox CmbPackName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.TextBox TxtQtyL;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyP;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAmount;
    }
}