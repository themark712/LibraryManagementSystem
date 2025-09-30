using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Controllers;
using LibraryManagementSystem.Database;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem.Forms
{
	public partial class ManageBooksForm : Form
	{
		Book? selectedBook;
		GenreController? genreCont;
		AuthorController? authorCont;
		BookController? bookCont;

		string imageLocation = ConfigurationManager.AppSettings["DatabaseLocation"]! + "\\covers\\";

		public ManageBooksForm()
		{
			InitializeComponent();
		}

		private void ManageBooksForm_Load(object sender, EventArgs e)
		{
			genreCont = new GenreController();
			authorCont = new AuthorController();
			bookCont = new BookController();
			labelStatus.Text = "";
			FillAuthorCombo();
			RefreshBookList();
			dgBooks.ClearSelection();

			if (App.AuthorId == 0)
			{
				comboAuthorView.SelectedIndex = -1;
			}
			else
			{
				comboAuthorView.SelectedValue = App.AuthorId;
			}

			if (App.GenreId == 0)
			{
				comboGenreView.SelectedIndex = -1;
			}
			else
			{
				comboGenreView.SelectedValue = App.GenreId;
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			App.GenreId = 0;
			App.AuthorId = 0;
			this.Close();
		}

		#region BookCRUDMethods
		private void textSearch_TextChanged(object sender, EventArgs e)
		{
			List<Book>? books = bookCont!.SearchBooks(textSearch.Text);
			RefreshBookList(books!);
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			textSearch.Text = "";
			RefreshBookList();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			string errorString = ValidateData();

			if (errorString == "")
			{
				int newBookId = bookCont!.AddBook(textTitle.Text, Convert.ToInt32(comboAuthors.SelectedValue), Convert.ToInt32(comboGenres.SelectedValue), textPublisher.Text, Convert.ToInt32(textYear.Text), textISBN.Text, Convert.ToInt32(numCopies.Value), Convert.ToDecimal(textPrice.Text), dateReceived.Text, textAbout.Text);

				if (newBookId != 0)
				{
					labelStatus.Text = "Books added";
					selectedBook = bookCont.GetBook(newBookId);
				}
				RefreshBookList();
			}
			else
			{
				MessageBox.Show(errorString, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			string errorString = ValidateData(true);

			if (errorString == "")
			{
				if (bookCont!.UpdateBook(Convert.ToInt32(textId.Text), textTitle.Text, Convert.ToInt32(comboAuthors.SelectedValue), Convert.ToInt32(comboGenres.SelectedValue), textPublisher.Text, Convert.ToInt32(textYear.Text), textISBN.Text, Convert.ToInt32(numCopies.Value), Convert.ToDecimal(textPrice.Text), dateReceived.Text, textAbout.Text, labelCoverFileName.Text))
				{
					labelStatus.Text = "Books updated";
				}

				selectedBook = bookCont.GetBook(Convert.ToInt32(textId.Text));
				RefreshBookList();
			}
			else
			{
				MessageBox.Show(errorString, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		private void buttonAddCover_Click(object sender, EventArgs e)
		{
			openFileBookImage.Filter = "Select Image(*.jpg; *.png)|*.jpg; *.png";

			if (openFileBookImage.ShowDialog() == DialogResult.OK)
			{
				picCover.Image = Image.FromFile(openFileBookImage.FileName);
				labelCoverFileName.Text = openFileBookImage.SafeFileName;
				picCover.Image.Save(imageLocation + labelCoverFileName.Text);
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Delete this book?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				if (selectedBook != null)
				{
					bookCont!.DeleteBook(selectedBook.BookId);
					selectedBook = null;
				}
				RefreshBookList();
			}
		}

		private void FillAuthorCombo()
		{
			using (LmsContext context = new LmsContext())
			{
				List<Author> authors = new List<Author>();
				authors = authorCont!.GetAuthors()!;

				comboAuthors.Items.Clear();
				comboAuthors.DataSource = authors;
				comboAuthors.ValueMember = "AuthorId";
				comboAuthors.DisplayMember = "FullName";

				comboAuthorView.Items.Clear();
				comboAuthorView.DataSource = authors;
				comboAuthorView.ValueMember = "AuthorId";
				comboAuthorView.DisplayMember = "FullName";

				List<Genre> genres = new List<Genre>();
				genres = genreCont!.GetGenres()!;

				comboGenres.Items.Clear();
				comboGenres.DataSource = genres;
				comboGenres.ValueMember = "GenreId";
				comboGenres.DisplayMember = "Name";

				comboGenreView.Items.Clear();
				comboGenreView.DataSource = genres;
				comboGenreView.ValueMember = "GenreId";
				comboGenreView.DisplayMember = "Name";
			}
		}

		private string ValidateData(bool isUpdate = false)
		{
			string dataError = "";

			if (textTitle.Text.Length == 0)
			{
				dataError += "Book title is required" + Environment.NewLine;
			}

			if (comboAuthors.SelectedValue == null || comboAuthors.SelectedValue.ToString() == "")
			{
				dataError += "Author is required" + Environment.NewLine;
			}

			if (comboGenres.SelectedValue == null || comboGenres.SelectedValue.ToString() == "")
			{
				dataError += "Genre is required" + Environment.NewLine;
			}

			if (textYear.Text.Length == 0)
			{
				dataError += "Year of publication is required" + Environment.NewLine;
			}

			if (!isUpdate)
			{
				// check existing ISBN
				Book booksByIsbn = bookCont!.GetBookByIsbn(textISBN.Text)!;

				if (booksByIsbn != null)
				{
					dataError += "This ISBN number already exists" + Environment.NewLine;
				}
			}

			decimal price;

			if (!decimal.TryParse(textPrice.Text, out price))
			{
				dataError += "Price must be a numeric value" + Environment.NewLine;
			}

			return dataError;
		}

		private void RefreshBookList(List<Book>? bookList = null)
		{
			List<Book> books;

			if (bookList == null)
			{
				// if App.GenreId is not 0, user initiated form from genre form
				// if App.AuthorId is not 0, user initiated form from author form
				if (App.GenreId != 0 || App.AuthorId != 0)
				{
					books = bookCont!.GetBooks()!.ToList();

					if (App.AuthorId != 0)
					{
						books = books.Where(a => a.AuthorId == App.AuthorId).ToList();
					}
					if (App.GenreId != 0)
					{
						books = books.Where(a => a.GenreId == App.GenreId).ToList();
					}
				}
				else
				{
					books = bookCont!.GetBooks()!;
				}
			}
			else   // bookList parameter is not  null, getting books from search
			{
				books = bookList;
			}

			labelBooksCount.Text = books.Count.ToString() + " books";

			dgBooks.DataSource = null;

			DataTable dt = new DataTable();

			dt.Columns.Add("Id");
			dt.Columns.Add("Title");
			dt.Columns.Add("Author");
			dt.Columns.Add("Year");

			foreach (Book book in books!)
			{
				var row = dt.NewRow();
				row[0] = book.BookId;
				row[1] = book.Title;
				row[2] = book.Author.FullName;
				row[3] = book.Year;
				dt.Rows.Add(row);
			}

			dgBooks.DataSource = dt;

			if (selectedBook == null)
			{
				textId.Text = "";
				textTitle.Text = "";
				comboAuthors.SelectedValue = "";
				comboGenres.SelectedValue = "";
				textPublisher.Text = "";
				textYear.Text = "";
				textISBN.Text = "";
				textPrice.Text = "";
				textAbout.Text = "";
				numCopies.Value = 0M;
				dateReceived.CustomFormat = " ";
				dateReceived.Value = DateTime.Today;
				picCover.Image = null;
				dgBooks.ClearSelection();
				comboGenres.SelectedIndex = -1;
				comboAuthors.SelectedIndex = -1;
			}
			else
			{
				for (int i = 0; i < dgBooks.Rows.Count; i++)
				{
					if (Convert.ToInt32(dgBooks.Rows[i].Cells[0].Value) == selectedBook.BookId)
					{
						dgBooks.Rows[i].Selected = true;
					}
				}
			}
		}
		#endregion

		#region BookDataMethods
		private void dgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			GetBookData();
		}

		private void dgBooks_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			GetBookData();
		}

		private void GetBookData()
		{
			if (dgBooks.SelectedRows.Count > 0)
			{
				int selectedId = Convert.ToInt32(dgBooks.SelectedRows[0].Cells[0].Value);

				using (LmsContext context = new LmsContext())
				{
					selectedBook = context.Books.Where(i => i.BookId == selectedId).FirstOrDefault();
				}

				textId.Text = selectedBook!.BookId!.ToString();
				textTitle.Text = selectedBook!.Title!.ToString();
				comboAuthors.SelectedValue = selectedBook.AuthorId;
				comboGenres.SelectedValue = selectedBook.GenreId;
				textPublisher.Text = selectedBook.Publisher;
				textYear.Text = selectedBook.Year.ToString();
				textISBN.Text = selectedBook.ISBN;
				textPrice.Text = selectedBook.Price.ToString();
				textAbout.Text = selectedBook.About;
				numCopies.Value = (decimal)selectedBook.Copies!;
				labelCoverFileName.Text = selectedBook.Cover;

				if (!string.IsNullOrEmpty(selectedBook.Cover))
				{
					picCover.Image = Image.FromFile(imageLocation + selectedBook.Cover); // Correctly convert byte[] to Image
				}
				else
				{
					picCover.Image = Image.FromFile(imageLocation + "default.png");
				}

				if (!string.IsNullOrEmpty(selectedBook.DateReceived!.ToString().Trim()))
				{
					dateReceived.Value = DateTime.Parse(selectedBook.DateReceived!);
				}
				else
				{
					dateReceived.Value = DateTime.Today;
				}
			}
		}
		#endregion

		#region BookFilterEvents
		private void comboGenreView_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (comboGenreView.SelectedIndex >= 0) // && comboGenreView.SelectedValue!.GetType() == typeof(Int32))
			{
				App.GenreId = Convert.ToInt32(comboGenreView.SelectedValue!.ToString());
				RefreshBookList();
			}
		}

		private void comboAuthorView_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (comboAuthorView.SelectedIndex >= 0) // && comboAuthorView.SelectedValue!.GetType() == typeof(Int32))
			{
				App.AuthorId = Convert.ToInt32(comboAuthorView.SelectedValue!.ToString());
				RefreshBookList();
			}
		}

		private void buttonClearGenreFilter_Click(object sender, EventArgs e)
		{
			App.GenreId = 0;
			comboGenreView.SelectedIndex = -1;
			RefreshBookList();
		}

		private void buttonClearAuthorFilter_Click(object sender, EventArgs e)
		{
			App.AuthorId = 0;
			comboAuthorView.SelectedIndex = -1;
			RefreshBookList();
		}
		#endregion
	}
}
