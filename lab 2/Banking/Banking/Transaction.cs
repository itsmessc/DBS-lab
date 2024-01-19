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
    public partial class Transaction : Form
    {
        User u;
        public Transaction(User u1)
        {
            u = u1;
            InitializeComponent();
        }
        string bname;
        long amo;
        private void button1_Click(object sender, EventArgs e)
        {
            if (amo < u.balance)
            {
                u.balance = u.balance - amo;
                DateTime n = DateTime.Now;
                string da = n.ToString();
                u.lastacc = da;
                u.addlist("Date&Time:" + da + " To:" + bname + " Amount:" + amo);
                MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bname = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amo = (long)Convert.ToDouble(textBox2.Text);
            }
            catch (Exception eee)
            {
                MessageBox.Show("Enter Numericals","Input Invalid",MessageBoxButtons.OK);
            }
        }
        
    }
}
