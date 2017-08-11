namespace Reports
{
    partial class RptProductWiseProfits
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
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenCompany = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(185, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 266;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(117, 343);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 265;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(207, 217);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(110, 20);
            this.dtpTo.TabIndex = 262;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(204, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 264;
            this.label2.Text = "To  Date:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(51, 217);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 20);
            this.dtpFrom.TabIndex = 261;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(48, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 263;
            this.label3.Text = "From Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(182, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 260;
            this.label1.Text = "Company Name:";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyID.Location = new System.Drawing.Point(51, 175);
            this.txtCompanyID.MaxLength = 25;
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(76, 20);
            this.txtCompanyID.TabIndex = 258;
            this.txtCompanyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(48, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 259;
            this.label5.Text = "Company ID:";
            // 
            // btnOpenCompany
            // 
            this.btnOpenCompany.Location = new System.Drawing.Point(126, 173);
            this.btnOpenCompany.Name = "btnOpenCompany";
            this.btnOpenCompany.Size = new System.Drawing.Size(30, 23);
            this.btnOpenCompany.TabIndex = 257;
            this.btnOpenCompany.Text = "...";
            this.btnOpenCompany.UseVisualStyleBackColor = true;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Location = new System.Drawing.Point(185, 173);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(229, 20);
            this.txtCompanyName.TabIndex = 256;
            this.txtCompanyName.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(307, 36);
            this.label12.TabIndex = 267;
            this.label12.Text = "Product Wise Profits";
            // 
            // RptProductWiseProfits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(458, 372);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOpenCompany);
            this.Controls.Add(this.txtCompanyName);
            this.Name = "RptProductWiseProfits";
            this.Text = "Product Wise Profits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpenCompany;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label12;
    }
}