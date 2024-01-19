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
    public partial class Form2 : Form
    {
        User u;
        public Form2(User u1)
        {
            u = u1;
            InitializeComponent();
            label5.Text = u.name;
            label6.Text = u.balance.ToString();
            label7.Text = u.lastacc;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction(u);
            t.FormClosed += new FormClosedEventHandler(t1_FormClosed);
            t.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;
            string da = n.ToString();
            u.lastacc = da;
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //label6.Text = u.balance.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = u.name;
            label6.Text = u.balance.ToString();
            label7.Text = u.lastacc;
            foreach (string s in u.l1)
            {
                listBox1.Items.Add(s);
            }
        }
        private void t1_FormClosed(object sender, FormClosedEventArgs e)
        {
            label6.Text = u.balance.ToString();
            label7.Text = u.lastacc;
            listBox1.Items.Clear();
            if (u.l1.Count <= 5)
            {
                foreach(string s in u.l1)
                {
                    listBox1.Items.Add(s);
                }
            }
            else
            {
                for(int i=u.l1.Count-5;i<u.l1.Count;i++)
                {
                    listBox1.Items.Add(u.l1[i]);
                }
            }
        }
    }
}
