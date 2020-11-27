using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfCSLev2_ADO
{
    /// <summary>
    /// Interaction logic for AddDepartmentForm.xaml
    /// </summary>
    public partial class AddDepartmentForm : Window
    {

        public DataTable Department { get; set; }
        public AddDepartmentForm(DataTable dataRow)
        {
            InitializeComponent();
            Department = dataRow;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            depListView.ItemsSource = Department.DefaultView;
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

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            string cmdText = "INSERT INTO departments(name) VALUES(@name)";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestBase"].ConnectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            cmd.Parameters.AddWithValue("@name", depName.Text);
            dataAdapter.InsertCommand = cmd;
            dataAdapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChangeDepartment_Click(object sender, RoutedEventArgs e)
        {
            string cmdText = "UPDATE departments SET name = @name WHERE id = @id";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestBase"].ConnectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(depId.Text));
            cmd.Parameters.AddWithValue("@name", depName.Text);
            dataAdapter.UpdateCommand= cmd;
            dataAdapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void RemoveDepartment_Click(object sender, RoutedEventArgs e)
        {
            string cmdText = @"DELETE FROM departments WHERE id = @id";
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestBase"].ConnectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(depId.Text));
            dataAdapter.DeleteCommand = cmd;
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
