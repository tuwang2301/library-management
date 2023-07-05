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
    public partial class MyBorrowings : Form
    {
        Thread th;
        private Account currentAccount;
        private List<Borrowing> borrowingList;
        private static IBorrowing iBorrowing = new BorrowingServices();
        private static IBook iBook = new BookServices();
        private static ICategory iCat = new CategoryServices();


        public MyBorrowings()
        {
            InitializeComponent();
        }

        public MyBorrowings(Account acc) : this()
        {
            currentAccount = acc;
            borrowingList = iBorrowing.getBorrowingsByAccountID(currentAccount.AccountId);
        }


        public void logoutThread(object obj)
        {
            Application.Run(new Login());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(logoutThread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void displayDGV(List<Borrowing> borrowingList)
        {
            dgvBorrowings.Rows.Clear();
            foreach (var item in borrowingList)
            {
                item.Book = iBook.GetBookById(item.BookId);
                dgvBorrowings.Rows.Add(item.BorrowingId, item.BookId, item.Book.Title, item.BorrowDate.ToString("MM-dd-yyyy"), item.DueDate.ToString("MM-dd-yyyy"));
            }
        }

        private void MyBorrowings_Load(object sender, EventArgs e)
        {
            displayDGV(borrowingList);

        }

        private void dgvBorrowings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                try
                {
                    int BookId = int.Parse(dgvBorrowings.Rows[e.RowIndex].Cells["Column2"].Value.ToString());
                    Book book = iBook.GetBookById(BookId);
                    book.Category = iCat.GetCategoryById(book.CategoryId);
                    string coverUrl = $"C:\\Users\\quang\\Documents\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\{book.CoverPictureUrl}.jpg";
                    // Kiểm tra xem tập tin ảnh có tồn tại không
                    if (System.IO.File.Exists(coverUrl))
                    {
                        // Tạo một đối tượng Image từ tập tin ảnh
                        Image image = Image.FromFile(coverUrl);

                        // Gán hình ảnh cho BackgroundImage của PictureBox
                        pictureBox_CoverPic.BackgroundImage = image;
                        lblId.Text = book.BookId.ToString();
                        lblTitle.Text = book.Title.ToString();
                        lblAuthor.Text = book.Author.ToString();
                        lblCategory.Text = book.Category.CategoryName.ToString();
                        lblDescription.Text = book.Description.ToString();
                        lblDueDate.Text = dgvBorrowings.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tập tin ảnh.");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(logoutThread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = txtSearch.Text;
            List<Borrowing> result = iBorrowing.getBorrowingsByBookSearch(borrowingList, searchStr);
            displayDGV(result);
        }


        private void dateTimePickerDueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dueDate = dateTimePickerDueDate.Value;
            List<Borrowing> result = iBorrowing.getBorrowingsByDueDate(borrowingList, dueDate);
            displayDGV(result);
        }

        private void dateTimePickerBorrowDate_ValueChanged_1(object sender, EventArgs e)
        {
            string borrowDate = dateTimePickerBorrowDate.Text;
            List<Borrowing> result = iBorrowing.getBorrowingsByBorrowDate(borrowingList, DateTime.Parse(borrowDate));
            displayDGV(result);
        }
    }
}

