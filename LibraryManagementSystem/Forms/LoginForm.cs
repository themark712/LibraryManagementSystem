using LibraryManagementSystem.Database;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Controllers;
using Microsoft.EntityFrameworkCore.Infrastructure;
using LibraryManagementSystem.Classes;

namespace LibraryManagementSystem.Forms
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			DatabaseFacade facade = new DatabaseFacade(new LmsContext());
			facade.EnsureCreated();

			this.AcceptButton = buttonLogin;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// manipulate the dashboard form from the login form
		private DashboardForm? dashboardForm = null;

		public LoginForm(DashboardForm sourceForm)
		{
			dashboardForm = sourceForm as DashboardForm;
			InitializeComponent();
		}

		// the login button click handler
		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string username = textUsername.Text;
			string password = textPassword.Text;

			//DataTable table = new DataTable();

			//List<AppUser>? users = MyDb.GetUsers(username, password);
			AppUser? user = AppUserController.GetUser(username, password);

			try
			{
				// check if this user exists or not 
				if (user != null)   // if exists
				{
					App.User = user;
					dashboardForm!.Enabled = true;

					Label? labelHeader = dashboardForm.Controls.Find("labelHeaderName", true).FirstOrDefault() as Label;
					labelHeader!.Text = "Welcome, " + App.User!.FirstName + " " + App.User.LastName;

					this.Close();
				}
				else      // if not exists
				{
					// check if the username is empty
					if (username.Trim().Equals(""))
					{
						MessageBox.Show("Please enter your username", "No Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					// check if the username is empty
					else if (password.Trim().Equals(""))
					{
						MessageBox.Show("Please enter your password", "No Passwod", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					// if user is not found
					else
					{
						MessageBox.Show("Incorrect username or password", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				string errorMessage = ex.Message;
				if (errorMessage == "Unable to connect to any of the specified MySQL hosts")
				{
					MessageBox.Show("MySql database does not exist on this system. " + errorMessage + ". You can install the MySql database system by installing the XAMPP MySql Server and following the database setup instrutions in this app.", "Database Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
