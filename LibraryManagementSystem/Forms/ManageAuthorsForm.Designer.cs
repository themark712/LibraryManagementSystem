namespace LibraryManagementSystem.Forms
{
	partial class ManageAuthorsForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAuthorsForm));
			labelHeader = new Label();
			panel1 = new Panel();
			pictureBox2 = new PictureBox();
			textSearch = new TextBox();
			textAbout = new RichTextBox();
			textEduction = new RichTextBox();
			labelAbout = new Label();
			labelEducation = new Label();
			textHometown = new TextBox();
			labelHometown = new Label();
			textDOD = new TextBox();
			labelDOD = new Label();
			textDOB = new TextBox();
			labelDOB = new Label();
			textLastName = new TextBox();
			labelLastName = new Label();
			labelStatus = new Label();
			dgAuthors = new DataGridView();
			textFirstName = new TextBox();
			textId = new TextBox();
			labelFirstName = new Label();
			labelId = new Label();
			panel2 = new Panel();
			pictureBox1 = new PictureBox();
			buttonClose = new Button();
			panel3 = new Panel();
			buttonDelete = new Button();
			buttonUpdate = new Button();
			buttonAdd = new Button();
			buttonClearSearch = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgAuthors).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel3.SuspendLayout();
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
			labelHeader.Text = "Authors";
			labelHeader.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Silver;
			panel1.Controls.Add(buttonClearSearch);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(textSearch);
			panel1.Controls.Add(textAbout);
			panel1.Controls.Add(textEduction);
			panel1.Controls.Add(labelAbout);
			panel1.Controls.Add(labelEducation);
			panel1.Controls.Add(textHometown);
			panel1.Controls.Add(labelHometown);
			panel1.Controls.Add(textDOD);
			panel1.Controls.Add(labelDOD);
			panel1.Controls.Add(textDOB);
			panel1.Controls.Add(labelDOB);
			panel1.Controls.Add(textLastName);
			panel1.Controls.Add(labelLastName);
			panel1.Controls.Add(labelStatus);
			panel1.Controls.Add(dgAuthors);
			panel1.Controls.Add(textFirstName);
			panel1.Controls.Add(textId);
			panel1.Controls.Add(labelFirstName);
			panel1.Controls.Add(labelId);
			panel1.Location = new Point(159, 78);
			panel1.Name = "panel1";
			panel1.Size = new Size(773, 421);
			panel1.TabIndex = 4;
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
			textSearch.Font = new Font("Segoe UI", 15.75F);
			textSearch.Location = new Point(446, 17);
			textSearch.MaxLength = 100;
			textSearch.Name = "textSearch";
			textSearch.Size = new Size(245, 35);
			textSearch.TabIndex = 22;
			textSearch.TextChanged += textSearch_TextChanged;
			// 
			// textAbout
			// 
			textAbout.Location = new Point(143, 339);
			textAbout.Name = "textAbout";
			textAbout.Size = new Size(243, 51);
			textAbout.TabIndex = 21;
			textAbout.Text = "";
			// 
			// textEduction
			// 
			textEduction.Location = new Point(143, 281);
			textEduction.Name = "textEduction";
			textEduction.Size = new Size(242, 52);
			textEduction.TabIndex = 20;
			textEduction.Text = "";
			// 
			// labelAbout
			// 
			labelAbout.AutoSize = true;
			labelAbout.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelAbout.Location = new Point(57, 339);
			labelAbout.Name = "labelAbout";
			labelAbout.Size = new Size(75, 30);
			labelAbout.TabIndex = 19;
			labelAbout.Text = "About:";
			// 
			// labelEducation
			// 
			labelEducation.AutoSize = true;
			labelEducation.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelEducation.Location = new Point(22, 281);
			labelEducation.Name = "labelEducation";
			labelEducation.Size = new Size(110, 30);
			labelEducation.TabIndex = 17;
			labelEducation.Text = "Education:";
			// 
			// textHometown
			// 
			textHometown.Font = new Font("Segoe UI", 15.75F);
			textHometown.Location = new Point(143, 240);
			textHometown.Name = "textHometown";
			textHometown.Size = new Size(243, 35);
			textHometown.TabIndex = 16;
			// 
			// labelHometown
			// 
			labelHometown.AutoSize = true;
			labelHometown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelHometown.Location = new Point(12, 241);
			labelHometown.Name = "labelHometown";
			labelHometown.Size = new Size(120, 30);
			labelHometown.TabIndex = 15;
			labelHometown.Text = "Hometown:";
			// 
			// textDOD
			// 
			textDOD.Font = new Font("Segoe UI", 15.75F);
			textDOD.Location = new Point(143, 199);
			textDOD.Name = "textDOD";
			textDOD.Size = new Size(243, 35);
			textDOD.TabIndex = 14;
			// 
			// labelDOD
			// 
			labelDOD.AutoSize = true;
			labelDOD.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelDOD.Location = new Point(68, 200);
			labelDOD.Name = "labelDOD";
			labelDOD.Size = new Size(64, 30);
			labelDOD.TabIndex = 13;
			labelDOD.Text = "DOD:";
			// 
			// textDOB
			// 
			textDOB.Font = new Font("Segoe UI", 15.75F);
			textDOB.Location = new Point(143, 158);
			textDOB.Name = "textDOB";
			textDOB.Size = new Size(243, 35);
			textDOB.TabIndex = 12;
			// 
			// labelDOB
			// 
			labelDOB.AutoSize = true;
			labelDOB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelDOB.Location = new Point(71, 159);
			labelDOB.Name = "labelDOB";
			labelDOB.Size = new Size(61, 30);
			labelDOB.TabIndex = 11;
			labelDOB.Text = "DOB:";
			// 
			// textLastName
			// 
			textLastName.Font = new Font("Segoe UI", 15.75F);
			textLastName.Location = new Point(143, 117);
			textLastName.Name = "textLastName";
			textLastName.Size = new Size(243, 35);
			textLastName.TabIndex = 10;
			// 
			// labelLastName
			// 
			labelLastName.AutoSize = true;
			labelLastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelLastName.Location = new Point(15, 118);
			labelLastName.Name = "labelLastName";
			labelLastName.Size = new Size(117, 30);
			labelLastName.TabIndex = 9;
			labelLastName.Text = "Last Name:";
			// 
			// labelStatus
			// 
			labelStatus.AutoSize = true;
			labelStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelStatus.ForeColor = Color.DarkBlue;
			labelStatus.Location = new Point(405, 368);
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
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.DarkBlue;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgAuthors.Location = new Point(405, 73);
			dgAuthors.MultiSelect = false;
			dgAuthors.Name = "dgAuthors";
			dgAuthors.ReadOnly = true;
			dgAuthors.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.DarkBlue;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgAuthors.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgAuthors.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.Silver;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
			dgAuthors.RowsDefaultCellStyle = dataGridViewCellStyle3;
			dgAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgAuthors.Size = new Size(342, 316);
			dgAuthors.TabIndex = 0;
			dgAuthors.CellClick += dgAuthors_CellClick;
			// 
			// textFirstName
			// 
			textFirstName.Font = new Font("Segoe UI", 15.75F);
			textFirstName.Location = new Point(143, 76);
			textFirstName.Name = "textFirstName";
			textFirstName.Size = new Size(243, 35);
			textFirstName.TabIndex = 3;
			// 
			// textId
			// 
			textId.Enabled = false;
			textId.Font = new Font("Segoe UI", 15.75F);
			textId.Location = new Point(143, 35);
			textId.MaxLength = 100;
			textId.Name = "textId";
			textId.Size = new Size(242, 35);
			textId.TabIndex = 2;
			// 
			// labelFirstName
			// 
			labelFirstName.AutoSize = true;
			labelFirstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelFirstName.Location = new Point(14, 77);
			labelFirstName.Name = "labelFirstName";
			labelFirstName.Size = new Size(118, 30);
			labelFirstName.TabIndex = 1;
			labelFirstName.Text = "First Name:";
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelId.Location = new Point(93, 37);
			labelId.Name = "labelId";
			labelId.Size = new Size(39, 30);
			labelId.TabIndex = 0;
			labelId.Text = "ID:";
			// 
			// panel2
			// 
			panel2.BackColor = Color.DarkBlue;
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(buttonClose);
			panel2.Controls.Add(labelHeader);
			panel2.Location = new Point(4, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(928, 70);
			panel2.TabIndex = 5;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(7, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(67, 59);
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
			buttonClose.Location = new Point(891, 3);
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
			panel3.Location = new Point(4, 75);
			panel3.Name = "panel3";
			panel3.Size = new Size(149, 424);
			panel3.TabIndex = 6;
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
			buttonDelete.Location = new Point(12, 178);
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
			buttonUpdate.Location = new Point(12, 104);
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
			buttonAdd.Location = new Point(12, 30);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(125, 53);
			buttonAdd.TabIndex = 8;
			buttonAdd.Text = "Add";
			buttonAdd.TextAlign = ContentAlignment.MiddleRight;
			buttonAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonAdd.UseVisualStyleBackColor = false;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// buttonClearSearch
			// 
			buttonClearSearch.BackgroundImage = (Image)resources.GetObject("buttonClearSearch.BackgroundImage");
			buttonClearSearch.BackgroundImageLayout = ImageLayout.Stretch;
			buttonClearSearch.Location = new Point(712, 17);
			buttonClearSearch.Name = "buttonClearSearch";
			buttonClearSearch.Size = new Size(35, 35);
			buttonClearSearch.TabIndex = 24;
			buttonClearSearch.UseVisualStyleBackColor = true;
			buttonClearSearch.Click += buttonClearSearch_Click;
			// 
			// ManageAuthorsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 24, 34);
			ClientSize = new Size(939, 511);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageAuthorsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ManageAuthorsForm";
			Load += ManageAuthorsForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)dgAuthors).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label labelHeader;
		private Panel panel1;
		private Label labelStatus;
		private DataGridView dgAuthors;
		private TextBox textFirstName;
		private TextBox textId;
		private Label labelFirstName;
		private Label labelId;
		private Panel panel2;
		private PictureBox pictureBox1;
		private Button buttonClose;
		private Panel panel3;
		private Button buttonDelete;
		private Button buttonUpdate;
		private Button buttonAdd;
		private TextBox textLastName;
		private Label labelLastName;
		private Label labelAbout;
		private Label labelEducation;
		private TextBox textHometown;
		private Label labelHometown;
		private TextBox textDOD;
		private Label labelDOD;
		private TextBox textDOB;
		private Label labelDOB;
		private RichTextBox textAbout;
		private RichTextBox textEduction;
		private TextBox textSearch;
		private PictureBox pictureBox2;
		private Button buttonClearSearch;
	}
}