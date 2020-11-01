using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    abstract class Person : IComparable
    {

        private string _pName;
        private string _pSurname;
        private string _pPatronymic;
        private decimal _pAge;
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

        public decimal Age
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
       
        public Person(string name, string surname, string patronymic, decimal age, double salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Age = age;
            Salary = salary;
        }

        public abstract double Payment();

        #region Вспомогательные классы для сортировки

        private class sortAgeAscending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;

                if (c1._pAge > c2._pAge)
                    return 1;

                if (c1._pAge < c2._pAge)
                    return -1;

                else
                    return 0;
            }
        }

        private class sortAgeDescending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;

                if (c1._pAge < c2._pAge)
                    return 1;

                if (c1._pAge > c2._pAge)
                    return -1;

                else
                    return 0;
            }
        }

        private class sortSalaryAscending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;

                if (c1._salary > c2._salary)
                    return 1;

                if (c1._salary < c2._salary)
                    return -1;

                else
                    return 0;
            }
        }

        private class sortSalaryDescending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;

                if (c1._salary < c2._salary)
                    return 1;

                if (c1._salary > c2._salary)
                    return -1;

                else
                    return 0;
            }
        }

        private class sortNameAscending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;
                return String.Compare(c1._pName, c2._pName);
            }
        }
        private class sortNameDescending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;
                return String.Compare(c2._pName, c1._pName);
            }
        }

        private class sortSNameDescending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;
                return String.Compare(c2._pName, c1._pName);
            }
        }

        private class sortPNameAscending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;
                return String.Compare(c1._pName, c2._pName);
            }
        }
        private class sortPNameDescending : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Person c1 = (Person)a;
                Person c2 = (Person)b;
                return String.Compare(c2._pName, c1._pName);
            }
        }
        #endregion

        //Сортировка по умолчанию
        int IComparable.CompareTo(object obj)
        {
            Person person = (Person)obj;
            return String.Compare(this._pSurname, person._pSurname);
        }

        #region Вспомогательные методы, возвращиющие объект IComparer
        public static IComparer sortAgeAsc()
        {
            return (IComparer)new sortAgeAscending();
        }

        public static IComparer sortAgeDes()
        {
            return (IComparer)new sortAgeDescending();
        }
        public static IComparer sortSalaryAsc()
        {
            return (IComparer)new sortSalaryAscending();
        }

        public static IComparer sortSalaryDes()
        {
            return (IComparer)new sortSalaryDescending();
        }

        public static IComparer sortNameAsc()
        {
            return (IComparer)new sortNameAscending();
        }

        public static IComparer sortNameDes()
        {
            return (IComparer)new sortNameDescending();
        }
        public static IComparer sortPNameAsc()
        {
            return (IComparer)new sortPNameAscending();
        }

        public static IComparer sortPNameDes()
        {
            return (IComparer)new sortPNameDescending();
        }
        public static IComparer sortSNameDes()
        {
            return (IComparer)new sortSNameDescending();
        }
        #endregion
    }
}
