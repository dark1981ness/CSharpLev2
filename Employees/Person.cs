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
        private int _pid;
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

        public int ID
        {
            get { return _pid; }
            set { _pid = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Person() { }

        public Person(string name, string surname, string patronymic, int age, int id, double salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Age = age;
            ID = id;
            Salary = salary;
        }

        public Person(string name, string surname, string patronymic, int id) : this(name, surname, patronymic, 0, id, 0) { }

        public abstract double Payment();
    }
}
