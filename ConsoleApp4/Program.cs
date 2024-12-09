using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 4.Сортировка массива по возрастанию.
            int[] omas = { 2, 3, 7, 8, 2, 3, 4, 6, 9, 5 };
            Array.Sort(omas);
            foreach (var om in omas)
            {
                Console.Write(om + " ");
            }
            Array.Reverse(omas); 
            Console.WriteLine();
            foreach (var om in omas)
            {
                Console.Write(om + " ");
            }
            Console.ReadKey ();
        }
    }
}
