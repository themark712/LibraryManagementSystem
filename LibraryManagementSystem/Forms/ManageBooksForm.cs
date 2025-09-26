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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
			RefreshBookList();
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

		private void dgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
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
			if (!string.IsNullOrEmpty(selectedBook.DateReceived!.ToString()))
			{
				dateReceived.Format = DateTimePickerFormat.Long;
				dateReceived.Value = DateTime.Parse(selectedBook.DateReceived!);
			}
			else
			{
				dateReceived.CustomFormat = " ";
				dateReceived.Format = DateTimePickerFormat.Custom;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (selectedBook != null)
			{
				BookController.DeleteBook(selectedBook.BookId);
			}
			RefreshBookList();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textTitle.Text.Length > 0 && !string.IsNullOrEmpty(comboAuthors.SelectedValue!.ToString()) && !string.IsNullOrEmpty(comboGenres.SelectedValue!.ToString()))
			{
				if (BookController.AddBook(textTitle.Text, Convert.ToInt32(comboAuthors.SelectedValue), Convert.ToInt32(comboGenres.SelectedValue), textPublisher.Text, Convert.ToInt32(textYear.Text), textISBN.Text, Convert.ToInt32(numCopies.Value), Convert.ToDecimal(textPrice.Text), dateReceived.Text, textAbout.Text))
				{
					labelStatus.Text = "Books added";
				}
				RefreshBookList();
			}
			else
			{
				MessageBox.Show("Book title, author, genre, and year of publication are required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (textTitle.Text.Length > 0 && !string.IsNullOrEmpty(comboAuthors.SelectedValue!.ToString()) && !string.IsNullOrEmpty(comboGenres.SelectedValue!.ToString()))
			{
				if (BookController.UpdateBook(Convert.ToInt32(textId.Text), textTitle.Text, Convert.ToInt32(comboAuthors.SelectedValue), Convert.ToInt32(comboGenres.SelectedValue), textPublisher.Text, Convert.ToInt32(textYear.Text), textISBN.Text, Convert.ToInt32(numCopies.Value), Convert.ToDecimal(textPrice.Text), dateReceived.Text, textAbout.Text))
				{
					labelStatus.Text = "Books updated";
				}
				RefreshBookList();
			}
			else
			{
				MessageBox.Show("Book title, author, genre, and year of publication are required", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void textSearch_TextChanged(object sender, EventArgs e)
		{
			List<Book>? books = BookController.SearchBooks(textSearch.Text);
			RefreshBookList(books!);
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			textSearch.Text = "";
			RefreshBookList();
		}

		private void RefreshBookList(List<Book> bookList = null)
		{
			List<Book> books;

			if (bookList == null)
			{
				 books = BookController.GetBooks()!;
			} else
			{
				books = bookList;
			}

				//dgBooks.DataSource = bookss;

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

			selectedBook = null;
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
			dateReceived.Format = DateTimePickerFormat.Custom;
		}
	}
}
