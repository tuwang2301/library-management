using Microsoft.VisualBasic;
using PRN211_Project_LibraryManagement.Models;
using PRN211_Project_LibraryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRN211_Project_LibraryManagement.Services
{
    internal class BorrowingServices : IBorrowing
    {
        private static IBook iBook = new BookServices();
        public void AddBorrowing(Borrowing borrowing)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Borrowings.Add(borrowing);
                con.SaveChanges();
            }
        }

        public void DeleteBorrowing(Borrowing borrowing)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Borrowings.Remove(borrowing);
                con.SaveChanges();
            }
        }

        public List<Borrowing> GetAllBorrowings()
        {
            List<Borrowing> borrowings = new List<Borrowing>();
            using (var con = new LibraryManagementContext())
            {
                borrowings = con.Borrowings.ToList();
            }

            return borrowings;
        }

        public List<Borrowing> getBorrowingsByAccountID(int accountId)
        {
            List<Borrowing> result = new List<Borrowing>();
            using (var con = new LibraryManagementContext())
            {
                result = con.Borrowings.Where((x) => x.AccountId == accountId && x.StatusId == 1).ToList();
            }

            return result;
        }

        public List<Borrowing> getBorrowingsByBookID(List<Borrowing> borrowings, int bookId)
        {
            List<Borrowing> result = new List<Borrowing>();
            result = borrowings.Where((x) => x.BookId == bookId).ToList();

            return result;
        }

        public Borrowing GetBorrowingById(int id)
        {
            Borrowing borrowing = new Borrowing();
            using (var con = new LibraryManagementContext())
            {
                borrowing = con.Borrowings.Where((x) => x.BorrowingId == id).FirstOrDefault();
            }

            return borrowing;
        }

        public List<Borrowing> getBorrowingsByStatusId(int statusId)
        {
            List<Borrowing> borrowings = new List<Borrowing>();
            using (var con = new LibraryManagementContext())
            {
                borrowings = con.Borrowings.Where((x) => x.StatusId == statusId).ToList();
            }

            return borrowings;
        }

        public void UpdateBorrowing(Borrowing borrowing)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Borrowings.Update(borrowing);
                con.SaveChanges();
            }
        }

        public List<Borrowing> getBorrowingsByBorrowDate(List<Borrowing> borrowings, DateTime borrowDate)
        {
            List<Borrowing> result = new List<Borrowing>();
            result = borrowings.Where((x) => x.BorrowDate.Date == borrowDate.Date).ToList();

            return result;
        }

        public List<Borrowing> getBorrowingsByDueDate(List<Borrowing> borrowings, DateTime dueDate)
        {
            List<Borrowing> result = new List<Borrowing>();
            result = borrowings.Where((x) => x.DueDate.Date == dueDate.Date).ToList();

            return result;
        }

        public List<Borrowing> getBorrowingsByBookSearch(List<Borrowing> borrowings, string bookSearch)
        {
            List<Borrowing> result = new List<Borrowing>();
            result = borrowings.Where((x)
                => (iBook.GetBookById(x.BookId).Title.ToLower().Contains(bookSearch.ToLower())
                    || iBook.GetBookById(x.BookId).Author.ToLower().Contains(bookSearch.ToLower())
                    || iBook.GetBookById(x.BookId).Description.ToLower().Contains(bookSearch.ToLower()))).ToList();

            return result;
        }

        public int GetLastID()
        {
            using (var con = new LibraryManagementContext())
            {
                var last = con.Borrowings.OrderByDescending(a => a.BorrowingId).FirstOrDefault();
                if (last != null)
                {
                    return last.BorrowingId;
                }
                return 0; // hoặc giá trị mặc định khác tùy vào yêu cầu của bạn
            }
        }
    }
}
