namespace Defination
{
    partial class DefOfficeSectors
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SampleNode");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SampleNode");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("SampleNode", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SampleNode");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefOfficeSectors));
            this.tvwSectors = new System.Windows.Forms.TreeView();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Offices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwSectors
            // 
            this.tvwSectors.Location = new System.Drawing.Point(12, 102);
            this.tvwSectors.Name = "tvwSectors";
            treeNode1.Name = "SampleNode";
            treeNode1.Text = "SampleNode";
            treeNode2.Name = "SampleNode";
            treeNode2.Text = "SampleNode";
            treeNode3.Name = "SampleNode";
            treeNode3.Text = "SampleNode";
            treeNode4.Name = "SampleNode";
            treeNode4.Text = "SampleNode";
            this.tvwSectors.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.tvwSectors.Size = new System.Drawing.Size(274, 263);
            this.tvwSectors.TabIndex = 8;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Offices});
            this.Grid.Location = new System.Drawing.Point(338, 102);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(297, 263);
            this.Grid.TabIndex = 38;
            // 
            // Offices
            // 
            this.Offices.DataPropertyName = "Offices";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Offices.DefaultCellStyle = dataGridViewCellStyle1;
            this.Offices.HeaderText = "Offices";
            this.Offices.Name = "Offices";
            this.Offices.ReadOnly = true;
            this.Offices.Width = 270;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(110, 386);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 43;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(246, 386);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 42;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(382, 386);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 41;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(178, 386);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 40;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(314, 386);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(62, 23);
            this.CmdOpen.TabIndex = 39;
            this.CmdOpen.Text = "Select";
            this.CmdOpen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 36);
            this.label4.TabIndex = 44;
            this.label4.Text = "Sectors";
            // 
            // DefOfficeSectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.tvwSectors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefOfficeSectors";
            this.Text = "Office Sector";
            this.Load += new System.EventHandler(this.DefOfficeSectors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwSectors;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offices;

    }
}