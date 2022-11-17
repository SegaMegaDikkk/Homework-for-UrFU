using System;

namespace Area
{

    class Program
    {

        public bool Condition(double x, double y)
        {
            if (y > 0.5 & y < 1.5 & x < 2)
                return true;
            else if (x > 2)
                return true;
            else
                return false;
        }

        static void Main()
        {
            var pr = new Program();
            Console.WriteLine("Введите координаты точки (x, y)");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(pr.Condition(x, y));
        }
    }
}