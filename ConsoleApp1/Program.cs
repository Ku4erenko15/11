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
            //Задача 1.Определить количество элементов одномерного массива
            int[] omas = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine($"Size:{omas.Length}");
            string[] omas1 = { "Iphone", "Samsung", "Google" };
            int size = omas1.Length;
            Console.WriteLine($"Size:{size}");
            Console.ReadKey();
        }
    }
}
