using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
	partial class ManageUsersForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			labelHeader = new Label();
			panelMain = new Panel();
			labelBooksCount = new Label();
			buttonShowAuthorBooks = new Button();
			dgUsers = new DataGridView();
			textPassword = new TextBox();
			labelPassword = new Label();
			textUsername = new TextBox();
			labelUsername = new Label();
			label8 = new Label();
			textEmail = new TextBox();
			labelEmail = new Label();
			label7 = new Label();
			textDOB = new TextBox();
			labelDOB = new Label();
			label6 = new Label();
			label5 = new Label();
			textPhone = new TextBox();
			labelPhone = new Label();
			label4 = new Label();
			textUserNumber = new TextBox();
			labelUserNumber = new Label();
			labelRole = new Label();
			comboRole = new ComboBox();
			labelState = new Label();
			comboState = new ComboBox();
			textZip = new TextBox();
			labelZip = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			buttonClearSearch = new Button();
			picSearchIcon = new PictureBox();
			textSearch = new TextBox();
			textCity = new TextBox();
			labelCity = new Label();
			textAddress2 = new TextBox();
			labelAddress2 = new Label();
			textAddress1 = new TextBox();
			labelAddress1 = new Label();
			textLastName = new TextBox();
			labelLastName = new Label();
			textFirstName = new TextBox();
			textId = new TextBox();
			labelFirstName = new Label();
			labelId = new Label();
			panelHeader = new Panel();
			labelStatus = new Label();
			picHeaderLogo = new PictureBox();
			buttonClose = new Button();
			panelSidebar = new Panel();
			labelUsersCount = new Label();
			buttonDelete = new Button();
			buttonUpdate = new Button();
			buttonAdd = new Button();
			toolTip1 = new ToolTip(components);
			panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
			((System.ComponentModel.ISupportInitialize)picSearchIcon).BeginInit();
			panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picHeaderLogo).BeginInit();
			panelSidebar.SuspendLayout();
			SuspendLayout();
			// 
			// labelHeader
			// 
			labelHeader.BackColor = Color.DarkBlue;
			labelHeader.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelHeader.ForeColor = Color.Silver;
			labelHeader.ImageAlign = ContentAlignment.MiddleLeft;
			labelHeader.Location = new Point(72, 6);
			labelHeader.Name = "labelHeader";
			labelHeader.Size = new Size(233, 60);
			labelHeader.TabIndex = 9;
			labelHeader.Text = "Users";
			labelHeader.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panelMain
			// 
			panelMain.BackColor = Color.Silver;
			panelMain.Controls.Add(labelBooksCount);
			panelMain.Controls.Add(buttonShowAuthorBooks);
			panelMain.Controls.Add(dgUsers);
			panelMain.Controls.Add(textPassword);
			panelMain.Controls.Add(labelPassword);
			panelMain.Controls.Add(textUsername);
			panelMain.Controls.Add(labelUsername);
			panelMain.Controls.Add(label8);
			panelMain.Controls.Add(textEmail);
			panelMain.Controls.Add(labelEmail);
			panelMain.Controls.Add(label7);
			panelMain.Controls.Add(textDOB);
			panelMain.Controls.Add(labelDOB);
			panelMain.Controls.Add(label6);
			panelMain.Controls.Add(label5);
			panelMain.Controls.Add(textPhone);
			panelMain.Controls.Add(labelPhone);
			panelMain.Controls.Add(label4);
			panelMain.Controls.Add(textUserNumber);
			panelMain.Controls.Add(labelUserNumber);
			panelMain.Controls.Add(labelRole);
			panelMain.Controls.Add(comboRole);
			panelMain.Controls.Add(labelState);
			panelMain.Controls.Add(comboState);
			panelMain.Controls.Add(textZip);
			panelMain.Controls.Add(labelZip);
			panelMain.Controls.Add(label3);
			panelMain.Controls.Add(label2);
			panelMain.Controls.Add(label1);
			panelMain.Controls.Add(buttonClearSearch);
			panelMain.Controls.Add(picSearchIcon);
			panelMain.Controls.Add(textSearch);
			panelMain.Controls.Add(textCity);
			panelMain.Controls.Add(labelCity);
			panelMain.Controls.Add(textAddress2);
			panelMain.Controls.Add(labelAddress2);
			panelMain.Controls.Add(textAddress1);
			panelMain.Controls.Add(labelAddress1);
			panelMain.Controls.Add(textLastName);
			panelMain.Controls.Add(labelLastName);
			panelMain.Controls.Add(textFirstName);
			panelMain.Controls.Add(textId);
			panelMain.Controls.Add(labelFirstName);
			panelMain.Controls.Add(labelId);
			panelMain.Location = new Point(159, 78);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(790, 569);
			panelMain.TabIndex = 4;
			// 
			// labelBooksCount
			// 
			labelBooksCount.BackColor = Color.Silver;
			labelBooksCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelBooksCount.ForeColor = Color.DarkBlue;
			labelBooksCount.Location = new Point(583, 65);
			labelBooksCount.Name = "labelBooksCount";
			labelBooksCount.Size = new Size(162, 21);
			labelBooksCount.TabIndex = 40;
			labelBooksCount.Text = "books";
			// 
			// buttonShowAuthorBooks
			// 
			buttonShowAuthorBooks.BackColor = Color.Silver;
			buttonShowAuthorBooks.BackgroundImageLayout = ImageLayout.None;
			buttonShowAuthorBooks.Cursor = Cursors.Hand;
			buttonShowAuthorBooks.FlatAppearance.BorderSize = 0;
			buttonShowAuthorBooks.FlatStyle = FlatStyle.Flat;
			buttonShowAuthorBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonShowAuthorBooks.ForeColor = Color.DarkBlue;
			buttonShowAuthorBooks.Image = (Image)resources.GetObject("buttonShowAuthorBooks.Image");
			buttonShowAuthorBooks.ImageAlign = ContentAlignment.MiddleLeft;
			buttonShowAuthorBooks.Location = new Point(578, 101);
			buttonShowAuthorBooks.Name = "buttonShowAuthorBooks";
			buttonShowAuthorBooks.Size = new Size(167, 53);
			buttonShowAuthorBooks.TabIndex = 41;
			buttonShowAuthorBooks.Text = "View Books";
			buttonShowAuthorBooks.TextAlign = ContentAlignment.MiddleRight;
			buttonShowAuthorBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonShowAuthorBooks.UseVisualStyleBackColor = false;
			buttonShowAuthorBooks.Click += buttonShowAuthorBooks_Click;
			// 
			// dgUsers
			// 
			dgUsers.AllowUserToAddRows = false;
			dgUsers.AllowUserToDeleteRows = false;
			dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgUsers.BackgroundColor = Color.Silver;
			dgUsers.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = Color.DarkBlue;
			dataGridViewCellStyle16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle16.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
			dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgUsers.Location = new Point(34, 55);
			dgUsers.MultiSelect = false;
			dgUsers.Name = "dgUsers";
			dgUsers.ReadOnly = true;
			dgUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = Color.DarkBlue;
			dataGridViewCellStyle17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle17.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
			dgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
			dgUsers.RowHeadersVisible = false;
			dataGridViewCellStyle18.BackColor = Color.Silver;
			dataGridViewCellStyle18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle18.ForeColor = Color.Black;
			dataGridViewCellStyle18.SelectionBackColor = Color.RoyalBlue;
			dgUsers.RowsDefaultCellStyle = dataGridViewCellStyle18;
			dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgUsers.ShowEditingIcon = false;
			dgUsers.Size = new Size(524, 225);
			dgUsers.TabIndex = 106;
			dgUsers.TabStop = false;
			// 
			// textPassword
			// 
			textPassword.Font = new Font("Segoe UI", 12F);
			textPassword.Location = new Point(502, 494);
			textPassword.MaxLength = 100;
			textPassword.Name = "textPassword";
			textPassword.PasswordChar = '*';
			textPassword.Size = new Size(243, 29);
			textPassword.TabIndex = 34;
			// 
			// labelPassword
			// 
			labelPassword.AutoSize = true;
			labelPassword.Font = new Font("Segoe UI", 12F);
			labelPassword.Location = new Point(416, 497);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new Size(79, 21);
			labelPassword.TabIndex = 33;
			labelPassword.Text = "Password:";
			// 
			// textUsername
			// 
			textUsername.Font = new Font("Segoe UI", 12F);
			textUsername.Location = new Point(502, 462);
			textUsername.MaxLength = 100;
			textUsername.Name = "textUsername";
			textUsername.Size = new Size(243, 29);
			textUsername.TabIndex = 32;
			// 
			// labelUsername
			// 
			labelUsername.AutoSize = true;
			labelUsername.Font = new Font("Segoe UI", 12F);
			labelUsername.Location = new Point(411, 465);
			labelUsername.Name = "labelUsername";
			labelUsername.Size = new Size(84, 21);
			labelUsername.TabIndex = 31;
			labelUsername.Text = "Username:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.White;
			label8.Font = new Font("Segoe UI", 12F);
			label8.ForeColor = Color.DarkBlue;
			label8.Location = new Point(727, 336);
			label8.Name = "label8";
			label8.Size = new Size(17, 21);
			label8.TabIndex = 22;
			label8.Text = "*";
			// 
			// textEmail
			// 
			textEmail.Font = new Font("Segoe UI", 12F);
			textEmail.Location = new Point(502, 334);
			textEmail.MaxLength = 100;
			textEmail.Name = "textEmail";
			textEmail.Size = new Size(243, 29);
			textEmail.TabIndex = 21;
			// 
			// labelEmail
			// 
			labelEmail.AutoSize = true;
			labelEmail.Font = new Font("Segoe UI", 12F);
			labelEmail.Location = new Point(444, 337);
			labelEmail.Name = "labelEmail";
			labelEmail.Size = new Size(51, 21);
			labelEmail.TabIndex = 20;
			labelEmail.Text = "Email:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.White;
			label7.Font = new Font("Segoe UI", 12F);
			label7.ForeColor = Color.DarkBlue;
			label7.Location = new Point(727, 368);
			label7.Name = "label7";
			label7.Size = new Size(17, 21);
			label7.TabIndex = 1246;
			label7.Text = "*";
			// 
			// textDOB
			// 
			textDOB.Font = new Font("Segoe UI", 12F);
			textDOB.Location = new Point(502, 366);
			textDOB.Name = "textDOB";
			textDOB.Size = new Size(243, 29);
			textDOB.TabIndex = 23;
			textDOB.Text = "yyyy-mm-dd";
			// 
			// labelDOB
			// 
			labelDOB.AutoSize = true;
			labelDOB.Font = new Font("Segoe UI", 12F);
			labelDOB.Location = new Point(450, 369);
			labelDOB.Name = "labelDOB";
			labelDOB.Size = new Size(45, 21);
			labelDOB.TabIndex = 14;
			labelDOB.Text = "DOB:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Silver;
			label6.Font = new Font("Segoe UI", 12F);
			label6.ForeColor = Color.DarkBlue;
			label6.Location = new Point(746, 428);
			label6.Margin = new Padding(0, 0, 3, 0);
			label6.Name = "label6";
			label6.Size = new Size(17, 21);
			label6.TabIndex = 30;
			label6.Text = "*";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.White;
			label5.Font = new Font("Segoe UI", 12F);
			label5.ForeColor = Color.DarkBlue;
			label5.Location = new Point(727, 401);
			label5.Name = "label5";
			label5.Size = new Size(17, 21);
			label5.TabIndex = 27;
			label5.Text = "*";
			// 
			// textPhone
			// 
			textPhone.Font = new Font("Segoe UI", 12F);
			textPhone.Location = new Point(502, 398);
			textPhone.MaxLength = 100;
			textPhone.Name = "textPhone";
			textPhone.Size = new Size(243, 29);
			textPhone.TabIndex = 26;
			textPhone.Text = "xxx-xxx-xxxx";
			// 
			// labelPhone
			// 
			labelPhone.AutoSize = true;
			labelPhone.Font = new Font("Segoe UI", 12F);
			labelPhone.Location = new Point(425, 401);
			labelPhone.Name = "labelPhone";
			labelPhone.Size = new Size(70, 21);
			labelPhone.TabIndex = 25;
			labelPhone.Text = "Phone #:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.White;
			label4.Font = new Font("Segoe UI", 12F);
			label4.ForeColor = Color.DarkBlue;
			label4.Location = new Point(727, 303);
			label4.Name = "label4";
			label4.Size = new Size(17, 21);
			label4.TabIndex = 19;
			label4.Text = "*";
			// 
			// textUserNumber
			// 
			textUserNumber.Font = new Font("Segoe UI", 12F);
			textUserNumber.Location = new Point(502, 301);
			textUserNumber.MaxLength = 100;
			textUserNumber.Name = "textUserNumber";
			textUserNumber.Size = new Size(243, 29);
			textUserNumber.TabIndex = 18;
			// 
			// labelUserNumber
			// 
			labelUserNumber.AutoSize = true;
			labelUserNumber.Font = new Font("Segoe UI", 12F);
			labelUserNumber.Location = new Point(387, 309);
			labelUserNumber.Name = "labelUserNumber";
			labelUserNumber.Size = new Size(108, 21);
			labelUserNumber.TabIndex = 17;
			labelUserNumber.Text = "Card Number:";
			// 
			// labelRole
			// 
			labelRole.AutoSize = true;
			labelRole.Font = new Font("Segoe UI", 12F);
			labelRole.Location = new Point(451, 433);
			labelRole.Name = "labelRole";
			labelRole.Size = new Size(44, 21);
			labelRole.TabIndex = 29;
			labelRole.Text = "Role:";
			// 
			// comboRole
			// 
			comboRole.Font = new Font("Segoe UI", 12F);
			comboRole.FormattingEnabled = true;
			comboRole.ItemHeight = 21;
			comboRole.Location = new Point(502, 430);
			comboRole.Name = "comboRole";
			comboRole.Size = new Size(242, 29);
			comboRole.TabIndex = 32;
			// 
			// labelState
			// 
			labelState.AutoSize = true;
			labelState.Font = new Font("Segoe UI", 12F);
			labelState.Location = new Point(61, 496);
			labelState.Name = "labelState";
			labelState.Size = new Size(47, 21);
			labelState.TabIndex = 13;
			labelState.Text = "State:";
			// 
			// comboState
			// 
			comboState.Font = new Font("Segoe UI", 12F);
			comboState.FormattingEnabled = true;
			comboState.Location = new Point(120, 493);
			comboState.Name = "comboState";
			comboState.Size = new Size(244, 29);
			comboState.TabIndex = 14;
			// 
			// textZip
			// 
			textZip.Font = new Font("Segoe UI", 12F);
			textZip.Location = new Point(120, 525);
			textZip.MaxLength = 100;
			textZip.Name = "textZip";
			textZip.Size = new Size(244, 29);
			textZip.TabIndex = 16;
			// 
			// labelZip
			// 
			labelZip.AutoSize = true;
			labelZip.Font = new Font("Segoe UI", 12F);
			labelZip.Location = new Point(35, 528);
			labelZip.Name = "labelZip";
			labelZip.Size = new Size(75, 21);
			labelZip.TabIndex = 15;
			labelZip.Text = "Zip Code:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Silver;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DarkBlue;
			label3.Location = new Point(666, 534);
			label3.Name = "label3";
			label3.Size = new Size(79, 20);
			label3.TabIndex = 37;
			label3.Text = "* Required";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.White;
			label2.Font = new Font("Segoe UI", 12F);
			label2.ForeColor = Color.DarkBlue;
			label2.Location = new Point(345, 369);
			label2.Name = "label2";
			label2.Size = new Size(17, 21);
			label2.TabIndex = 6;
			label2.Text = "*";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.White;
			label1.Font = new Font("Segoe UI", 12F);
			label1.ForeColor = Color.DarkBlue;
			label1.Location = new Point(345, 334);
			label1.Name = "label1";
			label1.Size = new Size(17, 21);
			label1.TabIndex = 4;
			label1.Text = "*";
			// 
			// buttonClearSearch
			// 
			buttonClearSearch.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearSearch.Image = (Image)resources.GetObject("buttonClearSearch.Image");
			buttonClearSearch.Location = new Point(523, 11);
			buttonClearSearch.Name = "buttonClearSearch";
			buttonClearSearch.Size = new Size(35, 35);
			buttonClearSearch.TabIndex = 39;
			buttonClearSearch.UseVisualStyleBackColor = true;
			buttonClearSearch.Click += buttonClearSearch_Click;
			// 
			// picSearchIcon
			// 
			picSearchIcon.Image = (Image)resources.GetObject("picSearchIcon.Image");
			picSearchIcon.Location = new Point(34, 13);
			picSearchIcon.Name = "picSearchIcon";
			picSearchIcon.Size = new Size(35, 35);
			picSearchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
			picSearchIcon.TabIndex = 23;
			picSearchIcon.TabStop = false;
			// 
			// textSearch
			// 
			textSearch.Font = new Font("Segoe UI", 14.25F);
			textSearch.Location = new Point(75, 13);
			textSearch.MaxLength = 100;
			textSearch.Name = "textSearch";
			textSearch.Size = new Size(442, 33);
			textSearch.TabIndex = 38;
			textSearch.TextChanged += textSearch_TextChanged;
			// 
			// textCity
			// 
			textCity.Font = new Font("Segoe UI", 12F);
			textCity.Location = new Point(120, 461);
			textCity.MaxLength = 100;
			textCity.Name = "textCity";
			textCity.Size = new Size(244, 29);
			textCity.TabIndex = 12;
			// 
			// labelCity
			// 
			labelCity.AutoSize = true;
			labelCity.Font = new Font("Segoe UI", 12F);
			labelCity.Location = new Point(68, 463);
			labelCity.Name = "labelCity";
			labelCity.Size = new Size(40, 21);
			labelCity.TabIndex = 11;
			labelCity.Text = "City:";
			// 
			// textAddress2
			// 
			textAddress2.Font = new Font("Segoe UI", 12F);
			textAddress2.Location = new Point(120, 429);
			textAddress2.Name = "textAddress2";
			textAddress2.Size = new Size(244, 29);
			textAddress2.TabIndex = 10;
			// 
			// labelAddress2
			// 
			labelAddress2.AutoSize = true;
			labelAddress2.Font = new Font("Segoe UI", 12F);
			labelAddress2.Location = new Point(32, 432);
			labelAddress2.Name = "labelAddress2";
			labelAddress2.Size = new Size(78, 21);
			labelAddress2.TabIndex = 9;
			labelAddress2.Text = "Address2:";
			// 
			// textAddress1
			// 
			textAddress1.Font = new Font("Segoe UI", 12F);
			textAddress1.Location = new Point(120, 397);
			textAddress1.Name = "textAddress1";
			textAddress1.Size = new Size(244, 29);
			textAddress1.TabIndex = 8;
			// 
			// labelAddress1
			// 
			labelAddress1.AutoSize = true;
			labelAddress1.Font = new Font("Segoe UI", 12F);
			labelAddress1.Location = new Point(32, 400);
			labelAddress1.Name = "labelAddress1";
			labelAddress1.Size = new Size(78, 21);
			labelAddress1.TabIndex = 7;
			labelAddress1.Text = "Address1:";
			// 
			// textLastName
			// 
			textLastName.Font = new Font("Segoe UI", 12F);
			textLastName.Location = new Point(120, 365);
			textLastName.MaxLength = 100;
			textLastName.Name = "textLastName";
			textLastName.Size = new Size(244, 29);
			textLastName.TabIndex = 5;
			// 
			// labelLastName
			// 
			labelLastName.AutoSize = true;
			labelLastName.Font = new Font("Segoe UI", 12F);
			labelLastName.Location = new Point(21, 368);
			labelLastName.Name = "labelLastName";
			labelLastName.Size = new Size(87, 21);
			labelLastName.TabIndex = 4;
			labelLastName.Text = "Last Name:";
			// 
			// textFirstName
			// 
			textFirstName.Font = new Font("Segoe UI", 12F);
			textFirstName.Location = new Point(120, 333);
			textFirstName.MaxLength = 100;
			textFirstName.Name = "textFirstName";
			textFirstName.Size = new Size(244, 29);
			textFirstName.TabIndex = 3;
			// 
			// textId
			// 
			textId.Enabled = false;
			textId.Font = new Font("Segoe UI", 12F);
			textId.Location = new Point(120, 301);
			textId.MaxLength = 100;
			textId.Name = "textId";
			textId.Size = new Size(244, 29);
			textId.TabIndex = 1;
			// 
			// labelFirstName
			// 
			labelFirstName.AutoSize = true;
			labelFirstName.Font = new Font("Segoe UI", 12F);
			labelFirstName.Location = new Point(21, 337);
			labelFirstName.Name = "labelFirstName";
			labelFirstName.Size = new Size(89, 21);
			labelFirstName.TabIndex = 2;
			labelFirstName.Text = "First Name:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Font = new Font("Segoe UI", 12F);
			labelId.Location = new Point(82, 303);
			labelId.Name = "labelId";
			labelId.Size = new Size(28, 21);
			labelId.TabIndex = 0;
			labelId.Text = "ID:";
			// 
			// panelHeader
			// 
			panelHeader.BackColor = Color.DarkBlue;
			panelHeader.Controls.Add(labelStatus);
			panelHeader.Controls.Add(picHeaderLogo);
			panelHeader.Controls.Add(buttonClose);
			panelHeader.Controls.Add(labelHeader);
			panelHeader.Location = new Point(4, 3);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(945, 70);
			panelHeader.TabIndex = 5;
			// 
			// labelStatus
			// 
			labelStatus.BackColor = Color.DarkBlue;
			labelStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelStatus.ForeColor = Color.Gold;
			labelStatus.Location = new Point(298, 34);
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(537, 21);
			labelStatus.TabIndex = 12;
			labelStatus.Text = "status";
			// 
			// picHeaderLogo
			// 
			picHeaderLogo.BackColor = Color.Transparent;
			picHeaderLogo.ErrorImage = null;
			picHeaderLogo.Image = (Image)resources.GetObject("picHeaderLogo.Image");
			picHeaderLogo.Location = new Point(7, 7);
			picHeaderLogo.Name = "picHeaderLogo";
			picHeaderLogo.Size = new Size(67, 59);
			picHeaderLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			picHeaderLogo.TabIndex = 11;
			picHeaderLogo.TabStop = false;
			// 
			// buttonClose
			// 
			buttonClose.BackColor = Color.DarkBlue;
			buttonClose.Cursor = Cursors.Hand;
			buttonClose.FlatAppearance.BorderSize = 0;
			buttonClose.FlatStyle = FlatStyle.Flat;
			buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
			buttonClose.Location = new Point(903, 6);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(34, 32);
			buttonClose.TabIndex = 10;
			buttonClose.UseVisualStyleBackColor = false;
			buttonClose.Click += buttonClose_Click;
			// 
			// panelSidebar
			// 
			panelSidebar.Controls.Add(labelUsersCount);
			panelSidebar.Controls.Add(buttonDelete);
			panelSidebar.Controls.Add(buttonUpdate);
			panelSidebar.Controls.Add(buttonAdd);
			panelSidebar.Location = new Point(4, 75);
			panelSidebar.Name = "panelSidebar";
			panelSidebar.Size = new Size(149, 424);
			panelSidebar.TabIndex = 6;
			// 
			// labelUsersCount
			// 
			labelUsersCount.BackColor = Color.FromArgb(17, 24, 34);
			labelUsersCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelUsersCount.ForeColor = Color.Gold;
			labelUsersCount.Location = new Point(12, 30);
			labelUsersCount.Name = "labelUsersCount";
			labelUsersCount.Size = new Size(125, 21);
			labelUsersCount.TabIndex = 42;
			labelUsersCount.Text = "users";
			labelUsersCount.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.LightCoral;
			buttonDelete.BackgroundImageLayout = ImageLayout.None;
			buttonDelete.Cursor = Cursors.Hand;
			buttonDelete.FlatStyle = FlatStyle.Popup;
			buttonDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonDelete.ForeColor = Color.DarkBlue;
			buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
			buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
			buttonDelete.Location = new Point(12, 229);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(125, 53);
			buttonDelete.TabIndex = 45;
			buttonDelete.TabStop = false;
			buttonDelete.Text = "Delete";
			buttonDelete.TextAlign = ContentAlignment.MiddleRight;
			buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonDelete, "Delete the currently selected user");
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonUpdate
			// 
			buttonUpdate.BackColor = Color.SteelBlue;
			buttonUpdate.BackgroundImageLayout = ImageLayout.None;
			buttonUpdate.Cursor = Cursors.Hand;
			buttonUpdate.FlatStyle = FlatStyle.Popup;
			buttonUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonUpdate.ForeColor = Color.DarkBlue;
			buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
			buttonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
			buttonUpdate.Location = new Point(12, 155);
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.Size = new Size(125, 53);
			buttonUpdate.TabIndex = 44;
			buttonUpdate.TabStop = false;
			buttonUpdate.Text = "Update";
			buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
			buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonUpdate, "Update the currently selected user's information");
			buttonUpdate.UseVisualStyleBackColor = false;
			buttonUpdate.Click += buttonUpdate_Click;
			// 
			// buttonAdd
			// 
			buttonAdd.BackColor = Color.SteelBlue;
			buttonAdd.BackgroundImageLayout = ImageLayout.None;
			buttonAdd.Cursor = Cursors.Hand;
			buttonAdd.FlatStyle = FlatStyle.Popup;
			buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAdd.ForeColor = Color.DarkBlue;
			buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
			buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
			buttonAdd.Location = new Point(12, 81);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(125, 53);
			buttonAdd.TabIndex = 43;
			buttonAdd.TabStop = false;
			buttonAdd.Text = "Add";
			buttonAdd.TextAlign = ContentAlignment.MiddleRight;
			buttonAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonAdd, "Add the current form information as a new user");
			buttonAdd.UseVisualStyleBackColor = false;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// ManageUsersForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 24, 34);
			ClientSize = new Size(963, 659);
			Controls.Add(panelSidebar);
			Controls.Add(panelHeader);
			Controls.Add(panelMain);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageUsersForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageUsersForm";
			Load += ManageUsersForm_Load;
			panelMain.ResumeLayout(false);
			panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
			((System.ComponentModel.ISupportInitialize)picSearchIcon).EndInit();
			panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picHeaderLogo).EndInit();
			panelSidebar.ResumeLayout(false);
			ResumeLayout(false);
		}




		#endregion

		private Label labelHeader;
		private Panel panelMain;
		private TextBox textFirstName;
		private TextBox textId;
		private Label labelFirstName;
		private Label labelId;
		private Panel panelHeader;
		private PictureBox picHeaderLogo;
		private Button buttonClose;
		private Panel panelSidebar;
		private Button buttonDelete;
		private Button buttonUpdate;
		private Button buttonAdd;
		private TextBox textLastName;
		private Label labelLastName;
		private TextBox textCity;
		private Label labelCity;
		private TextBox textAddress2;
		private Label labelAddress2;
		private TextBox textAddress1;
		private Label labelAddress1;
		private TextBox textSearch;
		private PictureBox picSearchIcon;
		private Button buttonClearSearch;
		private Label labelStatus;
		private Label label1;
		private Label label2;
		private Label label3;
		private ToolTip toolTip1;
		private Label labelUsersCount;
		private TextBox textZip;
		private Label labelZip;
		private ComboBox comboState;
		private Label labelState;
		private Label labelRole;
		private ComboBox comboRole;
		private Label label4;
		private TextBox textUserNumber;
		private Label labelUserNumber;
		private TextBox textPhone;
		private Label labelPhone;
		private Label label5;
		private Label label6;
		private Label labelDOB;
		private TextBox textDOB;
		private Label label7;
		private Label label8;
		private TextBox textEmail;
		private Label labelEmail;
		private TextBox textPassword;
		private Label labelPassword;
		private TextBox textUsername;
		private Label labelUsername;
		private Label labelBooksCount;
		private Button buttonShowAuthorBooks;
		private DataGridView dgUsers;
	}
}