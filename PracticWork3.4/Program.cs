using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество элементов массива");
                   int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
                        int minValue = a.Min<int>();
            Console.WriteLine("минимальный элемент массива: " + minValue);
            Console.ReadKey();
        }
    }  
}
