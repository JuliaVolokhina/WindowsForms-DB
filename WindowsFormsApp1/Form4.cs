using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        SqlConnection sqlConnection;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter1.Fill(this.companyDataSet1.Employee);
            string connectionString = @"Data Source=IBPPM-BIOENG\SQLEXPRESS; Initial Catalog=Company; Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sql_cmd = new SqlCommand("show databases", sqlConnection);
            //SqlDataReader sql_rd = sql_cmd.ExecuteReader();
        }
       
        private void EmployeeBNSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.EmployeeBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.companyDataSet1);
        }              

        private void button1_Click_1(object sender, EventArgs e)
        {
            EmployeeBS.AddNew();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EmployeeBS.EndEdit();
            employeeTableAdapter1.Update(companyDataSet1);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить сотрудника?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
