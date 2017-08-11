namespace Reports
{
    partial class pmtOpeningStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pmtOpeningStock));
            this.label15 = new System.Windows.Forms.Label();
            this.TxtCompanyID = new System.Windows.Forms.TextBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.BtnSchCompany = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(33, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 618;
            this.label15.Text = "Company";
            // 
            // TxtCompanyID
            // 
            this.TxtCompanyID.BackColor = System.Drawing.Color.White;
            this.TxtCompanyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyID.Enabled = false;
            this.TxtCompanyID.Location = new System.Drawing.Point(36, 146);
            this.TxtCompanyID.Name = "TxtCompanyID";
            this.TxtCompanyID.ReadOnly = true;
            this.TxtCompanyID.Size = new System.Drawing.Size(89, 20);
            this.TxtCompanyID.TabIndex = 617;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompanyName.Location = new System.Drawing.Point(162, 146);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(228, 20);
            this.TxtCompanyName.TabIndex = 616;
            // 
            // BtnSchCompany
            // 
            this.BtnSchCompany.Location = new System.Drawing.Point(124, 145);
            this.BtnSchCompany.Name = "BtnSchCompany";
            this.BtnSchCompany.Size = new System.Drawing.Size(28, 22);
            this.BtnSchCompany.TabIndex = 615;
            this.BtnSchCompany.Text = "....";
            this.BtnSchCompany.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(151, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 26);
            this.btnClose.TabIndex = 637;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(80, 254);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(65, 25);
            this.btnPreview.TabIndex = 636;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(39, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(240, 37);
            this.label18.TabIndex = 638;
            this.label18.Text = "Opening Stock";
            // 
            // pmtOpeningStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(444, 291);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtCompanyID);
            this.Controls.Add(this.TxtCompanyName);
            this.Controls.Add(this.BtnSchCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pmtOpeningStock";
            this.Text = "Opening Stock";
            this.Load += new System.EventHandler(this.pmtOpeningStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtCompanyID;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Button BtnSchCompany;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label18;
    }
}