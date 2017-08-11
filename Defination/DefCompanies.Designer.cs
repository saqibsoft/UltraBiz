namespace Defination
{
    partial class DefCompanies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefCompanies));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyID,
            this.CompanyGroupName});
            this.Grid.Location = new System.Drawing.Point(261, 115);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(297, 263);
            this.Grid.TabIndex = 38;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // CompanyID
            // 
            this.CompanyID.DataPropertyName = "CompanyID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CompanyID.DefaultCellStyle = dataGridViewCellStyle1;
            this.CompanyID.HeaderText = "ID ";
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.ReadOnly = true;
            this.CompanyID.Width = 60;
            // 
            // CompanyGroupName
            // 
            this.CompanyGroupName.DataPropertyName = "CompanyName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CompanyGroupName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CompanyGroupName.HeaderText = "Company/Group Name";
            this.CompanyGroupName.Name = "CompanyGroupName";
            this.CompanyGroupName.ReadOnly = true;
            this.CompanyGroupName.Width = 170;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(80, 397);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 43;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(216, 397);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 42;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(352, 397);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 41;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(148, 397);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 40;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(284, 397);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(62, 23);
            this.CmdOpen.TabIndex = 39;
            this.CmdOpen.Text = "Select";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Company/Group Name:";
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Location = new System.Drawing.Point(12, 251);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(243, 20);
            this.TxtName.TabIndex = 44;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(12, 192);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(67, 20);
            this.txtID.TabIndex = 47;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 36);
            this.label4.TabIndex = 48;
            this.label4.Text = "Companies/Groups";
            // 
            // DefCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 432);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefCompanies";
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.DefCompanies_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DefCompanies_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyGroupName;
    }
}