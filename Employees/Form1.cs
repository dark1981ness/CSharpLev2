using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Form1 : Form
    {
        List<Person> peopledb;
        public bool IsEnable
        {
            get => button1.Enabled;
            set => button1.Enabled = value;
        }

        public Form1()
        {
            InitializeComponent();
            peopledb = new List<Person>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Form2 form = new Form2();
            form.ReturnBtnState += (s, ev) => IsEnable = true;
            form.AddEmployeeData += (s, ev) => peopledb.Add(new FixedSalary { Name = ev.Name, Surname = ev.SurName, Patronymic = ev.Patronymic, Age = ev.Age, Salary = ev.Salary });
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = peopledb;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
