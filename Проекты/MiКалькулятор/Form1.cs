using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiКалькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 100;
        }
        private double Number1 = 0;
        private char Symbol = 'v';
        private string history = "";
        private string longHistory = "";

        private void button10_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button10.Text;
                }
                else
                {
                    Input.Text += button10.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text != "0")
                {
                    Input.Text += button2.Text;
                    switch (Symbol)
                    {
                        case 'v':
                            Output.Text = "=" + Input.Text;
                            break;
                        case '+':
                            Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                            break;
                        case '-':
                            Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                            break;
                        case '*':
                            Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                            break;
                        case '/':
                            Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                            break;
                    }
                }
                button17.Text = "C";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button6.Text;
                }
                else
                {
                    Input.Text += button6.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button5.Text;
                }
                else
                {
                    Input.Text += button5.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button7.Text;
                }
                else
                {
                    Input.Text += button7.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button11.Text;
                }
                else
                {
                    Input.Text += button11.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button9.Text;
                }
                else
                {
                    Input.Text += button9.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button13.Text;
                }
                else
                {
                    Input.Text += button13.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button14.Text;
                }
                else
                {
                    Input.Text += button14.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 16)
            {
                if (Input.Text == "0")
                {
                    Input.Text = button15.Text;
                }
                else
                {
                    Input.Text += button15.Text;
                }
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Input.Text.Length < 15 && !Input.Text.Contains(','))
            {
                Input.Text += ",";
                switch (Symbol)
                {
                    case 'v':
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '-':
                        Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '*':
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Output.Text = "=" + Math.Round((Number1 / Convert.ToDouble(Input.Text)), 2).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Input.Text != "0")
            {
                Input.Text = Input.Text.Substring(0, Input.Text.Length - 1);
                if (Input.Text == "" || Input.Text == "0")
                {
                    Input.Text = "0";
                    if (Symbol == 'v')
                    {
                        Output.Text = "";
                        button17.Text = "AC";
                    }
                    else
                    {
                        switch (Symbol)
                        {
                            case 'v':
                                Output.Text = "=" + Number1.ToString();
                                break;
                            case '+':
                                Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                                break;
                            case '-':
                                Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                                break;
                            case '*':
                                Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                                break;
                            case '/':
                                Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                                break;
                        }
                        button17.Text = "C";
                    }
                }
                else
                {
                    switch (Symbol)
                    {
                        case 'v':
                            Output.Text = "=" + Input.Text;
                            break;
                        case '+':
                            Output.Text = "=" + (Number1 + Convert.ToDouble(Input.Text)).ToString();
                            break;
                        case '-':
                            Output.Text = "=" + (Number1 - Convert.ToDouble(Input.Text)).ToString();
                            break;
                        case '*':
                            Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                            break;
                        case '/':
                            Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                            break;
                    }
                    button17.Text = "C";
                }
            }
            else if (Symbol != 'v')
            {
                Symbol = 'v';
                History.Text = longHistory;
                history = "";
                Input.Text = Number1.ToString();
                if (Number1 != 0)
                {
                    Output.Text = "=" + Input.Text;
                    button17.Text = "AC";
                }
                else
                {
                    Output.Text = "";
                    button17.Text = "C";
                }
                Number1 = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Symbol == 'v')
            {
                history = Input.Text + "+";
                History.Text = longHistory + history;
                Number1 = Convert.ToDouble(Input.Text);
                Input.Text = "0";
                Symbol = '+';
                Output.Text = "=" + (Number1).ToString();
                button17.Text = "C";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Symbol == 'v')
            {
                history = Input.Text + "÷";
                History.Text = longHistory + history;
                Number1 = Convert.ToDouble(Input.Text);
                Input.Text = "0";
                Symbol = '/';
                Output.Text = "=" + (Number1 / 0).ToString();
                button17.Text = "C";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Symbol == 'v')
            {
                history = Input.Text + "×";
                History.Text = longHistory + history;
                Number1 = Convert.ToDouble(Input.Text);
                Input.Text = "0";
                Symbol = '*';
                Output.Text = "=0";
                button17.Text = "C";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Symbol == 'v')
            {
                history = Input.Text + "−";
                History.Text = longHistory + history;
                Number1 = Convert.ToDouble(Input.Text);
                Input.Text = "0";
                Symbol = '-';
                Output.Text = "=" + (Number1).ToString();
                button17.Text = "C";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Input.Text != "0")
            {
                switch (Symbol)
                {
                    case 'v':
                        Input.Text = (Convert.ToDouble(Input.Text) / 100).ToString();
                        Output.Text = "=" + Input.Text;
                        break;
                    case '+':
                        Input.Text = (Convert.ToDouble(Input.Text) / 100 * Number1).ToString();
                        Output.Text = "=" + (Number1 + (Convert.ToDouble(Input.Text))).ToString();
                        break;
                    case '-':
                        Input.Text = (Convert.ToDouble(Input.Text) / 100 * Number1).ToString();
                        Output.Text = "=" + (Number1 - (Convert.ToDouble(Input.Text))).ToString();
                        break;
                    case '*':
                        Input.Text = (Convert.ToDouble(Input.Text) / 100).ToString();
                        Output.Text = "=" + (Number1 * Convert.ToDouble(Input.Text)).ToString();
                        break;
                    case '/':
                        Input.Text = (Convert.ToDouble(Input.Text) / 100).ToString();
                        Output.Text = "=" + (Number1 / Convert.ToDouble(Input.Text)).ToString();
                        break;
                }
                button17.Text = "C";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            longHistory = longHistory + history + Input.Text + "\n" + Output.Text + "\n";
            history = "";
            History.Text = longHistory;
            Input.Text = Output.Text.Substring(1);
            Number1 = 0;
            Symbol = 'v';
            History.SelectionStart = History.TextLength;
            History.ScrollToCaret();
            button17.Text = "C";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Text == "C")
            {
                Input.Text = "0";
                History.Text = longHistory;
                Output.Text = "";
                Symbol = 'v';
                Number1 = 0;
                button17.Text = "AC";
            }
            else
            {
                longHistory = "";
                Input.Text = "0";
                History.Text = longHistory;
                Output.Text = "";
                Symbol = 'v';
                Number1 = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
