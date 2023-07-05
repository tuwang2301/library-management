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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRN211_Project_LibraryManagement
{
    public partial class Home : Form
    {
        Thread th;
        private Account currentAccount;
        public Home()
        {
            InitializeComponent();
        }

        public void logoutThread(object obj)
        {
            Application.Run(new Login());
        }

        public Home(Account acc) : this()
        {
            currentAccount = acc;
        }

        private static IBook iBook = new BookServices();
        private static ICategory iCat = new CategoryServices();
        private static IBorrowing iBorrowing = new BorrowingServices();


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(logoutThread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void displayDGV(List<Book> books)
        {
            dgvBooks.Rows.Clear();
            foreach (var item in books)
            {
                item.Category = iCat.GetCategoryById(item.CategoryId);
                dgvBooks.Rows.Add(item.BookId, item.Quantity, item.Title, item.Author, item.Category.CategoryName, item.Description);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            books = iBook.GetAllBooks();
            displayDGV(books);
            List<Category> categories = new List<Category>();
            Category all = new Category();
            all.CategoryId = 0;
            all.CategoryName = "All";
            categories.Add(all);
            categories.AddRange(iCat.GetAllCategories().ToList());
            comboBox_Category.DisplayMember = "CategoryName";
            comboBox_Category.ValueMember = "CategoryId";
            comboBox_Category.DataSource = categories;
            Book book = books[0];
            book.Category = iCat.GetCategoryById(book.CategoryId);
            try
            {
                string coverUrl = $"C:\\Users\\quang\\Documents\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\{book.CoverPictureUrl}.jpg";
                // Kiểm tra xem tập tin ảnh có tồn tại không
                if (System.IO.File.Exists(coverUrl))
                {
                    // Tạo một đối tượng Image từ tập tin ảnh
                    Image image = Image.FromFile(coverUrl);

                    // Gán hình ảnh cho BackgroundImage của PictureBox
                    pictureBox_CoverPic.BackgroundImage = image;
                    lblId.Text = book.BookId.ToString();
                    lblQuantity.Text = book.Quantity.ToString();
                    lblTitle.Text = book.Title;
                    lblAuthor.Text = book.Author;
                    lblCategory.Text = book.Category.CategoryName;
                    lblDescription.Text = book.Description;
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

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                try
                {
                    int id = int.Parse(dgvBooks.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
                    Book book = iBook.GetBookById(id);
                    string coverUrl = $"C:\\Users\\quang\\Documents\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\{book.CoverPictureUrl}.jpg";
                    // Kiểm tra xem tập tin ảnh có tồn tại không
                    if (System.IO.File.Exists(coverUrl))
                    {
                        // Tạo một đối tượng Image từ tập tin ảnh
                        Image image = Image.FromFile(coverUrl);

                        // Gán hình ảnh cho BackgroundImage của PictureBox
                        pictureBox_CoverPic.BackgroundImage = image;
                        lblId.Text = dgvBooks.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                        lblQuantity.Text = dgvBooks.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                        lblTitle.Text = dgvBooks.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                        lblAuthor.Text = dgvBooks.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                        lblCategory.Text = dgvBooks.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                        lblDescription.Text = dgvBooks.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = txtSearch.Text;
            List<Book> books = iBook.getBooks(searchStr);
            displayDGV(books);
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn trong ComboBox
            int selectedValue = int.Parse(comboBox_Category.SelectedValue.ToString());

            List<Book> books = iBook.getBooksByCategory(selectedValue);
            displayDGV(books);
        }

        private void linkLabel_myBorrowings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyBorrowings myBorrowings = new MyBorrowings(currentAccount);
            myBorrowings.Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(lblId.Text);
            List<Borrowing> myBorrowings = iBorrowing.getBorrowingsByAccountID(currentAccount.AccountId);
            List<Borrowing> check = iBorrowing.getBorrowingsByBookID(myBorrowings, bookId);
            if(check.Count > 0)
            {
                MessageBox.Show("You are borrowing this book!"
                  , "Borrowing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Book chosenbook = iBook.GetBookById(bookId);
                BorrowingConfirmation borrowingConfirm = new BorrowingConfirmation(currentAccount, chosenbook);
                borrowingConfirm.ShowDialog();
            }
        }
    }

}

