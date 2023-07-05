namespace PRN211_Project_LibraryManagement
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(204, 409);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 29);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Get password";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(185, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 199);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 297);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 11;
            label2.Text = "Your email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(78, 349);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 12;
            label3.Text = "Result";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(204, 295);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 27);
            txtEmail.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 347);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(298, 27);
            textBox1.TabIndex = 18;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 484);
            Controls.Add(textBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox textBox1;
    }
}