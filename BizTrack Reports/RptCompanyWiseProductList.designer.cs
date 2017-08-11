namespace Reports
{
    partial class RptCompanyWiseProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptCompanyWiseProductList));
            this.label7 = new System.Windows.Forms.Label();
            this.CmbGroup = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtCompanyID = new System.Windows.Forms.TextBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.BtnSchCompany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.BtnSchProduct = new System.Windows.Forms.Button();
            this.ChkWithoutPrices = new System.Windows.Forms.CheckBox();
            this.ChkGroupwise = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(23, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 622;
            this.label7.Text = "Group";
            // 
            // CmbGroup
            // 
            this.CmbGroup.FormattingEnabled = true;
            this.CmbGroup.Location = new System.Drawing.Point(23, 223);
            this.CmbGroup.Name = "CmbGroup";
            this.CmbGroup.Size = new System.Drawing.Size(222, 21);
            this.CmbGroup.TabIndex = 621;
            this.CmbGroup.SelectedIndexChanged += new System.EventHandler(this.CmbGroup_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(20, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 620;
            this.label15.Text = "CompanyID";
            // 
            // TxtCompanyID
            // 
            this.TxtCompanyID.BackColor = System.Drawing.Color.White;
            this.TxtCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyID.Enabled = false;
            this.TxtCompanyID.Location = new System.Drawing.Point(23, 124);
            this.TxtCompanyID.Name = "TxtCompanyID";
            this.TxtCompanyID.ReadOnly = true;
            this.TxtCompanyID.Size = new System.Drawing.Size(75, 20);
            this.TxtCompanyID.TabIndex = 619;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyName.Location = new System.Drawing.Point(133, 124);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(230, 20);
            this.TxtCompanyName.TabIndex = 618;
            // 
            // BtnSchCompany
            // 
            this.BtnSchCompany.Location = new System.Drawing.Point(97, 123);
            this.BtnSchCompany.Name = "BtnSchCompany";
            this.BtnSchCompany.Size = new System.Drawing.Size(28, 22);
            this.BtnSchCompany.TabIndex = 617;
            this.BtnSchCompany.Text = "....";
            this.BtnSchCompany.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 626;
            this.label1.Text = "ProductID";
            // 
            // TxtProductID
            // 
            this.TxtProductID.BackColor = System.Drawing.Color.White;
            this.TxtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductID.Enabled = false;
            this.TxtProductID.Location = new System.Drawing.Point(23, 171);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.ReadOnly = true;
            this.TxtProductID.Size = new System.Drawing.Size(75, 20);
            this.TxtProductID.TabIndex = 625;
            // 
            // TxtProductName
            // 
            this.TxtProductName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductName.Location = new System.Drawing.Point(133, 171);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(230, 20);
            this.TxtProductName.TabIndex = 624;
            // 
            // BtnSchProduct
            // 
            this.BtnSchProduct.Location = new System.Drawing.Point(97, 170);
            this.BtnSchProduct.Name = "BtnSchProduct";
            this.BtnSchProduct.Size = new System.Drawing.Size(28, 22);
            this.BtnSchProduct.TabIndex = 623;
            this.BtnSchProduct.Text = "....";
            this.BtnSchProduct.UseVisualStyleBackColor = true;
            // 
            // ChkWithoutPrices
            // 
            this.ChkWithoutPrices.AutoSize = true;
            this.ChkWithoutPrices.BackColor = System.Drawing.Color.Transparent;
            this.ChkWithoutPrices.Location = new System.Drawing.Point(30, 277);
            this.ChkWithoutPrices.Name = "ChkWithoutPrices";
            this.ChkWithoutPrices.Size = new System.Drawing.Size(95, 17);
            this.ChkWithoutPrices.TabIndex = 627;
            this.ChkWithoutPrices.Text = "Without Prices";
            this.ChkWithoutPrices.UseVisualStyleBackColor = false;
            this.ChkWithoutPrices.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChkGroupwise
            // 
            this.ChkGroupwise.AutoSize = true;
            this.ChkGroupwise.BackColor = System.Drawing.Color.Transparent;
            this.ChkGroupwise.Location = new System.Drawing.Point(30, 254);
            this.ChkGroupwise.Name = "ChkGroupwise";
            this.ChkGroupwise.Size = new System.Drawing.Size(82, 17);
            this.ChkGroupwise.TabIndex = 628;
            this.ChkGroupwise.Text = "Group Wise";
            this.ChkGroupwise.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(158, 353);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 26);
            this.btnClose.TabIndex = 670;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(84, 353);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(68, 25);
            this.btnPreview.TabIndex = 669;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // RptCompanyWiseProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(412, 384);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.ChkGroupwise);
            this.Controls.Add(this.ChkWithoutPrices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProductID);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.BtnSchProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbGroup);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtCompanyID);
            this.Controls.Add(this.TxtCompanyName);
            this.Controls.Add(this.BtnSchCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptCompanyWiseProductList";
            this.Text = "Company Wise Product List";
            this.Load += new System.EventHandler(this.Company_Wise_Product_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbGroup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtCompanyID;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Button BtnSchCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Button BtnSchProduct;
        private System.Windows.Forms.CheckBox ChkWithoutPrices;
        private System.Windows.Forms.CheckBox ChkGroupwise;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
    }
}