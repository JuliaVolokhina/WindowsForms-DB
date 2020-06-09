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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.listOfWorkersTableAdapter1.Fill(this.companyDataSet1.ListOfWorkers);
        }

        private void ListOfWBNSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ListOfWBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.companyDataSet1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfWBS.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListOfWBS.EndEdit();
            listOfWorkersTableAdapter1.Update(companyDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить сотрудника с этой позиции?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }       
    }
}
