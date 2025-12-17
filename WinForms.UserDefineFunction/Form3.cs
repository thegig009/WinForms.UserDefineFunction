using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
                
				textBox3.Text = letterTriangle1(letter, size);
			}
            else if (radioButton2.Checked)
            {
           
				textBox3.Text = letterTriangle2(letter);
			}
            else if (radioButton3.Checked)
            {
                letterTriangle3(letter, size, out string result);
			}
            
		}


    }
}
