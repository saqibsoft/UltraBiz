namespace Defination
{
    partial class DefProductBarcodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefProductBarcodes));
            this.GridProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtShortCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBarCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // GridProduct
            // 
            this.GridProduct.AllowUserToAddRows = false;
            this.GridProduct.AllowUserToDeleteRows = false;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.BarCode,
            this.ShortCode});
            this.GridProduct.Location = new System.Drawing.Point(12, 144);
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.ReadOnly = true;
            this.GridProduct.RowHeadersWidth = 30;
            this.GridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProduct.Size = new System.Drawing.Size(544, 284);
            this.GridProduct.TabIndex = 19;
            this.GridProduct.Click += new System.EventHandler(this.GridProduct_Click);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 70;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 250;
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "Bar Code";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 110;
            // 
            // ShortCode
            // 
            this.ShortCode.HeaderText = "Short Code";
            this.ShortCode.Name = "ShortCode";
            this.ShortCode.ReadOnly = true;
            this.ShortCode.Width = 110;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(329, 434);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 24;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(132, 434);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 20;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(263, 434);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 22;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(198, 434);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 21;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // TxtProductID
            // 
            this.TxtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductID.Location = new System.Drawing.Point(14, 118);
            this.TxtProductID.MaxLength = 100;
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(97, 20);
            this.TxtProductID.TabIndex = 25;
            this.TxtProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProductID_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product ID";
            // 
            // TxtProductName
            // 
            this.TxtProductName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductName.Location = new System.Drawing.Point(110, 118);
            this.TxtProductName.MaxLength = 100;
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(250, 20);
            this.TxtProductName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(110, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product Name";
            // 
            // TxtShortCode
            // 
            this.TxtShortCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtShortCode.Location = new System.Drawing.Point(473, 118);
            this.TxtShortCode.MaxLength = 100;
            this.TxtShortCode.Name = "TxtShortCode";
            this.TxtShortCode.Size = new System.Drawing.Size(83, 20);
            this.TxtShortCode.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(472, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Short Code";
            // 
            // TxtBarCode
            // 
            this.TxtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBarCode.Location = new System.Drawing.Point(359, 118);
            this.TxtBarCode.MaxLength = 100;
            this.TxtBarCode.Name = "TxtBarCode";
            this.TxtBarCode.Size = new System.Drawing.Size(115, 20);
            this.TxtBarCode.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(358, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Bar Code";
            // 
            // DefProductBarcodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 464);
            this.Controls.Add(this.TxtBarCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtShortCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.GridProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefProductBarcodes";
            this.Text = "Product Barcodes";
            this.Load += new System.EventHandler(this.DefProductBarcodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridProduct;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtShortCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBarCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortCode;
    }
}