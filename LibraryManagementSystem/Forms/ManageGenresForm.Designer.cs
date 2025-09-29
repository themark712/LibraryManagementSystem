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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			panel1 = new Panel();
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
			panel2 = new Panel();
			labelStatus = new Label();
			pictureBox1 = new PictureBox();
			buttonClose = new Button();
			labelHeader = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgGenres).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Silver;
			panel1.Controls.Add(label1);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(buttonShowGenreBooks);
			panel1.Controls.Add(buttonDelete);
			panel1.Controls.Add(buttonUpdate);
			panel1.Controls.Add(buttonAdd);
			panel1.Controls.Add(dgGenres);
			panel1.Controls.Add(textName);
			panel1.Controls.Add(textId);
			panel1.Controls.Add(labelName);
			panel1.Controls.Add(labelId);
			panel1.Location = new Point(6, 78);
			panel1.Name = "panel1";
			panel1.Size = new Size(730, 264);
			panel1.TabIndex = 2;
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
			label3.TabIndex = 28;
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
			buttonShowGenreBooks.TabIndex = 12;
			buttonShowGenreBooks.Text = "View Books";
			buttonShowGenreBooks.TextAlign = ContentAlignment.MiddleRight;
			buttonShowGenreBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonShowGenreBooks.UseVisualStyleBackColor = false;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.Transparent;
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
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.DarkBlue;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dgGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgGenres.Location = new Point(400, 24);
			dgGenres.MultiSelect = false;
			dgGenres.Name = "dgGenres";
			dgGenres.ReadOnly = true;
			dgGenres.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.DarkBlue;
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dgGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dgGenres.RowHeadersVisible = false;
			dataGridViewCellStyle6.BackColor = Color.Silver;
			dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle6.ForeColor = Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = Color.RoyalBlue;
			dgGenres.RowsDefaultCellStyle = dataGridViewCellStyle6;
			dgGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
			textId.TabIndex = 2;
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelName.Location = new Point(20, 68);
			labelName.Name = "labelName";
			labelName.Size = new Size(74, 30);
			labelName.TabIndex = 1;
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
			// panel2
			// 
			panel2.BackColor = Color.DarkBlue;
			panel2.Controls.Add(labelStatus);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(buttonClose);
			panel2.Controls.Add(labelHeader);
			panel2.Location = new Point(6, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(730, 70);
			panel2.TabIndex = 3;
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
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(7, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(59, 59);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 11;
			pictureBox1.TabStop = false;
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
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageGenresForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageGenresForm";
			Load += ManageGenresForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgGenres).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
		private Panel panel2;
		private Button buttonClose;
		private Label labelHeader;
		private PictureBox pictureBox1;
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
	}
}