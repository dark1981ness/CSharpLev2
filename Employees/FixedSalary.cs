using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class FixedSalary : Person
    {
        public FixedSalary() { }
        public FixedSalary(string name, string surname, string patronymic, decimal age, double salary) : base(name, surname, patronymic, age, salary) { }
        public override double Payment()
        {
            return Salary;
        }
    }
}
