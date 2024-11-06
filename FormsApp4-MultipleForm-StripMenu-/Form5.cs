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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
            WindowState = FormWindowState.Maximized;    
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Size = new Size(50, 50);
            //set the title of label
        /// Set the size of the label
            label1.Size = new Size(200, 50); // Width: 200 pixels, Height: 50 pixels
            label1.Text = "label1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }
    }
}
