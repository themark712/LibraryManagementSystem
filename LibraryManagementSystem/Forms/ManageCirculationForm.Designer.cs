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
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCirculationForm));
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			labelHeader = new Label();
			panelMain = new Panel();
			groupBooks = new GroupBox();
			buttonClearBookSearch = new Button();
			dgBooks = new DataGridView();
			pictureBox1 = new PictureBox();
			buttonAdd = new Button();
			textBookSearch = new TextBox();
			groupUserBooks = new GroupBox();
			buttonUpdate = new Button();
			dgCirculation = new DataGridView();
			buttonDelete = new Button();
			buttonClearUserSearch = new Button();
			picSearchIcon = new PictureBox();
			textUserSearch = new TextBox();
			labelRenewals = new Label();
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
			labelUserCheckOutCount = new Label();
			labelPhone = new Label();
			labelEmail = new Label();
			labelCardNumber = new Label();
			labelName = new Label();
			labelCheckOutCount = new Label();
			toolTip1 = new ToolTip(components);
			panelMain.SuspendLayout();
			groupBooks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupUserBooks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgCirculation).BeginInit();
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
			panelMain.Controls.Add(groupBooks);
			panelMain.Controls.Add(groupUserBooks);
			panelMain.Location = new Point(159, 78);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(847, 530);
			panelMain.TabIndex = 4;
			// 
			// groupBooks
			// 
			groupBooks.Controls.Add(buttonClearBookSearch);
			groupBooks.Controls.Add(dgBooks);
			groupBooks.Controls.Add(pictureBox1);
			groupBooks.Controls.Add(buttonAdd);
			groupBooks.Controls.Add(textBookSearch);
			groupBooks.Location = new Point(436, 13);
			groupBooks.Name = "groupBooks";
			groupBooks.Size = new Size(393, 508);
			groupBooks.TabIndex = 41;
			groupBooks.TabStop = false;
			groupBooks.Text = "Available Books";
			// 
			// buttonClearBookSearch
			// 
			buttonClearBookSearch.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearBookSearch.Image = (Image)resources.GetObject("buttonClearBookSearch.Image");
			buttonClearBookSearch.Location = new Point(350, 25);
			buttonClearBookSearch.Name = "buttonClearBookSearch";
			buttonClearBookSearch.Size = new Size(35, 35);
			buttonClearBookSearch.TabIndex = 38;
			buttonClearBookSearch.UseVisualStyleBackColor = true;
			buttonClearBookSearch.Click += buttonClearBookSearch_Click;
			// 
			// dgBooks
			// 
			dgBooks.AllowUserToAddRows = false;
			dgBooks.AllowUserToDeleteRows = false;
			dgBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgBooks.BackgroundColor = Color.Silver;
			dgBooks.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = Color.DarkBlue;
			dataGridViewCellStyle16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle16.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
			dgBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			dgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgBooks.Location = new Point(11, 79);
			dgBooks.MultiSelect = false;
			dgBooks.Name = "dgBooks";
			dgBooks.ReadOnly = true;
			dgBooks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = Color.DarkBlue;
			dataGridViewCellStyle17.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle17.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
			dgBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
			dgBooks.RowHeadersVisible = false;
			dataGridViewCellStyle18.BackColor = Color.Silver;
			dataGridViewCellStyle18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle18.ForeColor = Color.Black;
			dataGridViewCellStyle18.SelectionBackColor = Color.RoyalBlue;
			dgBooks.RowsDefaultCellStyle = dataGridViewCellStyle18;
			dgBooks.RowTemplate.Height = 20;
			dgBooks.RowTemplate.ReadOnly = true;
			dgBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgBooks.ShowEditingIcon = false;
			dgBooks.Size = new Size(371, 340);
			dgBooks.TabIndex = 31;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(11, 25);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(35, 35);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 39;
			pictureBox1.TabStop = false;
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
			buttonAdd.Location = new Point(257, 446);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(125, 45);
			buttonAdd.TabIndex = 34;
			buttonAdd.TabStop = false;
			buttonAdd.Text = "Loan";
			buttonAdd.TextAlign = ContentAlignment.MiddleRight;
			buttonAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonAdd, "Add the current form information as a new author");
			buttonAdd.UseVisualStyleBackColor = false;
			// 
			// textBookSearch
			// 
			textBookSearch.Font = new Font("Segoe UI", 15.75F);
			textBookSearch.Location = new Point(52, 25);
			textBookSearch.MaxLength = 100;
			textBookSearch.Name = "textBookSearch";
			textBookSearch.Size = new Size(294, 35);
			textBookSearch.TabIndex = 37;
			textBookSearch.TextChanged += textBookSearch_TextChanged;
			// 
			// groupUserBooks
			// 
			groupUserBooks.Controls.Add(buttonUpdate);
			groupUserBooks.Controls.Add(dgCirculation);
			groupUserBooks.Controls.Add(buttonDelete);
			groupUserBooks.Controls.Add(buttonClearUserSearch);
			groupUserBooks.Controls.Add(picSearchIcon);
			groupUserBooks.Controls.Add(textUserSearch);
			groupUserBooks.Controls.Add(labelRenewals);
			groupUserBooks.Controls.Add(textRenewals);
			groupUserBooks.Controls.Add(labelCheckoutDate);
			groupUserBooks.Controls.Add(dgUsers);
			groupUserBooks.Controls.Add(textDueDate);
			groupUserBooks.Controls.Add(textCheckOutDate);
			groupUserBooks.Controls.Add(labelDueDate);
			groupUserBooks.Location = new Point(13, 13);
			groupUserBooks.Name = "groupUserBooks";
			groupUserBooks.Size = new Size(405, 508);
			groupUserBooks.TabIndex = 40;
			groupUserBooks.TabStop = false;
			groupUserBooks.Text = "User Circulation";
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
			buttonUpdate.Location = new Point(230, 415);
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.Size = new Size(137, 34);
			buttonUpdate.TabIndex = 35;
			buttonUpdate.TabStop = false;
			buttonUpdate.Text = "Return";
			buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
			buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonUpdate, "Update the currently selected author's information");
			buttonUpdate.UseVisualStyleBackColor = false;
			// 
			// dgCirculation
			// 
			dgCirculation.AllowUserToAddRows = false;
			dgCirculation.AllowUserToDeleteRows = false;
			dgCirculation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgCirculation.BackgroundColor = Color.Silver;
			dgCirculation.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = Color.DarkBlue;
			dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle10.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
			dgCirculation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			dgCirculation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgCirculation.Location = new Point(18, 275);
			dgCirculation.MultiSelect = false;
			dgCirculation.Name = "dgCirculation";
			dgCirculation.ReadOnly = true;
			dgCirculation.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = Color.DarkBlue;
			dataGridViewCellStyle11.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle11.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
			dgCirculation.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			dgCirculation.RowHeadersVisible = false;
			dataGridViewCellStyle12.BackColor = Color.Silver;
			dataGridViewCellStyle12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle12.ForeColor = Color.Black;
			dataGridViewCellStyle12.SelectionBackColor = Color.RoyalBlue;
			dgCirculation.RowsDefaultCellStyle = dataGridViewCellStyle12;
			dgCirculation.RowTemplate.Height = 20;
			dgCirculation.RowTemplate.ReadOnly = true;
			dgCirculation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgCirculation.ShowEditingIcon = false;
			dgCirculation.Size = new Size(206, 216);
			dgCirculation.TabIndex = 49;
			dgCirculation.CellClick += dgCirculation_CellClick;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.SteelBlue;
			buttonDelete.BackgroundImageLayout = ImageLayout.None;
			buttonDelete.Cursor = Cursors.Hand;
			buttonDelete.FlatStyle = FlatStyle.Popup;
			buttonDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonDelete.ForeColor = Color.DarkBlue;
			buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
			buttonDelete.ImageAlign = ContentAlignment.TopLeft;
			buttonDelete.Location = new Point(230, 458);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(137, 35);
			buttonDelete.TabIndex = 48;
			buttonDelete.TabStop = false;
			buttonDelete.Text = "Renew";
			buttonDelete.TextAlign = ContentAlignment.MiddleRight;
			buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip1.SetToolTip(buttonDelete, "Delete the currently selected author");
			buttonDelete.UseVisualStyleBackColor = false;
			// 
			// buttonClearUserSearch
			// 
			buttonClearUserSearch.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearUserSearch.Image = (Image)resources.GetObject("buttonClearUserSearch.Image");
			buttonClearUserSearch.Location = new Point(361, 25);
			buttonClearUserSearch.Name = "buttonClearUserSearch";
			buttonClearUserSearch.Size = new Size(35, 35);
			buttonClearUserSearch.TabIndex = 44;
			buttonClearUserSearch.UseVisualStyleBackColor = true;
			// 
			// picSearchIcon
			// 
			picSearchIcon.Image = (Image)resources.GetObject("picSearchIcon.Image");
			picSearchIcon.Location = new Point(12, 25);
			picSearchIcon.Name = "picSearchIcon";
			picSearchIcon.Size = new Size(35, 35);
			picSearchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
			picSearchIcon.TabIndex = 46;
			picSearchIcon.TabStop = false;
			// 
			// textUserSearch
			// 
			textUserSearch.Font = new Font("Segoe UI", 15.75F);
			textUserSearch.Location = new Point(53, 25);
			textUserSearch.MaxLength = 100;
			textUserSearch.Name = "textUserSearch";
			textUserSearch.Size = new Size(302, 35);
			textUserSearch.TabIndex = 43;
			textUserSearch.TextChanged += textUserSearch_TextChanged;
			// 
			// labelRenewals
			// 
			labelRenewals.AutoSize = true;
			labelRenewals.Font = new Font("Segoe UI", 9.75F);
			labelRenewals.Location = new Point(230, 366);
			labelRenewals.Name = "labelRenewals";
			labelRenewals.Size = new Size(65, 17);
			labelRenewals.TabIndex = 42;
			labelRenewals.Text = "Renewals:";
			// 
			// textRenewals
			// 
			textRenewals.Font = new Font("Segoe UI", 9.75F);
			textRenewals.Location = new Point(230, 384);
			textRenewals.MaxLength = 100;
			textRenewals.Name = "textRenewals";
			textRenewals.Size = new Size(137, 25);
			textRenewals.TabIndex = 41;
			// 
			// labelCheckoutDate
			// 
			labelCheckoutDate.AutoSize = true;
			labelCheckoutDate.Font = new Font("Segoe UI", 9.75F);
			labelCheckoutDate.Location = new Point(230, 275);
			labelCheckoutDate.Name = "labelCheckoutDate";
			labelCheckoutDate.Size = new Size(101, 17);
			labelCheckoutDate.TabIndex = 40;
			labelCheckoutDate.Text = "Check Out Date:";
			// 
			// dgUsers
			// 
			dgUsers.AllowUserToAddRows = false;
			dgUsers.AllowUserToDeleteRows = false;
			dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgUsers.BackgroundColor = Color.Silver;
			dgUsers.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = Color.DarkBlue;
			dataGridViewCellStyle13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle13.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
			dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgUsers.Location = new Point(18, 79);
			dgUsers.MultiSelect = false;
			dgUsers.Name = "dgUsers";
			dgUsers.ReadOnly = true;
			dgUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = Color.DarkBlue;
			dataGridViewCellStyle14.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle14.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
			dgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			dgUsers.RowHeadersVisible = false;
			dataGridViewCellStyle15.BackColor = Color.Silver;
			dataGridViewCellStyle15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle15.ForeColor = Color.Black;
			dataGridViewCellStyle15.SelectionBackColor = Color.RoyalBlue;
			dgUsers.RowsDefaultCellStyle = dataGridViewCellStyle15;
			dgUsers.RowTemplate.Height = 20;
			dgUsers.RowTemplate.ReadOnly = true;
			dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgUsers.ShowEditingIcon = false;
			dgUsers.Size = new Size(369, 190);
			dgUsers.TabIndex = 45;
			dgUsers.CellClick += dgUsers_CellClick;
			// 
			// textDueDate
			// 
			textDueDate.Font = new Font("Segoe UI", 9.75F);
			textDueDate.Location = new Point(230, 338);
			textDueDate.MaxLength = 100;
			textDueDate.Name = "textDueDate";
			textDueDate.Size = new Size(137, 25);
			textDueDate.TabIndex = 39;
			// 
			// textCheckOutDate
			// 
			textCheckOutDate.Enabled = false;
			textCheckOutDate.Font = new Font("Segoe UI", 9.75F);
			textCheckOutDate.Location = new Point(230, 292);
			textCheckOutDate.MaxLength = 100;
			textCheckOutDate.Name = "textCheckOutDate";
			textCheckOutDate.Size = new Size(137, 25);
			textCheckOutDate.TabIndex = 38;
			// 
			// labelDueDate
			// 
			labelDueDate.AutoSize = true;
			labelDueDate.Font = new Font("Segoe UI", 9.75F);
			labelDueDate.Location = new Point(230, 320);
			labelDueDate.Name = "labelDueDate";
			labelDueDate.Size = new Size(65, 17);
			labelDueDate.TabIndex = 37;
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
			panelHeader.Size = new Size(1002, 70);
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
			buttonClose.Location = new Point(961, 2);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(34, 32);
			buttonClose.TabIndex = 10;
			buttonClose.UseVisualStyleBackColor = false;
			buttonClose.Click += buttonClose_Click;
			// 
			// panelSidebar
			// 
			panelSidebar.Controls.Add(labelUserCheckOutCount);
			panelSidebar.Controls.Add(labelPhone);
			panelSidebar.Controls.Add(labelEmail);
			panelSidebar.Controls.Add(labelCardNumber);
			panelSidebar.Controls.Add(labelName);
			panelSidebar.Controls.Add(labelCheckOutCount);
			panelSidebar.Location = new Point(4, 75);
			panelSidebar.Name = "panelSidebar";
			panelSidebar.Size = new Size(149, 524);
			panelSidebar.TabIndex = 6;
			// 
			// labelUserCheckOutCount
			// 
			labelUserCheckOutCount.BackColor = Color.DarkBlue;
			labelUserCheckOutCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelUserCheckOutCount.ForeColor = Color.Gold;
			labelUserCheckOutCount.Location = new Point(12, 196);
			labelUserCheckOutCount.Name = "labelUserCheckOutCount";
			labelUserCheckOutCount.Size = new Size(125, 21);
			labelUserCheckOutCount.TabIndex = 34;
			labelUserCheckOutCount.Text = "books";
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
			// ManageCirculationForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 24, 34);
			ClientSize = new Size(1018, 620);
			Controls.Add(panelSidebar);
			Controls.Add(panelHeader);
			Controls.Add(panelMain);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageCirculationForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageCirculationForm";
			Load += ManageCirculationForm_Load;
			panelMain.ResumeLayout(false);
			groupBooks.ResumeLayout(false);
			groupBooks.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupUserBooks.ResumeLayout(false);
			groupUserBooks.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgCirculation).EndInit();
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
		private Panel panelHeader;
		private PictureBox picHeaderLogo;
		private Button buttonClose;
		private Panel panelSidebar;
		private Label labelStatus;
		private ToolTip toolTip1;
		private Label labelCheckOutCount;
		private Label labelPhone;
		private Label labelEmail;
		private Label labelCardNumber;
		private Label labelName;
		private Label labelUserCheckOutCount;
		private DataGridView dgBooks;
		private Button buttonUpdate;
		private Button buttonAdd;
		private Button buttonClearBookSearch;
		private PictureBox pictureBox1;
		private TextBox textBookSearch;
		private GroupBox groupUserBooks;
		private Button buttonDelete;
		private DataGridView dgCirculation;
		private Button buttonClearUserSearch;
		private PictureBox picSearchIcon;
		private TextBox textUserSearch;
		private Label labelRenewals;
		private TextBox textRenewals;
		private Label labelCheckoutDate;
		private DataGridView dgUsers;
		private TextBox textDueDate;
		private TextBox textCheckOutDate;
		private Label labelDueDate;
		private GroupBox groupBooks;
	}
}