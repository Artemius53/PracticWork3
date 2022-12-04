using System;


namespace PracticWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите целое число: ");
            a = Int32.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
            Console.ReadKey();
        }
    }
}
