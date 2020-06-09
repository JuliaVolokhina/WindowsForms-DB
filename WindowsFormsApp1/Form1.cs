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
    public partial class Form1 : Form
    {
        void Clear()
        {
            errorProvider1.SetError(button1, "");
        }
        public Form1()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            String s1 = this.textBox1.Text;
            String s2 = this.textBox2.Text;

            if (s1 == "user" && s2 == "user")
            {
                Form2 u = new Form2();
                this.Hide();
                u.ShowDialog();
            }

            else if (s1 == "admin" && s2 == "admin")
            {
                Form3 a = new Form3();
                this.Hide();
                a.ShowDialog();
            }

            else errorProvider1.SetError(button1, "Неверный логин и/или пароль");
        }
    }
}
