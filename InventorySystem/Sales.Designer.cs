namespace InventorySystem
{
    partial class frmSales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.grpSlsChart = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlMonthlySls = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlWeeklySls = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDailySls = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSlsFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
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
            this.grpSlsChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.pnlMonthlySls.SuspendLayout();
            this.pnlWeeklySls.SuspendLayout();
            this.pnlDailySls.SuspendLayout();
            this.grpSlsFilter.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSlsChart
            // 
            this.grpSlsChart.BackColor = System.Drawing.Color.MistyRose;
            this.grpSlsChart.BorderRadius = 10;
            this.grpSlsChart.Controls.Add(this.chartSales);
            this.grpSlsChart.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpSlsChart.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.grpSlsChart.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSlsChart.ForeColor = System.Drawing.Color.SaddleBrown;
            this.grpSlsChart.Location = new System.Drawing.Point(206, 272);
            this.grpSlsChart.Name = "grpSlsChart";
            this.grpSlsChart.Size = new System.Drawing.Size(491, 299);
            this.grpSlsChart.TabIndex = 6;
            this.grpSlsChart.Text = "Sales Chart";
            this.grpSlsChart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chartSales
            // 
            this.chartSales.BackColor = System.Drawing.Color.Transparent;
            this.chartSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartSales.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartSales.BorderlineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSales.Legends.Add(legend2);
            this.chartSales.Location = new System.Drawing.Point(7, 38);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartSales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.RosyBrown,
        System.Drawing.Color.LightPink};
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Monday";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Tuesday";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Wednesday";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Thursday";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Friday";
            this.chartSales.Series.Add(series6);
            this.chartSales.Series.Add(series7);
            this.chartSales.Series.Add(series8);
            this.chartSales.Series.Add(series9);
            this.chartSales.Series.Add(series10);
            this.chartSales.Size = new System.Drawing.Size(473, 258);
            this.chartSales.TabIndex = 1;
            this.chartSales.Text = "chart1";
            // 
            // pnlMonthlySls
            // 
            this.pnlMonthlySls.BackColor = System.Drawing.Color.Transparent;
            this.pnlMonthlySls.Controls.Add(this.label5);
            this.pnlMonthlySls.FillColor = System.Drawing.Color.White;
            this.pnlMonthlySls.Location = new System.Drawing.Point(525, 166);
            this.pnlMonthlySls.Name = "pnlMonthlySls";
            this.pnlMonthlySls.Radius = 5;
            this.pnlMonthlySls.ShadowColor = System.Drawing.Color.Black;
            this.pnlMonthlySls.Size = new System.Drawing.Size(145, 100);
            this.pnlMonthlySls.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monthly";
            // 
            // pnlWeeklySls
            // 
            this.pnlWeeklySls.BackColor = System.Drawing.Color.Transparent;
            this.pnlWeeklySls.Controls.Add(this.label3);
            this.pnlWeeklySls.FillColor = System.Drawing.Color.White;
            this.pnlWeeklySls.Location = new System.Drawing.Point(366, 166);
            this.pnlWeeklySls.Name = "pnlWeeklySls";
            this.pnlWeeklySls.Radius = 5;
            this.pnlWeeklySls.ShadowColor = System.Drawing.Color.Black;
            this.pnlWeeklySls.Size = new System.Drawing.Size(145, 100);
            this.pnlWeeklySls.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weekly";
            // 
            // pnlDailySls
            // 
            this.pnlDailySls.BackColor = System.Drawing.Color.Transparent;
            this.pnlDailySls.Controls.Add(this.label1);
            this.pnlDailySls.FillColor = System.Drawing.Color.White;
            this.pnlDailySls.Location = new System.Drawing.Point(207, 167);
            this.pnlDailySls.Name = "pnlDailySls";
            this.pnlDailySls.Radius = 5;
            this.pnlDailySls.ShadowColor = System.Drawing.Color.Black;
            this.pnlDailySls.Size = new System.Drawing.Size(145, 100);
            this.pnlDailySls.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Daily";
            // 
            // grpSlsFilter
            // 
            this.grpSlsFilter.BackColor = System.Drawing.Color.MistyRose;
            this.grpSlsFilter.BorderRadius = 10;
            this.grpSlsFilter.Controls.Add(this.guna2TileButton1);
            this.grpSlsFilter.Controls.Add(this.guna2DateTimePicker1);
            this.grpSlsFilter.Controls.Add(this.guna2ComboBox1);
            this.grpSlsFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpSlsFilter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.grpSlsFilter.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSlsFilter.ForeColor = System.Drawing.Color.SaddleBrown;
            this.grpSlsFilter.Location = new System.Drawing.Point(206, 72);
            this.grpSlsFilter.Name = "grpSlsFilter";
            this.grpSlsFilter.Size = new System.Drawing.Size(453, 88);
            this.grpSlsFilter.TabIndex = 4;
            this.grpSlsFilter.Text = "Sales Report";
            this.grpSlsFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.RosyBrown;
            this.guna2TileButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Location = new System.Drawing.Point(338, 47);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(98, 24);
            this.guna2TileButton1.TabIndex = 2;
            this.guna2TileButton1.Text = "Generate";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(138, 47);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(187, 24);
            this.guna2DateTimePicker1.TabIndex = 1;
            this.guna2DateTimePicker1.Value = new System.DateTime(2026, 5, 18, 17, 40, 8, 994);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.guna2ComboBox1.ItemHeight = 18;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(15, 47);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(112, 24);
            this.guna2ComboBox1.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.guna2GroupBox1.Location = new System.Drawing.Point(703, 72);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(369, 496);
            this.guna2GroupBox1.TabIndex = 19;
            this.guna2GroupBox1.Text = "Sales Record";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.guna2GradientPanel1.TabIndex = 21;
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
            this.guna2GradientPanel2.TabIndex = 20;
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
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sales";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.pnlMonthlySls);
            this.Controls.Add(this.pnlWeeklySls);
            this.Controls.Add(this.pnlDailySls);
            this.Controls.Add(this.grpSlsChart);
            this.Controls.Add(this.grpSlsFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.grpSlsChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.pnlMonthlySls.ResumeLayout(false);
            this.pnlMonthlySls.PerformLayout();
            this.pnlWeeklySls.ResumeLayout(false);
            this.pnlWeeklySls.PerformLayout();
            this.pnlDailySls.ResumeLayout(false);
            this.pnlDailySls.PerformLayout();
            this.grpSlsFilter.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox grpSlsFilter;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlMonthlySls;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlWeeklySls;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDailySls;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox grpSlsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
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