using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
//using MySqlConnector;
//using Oracle.ManagedDataAccess.Client;

// installed packages: MySql.Data, Nuget Framework




namespace DBConnection
{
    public partial class Form1 : Form
    {


        //password value should not be enclosed in single quotes
        MySqlConnection conn = new MySqlConnection("server=localhost; user=root; password=; database=test");

        string query = "Select * from temp";

        // string vs. String in C#

        //static String url = "server=localhost; user=root; password=''; database=hms";
        //String qry = "Select * from temp";
        //MySqlConnection conn = new MySqlConnection(url);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Text = "Back";
            //b2.Text = "file Dialog";
            //button2.Text = "Execute for list box";


            //save.Enabled = false;
            //edit.Enabled = false;
            //del.Enabled = false;


            lgv();
        }


    public void lgv()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Prepare the insert query
            string insertQuery = "INSERT INTO temp (empid, ename, salary) VALUES (@empid, @ename, @salary)";

            try
            {
                // Open connection
                conn.Open();

                // Create a command with the query and the connection
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@empid", Convert.ToInt32(empidTextBox.Text)); // Assuming you have a TextBox for empid
                cmd.Parameters.AddWithValue("@ename", enameTextBox.Text); // Assuming you have a TextBox for ename
                cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(salaryTextBox.Text)); // Assuming you have a TextBox for salary

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the insert was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Insert failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }

            // Optionally reload the data to reflect changes
            lgv();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            empidTextBox.Text = "";
            enameTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(empidTextBox.Text))
            {
                MessageBox.Show("Please enter a valid empid.");
                return;
            }

            MySqlCommand cmd = null;

            try
            {
                string deleteQuery = "DELETE FROM temp WHERE empid = @empid";
                cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@empid", Convert.ToInt32(empidTextBox.Text));

                conn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Record deleted successfully.");
                else
                    MessageBox.Show("No record found with the given empid.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();  // Explicitly dispose of the command object
                }
                conn.Close();  // Ensure connection is always closed
            }

            lgv(); // Reload data
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure that empid TextBox is not empty
            if (string.IsNullOrEmpty(empidTextBox.Text))
            {
                MessageBox.Show("Please enter a valid empid.");
                return;
            }

            try
            {
                // Prepare the update query
                string updateQuery = "UPDATE temp SET ename = @ename, salary = @salary WHERE empid = @empid";

                // Create a command with the query and the connection
                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@empid", Convert.ToInt32(empidTextBox.Text));  // empid
                cmd.Parameters.AddWithValue("@ename", enameTextBox.Text);                    // ename
                cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(salaryTextBox.Text)); // salary

                // Open the connection
                conn.Open();

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("No record found with the given empid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }

            // Optionally reload the data to reflect changes
            lgv();
        }
    }
}
