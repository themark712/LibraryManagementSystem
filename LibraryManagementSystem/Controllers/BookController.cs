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
					var books = context.Books.Include(a => a.Author).Include(g=>g.Genre).OrderBy(n=>n.Title).ToList();
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
					var book = context.Books.Where(i=>i.BookId==_id).FirstOrDefault();
					return book;
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

		public static bool AddBook(string _title)
		{
			using (LmsContext context = new LmsContext())
			{
				var title = _title;
				var books = context.Books.Where(n=>n.Title==title).ToList();

				if(books.Count > 0)
				{
					MessageBox.Show("This book already exists","Book Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}

				if (!string.IsNullOrEmpty(title))
				{
					context.Books.Add(new Book() { Title = title });
					context.SaveChanges();
				}
			}
			return true;
		}

		public static bool UpdateBook(int _id, string _title)
		{
			int id = _id;
			string title = _title;

			using (LmsContext context = new LmsContext())
			{
				Book book = context.Books.Where(i => i.BookId == id).FirstOrDefault()!;

				if (book != null)
				{
					book.Title = title;
					context.SaveChanges();
				} else
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
