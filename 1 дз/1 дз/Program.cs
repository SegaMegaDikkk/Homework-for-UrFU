using System;

namespace Poem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("В. Маяковский ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("А вы могли бы?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Я сразу смазал карту будня,\nплеснувши краску из стакана;\nя показал на блюде студня\nкосые скулы океана.\nНа чешуе жестяной рыбы\nпрочел я зовы новых губ.\nА вы\nноктюрн сыграть\nмогли бы\nна флейте водосточных труб?");
            Console.ResetColor();
        }
    }
}
