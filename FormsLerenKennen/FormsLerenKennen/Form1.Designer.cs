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
			errorProvider1 = new ErrorProvider(components);
			button1 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			listBox1 = new ListBox();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// button1
			// 
			button1.Location = new Point(138, 121);
			button1.Name = "button1";
			button1.Size = new Size(170, 29);
			button1.TabIndex = 0;
			button1.Text = "voeg item toe";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(369, 76);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 1;
			label1.Text = "label1";
			label1.Click += label1_Click_1;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(138, 73);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(170, 27);
			textBox1.TabIndex = 2;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.Location = new Point(138, 166);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(170, 164);
			listBox1.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(listBox1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ErrorProvider errorProvider1;
		private TextBox textBox1;
		private Label label1;
		private Button button1;
		private ListBox listBox1;
	}
}
