using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Win4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int result = num1 / num2;

                label4.Text = "RESULT=" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int result = num1 + num2;

                label4.Text = "RESULT=" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                Console.WriteLine("please enter a number!"); 
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int result = num1 - num2;

                label4.Text = "RESULT=" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);

                int result = num1 * num2;

                label4.Text = "RESULT=" + result.ToString();
                label4.Visible = true;
            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
