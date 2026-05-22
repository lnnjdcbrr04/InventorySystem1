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
            this.datePickup = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.btnDbLogout = new System.Windows.Forms.Button();
            this.btnDbSettings = new System.Windows.Forms.Button();
            this.btnDbUsers = new System.Windows.Forms.Button();
            this.btnDbStocks = new System.Windows.Forms.Button();
            this.btnDbSales = new System.Windows.Forms.Button();
            this.btnDbInventory = new System.Windows.Forms.Button();
            this.btnDbOrders = new System.Windows.Forms.Button();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.datePickup.Location = new System.Drawing.Point(317, 395);
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
            this.txtConNo.Location = new System.Drawing.Point(234, 220);
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
            this.label10.Location = new System.Drawing.Point(234, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Contact Number:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(234, 279);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(299, 21);
            this.cmbCategory.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(234, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Category:";
            // 
            // btnDeleteSo
            // 
            this.btnDeleteSo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSo.Location = new System.Drawing.Point(429, 533);
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
            this.btnUpdateSo.Location = new System.Drawing.Point(332, 533);
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
            this.btnAddOrder.Location = new System.Drawing.Point(235, 533);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(91, 29);
            this.btnAddOrder.TabIndex = 18;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // cmbStat
            // 
            this.cmbStat.FormattingEnabled = true;
            this.cmbStat.Location = new System.Drawing.Point(234, 482);
            this.cmbStat.Name = "cmbStat";
            this.cmbStat.Size = new System.Drawing.Size(186, 21);
            this.cmbStat.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(234, 458);
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
            this.label6.Location = new System.Drawing.Point(327, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pickup Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(234, 395);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(78, 22);
            this.txtQuantity.TabIndex = 13;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(234, 337);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(299, 21);
            this.cmbProduct.TabIndex = 12;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(234, 161);
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
            this.label5.Location = new System.Drawing.Point(234, 371);
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
            this.label4.Location = new System.Drawing.Point(234, 313);
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
            this.label3.Location = new System.Drawing.Point(234, 137);
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
            this.label1.Location = new System.Drawing.Point(272, 91);
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
            this.label8.Location = new System.Drawing.Point(23, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Orders";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnDbLogout);
            this.guna2GradientPanel1.Controls.Add(this.btnDbSettings);
            this.guna2GradientPanel1.Controls.Add(this.btnDbUsers);
            this.guna2GradientPanel1.Controls.Add(this.btnDbStocks);
            this.guna2GradientPanel1.Controls.Add(this.btnDbSales);
            this.guna2GradientPanel1.Controls.Add(this.btnDbInventory);
            this.guna2GradientPanel1.Controls.Add(this.btnDbOrders);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightPink;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 60);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 551);
            this.guna2GradientPanel1.TabIndex = 14;
            // 
            // btnDbLogout
            // 
            this.btnDbLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnDbLogout.FlatAppearance.BorderSize = 0;
            this.btnDbLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbLogout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDbLogout.Location = new System.Drawing.Point(1, 486);
            this.btnDbLogout.Name = "btnDbLogout";
            this.btnDbLogout.Size = new System.Drawing.Size(197, 33);
            this.btnDbLogout.TabIndex = 16;
            this.btnDbLogout.Text = "     Logout";
            this.btnDbLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbLogout.UseVisualStyleBackColor = false;
            // 
            // btnDbSettings
            // 
            this.btnDbSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnDbSettings.FlatAppearance.BorderSize = 0;
            this.btnDbSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbSettings.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbSettings.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDbSettings.Location = new System.Drawing.Point(1, 442);
            this.btnDbSettings.Name = "btnDbSettings";
            this.btnDbSettings.Size = new System.Drawing.Size(197, 33);
            this.btnDbSettings.TabIndex = 15;
            this.btnDbSettings.Text = "     Settings";
            this.btnDbSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbSettings.UseVisualStyleBackColor = false;
            // 
            // btnDbUsers
            // 
            this.btnDbUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnDbUsers.FlatAppearance.BorderSize = 0;
            this.btnDbUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbUsers.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDbUsers.Location = new System.Drawing.Point(1, 398);
            this.btnDbUsers.Name = "btnDbUsers";
            this.btnDbUsers.Size = new System.Drawing.Size(197, 33);
            this.btnDbUsers.TabIndex = 14;
            this.btnDbUsers.Text = "     Users";
            this.btnDbUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbUsers.UseVisualStyleBackColor = false;
            // 
            // btnDbStocks
            // 
            this.btnDbStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnDbStocks.FlatAppearance.BorderSize = 0;
            this.btnDbStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbStocks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbStocks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDbStocks.Location = new System.Drawing.Point(2, 179);
            this.btnDbStocks.Name = "btnDbStocks";
            this.btnDbStocks.Size = new System.Drawing.Size(197, 33);
            this.btnDbStocks.TabIndex = 13;
            this.btnDbStocks.Text = "     Stocks";
            this.btnDbStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbStocks.UseVisualStyleBackColor = false;
            // 
            // btnDbSales
            // 
            this.btnDbSales.BackColor = System.Drawing.Color.Transparent;
            this.btnDbSales.FlatAppearance.BorderSize = 0;
            this.btnDbSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbSales.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbSales.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDbSales.Location = new System.Drawing.Point(1, 135);
            this.btnDbSales.Name = "btnDbSales";
            this.btnDbSales.Size = new System.Drawing.Size(197, 33);
            this.btnDbSales.TabIndex = 12;
            this.btnDbSales.Text = "     Sales Report";
            this.btnDbSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbSales.UseVisualStyleBackColor = false;
            // 
            // btnDbInventory
            // 
            this.btnDbInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnDbInventory.FlatAppearance.BorderSize = 0;
            this.btnDbInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbInventory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbInventory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDbInventory.Location = new System.Drawing.Point(1, 91);
            this.btnDbInventory.Name = "btnDbInventory";
            this.btnDbInventory.Size = new System.Drawing.Size(197, 33);
            this.btnDbInventory.TabIndex = 11;
            this.btnDbInventory.Text = "     Inventory";
            this.btnDbInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbInventory.UseVisualStyleBackColor = false;
            // 
            // btnDbOrders
            // 
            this.btnDbOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnDbOrders.FlatAppearance.BorderSize = 0;
            this.btnDbOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbOrders.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDbOrders.Location = new System.Drawing.Point(1, 47);
            this.btnDbOrders.Name = "btnDbOrders";
            this.btnDbOrders.Size = new System.Drawing.Size(197, 33);
            this.btnDbOrders.TabIndex = 10;
            this.btnDbOrders.Text = "     Orders";
            this.btnDbOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbOrders.UseVisualStyleBackColor = false;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel2.Controls.Add(this.label2);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(66, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orders";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.datePickup);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.txtConNo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStat);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateSo);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.btnDeleteSo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrders";
            this.Text = "Orders";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickup;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnDbLogout;
        private System.Windows.Forms.Button btnDbSettings;
        private System.Windows.Forms.Button btnDbUsers;
        private System.Windows.Forms.Button btnDbStocks;
        private System.Windows.Forms.Button btnDbSales;
        private System.Windows.Forms.Button btnDbInventory;
        private System.Windows.Forms.Button btnDbOrders;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}