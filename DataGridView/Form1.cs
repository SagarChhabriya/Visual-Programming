using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table_person = new DataTable();

            //table.Columns.Add(
            //    new DataColumn( CompanyName, typeof(string ) ) );

            table_person.Columns.Add("Rno");
            table_person.Columns.Add("Name");
            table_person.Columns.Add("Address");

            table_person.Rows.Add(101, "Sagar", "KK");
            table_person.Rows.Add(101, "Qadeer", "KK");
            table_person.Rows.Add(101, "Deepak", "KK");

            DataTable  table_color = new DataTable();
            
            table_color.Columns.Add("Color");
            table_color.Columns.Add("des");
            table_color.Rows.Add("Red", "good");
            table_color.Rows.Add("Green", "Exe");






            // dataGridView1.DataSource = table_person;
            DataSet set = new DataSet();
            set.Tables.Add(table_color);
            set.Tables.Add(table_person);


            //dataGridView1.DataSource = set.Tables[0];
            dataGridView1.DataSource = table_person;





        }
    }
}
