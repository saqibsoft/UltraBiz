namespace Reports
{
    partial class RptPrintInvoiceBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptPrintInvoiceBatch));
            this.txtToSaleID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnTo = new System.Windows.Forms.Button();
            this.txtFromSaleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrom = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTownID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSchTown = new System.Windows.Forms.Button();
            this.txtTownName = new System.Windows.Forms.TextBox();
            this.txtSectorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSchSector = new System.Windows.Forms.Button();
            this.txtSectorName = new System.Windows.Forms.TextBox();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.ChkIncludeAlreadyPrintedInvoices = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtToSaleID
            // 
            this.txtToSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToSaleID.Location = new System.Drawing.Point(174, 114);
            this.txtToSaleID.MaxLength = 25;
            this.txtToSaleID.Name = "txtToSaleID";
            this.txtToSaleID.Size = new System.Drawing.Size(76, 20);
            this.txtToSaleID.TabIndex = 205;
            this.txtToSaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(171, 99);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 13);
            this.lbl.TabIndex = 206;
            this.lbl.Text = "To (SaleID)";
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(249, 112);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(30, 23);
            this.btnTo.TabIndex = 204;
            this.btnTo.Text = "...";
            this.btnTo.UseVisualStyleBackColor = true;
            // 
            // txtFromSaleID
            // 
            this.txtFromSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFromSaleID.Location = new System.Drawing.Point(39, 112);
            this.txtFromSaleID.MaxLength = 25;
            this.txtFromSaleID.Name = "txtFromSaleID";
            this.txtFromSaleID.Size = new System.Drawing.Size(76, 20);
            this.txtFromSaleID.TabIndex = 208;
            this.txtFromSaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 209;
            this.label1.Text = "From (SaleID)";
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(114, 110);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(30, 23);
            this.btnFrom.TabIndex = 207;
            this.btnFrom.Text = "...";
            this.btnFrom.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(170, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 219;
            this.label9.Text = "Sector Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(170, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 218;
            this.label8.Text = "Town Name:";
            // 
            // txtTownID
            // 
            this.txtTownID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownID.Location = new System.Drawing.Point(39, 205);
            this.txtTownID.MaxLength = 25;
            this.txtTownID.Name = "txtTownID";
            this.txtTownID.Size = new System.Drawing.Size(76, 20);
            this.txtTownID.TabIndex = 216;
            this.txtTownID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(36, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 217;
            this.label3.Text = "Town ID:";
            // 
            // btnSchTown
            // 
            this.btnSchTown.Location = new System.Drawing.Point(114, 203);
            this.btnSchTown.Name = "btnSchTown";
            this.btnSchTown.Size = new System.Drawing.Size(30, 23);
            this.btnSchTown.TabIndex = 215;
            this.btnSchTown.Text = "...";
            this.btnSchTown.UseVisualStyleBackColor = true;
            // 
            // txtTownName
            // 
            this.txtTownName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownName.Location = new System.Drawing.Point(173, 203);
            this.txtTownName.Name = "txtTownName";
            this.txtTownName.ReadOnly = true;
            this.txtTownName.Size = new System.Drawing.Size(246, 20);
            this.txtTownName.TabIndex = 214;
            this.txtTownName.TabStop = false;
            // 
            // txtSectorID
            // 
            this.txtSectorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectorID.Location = new System.Drawing.Point(39, 160);
            this.txtSectorID.MaxLength = 25;
            this.txtSectorID.Name = "txtSectorID";
            this.txtSectorID.Size = new System.Drawing.Size(76, 20);
            this.txtSectorID.TabIndex = 212;
            this.txtSectorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 213;
            this.label2.Text = "Sector ID:";
            // 
            // btnSchSector
            // 
            this.btnSchSector.Location = new System.Drawing.Point(114, 159);
            this.btnSchSector.Name = "btnSchSector";
            this.btnSchSector.Size = new System.Drawing.Size(30, 23);
            this.btnSchSector.TabIndex = 211;
            this.btnSchSector.Text = "...";
            this.btnSchSector.UseVisualStyleBackColor = true;
            // 
            // txtSectorName
            // 
            this.txtSectorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectorName.Location = new System.Drawing.Point(173, 159);
            this.txtSectorName.Name = "txtSectorName";
            this.txtSectorName.ReadOnly = true;
            this.txtSectorName.Size = new System.Drawing.Size(246, 20);
            this.txtSectorName.TabIndex = 210;
            this.txtSectorName.TabStop = false;
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(165, 259);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 223;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(162, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 222;
            this.label12.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(39, 258);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 221;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(36, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 220;
            this.label13.Text = "From Date:";
            // 
            // ChkIncludeAlreadyPrintedInvoices
            // 
            this.ChkIncludeAlreadyPrintedInvoices.AutoSize = true;
            this.ChkIncludeAlreadyPrintedInvoices.BackColor = System.Drawing.Color.Transparent;
            this.ChkIncludeAlreadyPrintedInvoices.Location = new System.Drawing.Point(39, 299);
            this.ChkIncludeAlreadyPrintedInvoices.Name = "ChkIncludeAlreadyPrintedInvoices";
            this.ChkIncludeAlreadyPrintedInvoices.Size = new System.Drawing.Size(178, 17);
            this.ChkIncludeAlreadyPrintedInvoices.TabIndex = 224;
            this.ChkIncludeAlreadyPrintedInvoices.Text = "Include Already Printed Invoices";
            this.ChkIncludeAlreadyPrintedInvoices.UseVisualStyleBackColor = false;
            this.ChkIncludeAlreadyPrintedInvoices.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 226;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(112, 334);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 225;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(285, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(134, 23);
            this.progressBar1.TabIndex = 227;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(282, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 228;
            this.label4.Text = "Send Printing Request:";
            // 
            // RptPrintInvoiceBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.ChkIncludeAlreadyPrintedInvoices);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTownID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSchTown);
            this.Controls.Add(this.txtTownName);
            this.Controls.Add(this.txtSectorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSchSector);
            this.Controls.Add(this.txtSectorName);
            this.Controls.Add(this.txtFromSaleID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFrom);
            this.Controls.Add(this.txtToSaleID);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnTo);
            this.Name = "RptPrintInvoiceBatch";
            this.Text = "Multi Invoices Printing";
            this.Load += new System.EventHandler(this.RptPrintInvoiceBatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToSaleID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.TextBox txtFromSaleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTownID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSchTown;
        private System.Windows.Forms.TextBox txtTownName;
        private System.Windows.Forms.TextBox txtSectorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSchSector;
        private System.Windows.Forms.TextBox txtSectorName;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ChkIncludeAlreadyPrintedInvoices;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
    }
}