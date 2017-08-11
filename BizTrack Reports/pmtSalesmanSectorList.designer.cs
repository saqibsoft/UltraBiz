namespace Reports
{
    partial class pmtSalesmanSectorList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pmtSalesmanSectorList));
            this.label15 = new System.Windows.Forms.Label();
            this.TxtSalesmanID = new System.Windows.Forms.TextBox();
            this.TxtSalesmanName = new System.Windows.Forms.TextBox();
            this.BtnSchSalesman = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.ChkIncludeParties = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(25, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 650;
            this.label15.Text = "SalesmenID";
            // 
            // TxtSalesmanID
            // 
            this.TxtSalesmanID.BackColor = System.Drawing.Color.White;
            this.TxtSalesmanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSalesmanID.Enabled = false;
            this.TxtSalesmanID.Location = new System.Drawing.Point(28, 125);
            this.TxtSalesmanID.Name = "TxtSalesmanID";
            this.TxtSalesmanID.ReadOnly = true;
            this.TxtSalesmanID.Size = new System.Drawing.Size(83, 20);
            this.TxtSalesmanID.TabIndex = 649;
            // 
            // TxtSalesmanName
            // 
            this.TxtSalesmanName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSalesmanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSalesmanName.Location = new System.Drawing.Point(146, 125);
            this.TxtSalesmanName.Name = "TxtSalesmanName";
            this.TxtSalesmanName.Size = new System.Drawing.Size(233, 20);
            this.TxtSalesmanName.TabIndex = 648;
            // 
            // BtnSchSalesman
            // 
            this.BtnSchSalesman.Location = new System.Drawing.Point(110, 124);
            this.BtnSchSalesman.Name = "BtnSchSalesman";
            this.BtnSchSalesman.Size = new System.Drawing.Size(28, 22);
            this.BtnSchSalesman.TabIndex = 647;
            this.BtnSchSalesman.Text = "....";
            this.BtnSchSalesman.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 26);
            this.btnClose.TabIndex = 659;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(126, 282);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(65, 25);
            this.btnPreview.TabIndex = 658;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(21, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(355, 37);
            this.label18.TabIndex = 660;
            this.label18.Text = "Salesmen Sectors List";
            // 
            // ChkIncludeParties
            // 
            this.ChkIncludeParties.AutoSize = true;
            this.ChkIncludeParties.BackColor = System.Drawing.Color.Transparent;
            this.ChkIncludeParties.Location = new System.Drawing.Point(30, 162);
            this.ChkIncludeParties.Name = "ChkIncludeParties";
            this.ChkIncludeParties.Size = new System.Drawing.Size(177, 17);
            this.ChkIncludeParties.TabIndex = 661;
            this.ChkIncludeParties.Text = "Included Parites For the Sectors";
            this.ChkIncludeParties.UseVisualStyleBackColor = false;
            // 
            // pmtSalesmanSectorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(405, 319);
            this.Controls.Add(this.ChkIncludeParties);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtSalesmanID);
            this.Controls.Add(this.TxtSalesmanName);
            this.Controls.Add(this.BtnSchSalesman);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pmtSalesmanSectorList";
            this.Text = "Salesmen Sector List";
            this.Load += new System.EventHandler(this.Sectors_List__Salesmen_Wise__Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtSalesmanID;
        private System.Windows.Forms.TextBox TxtSalesmanName;
        private System.Windows.Forms.Button BtnSchSalesman;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox ChkIncludeParties;
    }
}