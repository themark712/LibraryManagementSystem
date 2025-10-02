using LibraryManagementSystem.Database;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagementSystem.Controllers
{
	public class CirculationController
	{
		public int GetCirculationCount()
		{
			int count = 0;

			using (LmsContext context = new LmsContext())
			{
				count = context.Circulation.Where(s => s.Status == "out").ToList().Count();
				return count;
			}
		}

		public List<Book> GetUserBooks(int _uid)
		{
			using (LmsContext context = new LmsContext())
			{
				List<Book>? books = new List<Book>();

				var circulation = context.Circulation.Where(u => u.AppUserId == _uid).ToList();

				if (circulation.Any())
				{
					foreach (var item in circulation)
					{
						Book book = context.Books.Where(i => i.BookId == item.BookId).FirstOrDefault()!;
						books!.Add(book);
					}
				}

				return books!;
			}
		}

		public int GetCirculationId(int _uid, int _bid)
		{
			using (LmsContext context = new LmsContext())
			{
				int circulationId = context.Circulation.Where(i => i.AppUserId == _uid && i.BookId == _bid).FirstOrDefault()!.CirculationId;
				return circulationId;
			}
		}

		public Circulation GetCirculationInfo(int _cid)
		{
			using (LmsContext context = new LmsContext())
			{
				Circulation circulation = context.Circulation.Where(i=>i.CirculationId== _cid).FirstOrDefault()!;
				return circulation;
			}
		}
	}
}
