using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class FixedSalary : Person
    {
        public FixedSalary(string name, string surname, string patronymic, int id) : base(name, surname, patronymic, id) { }
        public override double Payment()
        {
            return Salary;
        }
    }
}
