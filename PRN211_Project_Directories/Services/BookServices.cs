using PRN211_Project_LibraryManagement.Models;
using PRN211_Project_LibraryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Services
{
    public class BookServices : IBook
    {
        public void AddBook(Book book)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Books.Add(book);
                con.SaveChanges();
            }
        }

        public void DeleteBook(Book book)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Books.Remove(book);
                con.SaveChanges();
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (var con = new LibraryManagementContext())
            {
                books = con.Books.ToList();
            }
            return books;
        }

        public List<Book> getBooks(string searchStr)
        {
            List<Book> books = new List<Book>();
            using (var con = new LibraryManagementContext())
            {
                books = con.Books.Where((x)
                    => (x.Title.ToLower().Contains(searchStr.ToLower())
                    || x.Author.ToLower().Contains(searchStr.ToLower())
                    || x.Description.ToLower().Contains(searchStr.ToLower()))).ToList();
            }
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = new Book();
            using (var con = new LibraryManagementContext())
            {
                book = con.Books.Where((x) => x.BookId == id).FirstOrDefault();
            }
            return book;
        }

        public void UpdateBook(Book book)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Books.Update(book);
                con.SaveChanges();
            }
        }

        public List<Book> getBooksByCategory(int catId)
        {
            List<Book> books = new List<Book>();
            using (var con = new LibraryManagementContext())
            {
                if (catId == 0)
                {
                    books = con.Books.ToList();
                }
                else
                {
                    books = con.Books.Where((x) => x.CategoryId == catId).ToList();
                }

            }
            return books;
        }

        public int GetLastID()
        {
            using (var con = new LibraryManagementContext())
            {
                var last = con.Books.OrderByDescending(a => a.BookId).FirstOrDefault();
                if (last != null)
                {
                    return last.BookId;
                }
                return 0; // hoặc giá trị mặc định khác tùy vào yêu cầu của bạn
            }
        }
    }
}
