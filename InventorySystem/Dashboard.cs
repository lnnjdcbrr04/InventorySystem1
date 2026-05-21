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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDbLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            //Message
            this.Close();
        }

        private void btnDbOrders_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            orders.Show();

            this.Close();
        }

        private void btnDbInventory_Click(object sender, EventArgs e)
        {
            frmInv inv = new frmInv();
            inv.Show();

            this.Close();
        }

        private void btnDbSales_Click(object sender, EventArgs e)
        {
            frmSales sls = new frmSales();
            sls.Show();
            this.Close();
        }

        private void btnDbStocks_Click(object sender, EventArgs e)
        {
            frmStocks stk = new frmStocks();
            stk.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDbUsers_Click(object sender, EventArgs e)
        {
            frmUsers usr = new frmUsers();
            usr.Show();
            this.Close();
        }
    }
}
