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
            string fullName, userName, password, confirm, email;
            userName = txtUsername.Text;
            if (iAccount.GetAccountByUsername(userName) != null)
            {
                MessageBox.Show("Username already exist!\nPlease try another one!", "Username exist!");
            }
            else
            {
                password = txtPassword.Text;
                confirm = txtConfirm.Text;
                if (!confirm.Equals(password))
                {
                    MessageBox.Show("Your confirm password do not match your password!\nPlease check again!", "Password do not match!");
                }
                else
                {
                    email = txtEmail.Text;
                    if (iUserProfile.GetUserProfileByEmail(email) != null)
                    {
                        MessageBox.Show("Email already exist!\nPlease try another one!", "Email exist!");
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
                        newUp.Email = email;
                        newUp.AccountId = newID;
                        iAccount.AddAccount(newAcc);
                        iUserProfile.AddUserProfile(newUp);
                        MessageBox.Show("SIGNUP SUCCESSFULLY!\nTRY LOGIN!", "SIGNUP SUCCESSFULLY!");
                        this.Close();
                    }

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
