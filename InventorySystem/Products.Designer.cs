namespace InventorySystem
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnProdReports = new System.Windows.Forms.Button();
            this.btnProdDsh = new System.Windows.Forms.Button();
            this.btnProdLogout = new System.Windows.Forms.Button();
            this.btnProdUsers = new System.Windows.Forms.Button();
            this.btnProdOrders = new System.Windows.Forms.Button();
            this.btnProdTrans = new System.Windows.Forms.Button();
            this.btnProdStocks = new System.Windows.Forms.Button();
            this.btnProdProducts = new System.Windows.Forms.Button();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProductN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnUpdProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnProdReports);
            this.guna2GradientPanel1.Controls.Add(this.btnProdDsh);
            this.guna2GradientPanel1.Controls.Add(this.btnProdLogout);
            this.guna2GradientPanel1.Controls.Add(this.btnProdUsers);
            this.guna2GradientPanel1.Controls.Add(this.btnProdOrders);
            this.guna2GradientPanel1.Controls.Add(this.btnProdTrans);
            this.guna2GradientPanel1.Controls.Add(this.btnProdStocks);
            this.guna2GradientPanel1.Controls.Add(this.btnProdProducts);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightPink;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 60);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 551);
            this.guna2GradientPanel1.TabIndex = 14;
            // 
            // btnProdReports
            // 
            this.btnProdReports.BackColor = System.Drawing.Color.Transparent;
            this.btnProdReports.FlatAppearance.BorderSize = 0;
            this.btnProdReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdReports.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdReports.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProdReports.Location = new System.Drawing.Point(2, 266);
            this.btnProdReports.Name = "btnProdReports";
            this.btnProdReports.Size = new System.Drawing.Size(197, 33);
            this.btnProdReports.TabIndex = 18;
            this.btnProdReports.Text = "     Reports";
            this.btnProdReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdReports.UseVisualStyleBackColor = false;
            this.btnProdReports.Click += new System.EventHandler(this.btnProdReports_Click);
            // 
            // btnProdDsh
            // 
            this.btnProdDsh.BackColor = System.Drawing.Color.Transparent;
            this.btnProdDsh.FlatAppearance.BorderSize = 0;
            this.btnProdDsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdDsh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdDsh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProdDsh.Location = new System.Drawing.Point(1, 46);
            this.btnProdDsh.Name = "btnProdDsh";
            this.btnProdDsh.Size = new System.Drawing.Size(197, 33);
            this.btnProdDsh.TabIndex = 17;
            this.btnProdDsh.Text = "     Dashboard";
            this.btnProdDsh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdDsh.UseVisualStyleBackColor = false;
            this.btnProdDsh.Click += new System.EventHandler(this.btnProdDsh_Click);
            // 
            // btnProdLogout
            // 
            this.btnProdLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnProdLogout.FlatAppearance.BorderSize = 0;
            this.btnProdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdLogout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProdLogout.Location = new System.Drawing.Point(1, 486);
            this.btnProdLogout.Name = "btnProdLogout";
            this.btnProdLogout.Size = new System.Drawing.Size(197, 33);
            this.btnProdLogout.TabIndex = 16;
            this.btnProdLogout.Text = "     Logout";
            this.btnProdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdLogout.UseVisualStyleBackColor = false;
            this.btnProdLogout.Click += new System.EventHandler(this.btnProdLogout_Click);
            // 
            // btnProdUsers
            // 
            this.btnProdUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnProdUsers.FlatAppearance.BorderSize = 0;
            this.btnProdUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdUsers.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProdUsers.Location = new System.Drawing.Point(1, 442);
            this.btnProdUsers.Name = "btnProdUsers";
            this.btnProdUsers.Size = new System.Drawing.Size(197, 33);
            this.btnProdUsers.TabIndex = 14;
            this.btnProdUsers.Text = "     Users";
            this.btnProdUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdUsers.UseVisualStyleBackColor = false;
            this.btnProdUsers.Click += new System.EventHandler(this.btnProdUsers_Click);
            // 
            // btnProdOrders
            // 
            this.btnProdOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnProdOrders.FlatAppearance.BorderSize = 0;
            this.btnProdOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdOrders.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProdOrders.Location = new System.Drawing.Point(2, 222);
            this.btnProdOrders.Name = "btnProdOrders";
            this.btnProdOrders.Size = new System.Drawing.Size(197, 33);
            this.btnProdOrders.TabIndex = 13;
            this.btnProdOrders.Text = "     Orders";
            this.btnProdOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdOrders.UseVisualStyleBackColor = false;
            this.btnProdOrders.Click += new System.EventHandler(this.btnProdOrders_Click);
            // 
            // btnProdTrans
            // 
            this.btnProdTrans.BackColor = System.Drawing.Color.Transparent;
            this.btnProdTrans.FlatAppearance.BorderSize = 0;
            this.btnProdTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdTrans.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdTrans.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProdTrans.Location = new System.Drawing.Point(1, 178);
            this.btnProdTrans.Name = "btnProdTrans";
            this.btnProdTrans.Size = new System.Drawing.Size(197, 33);
            this.btnProdTrans.TabIndex = 12;
            this.btnProdTrans.Text = "     Transaction";
            this.btnProdTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdTrans.UseVisualStyleBackColor = false;
            this.btnProdTrans.Click += new System.EventHandler(this.btnProdTrans_Click);
            // 
            // btnProdStocks
            // 
            this.btnProdStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnProdStocks.FlatAppearance.BorderSize = 0;
            this.btnProdStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdStocks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdStocks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProdStocks.Location = new System.Drawing.Point(1, 134);
            this.btnProdStocks.Name = "btnProdStocks";
            this.btnProdStocks.Size = new System.Drawing.Size(197, 33);
            this.btnProdStocks.TabIndex = 11;
            this.btnProdStocks.Text = "     Stocks";
            this.btnProdStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdStocks.UseVisualStyleBackColor = false;
            this.btnProdStocks.Click += new System.EventHandler(this.btnProdStocks_Click);
            // 
            // btnProdProducts
            // 
            this.btnProdProducts.BackColor = System.Drawing.Color.MistyRose;
            this.btnProdProducts.FlatAppearance.BorderSize = 0;
            this.btnProdProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdProducts.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdProducts.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnProdProducts.Location = new System.Drawing.Point(1, 90);
            this.btnProdProducts.Name = "btnProdProducts";
            this.btnProdProducts.Size = new System.Drawing.Size(197, 33);
            this.btnProdProducts.TabIndex = 10;
            this.btnProdProducts.Text = "     Products";
            this.btnProdProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdProducts.UseVisualStyleBackColor = false;
            this.btnProdProducts.Click += new System.EventHandler(this.btnProdProducts_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel2.Controls.Add(this.label1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.LightPink;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1084, 60);
            this.guna2GradientPanel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(460, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 22);
            this.textBox1.TabIndex = 74;
            // 
            // txtProductN
            // 
            this.txtProductN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductN.Location = new System.Drawing.Point(263, 225);
            this.txtProductN.Multiline = true;
            this.txtProductN.Name = "txtProductN";
            this.txtProductN.Size = new System.Drawing.Size(138, 22);
            this.txtProductN.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(263, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 21);
            this.label10.TabIndex = 72;
            this.label10.Text = "Product Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(263, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Product ID:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(263, 286);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(138, 21);
            this.cmbCategory.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(460, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 65;
            this.label8.Text = "Price:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(639, 278);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(91, 29);
            this.btnAddProduct.TabIndex = 68;
            this.btnAddProduct.Text = "Add ";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(263, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 70;
            this.label9.Text = "Category:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(460, 225);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(78, 22);
            this.txtQuantity.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.Location = new System.Drawing.Point(460, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 66;
            this.label11.Text = "Quantity:";
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Location = new System.Drawing.Point(736, 278);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(91, 29);
            this.btnSaveProduct.TabIndex = 69;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(215, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "PRODUCT RECORD MANAGEMENT";
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(267, 157);
            this.txtProductID.Multiline = true;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(138, 22);
            this.txtProductID.TabIndex = 76;
            // 
            // btnUpdProduct
            // 
            this.btnUpdProduct.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdProduct.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdProduct.Location = new System.Drawing.Point(833, 278);
            this.btnUpdProduct.Name = "btnUpdProduct";
            this.btnUpdProduct.Size = new System.Drawing.Size(91, 29);
            this.btnUpdProduct.TabIndex = 77;
            this.btnUpdProduct.Text = "Update";
            this.btnUpdProduct.UseVisualStyleBackColor = false;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelProduct.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProduct.ForeColor = System.Drawing.Color.White;
            this.btnDelProduct.Location = new System.Drawing.Point(930, 278);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(91, 29);
            this.btnDelProduct.TabIndex = 78;
            this.btnDelProduct.Text = "Delete";
            this.btnDelProduct.UseVisualStyleBackColor = false;
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductN,
            this.Category,
            this.Price,
            this.Quantity,
            this.Description,
            this.Status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.Location = new System.Drawing.Point(263, 346);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.Size = new System.Drawing.Size(755, 253);
            this.dgvProduct.TabIndex = 79;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductN
            // 
            this.ProductN.HeaderText = "Name";
            this.ProductN.Name = "ProductN";
            this.ProductN.Width = 150;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(456, 286);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(138, 21);
            this.cmbStatus.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(456, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 80;
            this.label3.Text = "Status:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(856, 87);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 22);
            this.txtSearch.TabIndex = 83;
            this.txtSearch.Text = "SEARCH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(787, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 82;
            this.label4.Text = "Search:";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnUpdProduct);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtProductN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnProdReports;
        private System.Windows.Forms.Button btnProdDsh;
        private System.Windows.Forms.Button btnProdLogout;
        private System.Windows.Forms.Button btnProdUsers;
        private System.Windows.Forms.Button btnProdOrders;
        private System.Windows.Forms.Button btnProdTrans;
        private System.Windows.Forms.Button btnProdStocks;
        private System.Windows.Forms.Button btnProdProducts;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtProductN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnUpdProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
    }
}