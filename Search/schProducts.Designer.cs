namespace Search
{
    partial class schProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schProducts));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtProductGroup = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilter.Location = new System.Drawing.Point(228, 55);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(249, 23);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // txtProductGroup
            // 
            this.txtProductGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProductGroup.Location = new System.Drawing.Point(36, 55);
            this.txtProductGroup.Name = "txtProductGroup";
            this.txtProductGroup.Size = new System.Drawing.Size(179, 23);
            this.txtProductGroup.TabIndex = 10;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.CompanyName,
            this.CStock,
            this.MinSalePrice,
            this.MaxSalePrice});
            this.Grid.Location = new System.Drawing.Point(12, 98);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(673, 331);
            this.Grid.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(323, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 26);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelect.Location = new System.Drawing.Point(228, 435);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 26);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductId.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 65;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 175;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // CStock
            // 
            this.CStock.DataPropertyName = "CStock";
            this.CStock.HeaderText = "CStock";
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            // 
            // MinSalePrice
            // 
            this.MinSalePrice.DataPropertyName = "MinSalePrice";
            this.MinSalePrice.HeaderText = "MinSalePrice";
            this.MinSalePrice.Name = "MinSalePrice";
            this.MinSalePrice.ReadOnly = true;
            // 
            // MaxSalePrice
            // 
            this.MaxSalePrice.DataPropertyName = "MaxSalePrice";
            this.MaxSalePrice.HeaderText = "MaxSalePrice";
            this.MaxSalePrice.Name = "MaxSalePrice";
            this.MaxSalePrice.ReadOnly = true;
            // 
            // schProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 465);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtProductGroup);
            this.Controls.Add(this.txtFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "schProducts";
            this.Text = "schProducts";
            this.Load += new System.EventHandler(this.schProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtProductGroup;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSalePrice;
    }
}