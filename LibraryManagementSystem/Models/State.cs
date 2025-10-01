using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
	public class State
	{
		[Key]
		public int StateId { get; set; }

		public string StateName { get; set; } = string.Empty;

		public string Abbreviation { get; set; } = string.Empty;
	}
}
