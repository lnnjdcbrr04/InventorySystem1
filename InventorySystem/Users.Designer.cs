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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
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
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(846, 540);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(91, 29);
            this.btnEditUser.TabIndex = 22;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = false;
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
            this.guna2GradientPanel1.TabIndex = 25;
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
            this.guna2GradientPanel2.Controls.Add(this.label1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.LightPink;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1068, 60);
            this.guna2GradientPanel2.TabIndex = 24;
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
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Users";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1068, 611);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsers";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
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
        private System.Windows.Forms.Label label1;
    }
}