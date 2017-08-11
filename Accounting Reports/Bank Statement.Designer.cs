namespace Accounting_Reports
{
    partial class Bank_Statement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank_Statement));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtTownID = new System.Windows.Forms.TextBox();
            this.TxtTownName = new System.Windows.Forms.TextBox();
            this.BtnSchTown = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 692;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(267, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 691;
            this.label3.Text = "To Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(145, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker2.TabIndex = 690;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(145, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 689;
            this.label4.Text = "From Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(143, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 706;
            this.label15.Text = "Account No";
            // 
            // TxtTownID
            // 
            this.TxtTownID.BackColor = System.Drawing.Color.White;
            this.TxtTownID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTownID.Enabled = false;
            this.TxtTownID.Location = new System.Drawing.Point(147, 194);
            this.TxtTownID.Name = "TxtTownID";
            this.TxtTownID.ReadOnly = true;
            this.TxtTownID.Size = new System.Drawing.Size(55, 20);
            this.TxtTownID.TabIndex = 705;
            // 
            // TxtTownName
            // 
            this.TxtTownName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTownName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTownName.Location = new System.Drawing.Point(234, 194);
            this.TxtTownName.Name = "TxtTownName";
            this.TxtTownName.Size = new System.Drawing.Size(220, 20);
            this.TxtTownName.TabIndex = 704;
            // 
            // BtnSchTown
            // 
            this.BtnSchTown.Location = new System.Drawing.Point(203, 192);
            this.BtnSchTown.Name = "BtnSchTown";
            this.BtnSchTown.Size = new System.Drawing.Size(28, 22);
            this.BtnSchTown.TabIndex = 703;
            this.BtnSchTown.Text = "....";
            this.BtnSchTown.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(148, 239);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(264, 17);
            this.checkBox1.TabIndex = 707;
            this.checkBox1.Text = "Include Journal, Debit, Credit & Bank Vouchers Also";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(268, 347);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(65, 26);
            this.CmdClose.TabIndex = 710;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(196, 348);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(65, 25);
            this.CmdSave.TabIndex = 709;
            this.CmdSave.Text = "Preview";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(115, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(258, 37);
            this.label18.TabIndex = 711;
            this.label18.Text = "Bank Statement";
            // 
            // Bank_Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounting_Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(472, 398);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtTownID);
            this.Controls.Add(this.TxtTownName);
            this.Controls.Add(this.BtnSchTown);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bank_Statement";
            this.Text = "Bank_Statement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtTownID;
        private System.Windows.Forms.TextBox TxtTownName;
        private System.Windows.Forms.Button BtnSchTown;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label18;
    }
}