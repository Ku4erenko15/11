using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 7.Поиск элемента по условию.
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            string first = Array.Find(people, person => person.Length > 3);
            Console.WriteLine(first);
            string last = Array.FindLast(people, person => person.Length > 3);
            Console.WriteLine(last);
            string[] group = Array.FindAll(people, person => person.Length == 3);
            foreach (var pers in group)
            { 
                Console.WriteLine(pers);
            }
            Console.ReadLine();
        }
    }
}
