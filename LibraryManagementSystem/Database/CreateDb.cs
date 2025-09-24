using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Database
{
	public static class CreateDb
	{
		// open xampp
		// create the database
		// create AppUsers table

		static bool CreateDatabase()
		{
			string sql = "CREATE DATABASE IF NOT EXISTS LMS_DB";
			return true;
		}

		static bool CreateUserTable()
		{
			string sql = "CREATE TABLE `LMS_DB`.`AppUsers` (";
			sql += "`AppUserId` INT NOT NULL AUTO_INCREMENT , ";
			sql += " `FirstName` VARCHAR(100) NOT NULL , ";
			sql += " ``LastName` VARCHAR(100) NOT NULL , ";
			sql += " ``Username` VARCHAR(50) NOT NULL , ";
			sql += " ``Password` VARCHAR(20) NOT NULL , ";
			sql += " ``UserType` VARCHAR(20) NOT NULL , ";
			sql += " `PRIMARY KEY (`AppUserId`)) ENGINE = InnoDB;";
			return true;
		}
	}
}
