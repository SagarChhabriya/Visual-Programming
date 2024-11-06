using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept_06
{
    public partial class Form1 : Form
    {
        int k = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            BackColor = Color.Beige;
            label1.Text = Convert.ToString(k);
            timer1.Interval = 1000;
            timer1.Start();
        // Timer tick event will fire

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k = k + 1;
            if (k > 10)
            {
                k = 1;
            }
            label1.Text = k.ToString();
        }

        private void pictureHandlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show(); 
        }
    }
}
