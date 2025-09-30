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
	public class GenreController
	{
		public List<Genre>? GetGenres()
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var genres = context.Genres.OrderBy(n => n.Name).ToList();
					return genres.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public Genre? GetGenre(int _id)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var genre = context.Genres.Where(i => i.GenreId == _id).FirstOrDefault();
					return genre;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public int AddGenre(string _name)
		{
			using (LmsContext context = new LmsContext())
			{
				var name = _name;
				var genres = context.Genres.Where(n => n.Name == name).ToList();
				int newGenreId = 0;

				if (genres.Count > 0)
				{
					MessageBox.Show("This genre already exists", "Genre Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return 0;
				}

				if (!string.IsNullOrEmpty(name))
				{

					Genre newGenre = new Genre
					{
						Name = name
					};
					context.Genres.Add(newGenre);
					context.SaveChanges();
					newGenreId = newGenre.GenreId;
				}
				return newGenreId;
			}
		}

		public bool UpdateGenre(int _id, string _name)
		{
			int id = _id;
			string name = _name;

			using (LmsContext context = new LmsContext())
			{
				Genre genre = context.Genres.Where(i => i.GenreId == id).FirstOrDefault()!;

				if (genre != null)
				{
					genre.Name = name;
					context.SaveChanges();
				}
				else
				{
					return false;
				}
			}
			return true;
		}

		public bool DeleteGenre(int _id)
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
