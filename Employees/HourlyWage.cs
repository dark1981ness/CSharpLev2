using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class HourlyWage : Person
    {
        private double _hours;
        private double _days;
        private double _wageRate;

        public double Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        public double Days
        {
            get { return _days; }
            set { _days = value; }
        }

        public double WageRate
        {
            get { return _wageRate; }
            set { _wageRate = value; }
        }

        public HourlyWage(string name, string surname, string patronymic, int id, double hours, double days, double wagerate) : base(name,surname,patronymic,id)
        {
            Hours = hours;
            Days = days;
            WageRate = wagerate;
        }
        public override double Payment()
        {
            Salary = Days * Hours * WageRate;
            return Salary;
        }
    }
}
