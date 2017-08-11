namespace Accounting_Reports
{
    partial class Opening_Balances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opening_Balances));
            this.label7 = new System.Windows.Forms.Label();
            this.CmbAccountType = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(174, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 626;
            this.label7.Text = "Account Type:";
            // 
            // CmbAccountType
            // 
            this.CmbAccountType.FormattingEnabled = true;
            this.CmbAccountType.Location = new System.Drawing.Point(174, 164);
            this.CmbAccountType.Name = "CmbAccountType";
            this.CmbAccountType.Size = new System.Drawing.Size(200, 21);
            this.CmbAccountType.TabIndex = 625;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(177, 202);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(216, 17);
            this.checkBox2.TabIndex = 629;
            this.checkBox2.Text = "Exclude Accounts Having Zero Balance";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(257, 337);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(70, 26);
            this.CmdClose.TabIndex = 674;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(183, 337);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(68, 25);
            this.CmdSave.TabIndex = 673;
            this.CmdSave.Text = "Preview";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(90, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(445, 37);
            this.label18.TabIndex = 675;
            this.label18.Text = "Accounts Opening Balances";
            // 
            // Opening_Balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Accounting_Reports.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(600, 439);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbAccountType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Opening_Balances";
            this.Text = "Accounts_Opening_Balances";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbAccountType;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label18;
    }
}