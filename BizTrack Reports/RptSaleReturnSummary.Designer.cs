namespace Reports
{
    partial class RptSaleReturnSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptSaleReturnSummary));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTownID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSchTown = new System.Windows.Forms.Button();
            this.txtTownName = new System.Windows.Forms.TextBox();
            this.txtSectorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSchSector = new System.Windows.Forms.Button();
            this.txtSectorName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSchCustomer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(199, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 216;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(131, 337);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 215;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(163, 278);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 214;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(160, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 213;
            this.label9.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(26, 278);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 212;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(23, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 211;
            this.label10.Text = "From Date:";
            // 
            // txtTownID
            // 
            this.txtTownID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownID.Location = new System.Drawing.Point(29, 233);
            this.txtTownID.MaxLength = 25;
            this.txtTownID.Name = "txtTownID";
            this.txtTownID.Size = new System.Drawing.Size(76, 20);
            this.txtTownID.TabIndex = 209;
            this.txtTownID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 210;
            this.label3.Text = "Town:";
            // 
            // btnSchTown
            // 
            this.btnSchTown.Location = new System.Drawing.Point(104, 231);
            this.btnSchTown.Name = "btnSchTown";
            this.btnSchTown.Size = new System.Drawing.Size(30, 23);
            this.btnSchTown.TabIndex = 208;
            this.btnSchTown.Text = "...";
            this.btnSchTown.UseVisualStyleBackColor = true;
            // 
            // txtTownName
            // 
            this.txtTownName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownName.Location = new System.Drawing.Point(163, 231);
            this.txtTownName.Name = "txtTownName";
            this.txtTownName.ReadOnly = true;
            this.txtTownName.Size = new System.Drawing.Size(229, 20);
            this.txtTownName.TabIndex = 207;
            this.txtTownName.TabStop = false;
            // 
            // txtSectorID
            // 
            this.txtSectorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectorID.Location = new System.Drawing.Point(29, 178);
            this.txtSectorID.MaxLength = 25;
            this.txtSectorID.Name = "txtSectorID";
            this.txtSectorID.Size = new System.Drawing.Size(76, 20);
            this.txtSectorID.TabIndex = 205;
            this.txtSectorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 206;
            this.label2.Text = "Sector:";
            // 
            // btnSchSector
            // 
            this.btnSchSector.Location = new System.Drawing.Point(104, 176);
            this.btnSchSector.Name = "btnSchSector";
            this.btnSchSector.Size = new System.Drawing.Size(30, 23);
            this.btnSchSector.TabIndex = 204;
            this.btnSchSector.Text = "...";
            this.btnSchSector.UseVisualStyleBackColor = true;
            // 
            // txtSectorName
            // 
            this.txtSectorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectorName.Location = new System.Drawing.Point(163, 176);
            this.txtSectorName.Name = "txtSectorName";
            this.txtSectorName.ReadOnly = true;
            this.txtSectorName.Size = new System.Drawing.Size(229, 20);
            this.txtSectorName.TabIndex = 203;
            this.txtSectorName.TabStop = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(29, 124);
            this.txtCustomerID.MaxLength = 25;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerID.TabIndex = 201;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 202;
            this.label1.Text = "Customer:";
            // 
            // btnSchCustomer
            // 
            this.btnSchCustomer.Location = new System.Drawing.Point(104, 122);
            this.btnSchCustomer.Name = "btnSchCustomer";
            this.btnSchCustomer.Size = new System.Drawing.Size(30, 23);
            this.btnSchCustomer.TabIndex = 200;
            this.btnSchCustomer.Text = "...";
            this.btnSchCustomer.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(163, 122);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(229, 20);
            this.txtCustomerName.TabIndex = 199;
            this.txtCustomerName.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 36);
            this.label12.TabIndex = 217;
            this.label12.Text = "Sales Returns Summary";
            // 
            // RptSaleReturnSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(463, 367);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTownID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSchTown);
            this.Controls.Add(this.txtTownName);
            this.Controls.Add(this.txtSectorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSchSector);
            this.Controls.Add(this.txtSectorName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSchCustomer);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "RptSaleReturnSummary";
            this.Text = "Sale Return Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTownID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSchTown;
        private System.Windows.Forms.TextBox txtTownName;
        private System.Windows.Forms.TextBox txtSectorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSchSector;
        private System.Windows.Forms.TextBox txtSectorName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSchCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label12;
    }
}