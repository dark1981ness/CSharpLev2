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


    public partial class Form2 : Form
    {
        public event EventHandler ReturnBtnState;
        public event EventHandler<EmployeeEventArgs> AddEmployeeData;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnBtnState?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ReturnBtnState?.Invoke(this, EventArgs.Empty);
            AddEmployeeData?.Invoke(this, new EmployeeEventArgs(tbName.Text, tbSName.Text, tbPatr.Text, numericAge.Value, double.Parse(tbSalary.Text)));
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double result = double.Parse(tbHours.Text) * double.Parse(tbDays.Text) * double.Parse(tbWageRate.Text);
            tbSalary.Text = result.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSalaryType.SelectedItem.ToString() == "Почасовая")
                gbSalary.Visible = true;
            if (cbSalaryType.SelectedItem.ToString() == "Фиксированная")
                gbSalary.Visible = false;
        }
    }

    public class EmployeeEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public decimal Age { get; set; }
        public double Salary { get; set; }

        public EmployeeEventArgs(string name, string surname, string patronymic, decimal age, double salary)
        {
            Name = name;
            SurName = surname;
            Patronymic = patronymic;
            Age = age;
            Salary = salary;
        }
    }
}
