namespace Reports
{
    partial class RptPartyBalnances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptPartyBalnances));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtpUpTill = new System.Windows.Forms.DateTimePicker();
            this.optRange = new System.Windows.Forms.RadioButton();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbPartyGroups = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbPaties = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTownID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSchTown = new System.Windows.Forms.Button();
            this.txtTownName = new System.Windows.Forms.TextBox();
            this.txtSectorID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSchSector = new System.Windows.Forms.Button();
            this.txtSectorName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(28, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 101;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "UpTill Date";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // dtpUpTill
            // 
            this.dtpUpTill.CustomFormat = "dd/MMM/yyyy";
            this.dtpUpTill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpTill.Location = new System.Drawing.Point(145, 106);
            this.dtpUpTill.Name = "dtpUpTill";
            this.dtpUpTill.Size = new System.Drawing.Size(110, 20);
            this.dtpUpTill.TabIndex = 102;
            // 
            // optRange
            // 
            this.optRange.AutoSize = true;
            this.optRange.BackColor = System.Drawing.Color.Transparent;
            this.optRange.Location = new System.Drawing.Point(28, 152);
            this.optRange.Name = "optRange";
            this.optRange.Size = new System.Drawing.Size(98, 17);
            this.optRange.TabIndex = 96;
            this.optRange.TabStop = true;
            this.optRange.Text = "Between Dates";
            this.optRange.UseVisualStyleBackColor = false;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MMM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(301, 150);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(110, 20);
            this.dtpTo.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "To ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(145, 150);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 20);
            this.dtpFrom.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "From ";
            // 
            // CmbPartyGroups
            // 
            this.CmbPartyGroups.FormattingEnabled = true;
            this.CmbPartyGroups.Location = new System.Drawing.Point(28, 235);
            this.CmbPartyGroups.Name = "CmbPartyGroups";
            this.CmbPartyGroups.Size = new System.Drawing.Size(182, 21);
            this.CmbPartyGroups.TabIndex = 238;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(25, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 237;
            this.label14.Text = "Party Group:";
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(216, 235);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(195, 21);
            this.CmbCity.TabIndex = 236;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(213, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 235;
            this.label3.Text = "City";
            // 
            // CmbPaties
            // 
            this.CmbPaties.FormattingEnabled = true;
            this.CmbPaties.Location = new System.Drawing.Point(28, 196);
            this.CmbPaties.Name = "CmbPaties";
            this.CmbPaties.Size = new System.Drawing.Size(189, 21);
            this.CmbPaties.TabIndex = 240;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(25, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 239;
            this.label11.Text = "Party Type:";
            // 
            // txtTownID
            // 
            this.txtTownID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownID.Location = new System.Drawing.Point(24, 273);
            this.txtTownID.MaxLength = 25;
            this.txtTownID.Name = "txtTownID";
            this.txtTownID.Size = new System.Drawing.Size(76, 20);
            this.txtTownID.TabIndex = 247;
            this.txtTownID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 248;
            this.label4.Text = "Town:";
            // 
            // btnSchTown
            // 
            this.btnSchTown.Location = new System.Drawing.Point(99, 271);
            this.btnSchTown.Name = "btnSchTown";
            this.btnSchTown.Size = new System.Drawing.Size(30, 23);
            this.btnSchTown.TabIndex = 246;
            this.btnSchTown.Text = "...";
            this.btnSchTown.UseVisualStyleBackColor = true;
            // 
            // txtTownName
            // 
            this.txtTownName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTownName.Location = new System.Drawing.Point(158, 271);
            this.txtTownName.Name = "txtTownName";
            this.txtTownName.ReadOnly = true;
            this.txtTownName.Size = new System.Drawing.Size(229, 20);
            this.txtTownName.TabIndex = 245;
            this.txtTownName.TabStop = false;
            // 
            // txtSectorID
            // 
            this.txtSectorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectorID.Location = new System.Drawing.Point(24, 315);
            this.txtSectorID.MaxLength = 25;
            this.txtSectorID.Name = "txtSectorID";
            this.txtSectorID.Size = new System.Drawing.Size(76, 20);
            this.txtSectorID.TabIndex = 243;
            this.txtSectorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(21, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 244;
            this.label5.Text = "Sector:";
            // 
            // btnSchSector
            // 
            this.btnSchSector.Location = new System.Drawing.Point(99, 313);
            this.btnSchSector.Name = "btnSchSector";
            this.btnSchSector.Size = new System.Drawing.Size(30, 23);
            this.btnSchSector.TabIndex = 242;
            this.btnSchSector.Text = "...";
            this.btnSchSector.UseVisualStyleBackColor = true;
            // 
            // txtSectorName
            // 
            this.txtSectorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSectorName.Location = new System.Drawing.Point(158, 313);
            this.txtSectorName.Name = "txtSectorName";
            this.txtSectorName.ReadOnly = true;
            this.txtSectorName.Size = new System.Drawing.Size(229, 20);
            this.txtSectorName.TabIndex = 241;
            this.txtSectorName.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(185, 354);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 250;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(117, 354);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 249;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(55, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 36);
            this.label12.TabIndex = 251;
            this.label12.Text = "Party Balances";
            // 
            // RptPartyBalnances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(424, 385);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtTownID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSchTown);
            this.Controls.Add(this.txtTownName);
            this.Controls.Add(this.txtSectorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSchSector);
            this.Controls.Add(this.txtSectorName);
            this.Controls.Add(this.CmbPaties);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmbPartyGroups);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CmbCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dtpUpTill);
            this.Controls.Add(this.optRange);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label2);
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Name = "RptPartyBalnances";
            this.Text = "Party Balnances";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dtpUpTill;
        private System.Windows.Forms.RadioButton optRange;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbPartyGroups;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbPaties;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTownID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSchTown;
        private System.Windows.Forms.TextBox txtTownName;
        private System.Windows.Forms.TextBox txtSectorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSchSector;
        private System.Windows.Forms.TextBox txtSectorName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label12;
    }
}