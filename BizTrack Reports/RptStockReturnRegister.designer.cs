namespace Reports
{
    partial class RptStockReturnRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptStockReturnRegister));
            this.label18 = new System.Windows.Forms.Label();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtSMID = new System.Windows.Forms.TextBox();
            this.TxtSMName = new System.Windows.Forms.TextBox();
            this.BtnSchSM = new System.Windows.Forms.Button();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(29, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(348, 37);
            this.label18.TabIndex = 653;
            this.label18.Text = "Stock Return Register";
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(181, 253);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(65, 26);
            this.CmdClose.TabIndex = 652;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(110, 254);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(65, 25);
            this.CmdSave.TabIndex = 651;
            this.CmdSave.Text = "Preview";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(49, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 646;
            this.label15.Text = "SalesmenID";
            // 
            // TxtSMID
            // 
            this.TxtSMID.BackColor = System.Drawing.Color.White;
            this.TxtSMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSMID.Enabled = false;
            this.TxtSMID.Location = new System.Drawing.Point(54, 120);
            this.TxtSMID.Name = "TxtSMID";
            this.TxtSMID.ReadOnly = true;
            this.TxtSMID.Size = new System.Drawing.Size(55, 20);
            this.TxtSMID.TabIndex = 645;
            // 
            // TxtSMName
            // 
            this.TxtSMName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSMName.Location = new System.Drawing.Point(141, 120);
            this.TxtSMName.Name = "TxtSMName";
            this.TxtSMName.Size = new System.Drawing.Size(201, 20);
            this.TxtSMName.TabIndex = 644;
            // 
            // BtnSchSM
            // 
            this.BtnSchSM.Location = new System.Drawing.Point(110, 118);
            this.BtnSchSM.Name = "BtnSchSM";
            this.BtnSchSM.Size = new System.Drawing.Size(28, 22);
            this.BtnSchSM.TabIndex = 643;
            this.BtnSchSM.Text = "....";
            this.BtnSchSM.UseVisualStyleBackColor = true;
            // 
            // DtpToDate
            // 
            this.DtpToDate.CustomFormat = "dd/MMM/yyyy";
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpToDate.Location = new System.Drawing.Point(183, 170);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(98, 20);
            this.DtpToDate.TabIndex = 657;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(180, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 656;
            this.label12.Text = "To Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(57, 169);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(106, 20);
            this.dtpFromDate.TabIndex = 655;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(54, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 654;
            this.label13.Text = "From Date:";
            // 
            // RptStockReturnRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(414, 285);
            this.Controls.Add(this.DtpToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtSMID);
            this.Controls.Add(this.TxtSMName);
            this.Controls.Add(this.BtnSchSM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RptStockReturnRegister";
            this.Text = "Stock Return Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtSMID;
        private System.Windows.Forms.TextBox TxtSMName;
        private System.Windows.Forms.Button BtnSchSM;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
    }
}