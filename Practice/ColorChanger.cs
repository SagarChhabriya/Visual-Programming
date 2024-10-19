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
    public partial class ColorChanger : Form
    {
        public ColorChanger()
        {
            InitializeComponent();
        }

        private void ColorChanger_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r, g, b;
            Random random = new Random();
            r = random.Next(0, 256);
            g = random.Next(0, 256);
            b = random.Next(0, 256);
            this.BackColor = Color.FromArgb(r, g, b);

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
    }
}
