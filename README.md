# Visual-Programming

## What is C#?

C# is pronounced "C-Sharp".<br>

It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.<br><br>

C# has roots from the C family, and the language is close to other popular languages like C++ and Java.<br><br>

The first version was released in year 2002. The latest version, C# 12, was released in November 2023.<br><br>

C# is used for:<br><br>

Mobile applications<br>
Desktop applications<br>
Web applications<br>
Web services<br>
Web sites<br>
Games<br>
VR<br>
Database applications<br>
And much, much more!<br>




```python
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Lab_Task_Oct_29_2024
{
    public partial class Form1 : Form
    {
        int hour = 0;
        int mnt = 0;
        int sec = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            timeWatch.Text = hour.ToString() + " : " + mnt.ToString() + " : " + sec.ToString();
            sec = sec + 1;
            if (sec>59)
            {
                sec = 0;
                mnt = mnt + 1;
                timeWatch.Text = hour.ToString() + ":" + mnt.ToString() + ":" + sec.ToString();
            }
            if (mnt > 59)
            {
                sec = 0;
                mnt = 0;
                hour = hour + 1;
                timeWatch.Text = hour.ToString() + ":" + mnt.ToString() + ":" + sec.ToString();
            }
            if(hour>24)
            {
                sec = 0;
                mnt = 0;
                hour = 0;
                timeWatch.Text = hour.ToString() + ":" + mnt.ToString() + ":" + sec.ToString();
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();

        }
    }
}

```
