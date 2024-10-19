using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace Practice
{
    public partial class GroupBox : Form
    {

        //To ensure that the new row is added to the DataGridView
        //instead of replacing the existing data, you need to maintain
        //the DataTable as a class-level variable.This way,
        //you can keep adding rows to the same DataTable
        //each time the button is clicked

        private DataTable dataTable; // Class-level variable
        
            
        public GroupBox()
        {
            InitializeComponent();
            dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("CMS");
            dataTable.Columns.Add("Gender");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            

            string gender = "";
            if (maleRadioButton.Checked)
                gender = "Male";
            if (femaleRadioButton.Checked)
                gender = "Female";
            if(gmailRadioButton.Checked)
                gender = "gmail";


            dataTable.Rows.Add(nameTextBox.Text,cmsTextBox.Text,gender);
            dataGridView1.DataSource = dataTable;


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
            this .Hide();
            PictureChanger pictureChanger = new PictureChanger();
            pictureChanger.Show();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide ();
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
