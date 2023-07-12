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
            for (int i = 0; i < dgvBorrowings.Rows.Count - 1; i++)
            {
                DateTime due = DateTime.Parse(dgvBorrowings.Rows[i].Cells["Column5"].Value.ToString());
                DateTime today = DateTime.Today;
                int range = (due.Date - today.Date).Days;
                // Kiểm tra điều kiện cho hàng hiện tại
                if (range < 0)
                {
                    // Làm nổi bật hàng
                    dgvBorrowings.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
                else if (range <= 3)
                {
                    // Làm nổi bật hàng
                    dgvBorrowings.Rows[i].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }
            }
        }

        private void refreshDGV()
        {
            borrowingList = iBorrowing.getBorrowingsByAccountID(currentAccount.AccountId);
            displayDGV(borrowingList);
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
                    string coverUrl = $"D:\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\{book.CoverPictureUrl}";
                    // Kiểm tra xem tập tin ảnh có tồn tại không
                    if (System.IO.File.Exists(coverUrl))
                    {
                        // Tạo một đối tượng Image từ tập tin ảnh
                        Image image = Image.FromFile(coverUrl);

                        // Gán hình ảnh cho BackgroundImage của PictureBox
                        pictureBox_CoverPic.BackgroundImage = image;
                        lblBorrowID.Text = dgvBorrowings.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DateTime due = DateTime.Parse(lblDueDate.Text);
            DateTime today = DateTime.Today;
            int range = (due.Date - today.Date).Days;
            bool check = true;
            // Kiểm tra thoi gian nop
            if (range < 0)
            {
                // Nop tre
                check = false;
            }
            int bookId = int.Parse(lblId.Text);
            int borrowId = int.Parse(lblBorrowID.Text);
            Book returnBook = iBook.GetBookById(bookId);
            DialogResult result
                = MessageBox.Show($"Do you want to return the book: {returnBook.Title}!" +
                $"\nAfter press \"Yes\", you will return this book!", "Return information"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Borrowing returnBr = iBorrowing.GetBorrowingById(borrowId);
                returnBr.StatusId = 2;
                iBorrowing.UpdateBorrowing(returnBr);
                returnBook.Quantity += 1;
                iBook.UpdateBook(returnBook);
                refreshDGV();
                if (check)
                {
                    MessageBox.Show("RETURN SUCCESSFULLY!", "SUCCESSFUL");
                }
                else
                {
                    MessageBox.Show("RETURN SUCCESSFULLY!\nPLEASE REMEMBER TO RETURN ON TIME NEXT TIME!", "SUCCESSFUL");
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile(currentAccount);
            myProfile.Show();
        }
    }
}

