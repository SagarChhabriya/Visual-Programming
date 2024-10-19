using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.IndianRed;
            WindowState = FormWindowState.Maximized;
            label1.Text = "Name";
            label2.Text = "City";
            label3.Text = "Dept";
            label4.Text = "Salary";
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label2.Font = new Font("Arial", 12, FontStyle.Bold);
            label3.Font = new Font("Arial", 12, FontStyle.Bold);
            label4.Font = new Font("Arial", 12, FontStyle.Bold);

            textBox1.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox2.Font = new Font("aArial", 12, FontStyle.Bold);
            textBox3.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox4.Font = new Font("Arial", 12, FontStyle.Bold);
            
            button1.Font = new Font("Arial", 12, FontStyle.Bold);

            label1.BorderStyle = BorderStyle.FixedSingle;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label4.BorderStyle = BorderStyle.FixedSingle;


            //add padding to the labels

            label1.Padding = new Padding(8, 5, 8, 5);
            //what are the axes in 4 values
            //1st value is left padding
            //2nd value is top padding
            //3rd value is right padding
            //4th value is bottom padding

            label2.Padding = new Padding(8, 5, 8, 5);
            label3.Padding = new Padding(8, 5, 8, 5);
            label4.Padding = new Padding(8, 5, 8, 5);

            //apply label border white color
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Submit";
            Close();
        }

       
    }
}
