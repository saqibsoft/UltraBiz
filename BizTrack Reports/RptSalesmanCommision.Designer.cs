namespace Reports
{
    partial class RptSalesmanCommision
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
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSchProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSalesmanID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSchSalesman = new System.Windows.Forms.Button();
            this.txtSalesmanName = new System.Windows.Forms.TextBox();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenCompany = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCommissionRatio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkProductWiseCommission = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductCode
            // 
            this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCode.Location = new System.Drawing.Point(35, 176);
            this.txtProductCode.MaxLength = 25;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(76, 20);
            this.txtProductCode.TabIndex = 255;
            this.txtProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(32, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 256;
            this.label4.Text = "Product:";
            // 
            // btnSchProduct
            // 
            this.btnSchProduct.Location = new System.Drawing.Point(110, 174);
            this.btnSchProduct.Name = "btnSchProduct";
            this.btnSchProduct.Size = new System.Drawing.Size(30, 23);
            this.btnSchProduct.TabIndex = 254;
            this.btnSchProduct.Text = "...";
            this.btnSchProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(169, 174);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(229, 20);
            this.txtProductName.TabIndex = 253;
            this.txtProductName.TabStop = false;
            // 
            // txtSalesmanID
            // 
            this.txtSalesmanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesmanID.Location = new System.Drawing.Point(35, 218);
            this.txtSalesmanID.MaxLength = 25;
            this.txtSalesmanID.Name = "txtSalesmanID";
            this.txtSalesmanID.Size = new System.Drawing.Size(76, 20);
            this.txtSalesmanID.TabIndex = 251;
            this.txtSalesmanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(32, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 252;
            this.label5.Text = "Salesman:";
            // 
            // btnSchSalesman
            // 
            this.btnSchSalesman.Location = new System.Drawing.Point(110, 216);
            this.btnSchSalesman.Name = "btnSchSalesman";
            this.btnSchSalesman.Size = new System.Drawing.Size(30, 23);
            this.btnSchSalesman.TabIndex = 250;
            this.btnSchSalesman.Text = "...";
            this.btnSchSalesman.UseVisualStyleBackColor = true;
            // 
            // txtSalesmanName
            // 
            this.txtSalesmanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesmanName.Location = new System.Drawing.Point(169, 216);
            this.txtSalesmanName.Name = "txtSalesmanName";
            this.txtSalesmanName.ReadOnly = true;
            this.txtSalesmanName.Size = new System.Drawing.Size(229, 20);
            this.txtSalesmanName.TabIndex = 249;
            this.txtSalesmanName.TabStop = false;
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(161, 267);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 260;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(158, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 259;
            this.label12.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(35, 266);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 258;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(32, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 257;
            this.label13.Text = "From Date:";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyID.Location = new System.Drawing.Point(35, 135);
            this.txtCompanyID.MaxLength = 25;
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(76, 20);
            this.txtCompanyID.TabIndex = 263;
            this.txtCompanyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 264;
            this.label1.Text = "Company ID:";
            // 
            // btnOpenCompany
            // 
            this.btnOpenCompany.Location = new System.Drawing.Point(110, 133);
            this.btnOpenCompany.Name = "btnOpenCompany";
            this.btnOpenCompany.Size = new System.Drawing.Size(30, 23);
            this.btnOpenCompany.TabIndex = 262;
            this.btnOpenCompany.Text = "...";
            this.btnOpenCompany.UseVisualStyleBackColor = true;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Location = new System.Drawing.Point(169, 133);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(229, 20);
            this.txtCompanyName.TabIndex = 261;
            this.txtCompanyName.TabStop = false;
            // 
            // txtCommissionRatio
            // 
            this.txtCommissionRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommissionRatio.Location = new System.Drawing.Point(268, 266);
            this.txtCommissionRatio.MaxLength = 25;
            this.txtCommissionRatio.Name = "txtCommissionRatio";
            this.txtCommissionRatio.Size = new System.Drawing.Size(130, 20);
            this.txtCommissionRatio.TabIndex = 265;
            this.txtCommissionRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(265, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 266;
            this.label2.Text = "Commission Ratio:";
            // 
            // ChkProductWiseCommission
            // 
            this.ChkProductWiseCommission.AutoSize = true;
            this.ChkProductWiseCommission.BackColor = System.Drawing.Color.Transparent;
            this.ChkProductWiseCommission.Location = new System.Drawing.Point(35, 301);
            this.ChkProductWiseCommission.Name = "ChkProductWiseCommission";
            this.ChkProductWiseCommission.Size = new System.Drawing.Size(213, 17);
            this.ChkProductWiseCommission.TabIndex = 267;
            this.ChkProductWiseCommission.Text = "Show Product Wise Commission Report";
            this.ChkProductWiseCommission.UseVisualStyleBackColor = false;
            this.ChkProductWiseCommission.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(178, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 269;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(110, 336);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 268;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(42, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(334, 36);
            this.label15.TabIndex = 270;
            this.label15.Text = "Salesman Commission";
            // 
            // RptSalesmanCommision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(446, 361);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.ChkProductWiseCommission);
            this.Controls.Add(this.txtCommissionRatio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenCompany);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSchProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtSalesmanID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSchSalesman);
            this.Controls.Add(this.txtSalesmanName);
            this.Name = "RptSalesmanCommision";
            this.Text = "Salesman Commision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSchProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSalesmanID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSchSalesman;
        private System.Windows.Forms.TextBox txtSalesmanName;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenCompany;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCommissionRatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkProductWiseCommission;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label15;
    }
}