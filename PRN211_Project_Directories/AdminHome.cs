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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            List<Account> accounts = iAccount.GetAllAccounts();
            List<Category> categories = iCat.GetAllCategories();
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
            // Display all Accounts dgv
            displayDGVAccounts(accounts);
            // Load account info
            loadAccountInformation();
            // Load rolename combobox
            loadRoleName();
            // Display all Categories dgv
            displayDGVCategories(categories);
            // Load Cat information
            loadCategoryInformation();
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
                string gender = (item.Gender == null) ? "Unknown" : (item.Gender.Value) ? "Male" : "Female";
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

        void displayDGVAccounts(List<Account> accounts)
        {
            dgvOther_Account.Rows.Clear();
            foreach (var item in accounts)
            {
                string status = (item.Status) ? "Enabled" : "Disabled";
                dgvOther_Account.Rows.Add(item.AccountId, item.Username, item.RoleName, status);
            }
        }
        void displayDGVCategories(List<Category> categories)
        {
            dgvOther_Category.Rows.Clear();
            foreach (var item in categories)
            {
                dgvOther_Category.Rows.Add(item.CategoryId, item.CategoryName);
            }
        }

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
        private void loadRoleName()
        {
            List<Account> accounts = iAccount.GetAllAccounts();
            var groupByRoleName = accounts.GroupBy((x) => x.RoleName).ToList();
            comboBoxOther_roleName.DisplayMember = "key";
            comboBoxOther_roleName.ValueMember = "key";
            comboBoxOther_roleName.DataSource = groupByRoleName;
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

        void loadAccountInformation()
        {
            lblOtherAccountID.Text = dgvOther_Account.Rows[0].Cells["AccountColumn1"].Value.ToString();
            txtOther_UserName.Text = dgvOther_Account.Rows[0].Cells["AccountColumn2"].Value.ToString();
            comboBoxOther_roleName.Text = dgvOther_Account.Rows[0].Cells["AccountColumn3"].Value.ToString();
            string status = dgvOther_Account.Rows[0].Cells["AccountColumn4"].Value.ToString();
            if (status.Equals("Enabled"))
            {
                radioButton_Other_Enable.Checked = true;
            }
            else
            {
                radioButton_Other_Disable.Checked = true;
            }
        }

        void loadCategoryInformation()
        {
            lblOther_CatID.Text = dgvOther_Category.Rows[0].Cells["CategoryColumn1"].Value.ToString();
            txtOther_CategoryName.Text = dgvOther_Category.Rows[0].Cells["CategoryColumn2"].Value.ToString();
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

        void refreshDGVAccount()
        {
            List<Account> accounts = iAccount.GetAllAccounts();
            displayDGVAccounts(accounts);
        }

        void refreshDGVUserProfile()
        {
            List<UserProfile> userProfiles = iUserProfile.GetAllUserProfiles();
            displayDGVUserProfles(userProfiles);
        }

        void refreshDGVCategory()
        {
            List<Category> categories = iCat.GetAllCategories();
            displayDGVCategories(categories);
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
                int id = int.Parse(lblBorrowId.Text);
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

        private void dateTimePickerBorrowDate_ValueChanged(object sender, EventArgs e)
        {
            List<Borrowing> borrowingList = iBorrowing.GetAllBorrowings();
            string borrowDate = dateTimePickerBorrowDate.Text;
            List<Borrowing> result = iBorrowing.getBorrowingsByBorrowDate(borrowingList, DateTime.Parse(borrowDate));
            displayDGVBorrowings(result);
        }

        private void dateTimePickerDueDate_ValueChanged(object sender, EventArgs e)
        {
            List<Borrowing> borrowingList = iBorrowing.GetAllBorrowings();
            DateTime dueDate = dateTimePickerDueDate.Value;
            List<Borrowing> result = iBorrowing.getBorrowingsByDueDate(borrowingList, dueDate);
            displayDGVBorrowings(result);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile(currentAccount);
            myProfile.Show();
        }

        private void dgvOther_Account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblOtherAccountID.Text = dgvOther_Account.Rows[e.RowIndex].Cells["AccountColumn1"].Value.ToString();
                txtOther_UserName.Text = dgvOther_Account.Rows[e.RowIndex].Cells["AccountColumn2"].Value.ToString();
                comboBoxOther_roleName.Text = dgvOther_Account.Rows[e.RowIndex].Cells["AccountColumn3"].Value.ToString();
                string status = dgvOther_Account.Rows[e.RowIndex].Cells["AccountColumn4"].Value.ToString();
                if (status.Equals("Enabled"))
                {
                    radioButton_Other_Enable.Checked = true;
                }
                else
                {
                    radioButton_Other_Disable.Checked = true;
                }
            }
        }

        private void dgvOther_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblOther_CatID.Text = dgvOther_Category.Rows[e.RowIndex].Cells["CategoryColumn1"].Value.ToString();
                txtOther_CategoryName.Text = dgvOther_Category.Rows[e.RowIndex].Cells["CategoryColumn2"].Value.ToString();
            }
        }

        private void buttonOtherAddAccount_Click(object sender, EventArgs e)
        {
            string fullName, userName, password, confirm;
            userName = txtOther_UserName.Text;
            if (iAccount.GetAccountByUsername(userName) != null)
            {
                DialogResult check = MessageBox.Show("The username already exist! Do you mean update?"
                      , "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    int id = int.Parse(lblOtherAccountID.Text);
                    Account account = iAccount.GetAccountById(id);
                    account.RoleName = comboBoxOther_roleName.SelectedValue.ToString();
                    Boolean status = (radioButton_Other_Enable.Checked) ? true : false;
                    account.Status = status;
                    iAccount.UpdateAccount(account);
                    MessageBox.Show("ROLENAME/STATUS UPDATE SUCCESSFULLY!", "UPDATE ACCOUNT SUCCESSFULLY!");
                    refreshDGVAccount();
                    loadAccountInformation();
                }

            }
            else
            {
                password = txtOtherPassword.Text;
                if (password.Length == 0)
                {
                    MessageBox.Show("Password required! Please enter password!"
                      , "ADD FAIL", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    DialogResult check = MessageBox.Show("Do you want to add this account?"
                     , "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        Account newAcc = new Account();
                        UserProfile newUp = new UserProfile();
                        int newID = iAccount.GetLastID() + 1;
                        newAcc.AccountId = newID;
                        newAcc.Username = userName;
                        newAcc.Password = password;
                        newAcc.RoleName = comboBoxOther_roleName.SelectedValue.ToString();
                        Boolean status = (radioButton_Other_Enable.Checked) ? true : false;
                        newAcc.Status = status;
                        newUp.UserProfileId = iUserProfile.GetLastID() + 1;
                        newUp.FullName = userName;
                        newUp.AccountId = newID;
                        iAccount.AddAccount(newAcc);
                        iUserProfile.AddUserProfile(newUp);
                        MessageBox.Show("ADD ACCOUNT SUCCESSFULLY!", "ADD ACCOUNT SUCCESSFULLY!");
                        refreshDGVAccount();
                        refreshDGVUserProfile();
                        loadAccountInformation();

                    }
                }

            }
        }

        private void buttonOtherUpdateAccount_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you want to update this account?"
                     , "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                int id = int.Parse(lblOtherAccountID.Text);
                Account account = iAccount.GetAccountById(id);
                account.RoleName = comboBoxOther_roleName.SelectedValue.ToString();
                Boolean status = (radioButton_Other_Enable.Checked) ? true : false;
                account.Status = status;
                iAccount.UpdateAccount(account);
                MessageBox.Show("ROLENAME/STATUS UPDATE SUCCESSFULLY!", "UPDATE ACCOUNT SUCCESSFULLY!");
                refreshDGVAccount();
                loadAccountInformation();
            }
        }

        private void buttonOtherDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("To delete this account, you have to delete everything relating to them!\nDisable them if you want!"
                     , "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void buttonOtherDelCat_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("To delete this category, you have to delete everything relating to them!\nChange their name either!"
                   , "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void buttonOtherAddCat_Click(object sender, EventArgs e)
        {
            string name = txtOther_CategoryName.Text;
            if (iCat.GetCategoryByName(name) != null)
            {
                DialogResult check = MessageBox.Show("The category name already exist! Please try another one!"
                   , "ADD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Category category = new Category();
                category.CategoryId = iCat.GetLastID() + 1;
                category.CategoryName = name;
                iCat.AddCategory(category);
                MessageBox.Show("ADD CATEGORY SUCCESSFULLY!", "ADD CATEGORY SUCCESSFULLY!");
                refreshDGVCategory();
                refreshDGVCategory();
                loadCategory();
                loadCategoryInformation();
            }
        }

        private void buttonOtherUpdCat_Click(object sender, EventArgs e)
        {
            string name = txtOther_CategoryName.Text;
            int id = int.Parse(lblOther_CatID.Text);
            Category cate = iCat.GetCategoryById(id);
            if (iCat.GetCategoryByName(name).CategoryId != cate.CategoryId)
            {
                DialogResult check = MessageBox.Show("The category name already exist! Please try another one!"
                   , "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cate.CategoryName = name;
                iCat.UpdateCategory(cate);
                MessageBox.Show("UPDATE CATEGORY SUCCESSFULLY!", "UPDATE CATEGORY SUCCESSFULLY!");
                refreshDGVCategory();
                loadCategoryInformation();
            }
        }
    }


}

