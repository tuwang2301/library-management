using PRN211_Project_LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Repository
{
    public interface IBook
    {
        /// <summary>
        /// Get all books
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks();

        /// <summary>
        /// Get book by username, password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Book GetBookById(int id);
        public Book GetBookByTitle(string title);


        public List<Book> getBooks(string searchStr);

        public List<Book> getBooksByCategory(int catId);

        public int GetLastID();

        public void AddBook(Book book);

        public void UpdateBook(Book book);

        public void DeleteBook(Book book);

    }
}
