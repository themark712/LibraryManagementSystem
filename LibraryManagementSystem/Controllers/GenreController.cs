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

namespace LibraryManagementSystem.Controllers
{
	public static class GenreController
	{
		public static List<Genre>? GetGenres()
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var genres = context.Genres.ToList();
					return genres.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static bool AddGenre(string _name)
		{
			using (LmsContext context = new LmsContext())
			{
				var name = _name;
				var genres = context.Genres.Where(n=>n.Name==name).ToList();

				if(genres.Count > 0)
				{
					MessageBox.Show("This genere already exists","Genre Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					return false;
				}

				if (!string.IsNullOrEmpty(name))
				{
					context.Genres.Add(new Genre() { Name = name });
					context.SaveChanges();
				}
			}
			return true;
		}

		public static bool UpdateGenre(int _id, string _name)
		{
			int id = _id;
			string name = _name;

			using (LmsContext context = new LmsContext())
			{
				Genre genre = context.Genres.Where(i => i.GenreId == id).FirstOrDefault()!;

				if (genre != null && !string.IsNullOrEmpty(name))
				{
					genre.Name = name;
					context.SaveChanges();
				} else
				{
					return false;
				}
			}
			return true;
		}

		public static bool DeleteGenre(int _id)
		{
			int id = _id;

			using (LmsContext context = new LmsContext())
			{
				Genre genre = context.Genres.Where(i => i.GenreId == id).FirstOrDefault()!;

				if (genre != null)
				{
					context.Remove(genre);
					context.SaveChanges();
				}
			}
			return true;
		}
	}
}
