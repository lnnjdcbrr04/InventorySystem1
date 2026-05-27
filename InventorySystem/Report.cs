using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnRpDsh_Click(object sender, EventArgs e)
        {
            frmDashboard rp = new frmDashboard();
            rp.Show();
            this.Close();
        }

        private void btnRpProd_Click(object sender, EventArgs e)
        {
            frmProducts rp = new frmProducts();
            rp.Show();
            this.Close();
        }

        private void btnRpStocks_Click(object sender, EventArgs e)
        {
            frmStocks rp = new frmStocks();
            rp.Show();
            this.Close();
        }

        private void btnRpTrans_Click(object sender, EventArgs e)
        {
            frmTransaction rp = new frmTransaction();
            rp.Show();
            this.Close();
        }

        private void btnRpOrders_Click(object sender, EventArgs e)
        {
            frmOrder rp = new frmOrder();
            rp.Show();
            this.Close();
        }

        private void btnRpReports_Click(object sender, EventArgs e)
        {
            frmReport rp = new frmReport();
            rp.Show();
            this.Close();
        }

        private void btnRpUsers_Click(object sender, EventArgs e)
        {
            frmUsers rp = new frmUsers();
            rp.Show();
            this.Close();
        }

        private void btnRpLogout_Click(object sender, EventArgs e)
        {
            frmLogin rp = new frmLogin();
            rp.Show();
            this.Close();
        }
    }
}
