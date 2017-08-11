namespace Reports
{
    partial class RptStockCountSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptStockCountSheet));
            this.label15 = new System.Windows.Forms.Label();
            this.TxtCompanyID = new System.Windows.Forms.TextBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.BtnSchCompany = new System.Windows.Forms.Button();
            this.OptSalePrice = new System.Windows.Forms.RadioButton();
            this.OptPurchasePrice = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(93, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 618;
            this.label15.Text = "Company:";
            // 
            // TxtCompanyID
            // 
            this.TxtCompanyID.BackColor = System.Drawing.Color.White;
            this.TxtCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyID.Enabled = false;
            this.TxtCompanyID.Location = new System.Drawing.Point(95, 167);
            this.TxtCompanyID.Name = "TxtCompanyID";
            this.TxtCompanyID.ReadOnly = true;
            this.TxtCompanyID.Size = new System.Drawing.Size(64, 20);
            this.TxtCompanyID.TabIndex = 617;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyName.Location = new System.Drawing.Point(185, 167);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(237, 20);
            this.TxtCompanyName.TabIndex = 616;
            // 
            // BtnSchCompany
            // 
            this.BtnSchCompany.Location = new System.Drawing.Point(158, 166);
            this.BtnSchCompany.Name = "BtnSchCompany";
            this.BtnSchCompany.Size = new System.Drawing.Size(28, 22);
            this.BtnSchCompany.TabIndex = 615;
            this.BtnSchCompany.Text = "....";
            this.BtnSchCompany.UseVisualStyleBackColor = true;
            // 
            // OptSalePrice
            // 
            this.OptSalePrice.AutoSize = true;
            this.OptSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.OptSalePrice.Location = new System.Drawing.Point(119, 216);
            this.OptSalePrice.Name = "OptSalePrice";
            this.OptSalePrice.Size = new System.Drawing.Size(100, 17);
            this.OptSalePrice.TabIndex = 665;
            this.OptSalePrice.TabStop = true;
            this.OptSalePrice.Text = "Sale Price Wise";
            this.OptSalePrice.UseVisualStyleBackColor = false;
            this.OptSalePrice.Visible = false;
            // 
            // OptPurchasePrice
            // 
            this.OptPurchasePrice.AutoSize = true;
            this.OptPurchasePrice.BackColor = System.Drawing.Color.Transparent;
            this.OptPurchasePrice.Location = new System.Drawing.Point(120, 239);
            this.OptPurchasePrice.Name = "OptPurchasePrice";
            this.OptPurchasePrice.Size = new System.Drawing.Size(124, 17);
            this.OptPurchasePrice.TabIndex = 666;
            this.OptPurchasePrice.TabStop = true;
            this.OptPurchasePrice.Text = "Purchase Price Wise";
            this.OptPurchasePrice.UseVisualStyleBackColor = false;
            this.OptPurchasePrice.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 26);
            this.btnClose.TabIndex = 668;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(139, 322);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 26);
            this.btnPreview.TabIndex = 667;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // RptStockCountSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(508, 360);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.OptPurchasePrice);
            this.Controls.Add(this.OptSalePrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtCompanyID);
            this.Controls.Add(this.TxtCompanyName);
            this.Controls.Add(this.BtnSchCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptStockCountSheet";
            this.Text = "Stock Count Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtCompanyID;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Button BtnSchCompany;
        private System.Windows.Forms.RadioButton OptSalePrice;
        private System.Windows.Forms.RadioButton OptPurchasePrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
    }
}