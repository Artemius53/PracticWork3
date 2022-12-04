using System;


namespace PracticWork3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int computerNumber = rand.Next(1, 100);
            int count = 0;
            int userNumber;

            while (true)
            {
                Console.WriteLine("Введите число:");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber < computerNumber)
                {
                    Console.WriteLine("Число меньше загаданного");
                }
                else if (userNumber > computerNumber)
                {
                    Console.WriteLine("Число больше загаданного");
                }
                else
                { 
                    Console.WriteLine($"Ура!!!\nТы угадал число!!!\nКоличество попыток: {count}.");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
