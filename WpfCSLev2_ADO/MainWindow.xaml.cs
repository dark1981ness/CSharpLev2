using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq;
using System.Collections.ObjectModel;
using System.Configuration;

namespace WpfCSLev2_ADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        public MainWindow()
        {
            InitializeComponent();

            //this.DataContext = employeeViewModel;
        }

        #region window title bar
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

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region slide menu
        private void CloseMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuBtn.Visibility = Visibility.Visible;
            CloseMenuBtn.Visibility = Visibility.Collapsed;
        }

        private void OpenMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuBtn.Visibility = Visibility.Collapsed;
            CloseMenuBtn.Visibility = Visibility.Visible;
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            switch (item.Name)
            {
                case "Home":
                    
                    AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
                    addDepartmentForm.depListView.DataContext = dataTable.DefaultView;
                    //addDepartmentForm.AddDepData += (s, ev) => employeeViewModel.GetDepartment.Add(new Department { Id = ev.Id, Name = ev.Name });
                    //addDepartmentForm.UpdateDepData += (s, ev) =>
                    //    {
                    //        var result = employeeViewModel.GetDepartment.Where(x => x.Id == ev.Id).FirstOrDefault();
                    //        result.Name = ev.Name;
                    //    };
                    //addDepartmentForm.RemoveDepData += (s, ev) => employeeViewModel.GetDepartment.Remove(employeeViewModel.GetDepartment.Where(x => x.Id == ev.Id).FirstOrDefault());
                    addDepartmentForm.Show();
                    break;
                case "Employees":
                    DataRow dataRow = dataTable.NewRow();
                    AddEmployeeForm addEmployeeForm = new AddEmployeeForm(dataRow);
                    addEmployeeForm.ShowDialog();
                    if (addEmployeeForm.DialogResult.HasValue && addEmployeeForm.DialogResult.Value)
                    {
                        dataTable.Rows.Add(addEmployeeForm.Employee);
                        dataAdapter.Update(dataTable);
                    }
                    break;
                case "Logout":
                    Application.Current.Shutdown();
                    break;
            }
        }

        #endregion

        private void MainCC_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;
            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void employeeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestBase"].ConnectionString;
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();

            // fill datatable
            //string cmdText = @"SELECT id, surname, name, patronymic, birthday, age, salary, position,
            //phone, email, department_id FROM employees";
            string cmdText = @"SELECT employees.id, employees.surname, employees.name, employees.patronymic, employees.birthday, employees.age, employees.salary, employees.position,
employees.phone, employees.email, employees.department_id, departments.id AS 'dep_id', departments.name AS 'dep_name' FROM employees
INNER JOIN departments ON employees.department_id = departments.id;";
            SqlCommand command = new SqlCommand(cmdText, connection);
            dataAdapter.SelectCommand = command;

            //insert
            string insertText = @"INSERT INTO employees (surname, name, patronymic, birthday, salary, position,
            phone, email, department_id) VALUES (@surname, @name, @patronymic, @birthday, @salary, @position,
            @phone, @email, @department_id); SET @id = @@IDENTITY;";
            command = new SqlCommand(insertText, connection);
            command.Parameters.Add("@surname", SqlDbType.NVarChar, 50, "surname");
            command.Parameters.Add("@name", SqlDbType.NVarChar, 50, "name");
            command.Parameters.Add("@patronymic", SqlDbType.NVarChar, 50, "patronymic");
            command.Parameters.Add("@birthday", SqlDbType.Date, 0, "birthday");
            command.Parameters.Add("@salary", SqlDbType.Float, 0, "salary");
            command.Parameters.Add("@position", SqlDbType.NVarChar, 50, "position");
            command.Parameters.Add("@phone", SqlDbType.NVarChar, 50, "phone");
            command.Parameters.Add("@email", SqlDbType.NVarChar, 50, "email");
            command.Parameters.Add("@department_id", SqlDbType.Int, 0, "department_id");
            SqlParameter parameter = command.Parameters.Add("@id", SqlDbType.Int, 0, "id");
            parameter.Direction = ParameterDirection.Output;
            dataAdapter.InsertCommand = command;

            //update
            string updateText = @"UPDATE employees SET surname = @surname, name = @name, patronymic = @patronymic, birthday = @birthday,
            salary = @salary, position = @position,
            phone = @phone, email = @email, department_id = @department_id WHERE id = @id;";
            command = new SqlCommand(updateText, connection);
            command.Parameters.Add("@surname", SqlDbType.NVarChar, 50, "surname");
            command.Parameters.Add("@name", SqlDbType.NVarChar, 50, "name");
            command.Parameters.Add("@patronymic", SqlDbType.NVarChar, 50, "patronymic");
            command.Parameters.Add("@birthday", SqlDbType.Date, 0, "birthday");
            command.Parameters.Add("@salary", SqlDbType.Float, 0, "salary");
            command.Parameters.Add("@position", SqlDbType.NVarChar, 50, "position");
            command.Parameters.Add("@phone", SqlDbType.NVarChar, 50, "phone");
            command.Parameters.Add("@email", SqlDbType.NVarChar, 50, "email");
            command.Parameters.Add("@department_id", SqlDbType.Int, 0, "department_id");
            parameter = command.Parameters.Add("@id", SqlDbType.Int, 0, "id");
            parameter.SourceVersion = DataRowVersion.Original;
            dataAdapter.UpdateCommand = command;

            //remove
            string removeText = @"DELETE FROM employees WHERE id = @id";
            command = new SqlCommand(removeText, connection);
            parameter = command.Parameters.Add("@id", SqlDbType.Int, 0, "id");
            parameter.SourceVersion = DataRowVersion.Original;
            dataAdapter.DeleteCommand = command;

            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            MainGrid.DataContext = dataTable.DefaultView;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView rowView = (DataRowView)MainGrid.SelectedItem;
            rowView.BeginEdit();
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(rowView.Row);
            addEmployeeForm.ShowDialog();
            if (addEmployeeForm.DialogResult.HasValue && addEmployeeForm.DialogResult.Value)
            {
                rowView.EndEdit();
                dataAdapter.Update(dataTable);
            }
            else
            {
                rowView.CancelEdit();
            }
        }
    }
}
