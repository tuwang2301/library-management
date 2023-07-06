using Microsoft.VisualBasic;
using PRN211_Project_LibraryManagement.Models;
using PRN211_Project_LibraryManagement.Services;
using System.Threading;

namespace PRN211_Project_LibraryManagement
{

    public partial class Login : Form
    {
        Thread th;
        public Login()
        {
            InitializeComponent();
        }

        public void loginThread1(object obj)
        {
            Account account = (Account)obj;
            Application.Run(new Home(account));
        }
        public void loginThread2(object obj)
        {
            Account account = (Account)obj;
            Application.Run(new AdminHome(account));
        }

        private void linkLabel_Forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountServices aS = new AccountServices();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Account login = aS.GetAccount(username, password);
            if (login != null)
            {
                if (!login.Status)
                {
                    DialogResult check = MessageBox.Show("You have been blocked by admin! See you soon!"
                       , "BLOCK", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (login.RoleName.Trim().Equals("user"))
                    {
                        this.Close();
                        th = new Thread(loginThread1);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start(login);
                    }
                    else
                    {
                        this.Close();
                        th = new Thread(loginThread2);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start(login);
                    }

                }

            }
            else
            {
                MessageBox.Show("Username and password are invalid! Please try again!"
                    , "Invalid login information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}