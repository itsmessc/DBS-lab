using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q1
{
    public partial class Form1 : Form
    {

        String input = "";
        String op1 = "";
        String op2 = "";
        String sqr = "";
        char operand ;
        double res;
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            double.TryParse(input, out res);
            res = Math.Sqrt(res);
            textBox1.Text =res.ToString() ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "1";
            textBox1.Text = input;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "2";
            textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "3";
            textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "4";
            textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "5";
            textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "6";
            textBox1.Text = input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "7";
            textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "8";
            textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "9";
            textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = input + "0";
            textBox1.Text = input;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            op1 = input;
            operand = '+';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op1 = input;
            operand = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op1 = input;
            operand = '*';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            op1 = input;
            operand = '/';
            input = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            input = string.Empty;
            op1 = string.Empty;
            op2 = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op2 = input;
            double n1, n2;
            double.TryParse(op2,out n2);
            double.TryParse(op1,out n1);
            if (operand == '+')
            {
                res = (n1 + n2);
                input = res.ToString();
                textBox1.Text = res.ToString();
            }
            if (operand == '-')
            {
                res = (n1 - n2);
                input = res.ToString();
                textBox1.Text = res.ToString();
            }
            if (operand == '*')
            {
                res = (n1 * n2);
                input = res.ToString();
                textBox1.Text = res.ToString();
            }
            if (operand == '/')
            {
                res = (n1 / n2);
                input = res.ToString();
                textBox1.Text = res.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            double.TryParse(input, out res);
            res = Math.Cos(res);
            textBox1.Text = res.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            double.TryParse(input, out res);
            res = Math.Sin(res);
            textBox1.Text = res.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            double.TryParse(input, out res);
            res = Math.Tan(res);
            textBox1.Text = res.ToString();
        }
    }
}
