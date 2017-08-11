namespace Accounting_Reports
{
    partial class Trial_Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trial_Balance));
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbOffice = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtTownID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(262, 500);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(65, 26);
            this.CmdClose.TabIndex = 726;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(190, 501);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(65, 25);
            this.CmdSave.TabIndex = 725;
            this.CmdSave.Text = "Preview";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(162, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 17);
            this.checkBox1.TabIndex = 724;
            this.checkBox1.Text = "Exclude Accounts Having zero Balance";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Location = new System.Drawing.Point(162, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 100);
            this.groupBox2.TabIndex = 723;
            this.groupBox2.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.BackColor = System.Drawing.Color.Transparent;
            this.radioButton7.Location = new System.Drawing.Point(20, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(98, 17);
            this.radioButton7.TabIndex = 699;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Exclude Parties";
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.BackColor = System.Drawing.Color.Transparent;
            this.radioButton8.Location = new System.Drawing.Point(20, 46);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(95, 17);
            this.radioButton8.TabIndex = 700;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Include Parties";
            this.radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.BackColor = System.Drawing.Color.Transparent;
            this.radioButton9.Location = new System.Drawing.Point(20, 77);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(81, 17);
            this.radioButton9.TabIndex = 702;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Only Parties";
            this.radioButton9.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(162, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 100);
            this.groupBox1.TabIndex = 722;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(20, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(183, 17);
            this.radioButton1.TabIndex = 699;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Show Only Transaction Accounts";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(20, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 17);
            this.radioButton2.TabIndex = 700;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Show Only Accounts Groups";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Location = new System.Drawing.Point(20, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 17);
            this.radioButton3.TabIndex = 702;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Show Both Accounts";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Location = new System.Drawing.Point(162, 124);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(80, 17);
            this.radioButton5.TabIndex = 721;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Single Date";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.Transparent;
            this.radioButton6.Location = new System.Drawing.Point(162, 89);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(67, 17);
            this.radioButton6.TabIndex = 720;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "All Dates";
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Location = new System.Drawing.Point(162, 157);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 17);
            this.radioButton4.TabIndex = 719;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Date Range";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(297, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 728;
            this.label2.Text = "Office:";
            // 
            // CmbOffice
            // 
            this.CmbOffice.FormattingEnabled = true;
            this.CmbOffice.Location = new System.Drawing.Point(297, 104);
            this.CmbOffice.Name = "CmbOffice";
            this.CmbOffice.Size = new System.Drawing.Size(200, 21);
            this.CmbOffice.TabIndex = 727;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(353, 506);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 729;
            this.checkBox2.Text = "Print Urdu";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(348, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 731;
            this.label15.Text = "Closing Value More Than";
            // 
            // TxtTownID
            // 
            this.TxtTownID.BackColor = System.Drawing.Color.White;
            this.TxtTownID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTownID.Enabled = false;
            this.TxtTownID.Location = new System.Drawing.Point(353, 453);
            this.TxtTownID.Name = "TxtTownID";
            this.TxtTownID.ReadOnly = true;
            this.TxtTownID.Size = new System.Drawing.Size(123, 20);
            this.TxtTownID.TabIndex = 730;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(155, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(234, 37);
            this.label18.TabIndex = 732;
            this.label18.Text = "Trial Balances";
            // 
            // Trial_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounting_Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(537, 554);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtTownID);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbOffice);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trial_Balance";
            this.Text = "Trial_Balance";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbOffice;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtTownID;
        private System.Windows.Forms.Label label18;
    }
}