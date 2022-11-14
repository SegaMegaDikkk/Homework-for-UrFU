//Methods

using System;

namespace Methods
{
    class Program
    {
        static double Count(int a, int b)
        {
            return ((Math.Sqrt(a) + a) / b);
        }

        public static void Main()
        {
            Console.WriteLine("Значение выражения равно = " + (Count(6, 2) + Count(13, 5) + Count(21, 3)));
        }
    }
}
