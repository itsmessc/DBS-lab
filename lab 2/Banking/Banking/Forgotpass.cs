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
    public partial class Forgotpass : Form
    {
        User u1;
        string user;
        string dob;
        string pass;

        public Forgotpass(User u)
        {
            u1 = u;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (u1.name != user)
            {
                MessageBox.Show("Username not found", "Not Found", MessageBoxButtons.OK);
            }
            else if (dob == u1.DOB && pass!="")
            {
                u1.password = pass;
                MessageBox.Show("Changed Successfully", "Changed", MessageBoxButtons.OK);
                this.Close();
            }
            else if(dob!=u1.DOB)
            {
                MessageBox.Show("Date of birth doesnot match", "Not Match", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Password cannot be empty", "Empty", MessageBoxButtons.OK);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dob = dateTimePicker1.Value.ToString();
            dob = dob.Substring(0, 10);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textBox1.Text;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //label4.Text = pass;
                textBox2.PasswordChar = '\0';
            }
            else
            {
                //label4.Text = "";
                textBox2.PasswordChar = '*';
            }
        }

        

        private void Forgotpass_Load(object sender, EventArgs e)
        {

        }
    }
}
