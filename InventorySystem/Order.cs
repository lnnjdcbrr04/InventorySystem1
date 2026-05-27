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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnOrdDsh_Click(object sender, EventArgs e)
        {
            frmDashboard ord = new frmDashboard();
            ord.Show();
            this.Close();
        }

        private void btnOrdProd_Click(object sender, EventArgs e)
        {
            frmProducts ord = new frmProducts();
            ord.Show();
            this.Close();
        }

        private void btnOrdStocks_Click(object sender, EventArgs e)
        {
            frmStocks ord = new frmStocks();
            ord.Show();
            this.Close();
        }

        private void btnOrdTrans_Click(object sender, EventArgs e)
        {
            frmTransaction ord = new frmTransaction();
            ord.Show();
            this.Close();
        }

        private void btnOrdOrders_Click(object sender, EventArgs e)
        {
            frmOrder ord = new frmOrder();
            ord.Show();
            this.Close();
        }

        private void btnOrdReports_Click(object sender, EventArgs e)
        {
            frmReport ord = new frmReport();
            ord.Show();
            this.Close();
        }

        private void btnOrdUsers_Click(object sender, EventArgs e)
        {
            frmUsers ord = new frmUsers();
            ord.Show();
            this.Close();
        }

        private void btnOrdLogout_Click(object sender, EventArgs e)
        {
            frmLogin ord = new frmLogin();
            ord.Show();
            this.Close();
        }
    }
}
