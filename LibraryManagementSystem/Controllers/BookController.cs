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
	public static class BookController
	{
		public static List<Book>? GetBooks()
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

		public static Book? GetBook(int _id)
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
		public static List<Book>? SearchBooks(string search)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var books = context.Books.Where(d => d.Title!.ToLower().Contains(search.ToLower()) || d.Genre.Name!.ToLower().Contains(search.ToLower()) || d.Author.LastName!.ToLower().Contains(search.ToLower()) || d.Publisher!.ToLower().Contains(search.ToLower())).Include(a => a.Author).Include(g => g.Genre).OrderBy(n => n.Title).ToList();
					return books;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static int GetCount()
		{
			using (LmsContext context = new LmsContext())
			{
				var books = context.Books.ToList();
				return books.Count;
			}
		}

		public static bool AddBook(string _title, int _aid, int _gid, string _pub, int _year, string _is, int _cpy, decimal _prc, string _dte, string _abt)
		{
			using (LmsContext context = new LmsContext())
			{
				var title = _title;
				var books = context.Books.Where(b => b.Title == title && b.AuthorId == _aid && b.Year == _year).ToList();

				if (books.Count > 0)
				{
					MessageBox.Show("This book already exists", "Book Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}

				if (!string.IsNullOrEmpty(title))
				{
					Book newBook = new Book
					{
						Title = title,
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
				}
			}
			return true;
		}

		public static bool UpdateBook(int _id, string _title, int _aid, int _gid, string _pub, int _year, string _is, int _cpy, decimal _prc, string _dte, string _abt)
		{
			int id = _id;
			string title = _title;

			using (LmsContext context = new LmsContext())
			{
				Book book = context.Books.Where(i => i.BookId == id).FirstOrDefault()!;

				if (book != null)
				{
					book.Title = title;
					book.AuthorId = _aid;
					book.GenreId = _gid;
					book.Publisher = _pub;
					book.Year = _year;
					book.ISBN = _is;
					book.Copies = _cpy;
					book.Price = _prc;
					book.DateReceived = _dte;
					book.About = _abt;
					context.SaveChanges();
				}
				else
				{
					return false;
				}
			}
			return true;
		}

		public static bool DeleteBook(int _id)
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
	}
}
