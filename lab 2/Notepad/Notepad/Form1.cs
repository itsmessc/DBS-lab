using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            fd.ShowDialog();
            richTextBox1.SelectionFont = fd.Font;
        }

        private void cOlourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = richTextBox1.SelectionColor;
            cd.ShowDialog();
            richTextBox1.SelectionColor = cd.Color;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s="Thanks for using";
            MessageBox.Show(s);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fname = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(fname);
            sw.Write(richTextBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            op.DefaultExt = ".txt";
            op.Title="Open";
            op.ShowDialog();
            string fName = op.FileName;
            StreamReader sr = new StreamReader(fName);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd=new PrintDialog();
            pd.ShowDialog();
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

            t.Start();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        public static void ThreadProc()
        {
            // Window Help = new Window();
            //Application.Run(new Window(Help);    

            Application.Run(new Form1());
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
