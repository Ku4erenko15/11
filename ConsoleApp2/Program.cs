using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 8.Изменение размера массива.
            int[]omas = {8,4,5,4,6,3,2,1};
            Array.Resize(ref omas, 4);
            foreach (var num in omas) 
            {
                Console.Write($"{num}"); 
            }   
            Console.ReadLine();
        }
    }
}
