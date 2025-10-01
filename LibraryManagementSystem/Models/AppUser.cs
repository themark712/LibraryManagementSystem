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

		[Required(ErrorMessage = "User card number is required")]
		public string? UserNumber { get; set; } = string.Empty;

		[Required(ErrorMessage = "User first name is required")]
		[MaxLength(100)]
		public string? FirstName { get; set; }

		[Required(ErrorMessage = "User last name is required")]
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

		public string? Zip { get; set; } = string.Empty;

		[Phone(ErrorMessage = "Invalid phone number")]
		public string? Phone { get; set; } = string.Empty;

		[Required]
		public string? DOB { get; set; } = string.Empty;

		[Required]
		[EmailAddress(ErrorMessage = "Invalid email address.")]
		public string? Email { get; set; }	
	}
}
