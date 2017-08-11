namespace Reports
{
    partial class RptPartyReceivablesAdvance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptPartyReceivablesAdvance));
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSchgroup = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.ChkIncludeClearInvoices = new System.Windows.Forms.CheckBox();
            this.CmbInvType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbPartyGroups = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(47, 129);
            this.txtCustomerID.MaxLength = 25;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerID.TabIndex = 210;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 211;
            this.label1.Text = "Customer:";
            // 
            // btnSchgroup
            // 
            this.btnSchgroup.Location = new System.Drawing.Point(122, 127);
            this.btnSchgroup.Name = "btnSchgroup";
            this.btnSchgroup.Size = new System.Drawing.Size(30, 23);
            this.btnSchgroup.TabIndex = 209;
            this.btnSchgroup.Text = "...";
            this.btnSchgroup.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(181, 127);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(229, 20);
            this.txtCustomerName.TabIndex = 208;
            this.txtCustomerName.TabStop = false;
            // 
            // ChkIncludeClearInvoices
            // 
            this.ChkIncludeClearInvoices.AutoSize = true;
            this.ChkIncludeClearInvoices.BackColor = System.Drawing.Color.Transparent;
            this.ChkIncludeClearInvoices.Location = new System.Drawing.Point(47, 265);
            this.ChkIncludeClearInvoices.Name = "ChkIncludeClearInvoices";
            this.ChkIncludeClearInvoices.Size = new System.Drawing.Size(143, 17);
            this.ChkIncludeClearInvoices.TabIndex = 226;
            this.ChkIncludeClearInvoices.Text = "Include Cleared Invoices";
            this.ChkIncludeClearInvoices.UseVisualStyleBackColor = false;
            this.ChkIncludeClearInvoices.Visible = false;
            // 
            // CmbInvType
            // 
            this.CmbInvType.FormattingEnabled = true;
            this.CmbInvType.Location = new System.Drawing.Point(277, 180);
            this.CmbInvType.Name = "CmbInvType";
            this.CmbInvType.Size = new System.Drawing.Size(107, 21);
            this.CmbInvType.TabIndex = 225;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(274, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 224;
            this.label11.Text = "Invoice Type:";
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(173, 182);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 223;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(170, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 222;
            this.label12.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(47, 181);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 221;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(44, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 220;
            this.label13.Text = "From Date:";
            // 
            // CmbPartyGroups
            // 
            this.CmbPartyGroups.FormattingEnabled = true;
            this.CmbPartyGroups.Location = new System.Drawing.Point(47, 225);
            this.CmbPartyGroups.Name = "CmbPartyGroups";
            this.CmbPartyGroups.Size = new System.Drawing.Size(107, 21);
            this.CmbPartyGroups.TabIndex = 234;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(44, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 233;
            this.label14.Text = "Party Group:";
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(173, 225);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(107, 21);
            this.CmbCity.TabIndex = 232;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(170, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 231;
            this.label2.Text = "City";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(160, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 236;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(92, 316);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 235;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // RptPartyReceivablesAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(455, 352);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.CmbPartyGroups);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CmbCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChkIncludeClearInvoices);
            this.Controls.Add(this.CmbInvType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSchgroup);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "RptPartyReceivablesAdvance";
            this.Text = "Party Receivables Advance Ledger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSchgroup;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.CheckBox ChkIncludeClearInvoices;
        private System.Windows.Forms.ComboBox CmbInvType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbPartyGroups;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
    }
}