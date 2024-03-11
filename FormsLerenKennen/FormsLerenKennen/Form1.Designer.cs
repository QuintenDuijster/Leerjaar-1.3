namespace FormsLerenKennen
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
			components = new System.ComponentModel.Container();
			Label1 = new Label();
			LoginBox = new TextBox();
			PasswordBox = new TextBox();
			label2 = new Label();
			label3 = new Label();
			errorProvider1 = new ErrorProvider(components);
			LoginButton = new Button();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// Label1
			// 
			Label1.AutoSize = true;
			Label1.Location = new Point(278, 74);
			Label1.Name = "Label1";
			Label1.Size = new Size(186, 20);
			Label1.TabIndex = 0;
			Label1.Text = "Welcome to this aplication";
			Label1.Click += label1_Click;
			// 
			// LoginBox
			// 
			LoginBox.Location = new Point(310, 160);
			LoginBox.Name = "LoginBox";
			LoginBox.Size = new Size(125, 27);
			LoginBox.TabIndex = 1;
			// 
			// PasswordBox
			// 
			PasswordBox.Location = new Point(310, 248);
			PasswordBox.Name = "PasswordBox";
			PasswordBox.Size = new Size(125, 27);
			PasswordBox.TabIndex = 2;
			PasswordBox.TextChanged += textBox2_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(342, 137);
			label2.Name = "label2";
			label2.Size = new Size(49, 20);
			label2.TabIndex = 3;
			label2.Text = "Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(333, 225);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 4;
			label3.Text = "Password";
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// LoginButton
			// 
			LoginButton.Location = new Point(323, 299);
			LoginButton.Name = "LoginButton";
			LoginButton.Size = new Size(94, 29);
			LoginButton.TabIndex = 5;
			LoginButton.Text = "Login";
			LoginButton.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(LoginButton);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(PasswordBox);
			Controls.Add(LoginBox);
			Controls.Add(Label1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label Label1;
		private TextBox LoginBox;
		private TextBox PasswordBox;
		private Label label2;
		private Label label3;
		private ErrorProvider errorProvider1;
		private Button LoginButton;
	}
}
