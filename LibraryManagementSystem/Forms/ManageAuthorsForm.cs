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
		Author? selectedAuthor;

		public ManageAuthorsForm()
		{
			InitializeComponent();
		}

		private void ManageAuthorsForm_Load(object sender, EventArgs e)
		{
			RefreshAuthorList();
			buttonAdd.Enabled = true;
			buttonUpdate.Enabled = true;
			buttonDelete.Enabled = true;
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
			textEduction.Text = selectedAuthor.Education;
			textAbout.Text = selectedAuthor.About;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textFirstName.Text.Length > 0 && textLastName.Text.Length > 0)
			{
				if (AuthorController.AddAuthor(textFirstName.Text, textLastName.Text, textDOB.Text, textDOD.Text, textHometown.Text, textEduction.Text, textAbout.Text))
				{
					labelStatus.Text = "Author added";
				}
				RefreshAuthorList();
			}
			else
			{
				MessageBox.Show("Author's first and last name are required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (textFirstName.Text.Length > 0 && textLastName.Text.Length > 0)
			{
				if (AuthorController.UpdateAuthor(Convert.ToInt32(textId.Text), textFirstName.Text, textLastName.Text, textDOB.Text, textDOD.Text, textHometown.Text, textEduction.Text, textAbout.Text))
				{
					labelStatus.Text = "Author updated";
				}
				else
				{
					MessageBox.Show("Author's first and last name are required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

				RefreshAuthorList();
			}
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(textId.Text);

			if (id > 0)
			{
				if (AuthorController.DeleteAuthor(Convert.ToInt32(textId.Text)))
				{
					labelStatus.Text = "Author deleted";
				}
			}
			else
			{
				MessageBox.Show("No author ID found. Select an author from the list to delete", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			RefreshAuthorList();
		}

		private void RefreshAuthorList()
		{
			var authors = AuthorController.GetAuthors();
			dgAuthors.DataSource = authors;
			dgAuthors.Columns[0].Visible = false;
			dgAuthors.Columns[4].Visible = false;
			dgAuthors.Columns[5].Visible = false;
			dgAuthors.Columns[6].Visible = false;
			dgAuthors.Columns[7].Visible = false;
			selectedAuthor = null;
			textId.Text = "";
			textLastName.Text = "";
			textFirstName.Text = "";
			textDOB.Text = "";
			textDOD.Text = "";
			textHometown.Text = "";
			textEduction.Text = "";
			textAbout.Text = "";
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textSearch_TextChanged(object sender, EventArgs e)
		{
			List<Author>? authors = AuthorController.SearchAuthors(textSearch.Text);
			dgAuthors.DataSource = authors;
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			textSearch.Text = "";
			RefreshAuthorList();
		}
	}
}
