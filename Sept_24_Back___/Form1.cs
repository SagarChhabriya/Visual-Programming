using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sept_24_Back___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //backgroundWorker has 3 workress
            // 1. Do worker 2. Progress changed 3. Work completed
            // Do work       progress changed       completedtask
            
            //backgroundWorker1.WorkerReportsProgress = true;
            //backgroundWorker1.WorkerSupportsCancellation = true;


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i=1; i<= 100; i++){
                Thread.Sleep(90);
                //backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged; 
                backgroundWorker1.ReportProgress(0);
                // report progress will call the progress changed

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value += 1;
            // after progress changed RunWorkerComplete will be called
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Task Completed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();

            // by default the RunWorkerAsync will call the DoWorker
            // 

        }
    }
}
