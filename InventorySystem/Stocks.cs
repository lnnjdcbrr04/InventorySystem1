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

        private void btnDsh_Click(object sender, EventArgs e)
        {
            frmDashboard stk = new frmDashboard();
            stk.Show();
            this.Close();
        }

        private void btnStkProducts_Click(object sender, EventArgs e)
        {
            frmProducts stk = new frmProducts();
            stk.Show();
            this.Close();
        }

        private void btnStkStocks_Click(object sender, EventArgs e)
        {
            frmStocks stk = new frmStocks();
            stk.Show();
            this.Close();
        }

        private void btnStkTrans_Click(object sender, EventArgs e)
        {
            frmTransaction stk = new frmTransaction();
            stk.Show();
            this.Close();
        }

        private void btnStkOrders_Click(object sender, EventArgs e)
        {
            frmOrder stk = new frmOrder();
            stk.Show();
            this.Close();
        }

        private void btnStkReports_Click(object sender, EventArgs e)
        {
            frmReport stk = new frmReport();
            stk.Show();
            this.Close();
        }

        private void btnStkUsers_Click(object sender, EventArgs e)
        {
            frmUsers stk = new frmUsers();
            stk.Show();
            this.Close();
        }

        private void btnStkLogout_Click(object sender, EventArgs e)
        {
            frmLogin stk = new frmLogin();
            stk.Show();
            this.Close();
        }
    }
}
