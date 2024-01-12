using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg="";
            string error="";

            if (textBox1.Text == "")
            {
                error += "Enter name\n";
            }
            else
            {
                msg += "Name:" + textBox1.Text;
            }

            DateTime date;
            date = dateTimePicker1.Value;
            msg += "\n DOB:" + date;

            if (radioButton1.Checked == true)
            {
                msg += "\nGender: Male";
            }
            else if (radioButton2.Checked == true)
            {
                msg += "\nGender: Female";
            }
            else if (radioButton3.Checked == true)
            {
                msg += "\nGender: Other";
            }
            else
            {
                error += "Select Gender";
            }

            if ((textBox2.Text).Length != 9)
            {
                error += "invalid reg number";
            }
            else
            {
                msg += "\nReg num:" + textBox2.Text;
            }
            if (comboBox1.SelectedItem == null)
            {
                error += "Select department";
            }
            else
            {
                msg += "\nDepartment:" + comboBox1.SelectedItem;
            }

            msg += "\n----Interests---\n";
            if (checkBox1.Checked == true)
            {
                msg += "Football\n";
            }
            if (checkBox2.Checked == true)
            {
                msg += "Tennis\n";
            }
            if (checkBox3.Checked == true)
            {
                msg += "Badminton\n";
            }

            if (error != "")
            {
                MessageBox.Show(error);
            }
            else
                MessageBox.Show(msg);



        }
    }
}
