using PRN211_Project_LibraryManagement.Models;
using PRN211_Project_LibraryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRN211_Project_LibraryManagement.Services
{
    public class AccountServices : IAccount
    {

        public void AddAccount(Account account)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Accounts.Add(account);
                con.SaveChanges();
            }
        }

        public void DeleteAccount(Account account)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Accounts.Remove(account);
                con.SaveChanges();
            }
        }

        public Account GetAccount(string username, string password)
        {
            Account result = new Account();
            using (var con = new LibraryManagementContext())
            {
                result = con.Accounts
                .Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            }
            return result;
        }

        public Account GetAccountByUsername(string username)
        {
            Account result = new Account();
            using (var con = new LibraryManagementContext())
            {
                result = con.Accounts
                .Where(x => x.Username.Equals(username)).FirstOrDefault();
            }
            return result;
        }

        public Account GetAccountById(int id)
        {
            Account result = new Account();
            using (var con = new LibraryManagementContext())
            {
                result = con.Accounts
                .Where(x => x.AccountId == id).FirstOrDefault();
            }
            return result;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> result = new List<Account> ();
            using (var con = new LibraryManagementContext())
            {
                result = con.Accounts.ToList();
            }
            return result;
        }

        public void UpdateAccount(Account account)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Accounts.Update(account);
                con.SaveChanges();
            }
        }

        public int GetLastID()
        {
            using(var con = new LibraryManagementContext())
            {
                var lastAccount = con.Accounts.OrderByDescending(a => a.AccountId).FirstOrDefault();
                if (lastAccount != null)
                {
                    return lastAccount.AccountId;
                }
                return 0; // hoặc giá trị mặc định khác tùy vào yêu cầu của bạn
            }
        }
    }
    }
