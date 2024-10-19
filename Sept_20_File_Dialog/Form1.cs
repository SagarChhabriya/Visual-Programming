using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept_20_File_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            // choose image
            fileDialog.Filter = "ChooseImage(*.png;*.jgp;*.GIF)|*.png;*.jgp;*.GIF";
            fileDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(fileDialog.FileName);
            
            for(int i = 0; i<100; i++)
            {
                progressBar1.Value = i;
            }
            
             

























        }
    }
}
