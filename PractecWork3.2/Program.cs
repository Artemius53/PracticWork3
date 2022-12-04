using System;


namespace PracticWork3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую тебя, дорогой друг!!!");
            Console.WriteLine("Эта игра в простонародии называется Очко или по-другому 21.");
            Console.WriteLine("\nПодскажи, сколько карт находится в твоих руках?");
            Console.WriteLine("\nВведи это число: ");

            int handCards = Int32.Parse(Console.ReadLine());
            int handValue = 0;

            for (int i = 1; i <= handCards; i++)
            {
                Console.WriteLine($"\nВведите номинал {i}-й карты: ");
                string cardValue = Console.ReadLine();
                int Value;
                if (cardValue == "10" || cardValue == "J" || cardValue == "Q" || cardValue == "K" || cardValue == "T")
                    Value = 10;
                else if (cardValue == "2" || cardValue == "3" || cardValue == "4" || cardValue == "5" || cardValue == "6" || cardValue == "7" || cardValue == "8" || cardValue == "9")
                    Value = Int32.Parse(cardValue);
                else
                {
                    Console.WriteLine("Допустимы номиналы 2-10, J, Q, K, T");
                    break;
                }
                handValue += Value;
            }
            Console.WriteLine("\nСумма карт на руках: " + handValue);
            {
                if (handValue == 21)
                {
                    Console.WriteLine("\nДорогой друг, это ПОБЕДА!!!");
                }
                else
                {
                    Console.WriteLine("\nУвы, это проигрыш:(");                   
                }
                Console.ReadKey();
            }
        }
    }
    
}
