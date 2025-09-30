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
	public partial class ManageAuthorsForm : Form
	{
		AuthorController? authorCont;
		BookController? bookCont;
		Author? selectedAuthor;

		public ManageAuthorsForm()
		{
			InitializeComponent();
		}

		private void ManageAuthorsForm_Load(object sender, EventArgs e)
		{
			authorCont = new AuthorController();
			bookCont = new BookController();
			App.AuthorId = 0;
			labelStatus.Text = "";
			RefreshAuthorList();
			buttonAdd.Enabled = true;
			buttonUpdate.Enabled = true;
			buttonDelete.Enabled = true;
			dgAuthors.ClearSelection();
		}

		private void dgAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int selectedId = Convert.ToInt32(dgAuthors.SelectedRows[0].Cells[0].Value);

			using (LmsContext context = new LmsContext())
			{
				selectedAuthor = context.Authors.Where(i => i.AuthorId == selectedId).FirstOrDefault();
			}

			textId.Text = selectedAuthor!.AuthorId.ToString();
			textFirstName.Text = selectedAuthor.FirstName;
			textLastName.Text = selectedAuthor.LastName;
			textDOB.Text = selectedAuthor.DOB;
			textDOD.Text = selectedAuthor.DOD;
			textHometown.Text = selectedAuthor.Hometown;
			rtbEducation.Text = selectedAuthor.Education;
			rtbAbout.Text = selectedAuthor.About;

			int booksCount = 0;
			booksCount = bookCont!.GetBooksByAuthor(Convert.ToInt32(textId.Text))!.Count();
			labelBooksCount.Text = booksCount.ToString() + " books";
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			string errorString = ValidateData();

			if (errorString == "")
			{
				int newAuthorId = authorCont!.AddAuthor(textFirstName.Text, textLastName.Text, textDOB.Text, textDOD.Text, textHometown.Text, rtbEducation.Text, rtbAbout.Text);
				if (newAuthorId != 0)
				{
					labelStatus.Text = "Author added";
					selectedAuthor = authorCont.GetAuthor(newAuthorId);
					RefreshAuthorList();
				}
			}
			else
			{
				MessageBox.Show("Author's first and last name are required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			string errorString = ValidateData();

			if (errorString == "")
			{
				if (authorCont!.UpdateAuthor(Convert.ToInt32(textId.Text), textFirstName.Text, textLastName.Text, textDOB.Text, textDOD.Text, textHometown.Text, rtbEducation.Text, rtbAbout.Text))
				{
					labelStatus.Text = "Author updated";
					selectedAuthor = authorCont.GetAuthor(Convert.ToInt32(textId.Text));
					RefreshAuthorList();
				}
			}
			else
			{
				MessageBox.Show(errorString, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			int authorBookCount = bookCont!.GetBooksByAuthor(Convert.ToInt32(textId.Text))!.Count();
			string warningMessage = "WARNING: this author currently has " + authorBookCount.ToString() + " books in your system." + Environment.NewLine + Environment.NewLine;
			warningMessage += selectedAuthor!.FirstName + " " + selectedAuthor.LastName + " (b: " + selectedAuthor.DOB + ")" + "\n\n";
			warningMessage += "This action will also delete ALL BOOKS assigned to this author. Continue?";

			if (MessageBox.Show(warningMessage, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				int id = Convert.ToInt32(textId.Text);

				if (id > 0)
				{
					if (authorCont!.DeleteAuthor(Convert.ToInt32(textId.Text)))
					{
						labelStatus.Text = "Author deleted";
						selectedAuthor = null;
						RefreshAuthorList();
					}
				}
				else
				{
					MessageBox.Show("No author ID found. Select an author from the list to delete", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void RefreshAuthorList()
		{
			var authors = authorCont!.GetAuthors();
			dgAuthors.DataSource = authors;
			dgAuthors.Columns[0].Visible = false;
			dgAuthors.Columns[4].Visible = false;
			dgAuthors.Columns[5].Visible = false;
			dgAuthors.Columns[6].Visible = false;
			dgAuthors.Columns[7].Visible = false;

			if (selectedAuthor == null)
			{
				textId.Text = "";
				textLastName.Text = "";
				textFirstName.Text = "";
				textDOB.Text = "";
				textDOD.Text = "";
				textHometown.Text = "";
				rtbEducation.Text = "";
				rtbAbout.Text = "";
			}
			else
			{
				for (int i = 0; i < dgAuthors.Rows.Count; i++)
				{
					if (Convert.ToInt32(dgAuthors.Rows[i].Cells[0].Value) == selectedAuthor.AuthorId)
					{
						dgAuthors.Rows[i].Selected = true;
					}
				}
			}
		}

		private string ValidateData()
		{
			string errorString = "";

			if (textFirstName.Text.Length == 0)
			{
				errorString += "Author first name is required" + Environment.NewLine;
			}

			if (textLastName.Text.Length == 0)
			{
				errorString += "Author last name is required" + Environment.NewLine;
			}

			return errorString;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textSearch_TextChanged(object sender, EventArgs e)
		{
			List<Author>? authors = authorCont!.SearchAuthors(textSearch.Text);
			dgAuthors.DataSource = authors;
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			textSearch.Text = "";
			RefreshAuthorList();
		}

		private void buttonShowAuthorBooks_Click(object sender, EventArgs e)
		{
			if (textId.Text != "")
			{
				App.AuthorId = Convert.ToInt32(textId.Text);
				ManageBooksForm booksForm = new ManageBooksForm();
				booksForm.ShowDialog();
			}
		}
	}
}
