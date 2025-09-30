namespace LibraryManagementSystem.Forms
{
	partial class ManageGenresForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGenresForm));
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			panelMain = new Panel();
			labelBooksCount = new Label();
			label1 = new Label();
			label3 = new Label();
			buttonShowGenreBooks = new Button();
			buttonDelete = new Button();
			buttonUpdate = new Button();
			buttonAdd = new Button();
			dgGenres = new DataGridView();
			textName = new TextBox();
			textId = new TextBox();
			labelName = new Label();
			labelId = new Label();
			panelHeader = new Panel();
			labelStatus = new Label();
			picHeaderLogo = new PictureBox();
			buttonClose = new Button();
			labelHeader = new Label();
			panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgGenres).BeginInit();
			panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picHeaderLogo).BeginInit();
			SuspendLayout();
			// 
			// panelMain
			// 
			panelMain.BackColor = Color.Silver;
			panelMain.Controls.Add(labelBooksCount);
			panelMain.Controls.Add(label1);
			panelMain.Controls.Add(label3);
			panelMain.Controls.Add(buttonShowGenreBooks);
			panelMain.Controls.Add(buttonDelete);
			panelMain.Controls.Add(buttonUpdate);
			panelMain.Controls.Add(buttonAdd);
			panelMain.Controls.Add(dgGenres);
			panelMain.Controls.Add(textName);
			panelMain.Controls.Add(textId);
			panelMain.Controls.Add(labelName);
			panelMain.Controls.Add(labelId);
			panelMain.Location = new Point(6, 78);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(730, 264);
			panelMain.TabIndex = 2;
			// 
			// labelBooksCount
			// 
			labelBooksCount.BackColor = Color.Silver;
			labelBooksCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelBooksCount.ForeColor = Color.DarkBlue;
			labelBooksCount.Location = new Point(193, 220);
			labelBooksCount.Name = "labelBooksCount";
			labelBooksCount.Size = new Size(175, 21);
			labelBooksCount.TabIndex = 9;
			labelBooksCount.Text = "books";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.White;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.DarkBlue;
			label1.Location = new Point(353, 70);
			label1.Name = "label1";
			label1.Size = new Size(15, 20);
			label1.TabIndex = 29;
			label1.Text = "*";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Silver;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DarkBlue;
			label3.Location = new Point(294, 104);
			label3.Name = "label3";
			label3.Size = new Size(79, 20);
			label3.TabIndex = 4;
			label3.Text = "* Required";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// buttonShowGenreBooks
			// 
			buttonShowGenreBooks.BackColor = Color.Silver;
			buttonShowGenreBooks.BackgroundImageLayout = ImageLayout.None;
			buttonShowGenreBooks.Cursor = Cursors.Hand;
			buttonShowGenreBooks.FlatAppearance.BorderSize = 0;
			buttonShowGenreBooks.FlatStyle = FlatStyle.Flat;
			buttonShowGenreBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonShowGenreBooks.ForeColor = Color.DarkBlue;
			buttonShowGenreBooks.Image = (Image)resources.GetObject("buttonShowGenreBooks.Image");
			buttonShowGenreBooks.ImageAlign = ContentAlignment.MiddleLeft;
			buttonShowGenreBooks.Location = new Point(20, 203);
			buttonShowGenreBooks.Name = "buttonShowGenreBooks";
			buttonShowGenreBooks.Size = new Size(167, 53);
			buttonShowGenreBooks.TabIndex = 8;
			buttonShowGenreBooks.Text = "View Books";
			buttonShowGenreBooks.TextAlign = ContentAlignment.MiddleRight;
			buttonShowGenreBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonShowGenreBooks.UseVisualStyleBackColor = false;
			buttonShowGenreBooks.Click += buttonShowGenreBooks_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.LightCoral;
			buttonDelete.BackgroundImageLayout = ImageLayout.None;
			buttonDelete.Cursor = Cursors.Hand;
			buttonDelete.FlatAppearance.BorderSize = 0;
			buttonDelete.FlatStyle = FlatStyle.Flat;
			buttonDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonDelete.ForeColor = Color.DarkBlue;
			buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
			buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
			buttonDelete.Location = new Point(255, 132);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(118, 53);
			buttonDelete.TabIndex = 7;
			buttonDelete.Text = "Delete";
			buttonDelete.TextAlign = ContentAlignment.MiddleRight;
			buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonUpdate
			// 
			buttonUpdate.BackColor = Color.Transparent;
			buttonUpdate.BackgroundImageLayout = ImageLayout.None;
			buttonUpdate.Cursor = Cursors.Hand;
			buttonUpdate.FlatAppearance.BorderSize = 0;
			buttonUpdate.FlatStyle = FlatStyle.Flat;
			buttonUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonUpdate.ForeColor = Color.DarkBlue;
			buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
			buttonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
			buttonUpdate.Location = new Point(127, 132);
			buttonUpdate.Name = "buttonUpdate";
			buttonUpdate.Size = new Size(129, 53);
			buttonUpdate.TabIndex = 6;
			buttonUpdate.Text = "Update";
			buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
			buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonUpdate.UseVisualStyleBackColor = false;
			buttonUpdate.Click += buttonUpdate_Click;
			// 
			// buttonAdd
			// 
			buttonAdd.BackColor = Color.Transparent;
			buttonAdd.BackgroundImageLayout = ImageLayout.None;
			buttonAdd.Cursor = Cursors.Hand;
			buttonAdd.FlatAppearance.BorderSize = 0;
			buttonAdd.FlatStyle = FlatStyle.Flat;
			buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonAdd.ForeColor = Color.DarkBlue;
			buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
			buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
			buttonAdd.Location = new Point(20, 132);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(101, 53);
			buttonAdd.TabIndex = 5;
			buttonAdd.Text = "Add";
			buttonAdd.TextAlign = ContentAlignment.MiddleRight;
			buttonAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonAdd.UseVisualStyleBackColor = false;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// dgGenres
			// 
			dgGenres.AllowUserToAddRows = false;
			dgGenres.AllowUserToDeleteRows = false;
			dgGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgGenres.BackgroundColor = Color.Silver;
			dgGenres.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = Color.DarkBlue;
			dataGridViewCellStyle16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle16.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
			dgGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			dgGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgGenres.Location = new Point(400, 24);
			dgGenres.MultiSelect = false;
			dgGenres.Name = "dgGenres";
			dgGenres.ReadOnly = true;
			dgGenres.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = Color.DarkBlue;
			dataGridViewCellStyle17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle17.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
			dgGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
			dgGenres.RowHeadersVisible = false;
			dataGridViewCellStyle18.BackColor = Color.Silver;
			dataGridViewCellStyle18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle18.ForeColor = Color.Black;
			dataGridViewCellStyle18.SelectionBackColor = Color.RoyalBlue;
			dgGenres.RowsDefaultCellStyle = dataGridViewCellStyle18;
			dgGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgGenres.ShowEditingIcon = false;
			dgGenres.Size = new Size(306, 213);
			dgGenres.TabIndex = 4;
			dgGenres.CellClick += dgGenres_CellClick;
			// 
			// textName
			// 
			textName.Font = new Font("Segoe UI", 15.75F);
			textName.Location = new Point(118, 66);
			textName.Name = "textName";
			textName.Size = new Size(255, 35);
			textName.TabIndex = 3;
			textName.TextChanged += textName_TextChanged;
			// 
			// textId
			// 
			textId.Enabled = false;
			textId.Font = new Font("Segoe UI", 15.75F);
			textId.Location = new Point(118, 24);
			textId.MaxLength = 100;
			textId.Name = "textId";
			textId.Size = new Size(255, 35);
			textId.TabIndex = 1;
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelName.Location = new Point(20, 68);
			labelName.Name = "labelName";
			labelName.Size = new Size(74, 30);
			labelName.TabIndex = 2;
			labelName.Text = "Name:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelId.Location = new Point(55, 27);
			labelId.Name = "labelId";
			labelId.Size = new Size(39, 30);
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
			panelHeader.Location = new Point(6, 4);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(730, 70);
			panelHeader.TabIndex = 3;
			// 
			// labelStatus
			// 
			labelStatus.BackColor = Color.DarkBlue;
			labelStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelStatus.ForeColor = Color.Gold;
			labelStatus.Location = new Point(255, 34);
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(413, 21);
			labelStatus.TabIndex = 13;
			labelStatus.Text = "status";
			// 
			// picHeaderLogo
			// 
			picHeaderLogo.BackColor = Color.Transparent;
			picHeaderLogo.Image = (Image)resources.GetObject("picHeaderLogo.Image");
			picHeaderLogo.Location = new Point(7, 7);
			picHeaderLogo.Name = "picHeaderLogo";
			picHeaderLogo.Size = new Size(59, 59);
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
			buttonClose.Location = new Point(693, 3);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(34, 32);
			buttonClose.TabIndex = 10;
			buttonClose.UseVisualStyleBackColor = false;
			buttonClose.Click += buttonClose_Click;
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
			labelHeader.Text = "Genres";
			labelHeader.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// ManageGenresForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 24, 34);
			ClientSize = new Size(740, 350);
			Controls.Add(panelHeader);
			Controls.Add(panelMain);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageGenresForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageGenresForm";
			Load += ManageGenresForm_Load;
			panelMain.ResumeLayout(false);
			panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgGenres).EndInit();
			panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picHeaderLogo).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel panelMain;
		private Panel panelHeader;
		private Button buttonClose;
		private Label labelHeader;
		private PictureBox picHeaderLogo;
		private Label labelId;
		private Label labelName;
		private TextBox textName;
		private TextBox textId;
		private DataGridView dgGenres;
		private Button buttonAdd;
		private Button buttonUpdate;
		private Button buttonDelete;
		private Button buttonShowGenreBooks;
		private Label labelStatus;
		private Label label3;
		private Label label1;
		private Label labelBooksCount;
	}
}