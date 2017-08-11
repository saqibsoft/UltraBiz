namespace Reports
{
    partial class pmtWastageInvoiceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pmtWastageInvoiceReport));
            this.optAllDates = new System.Windows.Forms.RadioButton();
            this.optRange = new System.Windows.Forms.RadioButton();
            this.dt_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSchProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optAllDates
            // 
            this.optAllDates.AutoSize = true;
            this.optAllDates.Location = new System.Drawing.Point(49, 112);
            this.optAllDates.Name = "optAllDates";
            this.optAllDates.Size = new System.Drawing.Size(67, 17);
            this.optAllDates.TabIndex = 1;
            this.optAllDates.TabStop = true;
            this.optAllDates.Text = "All Dates";
            this.optAllDates.UseVisualStyleBackColor = true;
            // 
            // optRange
            // 
            this.optRange.AutoSize = true;
            this.optRange.Location = new System.Drawing.Point(49, 197);
            this.optRange.Name = "optRange";
            this.optRange.Size = new System.Drawing.Size(57, 17);
            this.optRange.TabIndex = 89;
            this.optRange.TabStop = true;
            this.optRange.Text = "Range";
            this.optRange.UseVisualStyleBackColor = true;
            // 
            // dt_ToDate
            // 
            this.dt_ToDate.CustomFormat = "dd/MMM/yyyy";
            this.dt_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ToDate.Location = new System.Drawing.Point(322, 195);
            this.dt_ToDate.Name = "dt_ToDate";
            this.dt_ToDate.Size = new System.Drawing.Size(110, 20);
            this.dt_ToDate.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "To Date";
            // 
            // dt_From
            // 
            this.dt_From.CustomFormat = "dd/MMM/yyyy";
            this.dt_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_From.Location = new System.Drawing.Point(166, 195);
            this.dt_From.Name = "dt_From";
            this.dt_From.Size = new System.Drawing.Size(110, 20);
            this.dt_From.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "From Date";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 153);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 94;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "For Date";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MMM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 95;
            // 
            // txtProductID
            // 
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductID.Location = new System.Drawing.Point(50, 239);
            this.txtProductID.MaxLength = 25;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(76, 20);
            this.txtProductID.TabIndex = 243;
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(47, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 244;
            this.label4.Text = "ProductID:";
            // 
            // btnSchProduct
            // 
            this.btnSchProduct.Location = new System.Drawing.Point(125, 237);
            this.btnSchProduct.Name = "btnSchProduct";
            this.btnSchProduct.Size = new System.Drawing.Size(30, 23);
            this.btnSchProduct.TabIndex = 242;
            this.btnSchProduct.Text = "...";
            this.btnSchProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(184, 237);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(229, 20);
            this.txtProductName.TabIndex = 241;
            this.txtProductName.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(166, 315);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 255;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(98, 315);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 254;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(181, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 256;
            this.label3.Text = "ProductName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(34, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 36);
            this.label12.TabIndex = 257;
            this.label12.Text = "Wastage Invoice Report";
            // 
            // pmtWastageInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 345);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSchProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.optRange);
            this.Controls.Add(this.dt_ToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optAllDates);
            this.Name = "pmtWastageInvoiceReport";
            this.Text = "Wastage Invoice Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optAllDates;
        private System.Windows.Forms.RadioButton optRange;
        private System.Windows.Forms.DateTimePicker dt_ToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSchProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
    }
}