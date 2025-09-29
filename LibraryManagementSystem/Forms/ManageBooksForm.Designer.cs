namespace LibraryManagementSystem.Forms
{
	partial class ManageBooksForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooksForm));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			panel1 = new Panel();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			labelCoverFileName = new Label();
			numCopies = new NumericUpDown();
			comboGenres = new ComboBox();
			labelGenre = new Label();
			dateReceived = new DateTimePicker();
			labelDateReceived = new Label();
			textPublisher = new TextBox();
			labelPublisher = new Label();
			buttonAddCover = new Button();
			labelCover = new Label();
			picCover = new PictureBox();
			textPrice = new TextBox();
			comboAuthors = new ComboBox();
			buttonClearSearch = new Button();
			pictureBox2 = new PictureBox();
			textSearch = new TextBox();
			textAbout = new RichTextBox();
			labelAbout = new Label();
			labelPrice = new Label();
			labelCopies = new Label();
			textISBN = new TextBox();
			labelISBN = new Label();
			textYear = new TextBox();
			labelYear = new Label();
			labelAuthor = new Label();
			dgBooks = new DataGridView();
			textTitle = new TextBox();
			textId = new TextBox();
			labelTitle = new Label();
			labelId = new Label();
			label4 = new Label();
			label5 = new Label();
			pictureBox1 = new PictureBox();
			labelHeader = new Label();
			panel2 = new Panel();
			labelStatus = new Label();
			buttonClose = new Button();
			panel3 = new Panel();
			buttonClearAuthorFilter = new Button();
			buttonClearGenreFilter = new Button();
			comboGenreView = new ComboBox();
			comboAuthorView = new ComboBox();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			buttonDelete = new Button();
			buttonUpdate = new Button();
			buttonAdd = new Button();
			openFileBookImage = new OpenFileDialog();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numCopies).BeginInit();
			((System.ComponentModel.ISupportInitialize)picCover).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgBooks).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Silver;
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(labelCoverFileName);
			panel1.Controls.Add(numCopies);
			panel1.Controls.Add(comboGenres);
			panel1.Controls.Add(labelGenre);
			panel1.Controls.Add(dateReceived);
			panel1.Controls.Add(labelDateReceived);
			panel1.Controls.Add(textPublisher);
			panel1.Controls.Add(labelPublisher);
			panel1.Controls.Add(buttonAddCover);
			panel1.Controls.Add(labelCover);
			panel1.Controls.Add(picCover);
			panel1.Controls.Add(textPrice);
			panel1.Controls.Add(comboAuthors);
			panel1.Controls.Add(buttonClearSearch);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(textSearch);
			panel1.Controls.Add(textAbout);
			panel1.Controls.Add(labelAbout);
			panel1.Controls.Add(labelPrice);
			panel1.Controls.Add(labelCopies);
			panel1.Controls.Add(textISBN);
			panel1.Controls.Add(labelISBN);
			panel1.Controls.Add(textYear);
			panel1.Controls.Add(labelYear);
			panel1.Controls.Add(labelAuthor);
			panel1.Controls.Add(dgBooks);
			panel1.Controls.Add(textTitle);
			panel1.Controls.Add(textId);
			panel1.Controls.Add(labelTitle);
			panel1.Controls.Add(labelId);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label5);
			panel1.Location = new Point(160, 80);
			panel1.Name = "panel1";
			panel1.Size = new Size(837, 508);
			panel1.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.White;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DarkBlue;
			label3.Location = new Point(354, 320);
			label3.Name = "label3";
			label3.Size = new Size(15, 20);
			label3.TabIndex = 40;
			label3.Text = "*";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.White;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DarkBlue;
			label2.Location = new Point(354, 169);
			label2.Name = "label2";
			label2.Size = new Size(15, 20);
			label2.TabIndex = 39;
			label2.Text = "*";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.White;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.DarkBlue;
			label1.Location = new Point(354, 55);
			label1.Name = "label1";
			label1.Size = new Size(15, 20);
			label1.TabIndex = 38;
			label1.Text = "*";
			// 
			// labelCoverFileName
			// 
			labelCoverFileName.AutoSize = true;
			labelCoverFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelCoverFileName.Location = new Point(465, 243);
			labelCoverFileName.Name = "labelCoverFileName";
			labelCoverFileName.Size = new Size(0, 21);
			labelCoverFileName.TabIndex = 37;
			// 
			// numCopies
			// 
			numCopies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			numCopies.Location = new Point(127, 281);
			numCopies.Name = "numCopies";
			numCopies.Size = new Size(120, 29);
			numCopies.TabIndex = 36;
			// 
			// comboGenres
			// 
			comboGenres.Font = new Font("Segoe UI", 12F);
			comboGenres.FormattingEnabled = true;
			comboGenres.Location = new Point(127, 129);
			comboGenres.Name = "comboGenres";
			comboGenres.Size = new Size(242, 29);
			comboGenres.TabIndex = 35;
			// 
			// labelGenre
			// 
			labelGenre.AutoSize = true;
			labelGenre.Font = new Font("Segoe UI", 12F);
			labelGenre.Location = new Point(66, 133);
			labelGenre.Name = "labelGenre";
			labelGenre.Size = new Size(55, 21);
			labelGenre.TabIndex = 34;
			labelGenre.Text = "Genre:";
			// 
			// dateReceived
			// 
			dateReceived.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dateReceived.Location = new Point(127, 455);
			dateReceived.Name = "dateReceived";
			dateReceived.Size = new Size(243, 27);
			dateReceived.TabIndex = 33;
			// 
			// labelDateReceived
			// 
			labelDateReceived.AutoSize = true;
			labelDateReceived.Font = new Font("Segoe UI", 12F);
			labelDateReceived.Location = new Point(10, 458);
			labelDateReceived.Name = "labelDateReceived";
			labelDateReceived.Size = new Size(111, 21);
			labelDateReceived.TabIndex = 32;
			labelDateReceived.Text = "Date Received:";
			// 
			// textPublisher
			// 
			textPublisher.Font = new Font("Segoe UI", 12F);
			textPublisher.Location = new Point(127, 205);
			textPublisher.MaxLength = 100;
			textPublisher.Name = "textPublisher";
			textPublisher.Size = new Size(243, 29);
			textPublisher.TabIndex = 31;
			// 
			// labelPublisher
			// 
			labelPublisher.AutoSize = true;
			labelPublisher.Font = new Font("Segoe UI", 12F);
			labelPublisher.Location = new Point(43, 209);
			labelPublisher.Name = "labelPublisher";
			labelPublisher.Size = new Size(78, 21);
			labelPublisher.TabIndex = 30;
			labelPublisher.Text = "Publisher:";
			// 
			// buttonAddCover
			// 
			buttonAddCover.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonAddCover.Image = (Image)resources.GetObject("buttonAddCover.Image");
			buttonAddCover.Location = new Point(570, 412);
			buttonAddCover.Name = "buttonAddCover";
			buttonAddCover.Size = new Size(146, 44);
			buttonAddCover.TabIndex = 29;
			buttonAddCover.Text = "Select Cover";
			buttonAddCover.TextAlign = ContentAlignment.MiddleRight;
			buttonAddCover.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonAddCover.UseVisualStyleBackColor = true;
			buttonAddCover.Click += buttonAddCover_Click;
			// 
			// labelCover
			// 
			labelCover.AutoSize = true;
			labelCover.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelCover.Location = new Point(405, 243);
			labelCover.Name = "labelCover";
			labelCover.Size = new Size(54, 21);
			labelCover.TabIndex = 28;
			labelCover.Text = "Cover:";
			// 
			// picCover
			// 
			picCover.ErrorImage = null;
			picCover.InitialImage = null;
			picCover.Location = new Point(406, 264);
			picCover.Name = "picCover";
			picCover.Size = new Size(145, 192);
			picCover.SizeMode = PictureBoxSizeMode.StretchImage;
			picCover.TabIndex = 27;
			picCover.TabStop = false;
			// 
			// textPrice
			// 
			textPrice.Font = new Font("Segoe UI", 12F);
			textPrice.Location = new Point(127, 319);
			textPrice.MaxLength = 100;
			textPrice.Name = "textPrice";
			textPrice.Size = new Size(243, 29);
			textPrice.TabIndex = 26;
			// 
			// comboAuthors
			// 
			comboAuthors.Font = new Font("Segoe UI", 12F);
			comboAuthors.FormattingEnabled = true;
			comboAuthors.Location = new Point(127, 91);
			comboAuthors.Name = "comboAuthors";
			comboAuthors.Size = new Size(242, 29);
			comboAuthors.TabIndex = 25;
			// 
			// buttonClearSearch
			// 
			buttonClearSearch.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearSearch.FlatAppearance.BorderSize = 0;
			buttonClearSearch.FlatStyle = FlatStyle.Flat;
			buttonClearSearch.Image = (Image)resources.GetObject("buttonClearSearch.Image");
			buttonClearSearch.Location = new Point(787, 15);
			buttonClearSearch.Name = "buttonClearSearch";
			buttonClearSearch.Size = new Size(29, 29);
			buttonClearSearch.TabIndex = 24;
			buttonClearSearch.UseVisualStyleBackColor = true;
			buttonClearSearch.Click += buttonClearSearch_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(405, 15);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(29, 29);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 23;
			pictureBox2.TabStop = false;
			// 
			// textSearch
			// 
			textSearch.Font = new Font("Segoe UI", 12F);
			textSearch.Location = new Point(440, 15);
			textSearch.MaxLength = 100;
			textSearch.Name = "textSearch";
			textSearch.Size = new Size(332, 29);
			textSearch.TabIndex = 22;
			textSearch.TextChanged += textSearch_TextChanged;
			// 
			// textAbout
			// 
			textAbout.Font = new Font("Segoe UI", 12F);
			textAbout.Location = new Point(127, 357);
			textAbout.MaxLength = 200;
			textAbout.Name = "textAbout";
			textAbout.Size = new Size(243, 89);
			textAbout.TabIndex = 21;
			textAbout.Text = "";
			// 
			// labelAbout
			// 
			labelAbout.AutoSize = true;
			labelAbout.Font = new Font("Segoe UI", 12F);
			labelAbout.Location = new Point(66, 361);
			labelAbout.Name = "labelAbout";
			labelAbout.Size = new Size(55, 21);
			labelAbout.TabIndex = 19;
			labelAbout.Text = "About:";
			// 
			// labelPrice
			// 
			labelPrice.AutoSize = true;
			labelPrice.Font = new Font("Segoe UI", 12F);
			labelPrice.Location = new Point(74, 323);
			labelPrice.Name = "labelPrice";
			labelPrice.Size = new Size(47, 21);
			labelPrice.TabIndex = 17;
			labelPrice.Text = "Price:";
			// 
			// labelCopies
			// 
			labelCopies.AutoSize = true;
			labelCopies.Font = new Font("Segoe UI", 12F);
			labelCopies.Location = new Point(61, 285);
			labelCopies.Name = "labelCopies";
			labelCopies.Size = new Size(60, 21);
			labelCopies.TabIndex = 15;
			labelCopies.Text = "Copies:";
			// 
			// textISBN
			// 
			textISBN.Font = new Font("Segoe UI", 12F);
			textISBN.Location = new Point(127, 243);
			textISBN.Name = "textISBN";
			textISBN.Size = new Size(243, 29);
			textISBN.TabIndex = 14;
			// 
			// labelISBN
			// 
			labelISBN.AutoSize = true;
			labelISBN.Font = new Font("Segoe UI", 12F);
			labelISBN.Location = new Point(74, 247);
			labelISBN.Name = "labelISBN";
			labelISBN.Size = new Size(47, 21);
			labelISBN.TabIndex = 13;
			labelISBN.Text = "ISBN:";
			// 
			// textYear
			// 
			textYear.Font = new Font("Segoe UI", 12F);
			textYear.Location = new Point(127, 167);
			textYear.Name = "textYear";
			textYear.Size = new Size(243, 29);
			textYear.TabIndex = 12;
			// 
			// labelYear
			// 
			labelYear.AutoSize = true;
			labelYear.Font = new Font("Segoe UI", 12F);
			labelYear.Location = new Point(78, 171);
			labelYear.Name = "labelYear";
			labelYear.Size = new Size(43, 21);
			labelYear.TabIndex = 11;
			labelYear.Text = "Year:";
			// 
			// labelAuthor
			// 
			labelAuthor.AutoSize = true;
			labelAuthor.Font = new Font("Segoe UI", 12F);
			labelAuthor.Location = new Point(60, 95);
			labelAuthor.Name = "labelAuthor";
			labelAuthor.Size = new Size(61, 21);
			labelAuthor.TabIndex = 9;
			labelAuthor.Text = "Author:";
			// 
			// dgBooks
			// 
			dgBooks.AllowUserToAddRows = false;
			dgBooks.AllowUserToDeleteRows = false;
			dgBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgBooks.BackgroundColor = Color.Silver;
			dgBooks.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.DarkBlue;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgBooks.Location = new Point(405, 55);
			dgBooks.MultiSelect = false;
			dgBooks.Name = "dgBooks";
			dgBooks.ReadOnly = true;
			dgBooks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.DarkBlue;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgBooks.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.Silver;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
			dgBooks.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dgBooks.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
			dgBooks.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dgBooks.RowTemplate.DefaultCellStyle.ForeColor = Color.DarkBlue;
			dgBooks.RowTemplate.Height = 20;
			dgBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgBooks.Size = new Size(411, 185);
			dgBooks.TabIndex = 0;
			dgBooks.CellClick += dgBooks_CellClick;
			// 
			// textTitle
			// 
			textTitle.Font = new Font("Segoe UI", 12F);
			textTitle.Location = new Point(127, 53);
			textTitle.MaxLength = 100;
			textTitle.Name = "textTitle";
			textTitle.Size = new Size(243, 29);
			textTitle.TabIndex = 3;
			// 
			// textId
			// 
			textId.Enabled = false;
			textId.Font = new Font("Segoe UI", 12F);
			textId.Location = new Point(127, 15);
			textId.MaxLength = 100;
			textId.Name = "textId";
			textId.Size = new Size(242, 29);
			textId.TabIndex = 2;
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Segoe UI", 12F);
			labelTitle.Location = new Point(79, 57);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(42, 21);
			labelTitle.TabIndex = 1;
			labelTitle.Text = "Title:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Font = new Font("Segoe UI", 12F);
			labelId.Location = new Point(93, 19);
			labelId.Name = "labelId";
			labelId.Size = new Size(28, 21);
			labelId.TabIndex = 0;
			labelId.Text = "ID:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.FlatStyle = FlatStyle.Flat;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.DarkBlue;
			label4.Location = new Point(366, 91);
			label4.Margin = new Padding(0);
			label4.Name = "label4";
			label4.Size = new Size(15, 20);
			label4.TabIndex = 41;
			label4.Text = "*";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.FlatStyle = FlatStyle.Flat;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.DarkBlue;
			label5.Location = new Point(366, 129);
			label5.Margin = new Padding(0);
			label5.Name = "label5";
			label5.Size = new Size(15, 20);
			label5.TabIndex = 42;
			label5.Text = "*";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.ErrorImage = null;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(7, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(67, 59);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 11;
			pictureBox1.TabStop = false;
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
			labelHeader.Text = "Books";
			labelHeader.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DarkBlue;
			panel2.Controls.Add(labelStatus);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(buttonClose);
			panel2.Controls.Add(labelHeader);
			panel2.Location = new Point(5, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(992, 70);
			panel2.TabIndex = 8;
			// 
			// labelStatus
			// 
			labelStatus.BackColor = Color.DarkBlue;
			labelStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelStatus.ForeColor = Color.Gold;
			labelStatus.Location = new Point(282, 34);
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(537, 21);
			labelStatus.TabIndex = 13;
			labelStatus.Text = "status";
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
			// panel3
			// 
			panel3.Controls.Add(buttonClearAuthorFilter);
			panel3.Controls.Add(buttonClearGenreFilter);
			panel3.Controls.Add(comboGenreView);
			panel3.Controls.Add(comboAuthorView);
			panel3.Controls.Add(label8);
			panel3.Controls.Add(label7);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(buttonDelete);
			panel3.Controls.Add(buttonUpdate);
			panel3.Controls.Add(buttonAdd);
			panel3.Location = new Point(5, 77);
			panel3.Name = "panel3";
			panel3.Size = new Size(149, 497);
			panel3.TabIndex = 9;
			// 
			// buttonClearAuthorFilter
			// 
			buttonClearAuthorFilter.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearAuthorFilter.FlatAppearance.BorderSize = 0;
			buttonClearAuthorFilter.FlatStyle = FlatStyle.Flat;
			buttonClearAuthorFilter.Image = (Image)resources.GetObject("buttonClearAuthorFilter.Image");
			buttonClearAuthorFilter.Location = new Point(113, 118);
			buttonClearAuthorFilter.Name = "buttonClearAuthorFilter";
			buttonClearAuthorFilter.Size = new Size(29, 21);
			buttonClearAuthorFilter.TabIndex = 41;
			buttonClearAuthorFilter.UseVisualStyleBackColor = true;
			buttonClearAuthorFilter.Click += buttonClearAuthorFilter_Click;
			// 
			// buttonClearGenreFilter
			// 
			buttonClearGenreFilter.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearGenreFilter.FlatAppearance.BorderSize = 0;
			buttonClearGenreFilter.FlatStyle = FlatStyle.Flat;
			buttonClearGenreFilter.Image = (Image)resources.GetObject("buttonClearGenreFilter.Image");
			buttonClearGenreFilter.Location = new Point(113, 51);
			buttonClearGenreFilter.Name = "buttonClearGenreFilter";
			buttonClearGenreFilter.Size = new Size(29, 21);
			buttonClearGenreFilter.TabIndex = 40;
			buttonClearGenreFilter.UseVisualStyleBackColor = true;
			buttonClearGenreFilter.Click += buttonClearGenreFilter_Click;
			// 
			// comboGenreView
			// 
			comboGenreView.Font = new Font("Segoe UI", 9.75F);
			comboGenreView.FormattingEnabled = true;
			comboGenreView.Location = new Point(12, 75);
			comboGenreView.Name = "comboGenreView";
			comboGenreView.Size = new Size(130, 25);
			comboGenreView.TabIndex = 39;
			comboGenreView.SelectedIndexChanged += comboGenreView_SelectedIndexChanged;
			// 
			// comboAuthorView
			// 
			comboAuthorView.Font = new Font("Segoe UI", 9.75F);
			comboAuthorView.FormattingEnabled = true;
			comboAuthorView.Location = new Point(12, 140);
			comboAuthorView.Name = "comboAuthorView";
			comboAuthorView.Size = new Size(130, 25);
			comboAuthorView.TabIndex = 38;
			comboAuthorView.SelectedIndexChanged += comboAuthorView_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.BackColor = Color.FromArgb(17, 24, 34);
			label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label8.ForeColor = Color.Gold;
			label8.Location = new Point(7, 116);
			label8.Name = "label8";
			label8.Size = new Size(125, 21);
			label8.TabIndex = 16;
			label8.Text = "Author";
			// 
			// label7
			// 
			label7.BackColor = Color.FromArgb(17, 24, 34);
			label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			label7.ForeColor = Color.Gold;
			label7.Location = new Point(7, 51);
			label7.Name = "label7";
			label7.Size = new Size(125, 21);
			label7.TabIndex = 15;
			label7.Text = "Genre";
			// 
			// label6
			// 
			label6.BackColor = Color.FromArgb(17, 24, 34);
			label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Gold;
			label6.Location = new Point(3, 17);
			label6.Name = "label6";
			label6.Size = new Size(143, 21);
			label6.TabIndex = 14;
			label6.Text = "View";
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
			buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
			buttonDelete.Location = new Point(12, 407);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(125, 53);
			buttonDelete.TabIndex = 10;
			buttonDelete.Text = "Delete";
			buttonDelete.TextAlign = ContentAlignment.MiddleRight;
			buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
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
			buttonUpdate.Location = new Point(12, 330);
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.Size = new Size(125, 53);
			buttonUpdate.TabIndex = 9;
			buttonUpdate.Text = "Update";
			buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
			buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
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
			buttonAdd.Location = new Point(12, 253);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(125, 53);
			buttonAdd.TabIndex = 8;
			buttonAdd.Text = "Add";
			buttonAdd.TextAlign = ContentAlignment.MiddleRight;
			buttonAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonAdd.UseVisualStyleBackColor = false;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// ManageBooksForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 24, 34);
			ClientSize = new Size(1003, 600);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Controls.Add(panel3);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageBooksForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageBooksForm";
			Load += ManageBooksForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numCopies).EndInit();
			((System.ComponentModel.ISupportInitialize)picCover).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)dgBooks).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button buttonClearSearch;
		private PictureBox pictureBox2;
		private TextBox textSearch;
		private RichTextBox textAbout;
		private Label labelAbout;
		private Label labelPrice;
		private Label labelCopies;
		private TextBox textISBN;
		private Label labelISBN;
		private TextBox textYear;
		private Label labelYear;
		private Label labelAuthor;
		private DataGridView dgBooks;
		private TextBox textTitle;
		private TextBox textId;
		private Label labelTitle;
		private Label labelId;
		private PictureBox pictureBox1;
		private Label labelHeader;
		private Panel panel2;
		private Button buttonClose;
		private Panel panel3;
		private Button buttonDelete;
		private Button buttonUpdate;
		private Button buttonAdd;
		private ComboBox comboAuthors;
		private TextBox textPrice;
		private PictureBox picCover;
		private Label labelCover;
		private Button buttonAddCover;
		private TextBox textPublisher;
		private Label labelPublisher;
		private Label labelDateReceived;
		private DateTimePicker dateReceived;
		private ComboBox comboGenres;
		private Label labelGenre;
		private NumericUpDown numCopies;
		private OpenFileDialog openFileBookImage;
		private Label labelCoverFileName;
		private Label labelStatus;
		private Label label2;
		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private ComboBox comboAuthorView;
		private ComboBox comboGenreView;
		private Button buttonClearGenreFilter;
		private Button buttonClearAuthorFilter;
	}
}