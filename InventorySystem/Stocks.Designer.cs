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
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnStkReports = new System.Windows.Forms.Button();
            this.btnStkDsh = new System.Windows.Forms.Button();
            this.btnStkLogout = new System.Windows.Forms.Button();
            this.btnStkUsers = new System.Windows.Forms.Button();
            this.btnStkOrders = new System.Windows.Forms.Button();
            this.btnStkTrans = new System.Windows.Forms.Button();
            this.btnStkStocks = new System.Windows.Forms.Button();
            this.btnStkProducts = new System.Windows.Forms.Button();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockOut = new System.Windows.Forms.TextBox();
            this.txtStkProduct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStockIn = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThresh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStkRelease = new System.Windows.Forms.Button();
            this.btnUpdStocks = new System.Windows.Forms.Button();
            this.btnChckAlert = new System.Windows.Forms.Button();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(215, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "STOCK MONITORING";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnStkReports);
            this.guna2GradientPanel1.Controls.Add(this.btnStkDsh);
            this.guna2GradientPanel1.Controls.Add(this.btnStkLogout);
            this.guna2GradientPanel1.Controls.Add(this.btnStkUsers);
            this.guna2GradientPanel1.Controls.Add(this.btnStkOrders);
            this.guna2GradientPanel1.Controls.Add(this.btnStkTrans);
            this.guna2GradientPanel1.Controls.Add(this.btnStkStocks);
            this.guna2GradientPanel1.Controls.Add(this.btnStkProducts);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightPink;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 60);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 551);
            this.guna2GradientPanel1.TabIndex = 77;
            // 
            // btnStkReports
            // 
            this.btnStkReports.BackColor = System.Drawing.Color.Transparent;
            this.btnStkReports.FlatAppearance.BorderSize = 0;
            this.btnStkReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkReports.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkReports.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStkReports.Location = new System.Drawing.Point(2, 266);
            this.btnStkReports.Name = "btnStkReports";
            this.btnStkReports.Size = new System.Drawing.Size(197, 33);
            this.btnStkReports.TabIndex = 18;
            this.btnStkReports.Text = "     Reports";
            this.btnStkReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStkReports.UseVisualStyleBackColor = false;
            this.btnStkReports.Click += new System.EventHandler(this.btnStkReports_Click);
            // 
            // btnStkDsh
            // 
            this.btnStkDsh.BackColor = System.Drawing.Color.Transparent;
            this.btnStkDsh.FlatAppearance.BorderSize = 0;
            this.btnStkDsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkDsh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkDsh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStkDsh.Location = new System.Drawing.Point(1, 46);
            this.btnStkDsh.Name = "btnStkDsh";
            this.btnStkDsh.Size = new System.Drawing.Size(197, 33);
            this.btnStkDsh.TabIndex = 17;
            this.btnStkDsh.Text = "     Dashboard";
            this.btnStkDsh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStkDsh.UseVisualStyleBackColor = false;
            this.btnStkDsh.Click += new System.EventHandler(this.btnDsh_Click);
            // 
            // btnStkLogout
            // 
            this.btnStkLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnStkLogout.FlatAppearance.BorderSize = 0;
            this.btnStkLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkLogout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStkLogout.Location = new System.Drawing.Point(1, 486);
            this.btnStkLogout.Name = "btnStkLogout";
            this.btnStkLogout.Size = new System.Drawing.Size(197, 33);
            this.btnStkLogout.TabIndex = 16;
            this.btnStkLogout.Text = "     Logout";
            this.btnStkLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStkLogout.UseVisualStyleBackColor = false;
            this.btnStkLogout.Click += new System.EventHandler(this.btnStkLogout_Click);
            // 
            // btnStkUsers
            // 
            this.btnStkUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnStkUsers.FlatAppearance.BorderSize = 0;
            this.btnStkUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkUsers.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStkUsers.Location = new System.Drawing.Point(1, 442);
            this.btnStkUsers.Name = "btnStkUsers";
            this.btnStkUsers.Size = new System.Drawing.Size(197, 33);
            this.btnStkUsers.TabIndex = 14;
            this.btnStkUsers.Text = "     Users";
            this.btnStkUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStkUsers.UseVisualStyleBackColor = false;
            this.btnStkUsers.Click += new System.EventHandler(this.btnStkUsers_Click);
            // 
            // btnStkOrders
            // 
            this.btnStkOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnStkOrders.FlatAppearance.BorderSize = 0;
            this.btnStkOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkOrders.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStkOrders.Location = new System.Drawing.Point(2, 222);
            this.btnStkOrders.Name = "btnStkOrders";
            this.btnStkOrders.Size = new System.Drawing.Size(197, 33);
            this.btnStkOrders.TabIndex = 13;
            this.btnStkOrders.Text = "     Orders";
            this.btnStkOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStkOrders.UseVisualStyleBackColor = false;
            this.btnStkOrders.Click += new System.EventHandler(this.btnStkOrders_Click);
            // 
            // btnStkTrans
            // 
            this.btnStkTrans.BackColor = System.Drawing.Color.Transparent;
            this.btnStkTrans.FlatAppearance.BorderSize = 0;
            this.btnStkTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkTrans.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkTrans.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStkTrans.Location = new System.Drawing.Point(1, 178);
            this.btnStkTrans.Name = "btnStkTrans";
            this.btnStkTrans.Size = new System.Drawing.Size(197, 33);
            this.btnStkTrans.TabIndex = 12;
            this.btnStkTrans.Text = "     Transaction";
            this.btnStkTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStkTrans.UseVisualStyleBackColor = false;
            this.btnStkTrans.Click += new System.EventHandler(this.btnStkTrans_Click);
            // 
            // btnStkStocks
            // 
            this.btnStkStocks.BackColor = System.Drawing.Color.MistyRose;
            this.btnStkStocks.FlatAppearance.BorderSize = 0;
            this.btnStkStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkStocks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkStocks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStkStocks.Location = new System.Drawing.Point(1, 134);
            this.btnStkStocks.Name = "btnStkStocks";
            this.btnStkStocks.Size = new System.Drawing.Size(197, 33);
            this.btnStkStocks.TabIndex = 11;
            this.btnStkStocks.Text = "     Stocks";
            this.btnStkStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStkStocks.UseVisualStyleBackColor = false;
            this.btnStkStocks.Click += new System.EventHandler(this.btnStkStocks_Click);
            // 
            // btnStkProducts
            // 
            this.btnStkProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnStkProducts.FlatAppearance.BorderSize = 0;
            this.btnStkProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkProducts.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkProducts.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStkProducts.Location = new System.Drawing.Point(1, 90);
            this.btnStkProducts.Name = "btnStkProducts";
            this.btnStkProducts.Size = new System.Drawing.Size(197, 33);
            this.btnStkProducts.TabIndex = 10;
            this.btnStkProducts.Text = "     Products";
            this.btnStkProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStkProducts.UseVisualStyleBackColor = false;
            this.btnStkProducts.Click += new System.EventHandler(this.btnStkProducts_Click);
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
            this.guna2GradientPanel2.TabIndex = 76;
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
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stocks";
            // 
            // txtStockOut
            // 
            this.txtStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockOut.Location = new System.Drawing.Point(373, 215);
            this.txtStockOut.Multiline = true;
            this.txtStockOut.Name = "txtStockOut";
            this.txtStockOut.Size = new System.Drawing.Size(138, 22);
            this.txtStockOut.TabIndex = 88;
            // 
            // txtStkProduct
            // 
            this.txtStkProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStkProduct.Location = new System.Drawing.Point(373, 150);
            this.txtStkProduct.Multiline = true;
            this.txtStkProduct.Name = "txtStkProduct";
            this.txtStkProduct.Size = new System.Drawing.Size(138, 22);
            this.txtStkProduct.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(293, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 86;
            this.label10.Text = "Product:";
            // 
            // cmbStockIn
            // 
            this.cmbStockIn.FormattingEnabled = true;
            this.cmbStockIn.Location = new System.Drawing.Point(373, 183);
            this.cmbStockIn.Name = "cmbStockIn";
            this.cmbStockIn.Size = new System.Drawing.Size(138, 21);
            this.cmbStockIn.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(276, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 79;
            this.label8.Text = "Stock Out:";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.Color.White;
            this.btnAddStock.Location = new System.Drawing.Point(545, 242);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(91, 29);
            this.btnAddStock.TabIndex = 82;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(289, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 84;
            this.label9.Text = "Stock In:";
            // 
            // txtThresh
            // 
            this.txtThresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThresh.Location = new System.Drawing.Point(373, 249);
            this.txtThresh.Multiline = true;
            this.txtThresh.Name = "txtThresh";
            this.txtThresh.Size = new System.Drawing.Size(138, 22);
            this.txtThresh.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.Location = new System.Drawing.Point(277, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 80;
            this.label11.Text = "Threshold:";
            // 
            // btnStkRelease
            // 
            this.btnStkRelease.BackColor = System.Drawing.Color.RosyBrown;
            this.btnStkRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStkRelease.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStkRelease.ForeColor = System.Drawing.Color.White;
            this.btnStkRelease.Location = new System.Drawing.Point(642, 242);
            this.btnStkRelease.Name = "btnStkRelease";
            this.btnStkRelease.Size = new System.Drawing.Size(91, 29);
            this.btnStkRelease.TabIndex = 83;
            this.btnStkRelease.Text = "Release";
            this.btnStkRelease.UseVisualStyleBackColor = false;
            // 
            // btnUpdStocks
            // 
            this.btnUpdStocks.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdStocks.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdStocks.ForeColor = System.Drawing.Color.White;
            this.btnUpdStocks.Location = new System.Drawing.Point(739, 242);
            this.btnUpdStocks.Name = "btnUpdStocks";
            this.btnUpdStocks.Size = new System.Drawing.Size(91, 29);
            this.btnUpdStocks.TabIndex = 89;
            this.btnUpdStocks.Text = "Update";
            this.btnUpdStocks.UseVisualStyleBackColor = false;
            // 
            // btnChckAlert
            // 
            this.btnChckAlert.BackColor = System.Drawing.Color.RosyBrown;
            this.btnChckAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChckAlert.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChckAlert.ForeColor = System.Drawing.Color.White;
            this.btnChckAlert.Location = new System.Drawing.Point(836, 242);
            this.btnChckAlert.Name = "btnChckAlert";
            this.btnChckAlert.Size = new System.Drawing.Size(91, 29);
            this.btnChckAlert.TabIndex = 90;
            this.btnChckAlert.Text = "Check Alert";
            this.btnChckAlert.UseVisualStyleBackColor = false;
            // 
            // dgvStocks
            // 
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Location = new System.Drawing.Point(250, 337);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.Size = new System.Drawing.Size(763, 150);
            this.dgvStocks.TabIndex = 91;
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dgvStocks);
            this.Controls.Add(this.btnChckAlert);
            this.Controls.Add(this.btnUpdStocks);
            this.Controls.Add(this.txtStockOut);
            this.Controls.Add(this.txtStkProduct);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbStockIn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtThresh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnStkRelease);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnStkReports;
        private System.Windows.Forms.Button btnStkDsh;
        private System.Windows.Forms.Button btnStkLogout;
        private System.Windows.Forms.Button btnStkUsers;
        private System.Windows.Forms.Button btnStkOrders;
        private System.Windows.Forms.Button btnStkTrans;
        private System.Windows.Forms.Button btnStkStocks;
        private System.Windows.Forms.Button btnStkProducts;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockOut;
        private System.Windows.Forms.TextBox txtStkProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbStockIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThresh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStkRelease;
        private System.Windows.Forms.Button btnUpdStocks;
        private System.Windows.Forms.Button btnChckAlert;
        private System.Windows.Forms.DataGridView dgvStocks;
    }
}