namespace Invoicing
{
    partial class PurchaseSizewise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseSizewise));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightKgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtTTLWeight = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtWeightKgs = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtSizeName = new System.Windows.Forms.TextBox();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVendorName = new System.Windows.Forms.TextBox();
            this.TxtVendorID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpImvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtRemainingStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsumedStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Size,
            this.SizeName,
            this.Qty,
            this.WeightKgs,
            this.TotalWeight});
            this.Grid.Location = new System.Drawing.Point(18, 272);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(417, 328);
            this.Grid.TabIndex = 29;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "size";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Size.DefaultCellStyle = dataGridViewCellStyle1;
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 55;
            // 
            // SizeName
            // 
            this.SizeName.DataPropertyName = "SizeName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SizeName.DefaultCellStyle = dataGridViewCellStyle2;
            this.SizeName.HeaderText = "SizeName";
            this.SizeName.Name = "SizeName";
            this.SizeName.ReadOnly = true;
            this.SizeName.Width = 90;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 55;
            // 
            // WeightKgs
            // 
            this.WeightKgs.DataPropertyName = "WeightKgs";
            this.WeightKgs.HeaderText = "WeightKgs";
            this.WeightKgs.Name = "WeightKgs";
            this.WeightKgs.ReadOnly = true;
            this.WeightKgs.Width = 80;
            // 
            // TotalWeight
            // 
            this.TotalWeight.DataPropertyName = "TotalWeight";
            this.TotalWeight.HeaderText = "TotalWeight";
            this.TotalWeight.Name = "TotalWeight";
            this.TotalWeight.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(192, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 218;
            this.label1.Text = "Quantity";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(359, 230);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 217;
            this.label22.Text = "Total Weight";
            // 
            // TxtTTLWeight
            // 
            this.TxtTTLWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTTLWeight.Location = new System.Drawing.Point(362, 246);
            this.TxtTTLWeight.Name = "TxtTTLWeight";
            this.TxtTTLWeight.Size = new System.Drawing.Size(73, 20);
            this.TxtTTLWeight.TabIndex = 216;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(279, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 215;
            this.label17.Text = "/Weight(kgs)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(109, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 214;
            this.label16.Text = "Size Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(15, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 213;
            this.label15.Text = "Size";
            // 
            // TxtWeightKgs
            // 
            this.TxtWeightKgs.BackColor = System.Drawing.SystemColors.Window;
            this.TxtWeightKgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWeightKgs.Enabled = false;
            this.TxtWeightKgs.Location = new System.Drawing.Point(281, 246);
            this.TxtWeightKgs.Name = "TxtWeightKgs";
            this.TxtWeightKgs.Size = new System.Drawing.Size(82, 20);
            this.TxtWeightKgs.TabIndex = 212;
            // 
            // TxtQty
            // 
            this.TxtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQty.Location = new System.Drawing.Point(195, 246);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(80, 20);
            this.TxtQty.TabIndex = 211;
            // 
            // TxtSizeName
            // 
            this.TxtSizeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSizeName.Location = new System.Drawing.Point(103, 246);
            this.TxtSizeName.Name = "TxtSizeName";
            this.TxtSizeName.Size = new System.Drawing.Size(92, 20);
            this.TxtSizeName.TabIndex = 210;
            // 
            // TxtSize
            // 
            this.TxtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSize.Location = new System.Drawing.Point(18, 246);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(85, 20);
            this.TxtSize.TabIndex = 209;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(108, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 222;
            this.label6.Text = "Purchase Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 221;
            this.label4.Text = "PurchaseID";
            // 
            // TxtInvoiceNo
            // 
            this.TxtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInvoiceNo.Location = new System.Drawing.Point(18, 115);
            this.TxtInvoiceNo.Name = "TxtInvoiceNo";
            this.TxtInvoiceNo.Size = new System.Drawing.Size(83, 20);
            this.TxtInvoiceNo.TabIndex = 219;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 225;
            this.label2.Text = "Vendor";
            // 
            // TxtVendorName
            // 
            this.TxtVendorName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVendorName.Enabled = false;
            this.TxtVendorName.Location = new System.Drawing.Point(97, 158);
            this.TxtVendorName.Name = "TxtVendorName";
            this.TxtVendorName.Size = new System.Drawing.Size(338, 20);
            this.TxtVendorName.TabIndex = 224;
            // 
            // TxtVendorID
            // 
            this.TxtVendorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVendorID.Location = new System.Drawing.Point(18, 158);
            this.TxtVendorID.Name = "TxtVendorID";
            this.TxtVendorID.Size = new System.Drawing.Size(83, 20);
            this.TxtVendorID.TabIndex = 223;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(98, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 229;
            this.label12.Text = "Prod.Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(17, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 228;
            this.label11.Text = "Prod.ID";
            // 
            // TxtProductName
            // 
            this.TxtProductName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductName.Location = new System.Drawing.Point(99, 207);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(336, 20);
            this.TxtProductName.TabIndex = 227;
            this.TxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtProductID
            // 
            this.TxtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductID.Location = new System.Drawing.Point(18, 207);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(83, 20);
            this.TxtProductID.TabIndex = 226;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(332, 610);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 23);
            this.CmdClose.TabIndex = 234;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(264, 610);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(63, 23);
            this.CmdSelect.TabIndex = 233;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(63, 610);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 23);
            this.CmdSave.TabIndex = 230;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(196, 610);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(63, 23);
            this.CmdDelete.TabIndex = 232;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(131, 610);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 23);
            this.CmdClear.TabIndex = 231;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(64, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 39);
            this.label8.TabIndex = 242;
            this.label8.Text = "Purchase Invoice";
            // 
            // dtpImvoiceDate
            // 
            this.dtpImvoiceDate.Location = new System.Drawing.Point(107, 115);
            this.dtpImvoiceDate.Name = "dtpImvoiceDate";
            this.dtpImvoiceDate.Size = new System.Drawing.Size(97, 20);
            this.dtpImvoiceDate.TabIndex = 243;
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentStock.Location = new System.Drawing.Point(451, 207);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.ReadOnly = true;
            this.txtCurrentStock.Size = new System.Drawing.Size(103, 20);
            this.txtCurrentStock.TabIndex = 245;
            this.txtCurrentStock.TabStop = false;
            this.txtCurrentStock.Visible = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label41.Location = new System.Drawing.Point(449, 192);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(91, 13);
            this.label41.TabIndex = 244;
            this.label41.Text = "Current Stock P-L";
            this.label41.Visible = false;
            // 
            // txtRemainingStock
            // 
            this.txtRemainingStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRemainingStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemainingStock.Location = new System.Drawing.Point(452, 446);
            this.txtRemainingStock.Name = "txtRemainingStock";
            this.txtRemainingStock.ReadOnly = true;
            this.txtRemainingStock.Size = new System.Drawing.Size(103, 20);
            this.txtRemainingStock.TabIndex = 247;
            this.txtRemainingStock.TabStop = false;
            this.txtRemainingStock.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(449, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 246;
            this.label3.Text = "Remaining Stock";
            this.label3.Visible = false;
            // 
            // txtConsumedStock
            // 
            this.txtConsumedStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtConsumedStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsumedStock.Location = new System.Drawing.Point(450, 404);
            this.txtConsumedStock.Name = "txtConsumedStock";
            this.txtConsumedStock.ReadOnly = true;
            this.txtConsumedStock.Size = new System.Drawing.Size(103, 20);
            this.txtConsumedStock.TabIndex = 249;
            this.txtConsumedStock.TabStop = false;
            this.txtConsumedStock.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(448, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 248;
            this.label5.Text = "Consumed Stock";
            this.label5.Visible = false;
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalItems.Location = new System.Drawing.Point(452, 488);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.ReadOnly = true;
            this.txtTotalItems.Size = new System.Drawing.Size(103, 20);
            this.txtTotalItems.TabIndex = 251;
            this.txtTotalItems.TabStop = false;
            this.txtTotalItems.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(449, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 250;
            this.label7.Text = "Total FTs";
            this.label7.Visible = false;
            // 
            // PurchaseSizewise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Defination.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(591, 641);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtConsumedStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemainingStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentStock);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.dtpImvoiceDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.TxtProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtVendorName);
            this.Controls.Add(this.TxtVendorID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtInvoiceNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.TxtTTLWeight);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtWeightKgs);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtSizeName);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseSizewise";
            this.Text = "Size Wise Product Settings";
            this.Load += new System.EventHandler(this.PurchaseSizewise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtTTLWeight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtWeightKgs;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtSizeName;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtVendorName;
        private System.Windows.Forms.TextBox TxtVendorID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpImvoiceDate;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtRemainingStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsumedStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightKgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWeight;
    }
}