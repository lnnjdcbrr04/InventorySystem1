namespace InventorySystem
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            this.panel3 = new System.Windows.Forms.Panel();
            this.datePickup = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnDeleteSo = new System.Windows.Forms.Button();
            this.btnUpdateSo = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.cmbStat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnOrdLogout = new System.Windows.Forms.Button();
            this.btnOrdSettings = new System.Windows.Forms.Button();
            this.btnOrdUsers = new System.Windows.Forms.Button();
            this.btnOrdStocks = new System.Windows.Forms.Button();
            this.btnOrdSales = new System.Windows.Forms.Button();
            this.btnOrdInventory = new System.Windows.Forms.Button();
            this.btnOrdOrders = new System.Windows.Forms.Button();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.datePickup);
            this.panel3.Controls.Add(this.txtConNo);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cmbCategory);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Controls.Add(this.btnDeleteSo);
            this.panel3.Controls.Add(this.btnUpdateSo);
            this.panel3.Controls.Add(this.btnAddOrder);
            this.panel3.Controls.Add(this.cmbStat);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.cmbProduct);
            this.panel3.Controls.Add(this.txtCustName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(206, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 526);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // datePickup
            // 
            this.datePickup.BackColor = System.Drawing.Color.White;
            this.datePickup.Checked = true;
            this.datePickup.FillColor = System.Drawing.Color.RosyBrown;
            this.datePickup.FocusedColor = System.Drawing.Color.Transparent;
            this.datePickup.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.datePickup.ForeColor = System.Drawing.Color.White;
            this.datePickup.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickup.Location = new System.Drawing.Point(132, 331);
            this.datePickup.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickup.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickup.Name = "datePickup";
            this.datePickup.Size = new System.Drawing.Size(214, 24);
            this.datePickup.TabIndex = 26;
            this.datePickup.Value = new System.DateTime(2026, 5, 10, 20, 46, 46, 478);
            // 
            // txtConNo
            // 
            this.txtConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNo.Location = new System.Drawing.Point(49, 156);
            this.txtConNo.Multiline = true;
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(299, 22);
            this.txtConNo.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(49, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Contact Number:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(49, 215);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(299, 21);
            this.cmbCategory.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(49, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Category:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 526);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // btnDeleteSo
            // 
            this.btnDeleteSo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSo.Location = new System.Drawing.Point(244, 469);
            this.btnDeleteSo.Name = "btnDeleteSo";
            this.btnDeleteSo.Size = new System.Drawing.Size(91, 29);
            this.btnDeleteSo.TabIndex = 20;
            this.btnDeleteSo.Text = "Delete";
            this.btnDeleteSo.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSo
            // 
            this.btnUpdateSo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdateSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSo.Location = new System.Drawing.Point(147, 469);
            this.btnUpdateSo.Name = "btnUpdateSo";
            this.btnUpdateSo.Size = new System.Drawing.Size(91, 29);
            this.btnUpdateSo.TabIndex = 19;
            this.btnUpdateSo.Text = "Update";
            this.btnUpdateSo.UseVisualStyleBackColor = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(50, 469);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(91, 29);
            this.btnAddOrder.TabIndex = 18;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // cmbStat
            // 
            this.cmbStat.FormattingEnabled = true;
            this.cmbStat.Location = new System.Drawing.Point(49, 418);
            this.cmbStat.Name = "cmbStat";
            this.cmbStat.Size = new System.Drawing.Size(186, 21);
            this.cmbStat.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(49, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(142, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pickup Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(49, 331);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(78, 22);
            this.txtQuantity.TabIndex = 13;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(49, 273);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(299, 21);
            this.cmbProduct.TabIndex = 12;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(49, 97);
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(299, 22);
            this.txtCustName.TabIndex = 8;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(49, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(49, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scheduled Orders";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(587, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 526);
            this.panel4.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(23, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Orders";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnOrdLogout);
            this.guna2GradientPanel1.Controls.Add(this.btnOrdSettings);
            this.guna2GradientPanel1.Controls.Add(this.btnOrdUsers);
            this.guna2GradientPanel1.Controls.Add(this.btnOrdStocks);
            this.guna2GradientPanel1.Controls.Add(this.btnOrdSales);
            this.guna2GradientPanel1.Controls.Add(this.btnOrdInventory);
            this.guna2GradientPanel1.Controls.Add(this.btnOrdOrders);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightPink;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 66);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 545);
            this.guna2GradientPanel1.TabIndex = 12;
            // 
            // btnOrdLogout
            // 
            this.btnOrdLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdLogout.FlatAppearance.BorderSize = 0;
            this.btnOrdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdLogout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOrdLogout.Location = new System.Drawing.Point(1, 486);
            this.btnOrdLogout.Name = "btnOrdLogout";
            this.btnOrdLogout.Size = new System.Drawing.Size(197, 33);
            this.btnOrdLogout.TabIndex = 16;
            this.btnOrdLogout.Text = "     Logout";
            this.btnOrdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdLogout.UseVisualStyleBackColor = false;
            this.btnOrdLogout.Click += new System.EventHandler(this.btnOrdLogout_Click);
            // 
            // btnOrdSettings
            // 
            this.btnOrdSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdSettings.FlatAppearance.BorderSize = 0;
            this.btnOrdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdSettings.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdSettings.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOrdSettings.Location = new System.Drawing.Point(1, 442);
            this.btnOrdSettings.Name = "btnOrdSettings";
            this.btnOrdSettings.Size = new System.Drawing.Size(197, 33);
            this.btnOrdSettings.TabIndex = 15;
            this.btnOrdSettings.Text = "     Settings";
            this.btnOrdSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdSettings.UseVisualStyleBackColor = false;
            // 
            // btnOrdUsers
            // 
            this.btnOrdUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdUsers.FlatAppearance.BorderSize = 0;
            this.btnOrdUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdUsers.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOrdUsers.Location = new System.Drawing.Point(1, 398);
            this.btnOrdUsers.Name = "btnOrdUsers";
            this.btnOrdUsers.Size = new System.Drawing.Size(197, 33);
            this.btnOrdUsers.TabIndex = 14;
            this.btnOrdUsers.Text = "     Users";
            this.btnOrdUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdUsers.UseVisualStyleBackColor = false;
            // 
            // btnOrdStocks
            // 
            this.btnOrdStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdStocks.FlatAppearance.BorderSize = 0;
            this.btnOrdStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdStocks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdStocks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOrdStocks.Location = new System.Drawing.Point(2, 179);
            this.btnOrdStocks.Name = "btnOrdStocks";
            this.btnOrdStocks.Size = new System.Drawing.Size(197, 33);
            this.btnOrdStocks.TabIndex = 13;
            this.btnOrdStocks.Text = "     Stocks";
            this.btnOrdStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdStocks.UseVisualStyleBackColor = false;
            this.btnOrdStocks.Click += new System.EventHandler(this.btnOrdStocks_Click);
            // 
            // btnOrdSales
            // 
            this.btnOrdSales.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdSales.FlatAppearance.BorderSize = 0;
            this.btnOrdSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdSales.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdSales.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOrdSales.Location = new System.Drawing.Point(1, 135);
            this.btnOrdSales.Name = "btnOrdSales";
            this.btnOrdSales.Size = new System.Drawing.Size(197, 33);
            this.btnOrdSales.TabIndex = 12;
            this.btnOrdSales.Text = "     Sales Report";
            this.btnOrdSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdSales.UseVisualStyleBackColor = false;
            this.btnOrdSales.Click += new System.EventHandler(this.btnOrdSales_Click);
            // 
            // btnOrdInventory
            // 
            this.btnOrdInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdInventory.FlatAppearance.BorderSize = 0;
            this.btnOrdInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdInventory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdInventory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOrdInventory.Location = new System.Drawing.Point(1, 91);
            this.btnOrdInventory.Name = "btnOrdInventory";
            this.btnOrdInventory.Size = new System.Drawing.Size(197, 33);
            this.btnOrdInventory.TabIndex = 11;
            this.btnOrdInventory.Text = "     Inventory";
            this.btnOrdInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdInventory.UseVisualStyleBackColor = false;
            this.btnOrdInventory.Click += new System.EventHandler(this.btnOrdInventory_Click);
            // 
            // btnOrdOrders
            // 
            this.btnOrdOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdOrders.FlatAppearance.BorderSize = 0;
            this.btnOrdOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdOrders.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOrdOrders.Location = new System.Drawing.Point(1, 47);
            this.btnOrdOrders.Name = "btnOrdOrders";
            this.btnOrdOrders.Size = new System.Drawing.Size(197, 33);
            this.btnOrdOrders.TabIndex = 10;
            this.btnOrdOrders.Text = "     Orders";
            this.btnOrdOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdOrders.UseVisualStyleBackColor = false;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel2.Controls.Add(this.label2);
            this.guna2GradientPanel2.Controls.Add(this.pictureBox3);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.LightPink;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1084, 66);
            this.guna2GradientPanel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(56, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(125, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dashboard";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::InventorySystem.Properties.Resources.icons8_menu_50;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(16, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrders";
            this.Text = "Orders";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbStat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnDeleteSo;
        private System.Windows.Forms.Button btnUpdateSo;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnOrdLogout;
        private System.Windows.Forms.Button btnOrdSettings;
        private System.Windows.Forms.Button btnOrdUsers;
        private System.Windows.Forms.Button btnOrdStocks;
        private System.Windows.Forms.Button btnOrdSales;
        private System.Windows.Forms.Button btnOrdInventory;
        private System.Windows.Forms.Button btnOrdOrders;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickup;
    }
}