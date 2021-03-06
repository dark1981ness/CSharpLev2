﻿using System;
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

        private void tbSName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextFields();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextFields();
        }

        private void tbPatr_TextChanged(object sender, EventArgs e)
        {
            ValidateTextFields();
        }

        private void tbSalary_TextChanged(object sender, EventArgs e)
        {
            ValidateTextFields();
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSName_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyChar(e);
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyChar(e);
        }

        private void tbPatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyChar(e);
        }

        private void ValidateTextFields()
        {
            btnOK.Enabled = !String.IsNullOrWhiteSpace(tbSName.Text) &&
                            !String.IsNullOrWhiteSpace(tbName.Text) &&
                            !String.IsNullOrWhiteSpace(tbPatr.Text) &&
                            !String.IsNullOrWhiteSpace(tbSalary.Text);
        }
        private static void AllowOnlyChar(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
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
