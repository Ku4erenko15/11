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
            //Задача 10.Удаление всех четных элементов из массива. В новом массиве сложить элементы
            int[] omas = {3,7,1,9,5,6,8,10};
            omas =omas.Where(x => x%2!=0).ToArray();
            foreach (int i in omas)
            {
                Console.WriteLine(i);              
            }
            int sum = omas.Sum();
            Console.WriteLine(sum);
            Console.ReadKey();  
        }
    }
}
