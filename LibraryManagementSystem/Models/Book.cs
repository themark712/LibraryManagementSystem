using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
	public class Book
	{
		[Key]
		public int BookId { get; set; }

		[Required]
		[MaxLength(200)]
		public string? Title { get; set; }=string.Empty;

		[Required]
		[Display(Name = "Author")]
		public int? AuthorId { get; set; }

		// navigation property - one-to-one
		[ValidateNever]
		public Author Author { get; set; } = null!;

		[Required]
		public int GenreId { get; set; }

		// navigation property - one-to-one
		[ValidateNever]
		public Genre Genre { get; set; } = null!;

		[MaxLength(100)]
		public string? Publisher { get; set; } = string.Empty;

		[Required]
		public int Year { get; set; }

		[MaxLength(20)]
		public string? ISBN { get; set; }= string.Empty;

		public int? Copies { get; set; } = 0;

		[Precision(10, 2)]
		public decimal? Price { get; set; } = 0;

		[MaxLength(300)]
		public string? About {  get; set; } = string.Empty;

		public string? DateReceived {  get; set; } = string.Empty;

		public byte? Cover { get; set; } = 0;

		public string? BookListItem
		{
			get { return $"{Title}, {ISBN}"; }
		}
	}
}
