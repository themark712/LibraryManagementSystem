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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			labelHeader = new Label();
			panelMain = new Panel();
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
			labelBooksCount = new Label();
			buttonShowAuthorBooks = new Button();
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
			dgUsers = new DataGridView();
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
			((System.ComponentModel.ISupportInitialize)picSearchIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
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
			panelMain.Controls.Add(labelBooksCount);
			panelMain.Controls.Add(buttonShowAuthorBooks);
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
			panelMain.Controls.Add(dgUsers);
			panelMain.Controls.Add(textFirstName);
			panelMain.Controls.Add(textId);
			panelMain.Controls.Add(labelFirstName);
			panelMain.Controls.Add(labelId);
			panelMain.Location = new Point(159, 78);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(837, 542);
			panelMain.TabIndex = 4;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.White;
			label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.DarkBlue;
			label7.Location = new Point(367, 177);
			label7.Name = "label7";
			label7.Size = new Size(15, 20);
			label7.TabIndex = 43;
			label7.Text = "*";
			// 
			// textDOB
			// 
			textDOB.Font = new Font("Segoe UI", 14.25F);
			textDOB.Location = new Point(142, 175);
			textDOB.Name = "textDOB";
			textDOB.Size = new Size(243, 33);
			textDOB.TabIndex = 42;
			textDOB.Text = "yyyy-mm-dd";
			// 
			// labelDOB
			// 
			labelDOB.AutoSize = true;
			labelDOB.Font = new Font("Segoe UI", 14.25F);
			labelDOB.Location = new Point(84, 178);
			labelDOB.Name = "labelDOB";
			labelDOB.Size = new Size(54, 25);
			labelDOB.TabIndex = 41;
			labelDOB.Text = "DOB:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Silver;
			label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.DarkBlue;
			label6.Location = new Point(387, 448);
			label6.Margin = new Padding(0, 0, 3, 0);
			label6.Name = "label6";
			label6.Size = new Size(15, 20);
			label6.TabIndex = 40;
			label6.Text = "*";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.White;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.DarkBlue;
			label5.Location = new Point(367, 410);
			label5.Name = "label5";
			label5.Size = new Size(15, 20);
			label5.TabIndex = 39;
			label5.Text = "*";
			// 
			// textPhone
			// 
			textPhone.Font = new Font("Segoe UI", 14.25F);
			textPhone.Location = new Point(143, 409);
			textPhone.MaxLength = 100;
			textPhone.Name = "textPhone";
			textPhone.Size = new Size(243, 33);
			textPhone.TabIndex = 38;
			textPhone.Text = "xxx-xxx-xxxx";
			// 
			// labelPhone
			// 
			labelPhone.AutoSize = true;
			labelPhone.Font = new Font("Segoe UI", 14.25F);
			labelPhone.Location = new Point(52, 412);
			labelPhone.Name = "labelPhone";
			labelPhone.Size = new Size(86, 25);
			labelPhone.TabIndex = 37;
			labelPhone.Text = "Phone #:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.White;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.DarkBlue;
			label4.Location = new Point(367, 59);
			label4.Name = "label4";
			label4.Size = new Size(15, 20);
			label4.TabIndex = 36;
			label4.Text = "*";
			// 
			// textUserNumber
			// 
			textUserNumber.Font = new Font("Segoe UI", 14.25F);
			textUserNumber.Location = new Point(143, 57);
			textUserNumber.MaxLength = 100;
			textUserNumber.Name = "textUserNumber";
			textUserNumber.Size = new Size(243, 33);
			textUserNumber.TabIndex = 35;
			// 
			// labelUserNumber
			// 
			labelUserNumber.AutoSize = true;
			labelUserNumber.Font = new Font("Segoe UI", 14.25F);
			labelUserNumber.Location = new Point(8, 60);
			labelUserNumber.Name = "labelUserNumber";
			labelUserNumber.Size = new Size(130, 25);
			labelUserNumber.TabIndex = 34;
			labelUserNumber.Text = "Card Number:";
			// 
			// labelRole
			// 
			labelRole.AutoSize = true;
			labelRole.Font = new Font("Segoe UI", 14.25F);
			labelRole.Location = new Point(86, 451);
			labelRole.Name = "labelRole";
			labelRole.Size = new Size(52, 25);
			labelRole.TabIndex = 33;
			labelRole.Text = "Role:";
			// 
			// comboRole
			// 
			comboRole.Font = new Font("Segoe UI", 14.25F);
			comboRole.FormattingEnabled = true;
			comboRole.Location = new Point(143, 448);
			comboRole.Name = "comboRole";
			comboRole.Size = new Size(242, 33);
			comboRole.TabIndex = 32;
			// 
			// labelState
			// 
			labelState.AutoSize = true;
			labelState.Font = new Font("Segoe UI", 14.25F);
			labelState.Location = new Point(81, 334);
			labelState.Name = "labelState";
			labelState.Size = new Size(57, 25);
			labelState.TabIndex = 31;
			labelState.Text = "State:";
			// 
			// comboState
			// 
			comboState.Font = new Font("Segoe UI", 14.25F);
			comboState.FormattingEnabled = true;
			comboState.Location = new Point(143, 331);
			comboState.Name = "comboState";
			comboState.Size = new Size(242, 33);
			comboState.TabIndex = 30;
			// 
			// textZip
			// 
			textZip.Font = new Font("Segoe UI", 14.25F);
			textZip.Location = new Point(143, 370);
			textZip.MaxLength = 100;
			textZip.Name = "textZip";
			textZip.Size = new Size(243, 33);
			textZip.TabIndex = 29;
			// 
			// labelZip
			// 
			labelZip.AutoSize = true;
			labelZip.Font = new Font("Segoe UI", 14.25F);
			labelZip.Location = new Point(46, 373);
			labelZip.Name = "labelZip";
			labelZip.Size = new Size(92, 25);
			labelZip.TabIndex = 28;
			labelZip.Text = "Zip Code:";
			// 
			// labelBooksCount
			// 
			labelBooksCount.BackColor = Color.Silver;
			labelBooksCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelBooksCount.ForeColor = Color.DarkBlue;
			labelBooksCount.Location = new Point(595, 447);
			labelBooksCount.Name = "labelBooksCount";
			labelBooksCount.Size = new Size(175, 21);
			labelBooksCount.TabIndex = 27;
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
			buttonShowAuthorBooks.Location = new Point(409, 430);
			buttonShowAuthorBooks.Name = "buttonShowAuthorBooks";
			buttonShowAuthorBooks.Size = new Size(167, 53);
			buttonShowAuthorBooks.TabIndex = 20;
			buttonShowAuthorBooks.Text = "View Books";
			buttonShowAuthorBooks.TextAlign = ContentAlignment.MiddleRight;
			buttonShowAuthorBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonShowAuthorBooks.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Silver;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DarkBlue;
			label3.Location = new Point(143, 493);
			label3.Name = "label3";
			label3.Size = new Size(79, 20);
			label3.TabIndex = 16;
			label3.Text = "* Required";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.White;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DarkBlue;
			label2.Location = new Point(367, 137);
			label2.Name = "label2";
			label2.Size = new Size(15, 20);
			label2.TabIndex = 26;
			label2.Text = "*";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.White;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.DarkBlue;
			label1.Location = new Point(367, 98);
			label1.Name = "label1";
			label1.Size = new Size(15, 20);
			label1.TabIndex = 25;
			label1.Text = "*";
			// 
			// buttonClearSearch
			// 
			buttonClearSearch.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearSearch.Location = new Point(787, 18);
			buttonClearSearch.Name = "buttonClearSearch";
			buttonClearSearch.Size = new Size(35, 35);
			buttonClearSearch.TabIndex = 18;
			buttonClearSearch.UseVisualStyleBackColor = true;
			buttonClearSearch.Click += buttonClearSearch_Click;
			// 
			// picSearchIcon
			// 
			picSearchIcon.Image = (Image)resources.GetObject("picSearchIcon.Image");
			picSearchIcon.Location = new Point(405, 18);
			picSearchIcon.Name = "picSearchIcon";
			picSearchIcon.Size = new Size(35, 35);
			picSearchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
			picSearchIcon.TabIndex = 23;
			picSearchIcon.TabStop = false;
			// 
			// textSearch
			// 
			textSearch.Font = new Font("Segoe UI", 14.25F);
			textSearch.Location = new Point(446, 18);
			textSearch.MaxLength = 100;
			textSearch.Name = "textSearch";
			textSearch.Size = new Size(335, 33);
			textSearch.TabIndex = 17;
			textSearch.TextChanged += textSearch_TextChanged;
			// 
			// textCity
			// 
			textCity.Font = new Font("Segoe UI", 14.25F);
			textCity.Location = new Point(143, 292);
			textCity.MaxLength = 100;
			textCity.Name = "textCity";
			textCity.Size = new Size(243, 33);
			textCity.TabIndex = 11;
			// 
			// labelCity
			// 
			labelCity.AutoSize = true;
			labelCity.Font = new Font("Segoe UI", 14.25F);
			labelCity.Location = new Point(90, 295);
			labelCity.Name = "labelCity";
			labelCity.Size = new Size(48, 25);
			labelCity.TabIndex = 10;
			labelCity.Text = "City:";
			// 
			// textAddress2
			// 
			textAddress2.Font = new Font("Segoe UI", 14.25F);
			textAddress2.Location = new Point(143, 253);
			textAddress2.Name = "textAddress2";
			textAddress2.Size = new Size(243, 33);
			textAddress2.TabIndex = 9;
			// 
			// labelAddress2
			// 
			labelAddress2.AutoSize = true;
			labelAddress2.Font = new Font("Segoe UI", 14.25F);
			labelAddress2.Location = new Point(45, 256);
			labelAddress2.Name = "labelAddress2";
			labelAddress2.Size = new Size(93, 25);
			labelAddress2.TabIndex = 8;
			labelAddress2.Text = "Address2:";
			// 
			// textAddress1
			// 
			textAddress1.Font = new Font("Segoe UI", 14.25F);
			textAddress1.Location = new Point(143, 214);
			textAddress1.Name = "textAddress1";
			textAddress1.Size = new Size(243, 33);
			textAddress1.TabIndex = 7;
			// 
			// labelAddress1
			// 
			labelAddress1.AutoSize = true;
			labelAddress1.Font = new Font("Segoe UI", 14.25F);
			labelAddress1.Location = new Point(45, 217);
			labelAddress1.Name = "labelAddress1";
			labelAddress1.Size = new Size(93, 25);
			labelAddress1.TabIndex = 6;
			labelAddress1.Text = "Address1:";
			// 
			// textLastName
			// 
			textLastName.Font = new Font("Segoe UI", 14.25F);
			textLastName.Location = new Point(143, 135);
			textLastName.MaxLength = 100;
			textLastName.Name = "textLastName";
			textLastName.Size = new Size(243, 33);
			textLastName.TabIndex = 5;
			// 
			// labelLastName
			// 
			labelLastName.AutoSize = true;
			labelLastName.Font = new Font("Segoe UI", 14.25F);
			labelLastName.Location = new Point(34, 138);
			labelLastName.Name = "labelLastName";
			labelLastName.Size = new Size(104, 25);
			labelLastName.TabIndex = 4;
			labelLastName.Text = "Last Name:";
			// 
			// dgUsers
			// 
			dgUsers.AllowUserToAddRows = false;
			dgUsers.AllowUserToDeleteRows = false;
			dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgUsers.BackgroundColor = Color.Silver;
			dgUsers.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.DarkBlue;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgUsers.Location = new Point(405, 74);
			dgUsers.MultiSelect = false;
			dgUsers.Name = "dgUsers";
			dgUsers.ReadOnly = true;
			dgUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.DarkBlue;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgUsers.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.Silver;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
			dgUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgUsers.ShowEditingIcon = false;
			dgUsers.Size = new Size(417, 347);
			dgUsers.TabIndex = 19;
			dgUsers.CellClick += dgUsers_CellClick;
			// 
			// textFirstName
			// 
			textFirstName.Font = new Font("Segoe UI", 14.25F);
			textFirstName.Location = new Point(143, 96);
			textFirstName.MaxLength = 100;
			textFirstName.Name = "textFirstName";
			textFirstName.Size = new Size(243, 33);
			textFirstName.TabIndex = 3;
			// 
			// textId
			// 
			textId.Enabled = false;
			textId.Font = new Font("Segoe UI", 14.25F);
			textId.Location = new Point(143, 18);
			textId.MaxLength = 100;
			textId.Name = "textId";
			textId.Size = new Size(242, 33);
			textId.TabIndex = 1;
			// 
			// labelFirstName
			// 
			labelFirstName.AutoSize = true;
			labelFirstName.Font = new Font("Segoe UI", 14.25F);
			labelFirstName.Location = new Point(32, 99);
			labelFirstName.Name = "labelFirstName";
			labelFirstName.Size = new Size(106, 25);
			labelFirstName.TabIndex = 2;
			labelFirstName.Text = "First Name:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Font = new Font("Segoe UI", 14.25F);
			labelId.Location = new Point(104, 20);
			labelId.Name = "labelId";
			labelId.Size = new Size(34, 25);
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
			panelHeader.Size = new Size(992, 70);
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
			buttonClose.Location = new Point(957, 3);
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
			labelUsersCount.TabIndex = 25;
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
			buttonDelete.TabIndex = 23;
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
			buttonUpdate.TabIndex = 22;
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
			buttonAdd.TabIndex = 21;
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
			ClientSize = new Size(1004, 632);
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
			((System.ComponentModel.ISupportInitialize)picSearchIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
			panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picHeaderLogo).EndInit();
			panelSidebar.ResumeLayout(false);
			ResumeLayout(false);
		}




		#endregion

		private Label labelHeader;
		private Panel panelMain;
		private DataGridView dgUsers;
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
		private Button buttonShowAuthorBooks;
		private ToolTip toolTip1;
		private Label labelBooksCount;
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
	}
}