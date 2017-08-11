namespace Defination
{
    partial class DefGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefGroups));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CmbCompany = new System.Windows.Forms.ComboBox();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.GroupName});
            this.Grid.Location = new System.Drawing.Point(260, 139);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(297, 263);
            this.Grid.TabIndex = 52;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // GroupID
            // 
            this.GroupID.DataPropertyName = "GroupID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GroupID.DefaultCellStyle = dataGridViewCellStyle1;
            this.GroupID.HeaderText = "ID #";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            this.GroupID.Width = 60;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GroupName.DefaultCellStyle = dataGridViewCellStyle2;
            this.GroupName.HeaderText = "Name";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Width = 170;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(79, 408);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(62, 23);
            this.CmdSave.TabIndex = 51;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(215, 408);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(62, 23);
            this.CmdDelete.TabIndex = 50;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(351, 408);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(62, 23);
            this.CmdClose.TabIndex = 49;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(147, 408);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(62, 23);
            this.CmdClear.TabIndex = 48;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdOpen
            // 
            this.CmdOpen.Location = new System.Drawing.Point(283, 408);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(62, 23);
            this.CmdOpen.TabIndex = 47;
            this.CmdOpen.Text = "Select";
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Group Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 247);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 20);
            this.txtName.TabIndex = 45;
            // 
            // CmbCompany
            // 
            this.CmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCompany.FormattingEnabled = true;
            this.CmbCompany.Location = new System.Drawing.Point(12, 193);
            this.CmbCompany.Name = "CmbCompany";
            this.CmbCompany.Size = new System.Drawing.Size(150, 21);
            this.CmbCompany.TabIndex = 44;
            this.CmbCompany.SelectedIndexChanged += new System.EventHandler(this.CmbCompany_SelectedIndexChanged);
            this.CmbCompany.Click += new System.EventHandler(this.CmbCompany_SelectedIndexChanged);
            // 
            // CmbFilter
            // 
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Location = new System.Drawing.Point(260, 112);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(289, 21);
            this.CmbFilter.TabIndex = 43;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            this.CmbFilter.Click += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Company:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(257, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Company:";
            // 
            // DefGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(564, 442);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.CmbCompany);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefGroups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.DefGroups_Load);
            this.Click += new System.EventHandler(this.DefGroups_Load);
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox CmbCompany;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
    }
}