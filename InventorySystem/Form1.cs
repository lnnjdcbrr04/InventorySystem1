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

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show(
                    "Successfully Login",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                frmDashboard dsh = new frmDashboard();

                dsh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username or Password",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
            }


        }
    }
}
