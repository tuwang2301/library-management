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

        public void loginThread(object obj)
        {
            Account account = (Account)obj;
            Application.Run(new Home(account));
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
                this.Close();
                th = new Thread(loginThread);
                th.SetApartmentState(ApartmentState.STA);
                th.Start(login);

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