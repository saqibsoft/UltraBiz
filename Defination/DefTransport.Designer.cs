namespace Defination
{
    partial class DefTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefTransport));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.TransportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Transport Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 244);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(251, 20);
            this.TxtName.TabIndex = 5;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransportID,
            this.TransportName});
            this.Grid.Location = new System.Drawing.Point(268, 125);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(324, 283);
            this.Grid.TabIndex = 20;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // TransportID
            // 
            this.TransportID.DataPropertyName = "TransportID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TransportID.DefaultCellStyle = dataGridViewCellStyle1;
            this.TransportID.HeaderText = "TransportID";
            this.TransportID.Name = "TransportID";
            this.TransportID.ReadOnly = true;
            // 
            // TransportName
            // 
            this.TransportName.DataPropertyName = "TransportName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TransportName.DefaultCellStyle = dataGridViewCellStyle2;
            this.TransportName.HeaderText = "TransportName";
            this.TransportName.Name = "TransportName";
            this.TransportName.ReadOnly = true;
            this.TransportName.Width = 190;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(369, 423);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 25;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(301, 423);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(62, 23);
            this.CmdSelect.TabIndex = 24;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            this.CmdSelect.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(100, 423);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 21;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(233, 423);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 23;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(168, 423);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 22;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // DefTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 454);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefTransport";
            this.Text = "Transport";
            this.Load += new System.EventHandler(this.DefTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportName;
    }
}