using System;

namespace Divide
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите промежуток чисел");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите искомую сумму делителей");
            int sumDividersInEachNum = 0;
            int sumOfDividers = int.Parse(Console.ReadLine());
            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int z = 1; z <= i; z++)
                {
                    if (i % z == 0)
                        sumDividersInEachNum += z;
                }
                if (sumDividersInEachNum == sumOfDividers)
                    Console.WriteLine($"{i} удовлетворяет условию");
                sumDividersInEachNum = 0;

            }
        }
    }
}
