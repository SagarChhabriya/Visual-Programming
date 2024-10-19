using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept_06
{
    public partial class Form2 : Form
    {   
        static int index = 1;
        string path = "D:\\Ao\\Code\\WebCode\\Web-Engineering\\100-Days-of-Code\\Week-2\\responsive-blog\\css\\assets\\dog" + index.ToString() + ".jpg";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            BackColor = Color.Khaki;
            timer1.Interval = 1000;
            timer1.Start(); 
            try
            {
                pictureBox1.Image = Image.FromFile(path);   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = index + 1;
            string path = "D:\\Ao\\Code\\WebCode\\Web-Engineering\\100-Days-of-Code\\Week-2\\responsive-blog\\css\\assets\\dog" + index.ToString() + ".jpg";
            if (index > 10)
            {
                index = 1; 
            }
            try
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            catch(Exception ex)
            {

            }


        }
    }
}
