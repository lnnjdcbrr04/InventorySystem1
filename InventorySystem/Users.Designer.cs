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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnUserReports = new System.Windows.Forms.Button();
            this.btnUserDsh = new System.Windows.Forms.Button();
            this.btnUserLogout = new System.Windows.Forms.Button();
            this.btnUserUsers = new System.Windows.Forms.Button();
            this.btnUserOrders = new System.Windows.Forms.Button();
            this.btnUserTrans = new System.Windows.Forms.Button();
            this.btnUserStocks = new System.Windows.Forms.Button();
            this.btnUserProd = new System.Windows.Forms.Button();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelStaff = new System.Windows.Forms.Button();
            this.btnUpdStaff = new System.Windows.Forms.Button();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(215, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "USERS MANAGEMENT";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnUserReports);
            this.guna2GradientPanel1.Controls.Add(this.btnUserDsh);
            this.guna2GradientPanel1.Controls.Add(this.btnUserLogout);
            this.guna2GradientPanel1.Controls.Add(this.btnUserUsers);
            this.guna2GradientPanel1.Controls.Add(this.btnUserOrders);
            this.guna2GradientPanel1.Controls.Add(this.btnUserTrans);
            this.guna2GradientPanel1.Controls.Add(this.btnUserStocks);
            this.guna2GradientPanel1.Controls.Add(this.btnUserProd);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightPink;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 60);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(200, 551);
            this.guna2GradientPanel1.TabIndex = 80;
            // 
            // btnUserReports
            // 
            this.btnUserReports.BackColor = System.Drawing.Color.Transparent;
            this.btnUserReports.FlatAppearance.BorderSize = 0;
            this.btnUserReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserReports.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserReports.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUserReports.Location = new System.Drawing.Point(2, 266);
            this.btnUserReports.Name = "btnUserReports";
            this.btnUserReports.Size = new System.Drawing.Size(197, 33);
            this.btnUserReports.TabIndex = 18;
            this.btnUserReports.Text = "     Reports";
            this.btnUserReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserReports.UseVisualStyleBackColor = false;
            this.btnUserReports.Click += new System.EventHandler(this.btnUserReports_Click);
            // 
            // btnUserDsh
            // 
            this.btnUserDsh.BackColor = System.Drawing.Color.Transparent;
            this.btnUserDsh.FlatAppearance.BorderSize = 0;
            this.btnUserDsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDsh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDsh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUserDsh.Location = new System.Drawing.Point(1, 46);
            this.btnUserDsh.Name = "btnUserDsh";
            this.btnUserDsh.Size = new System.Drawing.Size(197, 33);
            this.btnUserDsh.TabIndex = 17;
            this.btnUserDsh.Text = "     Dashboard";
            this.btnUserDsh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDsh.UseVisualStyleBackColor = false;
            this.btnUserDsh.Click += new System.EventHandler(this.btnUserDsh_Click);
            // 
            // btnUserLogout
            // 
            this.btnUserLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnUserLogout.FlatAppearance.BorderSize = 0;
            this.btnUserLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLogout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUserLogout.Location = new System.Drawing.Point(1, 486);
            this.btnUserLogout.Name = "btnUserLogout";
            this.btnUserLogout.Size = new System.Drawing.Size(197, 33);
            this.btnUserLogout.TabIndex = 16;
            this.btnUserLogout.Text = "     Logout";
            this.btnUserLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserLogout.UseVisualStyleBackColor = false;
            this.btnUserLogout.Click += new System.EventHandler(this.btnUserLogout_Click);
            // 
            // btnUserUsers
            // 
            this.btnUserUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUserUsers.FlatAppearance.BorderSize = 0;
            this.btnUserUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserUsers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserUsers.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUserUsers.Location = new System.Drawing.Point(1, 442);
            this.btnUserUsers.Name = "btnUserUsers";
            this.btnUserUsers.Size = new System.Drawing.Size(197, 33);
            this.btnUserUsers.TabIndex = 14;
            this.btnUserUsers.Text = "     Users";
            this.btnUserUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserUsers.UseVisualStyleBackColor = false;
            this.btnUserUsers.Click += new System.EventHandler(this.btnUserUsers_Click);
            // 
            // btnUserOrders
            // 
            this.btnUserOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnUserOrders.FlatAppearance.BorderSize = 0;
            this.btnUserOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserOrders.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUserOrders.Location = new System.Drawing.Point(2, 222);
            this.btnUserOrders.Name = "btnUserOrders";
            this.btnUserOrders.Size = new System.Drawing.Size(197, 33);
            this.btnUserOrders.TabIndex = 13;
            this.btnUserOrders.Text = "     Orders";
            this.btnUserOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserOrders.UseVisualStyleBackColor = false;
            this.btnUserOrders.Click += new System.EventHandler(this.btnUserOrders_Click);
            // 
            // btnUserTrans
            // 
            this.btnUserTrans.BackColor = System.Drawing.Color.Transparent;
            this.btnUserTrans.FlatAppearance.BorderSize = 0;
            this.btnUserTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserTrans.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserTrans.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUserTrans.Location = new System.Drawing.Point(1, 178);
            this.btnUserTrans.Name = "btnUserTrans";
            this.btnUserTrans.Size = new System.Drawing.Size(197, 33);
            this.btnUserTrans.TabIndex = 12;
            this.btnUserTrans.Text = "     Transaction";
            this.btnUserTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserTrans.UseVisualStyleBackColor = false;
            this.btnUserTrans.Click += new System.EventHandler(this.btnUserTrans_Click);
            // 
            // btnUserStocks
            // 
            this.btnUserStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnUserStocks.FlatAppearance.BorderSize = 0;
            this.btnUserStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserStocks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserStocks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUserStocks.Location = new System.Drawing.Point(1, 134);
            this.btnUserStocks.Name = "btnUserStocks";
            this.btnUserStocks.Size = new System.Drawing.Size(197, 33);
            this.btnUserStocks.TabIndex = 11;
            this.btnUserStocks.Text = "     Stocks";
            this.btnUserStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserStocks.UseVisualStyleBackColor = false;
            this.btnUserStocks.Click += new System.EventHandler(this.btnUserStocks_Click);
            // 
            // btnUserProd
            // 
            this.btnUserProd.BackColor = System.Drawing.Color.Transparent;
            this.btnUserProd.FlatAppearance.BorderSize = 0;
            this.btnUserProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUserProd.Location = new System.Drawing.Point(1, 90);
            this.btnUserProd.Name = "btnUserProd";
            this.btnUserProd.Size = new System.Drawing.Size(197, 33);
            this.btnUserProd.TabIndex = 10;
            this.btnUserProd.Text = "     Products";
            this.btnUserProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserProd.UseVisualStyleBackColor = false;
            this.btnUserProd.Click += new System.EventHandler(this.btnUserProd_Click);
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
            this.guna2GradientPanel2.TabIndex = 79;
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.fullname,
            this.username,
            this.userPW,
            this.Role,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(275, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(694, 364);
            this.dataGridView1.TabIndex = 82;
            // 
            // userID
            // 
            this.userID.HeaderText = "User ID";
            this.userID.Name = "userID";
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.Width = 150;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.Width = 120;
            // 
            // userPW
            // 
            this.userPW.HeaderText = "Password";
            this.userPW.Name = "userPW";
            this.userPW.Width = 120;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btnCancelStaff
            // 
            this.btnCancelStaff.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancelStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelStaff.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelStaff.ForeColor = System.Drawing.Color.White;
            this.btnCancelStaff.Location = new System.Drawing.Point(908, 531);
            this.btnCancelStaff.Name = "btnCancelStaff";
            this.btnCancelStaff.Size = new System.Drawing.Size(91, 29);
            this.btnCancelStaff.TabIndex = 121;
            this.btnCancelStaff.Text = "Cancel";
            this.btnCancelStaff.UseVisualStyleBackColor = false;
            // 
            // btnUpdStaff
            // 
            this.btnUpdStaff.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdStaff.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdStaff.ForeColor = System.Drawing.Color.White;
            this.btnUpdStaff.Location = new System.Drawing.Point(811, 531);
            this.btnUpdStaff.Name = "btnUpdStaff";
            this.btnUpdStaff.Size = new System.Drawing.Size(91, 29);
            this.btnUpdStaff.TabIndex = 120;
            this.btnUpdStaff.Text = "Update";
            this.btnUpdStaff.UseVisualStyleBackColor = false;
            // 
            // btnSaveStaff
            // 
            this.btnSaveStaff.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSaveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStaff.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStaff.ForeColor = System.Drawing.Color.White;
            this.btnSaveStaff.Location = new System.Drawing.Point(714, 531);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(91, 29);
            this.btnSaveStaff.TabIndex = 119;
            this.btnSaveStaff.Text = "Save";
            this.btnSaveStaff.UseVisualStyleBackColor = false;
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
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.btnCancelStaff);
            this.Controls.Add(this.btnUpdStaff);
            this.Controls.Add(this.btnSaveStaff);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Button btnUserReports;
        private System.Windows.Forms.Button btnUserDsh;
        private System.Windows.Forms.Button btnUserLogout;
        private System.Windows.Forms.Button btnUserUsers;
        private System.Windows.Forms.Button btnUserOrders;
        private System.Windows.Forms.Button btnUserTrans;
        private System.Windows.Forms.Button btnUserStocks;
        private System.Windows.Forms.Button btnUserProd;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnCancelStaff;
        private System.Windows.Forms.Button btnUpdStaff;
        private System.Windows.Forms.Button btnSaveStaff;
    }
}