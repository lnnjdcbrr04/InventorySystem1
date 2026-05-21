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
    public partial class frmStocks : Form
    {
        public frmStocks()
        {
            InitializeComponent();
        }

        private void btnSlsOrder_Click(object sender, EventArgs e)
        {
            frmOrders order = new frmOrders();
            order.Show();
            this.Close();
        }

        private void btnSlsInventory_Click(object sender, EventArgs e)
        {
            frmInv inv = new frmInv();
            inv.Show();
            this.Close();
        }

        private void btnSlsSales_Click(object sender, EventArgs e)
        {
            frmSales sls = new frmSales();
            sls.Show();
            this.Close();
        }

        private void btnSlsLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login .Show();
            this.Close();
        }

        private void btnSlsUsers_Click(object sender, EventArgs e)
        {
            frmUsers usr = new frmUsers();
            usr.Show();
            this.Close();
        }

        private void btnSlsOrder_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
