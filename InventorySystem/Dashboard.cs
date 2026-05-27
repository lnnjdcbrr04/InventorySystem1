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
        private void btnDsh_Click(object sender, EventArgs e)
        {
            frmDashboard dsh = new frmDashboard();
            dsh.Show();
            this.Close();
        }

        private void btnDbProd_Click(object sender, EventArgs e)
        {
            frmProducts dsh = new frmProducts();
            dsh.Show();
            this.Close();
        }

        private void btnDbStocks_Click(object sender, EventArgs e)
        {
            frmStocks dsh = new frmStocks();
            dsh.Show();
            this.Close();
        }

        private void btnDbTrans_Click(object sender, EventArgs e)
        {
            frmTransaction dsh = new frmTransaction();
            dsh.Show();
            this.Close();
        }

        private void btnDbOrders_Click(object sender, EventArgs e)
        {
            frmOrder dsh = new frmOrder();
            dsh.Show();
            this.Close();
        }

        private void btnDbReports_Click(object sender, EventArgs e)
        {
            frmReport dsh = new frmReport();
            dsh.Show();
            this.Close();
        }

        private void btnDbUsers_Click(object sender, EventArgs e)
        {
            frmUsers dsh = new frmUsers();
            dsh.Show();
            this.Close();
        }

        private void btnDbLogout_Click(object sender, EventArgs e)
        {
            frmLogin dsh = new frmLogin();
            dsh.Show();
            this.Close();
        }
    }
}
