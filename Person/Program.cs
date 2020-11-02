using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static Person[] peopledb;
        static void Main(string[] args)
        {
            peopledb = new Person[5]
            {
                new FixedSalary ("Константин", "Носков", "Иванович", 38, 100500),
                new FixedSalary ("Владимир", "Путин", "Владимирович", 68, 100500) ,
                new FixedSalary ("Дмитрий", "Медведев", "Анатольевич", 55, 100500),
                new HourlyWage ("Константин", "Носков", "Иванович", 39, 100500, 1, 3, 1500),
                new HourlyWage ("Константин", "Носков", "Иванович", 39, 100500, 1, 3, 1500)
            };

            Array.Sort(peopledb, FixedSalary.sortNameDes());
            foreach (Person person in peopledb)
                Console.WriteLine(person.Name + "\t" + person.Surname + "\t" + person.Patronymic + "\t" + person.Age + "\t" + person.Salary);

            Console.WriteLine("------------------------------\n\n");
            Array.Sort(peopledb, FixedSalary.sortNameAsc());
            foreach (Person person in peopledb)
                Console.WriteLine(person.Name + "\t" + person.Surname + "\t" + person.Patronymic + "\t" + person.Age + "\t" + person.Salary);
            Console.ReadKey();
        }
    }
}
