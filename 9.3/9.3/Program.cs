using System;

namespace NumberInsideOut
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            int insertnum = 0;
            while (number > 0)
            {
                insertnum = insertnum * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine($"Перевернутое число {insertnum}");
        }
    }
}

