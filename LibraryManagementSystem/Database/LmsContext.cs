using Dapper;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using State = LibraryManagementSystem.Models.State;

namespace LibraryManagementSystem.Database
{
	public class LmsContext : DbContext
	{
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Circulation> Circulation { get; set; }
		public DbSet<State> States { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
			var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var settings = configFile.AppSettings.Settings;

			if (Directory.Exists(ConfigurationManager.AppSettings["DatabaseLocation"]))
			{
				string folder = ConfigurationManager.AppSettings["DatabaseLocation"]!;
				string dbName = "LMS.db";
				string path = Path.Combine(folder, dbName);
				string connString = string.Format("data source={0}", path);
				optionsBuilder.UseSqlite(connString);
			}
		}

		// seed data
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<State>().HasData(
				new { StateId = 1, StateName = "", Abbreviation = "" },
				new { StateId = 2, StateName = "Alabama", Abbreviation = "AL" },
				new { StateId = 3, StateName = "Alaska", Abbreviation = "AK" },
				new { StateId = 4, StateName = "Arizona", Abbreviation = "AZ" },
				new { StateId = 5, StateName = "Arkansas", Abbreviation = "AR" },
				new { StateId = 6, StateName = "California", Abbreviation = "CA" },
				new { StateId = 7, StateName = "Colorado", Abbreviation = "CO" },
				new { StateId = 8, StateName = "Connecticut", Abbreviation = "CT" },
				new { StateId = 9, StateName = "Delaware", Abbreviation = "DE" },
				new { StateId = 10, StateName = "District of Columbia", Abbreviation = "DC" },
				new { StateId = 11, StateName = "Florida", Abbreviation = "FL" },
				new { StateId = 12, StateName = "Georgia", Abbreviation = "GA" },
				new { StateId = 13, StateName = "Hawaii", Abbreviation = "HI" },
				new { StateId = 14, StateName = "Idaho", Abbreviation = "ID" },
				new { StateId = 15, StateName = "Illinois", Abbreviation = "IL" },
				new { StateId = 16, StateName = "Indiana", Abbreviation = "IN" },
				new { StateId = 17, StateName = "Iowa", Abbreviation = "IA" },
				new { StateId = 18, StateName = "Kansas", Abbreviation = "KS" },
				new { StateId = 19, StateName = "Kentucky", Abbreviation = "KY" },
				new { StateId = 20, StateName = "Louisiana", Abbreviation = "LA" },
				new { StateId = 21, StateName = "Maine", Abbreviation = "ME" },
				new { StateId = 22, StateName = "Maryland", Abbreviation = "MD" },
				new { StateId = 23, StateName = "Massachusetts", Abbreviation = "MA" },
				new { StateId = 24, StateName = "Michigan", Abbreviation = "MI" },
				new { StateId = 25, StateName = "Minnesota", Abbreviation = "MN" },
				new { StateId = 26, StateName = "Mississippi", Abbreviation = "MS" },
				new { StateId = 27, StateName = "Missouri", Abbreviation = "MO" },
				new { StateId = 28, StateName = "Montana", Abbreviation = "MT" },
				new { StateId = 29, StateName = "Nebraska", Abbreviation = "NE" },
				new { StateId = 30, StateName = "Nevada", Abbreviation = "NV" },
				new { StateId = 31, StateName = "New Hampshire", Abbreviation = "NH" },
				new { StateId = 32, StateName = "New Jersey", Abbreviation = "NJ" },
				new { StateId = 33, StateName = "New Mexico", Abbreviation = "NM" },
				new { StateId = 34, StateName = "New York", Abbreviation = "NY" },
				new { StateId = 35, StateName = "North Carolina", Abbreviation = "NC" },
				new { StateId = 36, StateName = "North Dakota", Abbreviation = "ND" },
				new { StateId = 37, StateName = "Ohio", Abbreviation = "OH" },
				new { StateId = 38, StateName = "Oklahoma", Abbreviation = "OK" },
				new { StateId = 39, StateName = "Oregon", Abbreviation = "OR" },
				new { StateId = 40, StateName = "Pennsylvania", Abbreviation = "PA" },
				new { StateId = 41, StateName = "Rhode Island", Abbreviation = "RI" },
				new { StateId = 42, StateName = "South Carolina", Abbreviation = "SC" },
				new { StateId = 43, StateName = "South Dakota", Abbreviation = "SD" },
				new { StateId = 44, StateName = "Tennessee", Abbreviation = "TN" },
				new { StateId = 45, StateName = "Texas", Abbreviation = "TX" },
				new { StateId = 46, StateName = "Utah", Abbreviation = "UT" },
				new { StateId = 47, StateName = "Vermont", Abbreviation = "VT" },
				new { StateId = 48, StateName = "Virginia", Abbreviation = "VA" },
				new { StateId = 49, StateName = "Washington", Abbreviation = "WA" },
				new { StateId = 50, StateName = "West Virginia", Abbreviation = "WV" },
				new { StateId = 51, StateName = "Wisconsin", Abbreviation = "WI" },
				new { StateId = 52, StateName = "Wyoming", Abbreviation = "WY" }   
			);

