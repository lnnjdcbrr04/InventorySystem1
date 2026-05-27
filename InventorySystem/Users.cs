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

        private void frmUsers_Load(object sender, EventArgs e)
        {

        }
        private void btnUserProd_Click(object sender, EventArgs e)
        {
            frmProducts usr = new frmProducts();
            usr.Show();
            this.Close();
        }

        private void btnUserDsh_Click(object sender, EventArgs e)
        {
            frmDashboard usr = new frmDashboard();
            usr.Show();
            this.Close();
        }

        private void btnUserStocks_Click(object sender, EventArgs e)
        {
            frmStocks usr = new frmStocks();
            usr.Show();
            this.Close();
        }

        private void btnUserTrans_Click(object sender, EventArgs e)
        {
            frmTransaction usr = new frmTransaction();
            usr.Show();
            this.Close();
        }

        private void btnUserOrders_Click(object sender, EventArgs e)
        {
            frmOrder usr = new frmOrder();
            usr.Show();
            this.Close();
        }

        private void btnUserReports_Click(object sender, EventArgs e)
        {
            frmReport usr = new frmReport();
            usr.Show();
            this.Close();
        }

        private void btnUserUsers_Click(object sender, EventArgs e)
        {
            frmUsers usr = new frmUsers();
            usr.Show();
            this.Close();
        }

        private void btnUserLogout_Click(object sender, EventArgs e)
        {
            frmLogin usr = new frmLogin();
            usr.Show();
            this.Close();
        }
    }
}
