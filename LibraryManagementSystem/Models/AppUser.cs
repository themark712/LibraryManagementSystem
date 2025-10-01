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
		public string? UserNumber { get; set; } = string.Empty;

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
		[Required]
		public string? Role { get; set; } = "user";

		public string? Address1 { get; set; } = string.Empty;

		public string? Address2 { get; set; } = string.Empty;

		public string? City { get; set; } = string.Empty;

		public string? State { get; set; } = string.Empty;

		public string? Zip {  get; set; } = string.Empty;

		public string? Phone {  get; set; } = string.Empty;

		[Required]
		public string? DOB { get; set; }= string.Empty;
	}
}
