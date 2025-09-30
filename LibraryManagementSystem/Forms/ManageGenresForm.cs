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
	public partial class ManageGenresForm : Form
	{
		Genre? selectedGenre;
		GenreController? genreCont;
		BookController? bookCont;

		public ManageGenresForm()
		{
			InitializeComponent();
		}

		private void ManageGenresForm_Load(object sender, EventArgs e)
		{
			genreCont = new GenreController();
			bookCont = new BookController();
			App.GenreId = 0;
			labelStatus.Text = "";
			labelGenresCount.Text = genreCont.GetGenres()!.Count().ToString() + " genres";
			RefreshGenreList();
			buttonAdd.Enabled = false;
			buttonUpdate.Enabled = false;
			buttonDelete.Enabled = false;
			dgGenres.ClearSelection();
		}

		private void dgGenres_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = Convert.ToInt32(dgGenres.SelectedRows[0].Cells[0].Value);

			using (LmsContext context = new LmsContext())
			{
				selectedGenre = context.Genres.Where(i => i.GenreId == id).FirstOrDefault();
			}

			textId.Text = selectedGenre!.GenreId.ToString();
			textName.Text = selectedGenre.Name;

			int booksCount = 0;
			booksCount = bookCont!.GetBooksByGenre(Convert.ToInt32(textId.Text))!.Count();
			labelBooksCount.Text = booksCount.ToString() + " books";
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textName.Text.Length > 0)
			{
				int newGenreId = genreCont!.AddGenre(textName.Text);
				if (newGenreId != 0)
				{
					labelStatus.Text = "Genre added";
					selectedGenre = genreCont!.GetGenre(newGenreId);
					RefreshGenreList();
				}
			}
			else
			{
				MessageBox.Show("Genre name is required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{

			if (textName.Text.Length > 0)
			{
				if (genreCont!.UpdateGenre(Convert.ToInt32(textId.Text), textName.Text))
				{
					labelStatus.Text = "Genre updated";
					selectedGenre = genreCont.GetGenre(Convert.ToInt32(textId.Text));
					RefreshGenreList();
				}
			}
			else
			{
				MessageBox.Show("Genre name is required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			int genreBookCount = bookCont!.GetBooksByGenre(Convert.ToInt32(textId.Text))!.Count();
			string warningMessage = "WARNING: this genre currently has " + genreBookCount.ToString() + " books in your system." + Environment.NewLine + Environment.NewLine;
			warningMessage += selectedGenre!.Name + "\n\n";
			warningMessage += "This action will also delete ALL BOOKS assigned to this genre. Continue?";

			if (MessageBox.Show(warningMessage, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				int id = Convert.ToInt32(textId.Text);

				if (id > 0)
				{
					if (genreCont!.DeleteGenre(id))
					{
						selectedGenre = null;
						labelStatus.Text = "Genre deleted";
						RefreshGenreList();
					}
				}
				else
				{
					MessageBox.Show("No genre ID found. Select a genre from the list to delete", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void textName_TextChanged(object sender, EventArgs e)
		{
			if (selectedGenre != null && textName.Text == selectedGenre!.Name)
			{
				textId.Text = selectedGenre.GenreId.ToString();
				buttonAdd.Enabled = false;
				buttonUpdate.Enabled = false;
				buttonDelete.Enabled = true;
			}
			else
			{
				//textId.Text = "";
				buttonAdd.Enabled = true;
				buttonUpdate.Enabled = true;
				buttonDelete.Enabled = false;
			}
		}

		private void RefreshGenreList()
		{
			var genres = genreCont!.GetGenres();
			dgGenres.DataSource = genres;

			if (selectedGenre == null)
			{
				textId.Text = "";
				textName.Text = "";
			}
			else
			{
				for (int i = 0; i < dgGenres.Rows.Count; i++)
				{
					if (Convert.ToInt32(dgGenres.Rows[i].Cells[0].Value) == selectedGenre.GenreId)
					{
						dgGenres.Rows[i].Selected = true;
					}
				}
			}
		}

		private void buttonShowGenreBooks_Click(object sender, EventArgs e)
		{
			if(textId.Text != "")
			{
				App.GenreId = Convert.ToInt32(textId.Text);
				ManageBooksForm booksForm = new ManageBooksForm();
				booksForm.ShowDialog();
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