			modelBuilder.Entity<AppUser>().HasData(
				new AppUser { AppUserId = 1, FirstName = "Admin", LastName = "User", Username = "admin", Password = "admin123", Role = "admin", Email="adminUser@gmail.com" , DOB="1973-11-03"}
				, new AppUser { AppUserId = 2, FirstName = "Library", LastName = "Patron", Username = "patron", Password = "patron123", Role = "user", Email="library-patron-212@gmail.com" , DOB="1979-09-21"}
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
				, new Genre { GenreId = 18, Name = "Drama/Play" }
				, new Genre { GenreId = 19, Name = "Classic Literature: Other" }
			);

			modelBuilder.Entity<Author>().HasData(
				new Author { AuthorId = 1, FirstName = "Stephen", LastName = "King", Hometown = "Portland, ME", DOB = "1949-09-21", DOD = "", Education = "BA, University of Maine-Orono", About = "" }
				, new Author { AuthorId = 2, FirstName = "Dean", LastName = "Koontz", Hometown = "Everett, PA", DOB = "1945-07-09", DOD = "", Education = "BA, Shippensburg State College (PA)", About = "" }
				, new Author { AuthorId = 3, FirstName = "Charles", LastName = "Dickens", Hometown = "Portsmouth, England", DOB = "1812-02-07", DOD = "1870-06-08", Education = "", About = "" }
				, new Author { AuthorId = 4, FirstName = "William", LastName = "Shakespeare", Hometown = "Stratford-upon-Avon, England", DOB = "1564-04-23", DOD = "1616-04-23", Education = "King's New School, Stratford, England", About = "Famous English playwrite" }
				, new Author { AuthorId = 5, FirstName = "Agatha", LastName = "Christie", Hometown = "Torquay, England", DOB = "1890-09-15", DOD = "1976-01-12", Education = "", About = "Mystery writer" }
				, new Author { AuthorId = 6, FirstName = "J.K.", LastName = "Rowling", Hometown = "Yate, England", DOB = "1965-07-31", DOD = "", Education = "BA, University of Exeter", About = "Famou for Harry Potter series" }
				, new Author { AuthorId = 7, FirstName = "Leo", LastName = "Tolstoy", Hometown = "Yasnaya Polyana, Russia", DOB = "1828-09-09", DOD = "1910-11-20", Education = "Imperial Kazan University", About = "Classic Russian writer" }
				, new Author { AuthorId = 8, FirstName = "Louis", LastName = "L'Amour", Hometown = "Jamestown, ND", DOB = "1908-03-22", DOD = "1988-06-10", Education = "", About = "American Western writer" }
				, new Author { AuthorId = 9, FirstName = "Robert", LastName = "Ludlum", Hometown = "New York, NY", DOB = "1927-05-25", DOD = "2001-03-12", Education = "BA, Wesleyan University", About = "Spy fiction writer" }
				, new Author { AuthorId = 10, FirstName = "Tom", LastName = "Clancy", Hometown = "Baltimore, MD", DOB = "1947-04-12", DOD = "2013-10-01", Education = "BA, Loyola College (MD)", About = "Military thriller writer" }
				, new Author { AuthorId = 11, FirstName = "John", LastName = "Grisham", Hometown = "Jonesboro, AK", DOB = "1955-02-08", DOD = "", Education = "BS, Mississippi State University" + Environment.NewLine + "JD, University of Mississippi", About = "Legal thriller writer" }
				, new Author { AuthorId = 12, FirstName = "C.S.", LastName = "Lewis", Hometown = "Belfast, Ireland", DOB = "1898-11-29", DOD = "1963-11-22", Education = "University College (Oxford)", About = "Chrisian apologetics writer" }
				, new Author { AuthorId = 13, FirstName = "Anne", LastName = "Rice", Hometown = "New Orleans, LA", DOB = "1941-10-04", DOD = "2021-12-11", Education = "BA, MA, San Francisco State University", About = "Gothic horror writer" }
				, new Author { AuthorId = 14, FirstName = "J.R.R", LastName = "Tolkein", Hometown = "Bloefmontien, South Africa", DOB = "1892-01-03", DOD = "1973-09-02", Education = "Exeter College, Oxford", About = "Fantasy writer" }
				, new Author { AuthorId = 15, FirstName = "James", LastName = "Patterson", Hometown = "Newburgh, NY", DOB = "1947-03-22", DOD = "", Education = "BA, Manhattan University" + Environment.NewLine + "MA, Vanderbility University", About = "Mystery/thriller writer" }
			);

