using LibraryManagementSystem.Database;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controllers
{
	public static class AuthorController
	{
		public static List<Author>? GetAuthors()
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var authors = context.Authors.OrderBy(l=>l.LastName).ThenBy(f=>f.FirstName).ThenBy(d=>d.DOB).ToList();
					return authors;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static List<Author>? SearchAuthors(string search)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var authors = context.Authors.Where(d=>d.FirstName!.ToLower().Contains(search.ToLower()) || d.LastName!.ToLower().Contains(search.ToLower())).ToList();
					return authors;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static Author? GetAuthor(int _id)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var author = context.Authors.Where(i => i.AuthorId == _id).FirstOrDefault();
					return author;
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
				var authors = context.Authors.ToList();
				return authors.Count;
			}
		}

		public static int AddAuthor(string _fname, string _lname, string? _dob, string? _dod, string _hometown, string _eduction, string _about)
		{
			using (LmsContext context = new LmsContext())
			{
				// find existing authors with same first name, last name, and date of birth
				var authors = context.Authors.Where(n => n.FirstName == _fname && n.LastName == _lname && n.DOB == _dob).ToList();

				if (authors.Count > 0)
				{
					MessageBox.Show("This author already exists", "Author Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return 0;
				}
				Author newAuthor = new Author
				{
					FirstName = _fname,
					LastName = _lname,
					DOB = _dob != null ? _dob : null,
					DOD = _dod != null ? _dod : null,
					Hometown = _hometown,
					Education = _eduction,
					About = _about
				};

				context.Authors.Add(newAuthor);
				context.SaveChanges();
				return newAuthor.AuthorId;
			}
		}

		public static bool UpdateAuthor(int _id, string _fname, string _lname, string _dob, string _dod, string _hometown, string _eduction, string _about)
		{
			int id = _id;

			using (LmsContext context = new LmsContext())
			{
				Author author = context.Authors.Where(i => i.AuthorId == id).FirstOrDefault()!;

				if (author != null)
				{
					author.FirstName = _fname;
					author.LastName = _lname;
					author.DOB = _dob;
					author.DOD = _dod;
					author.Hometown = _hometown;
					author.Education = _eduction;
					author.About = _about;
					context.SaveChanges();
				}
				else
				{
					return false;
				}
			}
			return true;
		}

		public static bool DeleteAuthor(int _id)
		{
			int id = _id;

			using (LmsContext context = new LmsContext())
			{
				Author author = context.Authors.Where(i => i.AuthorId == id).FirstOrDefault()!;

				if (author != null)
				{
					context.Remove(author);
					context.SaveChanges();
				}
			}
			return true;
		}
	}
}
