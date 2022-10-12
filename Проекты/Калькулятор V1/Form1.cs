using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "0")
            {
                richTextBox1.Text += (sender as Button).Text;
            }
            else
            {
                richTextBox1.Text = (sender as Button).Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ",";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text[0] != '-')
            {
                richTextBox1.Text = "-" + richTextBox1.Text;
            }
            else
            {
                richTextBox1.Text.Remove(0, 1);
            }
        }

        double a = 0, b = 0, c = 0;

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            a = 0;
            b = 0;
            c = 0;
            symbol = 'j';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(richTextBox1.Text);
            switch (symbol)
            {
                case '+': c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case 'x':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
            }
            richTextBox1.Text = c.ToString();
            a = c;
            b = 0;
            c = 0;
            symbol = 'j';
        }

        char symbol = 'j';

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(richTextBox1.Text);
            symbol = (sender as Button).Text[0];
            richTextBox1.Text = "0";
        }
    }
}
