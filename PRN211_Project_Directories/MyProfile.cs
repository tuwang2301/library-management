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
	public partial class MyProfile : Form
	{
		private Account currentAccount;
		private UserProfile currentUserProfile;
		private static IUserProfile iU = new UserProfileServices();
		public MyProfile()
		{
			InitializeComponent();
		}

		public MyProfile(Account acc) : this()
		{
			currentAccount = acc;
			currentUserProfile = iU.GetUserProfile(currentAccount.AccountId);
		}

		private void refreshForm()
		{
			currentUserProfile = iU.GetUserProfile(currentAccount.AccountId);
			txtID.Text = currentUserProfile.UserProfileId.ToString();
			txtFullName.Text = currentUserProfile.FullName;
			txtEmail.Text = currentUserProfile.Email;
			txtAddress.Text = currentUserProfile.Address;

			if (currentUserProfile.Age != null)
			{
				numericUpDown_Age.Value = (decimal)currentUserProfile.Age;
			}
			else
			{
				numericUpDown_Age.Value = 8;
			}
			if (currentUserProfile.Gender != null)
			{
				if (currentUserProfile.Gender.Value)
				{
					Image image = Image.FromFile("D:\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\man.png");
					pictureBox1.BackgroundImage = image;
					radioButton_Male.Checked = true;
				}
				else
				{
					Image image = Image.FromFile("D:\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\woman.png");
					pictureBox1.BackgroundImage = image;
					radioButton_Female.Checked = true;
				}
			}
		}

		private void MyProfile_Load(object sender, EventArgs e)
		{
			txtID.Text = currentUserProfile.UserProfileId.ToString();
			txtFullName.Text = currentUserProfile.FullName;
			txtEmail.Text = currentUserProfile.Email;
			txtAddress.Text = currentUserProfile.Address;

			if (currentUserProfile.Age != null)
			{
				numericUpDown_Age.Text = currentUserProfile.Age.ToString();
			}
			else
			{
				numericUpDown_Age.Value = 8;
			}
			if (currentUserProfile.Gender != null)
			{
				if (currentUserProfile.Gender.Value)
				{
					Image image = Image.FromFile("D:\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\man.png");
					pictureBox1.BackgroundImage = image;
					radioButton_Male.Checked = true;
				}
				else
				{
					Image image = Image.FromFile("D:\\FPT\\Summer2023\\PRN211\\Library_Management\\library-management\\PRN211_Project_Directories\\img\\woman.png");
					pictureBox1.BackgroundImage = image;
					radioButton_Female.Checked = true;
				}
			}
		}

		private void buttonSaveEdit_Click(object sender, EventArgs e)
		{
			UserProfile edit = iU.GetUserProfile(currentAccount.AccountId);

			string newEmail = txtEmail.Text;
			if (iU.GetUserProfileByEmail(newEmail) != null)
			{
				if (iU.GetUserProfileByEmail(newEmail).UserProfileId != edit.UserProfileId)
				{
					MessageBox.Show("Email already exist! Please try again!", "Email exist!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					edit.FullName = txtFullName.Text;
					edit.Email = txtEmail.Text;
					edit.Address = txtAddress.Text;
					edit.Age = (int)numericUpDown_Age.Value;
					edit.Gender = (radioButton_Female.Checked) ? false : true;
					iU.UpdateUserProfile(edit);
					MessageBox.Show("New information saved successfully!", "Edit successfully");
					refreshForm();
				}
			}
			else
			{
				edit.FullName = txtFullName.Text;
				edit.Email = txtEmail.Text;
				edit.Address = txtAddress.Text;
				edit.Age = (int)numericUpDown_Age.Value;
				edit.Gender = (radioButton_Female.Checked) ? false : true;
				iU.UpdateUserProfile(edit);
				MessageBox.Show("New information saved successfully!", "Edit successfully");
				refreshForm();

			}

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
