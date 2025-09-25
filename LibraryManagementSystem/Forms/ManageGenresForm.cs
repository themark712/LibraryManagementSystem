using LibraryManagementSystem.Controllers;
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
			RefreshGenreList();
			buttonAdd.Enabled = false;
			buttonUpdate.Enabled = false;
			buttonDelete.Enabled = false;
		}

		private void dgGenres_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedGenre = new Genre();
			selectedGenre.GenreId = Convert.ToInt32(dgGenres.SelectedRows[0].Cells[0].Value);
			selectedGenre.Name = dgGenres.SelectedRows[0].Cells[1].Value.ToString();

			textId.Text = selectedGenre.GenreId.ToString();
			textName.Text = selectedGenre.Name;
			//MessageBox.Show(dgGenres.SelectedRows[0].Cells[1].Value.ToString());
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (GenreController.AddGenre(textName.Text))
			{
				labelStatus.Text = "Genre added";
			}
			
			RefreshGenreList();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			
			if(GenreController.UpdateGenre(Convert.ToInt32(textId.Text), textName.Text))
			{
				labelStatus.Text = "Genre updated";
			}
			RefreshGenreList();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if(GenreController.DeleteGenre(Convert.ToInt32(textId.Text))) {
				labelStatus.Text = "Genre deleted";
			}
			RefreshGenreList();
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
			selectedGenre = null;
			textId.Text = "";
			textName.Text = "";
		}
	}
}
