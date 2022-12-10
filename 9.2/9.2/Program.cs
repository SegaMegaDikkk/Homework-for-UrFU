using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество чисел последовательности");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числа");
            int[] number = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
                number[i] = int.Parse(Console.ReadLine());
            if (number[0] % 2 == 0)
            {
                int i = 0;
                while (number[i] % 2 == 0)
                {
                    sum += number[i];
                    i++;
                    if (i >= n) break;

                }
            }
            if (number[0] % 2 == 1)
            {
                int i = 0;
                while (number[i] % 2 == 1)
                {
                    sum += number[i];
                    i++;
                    if (i >= n) break;
                }
            }
            Console.WriteLine("Сумма равна " + sum);

        }
    }
}