using LibraryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
	public partial class DatabaseSetupForm : Form
	{
		public DatabaseSetupForm()
		{
			InitializeComponent();
		}

		private void buttonGetDataFolder_Click(object sender, EventArgs e)
		{
			buttonSetLocation.Enabled = false;

			var result = folderBrowserData.ShowDialog();
			if (result == DialogResult.OK && Directory.Exists(folderBrowserData.SelectedPath))
			{
				textDatabase.Text = folderBrowserData.SelectedPath;
				buttonSetLocation.Enabled = true;
			}
		}

		private void buttonSetLocation_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(textDatabase.Text))
			{
				Utilties.AddOrUpdateAppSettings("DatabaseLocation", textDatabase.Text);
				this.Close();
			}
		}

		private void DatabaseSetupForm_Load(object sender, EventArgs e)
		{
			buttonSetLocation.Enabled = false;
		}
	}
}
