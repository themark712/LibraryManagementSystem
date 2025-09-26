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
	public class LmsContext : DbContext
	{
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
			string dbName = "LMS.db";
			string path = Path.Combine(folder, dbName);
			string connString = string.Format("data source={0}", path);
			optionsBuilder.UseSqlite(connString);
		}

		// seed data
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AppUser>().HasData(
				new AppUser { AppUserId = 1, FirstName = "Admin", LastName = "User", Username = "admin", Password = "admin123", Role = "admin" }
				, new AppUser { AppUserId = 2, FirstName = "Library", LastName = "Patron", Username = "patron", Password = "patron123", Role = "user" }
			);

			modelBuilder.Entity<Genre>().HasData(
				new Genre { GenreId = 1, Name = "Biography" }
				, new Genre { GenreId = 2, Name = "Classic Literature: American" }
				, new Genre { GenreId = 3, Name = "Classic Literature: British" }
				, new Genre { GenreId = 4, Name = "Fantasy" }
				, new Genre { GenreId = 5, Name = "General Fiction" }
				, new Genre { GenreId = 6, Name = "General Nonfiction" }
				, new Genre { GenreId = 7, Name = "History" }
				, new Genre { GenreId = 8, Name = "Holiday" }
				, new Genre { GenreId = 9, Name = "Horror" }
				, new Genre { GenreId = 10, Name = "Music" }
				, new Genre { GenreId = 11, Name = "Mystery" }
				, new Genre { GenreId = 12, Name = "Science" }
				, new Genre { GenreId = 13, Name = "Science Fiction" }
				, new Genre { GenreId = 14, Name = "Sports" }
				, new Genre { GenreId = 15, Name = "Technology" }
				, new Genre { GenreId = 16, Name = "Thriller" }
				, new Genre { GenreId = 17, Name = "Western" }
			);

			modelBuilder.Entity<Author>().HasData(
				new Author { AuthorId = 1, FirstName = "Stephen", LastName = "King", Hometown = "Portland, ME", DOB = "1949-09-21", DOD = "", Education = "BA, University of Maine-Orono", About = "" }
				, new Author { AuthorId = 2, FirstName = "Dean", LastName = "Koontz", Hometown = "Everett, PA", DOB = "1945-07-09", DOD = "", Education = "BA, Shippensburg State College (PA)", About = "" }
				, new Author { AuthorId = 3, FirstName = "Charles", LastName = "Dickens", Hometown = "Portsmouth, England", DOB = "1812-02-07", DOD = "1870-06-08", Education = "", About = "" }
			);

			modelBuilder.Entity<Book>().HasData(
				new Book { BookId = 1, Title = "'Salem's Lot", AuthorId = 1, GenreId = 9, Publisher = "Doubleday", Year = 1975, ISBN = "978-0-385-00751-1", Copies = 1, Price = 14.99M, DateReceived = "", About = "Vampires in a small Maine town", Cover = null }
				, new Book { BookId = 2, Title = "Intensity", AuthorId = 2, GenreId = 16, Publisher = "Knopf", Year = 1996, ISBN = "0-7472-1334-8", Copies = 1, Price = 15.99M, DateReceived = "", About = "College student targeted by serial killer", Cover = null }
				, new Book { BookId = 3, Title = "A Tale of Two Cities", AuthorId = 3, GenreId = 3, Publisher = "Chapman & Hall", Year = 1859, ISBN = "978-0141439600", Copies = 1, Price = 7.99M, DateReceived = "", About = "French Revolution", Cover = null }
			);
		}
	}
}
