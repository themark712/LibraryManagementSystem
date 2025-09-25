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
	public class AppUserController
	{

		public static List<AppUser>? GetUsers(string uName, string password)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var users = context.AppUsers.ToList();
					return users;
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
				using (LmsContext context = new LmsContext())
				{
					var user =context.AppUsers.Where(u=>u.Username==uName && u.Password==password).FirstOrDefault();
					return user;
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
			using (LmsContext context = new LmsContext())
			{
				if(user != null && !string.IsNullOrEmpty(user!.Username))
				context.Add(user);
				context.SaveChanges();
			}
		}
	}
}
