using Dapper;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Database
{
	public class LmsContext: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["LMS"].ConnectionString);
		}

		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
	}
}
