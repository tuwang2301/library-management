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
    public partial class BorrowingConfirmation : Form
    {
        private Account borrowAccount;
        private Book borrowBook;
        private static IUserProfile iU = new UserProfileServices();
        private static IBorrowing iBr = new BorrowingServices();
        private static ICategory iC = new CategoryServices();
        private static IBook iB = new BookServices();
        public BorrowingConfirmation()
        {
            InitializeComponent();
        }

        public BorrowingConfirmation(Account ac, Book b) : this()
        {
            borrowAccount = ac;
            borrowBook = b;
        }

        private void BorrowingConfirmation_Load(object sender, EventArgs e)
        {
            //Profile
            UserProfile uP = iU.GetUserProfile(borrowAccount.AccountId);
            lblFullname.Text = uP.FullName;
            lblEmail.Text = uP.Email;
            lblAge.Text = uP.Age.ToString();
            lblGender.Text = (uP.Gender) ? "Male" : "Female";
            lblAddress.Text = uP.Address;

            //Book
            borrowBook.Category = iC.GetCategoryById(borrowBook.CategoryId);
            try
            {
                string coverUrl = $"C:\\Users\\quang\\Documents\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\{borrowBook.CoverPictureUrl}.jpg";
                // Kiểm tra xem tập tin ảnh có tồn tại không
                if (System.IO.File.Exists(coverUrl))
                {
                    // Tạo một đối tượng Image từ tập tin ảnh
                    Image image = Image.FromFile(coverUrl);

                    // Gán hình ảnh cho BackgroundImage của PictureBox
                    pictureBox_CoverPic.BackgroundImage = image;
                    lblId.Text = borrowBook.BookId.ToString();
                    lblTitle.Text = borrowBook.Title;
                    lblAuthor.Text = borrowBook.Author;
                    lblCategory.Text = borrowBook.Category.CategoryName;
                    lblDescription.Text = borrowBook.Description;
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

            //Borrow
            DateTime today = DateTime.Today;
            dateTimePickerBorrow.Text = today.ToString();
            DateTime tomorrow = DateTime.Today.AddDays(1);
            dateTimePickerDue.Text = tomorrow.ToString();



        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            List<Borrowing> myBorrowings = iBr.getBorrowingsByAccountID(borrowAccount.AccountId);
            DateTime today = DateTime.Today;
            DateTime due = dateTimePickerDue.Value;
            Borrowing newBorrowing = new Borrowing();
            newBorrowing.BorrowingId = myBorrowings[myBorrowings.Count - 1].BorrowingId + 1;
            newBorrowing.AccountId = borrowAccount.AccountId;
            newBorrowing.BookId = borrowBook.BookId;
            newBorrowing.BorrowDate = today;
            newBorrowing.DueDate = due;
            newBorrowing.StatusId = 1;
            iBr.AddBorrowing(newBorrowing);
            borrowBook.Quantity -= 1;
            iB.UpdateBook(borrowBook);
            MessageBox.Show("BORROW SUCCESSFULLY!","SUCCESSFUL");
            this.Close();
        }

        private void dateTimePickerDue_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = DateTime.Today.AddDays(1);
            DateTime due = dateTimePickerDue.Value;
            double range = (due - today).TotalDays;
            if (range <= 0)
            {
                MessageBox.Show("Due has to be after today!"
                 , "Due Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTimePickerDue.Text = tomorrow.ToString();
            }
            else if (range > 30)
            {
                MessageBox.Show("Maximum borrow time is 30 DAYS!"
                , "Due Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTimePickerDue.Text = tomorrow.ToString();

            }

        }

    }
}
