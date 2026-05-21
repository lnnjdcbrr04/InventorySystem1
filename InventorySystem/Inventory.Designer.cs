namespace InventorySystem
{
    partial class frmInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInv));
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateInv = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnInvLogout = new System.Windows.Forms.Button();
            this.btnInvSettings = new System.Windows.Forms.Button();
            this.btnInvUsers = new System.Windows.Forms.Button();
            this.btnInvStocks = new System.Windows.Forms.Button();
            this.btnInvSales = new System.Windows.Forms.Button();
            this.btnInvInventory = new System.Windows.Forms.Button();
            this.btnInvOrders = new System.Windows.Forms.Button();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlInventory.Controls.Add(this.dtgProduct);
            this.pnlInventory.Controls.Add(this.label9);
            this.pnlInventory.Controls.Add(this.groupBox1);
            this.pnlInventory.Location = new System.Drawing.Point(208, 72);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(866, 529);
            this.pnlInventory.TabIndex = 4;
            // 
            // dtgProduct
            // 
            this.dtgProduct.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProduct.ColumnHeadersHeight = 25;
            this.dtgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colName,
            this.colStock,
            this.colPrice});
            this.dtgProduct.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgProduct.Location = new System.Drawing.Point(339, 57);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.RowHeadersVisible = false;
            this.dtgProduct.RowHeadersWidth = 12;
            this.dtgProduct.Size = new System.Drawing.Size(513, 433);
            this.dtgProduct.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(513, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Product Table";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.dateInv);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 542);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateInv
            // 
            this.dateInv.BackColor = System.Drawing.Color.White;
            this.dateInv.Checked = true;
            this.dateInv.FillColor = System.Drawing.Color.RosyBrown;
            this.dateInv.FocusedColor = System.Drawing.Color.Transparent;
            this.dateInv.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.dateInv.ForeColor = System.Drawing.Color.White;
            this.dateInv.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateInv.Location = new System.Drawing.Point(62, 349);
            this.dateInv.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateInv.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateInv.Name = "dateInv";
            this.dateInv.Size = new System.Drawing.Size(216, 24);
            this.dateInv.TabIndex = 20;
            this.dateInv.Value = new System.DateTime(2026, 5, 10, 20, 46, 46, 478);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(172, 288);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(107, 22);
            this.txtStock.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(116, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 29);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(213, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(116, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(19, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(58, 228);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(221, 23);
            this.cmbCategory.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(58, 288);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(99, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(58, 169);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(58, 110);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(221, 22);
            this.txtCode.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Expiry:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(72, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Details";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel2.Controls.Add(this.label1);
            this.guna2GradientPanel2.Controls.Add(this.pictureBox3);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.LightPink;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1084, 66);
            this.guna2GradientPanel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(51, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(120, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::InventorySystem.Properties.Resources.icons8_menu_50;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(11, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnInvLogout);
            this.guna2GradientPanel1.Controls.Add(this.btnInvSettings);
            this.guna2GradientPanel1.Controls.Add(this.btnInvUsers);
            this.guna2GradientPanel1.Controls.Add(this.btnInvStocks);
            this.guna2GradientPanel1.Controls.Add(this.btnInvSales);
            this.guna2GradientPanel1.Controls.Add(this.btnInvInventory);
            this.guna2GradientPanel1.Controls.Add(this.btnInvOrders);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightPink;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 66);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 545);
            this.guna2GradientPanel1.TabIndex = 13;
            // 
            // btnInvLogout
            // 
            this.btnInvLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnInvLogout.FlatAppearance.BorderSize = 0;
            this.btnInvLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvLogout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInvLogout.Location = new System.Drawing.Point(1, 486);
            this.btnInvLogout.Name = "btnInvLogout";
            this.btnInvLogout.Size = new System.Drawing.Size(197, 33);
            this.btnInvLogout.TabIndex = 16;
            this.btnInvLogout.Text = "     Logout";
            this.btnInvLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvLogout.UseVisualStyleBackColor = false;
            // 
            // btnInvSettings
            // 
            this.btnInvSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnInvSettings.FlatAppearance.BorderSize = 0;
            this.btnInvSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvSettings.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvSettings.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInvSettings.Location = new System.Drawing.Point(1, 442);
            this.btnInvSettings.Name = "btnInvSettings";
            this.btnInvSettings.Size = new System.Drawing.Size(197, 33);
            this.btnInvSettings.TabIndex = 15;
            this.btnInvSettings.Text = "     Settings";
            this.btnInvSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvSettings.UseVisualStyleBackColor = false;
            // 
            // btnInvUsers
            // 
            this.btnInvUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnInvUsers.FlatAppearance.BorderSize = 0;
            this.btnInvUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvUsers.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInvUsers.Location = new System.Drawing.Point(1, 398);
            this.btnInvUsers.Name = "btnInvUsers";
            this.btnInvUsers.Size = new System.Drawing.Size(197, 33);
            this.btnInvUsers.TabIndex = 14;
            this.btnInvUsers.Text = "     Users";
            this.btnInvUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvUsers.UseVisualStyleBackColor = false;
            this.btnInvUsers.Click += new System.EventHandler(this.btnInvUsers_Click);
            // 
            // btnInvStocks
            // 
            this.btnInvStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnInvStocks.FlatAppearance.BorderSize = 0;
            this.btnInvStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvStocks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvStocks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInvStocks.Location = new System.Drawing.Point(2, 179);
            this.btnInvStocks.Name = "btnInvStocks";
            this.btnInvStocks.Size = new System.Drawing.Size(197, 33);
            this.btnInvStocks.TabIndex = 13;
            this.btnInvStocks.Text = "     Stocks";
            this.btnInvStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvStocks.UseVisualStyleBackColor = false;
            // 
            // btnInvSales
            // 
            this.btnInvSales.BackColor = System.Drawing.Color.Transparent;
            this.btnInvSales.FlatAppearance.BorderSize = 0;
            this.btnInvSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvSales.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvSales.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInvSales.Location = new System.Drawing.Point(1, 135);
            this.btnInvSales.Name = "btnInvSales";
            this.btnInvSales.Size = new System.Drawing.Size(197, 33);
            this.btnInvSales.TabIndex = 12;
            this.btnInvSales.Text = "     Sales Report";
            this.btnInvSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvSales.UseVisualStyleBackColor = false;
            this.btnInvSales.Click += new System.EventHandler(this.btnInvSales_Click_1);
            // 
            // btnInvInventory
            // 
            this.btnInvInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInvInventory.FlatAppearance.BorderSize = 0;
            this.btnInvInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvInventory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvInventory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInvInventory.Location = new System.Drawing.Point(1, 91);
            this.btnInvInventory.Name = "btnInvInventory";
            this.btnInvInventory.Size = new System.Drawing.Size(197, 33);
            this.btnInvInventory.TabIndex = 11;
            this.btnInvInventory.Text = "     Inventory";
            this.btnInvInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvInventory.UseVisualStyleBackColor = false;
            // 
            // btnInvOrders
            // 
            this.btnInvOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnInvOrders.FlatAppearance.BorderSize = 0;
            this.btnInvOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvOrders.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnInvOrders.Location = new System.Drawing.Point(1, 47);
            this.btnInvOrders.Name = "btnInvOrders";
            this.btnInvOrders.Size = new System.Drawing.Size(197, 33);
            this.btnInvOrders.TabIndex = 10;
            this.btnInvOrders.Text = "     Orders";
            this.btnInvOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvOrders.UseVisualStyleBackColor = false;
            // 
            // colProduct
            // 
            this.colProduct.FillWeight = 200F;
            this.colProduct.HeaderText = "Product Code";
            this.colProduct.MinimumWidth = 6;
            this.colProduct.Name = "colProduct";
            this.colProduct.Width = 120;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.Width = 120;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 120;
            // 
            // frmInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.pnlInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInv";
            this.Text = "Inventory";
            this.pnlInventory.ResumeLayout(false);
            this.pnlInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStock;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnInvLogout;
        private System.Windows.Forms.Button btnInvSettings;
        private System.Windows.Forms.Button btnInvUsers;
        private System.Windows.Forms.Button btnInvStocks;
        private System.Windows.Forms.Button btnInvSales;
        private System.Windows.Forms.Button btnInvInventory;
        private System.Windows.Forms.Button btnInvOrders;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}