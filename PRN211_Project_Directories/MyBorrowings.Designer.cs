namespace PRN211_Project_LibraryManagement
{
    partial class MyBorrowings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBorrowings));
            pictureBox_CoverPic = new PictureBox();
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
            label9 = new Label();
            panel1 = new Panel();
            lblBorrowID = new Label();
            label12 = new Label();
            groupBox_BookInfo = new GroupBox();
            lblDueDate = new Label();
            lbl = new Label();
            btnReturn = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvBorrowings = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            dateTimePickerBorrowDate = new DateTimePicker();
            dateTimePickerDueDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox_CoverPic).BeginInit();
            panel1.SuspendLayout();
            groupBox_BookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_CoverPic
            // 
            pictureBox_CoverPic.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_CoverPic.Location = new Point(39, 79);
            pictureBox_CoverPic.Margin = new Padding(5, 3, 5, 3);
            pictureBox_CoverPic.Name = "pictureBox_CoverPic";
            pictureBox_CoverPic.Size = new Size(315, 390);
            pictureBox_CoverPic.TabIndex = 0;
            pictureBox_CoverPic.TabStop = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(134, 97);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 23);
            lblId.TabIndex = 12;
            lblId.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 97);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 11;
            label8.Text = "Book ID: ";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantity.Location = new Point(138, 136);
            lblQuantity.Margin = new Padding(5, 0, 5, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(21, 23);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 136);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(96, 23);
            label11.TabIndex = 9;
            label11.Text = "Quantity:";
            // 
            // lblDescription
            // 
            lblDescription.AutoEllipsis = true;
            lblDescription.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(32, 292);
            lblDescription.Margin = new Padding(5, 0, 5, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(376, 274);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(139, 213);
            lblCategory.Margin = new Padding(5, 0, 5, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(87, 23);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor.Location = new Point(122, 176);
            lblAuthor.Margin = new Padding(5, 0, 5, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(70, 23);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            lblTitle.AutoEllipsis = true;
            lblTitle.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(32, 10);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(376, 72);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 253);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 4;
            label7.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 213);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 3;
            label6.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 176);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 2;
            label5.Text = "Author:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(164, 481);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 11;
            label9.Text = "Cover";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblBorrowID);
            panel1.Controls.Add(label12);
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
            panel1.Location = new Point(381, 79);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 600);
            panel1.TabIndex = 10;
            // 
            // lblBorrowID
            // 
            lblBorrowID.AutoSize = true;
            lblBorrowID.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBorrowID.Location = new Point(361, 97);
            lblBorrowID.Margin = new Padding(5, 0, 5, 0);
            lblBorrowID.Name = "lblBorrowID";
            lblBorrowID.Size = new Size(29, 23);
            lblBorrowID.TabIndex = 14;
            lblBorrowID.Text = "ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(237, 97);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(114, 23);
            label12.TabIndex = 13;
            label12.Text = "Borrow ID: ";
            // 
            // groupBox_BookInfo
            // 
            groupBox_BookInfo.Controls.Add(lblDueDate);
            groupBox_BookInfo.Controls.Add(lbl);
            groupBox_BookInfo.Controls.Add(label9);
            groupBox_BookInfo.Controls.Add(panel1);
            groupBox_BookInfo.Controls.Add(btnReturn);
            groupBox_BookInfo.Controls.Add(pictureBox_CoverPic);
            groupBox_BookInfo.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_BookInfo.Location = new Point(1019, 167);
            groupBox_BookInfo.Margin = new Padding(5, 3, 5, 3);
            groupBox_BookInfo.Name = "groupBox_BookInfo";
            groupBox_BookInfo.Padding = new Padding(5, 3, 5, 3);
            groupBox_BookInfo.Size = new Size(839, 685);
            groupBox_BookInfo.TabIndex = 21;
            groupBox_BookInfo.TabStop = false;
            groupBox_BookInfo.Text = "Book information";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDueDate.ForeColor = Color.FromArgb(128, 64, 0);
            lblDueDate.Location = new Point(195, 530);
            lblDueDate.Margin = new Padding(4, 0, 4, 0);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(111, 27);
            lblDueDate.TabIndex = 13;
            lblDueDate.Text = "Due Date:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl.ForeColor = Color.FromArgb(128, 64, 0);
            lbl.Location = new Point(76, 530);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(111, 27);
            lbl.TabIndex = 12;
            lbl.Text = "Due Date:";
            // 
            // btnReturn
            // 
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.Location = new Point(76, 591);
            btnReturn.Margin = new Padding(5, 3, 5, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(240, 54);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Return this book";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(426, 193);
            btnSearch.Margin = new Padding(5, 3, 5, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 31);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(115, 193);
            txtSearch.Margin = new Padding(5, 3, 5, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(301, 31);
            txtSearch.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 167);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 16;
            label2.Text = "Search book";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 47);
            label1.TabIndex = 13;
            label1.Text = "MY BORROWINGS";
            // 
            // dgvBorrowings
            // 
            dgvBorrowings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBorrowings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBorrowings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowings.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvBorrowings.Cursor = Cursors.Hand;
            dgvBorrowings.Location = new Point(112, 245);
            dgvBorrowings.Margin = new Padding(5, 3, 5, 3);
            dgvBorrowings.Name = "dgvBorrowings";
            dgvBorrowings.ReadOnly = true;
            dgvBorrowings.RowHeadersWidth = 51;
            dgvBorrowings.RowTemplate.Height = 29;
            dgvBorrowings.Size = new Size(881, 607);
            dgvBorrowings.TabIndex = 12;
            dgvBorrowings.CellContentClick += dgvBorrowings_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 320.855621F;
            Column1.HeaderText = "ID";
            Column1.MaxInputLength = 10;
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.FillWeight = 194.3279F;
            Column2.HeaderText = "BookID";
            Column2.MaxInputLength = 10;
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 85;
            // 
            // Column3
            // 
            Column3.FillWeight = 19.2970486F;
            Column3.HeaderText = "Title";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 19.2970486F;
            Column4.HeaderText = "BorrowDate";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 34.5646362F;
            Column5.HeaderText = "DueDate";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 166);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 23;
            label3.Text = "Borrow Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(802, 167);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 24;
            label4.Text = "Due Date";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(1780, 30);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 71);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // dateTimePickerBorrowDate
            // 
            dateTimePickerBorrowDate.Cursor = Cursors.Hand;
            dateTimePickerBorrowDate.Format = DateTimePickerFormat.Short;
            dateTimePickerBorrowDate.Location = new Point(564, 193);
            dateTimePickerBorrowDate.Name = "dateTimePickerBorrowDate";
            dateTimePickerBorrowDate.Size = new Size(193, 31);
            dateTimePickerBorrowDate.TabIndex = 27;
            dateTimePickerBorrowDate.ValueChanged += dateTimePickerBorrowDate_ValueChanged_1;
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Cursor = Cursors.Hand;
            dateTimePickerDueDate.Format = DateTimePickerFormat.Short;
            dateTimePickerDueDate.Location = new Point(802, 193);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(191, 31);
            dateTimePickerDueDate.TabIndex = 28;
            dateTimePickerDueDate.ValueChanged += dateTimePickerDueDate_ValueChanged;
            // 
            // MyBorrowings
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1017);
            Controls.Add(dateTimePickerDueDate);
            Controls.Add(dateTimePickerBorrowDate);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox_BookInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBorrowings);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MyBorrowings";
            Text = "MyBorrowings";
            WindowState = FormWindowState.Maximized;
            Load += MyBorrowings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_CoverPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox_BookInfo.ResumeLayout(false);
            groupBox_BookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_CoverPic;
        private Label lblId;
        private Label label8;
        private Label lblQuantity;
        private Label label11;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblTitle;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Panel panel1;
        private GroupBox groupBox_BookInfo;
        private Button btnReturn;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private Label label1;
        private DataGridView dgvBorrowings;
        private Label lbl;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private PictureBox pictureBox2;
        private Label lblDueDate;
        private DateTimePicker dateTimePickerBorrowDate;
        private DateTimePicker dateTimePickerDueDate;
        private Label lblBorrowID;
        private Label label12;
    }
}