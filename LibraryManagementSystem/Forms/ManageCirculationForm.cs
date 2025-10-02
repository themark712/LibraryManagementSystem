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
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem.Forms
{
	public partial class ManageCirculationForm : Form
	{
		AppUserController? userCont;
		BookController? bookCont;
		CirculationController? circCont;
		AppUser? selectedUser;

		public ManageCirculationForm()
		{
			InitializeComponent();
		}

		private void ManageCirculationForm_Load(object sender, EventArgs e)
		{
			userCont = new AppUserController();
			bookCont = new BookController();
			circCont = new CirculationController();

			labelStatus.Text = "";
			labelCheckOutCount.Text = circCont.GetCirculationCount()!.ToString() + " books checked out";

			RefreshUserList();
			RefreshBookList();
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

			textCheckOutDate.Text = selectedUser!.AppUserId.ToString();
			labelName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
			labelCardNumber.Text = selectedUser.UserNumber;
			labelPhone.Text = selectedUser.Phone;
			labelEmail.Text = selectedUser.Email;

			int booksCount = 0;
			var userBooks = circCont!.GetUserBooks(Convert.ToInt32(selectedUser.AppUserId))!;

			foreach (var item in userBooks)
			{
				string listViewText = $"{item.Title!}"; // + " (" + item.Year.ToString() + ")";
				ListViewItem book = new ListViewItem();
				book.Text = item.Title;
				book.SubItems.Add(item.Year.ToString());
				book.Tag = circCont.GetCirculationId(selectedUser.AppUserId, item.BookId);
			}

			booksCount = userBooks != null ? userBooks.Count() : 0;
			labelUserCheckOutCount.Text = booksCount.ToString() + " books";

			var books = bookCont!.GetBooks();

			DataTable dt = new DataTable();

			dt.Columns.Add("Id");
			dt.Columns.Add("Title");
			dt.Columns.Add("Year");

			foreach (var item in userBooks!)
			{
				var row = dt.NewRow();
				row[0] = circCont.GetCirculationId(selectedUser.AppUserId, item.BookId);
				row[1] = item.Title;
				row[2] = item.Year;
				dt.Rows.Add(row);
			}

			dgCirculation.DataSource = dt;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			//string errorString = ValidateData();

			//if (errorString == "")
			//{
			//	int newAuthorId = userCont!.AddAuthor(textFirstName.Text, textLastName.Text, textCardNumber.Text, textDOD.Text, textHometown.Text, rtbEducation.Text, rtbAbout.Text);
			//	if (newAuthorId != 0)
			//	{
			//		labelStatus.Text = "Author added";
			//		selectedUser = userCont.GetAuthor(newAuthorId);
			//		RefreshUserList();
			//	}
			//}
			//else
			//{
			//	MessageBox.Show("Author's first and last name are required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			//string errorString = ValidateData();

			//if (errorString == "")
			//{
			//	if (userCont!.UpdateAuthor(Convert.ToInt32(textId.Text), textFirstName.Text, textLastName.Text, textCardNumber.Text, textDOD.Text, textHometown.Text, rtbEducation.Text, rtbAbout.Text))
			//	{
			//		labelStatus.Text = "Author updated";
			//		selectedUser = userCont.GetAuthor(Convert.ToInt32(textId.Text));
			//		RefreshUserList();
			//	}
			//}
			//else
			//{
			//	MessageBox.Show(errorString, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//}
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			//int userBookCount = bookCont!.GetBooksByAuthor(Convert.ToInt32(textId.Text))!.Count();
			//string warningMessage = "WARNING: this user currently has " + userBookCount.ToString() + " books in your system." + Environment.NewLine + Environment.NewLine;
			//warningMessage += selectedUser!.FirstName + " " + selectedUser.LastName + " (b: " + selectedUser.DOB + ")" + "\n\n";
			//warningMessage += "This action will also delete ALL BOOKS assigned to this user. Continue?";

			//if (MessageBox.Show(warningMessage, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			//{
			//	int id = Convert.ToInt32(textId.Text);

			//	if (id > 0)
			//	{
			//		if (userCont!.DeleteAuthor(Convert.ToInt32(textId.Text)))
			//		{
			//			labelStatus.Text = "Author deleted";
			//			selectedUser = null;
			//			RefreshUserList();
			//		}
			//	}
			//	else
			//	{
			//		MessageBox.Show("No user ID found. Select an user from the list to delete", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	}
			//}
		}

		private void RefreshUserList()
		{
			var users = userCont!.GetUsers();
			dgUsers.DataSource = users;
			dgUsers.Columns[0].Visible = false;
			dgUsers.Columns[4].Visible = false;
			dgUsers.Columns[5].Visible = false;
			dgUsers.Columns[6].Visible = false;
			dgUsers.Columns[7].Visible = false;
			dgUsers.Columns[8].Visible = false;
			dgUsers.Columns[9].Visible = false;
			dgUsers.Columns[10].Visible = false;
			dgUsers.Columns[11].Visible = false;
			dgUsers.Columns[13].Visible = false;

			if (selectedUser == null)
			{
				textCheckOutDate.Text = "";
				textRenewals.Text = "";
				textDueDate.Text = "";
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

		private void RefreshBookList(List<Book>? bookList = null)
		{
			List<Book> books;

			if (bookList == null)
			{
				books = bookCont!.GetBooks()!;
			}
			else   // bookList parameter is not  null, getting books from search
			{
				books = bookList;
			}

			dgBooks.DataSource = null;

			DataTable dt = new DataTable();

			dt.Columns.Add("Title");
			dt.Columns.Add("Author");
			dt.Columns.Add("Year");
			dt.Columns.Add("Copies");

			foreach (Book book in books!)
			{
				var row = dt.NewRow();
				row[0] = book.Title;
				row[1] = book.Author.FullName;
				row[2] = book.Year;
				int? availableCopies = bookCont!.GetAvailableCopies(book.BookId);
				row[3] = availableCopies.ToString();
				dt.Rows.Add(row);
			}

			dgBooks.DataSource = dt;

			foreach (DataGridViewRow row in dgBooks.Rows) {
			 if (Convert.ToInt32(row.Cells[3].Value) == 0)
				{
					row.DefaultCellStyle.BackColor = Color.Red;
					row.DefaultCellStyle.ForeColor = Color.White;
				}
			}
		}

		private string ValidateData()
		{
			string errorString = "";

			if (textDueDate.Text.Length == 0)
			{
				errorString += "Author first name is required" + Environment.NewLine;
			}

			if (textRenewals.Text.Length == 0)
			{
				errorString += "Author last name is required" + Environment.NewLine;
			}

			return errorString;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textUserSearch_TextChanged(object sender, EventArgs e)
		{
			List<AppUser>? users = userCont!.SearchUsers(textUserSearch.Text);
			dgUsers.DataSource = users;
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			textUserSearch.Text = "";
			RefreshUserList();
		}

		private void buttonShowAuthorBooks_Click(object sender, EventArgs e)
		{
			if (textCheckOutDate.Text != "")
			{
				App.AuthorId = Convert.ToInt32(textCheckOutDate.Text);
				ManageBooksForm booksForm = new ManageBooksForm();
				booksForm.ShowDialog();
			}
		}

		private void dgCirculation_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int circulationId = Convert.ToInt32(dgCirculation.SelectedRows[0].Cells[0].Value);

			Circulation circulationInfo = circCont!.GetCirculationInfo(circulationId);
			textCheckOutDate.Text = circulationInfo.CheckOutDate;
			textDueDate.Text = circulationInfo.DueDate;
			textRenewals.Text = circulationInfo.NumberRenewals.ToString();
		}

		private void textBookSearch_TextChanged(object sender, EventArgs e)
		{
			List<Book>? books = bookCont!.SearchBooks(textBookSearch.Text);
			RefreshBookList(books!);
		}

		private void buttonClearBookSearch_Click(object sender, EventArgs e)
		{
			textBookSearch.Text = "";
			RefreshBookList();
		}
	}
}
