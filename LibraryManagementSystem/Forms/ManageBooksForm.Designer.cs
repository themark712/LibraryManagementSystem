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
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooksForm));
			panel1 = new Panel();
			textPrice = new TextBox();
			comboAuthors = new ComboBox();
			buttonClearSearch = new Button();
			pictureBox2 = new PictureBox();
			textSearch = new TextBox();
			textAbout = new RichTextBox();
			labelAbout = new Label();
			labelPrice = new Label();
			labelCopies = new Label();
			textDOD = new TextBox();
			labelISBN = new Label();
			textDOB = new TextBox();
			labelYear = new Label();
			labelAuthor = new Label();
			labelStatus = new Label();
			dgAuthors = new DataGridView();
			textFirstName = new TextBox();
			textId = new TextBox();
			labelTitle = new Label();
			labelId = new Label();
			pictureBox1 = new PictureBox();
			labelHeader = new Label();
			panel2 = new Panel();
			buttonClose = new Button();
			panel3 = new Panel();
			buttonDelete = new Button();
			buttonUpdate = new Button();
			buttonAdd = new Button();
			picCover = new PictureBox();
			labelCover = new Label();
			buttonAddCover = new Button();
			textPublisher = new TextBox();
			labelPublisher = new Label();
			labelDateReceived = new Label();
			dateTimePicker1 = new DateTimePicker();
			comboGenre = new ComboBox();
			labelGenre = new Label();
			numCopies = new NumericUpDown();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgAuthors).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picCover).BeginInit();
			((System.ComponentModel.ISupportInitialize)numCopies).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Silver;
			panel1.Controls.Add(numCopies);
			panel1.Controls.Add(comboGenre);
			panel1.Controls.Add(labelGenre);
			panel1.Controls.Add(dateTimePicker1);
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
			panel1.Controls.Add(textDOD);
			panel1.Controls.Add(labelISBN);
			panel1.Controls.Add(textDOB);
			panel1.Controls.Add(labelYear);
			panel1.Controls.Add(labelAuthor);
			panel1.Controls.Add(labelStatus);
			panel1.Controls.Add(dgAuthors);
			panel1.Controls.Add(textFirstName);
			panel1.Controls.Add(textId);
			panel1.Controls.Add(labelTitle);
			panel1.Controls.Add(labelId);
			panel1.Location = new Point(160, 80);
			panel1.Name = "panel1";
			panel1.Size = new Size(837, 508);
			panel1.TabIndex = 7;
			// 
			// textPrice
			// 
			textPrice.Font = new Font("Segoe UI", 12F);
			textPrice.Location = new Point(126, 307);
			textPrice.MaxLength = 100;
			textPrice.Name = "textPrice";
			textPrice.Size = new Size(243, 29);
			textPrice.TabIndex = 26;
			// 
			// comboAuthors
			// 
			comboAuthors.Font = new Font("Segoe UI", 12F);
			comboAuthors.FormattingEnabled = true;
			comboAuthors.Location = new Point(127, 94);
			comboAuthors.Name = "comboAuthors";
			comboAuthors.Size = new Size(242, 29);
			comboAuthors.TabIndex = 25;
			comboAuthors.SelectedIndexChanged += comboAuthors_SelectedIndexChanged;
			// 
			// buttonClearSearch
			// 
			buttonClearSearch.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearSearch.Location = new Point(787, 17);
			buttonClearSearch.Name = "buttonClearSearch";
			buttonClearSearch.Size = new Size(35, 35);
			buttonClearSearch.TabIndex = 24;
			buttonClearSearch.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(405, 17);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(35, 35);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 23;
			pictureBox2.TabStop = false;
			// 
			// textSearch
			// 
			textSearch.Font = new Font("Segoe UI", 12F);
			textSearch.Location = new Point(446, 17);
			textSearch.MaxLength = 100;
			textSearch.Name = "textSearch";
			textSearch.Size = new Size(335, 29);
			textSearch.TabIndex = 22;
			// 
			// textAbout
			// 
			textAbout.Font = new Font("Segoe UI", 12F);
			textAbout.Location = new Point(127, 342);
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
			labelAbout.Location = new Point(66, 341);
			labelAbout.Name = "labelAbout";
			labelAbout.Size = new Size(55, 21);
			labelAbout.TabIndex = 19;
			labelAbout.Text = "About:";
			// 
			// labelPrice
			// 
			labelPrice.AutoSize = true;
			labelPrice.Font = new Font("Segoe UI", 12F);
			labelPrice.Location = new Point(74, 309);
			labelPrice.Name = "labelPrice";
			labelPrice.Size = new Size(47, 21);
			labelPrice.TabIndex = 17;
			labelPrice.Text = "Price:";
			// 
			// labelCopies
			// 
			labelCopies.AutoSize = true;
			labelCopies.Font = new Font("Segoe UI", 12F);
			labelCopies.Location = new Point(61, 273);
			labelCopies.Name = "labelCopies";
			labelCopies.Size = new Size(60, 21);
			labelCopies.TabIndex = 15;
			labelCopies.Text = "Copies:";
			// 
			// textDOD
			// 
			textDOD.Font = new Font("Segoe UI", 12F);
			textDOD.Location = new Point(127, 235);
			textDOD.Name = "textDOD";
			textDOD.Size = new Size(243, 29);
			textDOD.TabIndex = 14;
			// 
			// labelISBN
			// 
			labelISBN.AutoSize = true;
			labelISBN.Font = new Font("Segoe UI", 12F);
			labelISBN.Location = new Point(74, 237);
			labelISBN.Name = "labelISBN";
			labelISBN.Size = new Size(47, 21);
			labelISBN.TabIndex = 13;
			labelISBN.Text = "ISBN:";
			// 
			// textDOB
			// 
			textDOB.Font = new Font("Segoe UI", 12F);
			textDOB.Location = new Point(127, 164);
			textDOB.Name = "textDOB";
			textDOB.Size = new Size(243, 29);
			textDOB.TabIndex = 12;
			// 
			// labelYear
			// 
			labelYear.AutoSize = true;
			labelYear.Font = new Font("Segoe UI", 12F);
			labelYear.Location = new Point(78, 166);
			labelYear.Name = "labelYear";
			labelYear.Size = new Size(43, 21);
			labelYear.TabIndex = 11;
			labelYear.Text = "Year:";
			// 
			// labelAuthor
			// 
			labelAuthor.AutoSize = true;
			labelAuthor.Font = new Font("Segoe UI", 12F);
			labelAuthor.Location = new Point(60, 96);
			labelAuthor.Name = "labelAuthor";
			labelAuthor.Size = new Size(61, 21);
			labelAuthor.TabIndex = 9;
			labelAuthor.Text = "Author:";
			// 
			// labelStatus
			// 
			labelStatus.AutoSize = true;
			labelStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelStatus.ForeColor = Color.DarkBlue;
			labelStatus.Location = new Point(405, 433);
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(0, 21);
			labelStatus.TabIndex = 8;
			// 
			// dgAuthors
			// 
			dgAuthors.AllowUserToAddRows = false;
			dgAuthors.AllowUserToDeleteRows = false;
			dgAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgAuthors.BackgroundColor = Color.Silver;
			dgAuthors.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = Color.DarkBlue;
			dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			dgAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dgAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgAuthors.Location = new Point(405, 351);
			dgAuthors.MultiSelect = false;
			dgAuthors.Name = "dgAuthors";
			dgAuthors.ReadOnly = true;
			dgAuthors.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = Color.DarkBlue;
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
			dgAuthors.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			dgAuthors.RowHeadersVisible = false;
			dataGridViewCellStyle9.BackColor = Color.Silver;
			dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle9.ForeColor = Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = Color.RoyalBlue;
			dgAuthors.RowsDefaultCellStyle = dataGridViewCellStyle9;
			dgAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgAuthors.Size = new Size(417, 106);
			dgAuthors.TabIndex = 0;
			// 
			// textFirstName
			// 
			textFirstName.Font = new Font("Segoe UI", 12F);
			textFirstName.Location = new Point(127, 58);
			textFirstName.MaxLength = 100;
			textFirstName.Name = "textFirstName";
			textFirstName.Size = new Size(243, 29);
			textFirstName.TabIndex = 3;
			// 
			// textId
			// 
			textId.Enabled = false;
			textId.Font = new Font("Segoe UI", 12F);
			textId.Location = new Point(127, 24);
			textId.MaxLength = 100;
			textId.Name = "textId";
			textId.Size = new Size(242, 29);
			textId.TabIndex = 2;
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Segoe UI", 12F);
			labelTitle.Location = new Point(79, 60);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(42, 21);
			labelTitle.TabIndex = 1;
			labelTitle.Text = "Title:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Font = new Font("Segoe UI", 12F);
			labelId.Location = new Point(93, 27);
			labelId.Name = "labelId";
			labelId.Size = new Size(28, 21);
			labelId.TabIndex = 0;
			labelId.Text = "ID:";
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
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(buttonClose);
			panel2.Controls.Add(labelHeader);
			panel2.Location = new Point(5, 5);
			panel2.Name = "panel2";
			panel2.Size = new Size(992, 70);
			panel2.TabIndex = 8;
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
			panel3.Controls.Add(buttonDelete);
			panel3.Controls.Add(buttonUpdate);
			panel3.Controls.Add(buttonAdd);
			panel3.Location = new Point(5, 77);
			panel3.Name = "panel3";
			panel3.Size = new Size(149, 424);
			panel3.TabIndex = 9;
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
			buttonDelete.Location = new Point(12, 184);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(125, 53);
			buttonDelete.TabIndex = 10;
			buttonDelete.Text = "Delete";
			buttonDelete.TextAlign = ContentAlignment.MiddleRight;
			buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonDelete.UseVisualStyleBackColor = false;
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
			buttonUpdate.Location = new Point(12, 107);
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.Size = new Size(125, 53);
			buttonUpdate.TabIndex = 9;
			buttonUpdate.Text = "Update";
			buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
			buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonUpdate.UseVisualStyleBackColor = false;
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
			buttonAdd.Location = new Point(12, 30);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(125, 53);
			buttonAdd.TabIndex = 8;
			buttonAdd.Text = "Add";
			buttonAdd.TextAlign = ContentAlignment.MiddleRight;
			buttonAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonAdd.UseVisualStyleBackColor = false;
			// 
			// picCover
			// 
			picCover.Location = new Point(599, 88);
			picCover.Name = "picCover";
			picCover.Size = new Size(223, 226);
			picCover.TabIndex = 27;
			picCover.TabStop = false;
			// 
			// labelCover
			// 
			labelCover.AutoSize = true;
			labelCover.Font = new Font("Segoe UI", 14.25F);
			labelCover.Location = new Point(599, 60);
			labelCover.Name = "labelCover";
			labelCover.Size = new Size(65, 25);
			labelCover.TabIndex = 28;
			labelCover.Text = "Cover:";
			// 
			// buttonAddCover
			// 
			buttonAddCover.Image = (Image)resources.GetObject("buttonAddCover.Image");
			buttonAddCover.Location = new Point(598, 332);
			buttonAddCover.Name = "buttonAddCover";
			buttonAddCover.Size = new Size(224, 44);
			buttonAddCover.TabIndex = 29;
			buttonAddCover.Text = "Select Cover";
			buttonAddCover.TextAlign = ContentAlignment.MiddleRight;
			buttonAddCover.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonAddCover.UseVisualStyleBackColor = true;
			// 
			// textPublisher
			// 
			textPublisher.Font = new Font("Segoe UI", 12F);
			textPublisher.Location = new Point(127, 199);
			textPublisher.MaxLength = 100;
			textPublisher.Name = "textPublisher";
			textPublisher.Size = new Size(243, 29);
			textPublisher.TabIndex = 31;
			// 
			// labelPublisher
			// 
			labelPublisher.AutoSize = true;
			labelPublisher.Font = new Font("Segoe UI", 12F);
			labelPublisher.Location = new Point(43, 201);
			labelPublisher.Name = "labelPublisher";
			labelPublisher.Size = new Size(78, 21);
			labelPublisher.TabIndex = 30;
			labelPublisher.Text = "Publisher:";
			// 
			// labelDateReceived
			// 
			labelDateReceived.AutoSize = true;
			labelDateReceived.Font = new Font("Segoe UI", 12F);
			labelDateReceived.Location = new Point(10, 440);
			labelDateReceived.Name = "labelDateReceived";
			labelDateReceived.Size = new Size(111, 21);
			labelDateReceived.TabIndex = 32;
			labelDateReceived.Text = "Date Received:";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dateTimePicker1.Location = new Point(127, 437);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(243, 27);
			dateTimePicker1.TabIndex = 33;
			// 
			// comboGenre
			// 
			comboGenre.Font = new Font("Segoe UI", 12F);
			comboGenre.FormattingEnabled = true;
			comboGenre.Location = new Point(128, 129);
			comboGenre.Name = "comboGenre";
			comboGenre.Size = new Size(242, 29);
			comboGenre.TabIndex = 35;
			// 
			// labelGenre
			// 
			labelGenre.AutoSize = true;
			labelGenre.Font = new Font("Segoe UI", 12F);
			labelGenre.Location = new Point(66, 131);
			labelGenre.Name = "labelGenre";
			labelGenre.Size = new Size(55, 21);
			labelGenre.TabIndex = 34;
			labelGenre.Text = "Genre:";
			// 
			// numCopies
			// 
			numCopies.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			numCopies.Location = new Point(128, 271);
			numCopies.Name = "numCopies";
			numCopies.Size = new Size(120, 29);
			numCopies.TabIndex = 36;
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
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)dgAuthors).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picCover).EndInit();
			((System.ComponentModel.ISupportInitialize)numCopies).EndInit();
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
		private TextBox textDOD;
		private Label labelISBN;
		private TextBox textDOB;
		private Label labelYear;
		private Label labelAuthor;
		private Label labelStatus;
		private DataGridView dgAuthors;
		private TextBox textFirstName;
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
		private DateTimePicker dateTimePicker1;
		private ComboBox comboGenre;
		private Label labelGenre;
		private NumericUpDown numCopies;
	}
}