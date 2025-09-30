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
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Configuration;
using LibraryManagementSystem.Controllers;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Forms
{
	public partial class DashboardForm : Form
	{
		AuthorController? authorCont;
		BookController? bookCont;

		public DashboardForm()
		{
			InitializeComponent();


			string databaseLocation = ConfigurationManager.AppSettings["DatabaseLocation"]!;
			if (databaseLocation == "" || !Directory.Exists(databaseLocation) || !File.Exists(databaseLocation + "\\LMS.db"))
			{
				DatabaseSetupForm formDbSetup = new DatabaseSetupForm();
				formDbSetup.ShowDialog();
			}

			if (!Directory.Exists(databaseLocation + "\\covers"))
			{
				Directory.CreateDirectory(databaseLocation + "\\covers");
			}

			if (!File.Exists(databaseLocation + "\\LMS.db"))
			{
				Utilties.CreateDatabase();
			}


			// Replace the problematic code block:
			if (!File.Exists(databaseLocation + "\\covers\\default.png"))
			{
				var defaultImg = LibraryManagementSystem.Properties.Resources.book_cover_default;
				var newImg = Image.FromStream(new MemoryStream(defaultImg));
				newImg.Save(databaseLocation + "\\covers\\default.png");
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void DashboardForm_Load(object sender, EventArgs e)
		{
			authorCont = new AuthorController();
			bookCont = new BookController();
		}

		private void DashboardForm_Shown(object sender, EventArgs e)
		{
			// TODO ... uncomment below
			//this.Enabled = false;

			//// show the login form
			//LoginForm lgf = new LoginForm(this);
			//lgf.Show();
			ToggleButtonBackgrounds(null);
		}

		private void buttonGenres_Click(object sender, EventArgs e)
		{
			// show the manage genres form
			ToggleButtonBackgrounds((Button)sender);
			ManageGenresForm mngGenres = new ManageGenresForm();
			mngGenres.ShowDialog();
			ToggleButtonBackgrounds(null);
		}

		private void buttonBooks_Click(object sender, EventArgs e)
		{
			App.GenreId = 0;
			App.AuthorId = 0;
			ToggleButtonBackgrounds((Button)sender);
			ManageBooksForm mngBooks = new ManageBooksForm();
			mngBooks.ShowDialog();
			ToggleButtonBackgrounds(null);
		}

		private void buttonAuthors_Click(object sender, EventArgs e)
		{
			ToggleButtonBackgrounds((Button)sender);
			ManageAuthorsForm mngAuthors = new ManageAuthorsForm();
			mngAuthors.ShowDialog();
			ToggleButtonBackgrounds(null);
		}

		private void buttonCirculation_Click(object sender, EventArgs e)
		{
			ToggleButtonBackgrounds((Button)sender);
		}

		private void buttonUsers_Click(object sender, EventArgs e)
		{
			ToggleButtonBackgrounds((Button)sender);
		}

		private void DashboardForm_Enter(object sender, EventArgs e)
		{
			ToggleButtonBackgrounds(null);
		}

		private void ToggleButtonBackgrounds(Button? buttonClicked)
		{
			//MessageBox.Show(buttonClicked.Name);
			buttonBooks.BackColor = Color.DarkBlue;
			buttonAuthors.BackColor = Color.DarkBlue;
			buttonGenres.BackColor = Color.DarkBlue;
			buttonCirculation.BackColor = Color.DarkBlue;
			buttonUsers.BackColor = Color.DarkBlue;

			if (buttonClicked != null)
			{
				buttonClicked.BackColor = Color.BlueViolet;
			}
		}

		private void DashboardForm_Activated(object sender, EventArgs e)
		{
			int authorCount = authorCont!.GetCount();
			labelAuthorCount.Text = authorCount.ToString();

			int bookCount = bookCont!.GetCount();
			labelBookCount.Text = bookCount.ToString();

			List<Book> latestBooks = bookCont.GetLastFiveBooks();

			if (!string.IsNullOrEmpty(latestBooks[0].Cover))
			{
				panelLatestBook1.BackgroundImageLayout = ImageLayout.Stretch;
				panelLatestBook1.BackgroundImage = Image.FromFile(ConfigurationManager.AppSettings["DatabaseLocation"]! + "\\covers\\" + latestBooks[0].Cover.ToString());
			}

			if (!string.IsNullOrEmpty(latestBooks[1].Cover))
			{
				panelLatestBook2.BackgroundImageLayout = ImageLayout.Stretch;
				panelLatestBook2.BackgroundImage = Image.FromFile(ConfigurationManager.AppSettings["DatabaseLocation"]! + "\\covers\\" + latestBooks[1].Cover.ToString());
			}
		}
	}
}
