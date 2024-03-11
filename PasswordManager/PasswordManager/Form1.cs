namespace PasswordManager
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void NameLabel_Click(object sender, EventArgs e)
		{

		}

		private void PasswordLabel_Click(object sender, EventArgs e)
		{

		}

		private void PasswordBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void NameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void Login_Click(object sender, EventArgs e)
		{
			if (NameBox.Text == "admin" && PasswordBox.Text == "1234")
			{
				WelcomeText.Text = "you have logged in";
			}
			else
			{
				WelcomeText.Text = PasswordBox.Text + " : " + NameBox.Text;
			}
		}
	}
}
