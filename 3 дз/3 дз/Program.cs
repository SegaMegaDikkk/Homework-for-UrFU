//SignsOfNumber

using System;

namespace Nuber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двухзначное число");
            int num = Convert.ToInt32(Console.ReadLine());
            int FirstSign = num / 10;
            int SecondSign = num % 10;
            Console.WriteLine("Число десятков - " + FirstSign + " Число единиц - " + SecondSign);
            Console.WriteLine("Сумма цифр числа - " + FirstSign + SecondSign + " Произведение цифр - " + FirstSign * SecondSign);
        }
    }
}
