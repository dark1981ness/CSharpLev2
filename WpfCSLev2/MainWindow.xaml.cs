using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCSLev2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> GetD { get; } = new ObservableCollection<Employee>();
        public static ObservableCollection<Department> GetDepartment { get; } = new ObservableCollection<Department>();
        public MainWindow()
        {
            InitializeComponent();
            GetD.Add(new Employee { Id = 1, Name = "Константин", Surname = "Носков", Patronymic = "Иванович", Birthday = new DateTime(1981, 12, 29), Age = 38, Salary = 120000 });
            GetDepartment.Add(new Department { Name = "СКТ" });
            GetDepartment.Add(new Department { Name = "бухгалтерия" });
            GetDepartment.Add(new Department { Name = "водители" });
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
            //switch (item.Name)
            //{
            //    case "Administration":
            //        DataContext = new MenuNavViewModel(1);
            //        break;
            //    case "Home":
            //        DataContext = new MenuNavViewModel(0);
            //        break;
            //    case "Employees":
            //        DataContext = new MenuNavViewModel(2);
            //        break;
            //    case "Scheduller":
            //        DataContext = new MenuNavViewModel(3);
            //        break;
            //    case "Logout":
            //        LoginWindow loginWindow = new LoginWindow();
            //        loginWindow.Show();
            //        this.Close();
            //        break;
            //}
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

        private void MainCC_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;
            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}
