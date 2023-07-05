using PRN211_Project_LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Repository
{
    public interface IBorrowing
    {
        /// <summary>
        /// Get all borrowings
        /// </summary>
        /// <returns></returns>
        public List<Borrowing> GetAllBorrowings();

        /// <summary>
        /// Get borrowing by username, password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Borrowing GetBorrowingById(int id);

        public List<Borrowing> getBorrowingsByAccountID(int accountId);

        public List<Borrowing> getBorrowingsByBookID(List<Borrowing> borrowings, int bookId);

        public List<Borrowing> getBorrowingsByBookSearch(List<Borrowing> borrowings, string bookSearch);

        public List<Borrowing> getBorrowingsByStatusId(int statusId);

        public List<Borrowing> getBorrowingsByBorrowDate(List<Borrowing> borrowings, DateTime borrowDate);
        public List<Borrowing> getBorrowingsByDueDate(List<Borrowing> borrowings, DateTime dueDate);

        public int GetLastID();

        public void AddBorrowing(Borrowing borrowing);

        public void UpdateBorrowing(Borrowing borrowing);

        public void DeleteBorrowing(Borrowing borrowing);

    }
}
