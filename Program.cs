using System;

namespace Exam
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Список всех циклических чисел до 10^6:");
            var pr = new Program();
            int[] mass = new int[6]; 
            for (int number = 2; number < 1000000; number++)
            {
                int newNumber = number;
                int i = 0;
                int digits = 0;
                int newCount = 0;
                if (pr.IfAnyDividers(number) == true)
                {
                    while (number > 0)
                    {
                        mass[i] = number % 10;
                        number /= 10;
                        i++;
                        digits++;
                    }
                }
                for (int j = 0; j < digits; j++)
                    for (int q = 0; q < digits; q++)
                        for (int w = 0; w < digits; w++)
                            for (int e = 0; e < digits; e++)
                                for (int r = 0; r < digits; r++)
                                    for (int z = 0; z < digits; z++)
                                    {
                                        if (j == q || j == w || j == e || j == z || j == r || q == w || q == e || q == r || q ==z || w == e || w == r || w ==z || e == r || e == z || r == z)
                                            break;
                                        else
                                        {
                                            double num = mass[i] * Math.Pow(10, digits) + mass[q] * Math.Pow(10, digits - 1) + mass[w] * Math.Pow(10, digits-2) + mass[e] * Math.Pow(10, digits-3) + mass[r] * Math.Pow(10, digits - 4) + mass[z] * Math.Pow(10, digits - 5);
                                            if (pr.IfAnyDividers(num) == false)
                                                newCount--;
                                        }
                                    }
            }
        }

        public bool IfAnyDividers(double number)
        {
            int sum = 0;
            for (int i = 2; i < (number / 2) + 1; i++)
                if (number % i == 0)
                    sum++;
            if (sum == 0)
                return true;
            else return false;
        }
    }
}
