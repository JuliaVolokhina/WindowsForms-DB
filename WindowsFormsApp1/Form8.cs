using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.taskTableAdapter1.Fill(this.companyDataSet1.Task);
        }

        private void TaskBNSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.TaskBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.companyDataSet1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskBS.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskBS.EndEdit();
            taskTableAdapter1.Update(companyDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить задание?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }        
    }
}
