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
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace LibraryManagementSystem.Controllers
{
	public class AppUserController
	{

		public List<AppUser>? GetUsers()
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

		public AppUser? GetUser(int _uid)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var user = context.AppUsers.Where(u => u.AppUserId==_uid).FirstOrDefault();
					return user;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public AppUser? LoginUser(string uName, string password)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var user = context.AppUsers.Where(u => u.Username == uName && u.Password == password).FirstOrDefault();
					return user;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public List<AppUser>? SearchUsers(string search)
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var users = context.AppUsers
							.Where(d => d.FirstName!.ToLower().Contains(search.ToLower()) 
								|| d.LastName!.ToLower().Contains(search.ToLower())
								|| d.Phone!.Replace("-", "").ToLower().Contains(search.Replace("-","").ToLower())
								|| d.UserNumber!.ToLower().Contains(search.ToLower()))
							.ToList();
					return users;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public int AddUser(string _fn, string _ln, string _unum, string _a1, string _a2, string _cty, string _st, string _zip, string _ph, string _role)
		{

			using (LmsContext context = new LmsContext())
			{
				// find existing users with same first name, last name, and date of birth
				var users = context.AppUsers.Where(n => n.FirstName == _fn && n.LastName == _ln && n.UserNumber=="").ToList();

				if (users.Count > 0)
				{
					MessageBox.Show("This user already exists", "AppUser Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return 0;
				}
				AppUser newAppUser = new AppUser
				{
					FirstName = _fn,
					LastName = _ln,
					UserNumber = _unum,
					Address1 = _a1,
					Address2 = _a2,
					City = _cty,
					State = _st,
					Zip = _zip,
					Phone = _ph,
					Role = _role
				};

				context.AppUsers.Add(newAppUser);
				context.SaveChanges();
				return newAppUser.AppUserId;
			}
		}

		public bool UpdateUser(int _id, string _fn, string _ln, string _unum, string _a1, string _a2, string _cty, string _st, string _zip, string _ph, string _role)
		{
			int id = _id;

			using (LmsContext context = new LmsContext())
			{
				AppUser user = context.AppUsers.Where(i => i.AppUserId == id).FirstOrDefault()!;

				if (user != null)
				{
					user.FirstName = _fn;
					user.LastName = _ln;
					user.UserNumber = _unum;
					user.Address1 = _a1;
					user.Address2 = _a2;
					user.City = _cty;
					user.State = _st;
					user.Zip = _zip;
					user.Phone = _ph;
					user.Role = _role;
					context.SaveChanges();
				}
				else
				{
					return false;
				}
			}
			return true;
		}

		public bool DeleteUser(int _id)
		{
			int id = _id;

			using (LmsContext context = new LmsContext())
			{
				AppUser user = context.AppUsers.Where(i => i.AppUserId == id).FirstOrDefault()!;

				if (user != null)
				{
					context.Remove(user);
					context.SaveChanges();
				}
			}
			return true;
		}

	}
}
