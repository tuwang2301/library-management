namespace PRN211_Project_LibraryManagement
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            button1 = new Button();
            dgvBooks = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel_myBorrowings = new LinkLabel();
            label2 = new Label();
            txtSearch = new TextBox();
            comboBox_Category = new ComboBox();
            label3 = new Label();
            btnSearch = new Button();
            groupBox_BookInfo = new GroupBox();
            label9 = new Label();
            panel1 = new Panel();
            lblId = new Label();
            label8 = new Label();
            lblQuantity = new Label();
            label11 = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnBorrow = new Button();
            pictureBox_CoverPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox_BookInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CoverPic).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(1677, 64);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(130, 33);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvBooks.Cursor = Cursors.Hand;
            dgvBooks.Location = new Point(98, 223);
            dgvBooks.Margin = new Padding(4, 3, 4, 3);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 29;
            dgvBooks.Size = new Size(889, 633);
            dgvBooks.TabIndex = 1;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 320.855621F;
            Column1.HeaderText = "BookId";
            Column1.MaxInputLength = 10;
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 85;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.FillWeight = 55.8288765F;
            Column2.HeaderText = "Quantity";
            Column2.MaxInputLength = 10;
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.FillWeight = 55.8288765F;
            Column3.HeaderText = "Title";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 55.8288765F;
            Column4.HeaderText = "Author";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 55.8288765F;
            Column5.HeaderText = "Category";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 55.8288765F;
            Column6.HeaderText = "Description";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 47);
            label1.TabIndex = 2;
            label1.Text = "LIST OF BOOKS";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(1562, 40);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 71);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // linkLabel_myBorrowings
            // 
            linkLabel_myBorrowings.AutoSize = true;
            linkLabel_myBorrowings.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel_myBorrowings.LinkColor = Color.Black;
            linkLabel_myBorrowings.Location = new Point(1344, 64);
            linkLabel_myBorrowings.Margin = new Padding(4, 0, 4, 0);
            linkLabel_myBorrowings.Name = "linkLabel_myBorrowings";
            linkLabel_myBorrowings.Size = new Size(172, 27);
            linkLabel_myBorrowings.TabIndex = 4;
            linkLabel_myBorrowings.TabStop = true;
            linkLabel_myBorrowings.Text = "My borrowings";
            linkLabel_myBorrowings.LinkClicked += linkLabel_myBorrowings_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 181);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 5;
            label2.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(187, 177);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(246, 31);
            txtSearch.TabIndex = 6;
            // 
            // comboBox_Category
            // 
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Location = new Point(696, 177);
            comboBox_Category.Margin = new Padding(4, 3, 4, 3);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(291, 31);
            comboBox_Category.TabIndex = 7;
            comboBox_Category.SelectedIndexChanged += comboBox_Category_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 8;
            label3.Text = "Category";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(441, 177);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 31);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox_BookInfo
            // 
            groupBox_BookInfo.Controls.Add(label9);
            groupBox_BookInfo.Controls.Add(panel1);
            groupBox_BookInfo.Controls.Add(btnBorrow);
            groupBox_BookInfo.Controls.Add(pictureBox_CoverPic);
            groupBox_BookInfo.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_BookInfo.Location = new Point(995, 178);
            groupBox_BookInfo.Margin = new Padding(4, 3, 4, 3);
            groupBox_BookInfo.Name = "groupBox_BookInfo";
            groupBox_BookInfo.Padding = new Padding(4, 3, 4, 3);
            groupBox_BookInfo.Size = new Size(815, 678);
            groupBox_BookInfo.TabIndex = 10;
            groupBox_BookInfo.TabStop = false;
            groupBox_BookInfo.Text = "Book information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(177, 494);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 11;
            label9.Text = "Cover";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(lblAuthor);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(400, 60);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 612);
            panel1.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(72, 84);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 23);
            lblId.TabIndex = 12;
            lblId.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 84);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(41, 23);
            label8.TabIndex = 11;
            label8.Text = "ID: ";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantity.Location = new Point(127, 118);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(85, 23);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 118);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(96, 23);
            label11.TabIndex = 9;
            label11.Text = "Quantity:";
            // 
            // lblDescription
            // 
            lblDescription.AutoEllipsis = true;
            lblDescription.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(23, 256);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(351, 311);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(128, 185);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(87, 23);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor.Location = new Point(111, 153);
            lblAuthor.Margin = new Padding(4, 0, 4, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(70, 23);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            lblTitle.AutoEllipsis = true;
            lblTitle.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(23, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(351, 63);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 220);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 4;
            label7.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 185);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 3;
            label6.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 153);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 2;
            label5.Text = "Author:";
            // 
            // btnBorrow
            // 
            btnBorrow.Cursor = Cursors.Hand;
            btnBorrow.Location = new Point(95, 556);
            btnBorrow.Margin = new Padding(4, 3, 4, 3);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(220, 71);
            btnBorrow.TabIndex = 9;
            btnBorrow.Text = "Borrow this book";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // pictureBox_CoverPic
            // 
            pictureBox_CoverPic.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_CoverPic.Location = new Point(28, 69);
            pictureBox_CoverPic.Margin = new Padding(4, 3, 4, 3);
            pictureBox_CoverPic.Name = "pictureBox_CoverPic";
            pictureBox_CoverPic.Size = new Size(352, 409);
            pictureBox_CoverPic.TabIndex = 0;
            pictureBox_CoverPic.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 868);
            Controls.Add(groupBox_BookInfo);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(comboBox_Category);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(linkLabel_myBorrowings);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dgvBooks);
            Controls.Add(button1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox_BookInfo.ResumeLayout(false);
            groupBox_BookInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CoverPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvBooks;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel_myBorrowings;
        private Label label2;
        private TextBox txtSearch;
        private ComboBox comboBox_Category;
        private Label label3;
        private Button btnSearch;
        private GroupBox groupBox_BookInfo;
        private Label label5;
        private PictureBox pictureBox_CoverPic;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblTitle;
        private Label label7;
        private Label label6;
        private Button btnBorrow;
        private Panel panel1;
        private Label label9;
        private Label lblQuantity;
        private Label label11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label lblId;
        private Label label8;
    }
}