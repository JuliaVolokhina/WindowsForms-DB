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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.sickLeaveTableAdapter1.Fill(this.companyDataSet1.SickLeave);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SickLBS.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SickLBS.EndEdit();
            sickLeaveTableAdapter1.Update(companyDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить больничный?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void SickLBNSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.SickLBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.companyDataSet1);
        }
    }
}
