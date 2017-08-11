namespace Accounts
{
    partial class Balance_Sheet_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance_Sheet_Setting));
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbAccountType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(266, 586);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(66, 26);
            this.CmdClose.TabIndex = 379;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(130, 587);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(66, 25);
            this.CmdSave.TabIndex = 377;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(198, 587);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(66, 25);
            this.CmdClear.TabIndex = 378;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 376;
            this.label7.Text = "Account Type";
            // 
            // CmbAccountType
            // 
            this.CmbAccountType.FormattingEnabled = true;
            this.CmbAccountType.Location = new System.Drawing.Point(12, 131);
            this.CmbAccountType.Name = "CmbAccountType";
            this.CmbAccountType.Size = new System.Drawing.Size(200, 21);
            this.CmbAccountType.TabIndex = 375;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNo,
            this.AccountName,
            this.Setting});
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 399);
            this.dataGridView1.TabIndex = 374;
            // 
            // AccountNo
            // 
            this.AccountNo.HeaderText = "A/C No";
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.Width = 130;
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "A/C Name";
            this.AccountName.Name = "AccountName";
            this.AccountName.Width = 170;
            // 
            // Setting
            // 
            this.Setting.HeaderText = "Setting";
            this.Setting.Name = "Setting";
            this.Setting.Width = 140;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(88, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(352, 37);
            this.label18.TabIndex = 381;
            this.label18.Text = "Balance Sheet Setting";
            // 
            // Balance_Sheet_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounts.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(517, 632);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbAccountType);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Balance_Sheet_Setting";
            this.Text = "Balance_Sheet_Setting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbAccountType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setting;
        private System.Windows.Forms.Label label18;
    }
}