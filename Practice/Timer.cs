using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Timer : Form
    {
        int counter=0;
        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void colorChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ColorChanger colorChanger = new ColorChanger();
            colorChanger.Show();
        }

        private void groupBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupBox groupBox = new GroupBox();
            groupBox.Show();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer timer = new Timer();
            timer.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(counter>9)
            {
                timer1.Stop();
                MessageBox.Show("Time is up");
            
            }
            else
            {
                counter++;
                label1.Text = counter.ToString();
            }

        }

        private void pictureChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PictureChanger pictureChanger = new PictureChanger();
            pictureChanger.Show();

        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Show();

        }

        private void fileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileDialog fileDialog = new FileDialog();
            fileDialog.Show();
        }
    }
}
