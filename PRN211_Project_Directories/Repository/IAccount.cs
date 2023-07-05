using PRN211_Project_LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Repository
{
    public interface IAccount
    {
        /// <summary>
        /// Get all accounts
        /// </summary>
        /// <returns></returns>
        public List<Account> GetAllAccounts();

        /// <summary>
        /// Get account by username, password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Account GetAccount(string username, string password);
        public Account GetAccountByUsername(string username);

        public Account GetAccountById(int id);

        public int GetLastID();

        public void AddAccount(Account account);

        public void UpdateAccount(Account account);

        public void DeleteAccount(Account account);

    }
}
