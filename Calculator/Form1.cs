using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void inputOutput_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void dot_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += ".";
            this.inputOutput.Text += input;
        }

        private void cee_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "0";
            this.inputOutput.Text += input;
        }
        private void one_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "1";
            this.inputOutput.Text += input;
        }
        private void two_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "2";
            this.inputOutput.Text += input;
        }
        private void three_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "3";
            this.inputOutput.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "4";
            this.inputOutput.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "5";
            this.inputOutput.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "6";
            this.inputOutput.Text += input;
        }
        private void seven_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "7";
            this.inputOutput.Text += input;
        }
        private void eight_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "8";
            this.inputOutput.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.inputOutput.Text = "";
            input += "9";
            this.inputOutput.Text += input;
        }
        private void addition_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }
        private void substraction_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }
        private void multiple_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                inputOutput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                inputOutput.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                inputOutput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    inputOutput.Text = result.ToString();
                }
                else
                {
                    inputOutput.Text = "DIV/Zero!";
                }

            }

        }
    }
}
