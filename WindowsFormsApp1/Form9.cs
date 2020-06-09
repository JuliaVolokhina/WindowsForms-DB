﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.salaryTableAdapter1.Fill(this.companyDataSet1.Salary);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalaryBS.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryBS.EndEdit();
            salaryTableAdapter1.Update(companyDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить зарплату?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void SalaryBNSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.SalaryBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.companyDataSet1);
        }
    }
}