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

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (AuthorController.AddAuthor(textFirstName.Text, textLastName.Text, textDOB.Text, textDOD.Text, textHometown.Text, textEduction.Text, textAbout.Text))
			{
				labelStatus.Text = "Author added";
			}
			RefreshAuthorList();
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

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (AuthorController.UpdateAuthor(Convert.ToInt32(textId.Text), textFirstName.Text, textLastName.Text, textDOB.Text, textDOD.Text, textHometown.Text, textEduction.Text, textAbout.Text))
			{
				labelStatus.Text = "Author updated";
			}

			RefreshAuthorList();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (AuthorController.DeleteAuthor(Convert.ToInt32(textId.Text)))
			{
				labelStatus.Text = "Author deleted";
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
	}
}
