using LibraryManagementSystem.Database;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controllers
{
	public class StateController
	{
		public List<State>? GetStates()
		{
			try
			{
				using (LmsContext context = new LmsContext())
				{
					var states = context.States.ToList();
					return states;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}
	}
}
