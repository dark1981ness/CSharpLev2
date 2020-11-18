using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfCSLev2
{
    /// <summary>
    /// Interaction logic for AddEmployeeForm.xaml
    /// </summary>
    public partial class AddEmployeeForm : Window
    {
        public Employee Employee { get; set; }
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void OnDragMoveWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (e.ClickCount == 2 && this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Employee = new Employee(Convert.ToInt32(this.uId.Text),
                    this.uName.Text,
                    this.uSurname.Text,
                    this.uPatr.Text,
                    Convert.ToDateTime(this.uBithday.Text),
                    Convert.ToByte(this.uAge.Text),
                    Convert.ToSingle(this.uSalary.Text),
                    this.uPos.Text,
                    this.uPhone.Text,
                    this.uEmail.Text
                    );
                //Employee = new Employee
                //{
                //    Id = Convert.ToInt32(this.uId.Text),
                //    Name = this.uName.Text,
                //    Surname = this.uSurname.Text,
                //    Patronymic = this.uPatr.Text,
                //    Birthday = Convert.ToDateTime(this.uBithday.Text),
                //    Age = Convert.ToByte(this.uAge.Text),
                //    Salary = Convert.ToSingle(this.uSalary.Text),
                //    Position = this.uPos.Text,
                //    Phone = this.uPhone.Text,
                //    Email = this.uEmail.Text
                //};
                this.DialogResult = true;
            }
            catch (Exception)
            {
                this.DialogResult = false;
            }
            Close();
        }

        private void Button_Cancek_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
