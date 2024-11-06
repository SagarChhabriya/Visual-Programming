using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept_06
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            BackColor = Color.Aqua;
            //timer1.Interval = 1000;
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Random rnd= new Random();
            //int r = rnd.Next(0, 255);
            //int g = rnd.Next(0, 255);
            //int b = rnd.Next(0, 255);

            //BackColor = Color.FromArgb(r, g, b);

        }
    }
}
