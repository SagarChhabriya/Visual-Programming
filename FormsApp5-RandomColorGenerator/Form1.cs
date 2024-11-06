using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //BackColor = Color.Turquoise;

            int r, g, b;
            Random random = new Random();
            r = random.Next(0,255);
            g = random.Next(0,255); 
            b = random.Next(0,255); 
            
            
            BackColor = Color.FromArgb(r, g, b);    
            WindowState = FormWindowState.Maximized;
        }
    }
}
