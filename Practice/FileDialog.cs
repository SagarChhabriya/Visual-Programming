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
    public partial class FileDialog : Form
    {
        public FileDialog()
        {
            InitializeComponent();
        }

        private void FileDialog_Load(object sender, EventArgs e)
        {

        }

        private void fileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileDialog fileDialog = new FileDialog();
            fileDialog.Show();
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

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Equals("Page Setup");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
