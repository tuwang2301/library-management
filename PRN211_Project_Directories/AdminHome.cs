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
    public partial class AdminHome : Form
    {
        Thread th;
        private Account currentAccount;
        private static IBook iBook = new BookServices();
        private static ICategory iCat = new CategoryServices();
        private static IBorrowing iBorrowing = new BorrowingServices();
        private static IUserProfile iUserProfile = new UserProfileServices();
        private static IAccount iAccount = new AccountServices();
        private static IStatus iStatus = new StatusServices();
        public AdminHome()
        {
            InitializeComponent();
        }

        public void logoutThread(object obj)
        {
            Application.Run(new Login());
        }

        public AdminHome(Account acc) : this()
        {
            currentAccount = acc;
        }


        private void AdminHome_Load(object sender, EventArgs e)
        {
            // Book list tab
            List<Book> books = iBook.GetAllBooks();
            List<Borrowing> borrowings = iBorrowing.GetAllBorrowings();
            List<UserProfile> userProfiles = iUserProfile.GetAllUserProfiles();
            // Display all book dgv
            displayDGVBooks(books);
            // Display all borrowing dgv
            displayDGVBorrowings(borrowings);
            // Load all Category
            loadCategory();
            // Load all status
            loadStatus();
            // Load book infor
            loadBookInformation();
            // Load borrow infor
            loadBorrowInformation();
            // Display all UserProfile dgv
            displayDGVUserProfles(userProfiles);
        }


        void displayDGVBooks(List<Book> books)
        {
            dgvBooks.Rows.Clear();
            dgvBook2.Rows.Clear();
            foreach (var item in books)
            {
                item.Category = iCat.GetCategoryById(item.CategoryId);
                dgvBooks.Rows.Add(item.BookId, item.Quantity, item.Title, item.Author, item.Category.CategoryName, item.Description);
                dgvBook2.Rows.Add(item.BookId, item.Quantity, item.Title, item.Author, item.Category.CategoryName, item.Description);
            }
        }

        void displayDGVUserProfles(List<UserProfile> userProfiles)
        {
            //dgvUserProfiles.Rows.Clear();
            dgvUserProfile2.Rows.Clear();
            foreach (var item in userProfiles)
            {
                //dgvUserProfiles.Rows.Add(item.UserProfileId, item.Quantity, item.Title, item.Author, item.Category.CategoryName, item.Description);
                string gender = (item.Gender.Value) ? "Male" : "Female";
                dgvUserProfile2.Rows.Add(item.AccountId, item.FullName, item.Age, gender, item.Address, item.Email);
            }
        }


        void displayDGVBorrowings(List<Borrowing> borrowingList)
        {
            dgvBorrowings.Rows.Clear();

            foreach (var item in borrowingList)
            {
                item.Status = iStatus.GetStatus(item.StatusId);
                dgvBorrowings.Rows.Add(item.BorrowingId, item.AccountId, item.BookId, item.BorrowDate.ToString("MM-dd-yyyy"), item.DueDate.ToString("MM-dd-yyyy"), item.Status.StatusName, item.Note);
            }
            for (int i = 0; i < dgvBorrowings.Rows.Count - 1; i++)
            {
                DateTime due = DateTime.Parse(dgvBorrowings.Rows[i].Cells["BorrowColumn5"].Value.ToString());
                DateTime today = DateTime.Today;
                string checkReturn = dgvBorrowings.Rows[i].Cells["BorrowColumn6"].Value.ToString();
                if (checkReturn.Equals("Returned"))
                {
                    dgvBorrowings.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
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
        }

        private Image image;

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    //string destinationFolderPath = "C:\\Users\\quang\\Documents\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\"; // Thay đổi đường dẫn đến thư mục "img" trong project của bạn
                    //string newFileName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg"; // Thay đổi tên mới theo quy chuẩn của bạn
                    //string destinationPath = Path.Combine(destinationFolderPath, newFileName); // Kết hợp đường dẫn thư mục đích và tên tệp tin mới
                    //// Di chuyển và đổi tên tệp tin đã chọn đến thư mục đích trong project
                    //File.Copy(selectedFilePath, destinationPath);
                    Image image = Image.FromFile(selectedFilePath);
                    pictureBox_CoverPic.BackgroundImage = image;
                    lblCoverURL.Text = selectedFilePath;
                    // Sau khi di chuyển và đổi tên tệp tin, bạn có thể thực hiện các hoạt động khác trên tệp tin

                }
            }

        }

        private void loadCategory()
        {
            List<Category> categories = new List<Category>();
            Category all = new Category();
            all.CategoryId = 0;
            all.CategoryName = "All";
            categories.Add(all);
            categories.AddRange(iCat.GetAllCategories().ToList());
            comboBox_Category.DisplayMember = "CategoryName";
            comboBox_Category.ValueMember = "CategoryId";
            comboBox_Category.DataSource = categories;

            List<Category> list = iCat.GetAllCategories();
            comboBox_Category2.DisplayMember = "CategoryName";
            comboBox_Category2.ValueMember = "CategoryId";
            comboBox_Category2.DataSource = list;
        }

        private void loadStatus()
        {
            List<Status> statuses = iStatus.GetAllStatuses();
            comboBox_BorrowStatus.DisplayMember = "StatusName";
            comboBox_BorrowStatus.ValueMember = "StatusId";
            comboBox_BorrowStatus.DataSource = statuses;
        }

        private void loadBookInformation()
        {
            try
            {
                int id = int.Parse(dgvBooks.Rows[0].Cells["BookColumn1"].Value.ToString());
                Book book = iBook.GetBookById(id);
                string coverUrl = $"C:\\Users\\quang\\Documents\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\{book.CoverPictureUrl}";
                // Kiểm tra xem tập tin ảnh có tồn tại không
                if (System.IO.File.Exists(coverUrl))
                {
                    // Tạo một đối tượng Image từ tập tin ảnh
                    Image image = Image.FromFile(coverUrl);

                    // Gán hình ảnh cho BackgroundImage của PictureBox
                    pictureBox_CoverPic.BackgroundImage = image;
                    lblCoverURL.Text = "None";
                    lblId.Text = dgvBooks.Rows[0].Cells["BookColumn1"].Value.ToString();
                    numericUpDown_Quantity.Text = dgvBooks.Rows[0].Cells["BookColumn2"].Value.ToString();
                    txtTitle.Text = dgvBooks.Rows[0].Cells["BookColumn3"].Value.ToString();
                    txtAuthor.Text = dgvBooks.Rows[0].Cells["BookColumn4"].Value.ToString();
                    comboBox_Category2.Text = dgvBooks.Rows[0].Cells["BookColumn5"].Value.ToString();
                    txtDescription.Text = dgvBooks.Rows[0].Cells["BookColumn6"].Value.ToString();
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

        private void loadBorrowInformation()
        {

            lblBorrow_AccountID.Text = dgvBorrowings.Rows[0].Cells["BorrowColumn2"].Value.ToString();
            lblBorrow_BookID.Text = dgvBorrowings.Rows[0].Cells["BorrowColumn3"].Value.ToString();
            Book chosenB = iBook.GetBookById(int.Parse(lblBorrow_BookID.Text));
            UserProfile chosenUP = iUserProfile.GetUserProfile(int.Parse(lblBorrow_AccountID.Text));
            lblBorrow_AccountFullName.Text = chosenUP.FullName;
            lblBorrow_BookTitle.Text = chosenB.Title;
            lblBorrowId.Text = dgvBorrowings.Rows[0].Cells["BorrowColumn1"].Value.ToString();
            dateTimePickerBorrow.Text = dgvBorrowings.Rows[0].Cells["BorrowColumn4"].Value.ToString();
            dateTimePickerDue.Text = dgvBorrowings.Rows[0].Cells["BorrowColumn5"].Value.ToString();
            comboBox_BorrowStatus.Text = dgvBorrowings.Rows[0].Cells["BorrowColumn6"].Value.ToString();
            if (dgvBorrowings.Rows[0].Cells["BorrowColumn7"].Value != null)
            {
                txtBorrowNote.Text = dgvBorrowings.Rows[0].Cells["BorrowColumn7"].Value.ToString();
            }
            else
            {
                txtBorrowNote.Text = "";
            }
        }

        void refreshDGVBook()
        {
            List<Book> books = iBook.GetAllBooks();
            displayDGVBooks(books);
        }

        void refreshDGVBorrowing()
        {
            List<Borrowing> books = iBorrowing.GetAllBorrowings();
            displayDGVBorrowings(books);
        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(logoutThread);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn trong ComboBox
            int selectedValue = int.Parse(comboBox_Category.SelectedValue.ToString());

            List<Book> books = iBook.getBooksByCategory(selectedValue);
            displayDGVBooks(books);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchStr = txtSearch.Text;
            List<Book> books = iBook.getBooks(searchStr);
            displayDGVBooks(books);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                try
                {
                    int id = int.Parse(dgvBooks.Rows[e.RowIndex].Cells["BookColumn1"].Value.ToString());
                    Book book = iBook.GetBookById(id);
                    string coverUrl = $"C:\\Users\\quang\\Documents\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\{book.CoverPictureUrl}";
                    // Kiểm tra xem tập tin ảnh có tồn tại không
                    if (System.IO.File.Exists(coverUrl))
                    {
                        // Tạo một đối tượng Image từ tập tin ảnh
                        Image image = Image.FromFile(coverUrl);

                        // Gán hình ảnh cho BackgroundImage của PictureBox
                        pictureBox_CoverPic.BackgroundImage = image;
                        lblId.Text = dgvBooks.Rows[e.RowIndex].Cells["BookColumn1"].Value.ToString();
                        numericUpDown_Quantity.Text = dgvBooks.Rows[e.RowIndex].Cells["BookColumn2"].Value.ToString();
                        txtTitle.Text = dgvBooks.Rows[e.RowIndex].Cells["BookColumn3"].Value.ToString();
                        txtAuthor.Text = dgvBooks.Rows[e.RowIndex].Cells["BookColumn4"].Value.ToString();
                        comboBox_Category2.Text = dgvBooks.Rows[e.RowIndex].Cells["BookColumn5"].Value.ToString();
                        txtDescription.Text = dgvBooks.Rows[e.RowIndex].Cells["BookColumn6"].Value.ToString();
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

        Book getInfoBook(Book book)
        {
            try
            {
                image = null;
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.Description = txtDescription.Text;
                book.CategoryId = (int)comboBox_Category2.SelectedValue;
                book.Quantity = int.Parse(numericUpDown_Quantity.Text);
                if (!lblCoverURL.Text.Equals("None"))
                {
                    string destinationFolderPath = "C:\\Users\\quang\\Documents\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\"; // Thay đổi đường dẫn đến thư mục "img" trong project của bạn
                    string selectedFilePath = lblCoverURL.Text;
                    string newFileName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg"; // Thay đổi tên mới theo quy chuẩn của bạn
                    string destinationPath = Path.Combine(destinationFolderPath, newFileName); // Kết hợp đường dẫn thư mục đích và tên tệp tin mới
                    // Di chuyển và đổi tên tệp tin đã chọn đến thư mục đích trong project
                    File.Copy(selectedFilePath, destinationPath);
                    book.CoverPictureUrl = newFileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return book;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                if (iBook.GetBookByTitle(title) != null)
                {
                    DialogResult check = MessageBox.Show("The book already exist! Do you mean update?"
                       , "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        int id = int.Parse(lblId.Text);
                        Book updateBook = iBook.GetBookById(id);
                        updateBook = getInfoBook(updateBook);
                        iBook.UpdateBook(updateBook);
                        MessageBox.Show("UPDATE SUCCESSFULLY!", "SUCCESSFUL");
                        loadBookInformation();
                        refreshDGVBook();
                    }
                }
                else
                {
                    DialogResult check = MessageBox.Show("Do you want to insert this book?"
                      , "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        Book newBook = new Book();
                        newBook.BookId = iBook.GetLastID() + 1;
                        newBook = getInfoBook(newBook);
                        iBook.AddBook(newBook);
                        MessageBox.Show("ADD SUCCESSFULLY!", "SUCCESSFUL");
                        loadBookInformation();
                        refreshDGVBook();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox_CoverPic_Click(object sender, EventArgs e)
        {

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you want to update this book?\nAfter press \"Yes\" this book will be updated"
                      , "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                int id = int.Parse(lblId.Text);
                Book updateBook = iBook.GetBookById(id);
                updateBook = getInfoBook(updateBook);
                iBook.UpdateBook(updateBook);
                MessageBox.Show("UPDATE SUCCESSFULLY!", "SUCCESSFUL");
                loadBookInformation();
                refreshDGVBook();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you want to delete this book?\nAfter press \"Yes\" this book will be deleted"
                      , "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                int id = int.Parse(lblId.Text);
                Book deleteBook = iBook.GetBookById(id);
                iBook.DeleteBook(deleteBook);
                MessageBox.Show("DELETE SUCCESSFULLY!", "SUCCESSFUL");
                loadBookInformation();
                refreshDGVBook();
            }
        }

        private void dateTimePickerBorrow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void tabPage_BorrowList_Click(object sender, EventArgs e)
        {

        }

        private void dgvBook2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblBorrow_BookID.Text = dgvBook2.Rows[e.RowIndex].Cells["dgvBook2Column1"].Value.ToString();
                lblBorrow_BookTitle.Text = dgvBook2.Rows[e.RowIndex].Cells["dgvBook2Column3"].Value.ToString();
            }

        }



        private void dgvUserProfile2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblBorrow_AccountID.Text = dgvUserProfile2.Rows[e.RowIndex].Cells["dgvUserProfile2Column1"].Value.ToString();
                lblBorrow_AccountFullName.Text = dgvUserProfile2.Rows[e.RowIndex].Cells["dgvUserProfile2Column2"].Value.ToString();
            }
        }

        private void dgvBorrowings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblBorrow_AccountID.Text = dgvBorrowings.Rows[e.RowIndex].Cells["BorrowColumn2"].Value.ToString();
                lblBorrow_BookID.Text = dgvBorrowings.Rows[e.RowIndex].Cells["BorrowColumn3"].Value.ToString();
                Book chosenB = iBook.GetBookById(int.Parse(lblBorrow_BookID.Text));
                UserProfile chosenUP = iUserProfile.GetUserProfile(int.Parse(lblBorrow_AccountID.Text));
                lblBorrow_AccountFullName.Text = chosenUP.FullName;
                lblBorrow_BookTitle.Text = chosenB.Title;
                lblBorrowId.Text = dgvBorrowings.Rows[e.RowIndex].Cells["BorrowColumn1"].Value.ToString();
                dateTimePickerBorrow.Text = dgvBorrowings.Rows[e.RowIndex].Cells["BorrowColumn4"].Value.ToString();
                dateTimePickerDue.Text = dgvBorrowings.Rows[e.RowIndex].Cells["BorrowColumn5"].Value.ToString();
                comboBox_BorrowStatus.Text = dgvBorrowings.Rows[e.RowIndex].Cells["BorrowColumn6"].Value.ToString();
                if (dgvBorrowings.Rows[e.RowIndex].Cells["BorrowColumn7"].Value != null)
                {
                    txtBorrowNote.Text = dgvBorrowings.Rows[e.RowIndex].Cells["BorrowColumn7"].Value.ToString();
                }
                else
                {
                    txtBorrowNote.Text = "";
                }


            }
        }

        Borrowing getInfoBorrowing(Borrowing borrowing)
        {
            borrowing.AccountId = int.Parse(lblBorrow_AccountID.Text);
            borrowing.BookId = int.Parse(lblBorrow_BookID.Text);
            borrowing.BorrowDate = DateTime.Parse(dateTimePickerBorrow.Text);
            borrowing.DueDate = DateTime.Parse(dateTimePickerDue.Text);
            borrowing.StatusId = (int)comboBox_BorrowStatus.SelectedValue;
            borrowing.Note = txtBorrowNote.Text;

            return borrowing;
        }

        private void buttonBorrowAdd_Click(object sender, EventArgs e)
        {
            int accId = int.Parse(lblBorrow_AccountID.Text);
            int bookId = int.Parse(lblBorrow_BookID.Text);
            Borrowing borrowing = iBorrowing.getBorrowingByAccountBookID(accId, bookId);
            if (borrowing == null || (borrowing != null && borrowing.StatusId != 1))
            {
                DialogResult check = MessageBox.Show("Do you want to add this borrowing?"
                      , "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    Borrowing newBorrowing = new Borrowing();
                    newBorrowing.BorrowingId = iBorrowing.GetLastID() + 1;
                    newBorrowing = getInfoBorrowing(newBorrowing);
                    newBorrowing.StatusId = 1;
                    iBorrowing.AddBorrowing(newBorrowing);
                    MessageBox.Show("ADD SUCCESSFULLY!", "SUCCESSFUL");
                    loadBorrowInformation();
                    refreshDGVBorrowing();
                }
            }
            else
            {
                DialogResult check = MessageBox.Show("The user is borrowing this book! Do you mean update?"
                       , "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    int id = int.Parse(lblId.Text);
                    Borrowing newBorrowing = iBorrowing.GetBorrowingById(id);
                    newBorrowing = getInfoBorrowing(newBorrowing);
                    iBorrowing.UpdateBorrowing(newBorrowing);
                    MessageBox.Show("UPDATE SUCCESSFULLY!", "SUCCESSFUL");
                    loadBorrowInformation();
                    refreshDGVBorrowing();
                }

            }
        }
        private void buttonBorrowUpdate_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you want to update this borrowing?"
                       , "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                int id = int.Parse(lblId.Text);
                Borrowing newBorrowing = iBorrowing.GetBorrowingById(id);
                newBorrowing = getInfoBorrowing(newBorrowing);
                iBorrowing.UpdateBorrowing(newBorrowing);
                MessageBox.Show("UPDATE SUCCESSFULLY!", "SUCCESSFUL");
                loadBorrowInformation();
                refreshDGVBorrowing();
            }
        }

        private void buttonBorrowDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you want to delete this borrowing?"
                       , "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                int id = int.Parse(lblId.Text);
                Borrowing deleteBorrowing = iBorrowing.GetBorrowingById(id);
                iBorrowing.DeleteBorrowing(deleteBorrowing);
                MessageBox.Show("DELETE SUCCESSFULLY!", "SUCCESSFUL");
                loadBorrowInformation();
                refreshDGVBorrowing();
            }
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

