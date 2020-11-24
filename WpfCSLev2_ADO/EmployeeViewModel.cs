using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Linq;

namespace WpfCSLev2_ADO
{
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> GetEmployee { get; set; } = new ObservableCollection<Employee>();
        
        public ObservableCollection<Department> GetDepartment { get; set; } = new ObservableCollection<Department>();
    }
}
