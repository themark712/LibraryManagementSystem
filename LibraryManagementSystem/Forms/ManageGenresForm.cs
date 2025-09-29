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

		public ManageGenresForm()
		{
			InitializeComponent();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ManageGenresForm_Load(object sender, EventArgs e)
		{
			labelStatus.Text = "";
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
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textName.Text.Length > 0)
			{
				int newGenreId = GenreController.AddGenre(textName.Text);
				if (newGenreId != 0)
				{
					labelStatus.Text = "Genre added";
					selectedGenre = GenreController.GetGenre(newGenreId);
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
				if (GenreController.UpdateGenre(Convert.ToInt32(textId.Text), textName.Text))
				{
					labelStatus.Text = "Genre updated";
					selectedGenre = GenreController.GetGenre(Convert.ToInt32(textId.Text));
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
			if (MessageBox.Show("Delete this Genre?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				int id = Convert.ToInt32(textId.Text);

				if (id > 0)
				{
					if (GenreController.DeleteGenre(id))
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
			var genres = GenreController.GetGenres();
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
	}
}
