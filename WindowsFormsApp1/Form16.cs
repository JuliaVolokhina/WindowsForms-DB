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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            //this.sickLeaveTableAdapter1.Fill(this.companyDataSet1.SickLeave);
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

        private void SickLBNSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.SickLBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.companyDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBS.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListBS.EndEdit();
            listOfSickLeaveTableAdapter1.Update(companyDataSet1);
        }

        private void ListBNSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ListBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.companyDataSet1);
        }
    }
}
