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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnUsrOrders_Click(object sender, EventArgs e)
        {
            frmOrders order = new frmOrders();
            order.Show();
            this.Close();
        }

        private void btnUsrInventory_Click(object sender, EventArgs e)
        {
            frmInv inv = new frmInv();
            inv.Show();
            this.Close();
        }

        private void btnUsrSales_Click(object sender, EventArgs e)
        {
            frmSales sls = new frmSales();
            sls.Show();
            this.Close();
        }

        private void btnUsrStocks_Click(object sender, EventArgs e)
        {
            frmStocks stk = new frmStocks();
            stk.Show();
            this.Close();
        }

        private void btnUsrLogout_Click(object sender, EventArgs e)
        {
            frmLogin login  = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
