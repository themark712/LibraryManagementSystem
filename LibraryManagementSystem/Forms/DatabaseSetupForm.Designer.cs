namespace LibraryManagementSystem.Forms
{
	partial class DatabaseSetupForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSetupForm));
			folderBrowserData = new FolderBrowserDialog();
			textDatabase = new TextBox();
			buttonGetDataFolder = new Button();
			buttonSetLocation = new Button();
			labelInfo = new Label();
			SuspendLayout();
			// 
			// textDatabase
			// 
			textDatabase.Location = new Point(187, 247);
			textDatabase.Name = "textDatabase";
			textDatabase.Size = new Size(277, 23);
			textDatabase.TabIndex = 0;
			// 
			// buttonGetDataFolder
			// 
			buttonGetDataFolder.Location = new Point(30, 246);
			buttonGetDataFolder.Name = "buttonGetDataFolder";
			buttonGetDataFolder.Size = new Size(135, 23);
			buttonGetDataFolder.TabIndex = 1;
			buttonGetDataFolder.Text = "Browse Location ...";
			buttonGetDataFolder.UseVisualStyleBackColor = true;
			buttonGetDataFolder.Click += buttonGetDataFolder_Click;
			// 
			// buttonSetLocation
			// 
			buttonSetLocation.Location = new Point(332, 280);
			buttonSetLocation.Name = "buttonSetLocation";
			buttonSetLocation.Size = new Size(132, 23);
			buttonSetLocation.TabIndex = 2;
			buttonSetLocation.Text = "Set Database Location";
			buttonSetLocation.UseVisualStyleBackColor = true;
			buttonSetLocation.Click += buttonSetLocation_Click;
			// 
			// labelInfo
			// 
			labelInfo.Location = new Point(30, 9);
			labelInfo.Name = "labelInfo";
			labelInfo.Size = new Size(434, 222);
			labelInfo.TabIndex = 3;
			labelInfo.Text = resources.GetString("labelInfo.Text");
			// 
			// DatabaseSetupForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(486, 315);
			Controls.Add(labelInfo);
			Controls.Add(buttonSetLocation);
			Controls.Add(buttonGetDataFolder);
			Controls.Add(textDatabase);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "DatabaseSetupForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Database Setup";
			Load += DatabaseSetupForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FolderBrowserDialog folderBrowserData;
		private TextBox textDatabase;
		private Button buttonGetDataFolder;
		private Button buttonSetLocation;
		private Label labelInfo;
	}
}