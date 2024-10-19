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
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }
    }
}
