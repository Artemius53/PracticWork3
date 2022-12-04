using System;

namespace PtacticWork3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool easyNum = true;
            Console.WriteLine("Введите целое число: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    easyNum = false;
                    break;
                }
            }
            if (easyNum)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();



        }
    }
}
