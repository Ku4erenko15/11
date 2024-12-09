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
            //Задача 2.Обнулить заданный диапазон элементов в одномерном массиве.
            int[] omas = Input(Size());
            Array.Clear(omas,1,3);
            Output(omas);
            Console.ReadKey(); 
        }
        static int Size()

        {
            Console.WriteLine("Size");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            { Console.WriteLine("error"); }
            return size;
        }
        static int[] Input (int size)
        {
            int[] omas = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Input {i+1}");
                omas[i]=int.Parse(Console.ReadLine());
            }
            return omas;
        }
        static void Output(int[]omas)
        {
            foreach (var el in omas)
            {
                Console.WriteLine(el);
            }
        }
    }
}
