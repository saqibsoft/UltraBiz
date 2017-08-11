namespace Accounts
{
    partial class Recievable_Payable_Parties_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recievable_Payable_Parties_Setting));
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbTown = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receivable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSector = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(299, 574);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 26);
            this.CmdClose.TabIndex = 378;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(163, 575);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 25);
            this.CmdSave.TabIndex = 376;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(231, 575);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 25);
            this.CmdClear.TabIndex = 377;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(21, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 373;
            this.label7.Text = "Town:";
            // 
            // CmbTown
            // 
            this.CmbTown.FormattingEnabled = true;
            this.CmbTown.Location = new System.Drawing.Point(21, 121);
            this.CmbTown.Name = "CmbTown";
            this.CmbTown.Size = new System.Drawing.Size(182, 21);
            this.CmbTown.TabIndex = 372;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartyID,
            this.PartyName,
            this.Receivable,
            this.Payable});
            this.dataGridView1.Location = new System.Drawing.Point(21, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(510, 399);
            this.dataGridView1.TabIndex = 371;
            // 
            // PartyID
            // 
            this.PartyID.HeaderText = "PartyID";
            this.PartyID.Name = "PartyID";
            this.PartyID.ReadOnly = true;
            // 
            // PartyName
            // 
            this.PartyName.HeaderText = "PartyName";
            this.PartyName.Name = "PartyName";
            this.PartyName.ReadOnly = true;
            this.PartyName.Width = 150;
            // 
            // Receivable
            // 
            this.Receivable.HeaderText = "Receivable";
            this.Receivable.Name = "Receivable";
            this.Receivable.ReadOnly = true;
            this.Receivable.Width = 110;
            // 
            // Payable
            // 
            this.Payable.HeaderText = "Payable";
            this.Payable.Name = "Payable";
            this.Payable.ReadOnly = true;
            this.Payable.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(209, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 380;
            this.label1.Text = "Sector:";
            // 
            // CmbSector
            // 
            this.CmbSector.FormattingEnabled = true;
            this.CmbSector.Location = new System.Drawing.Point(209, 121);
            this.CmbSector.Name = "CmbSector";
            this.CmbSector.Size = new System.Drawing.Size(188, 21);
            this.CmbSector.TabIndex = 379;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(58, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(428, 37);
            this.label18.TabIndex = 381;
            this.label18.Text = "Receivable/Payable Setting";
            // 
            // Recievable_Payable_Parties_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounts.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(558, 611);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSector);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbTown);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recievable_Payable_Parties_Setting";
            this.Text = "Recievable/Payable_Setting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbTown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receivable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSector;
        private System.Windows.Forms.Label label18;
    }
}