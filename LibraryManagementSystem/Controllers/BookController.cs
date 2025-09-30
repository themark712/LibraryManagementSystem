using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Database;
using LibraryManagementSystem.Models;
using System.Security.Cryptography;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace LibraryManagementSystem.Controllers
{
	public class BookController
	{
		public List<Book>? GetBooks()
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var books = context.Books.Include(a => a.Author).Include(g => g.Genre).OrderBy(n => n.Title).ToList();
					return books.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public Book? GetBook(int _id)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var book = context.Books.Where(i => i.BookId == _id).FirstOrDefault();
					return book;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public Book? GetBookByIsbn(string _isbn)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var book = context.Books.Where(i => i.ISBN == _isbn).FirstOrDefault();
					return book;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}


		public List<Book>? SearchBooks(string search)
		{
			// search by string contained in fields: title, author last name, genre, publisher, ISBN
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var books = context.Books
						.Where(b => b.Title!.ToLower().Contains(search.ToLower())
							|| b.Genre.Name!.ToLower().Contains(search.ToLower())
							|| b.Author.LastName!.ToLower().Contains(search.ToLower())
							|| b.Publisher!.ToLower().Contains(search.ToLower())
							|| b.ISBN!.Replace("-", "").Replace(" ", "").Trim().ToLower().Contains(search.ToLower()))
						.Include(a => a.Author).Include(g => g.Genre).OrderBy(n => n.Title).ToList();
					return books;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public int GetCount()
		{
			using (LmsContext context = new LmsContext())
			{
				var books = context.Books.ToList();
				return books.Count;
			}
		}

		public int AddBook(string _title, int _aid, int _gid, string _pub, int _year, string _is, int _cpy, decimal _prc, string _dte, string _abt)
		{
			int? existingBookId = BookExists(_title, _aid, _year, _is);

			if (existingBookId != 0)
			{
				MessageBox.Show("This book already exists (Book ID: " + existingBookId.ToString() + ")", "Book Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return 0;
			}

			using (LmsContext context = new LmsContext())
			{
				Book newBook = new Book
				{
					Title = _title,
					AuthorId = _aid,
					GenreId = _gid,
					Publisher = _pub,
					Year = _year,
					ISBN = _is,
					Copies = _cpy,
					Price = _prc,
					DateReceived = _dte,
					About = _abt
				};
				context.Books.Add(newBook);
				context.SaveChanges();
				return newBook.BookId;
			}
		}

		public bool UpdateBook(int _id, string _title, int _aid, int _gid, string _pub, int _year, string _is, int _cpy, decimal _prc, string _dte, string _abt, string _cvr)
		{
			int? existingBookId = BookExists(_title, _aid, _year, _is);
			if (existingBookId != 0)
			{
				MessageBox.Show("A book with this information (title, author, year and ISBN) already exists (Book ID: " + existingBookId.ToString() + ")", "Book Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			using (LmsContext context = new LmsContext())
			{
				Book book = context.Books.Where(i => i.BookId == _id).FirstOrDefault()!;

				if (book != null)
				{
					book.Title = _title;
					book.AuthorId = _aid;
					book.GenreId = _gid;
					book.Publisher = _pub;
					book.Year = _year;
					book.ISBN = _is;
					book.Copies = _cpy;
					book.Price = _prc;
					book.DateReceived = _dte;
					book.About = _abt;
					book.Cover = _cvr;

					context.SaveChanges();
				}
				else
				{
					return false;
				}
			}
			return true;
		}

		public bool DeleteBook(int _id)
		{
			int id = _id;

			using (LmsContext context = new LmsContext())
			{
				Book book = context.Books.Where(i => i.BookId == id).FirstOrDefault()!;

				if (book != null)
				{
					context.Remove(book);
					context.SaveChanges();
				}
			}
			return true;
		}

		private static int? BookExists(string _title, int _aid, int _year, string _isbn)
		{
			int? existingBookId = 0;

			using (LmsContext context = new LmsContext())
			{
				Book existingBook = context.Books
					.Where(b => b.Title == _title && b.AuthorId == _aid
						&& b.Year == _year
						&& b.ISBN!.Replace("-", "").Replace(" ", "").Trim().ToLower() == _isbn.Replace("-", "").Replace(" ", "").Trim().ToLower())
					.FirstOrDefault()!;

				if (existingBook == null)
				{
					return 0;
				}
				return existingBookId;
			}
		}
	}
}
