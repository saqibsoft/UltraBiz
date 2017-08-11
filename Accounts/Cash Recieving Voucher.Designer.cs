namespace Accounts
{
    partial class Cash_Recieving_Voucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cash_Recieving_Voucher));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Narration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtVoucherNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAccountName = new System.Windows.Forms.TextBox();
            this.BtnSchPur = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtAccountNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNarration = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotalAmount = new System.Windows.Forms.TextBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmbOffice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNo,
            this.AccountName,
            this.Narration,
            this.Credit});
            this.dataGridView1.Location = new System.Drawing.Point(35, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 399);
            this.dataGridView1.TabIndex = 3;
            // 
            // AccountNo
            // 
            this.AccountNo.HeaderText = "A/C No";
            this.AccountNo.Name = "AccountNo";
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "A/C Name";
            this.AccountName.Name = "AccountName";
            this.AccountName.Width = 150;
            // 
            // Narration
            // 
            this.Narration.HeaderText = "Narration";
            this.Narration.Name = "Narration";
            this.Narration.Width = 160;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit ";
            this.Credit.Name = "Credit";
            this.Credit.Width = 160;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 384;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(108, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 383;
            this.label6.Text = "Voucher Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 382;
            this.label4.Text = "Voucher No:";
            // 
            // TxtVoucherNo
            // 
            this.TxtVoucherNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVoucherNo.Location = new System.Drawing.Point(35, 124);
            this.TxtVoucherNo.Name = "TxtVoucherNo";
            this.TxtVoucherNo.Size = new System.Drawing.Size(70, 20);
            this.TxtVoucherNo.TabIndex = 381;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(122, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 389;
            this.label5.Text = "A/C Name:";
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccountName.Location = new System.Drawing.Point(125, 175);
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(201, 20);
            this.TxtAccountName.TabIndex = 388;
            // 
            // BtnSchPur
            // 
            this.BtnSchPur.Location = new System.Drawing.Point(94, 173);
            this.BtnSchPur.Name = "BtnSchPur";
            this.BtnSchPur.Size = new System.Drawing.Size(28, 22);
            this.BtnSchPur.TabIndex = 387;
            this.BtnSchPur.Text = "....";
            this.BtnSchPur.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(34, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 386;
            this.label10.Text = "A/C No:";
            // 
            // TxtAccountNo
            // 
            this.TxtAccountNo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccountNo.Location = new System.Drawing.Point(35, 175);
            this.TxtAccountNo.Name = "TxtAccountNo";
            this.TxtAccountNo.Size = new System.Drawing.Size(57, 20);
            this.TxtAccountNo.TabIndex = 385;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(36, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 391;
            this.label3.Text = "In Words";
            // 
            // TxtInWords
            // 
            this.TxtInWords.BackColor = System.Drawing.Color.Silver;
            this.TxtInWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInWords.Enabled = false;
            this.TxtInWords.Location = new System.Drawing.Point(37, 622);
            this.TxtInWords.Name = "TxtInWords";
            this.TxtInWords.ReadOnly = true;
            this.TxtInWords.Size = new System.Drawing.Size(388, 20);
            this.TxtInWords.TabIndex = 390;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(329, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 393;
            this.label1.Text = "Narration";
            // 
            // TxtNarration
            // 
            this.TxtNarration.BackColor = System.Drawing.Color.Silver;
            this.TxtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNarration.Enabled = false;
            this.TxtNarration.Location = new System.Drawing.Point(332, 176);
            this.TxtNarration.Name = "TxtNarration";
            this.TxtNarration.ReadOnly = true;
            this.TxtNarration.Size = new System.Drawing.Size(226, 20);
            this.TxtNarration.TabIndex = 392;
            // 
            // TxtAmount
            // 
            this.TxtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAmount.Location = new System.Drawing.Point(564, 176);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(83, 20);
            this.TxtAmount.TabIndex = 394;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(561, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 395;
            this.label2.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(561, 606);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 397;
            this.label7.Text = "Total Amount";
            // 
            // TxtTotalAmount
            // 
            this.TxtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalAmount.Location = new System.Drawing.Point(564, 622);
            this.TxtTotalAmount.Name = "TxtTotalAmount";
            this.TxtTotalAmount.Size = new System.Drawing.Size(83, 20);
            this.TxtTotalAmount.TabIndex = 396;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(427, 681);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 26);
            this.CmdClose.TabIndex = 402;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(359, 682);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(63, 25);
            this.CmdSelect.TabIndex = 401;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(158, 682);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 25);
            this.CmdSave.TabIndex = 398;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(291, 682);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(63, 25);
            this.CmdDelete.TabIndex = 400;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(226, 682);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 25);
            this.CmdClear.TabIndex = 399;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // CmbOffice
            // 
            this.CmbOffice.FormattingEnabled = true;
            this.CmbOffice.Location = new System.Drawing.Point(226, 124);
            this.CmbOffice.Name = "CmbOffice";
            this.CmbOffice.Size = new System.Drawing.Size(225, 21);
            this.CmbOffice.TabIndex = 403;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(561, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 405;
            this.label8.Text = "Balance";
            // 
            // TxtBalance
            // 
            this.TxtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBalance.Location = new System.Drawing.Point(564, 124);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(83, 20);
            this.TxtBalance.TabIndex = 404;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(224, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 406;
            this.label9.Text = "Office";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(118, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(367, 37);
            this.label18.TabIndex = 407;
            this.label18.Text = "Cash Recieving Voucher";
            // 
            // Cash_Recieving_Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounts.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(659, 716);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.CmbOffice);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTotalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNarration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtInWords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAccountName);
            this.Controls.Add(this.BtnSchPur);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtAccountNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtVoucherNo);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cash_Recieving_Voucher";
            this.Text = "Credit_Voucher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtVoucherNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAccountName;
        private System.Windows.Forms.Button BtnSchPur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtAccountNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNarration;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotalAmount;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.ComboBox CmbOffice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Narration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Label label18;
    }
}