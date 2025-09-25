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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			panel1 = new Panel();
			labelStatus = new Label();
			buttonDelete = new Button();
			buttonUpdate = new Button();
			buttonAdd = new Button();
			dgGenres = new DataGridView();
			textName = new TextBox();
			textId = new TextBox();
			labelName = new Label();
			labelId = new Label();
			panel2 = new Panel();
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
			panel1.Controls.Add(labelStatus);
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
			// labelStatus
			// 
			labelStatus.AutoSize = true;
			labelStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelStatus.ForeColor = Color.DarkBlue;
			labelStatus.Location = new Point(20, 222);
			labelStatus.Name = "labelStatus";
			labelStatus.Size = new Size(0, 21);
			labelStatus.TabIndex = 8;
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
			buttonDelete.Location = new Point(255, 144);
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
			buttonUpdate.Location = new Point(127, 144);
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
			buttonAdd.Location = new Point(20, 144);
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
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.DarkBlue;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgGenres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgGenres.Location = new Point(400, 24);
			dgGenres.MultiSelect = false;
			dgGenres.Name = "dgGenres";
			dgGenres.ReadOnly = true;
			dgGenres.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.DarkBlue;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dgGenres.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgGenres.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = Color.Silver;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
			dgGenres.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
			labelId.Location = new Point(20, 26);
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
			panel2.Location = new Point(6, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(726, 70);
			panel2.TabIndex = 3;
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
			buttonClose.Location = new Point(685, 6);
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
		private Label labelStatus;
	}
}