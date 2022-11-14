//Math

using System;

namespace Mathematics
{

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите х");
            double x = Convert.ToDouble(Console.ReadLine());
            double function = (Math.Sqrt(x + (1 / (Math.Sqrt(Math.Pow(x, 2) + 4)))));
            Console.WriteLine("Значение y=f(x) при х =" + x + " y = " + function);
        }
    }
}
