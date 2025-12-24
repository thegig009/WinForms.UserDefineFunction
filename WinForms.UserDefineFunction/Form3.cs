using System;
using System.Windows.Forms;

namespace WinForms.UserDefineFunction
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string letter = textBox1.Text;
			int size = int.Parse(textBox2.Text);

			if (radioButton1.Checked)
			{
				textBox3.Text = Triangle1(letter, size);
			}
			else if (radioButton2.Checked)
			{
				textBox3.Text = Triangle2(letter);
			}
			else if (radioButton3.Checked)
			{
				
				string result;
				Triangle3(letter, size, out result);
				textBox3.Text = result;
			}
		}

		private string Triangle1(string letter, int size)
		{
			string result = "";
			char ch = letter[0];

			for (int i = 1; i <= size; i++)
			{
				result += new string(ch, i) + Environment.NewLine;
			}
			return result;
		}

	
		private string Triangle2(string letter, int size = 5)
		{
			string result = "";
			char ch = letter[0];

			for (int i = 1; i <= size; i++)
			{
				result += new string(ch, i) + Environment.NewLine;
			}
			return result;
		}

		
		private void Triangle3(string letter, int size, out string result)
		{
			result = "";
			char ch = letter[0];

			for (int i = 1; i <= size; i++)
			{
				result += new string(ch, i) + Environment.NewLine;
			}
		}
	}
}

