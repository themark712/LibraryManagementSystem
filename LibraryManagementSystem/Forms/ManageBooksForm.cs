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
	public partial class ManageBooksForm : Form
	{
		Book? selectedBook;

		public ManageBooksForm()
		{
			InitializeComponent();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ManageBooksForm_Load(object sender, EventArgs e)
		{
			FillAuthorCombo();
			LoadTestBook(3);
		}

		private void LoadTestBook(int _id)
		{
			int id = _id;

			using (LmsContext context = new LmsContext())
			{
				selectedBook = context.Books.Where(i => i.BookId == id).FirstOrDefault()!;
			}

			textId.Text = selectedBook!.BookId.ToString();
			textTitle.Text = selectedBook.Title;
			comboAuthors.SelectedValue = selectedBook.AuthorId;
			comboGenres.SelectedValue = selectedBook.GenreId;
		}

		private void FillAuthorCombo()
		{
			using (LmsContext context = new LmsContext())
			{
				List<Author> authors = new List<Author>();
				authors = AuthorController.GetAuthors()!;

				comboAuthors.Items.Clear();
				comboAuthors.DataSource = authors;
				comboAuthors.ValueMember = "AuthorId";
				comboAuthors.DisplayMember = "FullName";

				List<Genre> genres = new List<Genre>();
				genres = GenreController.GetGenres()!;

				comboGenres.Items.Clear();
				comboGenres.DataSource = genres;
				comboGenres.ValueMember = "GenreId";
				comboGenres.DisplayMember = "Name";
			}
		}

		private void comboAuthors_SelectedIndexChanged(object sender, EventArgs e)
		{
			//MessageBox.Show(comboAuthors.SelectedValue.ToString());
		}
	}
}
