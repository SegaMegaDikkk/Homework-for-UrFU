using System;

namespace Coub
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два целых числа > 0");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Кубы чисел от " + a + " до " + b);
            for (int i = a; i <= b; i++) 
            {
                Console.WriteLine(i + "^3 = " + Math.Pow(i, 3));
                sum = sum + i*i*i;
            }
            Console.WriteLine("Сумма кубов = " + sum);
        }
    }
}