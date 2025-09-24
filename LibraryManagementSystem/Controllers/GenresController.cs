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

namespace LibraryManagementSystem.Controllers
{
	public static class GenresController
	{
		public static List<Genres>? GetGenres()
		{
			try
			{
				using (IDbConnection conn = new SQLiteConnection(MyDb.LoadConnectionString()))
				{
					var genres = conn.Query<Genres>("SELECT * FROM Genres ORDER BY Name", new DynamicParameters());
					return genres.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static bool AddGenre(string name)
		{
			return true;
		}

		public static bool UpdateGenre(int id, string name)
		{
			return true;
		}

		public static bool DeleteGenre(int id)
		{
			return true;
		}
	}
}
