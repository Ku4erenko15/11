using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3.Найти максимальное и минимальное значение в массиве.
            int[]omas = { 1, 2, 3, 4 , 5 };
            int max = omas.Max();
            int min = omas.Min();
            Console.WriteLine(max, min);
            Console.ReadKey();
        }
    }
}
