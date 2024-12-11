![image](https://github.com/user-attachments/assets/79a8658a-9acc-4392-9235-8b1bbd896ff7)



![image](https://github.com/user-attachments/assets/d5ed1b86-9e59-4909-a39f-0b8a3d99cd39)

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

namespace Sagar_Chhabriya_Final_LAB_Visual_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("Key");
            table.Columns.Add("*");
            table.Columns.Add("Value");
            table.Columns.Add("result");

            for (int i=1; i<= 10; i++)
            {
                table.Rows.Add(textBox1.Text, "*", i ,Convert.ToInt32(textBox1.Text)*i);
                
            }
            dataGridView1.DataSource = table;
        }
    }
}
```

