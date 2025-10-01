using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Controllers;
using LibraryManagementSystem.Database;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
	public partial class ManageUsersForm : Form
	{
		AppUserController? userCont;
		BookController? bookCont;
		AppUser? selectedUser;

		public ManageUsersForm()
		{
			InitializeComponent();
		}

		private void ManageUsersForm_Load(object sender, EventArgs e)
		{
			userCont = new AppUserController();
			bookCont = new BookController();

			labelStatus.Text = "";
			labelUsersCount.Text = userCont.GetUsers()!.Count.ToString() + " users";

			comboRole.Items.Clear();
			comboRole.Items.Add("");
			comboRole.Items.Add("admin");
			comboRole.Items.Add("user");

			RefreshUserList();
			buttonAdd.Enabled = true;
			buttonUpdate.Enabled = true;
			buttonDelete.Enabled = true;
			dgUsers.ClearSelection();
		}

		private void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int selectedId = Convert.ToInt32(dgUsers.SelectedRows[0].Cells[0].Value);

			using (LmsContext context = new LmsContext())
			{
				selectedUser = context.AppUsers.Where(i => i.AppUserId == selectedId).FirstOrDefault();
			}

			textId.Text = selectedUser!.AppUserId.ToString();
			textFirstName.Text = selectedUser.FirstName;
			textLastName.Text = selectedUser.LastName;
			textAddress1.Text = selectedUser.Address1;
			textAddress2.Text = selectedUser.Address2;
			textCity.Text = selectedUser.City;
			textZip.Text = selectedUser.Zip;
			comboState.SelectedValue = selectedUser.State;

			int booksCount = 0;
			//booksCount = bookCont!.GetBooksByUser(Convert.ToInt32(textId.Text))!.Count();
			labelBooksCount.Text = booksCount.ToString() + " books";
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			string errorString = ValidateData();

			if (errorString == "")
			{
				int newAppUserId = userCont!.AddUser(textFirstName.Text, textLastName.Text, textUserNumber.Text, textAddress1.Text, textAddress2.Text, textCity.Text, textAddress1.Text, textAddress2.Text, textPhone.Text, comboRole.SelectedValue!.ToString()!);
				if (newAppUserId != 0)
				{
					labelStatus.Text = "User added";
					selectedUser = userCont.GetUser(newAppUserId);
					RefreshUserList();
				}
			}
			else
			{
				MessageBox.Show("User's first and last name are required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			string errorString = ValidateData();

			if (errorString == "")
			{
				if (userCont!.UpdateUser(Convert.ToInt32(textId.Text), textFirstName.Text, textLastName.Text, textUserNumber.Text, textAddress1.Text, textAddress2.Text, textCity.Text, textAddress1.Text, textAddress2.Text, textPhone.Text, comboRole.SelectedValue!.ToString()!))
				{
					labelStatus.Text = "User updated";
					selectedUser = userCont.GetUser(Convert.ToInt32(textId.Text));
					RefreshUserList();
				}
			}
			else
			{
				MessageBox.Show(errorString, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			int userBookCount = bookCont!.GetBooksByUser(Convert.ToInt32(textId.Text))!.Count();
			string warningMessage = "WARNING: this user currently has " + userBookCount.ToString() + " books in your system." + Environment.NewLine + Environment.NewLine;
			warningMessage += selectedUser!.FirstName + " " + selectedUser.LastName + " (b: " + selectedUser.DOB + ")" + "\n\n";
			warningMessage += "This action will also delete ALL BOOKS assigned to this user. Continue?";

			if (MessageBox.Show(warningMessage, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				int id = Convert.ToInt32(textId.Text);

				if (id > 0)
				{
					if (userCont!.DeleteUser(Convert.ToInt32(textId.Text)))
					{
						labelStatus.Text = "User deleted";
						selectedUser = null;
						RefreshUserList();
					}
				}
				else
				{
					MessageBox.Show("No user ID found. Select an user from the list to delete", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void RefreshUserList()
		{
			var users = userCont!.GetUsers();
			dgUsers.DataSource = users;
			dgUsers.Columns[0].Visible = false;
			dgUsers.Columns[4].Visible = false;
			dgUsers.Columns[5].Visible = false;
			dgUsers.Columns[7].Visible = false;
			dgUsers.Columns[8].Visible = false;
			dgUsers.Columns[9].Visible = false;
			dgUsers.Columns[10].Visible = false;
			dgUsers.Columns[11].Visible = false;
			dgUsers.Columns[12].Visible = false;

			if (selectedUser == null)
			{
				textId.Text = "";
				textLastName.Text = "";
				textFirstName.Text = "";
				textUserNumber.Text = "";
				textAddress1.Text = "";
				textAddress2.Text = "";
				textCity.Text = "";
				comboRole.SelectedIndex = 0;
			}
			else
			{
				for (int i = 0; i < dgUsers.Rows.Count; i++)
				{
					if (Convert.ToInt32(dgUsers.Rows[i].Cells[0].Value) == selectedUser.AppUserId)
					{
						dgUsers.Rows[i].Selected = true;
					}
				}
			}
		}

		private string ValidateData()
		{
			string errorString = "";

			if (textFirstName.Text.Length == 0)
			{
				errorString += "User first name is required" + Environment.NewLine;
			}

			if (textLastName.Text.Length == 0)
			{
				errorString += "User last name is required" + Environment.NewLine;
			}

			string inputPhone = textPhone.Text;
			if (inputPhone.Length == 0)
			{
				errorString += "Phone number is required";
			}
			else
			{
				int areaCode;
				bool isAreaCodeNumber = int.TryParse(inputPhone.Substring(0, 4), out areaCode);
				int prefix;
				bool isPrefixNumber = int.TryParse(inputPhone.Substring(0, 4), out prefix);
				int lastFour;
				bool isLastFourNumber = int.TryParse(inputPhone.Substring(0, 4), out lastFour);

				bool firstDash = inputPhone.Substring(3, 1) == "-" ? true : false;
				bool secondDash = inputPhone.Substring(7, 1) == "-" ? true : false;

				if (!isAreaCodeNumber || !isPrefixNumber || !isLastFourNumber || !firstDash || !secondDash)
				{
					errorString += "Phone number must be in valid format (xxx-xxx-xxxx)";
				}
			}

			if (comboRole.SelectedText == "")
			{
				errorString += "User's role is required";
			}

			if (textUserNumber.Text.Length == 0)
			{
				errorString += "User card number is required";
			}


			return errorString;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textSearch_TextChanged(object sender, EventArgs e)
		{
			List<AppUser>? users = userCont!.SearchUsers(textSearch.Text);
			dgUsers.DataSource = users;
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			textSearch.Text = "";
			RefreshUserList();
		}

		private void buttonShowUserBooks_Click(object sender, EventArgs e)
		{
			if (textId.Text != "")
			{
				App.User = userCont!.GetUser(Convert.ToInt32(textId.Text));
				ManageBooksForm booksForm = new ManageBooksForm();
				booksForm.ShowDialog();
			}
		}
	}
}
