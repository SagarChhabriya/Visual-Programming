using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            //this.WindowState = FormWindowState.Maximized;
            WindowState = FormWindowState.Maximized;
        }

        

        private void programAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();

        }

        private void porgramBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }
    }
}
