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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdInventory_Click(object sender, EventArgs e)
        {
            frmInv inv = new frmInv();
            inv .Show();
            this.Close();
        }

        private void btnOrdSales_Click(object sender, EventArgs e)
        {
            frmSales sls = new frmSales();
            sls.Show();
            this.Close();
        }

        private void btnOrdStocks_Click(object sender, EventArgs e)
        {
            frmStocks stk = new frmStocks();
            stk.Show();
            this.Close();
        }

        private void btnOrdLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
