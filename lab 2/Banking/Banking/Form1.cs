using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Banking
{
    public partial class Form1 : Form
    {
        User u1 = new User("Aditya", "Aditya123", "04-01-2002", 500000, "03-23-2021 01:23:55");
        string uinput; 
        string pinput;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpass frm = new Forgotpass(u1);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (u1.name != uinput)
            {
                MessageBox.Show("Username not found", "Not Found", MessageBoxButtons.OK);
            }
            else if (u1.password != pinput)
            {
                MessageBox.Show("Password doesnot match", "Wrong password", MessageBoxButtons.OK);
            }
            else
            {
                Form2 frm = new Form2(u1);
                frm.FormClosed += new FormClosedEventHandler(frm1_FormClosed);
                frm.Show();
                this.Hide();
            }
        }
        private void frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            this.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            uinput = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pinput = textBox2.Text;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
