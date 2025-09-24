using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
	public class AppUser
	{
		[Key]
		public int AppUserId { get; set; }

		[Required]
		[MaxLength(100)]
		public string? FirstName { get; set; }

		[Required]
		[MaxLength(100)]
		public string? LastName { get; set; }

		[Required]
		[MaxLength(50)]
		public string? Username { get; set; }

		[Required]
		[MaxLength(20)]
		public string? Password { get; set; }

		[MaxLength(20)]
		public string? UserType { get; set; } = "User";
	}
}
