namespace PRN211_Project_LibraryManagement
{
	partial class MyProfile
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
			groupBox1 = new GroupBox();
			buttonSaveEdit = new Button();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			radioButton_Male = new RadioButton();
			radioButton_Female = new RadioButton();
			numericUpDown_Age = new NumericUpDown();
			txtAddress = new TextBox();
			txtEmail = new TextBox();
			txtFullName = new TextBox();
			txtID = new TextBox();
			label1 = new Label();
			label15 = new Label();
			label3 = new Label();
			label10 = new Label();
			label17 = new Label();
			label18 = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Age).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(buttonSaveEdit);
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.Controls.Add(panel2);
			groupBox1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.Location = new Point(58, 51);
			groupBox1.Margin = new Padding(7, 3, 7, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(7, 3, 7, 3);
			groupBox1.Size = new Size(676, 406);
			groupBox1.TabIndex = 24;
			groupBox1.TabStop = false;
			groupBox1.Text = "User information";
			// 
			// buttonSaveEdit
			// 
			buttonSaveEdit.Cursor = Cursors.Hand;
			buttonSaveEdit.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			buttonSaveEdit.Location = new Point(256, 354);
			buttonSaveEdit.Name = "buttonSaveEdit";
			buttonSaveEdit.Size = new Size(147, 36);
			buttonSaveEdit.TabIndex = 26;
			buttonSaveEdit.Text = "Save";
			buttonSaveEdit.UseVisualStyleBackColor = true;
			buttonSaveEdit.Click += buttonSaveEdit_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(10, 69);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(211, 267);
			pictureBox1.TabIndex = 25;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(radioButton_Male);
			panel2.Controls.Add(radioButton_Female);
			panel2.Controls.Add(numericUpDown_Age);
			panel2.Controls.Add(txtAddress);
			panel2.Controls.Add(txtEmail);
			panel2.Controls.Add(txtFullName);
			panel2.Controls.Add(txtID);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(label15);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label10);
			panel2.Controls.Add(label17);
			panel2.Controls.Add(label18);
			panel2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
			panel2.Location = new Point(231, 69);
			panel2.Margin = new Padding(7, 3, 7, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(418, 267);
			panel2.TabIndex = 10;
			// 
			// radioButton_Male
			// 
			radioButton_Male.AutoSize = true;
			radioButton_Male.Cursor = Cursors.Hand;
			radioButton_Male.Location = new Point(148, 174);
			radioButton_Male.Name = "radioButton_Male";
			radioButton_Male.Size = new Size(76, 27);
			radioButton_Male.TabIndex = 19;
			radioButton_Male.TabStop = true;
			radioButton_Male.Text = "Male";
			radioButton_Male.UseVisualStyleBackColor = true;
			// 
			// radioButton_Female
			// 
			radioButton_Female.AutoSize = true;
			radioButton_Female.Cursor = Cursors.Hand;
			radioButton_Female.Location = new Point(265, 174);
			radioButton_Female.Name = "radioButton_Female";
			radioButton_Female.Size = new Size(98, 27);
			radioButton_Female.TabIndex = 19;
			radioButton_Female.TabStop = true;
			radioButton_Female.Text = "Female";
			radioButton_Female.UseVisualStyleBackColor = true;
			// 
			// numericUpDown_Age
			// 
			numericUpDown_Age.Location = new Point(120, 134);
			numericUpDown_Age.Margin = new Padding(4, 3, 4, 3);
			numericUpDown_Age.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
			numericUpDown_Age.Name = "numericUpDown_Age";
			numericUpDown_Age.Size = new Size(273, 31);
			numericUpDown_Age.TabIndex = 16;
			numericUpDown_Age.Value = new decimal(new int[] { 8, 0, 0, 0 });
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(120, 213);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(273, 31);
			txtAddress.TabIndex = 15;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(120, 93);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(273, 31);
			txtEmail.TabIndex = 15;
			// 
			// txtFullName
			// 
			txtFullName.Location = new Point(120, 53);
			txtFullName.Name = "txtFullName";
			txtFullName.Size = new Size(273, 31);
			txtFullName.TabIndex = 15;
			// 
			// txtID
			// 
			txtID.Location = new Point(120, 13);
			txtID.Name = "txtID";
			txtID.ReadOnly = true;
			txtID.Size = new Size(273, 31);
			txtID.TabIndex = 15;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(7, 16);
			label1.Margin = new Padding(7, 0, 7, 0);
			label1.Name = "label1";
			label1.Size = new Size(39, 29);
			label1.TabIndex = 14;
			label1.Text = "ID: ";
			label1.UseCompatibleTextRendering = true;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(7, 56);
			label15.Margin = new Padding(7, 0, 7, 0);
			label15.Name = "label15";
			label15.Size = new Size(103, 23);
			label15.TabIndex = 13;
			label15.Text = "Fullname:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(7, 96);
			label3.Margin = new Padding(7, 0, 7, 0);
			label3.Name = "label3";
			label3.Size = new Size(69, 23);
			label3.TabIndex = 11;
			label3.Text = "Email:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(7, 136);
			label10.Margin = new Padding(7, 0, 7, 0);
			label10.Name = "label10";
			label10.Size = new Size(50, 23);
			label10.TabIndex = 9;
			label10.Text = "Age:";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(7, 216);
			label17.Margin = new Padding(7, 0, 7, 0);
			label17.Name = "label17";
			label17.Size = new Size(85, 23);
			label17.TabIndex = 3;
			label17.Text = "Address";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(7, 176);
			label18.Margin = new Padding(7, 0, 7, 0);
			label18.Name = "label18";
			label18.Size = new Size(84, 23);
			label18.TabIndex = 2;
			label18.Text = "Gender:";
			// 
			// MyProfile
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 492);
			Controls.Add(groupBox1);
			Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 3, 4, 3);
			Name = "MyProfile";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MyProfile";
			Load += MyProfile_Load;
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_Age).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Panel panel2;
		private Label label15;
		private Label label3;
		private Label label10;
		private Label label17;
		private Label label18;
		private PictureBox pictureBox1;
		private Label label1;
		private NumericUpDown numericUpDown_Age;
		private TextBox txtAddress;
		private TextBox txtEmail;
		private TextBox txtFullName;
		private TextBox txtID;
		private Button buttonSaveEdit;
		private RadioButton radioButton_Male;
		private RadioButton radioButton_Female;
	}
}