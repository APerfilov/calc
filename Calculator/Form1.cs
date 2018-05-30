using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            a = "";
            textBox1.Text = a;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Int16 one = 1;

            textBox1.Text = textBox1.Text + Convert.ToString(one);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int16 two = 2;
            textBox1.Text = textBox1.Text + Convert.ToString(two);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int16 three = 3;
            textBox1.Text = textBox1.Text + Convert.ToString(three);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int16 four = 4;
            textBox1.Text = textBox1.Text + Convert.ToString(four);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Int16 five = 5;
            textBox1.Text = textBox1.Text + Convert.ToString(five);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Int16 six = 6;
            textBox1.Text = textBox1.Text + Convert.ToString(six);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Int16 seven = 7;
            textBox1.Text = textBox1.Text + Convert.ToString(seven);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Int16 eight = 8;
            textBox1.Text = textBox1.Text + Convert.ToString(eight);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Int16 nine = 9;
            textBox1.Text = textBox1.Text + Convert.ToString(nine);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //Int16 zero = 0;
            textBox1.Text = textBox1.Text + 0; //Convert.ToString(zero);
        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Convert.ToString(",");
        }

        private void otr_Click(object sender, EventArgs e)
        {
            //Double prov;
            //prov = Convert.ToDouble(textBox1.Text);
           // if (prov)
            textBox1.Text =Convert.ToString(Convert.ToDouble(textBox1.Text) * -1);
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
