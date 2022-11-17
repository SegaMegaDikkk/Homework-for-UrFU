using System;
using static System.Net.Mime.MediaTypeNames;

namespace Chess
{

    class Program
    {
  
        static void Main()
        {

            Console.WriteLine("Введите позицию белого коня в формате 'буква' ENTER 'цифра'");
            char LetterOfKnight = Convert.ToChar(Console.ReadLine());
            int NumOfKnight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию черной ладьи в формате 'буква' ENTER 'цифра'");
            char LetterOfRook = Convert.ToChar(Console.ReadLine());
            int NumOfRook = Convert.ToInt32(Console.ReadLine());
            //Далее я решила немного усложнить себе задачу и проверить корректность введенных данных
            if (LetterOfRook > 'h' | LetterOfKnight > 'h' | NumOfRook > 8 | NumOfRook <= 0 | NumOfKnight > 8 | NumOfKnight <= 0)
                Console.WriteLine("Введены некорректные данные, повторите ввод");
            else if (LetterOfKnight == LetterOfRook | NumOfKnight == NumOfRook)
                Console.WriteLine("Конь находится под боем ладьи или же их позиции совпадают.\nВведите другое значение.");
            else
            {
                Console.WriteLine("Введите вторую позицию белого коня в формате 'буква' ENTER 'цифра'");
                char LetterOfKnightSecondPosition = Convert.ToChar(Console.ReadLine());
                int NumOfKnightSecondPosition = Convert.ToInt32(Console.ReadLine());
                int MinusLetters = LetterOfKnightSecondPosition - LetterOfKnight;
                int MinusNumbers = NumOfKnightSecondPosition - NumOfKnight;
                //Console.WriteLine(MinusLetters); проверяла значения для себя
                //Console.WriteLine(MinusNumbers);
                //снова проверяю корректность
                if (LetterOfKnightSecondPosition > 'h' | NumOfKnightSecondPosition > 8 | NumOfKnightSecondPosition <= 0)
                    Console.WriteLine("Введены некорректные данные, повторите ввод");
                else if ((MinusLetters * MinusNumbers == 2) || (MinusLetters * MinusNumbers == -2))
                 { 
                     if (LetterOfKnightSecondPosition == LetterOfRook | NumOfKnightSecondPosition == NumOfRook)
                         Console.WriteLine("Конь попадает под бой ладьи");
                     else
                         Console.WriteLine("Конь не попадает под бой ладьи");
                 }
                else
                    Console.WriteLine("Некорректный ход коня, не забывайте, эта фигура ходит буквой Г");
            }
        }
    }
}