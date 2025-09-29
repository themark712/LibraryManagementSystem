using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Classes
{
	public static class App
	{
		//Public privateFontCollection As New Drawing.Text.PrivateFontCollection
		public static PrivateFontCollection pFontCollection = new PrivateFontCollection();
		public static AppUser? User = null;
		public static string DatabaseLocation = "";
		public static int GenreId=0;
		public static int AuthorId=0;

		public static void AddFont()
		{
			//pFontCollection.AddFontFile(".\\Fonts\\Lato-Regular.ttf");
		}
	}
}
