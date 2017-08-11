namespace Accounts
{
    partial class Opening_Balances_for_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opening_Balances_for_Accounts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbAccountType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAccountName = new System.Windows.Forms.TextBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
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
            this.OpeningDebit,
            this.OpeningCredit});
            this.dataGridView1.Location = new System.Drawing.Point(23, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 399);
            this.dataGridView1.TabIndex = 2;
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
            // OpeningDebit
            // 
            this.OpeningDebit.HeaderText = "Opening Debit";
            this.OpeningDebit.Name = "OpeningDebit";
            this.OpeningDebit.Width = 110;
            // 
            // OpeningCredit
            // 
            this.OpeningCredit.HeaderText = "Opening Credit ";
            this.OpeningCredit.Name = "OpeningCredit";
            this.OpeningCredit.Width = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(23, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 354;
            this.label7.Text = "Account Type";
            // 
            // CmbAccountType
            // 
            this.CmbAccountType.FormattingEnabled = true;
            this.CmbAccountType.Location = new System.Drawing.Point(23, 106);
            this.CmbAccountType.Name = "CmbAccountType";
            this.CmbAccountType.Size = new System.Drawing.Size(92, 21);
            this.CmbAccountType.TabIndex = 353;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(120, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 356;
            this.label2.Text = "Account Name ";
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccountName.Location = new System.Drawing.Point(121, 106);
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(217, 20);
            this.TxtAccountName.TabIndex = 355;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(301, 559);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 26);
            this.CmdClose.TabIndex = 370;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(165, 560);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 25);
            this.CmdSave.TabIndex = 368;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(233, 560);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 25);
            this.CmdClear.TabIndex = 369;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(133, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(277, 37);
            this.label18.TabIndex = 379;
            this.label18.Text = "Opening Balance";
            // 
            // Opening_Balances_for_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounts.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(555, 599);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAccountName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbAccountType);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opening_Balances_for_Accounts";
            this.Text = "Opening_Balances_for_Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbAccountType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningCredit;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label label18;
    }
}