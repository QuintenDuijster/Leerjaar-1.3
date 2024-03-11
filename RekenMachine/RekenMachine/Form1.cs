namespace RekenMachine
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			answer.Text += "1";
		}

		private void Two_Click(object sender, EventArgs e)
		{
			answer.Text += "2";
		}

		private void Three_Click(object sender, EventArgs e)
		{
			answer.Text += "3";
		}

		private void Four_Click(object sender, EventArgs e)
		{
			answer.Text += "4";
		}

		private void Five_Click(object sender, EventArgs e)
		{
			answer.Text += "5";
		}

		private void Six_Click(object sender, EventArgs e)
		{
			answer.Text += "6";
		}

		private void Seven_Click(object sender, EventArgs e)
		{
			answer.Text += "7";
		}

		private void Eight_Click(object sender, EventArgs e)
		{
			answer.Text += "8";
		}

		private void Nine_Click(object sender, EventArgs e)
		{
			answer.Text += "9";
		}

		private void Plus_Click(object sender, EventArgs e)
		{
			answer.Text += " + ";
		}

		private void Min_Click(object sender, EventArgs e)
		{
			answer.Text += " - ";
		}

		private void Equels_Click(object sender, EventArgs e)
		{
			answer.Text += " = " + Calculate(answer.Text);
		}

		private void clear_Click(object sender, EventArgs e)
		{
			answer.Text = "";
		}

		private void answer_TextChanged(object sender, EventArgs e)
		{

		}

		private int Calculate(string calculation)
		{
			string[] calculationParts = calculation.Split(' ');
			int sum = int.Parse(calculationParts[0]);

			for (int i = 1; i < calculationParts.Length; i += 2)
			{
				string operation = calculationParts[i];
				int operand = int.Parse(calculationParts[i + 1]);

				if (operation == "+")
				{
					sum += operand;
				}

				if (operation == "-")
				{
					sum -= operand;
				}
			}
			return sum;
		}
	}
}
