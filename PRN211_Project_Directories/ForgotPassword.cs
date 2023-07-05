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
        private static IUserProfile iU = new UserProfileServices();
        private static IAccount iC = new AccountServices();

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            UserProfile uP = iU.GetUserProfileByEmail(email);
           
            if (uP != null)
            {
                Account a = iC.GetAccountById(uP.AccountId);
                txtResult.Text = a.Password;
            }
            else
            {
                MessageBox.Show("Your email does not exist!\nPlease try again or create new account", "Wrong email!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
