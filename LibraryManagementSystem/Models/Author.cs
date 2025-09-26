using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
	public class Author
	{
		[Key]
		public int AuthorId { get; set; }

		[Required]
		[MaxLength(100)]
		[Display(Name ="First Name")]
		public string? FirstName { get; set; } = string.Empty;

		[Required]
		[MaxLength(100)]
		[Display(Name = "Last Name")]
		public string? LastName { get; set; } = string.Empty;
		public string? FullName
		{
			get { return $"{LastName}, {FirstName}"; }
		}

		public string? DOB { get; set; }

		public string? DOD { get; set; }

		[MaxLength(100)]
		public string? Hometown { get; set; } = string.Empty;

		[MaxLength(200)]
		public string? Education { get; set; } = string.Empty;

		[MaxLength(200)]
		public string? About { get; set; } = string.Empty;
	}
}
