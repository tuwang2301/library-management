using PRN211_Project_LibraryManagement.Models;
using PRN211_Project_LibraryManagement.Repository;
using PRN211_Project_LibraryManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_Project_LibraryManagement
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private static IAccount iC = new AccountServices();

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            Account result = iC.GetAccountByUsername(username);

            if (result != null)
            {
                txtResult.Text = result.Password;
            }
            else
            {
                MessageBox.Show("Your Username does not exist!\nPlease try again or create new account", "Wrong username!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
