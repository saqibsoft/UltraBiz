namespace Reports
{
    partial class RptDailySaleSheet
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSalesmanID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSchSalesman = new System.Windows.Forms.Button();
            this.txtSalesmanName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 281;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(82, 329);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 280;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(179, 213);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 279;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(176, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 278;
            this.label12.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(53, 212);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 277;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(50, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 276;
            this.label13.Text = "From Date:";
            // 
            // txtSalesmanID
            // 
            this.txtSalesmanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesmanID.Location = new System.Drawing.Point(53, 164);
            this.txtSalesmanID.MaxLength = 25;
            this.txtSalesmanID.Name = "txtSalesmanID";
            this.txtSalesmanID.Size = new System.Drawing.Size(76, 20);
            this.txtSalesmanID.TabIndex = 274;
            this.txtSalesmanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(50, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 275;
            this.label5.Text = "Salesman:";
            // 
            // btnSchSalesman
            // 
            this.btnSchSalesman.Location = new System.Drawing.Point(128, 162);
            this.btnSchSalesman.Name = "btnSchSalesman";
            this.btnSchSalesman.Size = new System.Drawing.Size(30, 23);
            this.btnSchSalesman.TabIndex = 273;
            this.btnSchSalesman.Text = "...";
            this.btnSchSalesman.UseVisualStyleBackColor = true;
            // 
            // txtSalesmanName
            // 
            this.txtSalesmanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesmanName.Location = new System.Drawing.Point(187, 162);
            this.txtSalesmanName.Name = "txtSalesmanName";
            this.txtSalesmanName.ReadOnly = true;
            this.txtSalesmanName.Size = new System.Drawing.Size(229, 20);
            this.txtSalesmanName.TabIndex = 272;
            this.txtSalesmanName.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(24, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(482, 36);
            this.label15.TabIndex = 282;
            this.label15.Text = "Daily Sales Statement (SM Wise)";
            // 
            // RptDailySaleSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(513, 364);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSalesmanID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSchSalesman);
            this.Controls.Add(this.txtSalesmanName);
            this.Name = "RptDailySaleSheet";
            this.Text = "Daily Sale Statement(Salesman Wise)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSalesmanID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSchSalesman;
        private System.Windows.Forms.TextBox txtSalesmanName;
        private System.Windows.Forms.Label label15;
    }
}