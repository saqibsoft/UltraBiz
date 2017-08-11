namespace Invoicing
{
    partial class StockIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIssue));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.CmbPackName = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CmbOffice = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.TxtQtyL = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtPack = new System.Windows.Forms.TextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSMName = new System.Windows.Forms.TextBox();
            this.TxtSMID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIssueID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTTLNetValue = new System.Windows.Forms.TextBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdSelect = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtSMCurrentStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBookerName = new System.Windows.Forms.TextBox();
            this.txtBookerID = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyPack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyLoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.PackingName,
            this.Pack,
            this.QtyPack,
            this.QtyLoose,
            this.SalePrice,
            this.NetValue});
            this.dataGridView1.Location = new System.Drawing.Point(13, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(697, 265);
            this.dataGridView1.TabIndex = 218;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(532, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 256;
            this.label1.Text = "Cost";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(248, 239);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 255;
            this.label20.Text = "Pack Name";
            // 
            // CmbPackName
            // 
            this.CmbPackName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPackName.FormattingEnabled = true;
            this.CmbPackName.Location = new System.Drawing.Point(250, 253);
            this.CmbPackName.Name = "CmbPackName";
            this.CmbPackName.Size = new System.Drawing.Size(73, 21);
            this.CmbPackName.TabIndex = 254;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(288, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 253;
            this.label19.Text = "Office";
            // 
            // CmbOffice
            // 
            this.CmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOffice.FormattingEnabled = true;
            this.CmbOffice.Location = new System.Drawing.Point(291, 139);
            this.CmbOffice.Name = "CmbOffice";
            this.CmbOffice.Size = new System.Drawing.Size(226, 21);
            this.CmbOffice.TabIndex = 252;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(604, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 251;
            this.label17.Text = "Value";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(467, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 250;
            this.label16.Text = "Qty(L)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(394, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 249;
            this.label15.Text = "QtyPack";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(322, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 248;
            this.label14.Text = "Pack";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(106, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 247;
            this.label12.Text = "Product Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(46, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 246;
            this.label11.Text = "ProductID";
            // 
            // TxtValue
            // 
            this.TxtValue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValue.Enabled = false;
            this.TxtValue.Location = new System.Drawing.Point(606, 254);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(103, 20);
            this.TxtValue.TabIndex = 245;
            // 
            // TxtCost
            // 
            this.TxtCost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCost.Location = new System.Drawing.Point(534, 254);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(72, 20);
            this.TxtCost.TabIndex = 244;
            // 
            // TxtQtyL
            // 
            this.TxtQtyL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQtyL.Location = new System.Drawing.Point(468, 254);
            this.TxtQtyL.Name = "TxtQtyL";
            this.TxtQtyL.Size = new System.Drawing.Size(66, 20);
            this.TxtQtyL.TabIndex = 243;
            // 
            // TxtQty
            // 
            this.TxtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQty.Location = new System.Drawing.Point(396, 254);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(72, 20);
            this.TxtQty.TabIndex = 242;
            // 
            // TxtPack
            // 
            this.TxtPack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPack.Enabled = false;
            this.TxtPack.Location = new System.Drawing.Point(323, 254);
            this.TxtPack.Name = "TxtPack";
            this.TxtPack.Size = new System.Drawing.Size(73, 20);
            this.TxtPack.TabIndex = 241;
            // 
            // TxtProductName
            // 
            this.TxtProductName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductName.Location = new System.Drawing.Point(98, 254);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(152, 20);
            this.TxtProductName.TabIndex = 240;
            this.TxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtProductID
            // 
            this.TxtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProductID.Location = new System.Drawing.Point(48, 254);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(50, 20);
            this.TxtProductID.TabIndex = 239;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(97, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 260;
            this.label2.Text = "SalesmenName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 259;
            this.label3.Text = "SalesmenID";
            // 
            // TxtSMName
            // 
            this.TxtSMName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSMName.Location = new System.Drawing.Point(96, 184);
            this.TxtSMName.Name = "TxtSMName";
            this.TxtSMName.Size = new System.Drawing.Size(200, 20);
            this.TxtSMName.TabIndex = 258;
            this.TxtSMName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtSMID
            // 
            this.TxtSMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSMID.Location = new System.Drawing.Point(13, 184);
            this.TxtSMID.Name = "TxtSMID";
            this.TxtSMID.Size = new System.Drawing.Size(83, 20);
            this.TxtSMID.TabIndex = 257;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(96, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 264;
            this.label6.Text = "IssueDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 263;
            this.label4.Text = "Issue ID";
            // 
            // TxtIssueID
            // 
            this.TxtIssueID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtIssueID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIssueID.Location = new System.Drawing.Point(13, 140);
            this.TxtIssueID.Name = "TxtIssueID";
            this.TxtIssueID.Size = new System.Drawing.Size(81, 20);
            this.TxtIssueID.TabIndex = 261;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(534, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 266;
            this.label5.Text = "Net Value:";
            // 
            // TxtTTLNetValue
            // 
            this.TxtTTLNetValue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtTTLNetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTTLNetValue.Location = new System.Drawing.Point(593, 541);
            this.TxtTTLNetValue.Name = "TxtTTLNetValue";
            this.TxtTTLNetValue.Size = new System.Drawing.Size(116, 20);
            this.TxtTTLNetValue.TabIndex = 265;
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(445, 578);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(63, 27);
            this.CmdClose.TabIndex = 279;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // CmdSelect
            // 
            this.CmdSelect.Location = new System.Drawing.Point(377, 579);
            this.CmdSelect.Name = "CmdSelect";
            this.CmdSelect.Size = new System.Drawing.Size(63, 26);
            this.CmdSelect.TabIndex = 278;
            this.CmdSelect.Text = "Select";
            this.CmdSelect.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(176, 579);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(63, 26);
            this.CmdSave.TabIndex = 275;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(309, 579);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(63, 26);
            this.CmdDelete.TabIndex = 277;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(244, 579);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(63, 26);
            this.CmdClear.TabIndex = 276;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CustomFormat = "dd/MMM/yy";
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(99, 140);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(93, 20);
            this.dtpIssueDate.TabIndex = 280;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(71, 26);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(433, 39);
            this.label35.TabIndex = 281;
            this.label35.Text = "Stock Issue To Salesman";
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentStock.Location = new System.Drawing.Point(545, 138);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.ReadOnly = true;
            this.txtCurrentStock.Size = new System.Drawing.Size(116, 20);
            this.txtCurrentStock.TabIndex = 283;
            this.txtCurrentStock.TabStop = false;
            this.txtCurrentStock.Visible = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label41.Location = new System.Drawing.Point(543, 123);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(118, 13);
            this.label41.TabIndex = 282;
            this.label41.Text = "Total Current Stock P-L";
            this.label41.Visible = false;
            // 
            // txtSMCurrentStock
            // 
            this.txtSMCurrentStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSMCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSMCurrentStock.Location = new System.Drawing.Point(593, 183);
            this.txtSMCurrentStock.Name = "txtSMCurrentStock";
            this.txtSMCurrentStock.ReadOnly = true;
            this.txtSMCurrentStock.Size = new System.Drawing.Size(117, 20);
            this.txtSMCurrentStock.TabIndex = 285;
            this.txtSMCurrentStock.TabStop = false;
            this.txtSMCurrentStock.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(591, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 284;
            this.label7.Text = "Salesman Current Stock ";
            this.label7.Visible = false;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CustomFormat = "dd/MMM/yy";
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(195, 141);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(93, 20);
            this.dtpDeliveryDate.TabIndex = 286;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(192, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 287;
            this.label8.Text = "DeliveryDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(374, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 291;
            this.label9.Text = "BookerName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(317, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 290;
            this.label10.Text = "Booker";
            // 
            // txtBookerName
            // 
            this.txtBookerName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBookerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookerName.Location = new System.Drawing.Point(380, 183);
            this.txtBookerName.Name = "txtBookerName";
            this.txtBookerName.Size = new System.Drawing.Size(189, 20);
            this.txtBookerName.TabIndex = 289;
            this.txtBookerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBookerID
            // 
            this.txtBookerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookerID.Location = new System.Drawing.Point(318, 183);
            this.txtBookerID.Name = "txtBookerID";
            this.txtBookerID.Size = new System.Drawing.Size(62, 20);
            this.txtBookerID.TabIndex = 288;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(719, 608);
            this.shapeContainer1.TabIndex = 292;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 691;
            this.lineShape1.Y1 = 226;
            this.lineShape1.Y2 = 226;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 55;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 140;
            // 
            // PackingName
            // 
            this.PackingName.DataPropertyName = "PackingName";
            this.PackingName.HeaderText = "PackingName";
            this.PackingName.Name = "PackingName";
            this.PackingName.ReadOnly = true;
            this.PackingName.Width = 75;
            // 
            // Pack
            // 
            this.Pack.DataPropertyName = "Pack";
            this.Pack.HeaderText = "Pack";
            this.Pack.Name = "Pack";
            this.Pack.ReadOnly = true;
            this.Pack.Width = 75;
            // 
            // QtyPack
            // 
            this.QtyPack.DataPropertyName = "QtyPack";
            this.QtyPack.HeaderText = "QtyPack";
            this.QtyPack.Name = "QtyPack";
            this.QtyPack.ReadOnly = true;
            this.QtyPack.Width = 70;
            // 
            // QtyLoose
            // 
            this.QtyLoose.DataPropertyName = "QtyLoose";
            this.QtyLoose.HeaderText = "QtyLoose";
            this.QtyLoose.Name = "QtyLoose";
            this.QtyLoose.ReadOnly = true;
            this.QtyLoose.Width = 67;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "SalePrice";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            this.SalePrice.Width = 75;
            // 
            // NetValue
            // 
            this.NetValue.DataPropertyName = "NetValue";
            this.NetValue.HeaderText = "NetValue";
            this.NetValue.Name = "NetValue";
            this.NetValue.ReadOnly = true;
            // 
            // StockIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Defination.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(719, 608);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBookerName);
            this.Controls.Add(this.txtBookerID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.txtSMCurrentStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCurrentStock);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSelect);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTTLNetValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIssueID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSMName);
            this.Controls.Add(this.TxtSMID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CmbPackName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.CmbOffice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.TxtQtyL);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtPack);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.TxtProductID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockIssue";
            this.Text = "Stock Issue To Salesmen";
            this.Load += new System.EventHandler(this.StockIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox CmbPackName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox CmbOffice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.TextBox TxtQtyL;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtPack;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSMName;
        private System.Windows.Forms.TextBox TxtSMID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIssueID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTTLNetValue;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdSelect;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtSMCurrentStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBookerName;
        private System.Windows.Forms.TextBox txtBookerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyPack;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyLoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetValue;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}