namespace Reports
{
    partial class RptSalesmanSummary
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
            this.txtSalesmanID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSchCustomer = new System.Windows.Forms.Button();
            this.txtSalesmanName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(177, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 277;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(109, 319);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 276;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(199, 193);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(110, 20);
            this.dtpTo.TabIndex = 273;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(196, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 275;
            this.label2.Text = "To  Date:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(43, 193);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 20);
            this.dtpFrom.TabIndex = 272;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 274;
            this.label3.Text = "From Date: ";
            // 
            // txtSalesmanID
            // 
            this.txtSalesmanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesmanID.Location = new System.Drawing.Point(43, 151);
            this.txtSalesmanID.MaxLength = 25;
            this.txtSalesmanID.Name = "txtSalesmanID";
            this.txtSalesmanID.Size = new System.Drawing.Size(76, 20);
            this.txtSalesmanID.TabIndex = 269;
            this.txtSalesmanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(40, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 270;
            this.label5.Text = "Salesmen:";
            // 
            // btnSchCustomer
            // 
            this.btnSchCustomer.Location = new System.Drawing.Point(118, 149);
            this.btnSchCustomer.Name = "btnSchCustomer";
            this.btnSchCustomer.Size = new System.Drawing.Size(30, 23);
            this.btnSchCustomer.TabIndex = 268;
            this.btnSchCustomer.Text = "...";
            this.btnSchCustomer.UseVisualStyleBackColor = true;
            // 
            // txtSalesmanName
            // 
            this.txtSalesmanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesmanName.Location = new System.Drawing.Point(177, 149);
            this.txtSalesmanName.Name = "txtSalesmanName";
            this.txtSalesmanName.ReadOnly = true;
            this.txtSalesmanName.Size = new System.Drawing.Size(229, 20);
            this.txtSalesmanName.TabIndex = 267;
            this.txtSalesmanName.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(48, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 36);
            this.label12.TabIndex = 278;
            this.label12.Text = "Salesman Summary";
            // 
            // RptSalesmanSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(436, 349);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalesmanID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSchCustomer);
            this.Controls.Add(this.txtSalesmanName);
            this.Name = "RptSalesmanSummary";
            this.Text = "Salesman Summary";
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
        private System.Windows.Forms.TextBox txtSalesmanID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSchCustomer;
        private System.Windows.Forms.TextBox txtSalesmanName;
        private System.Windows.Forms.Label label12;
    }
}