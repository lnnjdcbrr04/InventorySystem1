namespace InventorySystem
{
    partial class frmStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStocks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2ShadowPanel4.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(216, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Stocks Management";
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
            this.guna2GradientPanel1.TabIndex = 24;
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
            this.guna2GradientPanel2.TabIndex = 23;
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
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stocks";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductName,
            this.Category,
            this.Stock,
            this.Price,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(438, 179);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(634, 336);
            this.dataGridView1.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.Width = 120;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Width = 80;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(222, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(293, 129);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 22);
            this.txtSearch.TabIndex = 34;
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.label5);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(221, 415);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.Radius = 5;
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(200, 100);
            this.guna2ShadowPanel4.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Out of Stocks";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.label3);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(221, 297);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 5;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(200, 100);
            this.guna2ShadowPanel2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Low Stocks";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(221, 179);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(200, 100);
            this.guna2ShadowPanel1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(17, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Products";
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.guna2ShadowPanel4);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStocks";
            this.Text = "Stocks";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2ShadowPanel4.ResumeLayout(false);
            this.guna2ShadowPanel4.PerformLayout();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label4;
    }
}