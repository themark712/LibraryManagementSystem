using LibraryManagementSystem.Controllers;
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
			var genres = GenresController.GetGenres();
			dgGenres.DataSource = genres;
		}

		private void dgGenres_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			MessageBox.Show(dgGenres.SelectedRows[0].Cells[1].Value.ToString());
		}
	}
}
