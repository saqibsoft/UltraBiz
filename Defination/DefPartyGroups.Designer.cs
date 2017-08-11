namespace Defination
{
    partial class DefPartyGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefPartyGroups));
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(372, 418);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 33;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(304, 418);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(62, 23);
            this.CmdSelect.TabIndex = 32;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            this.CmdSelect.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(103, 418);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 29;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(236, 418);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 31;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(171, 418);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 30;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.GroupName});
            this.Grid.Location = new System.Drawing.Point(251, 120);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(324, 283);
            this.Grid.TabIndex = 28;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // GroupID
            // 
            this.GroupID.DataPropertyName = "GroupID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GroupID.DefaultCellStyle = dataGridViewCellStyle1;
            this.GroupID.HeaderText = "GroupID";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GroupName.DefaultCellStyle = dataGridViewCellStyle2;
            this.GroupName.HeaderText = "GroupName";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Width = 190;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Group Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 241);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(227, 20);
            this.TxtName.TabIndex = 26;
            // 
            // DefPartyGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(587, 446);
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
            this.Name = "DefPartyGroups";
            this.Text = "Party Groups";
            this.Load += new System.EventHandler(this.DefPartyGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
    }
}