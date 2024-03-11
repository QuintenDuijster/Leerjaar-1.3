namespace RekenMachine
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
			One = new Button();
			Two = new Button();
			Three = new Button();
			Four = new Button();
			Five = new Button();
			Six = new Button();
			Seven = new Button();
			Eight = new Button();
			Nine = new Button();
			Equels = new Button();
			Plus = new Button();
			Min = new Button();
			answer = new TextBox();
			clear = new Button();
			SuspendLayout();
			// 
			// One
			// 
			One.Location = new Point(151, 187);
			One.Name = "One";
			One.Size = new Size(94, 29);
			One.TabIndex = 0;
			One.Text = "1";
			One.UseVisualStyleBackColor = true;
			One.Click += button1_Click;
			// 
			// Two
			// 
			Two.Location = new Point(251, 187);
			Two.Name = "Two";
			Two.Size = new Size(94, 29);
			Two.TabIndex = 1;
			Two.Text = "2";
			Two.UseVisualStyleBackColor = true;
			Two.Click += Two_Click;
			// 
			// Three
			// 
			Three.Location = new Point(351, 187);
			Three.Name = "Three";
			Three.Size = new Size(94, 29);
			Three.TabIndex = 2;
			Three.Text = "3";
			Three.UseVisualStyleBackColor = true;
			Three.Click += Three_Click;
			// 
			// Four
			// 
			Four.Location = new Point(151, 222);
			Four.Name = "Four";
			Four.Size = new Size(94, 29);
			Four.TabIndex = 3;
			Four.Text = "4";
			Four.UseVisualStyleBackColor = true;
			Four.Click += Four_Click;
			// 
			// Five
			// 
			Five.Location = new Point(251, 222);
			Five.Name = "Five";
			Five.Size = new Size(94, 29);
			Five.TabIndex = 4;
			Five.Text = "5";
			Five.UseVisualStyleBackColor = true;
			Five.Click += Five_Click;
			// 
			// Six
			// 
			Six.Location = new Point(351, 222);
			Six.Name = "Six";
			Six.Size = new Size(94, 29);
			Six.TabIndex = 5;
			Six.Text = "6";
			Six.UseVisualStyleBackColor = true;
			Six.Click += Six_Click;
			// 
			// Seven
			// 
			Seven.Location = new Point(151, 257);
			Seven.Name = "Seven";
			Seven.Size = new Size(94, 29);
			Seven.TabIndex = 6;
			Seven.Text = "7";
			Seven.UseVisualStyleBackColor = true;
			Seven.Click += Seven_Click;
			// 
			// Eight
			// 
			Eight.Location = new Point(251, 257);
			Eight.Name = "Eight";
			Eight.Size = new Size(94, 29);
			Eight.TabIndex = 7;
			Eight.Text = "8";
			Eight.UseVisualStyleBackColor = true;
			Eight.Click += Eight_Click;
			// 
			// Nine
			// 
			Nine.Location = new Point(351, 257);
			Nine.Name = "Nine";
			Nine.Size = new Size(94, 29);
			Nine.TabIndex = 8;
			Nine.Text = "9";
			Nine.UseVisualStyleBackColor = true;
			Nine.Click += Nine_Click;
			// 
			// Equels
			// 
			Equels.Location = new Point(251, 302);
			Equels.Name = "Equels";
			Equels.Size = new Size(94, 29);
			Equels.TabIndex = 9;
			Equels.Text = "=";
			Equels.UseVisualStyleBackColor = true;
			Equels.Click += Equels_Click;
			// 
			// Plus
			// 
			Plus.Location = new Point(476, 192);
			Plus.Name = "Plus";
			Plus.Size = new Size(94, 29);
			Plus.TabIndex = 10;
			Plus.Text = "+";
			Plus.UseVisualStyleBackColor = true;
			Plus.Click += Plus_Click;
			// 
			// Min
			// 
			Min.Location = new Point(476, 227);
			Min.Name = "Min";
			Min.Size = new Size(94, 29);
			Min.TabIndex = 11;
			Min.Text = "-";
			Min.UseVisualStyleBackColor = true;
			Min.Click += Min_Click;
			// 
			// answer
			// 
			answer.Location = new Point(151, 133);
			answer.Name = "answer";
			answer.Size = new Size(294, 27);
			answer.TabIndex = 12;
			answer.TextChanged += answer_TextChanged;
			// 
			// clear
			// 
			clear.Location = new Point(476, 262);
			clear.Name = "clear";
			clear.Size = new Size(94, 29);
			clear.TabIndex = 13;
			clear.Text = "clear";
			clear.UseVisualStyleBackColor = true;
			clear.Click += clear_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(clear);
			Controls.Add(answer);
			Controls.Add(Min);
			Controls.Add(Plus);
			Controls.Add(Equels);
			Controls.Add(Nine);
			Controls.Add(Eight);
			Controls.Add(Seven);
			Controls.Add(Six);
			Controls.Add(Five);
			Controls.Add(Four);
			Controls.Add(Three);
			Controls.Add(Two);
			Controls.Add(One);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button One;
		private Button Two;
		private Button Three;
		private Button Four;
		private Button Five;
		private Button Six;
		private Button Seven;
		private Button Eight;
		private Button Nine;
		private Button Equels;
		private Button Plus;
		private Button Min;
		private TextBox answer;
		private Button clear;
	}
}
