namespace Reports
{
    partial class pmtPurchaseReturnSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pmtPurchaseReturnSummary));
            this.label18 = new System.Windows.Forms.Label();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtVendorID = new System.Windows.Forms.TextBox();
            this.TxtVendorName = new System.Windows.Forms.TextBox();
            this.BtnSchVendor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(12, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(425, 37);
            this.label18.TabIndex = 619;
            this.label18.Text = "Purchase Return Summary";
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(168, 132);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 629;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(165, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 628;
            this.label12.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(42, 131);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 627;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(39, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 626;
            this.label13.Text = "From Date:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(168, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 26);
            this.btnClose.TabIndex = 625;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(97, 267);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(65, 25);
            this.btnPreview.TabIndex = 624;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(40, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 623;
            this.label15.Text = "Vendor:";
            // 
            // TxtVendorID
            // 
            this.TxtVendorID.BackColor = System.Drawing.Color.White;
            this.TxtVendorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVendorID.Enabled = false;
            this.TxtVendorID.Location = new System.Drawing.Point(41, 169);
            this.TxtVendorID.Name = "TxtVendorID";
            this.TxtVendorID.ReadOnly = true;
            this.TxtVendorID.Size = new System.Drawing.Size(67, 20);
            this.TxtVendorID.TabIndex = 622;
            // 
            // TxtVendorName
            // 
            this.TxtVendorName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVendorName.Location = new System.Drawing.Point(147, 169);
            this.TxtVendorName.Name = "TxtVendorName";
            this.TxtVendorName.Size = new System.Drawing.Size(260, 20);
            this.TxtVendorName.TabIndex = 621;
            // 
            // BtnSchVendor
            // 
            this.BtnSchVendor.Location = new System.Drawing.Point(107, 168);
            this.BtnSchVendor.Name = "BtnSchVendor";
            this.BtnSchVendor.Size = new System.Drawing.Size(28, 22);
            this.BtnSchVendor.TabIndex = 620;
            this.BtnSchVendor.Text = "....";
            this.BtnSchVendor.UseVisualStyleBackColor = true;
            // 
            // pmtPurchaseReturnSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(461, 298);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtVendorID);
            this.Controls.Add(this.TxtVendorName);
            this.Controls.Add(this.BtnSchVendor);
            this.Controls.Add(this.label18);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pmtPurchaseReturnSummary";
            this.Text = "Purchase Return Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtVendorID;
        private System.Windows.Forms.TextBox TxtVendorName;
        private System.Windows.Forms.Button BtnSchVendor;
    }
}