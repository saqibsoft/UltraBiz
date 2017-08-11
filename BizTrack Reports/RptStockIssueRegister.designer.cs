namespace Reports
{
    partial class RptStockIssueRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptStockIssueRegister));
            this.label15 = new System.Windows.Forms.Label();
            this.TxtSalesmanID = new System.Windows.Forms.TextBox();
            this.TxtSalesmanName = new System.Windows.Forms.TextBox();
            this.BtnSchSalesman = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(31, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 626;
            this.label15.Text = "SalesmenID";
            // 
            // TxtSalesmanID
            // 
            this.TxtSalesmanID.BackColor = System.Drawing.Color.White;
            this.TxtSalesmanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSalesmanID.Enabled = false;
            this.TxtSalesmanID.Location = new System.Drawing.Point(36, 124);
            this.TxtSalesmanID.Name = "TxtSalesmanID";
            this.TxtSalesmanID.ReadOnly = true;
            this.TxtSalesmanID.Size = new System.Drawing.Size(55, 20);
            this.TxtSalesmanID.TabIndex = 625;
            // 
            // TxtSalesmanName
            // 
            this.TxtSalesmanName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSalesmanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSalesmanName.Location = new System.Drawing.Point(127, 124);
            this.TxtSalesmanName.Name = "TxtSalesmanName";
            this.TxtSalesmanName.Size = new System.Drawing.Size(201, 20);
            this.TxtSalesmanName.TabIndex = 624;
            // 
            // BtnSchSalesman
            // 
            this.BtnSchSalesman.Location = new System.Drawing.Point(90, 123);
            this.BtnSchSalesman.Name = "BtnSchSalesman";
            this.BtnSchSalesman.Size = new System.Drawing.Size(28, 22);
            this.BtnSchSalesman.TabIndex = 623;
            this.BtnSchSalesman.Text = "....";
            this.BtnSchSalesman.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(12, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(327, 37);
            this.label18.TabIndex = 642;
            this.label18.Text = "Stock Issue Register";
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(160, 164);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 661;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(157, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 660;
            this.label12.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(34, 163);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 659;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(31, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 658;
            this.label13.Text = "From Date:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(146, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 26);
            this.btnClose.TabIndex = 663;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(78, 243);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 26);
            this.btnPreview.TabIndex = 662;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // RptStockIssueRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(356, 281);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtSalesmanID);
            this.Controls.Add(this.TxtSalesmanName);
            this.Controls.Add(this.BtnSchSalesman);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptStockIssueRegister";
            this.Text = "Stock Issue Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtSalesmanID;
        private System.Windows.Forms.TextBox TxtSalesmanName;
        private System.Windows.Forms.Button BtnSchSalesman;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
    }
}