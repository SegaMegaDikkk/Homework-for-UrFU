//Geometry
using System;

namespace Geometry
{
    class Program
    {
        static double area(double edge)
        {
            return (2 * (Math.Sqrt(3)) * (edge * edge));
        }

        static double volume(double edge)
        {
            return (Math.Pow(edge, 3) * (Math.Sqrt(2)) / 3);
        }
        public static void Main()
        {
            Console.WriteLine("Введите сторону октаэдра:");
            double edge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь поверхности - " + Math.Round(area(edge), 2));
            Console.WriteLine("Объем - " + Math.Round(volume(edge), 2));
        }
    }
}
