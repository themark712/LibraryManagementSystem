namespace LibraryManagementSystem.Forms
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			panel1 = new Panel();
			buttonClose = new Button();
			buttonLogin = new Button();
			textPassword = new TextBox();
			picPassword = new PictureBox();
			textUsername = new TextBox();
			picUser = new PictureBox();
			label1 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picPassword).BeginInit();
			((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(17, 24, 34);
			panel1.Controls.Add(buttonClose);
			panel1.Controls.Add(buttonLogin);
			panel1.Controls.Add(textPassword);
			panel1.Controls.Add(picPassword);
			panel1.Controls.Add(textUsername);
			panel1.Controls.Add(picUser);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(459, 333);
			panel1.TabIndex = 0;
			// 
			// buttonClose
			// 
			buttonClose.BackColor = Color.Transparent;
			buttonClose.Cursor = Cursors.Hand;
			buttonClose.FlatAppearance.BorderSize = 0;
			buttonClose.FlatStyle = FlatStyle.Flat;
			buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
			buttonClose.Location = new Point(422, 3);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(34, 32);
			buttonClose.TabIndex = 7;
			buttonClose.UseVisualStyleBackColor = false;
			buttonClose.Click += buttonClose_Click;
			// 
			// buttonLogin
			// 
			buttonLogin.BackColor = Color.DarkBlue;
			buttonLogin.Cursor = Cursors.Hand;
			buttonLogin.FlatStyle = FlatStyle.Flat;
			buttonLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			buttonLogin.ForeColor = Color.Silver;
			buttonLogin.Location = new Point(36, 238);
			buttonLogin.Name = "buttonLogin";
			buttonLogin.Size = new Size(385, 48);
			buttonLogin.TabIndex = 6;
			buttonLogin.Text = "Login";
			buttonLogin.UseVisualStyleBackColor = false;
			buttonLogin.Click += buttonLogin_Click;
			// 
			// textPassword
			// 
			textPassword.BackColor = Color.Silver;
			textPassword.Font = new Font("Microsoft Sans Serif", 20.25F);
			textPassword.Location = new Point(92, 171);
			textPassword.MaxLength = 25;
			textPassword.Name = "textPassword";
			textPassword.PasswordChar = '*';
			textPassword.Size = new Size(329, 38);
			textPassword.TabIndex = 5;
			// 
			// picPassword
			// 
			picPassword.BackColor = Color.FromArgb(64, 64, 64);
			picPassword.Image = (Image)resources.GetObject("picPassword.Image");
			picPassword.Location = new Point(36, 169);
			picPassword.Name = "picPassword";
			picPassword.Size = new Size(42, 40);
			picPassword.SizeMode = PictureBoxSizeMode.StretchImage;
			picPassword.TabIndex = 4;
			picPassword.TabStop = false;
			// 
			// textUsername
			// 
			textUsername.BackColor = Color.Silver;
			textUsername.Font = new Font("Microsoft Sans Serif", 20.25F);
			textUsername.Location = new Point(92, 110);
			textUsername.MaxLength = 25;
			textUsername.Name = "textUsername";
			textUsername.Size = new Size(329, 38);
			textUsername.TabIndex = 3;
			// 
			// picUser
			// 
			picUser.BackColor = Color.FromArgb(64, 64, 64);
			picUser.Image = (Image)resources.GetObject("picUser.Image");
			picUser.Location = new Point(36, 107);
			picUser.Name = "picUser";
			picUser.Size = new Size(42, 41);
			picUser.SizeMode = PictureBoxSizeMode.StretchImage;
			picUser.TabIndex = 2;
			picUser.TabStop = false;
			// 
			// label1
			// 
			label1.BackColor = Color.DarkBlue;
			label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Silver;
			label1.Location = new Point(0, -3);
			label1.Name = "label1";
			label1.Size = new Size(459, 77);
			label1.TabIndex = 0;
			label1.Text = "User Login";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			ClientSize = new Size(465, 336);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			Load += LoginForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picPassword).EndInit();
			((System.ComponentModel.ISupportInitialize)picUser).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private PictureBox picUser;
		private TextBox textUsername;
		private TextBox textPassword;
		private PictureBox picPassword;
		private Button buttonLogin;
		private Button buttonClose;
	}
}