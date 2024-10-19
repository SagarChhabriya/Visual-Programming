using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void program2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Close the current form i.e.,1 and open the the form 2
           
            


            this.Hide();
            new Form2().Show();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Azure;
            radioButton1.Text = "Male";
            radioButton2.Text = "Female";
            radioButton3.Text = "Other";

            //radioButton1.Checked = true;
            //radioButton2.Checked = true;
            //radioButton3.Checked = true;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //{
            //    label1.Text = "Male";
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton2.Checked)
            //{
            //    label1.Text = "Female";
            //}
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton3.Checked)
            //{
            //    label1.Text = "Other";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Male";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Female";
            }
            else
                label1.Text = "Other";
        
        }

        private void program3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Form3().Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { 
                listBox1.Items.Add(checkBox1.Text);
                listBox1.BackColor = Color.Red;
            }
            else
                listBox1.Items.Remove(checkBox1.Text);  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            { 
                listBox1.Items.Add((string)checkBox2.Text);
                listBox1.BackColor = Color.Green;
            }
            else
                listBox1.Items.Remove((string)checkBox2.Text);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            { 
                listBox1.Items.Add((string)checkBox3.Text);
                listBox1.BackColor = Color.Blue;
            }
            else
                listBox1.Items.Remove((string)checkBox3.Text);
        }
    }
}