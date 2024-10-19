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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void fileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileDialog fileDialog = new FileDialog();
            fileDialog.Show();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Show();

        }

        private void pictureChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PictureChanger pictureChanger = new PictureChanger();
            pictureChanger.Show();
        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Browser browser = new Browser();
            browser.Show();
        }
    }
}