			modelBuilder.Entity<Book>().HasData(
				new Book { BookId = 1, AuthorId = 1, Title = "'Salem's Lot", GenreId = 9, Publisher = "Doubleday", Year = 1975, ISBN = "978-0-385-00751-1", Copies = 1, Price = 14.99M, DateReceived = "", About = "Vampires in a small Maine town", Cover = null }
				, new Book { BookId = 2, AuthorId = 2, GenreId = 16,   Title = "Intensity", Publisher = "Knopf", Year = 1996, ISBN = "0-7472-1334-8", Copies = 1, Price = 15.99M, DateReceived = "", About = "College student targeted by serial killer", Cover = null }
				, new Book { BookId = 3, AuthorId = 3, GenreId = 3,    Title = "A Tale of Two Cities", Publisher = "Chapman & Hall", Year = 1859, ISBN = "978-0141439600", Copies = 1, Price = 7.99M, DateReceived = "", About = "French Revolution", Cover = null }
				, new Book { BookId = 4, AuthorId = 1, GenreId = 9,    Title = "The Stand", Publisher = "Doubleday", Year = 1978, ISBN = "978-0-385-12168-2", Copies = 1, Price = 16.99M, DateReceived = "", About = "Apocalytic thriller", Cover = null }
				, new Book { BookId = 5, AuthorId = 2, GenreId = 16,   Title = "False Memory", Publisher = "Bantam Books", Year = 1999, ISBN = "0-553-10666-X", Copies = 1, Price = 15.99M, DateReceived = "", About = "Autophobic patient manipulated by therapist", Cover = null }
				, new Book { BookId = 6, AuthorId = 3, GenreId = 3,    Title = "A Christmas Carol", Publisher = "Chapman & Hall", Year = 1843, ISBN = "978-0486268651", Copies = 1, Price = 6.99M, DateReceived = "", About = "Christmas ghost story", Cover = null }
				, new Book { BookId = 7, AuthorId = 4, GenreId = 18,   Title = "Romeo and Juliet", Publisher = "", Year = 1590, ISBN = "", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 8, AuthorId = 4, GenreId = 18,   Title = "The Taming of the Shrew", Publisher = "", Year = 1595, ISBN = "9780486275574", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				
				, new Book { BookId = 9, AuthorId = 5, GenreId = 11,   Title = "Death on the Nile", Publisher = "Collins Crime Club", Year = 1937, ISBN = "9780062073556", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 10, AuthorId = 5, GenreId = 11,  Title = "Murder on the Orient Express", Publisher = "Collins Crime Club", Year = 1934, ISBN = "9780007119318", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 11, AuthorId = 6, GenreId = 4,   Title = "Harry Potter and the Philosopher's's Stone", Publisher = "Pottermore Publishing", Year = 1997, ISBN = "978-0-7475-3269-9", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 12, AuthorId = 6, GenreId = 4,   Title = "Harry Potter and the Deathly Hallows", Publisher = "Raincoast Books.", Year = 2007, ISBN = "9780545010221", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 13, AuthorId = 7, GenreId = 19,  Title = "War and Peace", Publisher = "Edimat Libros", Year = 1869, ISBN = "9780192833983", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 14, AuthorId = 7, GenreId = 19,  Title = "Anna Karenina", Publisher = "The Russian Messenger", Year = 1878, ISBN = "9780345803924", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 15, AuthorId = 8, GenreId = 17,  Title = "Last of the Breed", Publisher = "Bantam Books", Year = 1987, ISBN = "9780593129944", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 16, AuthorId = 8, GenreId = 17,  Title = "Shalako", Publisher = "Bantam Books", Year = 1985, ISBN = "9780553248586 ", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 17, AuthorId = 9, GenreId = 16,  Title = "The Bourne Identity", Publisher = "Richard Marek", Year = 1980, ISBN = "0-399-90070-5", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 18, AuthorId = 9, GenreId = 16,  Title = "The Parsifal Mosaic", Publisher = "Random House", Year = 1982, ISBN = "0-394-52111-0", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 19, AuthorId = 10, GenreId = 16, Title = "Patriot Games", Publisher = "G.P. Putnam's Sons", Year = 1987, ISBN = "0399132414", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 20, AuthorId = 10, GenreId = 16, Title = "Clear and Present Danger", Publisher = "G.P. Putnam's Sons", Year = 1989, ISBN = "0399134409", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 21, AuthorId = 11, GenreId = 16, Title = "The Pelican Brief", Publisher = "Doubleday", Year = 1992, ISBN = "0-385-42198-2", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 22, AuthorId = 11, GenreId = 16, Title = "The Client", Publisher = "Doubleday", Year = 1993, ISBN = "9780385424714", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 23, AuthorId = 12, GenreId = 4,  Title = "The Lion, the Witch, and the Wardrobe", Publisher = "Geoffrey Bles", Year = 1950, ISBN = "9780064404990", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 24, AuthorId = 12, GenreId = 4,  Title = "The Screwtape Letters", Publisher = "Geoffrey Bles", Year = 1942, ISBN = "978-0060652937", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 25, AuthorId = 13, GenreId = 9,  Title = "Interview with the Vampire", Publisher = "Knopf", Year = 1976, ISBN = "0-394-49821-6", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 26, AuthorId = 13, GenreId = 9,  Title = "Merrick", Publisher = "Chatto & Windus", Year = 2000, ISBN = "9780345422408 ", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 27, AuthorId = 14, GenreId = 4,  Title = "The Hobbit", Publisher = "George Allen & Unwin", Year = 1937, ISBN = "9780007458424", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 28, AuthorId = 14, GenreId = 4,  Title = "The Lord of the Rings: The Fellowship of the Ring", Publisher = "George Allen & Unwin", Year = 1954, ISBN = "9780547952017", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 29, AuthorId = 15, GenreId = 16, Title = "Along Came a Spider", Publisher = "Little, Brown and Company", Year = 1993, ISBN = "0-316-69364-2", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
				, new Book { BookId = 30, AuthorId = 15, GenreId = 16, Title = "Kiss the Girls", Publisher = "Little, Brown and Company", Year = 1995, ISBN = "0-316-69370-7", Copies = 1, Price = 4.99M, DateReceived = "", About = "", Cover = null }
			);
		}
	}
}
