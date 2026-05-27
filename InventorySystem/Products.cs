using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnProdDsh_Click(object sender, EventArgs e)
        {
            frmDashboard dsh = new frmDashboard();
            dsh.Show();
            this.Close();
        }

        private void btnProdProducts_Click(object sender, EventArgs e)
        {
            frmProducts dsh = new frmProducts();
            dsh.Show();
            this.Close();
        }

        private void btnProdStocks_Click(object sender, EventArgs e)
        {
            frmStocks prod = new frmStocks();
            prod.Show();
            this.Close();
        }

        private void btnProdTrans_Click(object sender, EventArgs e)
        {
            frmTransaction prod = new frmTransaction();
            prod.Show();
            this.Close();
        }

        private void btnProdOrders_Click(object sender, EventArgs e)
        {
            frmProducts prod = new frmProducts();
            prod.Show();
            this.Close();
        }

        private void btnProdReports_Click(object sender, EventArgs e)
        {
            frmReport prod = new frmReport();
            prod.Show();
            this.Close();
        }

        private void btnProdUsers_Click(object sender, EventArgs e)
        {
            frmUsers prod = new frmUsers();
            prod.Show();
            this.Close();
        }

        private void btnProdLogout_Click(object sender, EventArgs e)
        {
           frmLogin prod = new frmLogin();
            prod.Show();
            this.Close();
        }
    }
}
