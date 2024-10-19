using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept_27_tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add a media player

            
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "D:\\  \\Aditya Rikhari\\Aditya Rikhari - AANA NAHI (original).mp4";
            axWindowsMediaPlayer2.URL = "D:\\  \\Aditya Rikhari\\Aditya Rikhari - Tinka (Official Music Video) ft. Mugdha Agarwal.mp4";



        }
    }
}
