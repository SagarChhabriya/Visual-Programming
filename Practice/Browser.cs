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
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://www.google.com");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // how to use the web browser control
            // this is not visible in the form, but it is in the code
            // what to do next?

        }
    }
}

