using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
	public class Genres
	{
		[Key]
		public int GenreId { get; set; }

		[Required]
		public string? Name { get; set; } = string.Empty;
	}
}
