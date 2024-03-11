namespace PasswordManager
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			WelcomeText = new Label();
			NameLabel = new Label();
			PasswordLabel = new Label();
			NameBox = new TextBox();
			PasswordBox = new TextBox();
			Login = new Button();
			SuspendLayout();
			// 
			// WelcomeText
			// 
			WelcomeText.AutoSize = true;
			WelcomeText.Location = new Point(367, 141);
			WelcomeText.Name = "WelcomeText";
			WelcomeText.Size = new Size(71, 20);
			WelcomeText.TabIndex = 0;
			WelcomeText.Text = "Welcome";
			// 
			// NameLabel
			// 
			NameLabel.AutoSize = true;
			NameLabel.Location = new Point(378, 192);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(49, 20);
			NameLabel.TabIndex = 1;
			NameLabel.Text = "Name";
			NameLabel.Click += NameLabel_Click;
			// 
			// PasswordLabel
			// 
			PasswordLabel.AutoSize = true;
			PasswordLabel.Location = new Point(366, 260);
			PasswordLabel.Name = "PasswordLabel";
			PasswordLabel.Size = new Size(72, 20);
			PasswordLabel.TabIndex = 2;
			PasswordLabel.Text = "password";
			PasswordLabel.Click += PasswordLabel_Click;
			// 
			// NameBox
			// 
			NameBox.Location = new Point(342, 215);
			NameBox.Name = "NameBox";
			NameBox.Size = new Size(125, 27);
			NameBox.TabIndex = 3;
			NameBox.TextChanged += PasswordBox_TextChanged;
			// 
			// PasswordBox
			// 
			PasswordBox.Location = new Point(343, 283);
			PasswordBox.Name = "PasswordBox";
			PasswordBox.Size = new Size(125, 27);
			PasswordBox.TabIndex = 4;
			PasswordBox.TextChanged += NameBox_TextChanged;
			// 
			// Login
			// 
			Login.Location = new Point(356, 341);
			Login.Name = "Login";
			Login.Size = new Size(94, 29);
			Login.TabIndex = 5;
			Login.Text = "Login";
			Login.UseVisualStyleBackColor = true;
			Login.Click += Login_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Login);
			Controls.Add(PasswordBox);
			Controls.Add(NameBox);
			Controls.Add(PasswordLabel);
			Controls.Add(NameLabel);
			Controls.Add(WelcomeText);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label WelcomeText;
		private Label NameLabel;
		private Label PasswordLabel;
		private TextBox NameBox;
		private TextBox PasswordBox;
		private Button Login;
	}
}
