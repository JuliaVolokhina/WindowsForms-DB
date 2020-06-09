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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyDataSetView1.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.companyDataSetView1.View_1);

        }

        private void ViewBNSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.view1BindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(companyDataSet1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view1BindingSource1.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view1BindingSource1.EndEdit();
            view_1TableAdapter.Adapter.Update(companyDataSet1);
        }
    }
}
