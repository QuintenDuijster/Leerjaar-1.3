namespace FormsLerenKennen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBox1.Text);
			textBox1.Text = "";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			label1.Text = textBox1.Text;
		}
	}
}
