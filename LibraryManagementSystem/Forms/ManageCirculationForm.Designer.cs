using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
	partial class ManageCirculationForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCirculationForm));
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			labelHeader = new Label();
			panelMain = new Panel();
			dgCirculation = new DataGridView();
			dgBooks = new DataGridView();
			buttonShowAuthorBooks = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			buttonClearSearch = new Button();
			picSearchIcon = new PictureBox();
			textSearch = new TextBox();
			labelRenewals = new Label();
			textHometown = new TextBox();
			textDOD = new TextBox();
			textCardNumber = new TextBox();
			textRenewals = new TextBox();
			labelCheckoutDate = new Label();
			dgUsers = new DataGridView();
			textDueDate = new TextBox();
			textCheckOutDate = new TextBox();
			labelDueDate = new Label();
			panelHeader = new Panel();
			labelStatus = new Label();
			picHeaderLogo = new PictureBox();
			buttonClose = new Button();
			panelSidebar = new Panel();
			labelBooksCount = new Label();
			labelPhone = new Label();
			labelEmail = new Label();
			labelCardNumber = new Label();
			labelName = new Label();
			labelCheckOutCount = new Label();
			buttonDelete = new Button();
			buttonUpdate = new Button();
			buttonAdd = new Button();
			toolTip1 = new ToolTip(components);
			panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgCirculation).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgBooks).BeginInit();
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
			labelHeader.Text = "Circulation";
			labelHeader.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panelMain
			// 
			panelMain.BackColor = Color.Silver;
			panelMain.Controls.Add(dgCirculation);
			panelMain.Controls.Add(dgBooks);
			panelMain.Controls.Add(buttonShowAuthorBooks);
			panelMain.Controls.Add(label3);
			panelMain.Controls.Add(label2);
			panelMain.Controls.Add(label1);
			panelMain.Controls.Add(buttonClearSearch);
			panelMain.Controls.Add(picSearchIcon);
			panelMain.Controls.Add(textSearch);
			panelMain.Controls.Add(labelRenewals);
			panelMain.Controls.Add(textHometown);
			panelMain.Controls.Add(textDOD);
			panelMain.Controls.Add(textCardNumber);
			panelMain.Controls.Add(textRenewals);
			panelMain.Controls.Add(labelCheckoutDate);
			panelMain.Controls.Add(dgUsers);
			panelMain.Controls.Add(textDueDate);
			panelMain.Controls.Add(textCheckOutDate);
			panelMain.Controls.Add(labelDueDate);
			panelMain.Location = new Point(159, 78);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(813, 530);
			panelMain.TabIndex = 4;
			// 
			// dgCirculation
			// 
			dgCirculation.AllowUserToAddRows = false;
			dgCirculation.AllowUserToDeleteRows = false;
			dgCirculation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgCirculation.BackgroundColor = Color.Silver;
			dgCirculation.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.DarkBlue;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgCirculation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgCirculation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgCirculation.Location = new Point(20, 285);
			dgCirculation.MultiSelect = false;
			dgCirculation.Name = "dgCirculation";
			dgCirculation.ReadOnly = true;
			dgCirculation.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.DarkBlue;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgCirculation.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgCirculation.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.Silver;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
			dgCirculation.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dgCirculation.RowTemplate.Height = 20;
			dgCirculation.RowTemplate.ReadOnly = true;
			dgCirculation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgCirculation.ShowEditingIcon = false;
			dgCirculation.Size = new Size(311, 205);
			dgCirculation.TabIndex = 33;
			// 
			// dgBooks
			// 
			dgBooks.AllowUserToAddRows = false;
			dgBooks.AllowUserToDeleteRows = false;
			dgBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgBooks.BackgroundColor = Color.Silver;
			dgBooks.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.DarkBlue;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgBooks.Location = new Point(439, 70);
			dgBooks.MultiSelect = false;
			dgBooks.Name = "dgBooks";
			dgBooks.ReadOnly = true;
			dgBooks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.DarkBlue;
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dgBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dgBooks.RowHeadersVisible = false;
			dataGridViewCellStyle6.BackColor = Color.Silver;
			dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle6.ForeColor = Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = Color.RoyalBlue;
			dgBooks.RowsDefaultCellStyle = dataGridViewCellStyle6;
			dgBooks.RowTemplate.Height = 20;
			dgBooks.RowTemplate.ReadOnly = true;
			dgBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgBooks.ShowEditingIcon = false;
			dgBooks.Size = new Size(342, 205);
			dgBooks.TabIndex = 31;
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
			buttonShowAuthorBooks.Location = new Point(407, 455);
			buttonShowAuthorBooks.Name = "buttonShowAuthorBooks";
			buttonShowAuthorBooks.Size = new Size(125, 51);
			buttonShowAuthorBooks.TabIndex = 30;
			buttonShowAuthorBooks.Text = "View Books";
			buttonShowAuthorBooks.TextAlign = ContentAlignment.MiddleRight;
			buttonShowAuthorBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonShowAuthorBooks.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Silver;
			label3.Font = new Font("Segoe UI", 9.75F);
			label3.ForeColor = Color.DarkBlue;
			label3.Location = new Point(711, 509);
			label3.Name = "label3";
			label3.Size = new Size(70, 17);
			label3.TabIndex = 16;
			label3.Text = "* Required";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.White;
			label2.Font = new Font("Segoe UI", 9.75F);
			label2.ForeColor = Color.DarkBlue;
			label2.Location = new Point(673, 512);
			label2.Name = "label2";
			label2.Size = new Size(13, 17);
			label2.TabIndex = 26;
			label2.Text = "*";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.White;
			label1.Font = new Font("Segoe UI", 9.75F);
			label1.ForeColor = Color.DarkBlue;
			label1.Location = new Point(692, 509);
			label1.Name = "label1";
			label1.Size = new Size(13, 17);
			label1.TabIndex = 25;
			label1.Text = "*";
			// 
			// buttonClearSearch
			// 
			buttonClearSearch.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearSearch.Location = new Point(504, 13);
			buttonClearSearch.Name = "buttonClearSearch";
			buttonClearSearch.Size = new Size(35, 35);
			buttonClearSearch.TabIndex = 18;
			buttonClearSearch.UseVisualStyleBackColor = true;
			buttonClearSearch.Click += buttonClearSearch_Click;
			// 
			// picSearchIcon
			// 
			picSearchIcon.Image = (Image)resources.GetObject("picSearchIcon.Image");
			picSearchIcon.Location = new Point(20, 13);
			picSearchIcon.Name = "picSearchIcon";
			picSearchIcon.Size = new Size(35, 35);
			picSearchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
			picSearchIcon.TabIndex = 23;
			picSearchIcon.TabStop = false;
			// 
			// textSearch
			// 
			textSearch.Font = new Font("Segoe UI", 15.75F);
			textSearch.Location = new Point(61, 13);
			textSearch.MaxLength = 100;
			textSearch.Name = "textSearch";
			textSearch.Size = new Size(437, 35);
			textSearch.TabIndex = 17;
			textSearch.TextChanged += textSearch_TextChanged;
			// 
			// labelRenewals
			// 
			labelRenewals.AutoSize = true;
			labelRenewals.Font = new Font("Segoe UI", 9.75F);
			labelRenewals.Location = new Point(252, 373);
			labelRenewals.Name = "labelRenewals";
			labelRenewals.Size = new Size(65, 17);
			labelRenewals.TabIndex = 12;
			labelRenewals.Text = "Renewals:";
			// 
			// textHometown
			// 
			textHometown.Font = new Font("Segoe UI", 9.75F);
			textHometown.Location = new Point(540, 481);
			textHometown.MaxLength = 100;
			textHometown.Name = "textHometown";
			textHometown.Size = new Size(243, 25);
			textHometown.TabIndex = 11;
			// 
			// textDOD
			// 
			textDOD.Font = new Font("Segoe UI", 9.75F);
			textDOD.Location = new Point(538, 450);
			textDOD.Name = "textDOD";
			textDOD.Size = new Size(243, 25);
			textDOD.TabIndex = 9;
			// 
			// textCardNumber
			// 
			textCardNumber.Font = new Font("Segoe UI", 9.75F);
			textCardNumber.Location = new Point(538, 419);
			textCardNumber.Name = "textCardNumber";
			textCardNumber.Size = new Size(243, 25);
			textCardNumber.TabIndex = 7;
			// 
			// textRenewals
			// 
			textRenewals.Font = new Font("Segoe UI", 9.75F);
			textRenewals.Location = new Point(361, 373);
			textRenewals.MaxLength = 100;
			textRenewals.Name = "textRenewals";
			textRenewals.Size = new Size(137, 25);
			textRenewals.TabIndex = 5;
			// 
			// labelCheckoutDate
			// 
			labelCheckoutDate.AutoSize = true;
			labelCheckoutDate.Font = new Font("Segoe UI", 9.75F);
			labelCheckoutDate.Location = new Point(252, 319);
			labelCheckoutDate.Name = "labelCheckoutDate";
			labelCheckoutDate.Size = new Size(101, 17);
			labelCheckoutDate.TabIndex = 4;
			labelCheckoutDate.Text = "Check Out Date:";
			// 
			// dgUsers
			// 
			dgUsers.AllowUserToAddRows = false;
			dgUsers.AllowUserToDeleteRows = false;
			dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgUsers.BackgroundColor = Color.Silver;
			dgUsers.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = Color.DarkBlue;
			dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgUsers.Location = new Point(20, 74);
			dgUsers.MultiSelect = false;
			dgUsers.Name = "dgUsers";
			dgUsers.ReadOnly = true;
			dgUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = Color.DarkBlue;
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
			dgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			dgUsers.RowHeadersVisible = false;
			dataGridViewCellStyle9.BackColor = Color.Silver;
			dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle9.ForeColor = Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = Color.RoyalBlue;
			dgUsers.RowsDefaultCellStyle = dataGridViewCellStyle9;
			dgUsers.RowTemplate.Height = 20;
			dgUsers.RowTemplate.ReadOnly = true;
			dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgUsers.ShowEditingIcon = false;
			dgUsers.Size = new Size(342, 205);
			dgUsers.TabIndex = 19;
			dgUsers.CellClick += dgUsers_CellClick;
			// 
			// textDueDate
			// 
			textDueDate.Font = new Font("Segoe UI", 9.75F);
			textDueDate.Location = new Point(361, 342);
			textDueDate.MaxLength = 100;
			textDueDate.Name = "textDueDate";
			textDueDate.Size = new Size(137, 25);
			textDueDate.TabIndex = 3;
			// 
			// textCheckOutDate
			// 
			textCheckOutDate.Enabled = false;
			textCheckOutDate.Font = new Font("Segoe UI", 9.75F);
			textCheckOutDate.Location = new Point(361, 311);
			textCheckOutDate.MaxLength = 100;
			textCheckOutDate.Name = "textCheckOutDate";
			textCheckOutDate.Size = new Size(137, 25);
			textCheckOutDate.TabIndex = 1;
			// 
			// labelDueDate
			// 
			labelDueDate.AutoSize = true;
			labelDueDate.Font = new Font("Segoe UI", 9.75F);
			labelDueDate.Location = new Point(252, 346);
			labelDueDate.Name = "labelDueDate";
			labelDueDate.Size = new Size(65, 17);
			labelDueDate.TabIndex = 0;
			labelDueDate.Text = "Due Date:";
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
			panelHeader.Size = new Size(968, 70);
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
			buttonClose.Location = new Point(934, 2);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(34, 32);
			buttonClose.TabIndex = 10;
			buttonClose.UseVisualStyleBackColor = false;
			buttonClose.Click += buttonClose_Click;
			// 
			// panelSidebar
			// 
			panelSidebar.Controls.Add(labelBooksCount);
			panelSidebar.Controls.Add(labelPhone);
			panelSidebar.Controls.Add(labelEmail);
			panelSidebar.Controls.Add(labelCardNumber);
			panelSidebar.Controls.Add(labelName);
			panelSidebar.Controls.Add(labelCheckOutCount);
			panelSidebar.Controls.Add(buttonDelete);
			panelSidebar.Controls.Add(buttonUpdate);
			panelSidebar.Controls.Add(buttonAdd);
			panelSidebar.Location = new Point(4, 75);
			panelSidebar.Name = "panelSidebar";
			panelSidebar.Size = new Size(149, 524);
			panelSidebar.TabIndex = 6;
			// 
			// labelBooksCount
			// 
			labelBooksCount.BackColor = Color.DarkBlue;
			labelBooksCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelBooksCount.ForeColor = Color.Gold;
			labelBooksCount.Location = new Point(12, 196);
			labelBooksCount.Name = "labelBooksCount";
			labelBooksCount.Size = new Size(125, 21);
			labelBooksCount.TabIndex = 34;
			labelBooksCount.Text = "books";
			// 
			// labelPhone
			// 
			labelPhone.AutoSize = true;
			labelPhone.Font = new Font("Segoe UI", 12F);
			labelPhone.ForeColor = Color.Gold;
			labelPhone.Location = new Point(16, 155);
			labelPhone.Name = "labelPhone";
			labelPhone.Size = new Size(54, 21);
			labelPhone.TabIndex = 33;
			labelPhone.Text = "phone";
			// 
			// labelEmail
			// 
			labelEmail.AutoSize = true;
			labelEmail.Font = new Font("Segoe UI", 12F);
			labelEmail.ForeColor = Color.Gold;
			labelEmail.Location = new Point(16, 127);
			labelEmail.Name = "labelEmail";
			labelEmail.Size = new Size(48, 21);
			labelEmail.TabIndex = 32;
			labelEmail.Text = "Email";
			// 
			// labelCardNumber
			// 
			labelCardNumber.AutoSize = true;
			labelCardNumber.Font = new Font("Segoe UI", 12F);
			labelCardNumber.ForeColor = Color.Gold;
			labelCardNumber.Location = new Point(16, 102);
			labelCardNumber.Name = "labelCardNumber";
			labelCardNumber.Size = new Size(40, 21);
			labelCardNumber.TabIndex = 31;
			labelCardNumber.Text = "card";
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Font = new Font("Segoe UI", 12F);
			labelName.ForeColor = Color.Gold;
			labelName.Location = new Point(15, 77);
			labelName.Name = "labelName";
			labelName.Size = new Size(49, 21);
			labelName.TabIndex = 30;
			labelName.Text = "name";
			// 
			// labelCheckOutCount
			// 
			labelCheckOutCount.BackColor = Color.FromArgb(17, 24, 34);
			labelCheckOutCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelCheckOutCount.ForeColor = Color.Gold;
			labelCheckOutCount.Location = new Point(12, 16);
			labelCheckOutCount.Name = "labelCheckOutCount";
			labelCheckOutCount.Size = new Size(125, 21);
			labelCheckOutCount.TabIndex = 25;
			labelCheckOutCount.Text = "checked out";
			labelCheckOutCount.TextAlign = ContentAlignment.MiddleLeft;
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
			buttonDelete.Location = new Point(12, 450);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(125, 53);
			buttonDelete.TabIndex = 23;
			buttonDelete.TabStop = false;
			buttonDelete.Text = "Delete";
			buttonDelete.TextAlign = ContentAlignment.MiddleRight;
			buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonDelete, "Delete the currently selected author");
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
			buttonUpdate.Location = new Point(12, 376);
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.Size = new Size(125, 53);
			buttonUpdate.TabIndex = 22;
			buttonUpdate.TabStop = false;
			buttonUpdate.Text = "Update";
			buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
			buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonUpdate, "Update the currently selected author's information");
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
			buttonAdd.Location = new Point(12, 302);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(125, 53);
			buttonAdd.TabIndex = 21;
			buttonAdd.TabStop = false;
			buttonAdd.Text = "Add";
			buttonAdd.TextAlign = ContentAlignment.MiddleRight;
			buttonAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonAdd, "Add the current form information as a new author");
			buttonAdd.UseVisualStyleBackColor = false;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// ManageCirculationForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 24, 34);
			ClientSize = new Size(980, 620);
			Controls.Add(panelSidebar);
			Controls.Add(panelHeader);
			Controls.Add(panelMain);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageCirculationForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageCirculationForm";
			Load += ManageCirculationForm_Load;
			panelMain.ResumeLayout(false);
			panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgCirculation).EndInit();
			((System.ComponentModel.ISupportInitialize)dgBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)picSearchIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
			panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picHeaderLogo).EndInit();
			panelSidebar.ResumeLayout(false);
			panelSidebar.PerformLayout();
			ResumeLayout(false);
		}




		#endregion

		private Label labelHeader;
		private Panel panelMain;
		private DataGridView dgUsers;
		private TextBox textDueDate;
		private TextBox textCheckOutDate;
		private Label labelDueDate;
		private Panel panelHeader;
		private PictureBox picHeaderLogo;
		private Button buttonClose;
		private Panel panelSidebar;
		private Button buttonDelete;
		private Button buttonUpdate;
		private Button buttonAdd;
		private TextBox textRenewals;
		private Label labelCheckoutDate;
		private Label labelRenewals;
		private TextBox textHometown;
		private TextBox textDOD;
		private TextBox textCardNumber;
		private TextBox textSearch;
		private PictureBox picSearchIcon;
		private Button buttonClearSearch;
		private Label labelStatus;
		private Label label1;
		private Label label2;
		private Label label3;
		private ToolTip toolTip1;
		private Label labelCheckOutCount;
		private Button buttonShowAuthorBooks;
		private Label labelPhone;
		private Label labelEmail;
		private Label labelCardNumber;
		private Label labelName;
		private Label labelBooksCount;
		private DataGridView dgBooks;
		private DataGridView dgCirculation;
	}
}