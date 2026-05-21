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
    public partial class frmInv : Form
    {
        public frmInv()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInvOrders_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            orders.Show();
            this.Close();
        }

        private void btnInvSales_Click(object sender, EventArgs e)
        {
            frmSales sls = new frmSales();
            sls.Show();
            this.Close();
        }

        private void btnInvStocks_Click(object sender, EventArgs e)
        {
            frmStocks stk = new frmStocks();
            stk.Show();
            this.Close();
        }

        private void btnInvLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnInvUsers_Click(object sender, EventArgs e)
        {
            frmUsers usr = new frmUsers();
            usr.Show();
            this.Close();
        }

        private void btnInvSales_Click_1(object sender, EventArgs e)
        {
            frmSales sls = new frmSales();
            sls.Show();
            this.Close();
        }
    }
}
