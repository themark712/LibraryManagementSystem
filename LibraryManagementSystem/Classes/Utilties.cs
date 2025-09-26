using LibraryManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
	public class Utilties
	{
		public static void CreateDatabase()
		{
			using var context = new LmsContext();
			context.Database.EnsureCreated();
		}
	}
}
