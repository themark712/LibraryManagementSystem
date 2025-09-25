using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace LibraryManagementSystem.Database
{
	public static class MyDb_DEL
	{
		public static string LoadConnectionString(string id = "LMS")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}
