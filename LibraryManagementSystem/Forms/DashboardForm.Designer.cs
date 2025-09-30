namespace LibraryManagementSystem.Forms
{
	partial class DashboardForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
			panelSidebar = new Panel();
			buttonUsers = new Button();
			buttonCirculation = new Button();
			buttonGenres = new Button();
			buttonAuthors = new Button();
			buttonBooks = new Button();
			panelLogoHeader = new Panel();
			labelHeader = new Label();
			picLogo = new PictureBox();
			panelMain = new Panel();
			panelHeader = new Panel();
			labelHeaderName = new Label();
			buttonClose = new Button();
			panelLatest = new Panel();
			panelLatestBook5 = new Panel();
			label13 = new Label();
			panelLatestBook4 = new Panel();
			label12 = new Label();
			panelLatestBook3 = new Panel();
			label11 = new Label();
			panelLatestBook2 = new Panel();
			label10 = new Label();
			panelLatestBook1 = new Panel();
			label9 = new Label();
			label8 = new Label();
			panelMembersCount = new Panel();
			label6 = new Label();
			label7 = new Label();
			panelAuthorsCount = new Panel();
			labelAuthorCount = new Label();
			label5 = new Label();
			panelBooksCount = new Panel();
			labelBookCount = new Label();
			label2 = new Label();
			panelSidebar.SuspendLayout();
			panelLogoHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
			panelMain.SuspendLayout();
			panelHeader.SuspendLayout();
			panelLatest.SuspendLayout();
			panelLatestBook5.SuspendLayout();
			panelLatestBook4.SuspendLayout();
			panelLatestBook3.SuspendLayout();
			panelLatestBook2.SuspendLayout();
			panelLatestBook1.SuspendLayout();
			panelMembersCount.SuspendLayout();
			panelAuthorsCount.SuspendLayout();
			panelBooksCount.SuspendLayout();
			SuspendLayout();
			// 
			// panelSidebar
			// 
			panelSidebar.BackColor = Color.SteelBlue;
			panelSidebar.Controls.Add(buttonUsers);
			panelSidebar.Controls.Add(buttonCirculation);
			panelSidebar.Controls.Add(buttonGenres);
			panelSidebar.Controls.Add(buttonAuthors);
			panelSidebar.Controls.Add(buttonBooks);
			panelSidebar.Controls.Add(panelLogoHeader);
			panelSidebar.Dock = DockStyle.Left;
			panelSidebar.Location = new Point(0, 0);
			panelSidebar.Name = "panelSidebar";
			panelSidebar.Size = new Size(200, 584);
			panelSidebar.TabIndex = 0;
			// 
			// buttonUsers
			// 
			buttonUsers.BackColor = Color.DarkBlue;
			buttonUsers.Cursor = Cursors.Hand;
			buttonUsers.FlatAppearance.BorderSize = 0;
			buttonUsers.FlatStyle = FlatStyle.Flat;
			buttonUsers.Font = new Font("Segoe UI", 15F);
			buttonUsers.ForeColor = Color.White;
			buttonUsers.Image = (Image)resources.GetObject("buttonUsers.Image");
			buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
			buttonUsers.Location = new Point(3, 370);
			buttonUsers.Name = "buttonUsers";
			buttonUsers.Size = new Size(194, 47);
			buttonUsers.TabIndex = 7;
			buttonUsers.Text = "Users";
			buttonUsers.TextAlign = ContentAlignment.MiddleRight;
			buttonUsers.UseVisualStyleBackColor = false;
			buttonUsers.Click += buttonUsers_Click;
			// 
			// buttonCirculation
			// 
			buttonCirculation.BackColor = Color.DarkBlue;
			buttonCirculation.Cursor = Cursors.Hand;
			buttonCirculation.FlatAppearance.BorderSize = 0;
			buttonCirculation.FlatStyle = FlatStyle.Flat;
			buttonCirculation.Font = new Font("Segoe UI", 15F);
			buttonCirculation.ForeColor = Color.White;
			buttonCirculation.Image = (Image)resources.GetObject("buttonCirculation.Image");
			buttonCirculation.ImageAlign = ContentAlignment.MiddleLeft;
			buttonCirculation.Location = new Point(3, 310);
			buttonCirculation.Name = "buttonCirculation";
			buttonCirculation.RightToLeft = RightToLeft.No;
			buttonCirculation.Size = new Size(194, 47);
			buttonCirculation.TabIndex = 6;
			buttonCirculation.Text = "Circulation";
			buttonCirculation.TextAlign = ContentAlignment.MiddleRight;
			buttonCirculation.UseVisualStyleBackColor = false;
			buttonCirculation.Click += buttonCirculation_Click;
			// 
			// buttonGenres
			// 
			buttonGenres.BackColor = Color.DarkBlue;
			buttonGenres.Cursor = Cursors.Hand;
			buttonGenres.FlatAppearance.BorderSize = 0;
			buttonGenres.FlatStyle = FlatStyle.Flat;
			buttonGenres.Font = new Font("Segoe UI", 15F);
			buttonGenres.ForeColor = Color.White;
			buttonGenres.Image = (Image)resources.GetObject("buttonGenres.Image");
			buttonGenres.ImageAlign = ContentAlignment.MiddleLeft;
			buttonGenres.Location = new Point(3, 250);
			buttonGenres.Name = "buttonGenres";
			buttonGenres.Size = new Size(194, 47);
			buttonGenres.TabIndex = 5;
			buttonGenres.Text = "Genres";
			buttonGenres.TextAlign = ContentAlignment.MiddleRight;
			buttonGenres.UseVisualStyleBackColor = false;
			buttonGenres.Click += buttonGenres_Click;
			// 
			// buttonAuthors
			// 
			buttonAuthors.BackColor = Color.DarkBlue;
			buttonAuthors.Cursor = Cursors.Hand;
			buttonAuthors.FlatAppearance.BorderSize = 0;
			buttonAuthors.FlatStyle = FlatStyle.Flat;
			buttonAuthors.Font = new Font("Segoe UI", 15F);
			buttonAuthors.ForeColor = Color.White;
			buttonAuthors.Image = (Image)resources.GetObject("buttonAuthors.Image");
			buttonAuthors.ImageAlign = ContentAlignment.MiddleLeft;
			buttonAuthors.Location = new Point(3, 190);
			buttonAuthors.Name = "buttonAuthors";
			buttonAuthors.Size = new Size(194, 47);
			buttonAuthors.TabIndex = 4;
			buttonAuthors.Text = "Authors";
			buttonAuthors.TextAlign = ContentAlignment.MiddleRight;
			buttonAuthors.UseVisualStyleBackColor = false;
			buttonAuthors.Click += buttonAuthors_Click;
			// 
			// buttonBooks
			// 
			buttonBooks.BackColor = Color.DarkBlue;
			buttonBooks.Cursor = Cursors.Hand;
			buttonBooks.FlatAppearance.BorderSize = 0;
			buttonBooks.FlatStyle = FlatStyle.Flat;
			buttonBooks.Font = new Font("Segoe UI", 15F);
			buttonBooks.ForeColor = Color.White;
			buttonBooks.Image = (Image)resources.GetObject("buttonBooks.Image");
			buttonBooks.ImageAlign = ContentAlignment.MiddleLeft;
			buttonBooks.Location = new Point(3, 130);
			buttonBooks.Name = "buttonBooks";
			buttonBooks.Size = new Size(194, 47);
			buttonBooks.TabIndex = 3;
			buttonBooks.Text = "Books";
			buttonBooks.TextAlign = ContentAlignment.MiddleRight;
			buttonBooks.UseVisualStyleBackColor = false;
			buttonBooks.Click += buttonBooks_Click;
			// 
			// panelLogoHeader
			// 
			panelLogoHeader.BackColor = Color.DarkBlue;
			panelLogoHeader.Controls.Add(labelHeader);
			panelLogoHeader.Controls.Add(picLogo);
			panelLogoHeader.Dock = DockStyle.Top;
			panelLogoHeader.Location = new Point(0, 0);
			panelLogoHeader.Name = "panelLogoHeader";
			panelLogoHeader.Size = new Size(200, 93);
			panelLogoHeader.TabIndex = 2;
			// 
			// labelHeader
			// 
			labelHeader.AutoSize = true;
			labelHeader.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelHeader.ForeColor = Color.Gold;
			labelHeader.Location = new Point(79, 15);
			labelHeader.Name = "labelHeader";
			labelHeader.Size = new Size(112, 59);
			labelHeader.TabIndex = 3;
			labelHeader.Text = "LMS";
			// 
			// picLogo
			// 
			picLogo.Image = (Image)resources.GetObject("picLogo.Image");
			picLogo.InitialImage = null;
			picLogo.Location = new Point(9, 13);
			picLogo.Name = "picLogo";
			picLogo.Size = new Size(73, 67);
			picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			picLogo.TabIndex = 2;
			picLogo.TabStop = false;
			// 
			// panelMain
			// 
			panelMain.BackColor = Color.Silver;
			panelMain.Controls.Add(panelHeader);
			panelMain.Controls.Add(panelLatest);
			panelMain.Controls.Add(panelMembersCount);
			panelMain.Controls.Add(panelAuthorsCount);
			panelMain.Controls.Add(panelBooksCount);
			panelMain.Location = new Point(203, 6);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(937, 572);
			panelMain.TabIndex = 1;
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.DarkBlue;
			panelHeader.Controls.Add(labelHeaderName);
			panelHeader.Controls.Add(buttonClose);
			panelHeader.Location = new Point(3, 3);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(928, 50);
			panelHeader.TabIndex = 3;
			// 
			// labelHeaderName
			// 
			labelHeaderName.BackColor = Color.DarkBlue;
			labelHeaderName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelHeaderName.ForeColor = Color.White;
			labelHeaderName.Location = new Point(1, 2);
			labelHeaderName.Name = "labelHeaderName";
			labelHeaderName.Size = new Size(734, 40);
			labelHeaderName.TabIndex = 2;
			labelHeaderName.Text = "Name";
			labelHeaderName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// buttonClose
			// 
			buttonClose.BackColor = Color.DarkBlue;
			buttonClose.Cursor = Cursors.Hand;
			buttonClose.FlatAppearance.BorderSize = 0;
			buttonClose.FlatStyle = FlatStyle.Flat;
			buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
			buttonClose.Location = new Point(890, 4);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(32, 32);
			buttonClose.TabIndex = 1;
			buttonClose.UseVisualStyleBackColor = false;
			buttonClose.Click += buttonClose_Click;
			// 
			// panelLatest
			// 
			panelLatest.BackColor = Color.MediumBlue;
			panelLatest.Controls.Add(panelLatestBook5);
			panelLatest.Controls.Add(panelLatestBook4);
			panelLatest.Controls.Add(panelLatestBook3);
			panelLatest.Controls.Add(panelLatestBook2);
			panelLatest.Controls.Add(panelLatestBook1);
			panelLatest.Controls.Add(label8);
			panelLatest.Location = new Point(20, 241);
			panelLatest.Name = "panelLatest";
			panelLatest.Size = new Size(898, 309);
			panelLatest.TabIndex = 2;
			// 
			// panelLatestBook5
			// 
			panelLatestBook5.BackColor = Color.RoyalBlue;
			panelLatestBook5.Controls.Add(label13);
			panelLatestBook5.Location = new Point(719, 66);
			panelLatestBook5.Name = "panelLatestBook5";
			panelLatestBook5.Size = new Size(162, 225);
			panelLatestBook5.TabIndex = 4;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.BackColor = Color.FromArgb(255, 128, 0);
			label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label13.ForeColor = Color.White;
			label13.Location = new Point(126, 0);
			label13.Name = "label13";
			label13.Size = new Size(36, 17);
			label13.TabIndex = 1;
			label13.Text = "$999";
			// 
			// panelLatestBook4
			// 
			panelLatestBook4.BackColor = Color.RoyalBlue;
			panelLatestBook4.Controls.Add(label12);
			panelLatestBook4.Location = new Point(543, 66);
			panelLatestBook4.Name = "panelLatestBook4";
			panelLatestBook4.Size = new Size(162, 225);
			panelLatestBook4.TabIndex = 3;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = Color.FromArgb(255, 128, 0);
			label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label12.ForeColor = Color.White;
			label12.Location = new Point(126, 0);
			label12.Name = "label12";
			label12.Size = new Size(36, 17);
			label12.TabIndex = 1;
			label12.Text = "$999";
			// 
			// panelLatestBook3
			// 
			panelLatestBook3.BackColor = Color.RoyalBlue;
			panelLatestBook3.Controls.Add(label11);
			panelLatestBook3.Location = new Point(367, 66);
			panelLatestBook3.Name = "panelLatestBook3";
			panelLatestBook3.Size = new Size(162, 225);
			panelLatestBook3.TabIndex = 3;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = Color.FromArgb(255, 128, 0);
			label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.White;
			label11.Location = new Point(126, 0);
			label11.Name = "label11";
			label11.Size = new Size(36, 17);
			label11.TabIndex = 1;
			label11.Text = "$999";
			// 
			// panelLatestBook2
			// 
			panelLatestBook2.BackColor = Color.RoyalBlue;
			panelLatestBook2.Controls.Add(label10);
			panelLatestBook2.Location = new Point(191, 66);
			panelLatestBook2.Name = "panelLatestBook2";
			panelLatestBook2.Size = new Size(162, 225);
			panelLatestBook2.TabIndex = 3;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.FromArgb(255, 128, 0);
			label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.White;
			label10.Location = new Point(126, 0);
			label10.Name = "label10";
			label10.Size = new Size(36, 17);
			label10.TabIndex = 1;
			label10.Text = "$999";
			// 
			// panelLatestBook1
			// 
			panelLatestBook1.BackColor = Color.RoyalBlue;
			panelLatestBook1.Controls.Add(label9);
			panelLatestBook1.Location = new Point(15, 66);
			panelLatestBook1.Name = "panelLatestBook1";
			panelLatestBook1.Size = new Size(162, 225);
			panelLatestBook1.TabIndex = 2;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.FromArgb(255, 128, 0);
			label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.ForeColor = Color.White;
			label9.Location = new Point(126, 0);
			label9.Name = "label9";
			label9.Size = new Size(36, 17);
			label9.TabIndex = 0;
			label9.Text = "$999";
			// 
			// label8
			// 
			label8.BackColor = Color.DarkBlue;
			label8.Dock = DockStyle.Top;
			label8.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.White;
			label8.Location = new Point(0, 0);
			label8.Name = "label8";
			label8.Size = new Size(898, 49);
			label8.TabIndex = 1;
			label8.Text = "Latest Books";
			label8.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panelMembersCount
			// 
			panelMembersCount.BackColor = Color.DodgerBlue;
			panelMembersCount.Controls.Add(label6);
			panelMembersCount.Controls.Add(label7);
			panelMembersCount.Location = new Point(648, 59);
			panelMembersCount.Name = "panelMembersCount";
			panelMembersCount.Size = new Size(270, 152);
			panelMembersCount.TabIndex = 2;
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(-3, 60);
			label6.Name = "label6";
			label6.Size = new Size(270, 49);
			label6.TabIndex = 3;
			label6.Text = "999";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.BackColor = Color.DarkBlue;
			label7.Dock = DockStyle.Top;
			label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.White;
			label7.Location = new Point(0, 0);
			label7.Name = "label7";
			label7.Size = new Size(270, 49);
			label7.TabIndex = 2;
			label7.Text = "Members";
			label7.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panelAuthorsCount
			// 
			panelAuthorsCount.BackColor = Color.RoyalBlue;
			panelAuthorsCount.Controls.Add(labelAuthorCount);
			panelAuthorsCount.Controls.Add(label5);
			panelAuthorsCount.Location = new Point(334, 59);
			panelAuthorsCount.Name = "panelAuthorsCount";
			panelAuthorsCount.Size = new Size(270, 152);
			panelAuthorsCount.TabIndex = 2;
			// 
			// labelAuthorCount
			// 
			labelAuthorCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelAuthorCount.ForeColor = Color.White;
			labelAuthorCount.Location = new Point(0, 60);
			labelAuthorCount.Name = "labelAuthorCount";
			labelAuthorCount.Size = new Size(270, 49);
			labelAuthorCount.TabIndex = 3;
			labelAuthorCount.Text = "999";
			labelAuthorCount.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.BackColor = Color.DarkBlue;
			label5.Dock = DockStyle.Top;
			label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.White;
			label5.Location = new Point(0, 0);
			label5.Name = "label5";
			label5.Size = new Size(270, 49);
			label5.TabIndex = 2;
			label5.Text = "Authors";
			label5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panelBooksCount
			// 
			panelBooksCount.BackColor = Color.MediumBlue;
			panelBooksCount.Controls.Add(labelBookCount);
			panelBooksCount.Controls.Add(label2);
			panelBooksCount.Location = new Point(20, 59);
			panelBooksCount.Name = "panelBooksCount";
			panelBooksCount.Size = new Size(270, 152);
			panelBooksCount.TabIndex = 1;
			// 
			// labelBookCount
			// 
			labelBookCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelBookCount.ForeColor = Color.White;
			labelBookCount.Location = new Point(0, 60);
			labelBookCount.Name = "labelBookCount";
			labelBookCount.Size = new Size(270, 49);
			labelBookCount.TabIndex = 1;
			labelBookCount.Text = "999";
			labelBookCount.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.BackColor = Color.DarkBlue;
			label2.Dock = DockStyle.Top;
			label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(270, 49);
			label2.TabIndex = 0;
			label2.Text = "Books";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// DashboardForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(46, 49, 49);
			ClientSize = new Size(1146, 584);
			Controls.Add(panelMain);
			Controls.Add(panelSidebar);
			FormBorderStyle = FormBorderStyle.None;
			Name = "DashboardForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DashboardForm";
			Load += DashboardForm_Load;
			Shown += DashboardForm_Shown;
			Enter += DashboardForm_Enter;
			panelSidebar.ResumeLayout(false);
			panelLogoHeader.ResumeLayout(false);
			panelLogoHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
			panelMain.ResumeLayout(false);
			panelHeader.ResumeLayout(false);
			panelLatest.ResumeLayout(false);
			panelLatestBook5.ResumeLayout(false);
			panelLatestBook5.PerformLayout();
			panelLatestBook4.ResumeLayout(false);
			panelLatestBook4.PerformLayout();
			panelLatestBook3.ResumeLayout(false);
			panelLatestBook3.PerformLayout();
			panelLatestBook2.ResumeLayout(false);
			panelLatestBook2.PerformLayout();
			panelLatestBook1.ResumeLayout(false);
			panelLatestBook1.PerformLayout();
			panelMembersCount.ResumeLayout(false);
			panelAuthorsCount.ResumeLayout(false);
			panelBooksCount.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelSidebar;
		private Panel panelLogoHeader;
		private Panel panelMain;
		private Panel panelBooksCount;
		private Panel panelMembersCount;
		private Panel panelAuthorsCount;
		private Panel panelLatest;
		private Label label2;
		private Label labelBookCount;
		private Label label6;
		private Label label7;
		private Label labelAuthorCount;
		private Label label5;
		private Label label8;
		private Panel panelLatestBook1;
		private Panel panelLatestBook4;
		private Panel panelLatestBook5;
		private Panel panelLatestBook3;
		private Panel panelLatestBook2;
		private Label label9;
		private Label label13;
		private Label label12;
		private Label label11;
		private Label label10;
		private Label labelHeader;
		private PictureBox picLogo;
		private Button buttonBooks;
		private Button buttonUsers;
		private Button buttonCirculation;
		private Button buttonGenres;
		private Button buttonAuthors;
		private Panel panelHeader;
		private Button buttonClose;
		private Label labelHeaderName;
	}
}