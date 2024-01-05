using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = String.Empty;
            msg = "";
            String err = "";
            if (textBox1.Text == "")
                err += "Enter Name\n";
            else
                msg += "Name: " + textBox1.Text;
            if (textBox2.Text == "")
            {
                err += "\nEnter regno";
            }
            else
            {
                msg += "\nReg:" + textBox2.Text;
            }
            msg += "\nDOB:" + dateTimePicker1.Value;
            if (radioButton1.Checked == true)
            {
                msg += "\nGender:Male";
            }
            else if (radioButton2.Checked == true)
            {
                msg += "\nGender:Female";
            }
            else
            {
                err += "\nSelect Gender";
            }
            if (comboBox1.SelectedItem == null)
            {
                err += "\nSelect Department";
            }
            else
            {
                msg += "\nDepatment:" + comboBox1.SelectedItem;
            }
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                msg+="\nSports Interested in:";
            }
            if (checkBox1.Checked==true)
            {
                msg += "\nCricket";
            }
            if (checkBox2.Checked==true)
            {
                msg += "\nBadminton";
            }
            if (checkBox3.Checked==true)
            {
                msg += "\nFootball";
            }

            if (err == "")
            {
                MessageBox.Show(err);
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
