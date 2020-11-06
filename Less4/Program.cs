using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Less4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex3();
        }

        private static void Ex3()
        {
           
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four",4 },
                {"two",2 },
                { "one",1 },
                {"three",3 },
            };
            var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });
            foreach (var pair in d)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.WriteLine();
            Console.WriteLine($"обращение к OrderBy с использованием лямбда-выражения\n");
            var a = dict.OrderBy(pair => pair.Value);
            foreach (var pair in a)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.WriteLine();
            Console.WriteLine($"*Развернуть обращение к OrderBy с использованием делегата \n");
            int myPredicate(KeyValuePair<string, int> pair) => pair.Value;
            Func<KeyValuePair<string, int>, int> func = myPredicate;
            var c = dict.OrderBy(func);
            foreach (var pair in c)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }


    }
}
