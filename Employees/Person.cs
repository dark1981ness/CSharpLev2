using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract class Person
    {

        private string _pName;
        private string _pSurname;
        private string _pPatronymic;
        private int _pAge;
        private double _salary;

        public string Name
        {
            get { return _pName; }
            set { _pName = value; }
        }

        public string Surname
        {
            get { return _pSurname; }
            set { _pSurname = value; }
        }

        public string Patronymic
        {
            get { return _pPatronymic; }
            set { _pPatronymic = value; }
        }

        public int Age
        {
            get { return _pAge; }
            set { _pAge = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Person() { }

        public Person(string name, string surname, string patronymic, int age, double salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Age = age;
            Salary = salary;
        }

        public abstract double Payment();
    }
}
