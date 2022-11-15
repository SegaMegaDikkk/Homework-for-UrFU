using System;

namespace Functions

{
    class Program
    {
        public int FuncUnderZero()
        {
            return -1;
        }

        public int FuncZero()
        {
            return 0;
        }

        public int FuncOverZero()
        {
            return 1;
        }
        static void Main()
        {
            Console.WriteLine("Введите аргумент функции");
            double x = Convert.ToDouble(Console.ReadLine());
            var pr = new Program();
            if (x > 0)
                Console.WriteLine("Значение функции = " + pr.FuncOverZero());
            else if (x == 0)
                Console.WriteLine("Значение функции = " + pr.FuncZero());
            else 
                Console.WriteLine("Значение функции = " + pr.FuncUnderZero());
        }
    }
}
