using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept_10_Date_Time_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

            // apply font to the label
            label1.Font = fontDialog1.Font;
            //fontDialog1_Apply.Apply += new EventHandler(fontDialog1_Apply);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fontObject = new FontDialog();
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                fontObject.ShowDialog();
                label1.Font = fontObject.Font;
            }

           
        }

        private void diceGameToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // open the dice game form
            new Form2().Show();
            this.Hide();
        }
    }
}
