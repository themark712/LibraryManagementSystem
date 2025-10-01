using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
	public class Circulation
	{
		[Key]
		public int CirculationId { get; set; }

		[Required]
		public int AppUserId { get; set; }	

		[Required]
		public int BookId { get; set; }

		[Required]
		public string CheckOutDate { get; set; } = null!;

		[Required]
		public string DueDate { get; set; } = null!;

		public int NumberRenewals { get; set; } = 0;

		public string Status { get; set; } = string.Empty;
	}
}
