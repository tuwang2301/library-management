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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private static IAccount iAccount = new AccountServices();
        private static IUserProfile iUserProfile = new UserProfileServices();

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string fullName, userName, password, confirm;
            userName = txtUsername.Text;
            if (userName.Length == 0)
            {
                MessageBox.Show("Username is required! Please enter username", "Username required!");
                return;

            }
            if (iAccount.GetAccountByUsername(userName) != null)
            {
                MessageBox.Show("Username already exist!\nPlease try another one!", "Username exist!");
            }
            else
            {
                password = txtPassword.Text;
                if(password.Length == 0)
                {
                    MessageBox.Show("Password is required! Please enter password", "Password required!");
                    return;

                }
                confirm = txtConfirm.Text;
                if (!confirm.Equals(password))
                {
                    MessageBox.Show("Your confirm password do not match your password!\nPlease check again!", "Password do not match!");
                }
                else
                {
                    fullName = txtFullname.Text;
                    Account newAcc = new Account();
                    UserProfile newUp = new UserProfile();
                    int newID = iAccount.GetLastID() + 1;
                    newAcc.AccountId = newID;
                    newAcc.Username = userName;
                    newAcc.Password = password;
                    newAcc.RoleName = "user";
                    newAcc.Status = true;
                    newUp.UserProfileId = iUserProfile.GetLastID() + 1;
                    newUp.FullName = fullName;
                    newUp.AccountId = newID;
                    iAccount.AddAccount(newAcc);
                    iUserProfile.AddUserProfile(newUp);
                    MessageBox.Show("SIGNUP SUCCESSFULLY!\nTRY LOGIN!", "SIGNUP SUCCESSFULLY!");
                    this.Close();

                }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtConfirm.UseSystemPasswordChar = !txtConfirm.UseSystemPasswordChar;
        }
    }
}
