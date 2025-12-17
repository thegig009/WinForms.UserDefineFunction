using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.UserDefineFunction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = 0.0;
            double weight = 0.0;
            double triangleArea = 0.0;
            if (double.TryParse(textBox1.Text, out height)
                && double.TryParse(textBox2.Text, out weight))
            {
                triangleArea = CalculateTriangleArea(height, weight);
                label5.Text = triangleArea.ToString("F2");
            }

        }

        private double CalculateTriangleArea(double height, double weight)
        {
            double area = 0.5 * height * weight;
            return area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius;

            if (!double.TryParse(textBox4.Text, out radius) || radius <= 0)
            {
                MessageBox.Show("กรุณากรอกรัศมีเป็นตัวเลขที่มากกว่า 0");
                return;
            }


            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;


            label15.Text = circumference.ToString("0.00");
            label10.Text = area.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(textBox3.Text, out i))
            {
                label16.Text = i.ToString();
                label18.Text = RandomNextNumber(ref i).ToString();
                textBox3.Text = i.ToString();

            }

        }

        private object RandomNextNumber(ref int x)
        {
            Random rnd = new Random();
            x += rnd.Next(1, 100);
            return x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sumaty = 0;
            string[] inputs = textBox5.Lines;
           double[] numbers = new double[inputs.Length];

			for (int i = 0; i < inputs.Length; i++)
            {
                if (!double.TryParse(inputs[i], out  numbers[i]))
                {
                    numbers[i] = 0.0;    
				}
                
			}

            sumaty = Calculatesumaty(numbers);
            MessageBox.Show("ผลรวม = " + sumaty.ToString("F2"));
		}

        private double Calculatesumaty(double[] numbers)
        {
            return numbers.Sum();
		}
    }
}

