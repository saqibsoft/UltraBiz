namespace Reports
{
    partial class RptSalesmanRecoveryRegister
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtTownid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSchSector = new System.Windows.Forms.Button();
            this.txtTownName = new System.Windows.Forms.TextBox();
            this.listTown = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkAll = new System.Windows.Forms.CheckBox();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.ChkWithPrevious = new System.Windows.Forms.CheckBox();
            this.ChkShowTogether = new System.Windows.Forms.CheckBox();
            this.ChkUrdu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(143, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 174;
            this.label8.Text = "Town Name:";
            // 
            // txtTownid
            // 
            this.txtTownid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownid.Location = new System.Drawing.Point(41, 125);
            this.txtTownid.MaxLength = 25;
            this.txtTownid.Name = "txtTownid";
            this.txtTownid.Size = new System.Drawing.Size(76, 20);
            this.txtTownid.TabIndex = 172;
            this.txtTownid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(38, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 173;
            this.label3.Text = "Towns:";
            // 
            // btnSchSector
            // 
            this.btnSchSector.Location = new System.Drawing.Point(116, 123);
            this.btnSchSector.Name = "btnSchSector";
            this.btnSchSector.Size = new System.Drawing.Size(30, 23);
            this.btnSchSector.TabIndex = 171;
            this.btnSchSector.Text = "...";
            this.btnSchSector.UseVisualStyleBackColor = true;
            // 
            // txtTownName
            // 
            this.txtTownName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownName.Location = new System.Drawing.Point(146, 124);
            this.txtTownName.Name = "txtTownName";
            this.txtTownName.ReadOnly = true;
            this.txtTownName.Size = new System.Drawing.Size(229, 20);
            this.txtTownName.TabIndex = 170;
            this.txtTownName.TabStop = false;
            // 
            // listTown
            // 
            this.listTown.FormattingEnabled = true;
            this.listTown.Location = new System.Drawing.Point(41, 170);
            this.listTown.Name = "listTown";
            this.listTown.Size = new System.Drawing.Size(378, 147);
            this.listTown.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 176;
            this.label1.Text = "Sector:";
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.BackColor = System.Drawing.Color.Transparent;
            this.ChkAll.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.ChkAll.Location = new System.Drawing.Point(340, 153);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Size = new System.Drawing.Size(78, 17);
            this.ChkAll.TabIndex = 268;
            this.ChkAll.Text = "Select ALL";
            this.ChkAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkAll.UseVisualStyleBackColor = false;
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(167, 337);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 272;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(164, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 271;
            this.label12.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(41, 336);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 270;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(38, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 269;
            this.label13.Text = "From Date:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(146, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 26);
            this.btnClose.TabIndex = 274;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(78, 386);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 26);
            this.btnPreview.TabIndex = 273;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // ChkWithPrevious
            // 
            this.ChkWithPrevious.AutoSize = true;
            this.ChkWithPrevious.BackColor = System.Drawing.Color.Transparent;
            this.ChkWithPrevious.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChkWithPrevious.Location = new System.Drawing.Point(316, 340);
            this.ChkWithPrevious.Name = "ChkWithPrevious";
            this.ChkWithPrevious.Size = new System.Drawing.Size(92, 17);
            this.ChkWithPrevious.TabIndex = 275;
            this.ChkWithPrevious.Text = "With Previous";
            this.ChkWithPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkWithPrevious.UseVisualStyleBackColor = false;
            // 
            // ChkShowTogether
            // 
            this.ChkShowTogether.AutoSize = true;
            this.ChkShowTogether.BackColor = System.Drawing.Color.Transparent;
            this.ChkShowTogether.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChkShowTogether.Location = new System.Drawing.Point(316, 363);
            this.ChkShowTogether.Name = "ChkShowTogether";
            this.ChkShowTogether.Size = new System.Drawing.Size(99, 17);
            this.ChkShowTogether.TabIndex = 276;
            this.ChkShowTogether.Text = "Show Together";
            this.ChkShowTogether.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkShowTogether.UseVisualStyleBackColor = false;
            // 
            // ChkUrdu
            // 
            this.ChkUrdu.AutoSize = true;
            this.ChkUrdu.BackColor = System.Drawing.Color.Transparent;
            this.ChkUrdu.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChkUrdu.Location = new System.Drawing.Point(316, 386);
            this.ChkUrdu.Name = "ChkUrdu";
            this.ChkUrdu.Size = new System.Drawing.Size(73, 17);
            this.ChkUrdu.TabIndex = 277;
            this.ChkUrdu.Text = "Print Urdu";
            this.ChkUrdu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkUrdu.UseVisualStyleBackColor = false;
            // 
            // RptSalesmanRecoveryRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(466, 420);
            this.Controls.Add(this.ChkUrdu);
            this.Controls.Add(this.ChkShowTogether);
            this.Controls.Add(this.ChkWithPrevious);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ChkAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTownid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSchSector);
            this.Controls.Add(this.txtTownName);
            this.Name = "RptSalesmanRecoveryRegister";
            this.Text = "Salesman Recovery Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTownid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSchSector;
        private System.Windows.Forms.TextBox txtTownName;
        private System.Windows.Forms.ListBox listTown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkAll;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox ChkWithPrevious;
        private System.Windows.Forms.CheckBox ChkShowTogether;
        private System.Windows.Forms.CheckBox ChkUrdu;
    }
}