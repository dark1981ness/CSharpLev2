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
        public Form2()
        {
            
            InitializeComponent();
            
        }

        Form1 mainForm = null;
        public Form2(Form form)
        {
            mainForm = form as Form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.IsEnable = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = double.Parse(textBox7.Text) * double.Parse(textBox6.Text) * double.Parse(textBox5.Text);
            textBox4.Text = result.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Почасовая")
                groupBox1.Visible = true;
            if (comboBox1.SelectedItem.ToString() == "Фиксированная")
                groupBox1.Visible = false;
        }
    }
}
