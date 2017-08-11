namespace Defination
{
    partial class DefSectors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefSectors));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.CmbTown = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.SectorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(258, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Town Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Town Name:";
            // 
            // CmbFilter
            // 
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Location = new System.Drawing.Point(261, 115);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(289, 21);
            this.CmbFilter.TabIndex = 5;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // CmbTown
            // 
            this.CmbTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTown.FormattingEnabled = true;
            this.CmbTown.Location = new System.Drawing.Point(15, 199);
            this.CmbTown.Name = "CmbTown";
            this.CmbTown.Size = new System.Drawing.Size(243, 21);
            this.CmbTown.TabIndex = 6;
            this.CmbTown.SelectedIndexChanged += new System.EventHandler(this.CmbTown_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 253);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 20);
            this.txtName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sector Name:";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(95, 414);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 36;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(231, 414);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 35;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(367, 414);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 34;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(163, 414);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 33;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(299, 414);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(62, 23);
            this.CmdOpen.TabIndex = 32;
            this.CmdOpen.Text = "Select";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectorID,
            this.SectorName});
            this.Grid.Location = new System.Drawing.Point(261, 142);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(297, 263);
            this.Grid.TabIndex = 37;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // SectorID
            // 
            this.SectorID.DataPropertyName = "SectorID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SectorID.DefaultCellStyle = dataGridViewCellStyle1;
            this.SectorID.HeaderText = "ID #";
            this.SectorID.Name = "SectorID";
            this.SectorID.ReadOnly = true;
            this.SectorID.Width = 60;
            // 
            // SectorName
            // 
            this.SectorName.DataPropertyName = "SectorName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SectorName.DefaultCellStyle = dataGridViewCellStyle2;
            this.SectorName.HeaderText = "Name";
            this.SectorName.Name = "SectorName";
            this.SectorName.ReadOnly = true;
            this.SectorName.Width = 170;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 36);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sectors";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblOrder.Location = new System.Drawing.Point(9, 289);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(70, 13);
            this.lblOrder.TabIndex = 40;
            this.lblOrder.Text = "Sector Order:";
            this.lblOrder.Visible = false;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(12, 305);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(123, 20);
            this.txtOrder.TabIndex = 39;
            this.txtOrder.Visible = false;
            // 
            // DefSectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(570, 449);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.CmbTown);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefSectors";
            this.Text = "Sectors";
            this.Load += new System.EventHandler(this.DefSectors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.ComboBox CmbTown;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TextBox txtOrder;
    }
}

