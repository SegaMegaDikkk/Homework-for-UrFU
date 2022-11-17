using System;

namespace Homework
{

    class Program
    {

        public bool CountNum(double m, double n)
        {
            if (m > 0 | n > 0)
                return true;
            else 
                return false;
        }

        static void Main()
        {
            var pr = new Program();
            Console.WriteLine("Введите два числа");
            double m = Convert.ToDouble(Console.ReadLine());
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(pr.CountNum(m, n));

        }

    }
}
