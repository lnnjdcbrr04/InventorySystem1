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
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void btnTransDsh_Click(object sender, EventArgs e)
        {
            frmDashboard trans = new frmDashboard();
            trans.Show();
            this.Close();
        }

        private void btnTransProd_Click(object sender, EventArgs e)
        {
            frmProducts trans = new frmProducts();
            trans.Show();
            this.Close();
        }

        private void btnTransStocks_Click(object sender, EventArgs e)
        {
            frmStocks trans = new frmStocks();
            trans.Show();
            this.Close();
        }

        private void btnTransTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction trans = new frmTransaction();
            trans.Show();
            this.Close();
        }

        private void btnTransOrders_Click(object sender, EventArgs e)
        {
            frmOrder trans = new frmOrder();
            trans.Show();
            this.Close();
        }

        private void btnTransReports_Click(object sender, EventArgs e)
        {
            frmReport trans = new frmReport();
            trans.Show();
            this.Close();
        }

        private void btnTransUsers_Click(object sender, EventArgs e)
        {
            frmUsers trans = new frmUsers();
            trans.Show();
            this.Close();
        }

        private void btnTransLogout_Click(object sender, EventArgs e)
        {
            frmLogin trans = new frmLogin();
            trans.Show();
            this.Close();
        }
    }
}
