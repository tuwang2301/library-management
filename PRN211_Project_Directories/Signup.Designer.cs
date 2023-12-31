﻿namespace PRN211_Project_LibraryManagement
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            pictureBox1 = new PictureBox();
            txtFullname = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtConfirm = new TextBox();
            label4 = new Label();
            btnSignup = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(217, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 127);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(34, 190);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(504, 27);
            txtFullname.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 166);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 5;
            label2.Text = "FullName";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(34, 259);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(504, 27);
            txtUsername.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 235);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 331);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(504, 27);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 307);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(34, 400);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(504, 27);
            txtConfirm.TabIndex = 12;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 376);
            label4.Name = "label4";
            label4.Size = new Size(161, 21);
            label4.TabIndex = 11;
            label4.Text = "Confirm Password";
            // 
            // btnSignup
            // 
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.Location = new Point(217, 467);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(133, 43);
            btnSignup.TabIndex = 15;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(514, 334);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(514, 403);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 21);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Signup
            // 
            AcceptButton = btnSignup;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(577, 542);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSignup);
            Controls.Add(txtConfirm);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtFullname);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Signup";
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtFullname;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtConfirm;
        private Label label4;
        private Button btnSignup;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}