## Visual Programming -C# Database Connection Using XAMPP

![image](https://github.com/user-attachments/assets/1a10e02d-26bc-40cb-9f1c-cbc120528db6)

![image](https://github.com/user-attachments/assets/a7549ebb-9965-4e82-b9e0-e84922394221)



### 1. Select Query
The database and table is created in the XAMPP and the Apache + MySQL services are up.

```csharp
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

// installed packages: MySql.Data, Nuget Framework




namespace DBConnection
{
    public partial class Form1 : Form
    {


        // 1. Connection with XAMPP: Password value should not be enclosed in single quotes
        MySqlConnection conn = new MySqlConnection("server=localhost; user=root; password=; database=test");


        // 2. Query
        string query = "Select * from temp";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // 4. Call the driver method
            lgv();
        }



        // 3. Driver Method
        public void lgv()
            {

                // 3.1. Establish the Connection i.e., open()
                conn.Open();
                
                // 3.2. Create a SQL Commmand using `connection` and `query`.
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // 3.3. Load the `cmd` data to adapter.
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);


                // 3.4. Fill Datable using the adapter    
                DataTable dt = new DataTable();
                adp.Fill(dt);

                // 3.5. Assign the filled datatable to the gridview.
                dataGridView1.DataSource = dt;

                // 3.6. Close the connection
                conn.Close();

            }
    }
}


      

```



## 2. Insert Query
The Insert Action will be performed on the button click.


```csharp
  private void button1_Click(object sender, EventArgs e)
        {
            // 1. Prepare the insert query
            string insertQuery = "INSERT INTO temp (empid, ename, salary) VALUES (@empid, @ename, @salary)";


            // 2. try-catch block
            try
            {
                // 2.1. Open connection
                conn.Open();

                // 2.2. Create a command with the query and the connection
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);

                // 2.3. Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@empid", Convert.ToInt32(empidTextBox.Text)); // Assuming you have a TextBox for empid
                cmd.Parameters.AddWithValue("@ename", enameTextBox.Text); // Assuming you have a TextBox for ename
                cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(salaryTextBox.Text)); // Assuming you have a TextBox for salary

                // 2.4. Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // 2.5. Check if the insert was successful
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

            // 3. Update the dataGridView to reflect changes i.e., call driver method lgv()
            lgv();
        }

       
```

`@empid`, `@ename`, and `@salary` are parameters in a SQL query, not variables or column names. They act as placeholders for values that will be inserted into the query at runtime.

For example, in this line:
```csharp
cmd.Parameters.AddWithValue("@empid", empidTextBox.Text);
```
`@empid` is a placeholder in the SQL query, and `empidTextBox.Text` is the actual value entered by the user. When the query runs, `@empid` is replaced with the value from the TextBox.

- Using parameters helps prevent SQL injection and makes the code more secure and maintainable.


### 3. Clear Button
The button will clear the data from the text fields.

```csharp
 private void button4_Click(object sender, EventArgs e){
            empidTextBox.Text = "";
            enameTextBox.Text = "";
            salaryTextBox.Text = "";
 }

```


### 4. Delete Query

```csharp
 private void button3_Click(object sender, EventArgs e)
        {
            // 1. Verify the Input Field
            if (string.IsNullOrEmpty(empidTextBox.Text))
            {
                MessageBox.Show("Please enter a valid empid.");
                return;
            }


            // 2. Object: Create SQL Command object.
            MySqlCommand cmd = null;

            // 3. try-catch block
            try
            {

                // 3.1. Query
                string deleteQuery = "DELETE FROM temp WHERE empid = @empid";
                
                // 3.2. Command with query and connection
                cmd = new MySqlCommand(deleteQuery, conn);
                
                // 3.3. Employee id
                cmd.Parameters.AddWithValue("@empid", Convert.ToInt32(empidTextBox.Text));

                // 3.4. Close the connection 
                conn.Open();


                // 3.5. Verification Message
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

            // 4. Update the dataGridView by calling the driver method lgv()
            lgv(); // Reload data
        }

        
```


## 5. Update Query

```csharp
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
      
```
