using LibraryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Classes;
using System.Drawing.Text;
using System.Reflection.Emit;

namespace LibraryManagementSystem.Forms
{
	public partial class DashboardForm : Form
	{
		public DashboardForm()
		{
			InitializeComponent();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void DashboardForm_Load(object sender, EventArgs e)
		{
			App.AddFont();

			//	Font fnt = new Font(App.pFontCollection.Families[0], 15);
			//labelHeader.Font = fnt;
		}

		private void DashboardForm_Shown(object sender, EventArgs e)
		{
			// TODO ... uncomment below
			//this.Enabled = false;

			//// show the login form
			//LoginForm lgf = new LoginForm(this);
			//lgf.Show();
		}

		private void buttonGenres_Click(object sender, EventArgs e)
		{
			// show the manage genres form
			ManageGenresForm mngGenres = new ManageGenresForm();
			mngGenres.Show();
		}
	}
}
