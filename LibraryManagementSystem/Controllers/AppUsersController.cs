using Dapper;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Database;

namespace LibraryManagementSystem.Controllers
{
	public class AppUserControllers
	{

		public static List<AppUser>? GetUsers(string uName, string password)
		{
			try
			{
				using (IDbConnection conn = new SQLiteConnection(MyDb.LoadConnectionString()))
				{
					var users = conn.Query<AppUser>("SELECT * FROM AppUsers", new DynamicParameters());
					return users.ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static AppUser? GetUser(string uName, string password)
		{
			try
			{
				using (IDbConnection conn = new SQLiteConnection(MyDb.LoadConnectionString()))
				{
					var users = conn.Query<AppUser>("SELECT * FROM AppUsers", new DynamicParameters());
					return users.FirstOrDefault();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static void AddUser(AppUser user)
		{
			using (IDbConnection conn = new SQLiteConnection(MyDb.LoadConnectionString()))
			{
				conn.Execute("INSERT INTO AppUsers (FirstName, LastName, Username,  Password, UserType) VALUES (@FirstName, @LastName, @Username, @Password, @UserType)", user);
			}
		}
	}
}
