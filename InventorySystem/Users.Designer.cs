namespace InventorySystem
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnUsrLogout = new System.Windows.Forms.Button();
            this.btnUsrSettings = new System.Windows.Forms.Button();
            this.btnUsrUsers = new System.Windows.Forms.Button();
            this.btnUsrStocks = new System.Windows.Forms.Button();
            this.btnUsrSales = new System.Windows.Forms.Button();
            this.btnUsrInventory = new System.Windows.Forms.Button();
            this.btnUsrOrders = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1068, 66);
            this.guna2GradientPanel2.TabIndex = 13;
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
            this.guna2GradientPanel1.Controls.Add(this.btnUsrLogout);
            this.guna2GradientPanel1.Controls.Add(this.btnUsrSettings);
            this.guna2GradientPanel1.Controls.Add(this.btnUsrUsers);
            this.guna2GradientPanel1.Controls.Add(this.btnUsrStocks);
            this.guna2GradientPanel1.Controls.Add(this.btnUsrSales);
            this.guna2GradientPanel1.Controls.Add(this.btnUsrInventory);
            this.guna2GradientPanel1.Controls.Add(this.btnUsrOrders);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightPink;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 66);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 545);
            this.guna2GradientPanel1.TabIndex = 14;
            // 
            // btnUsrLogout
            // 
            this.btnUsrLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnUsrLogout.FlatAppearance.BorderSize = 0;
            this.btnUsrLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrLogout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUsrLogout.Location = new System.Drawing.Point(1, 486);
            this.btnUsrLogout.Name = "btnUsrLogout";
            this.btnUsrLogout.Size = new System.Drawing.Size(197, 33);
            this.btnUsrLogout.TabIndex = 16;
            this.btnUsrLogout.Text = "     Logout";
            this.btnUsrLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsrLogout.UseVisualStyleBackColor = false;
            this.btnUsrLogout.Click += new System.EventHandler(this.btnUsrLogout_Click);
            // 
            // btnUsrSettings
            // 
            this.btnUsrSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnUsrSettings.FlatAppearance.BorderSize = 0;
            this.btnUsrSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrSettings.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrSettings.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUsrSettings.Location = new System.Drawing.Point(1, 442);
            this.btnUsrSettings.Name = "btnUsrSettings";
            this.btnUsrSettings.Size = new System.Drawing.Size(197, 33);
            this.btnUsrSettings.TabIndex = 15;
            this.btnUsrSettings.Text = "     Settings";
            this.btnUsrSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsrSettings.UseVisualStyleBackColor = false;
            // 
            // btnUsrUsers
            // 
            this.btnUsrUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsrUsers.FlatAppearance.BorderSize = 0;
            this.btnUsrUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrUsers.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUsrUsers.Location = new System.Drawing.Point(1, 398);
            this.btnUsrUsers.Name = "btnUsrUsers";
            this.btnUsrUsers.Size = new System.Drawing.Size(197, 33);
            this.btnUsrUsers.TabIndex = 14;
            this.btnUsrUsers.Text = "     Users";
            this.btnUsrUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsrUsers.UseVisualStyleBackColor = false;
            // 
            // btnUsrStocks
            // 
            this.btnUsrStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnUsrStocks.FlatAppearance.BorderSize = 0;
            this.btnUsrStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrStocks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrStocks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUsrStocks.Location = new System.Drawing.Point(2, 179);
            this.btnUsrStocks.Name = "btnUsrStocks";
            this.btnUsrStocks.Size = new System.Drawing.Size(197, 33);
            this.btnUsrStocks.TabIndex = 13;
            this.btnUsrStocks.Text = "     Stocks";
            this.btnUsrStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsrStocks.UseVisualStyleBackColor = false;
            this.btnUsrStocks.Click += new System.EventHandler(this.btnUsrStocks_Click);
            // 
            // btnUsrSales
            // 
            this.btnUsrSales.BackColor = System.Drawing.Color.Transparent;
            this.btnUsrSales.FlatAppearance.BorderSize = 0;
            this.btnUsrSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrSales.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrSales.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUsrSales.Location = new System.Drawing.Point(1, 135);
            this.btnUsrSales.Name = "btnUsrSales";
            this.btnUsrSales.Size = new System.Drawing.Size(197, 33);
            this.btnUsrSales.TabIndex = 12;
            this.btnUsrSales.Text = "     Sales Report";
            this.btnUsrSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsrSales.UseVisualStyleBackColor = false;
            this.btnUsrSales.Click += new System.EventHandler(this.btnUsrSales_Click);
            // 
            // btnUsrInventory
            // 
            this.btnUsrInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnUsrInventory.FlatAppearance.BorderSize = 0;
            this.btnUsrInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrInventory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrInventory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUsrInventory.Location = new System.Drawing.Point(1, 91);
            this.btnUsrInventory.Name = "btnUsrInventory";
            this.btnUsrInventory.Size = new System.Drawing.Size(197, 33);
            this.btnUsrInventory.TabIndex = 11;
            this.btnUsrInventory.Text = "     Inventory";
            this.btnUsrInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsrInventory.UseVisualStyleBackColor = false;
            this.btnUsrInventory.Click += new System.EventHandler(this.btnUsrInventory_Click);
            // 
            // btnUsrOrders
            // 
            this.btnUsrOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnUsrOrders.FlatAppearance.BorderSize = 0;
            this.btnUsrOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrOrders.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUsrOrders.Location = new System.Drawing.Point(1, 47);
            this.btnUsrOrders.Name = "btnUsrOrders";
            this.btnUsrOrders.Size = new System.Drawing.Size(197, 33);
            this.btnUsrOrders.TabIndex = 10;
            this.btnUsrOrders.Text = "     Orders";
            this.btnUsrOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsrOrders.UseVisualStyleBackColor = false;
            this.btnUsrOrders.Click += new System.EventHandler(this.btnUsrOrders_Click);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.EmpName,
            this.Username,
            this.Role,
            this.ContactNo,
            this.Status,
            this.LastLogin});
            this.dataGridView2.Location = new System.Drawing.Point(223, 113);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(818, 407);
            this.dataGridView2.TabIndex = 16;
            // 
            // UserId
            // 
            this.UserId.DividerWidth = 1;
            this.UserId.HeaderText = "User ID";
            this.UserId.Name = "UserId";
            this.UserId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserId.Width = 120;
            // 
            // EmpName
            // 
            this.EmpName.DividerWidth = 1;
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.Width = 140;
            // 
            // Username
            // 
            this.Username.DividerWidth = 1;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 120;
            // 
            // Role
            // 
            this.Role.DividerWidth = 1;
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // ContactNo
            // 
            this.ContactNo.DividerWidth = 1;
            this.ContactNo.HeaderText = "Contact Number";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Width = 125;
            // 
            // Status
            // 
            this.Status.DividerWidth = 1;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // LastLogin
            // 
            this.LastLogin.DividerWidth = 1;
            this.LastLogin.HeaderText = "Last Login";
            this.LastLogin.Name = "LastLogin";
            this.LastLogin.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(218, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Users";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(943, 540);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(91, 29);
            this.btnDeleteUser.TabIndex = 23;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(846, 540);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(91, 29);
            this.btnUpdateUser.TabIndex = 22;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(749, 540);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(91, 29);
            this.btnAddUser.TabIndex = 21;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1068, 611);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsers";
            this.Text = "Users";
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnUsrLogout;
        private System.Windows.Forms.Button btnUsrSettings;
        private System.Windows.Forms.Button btnUsrUsers;
        private System.Windows.Forms.Button btnUsrStocks;
        private System.Windows.Forms.Button btnUsrSales;
        private System.Windows.Forms.Button btnUsrInventory;
        private System.Windows.Forms.Button btnUsrOrders;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
    }
}