﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form14 : Form
    {
        public SqlConnection bd;// ПОКЛЮЧЕНИЕ К ФАЙЛУ БД
        public SqlCommand cmnd;// служит для задания команд
        public SqlDataAdapter dtad;// для адаптации
        public DataSet ds;// переменная в которую передаём бд
        public BindingSource bindingSource;//для построние таблицы

        const string _ConnectionString = @"Data Source=IBPPM-BIOENG\SQLEXPRESS; Initial Catalog=Company; Integrated Security=True";
        DataTable _dataTable;
        public DataTable GetDataSet { get { return _dataTable; } }
        public SqlConnection _con = new SqlConnection(_ConnectionString);
        SqlDataAdapter _adapter;
        SqlCommandBuilder _scb;

        private void View_table(string cmd, string name)
        {
            _adapter = new SqlDataAdapter(cmd, _con);
            _scb = new SqlCommandBuilder(_adapter);
            _dataTable = new DataTable();
            DataSet _dataset = new DataSet();
            _dataTable.TableName = name;
            _adapter.Fill(_dataTable);
            dataGridView1.DataSource = _dataTable.DefaultView;
            dataGridView2.DataSource = _dataTable.DefaultView;
            dataGridView3.DataSource = _dataTable.DefaultView;
        }

        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ageEmpl = int.Parse(textBox1.Text);
            string s1 = "EXEC  EmployeePositionProc'" + ageEmpl.ToString() + "'";
            View_table(s1, "");
        }

        //private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.employeeTableAdapter1.FillBy2(this.companyDataSet1.Employee);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
