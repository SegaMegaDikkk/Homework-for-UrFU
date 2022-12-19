using System;
using System.Data;
using System.Data.Common;

namespace Table
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите кол-во строк от 5 до 20");
            int row = int.Parse(Console.ReadLine());
            if (row < 5 || row > 20)
                while (row < 5 || row > 20)
                {
                    Console.WriteLine("Ошибка! Введите значение от 5 до 20");
                    row = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Введите кол-во столбцов от 5 до 20");
            int column = int.Parse(Console.ReadLine());
            if (column < 5 || column > 20)
            {
                while (column < 5 || column > 20)
                {
                    Console.WriteLine("Ошибка! Введите значение от 5 до 20");
                    column = int.Parse(Console.ReadLine());
                }
            }
            Random rnd = new Random();
            int[ , ] rndmTable = new int[row, column];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    rndmTable[i, j] = rnd.Next(100);
            TableOutput(rndmTable);
            Console.WriteLine("Введите искомый элемент");
            int find = int.Parse(Console.ReadLine());
            FindElement(rndmTable, find);
            TableMax(rndmTable);
        }
        static void TableOutput(int[ , ] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            { 
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write($"{table[i, j],2} ");
                Console.WriteLine();
            }
        }
        static void FindElement(int[,] table, int a)
        {
            int sum = 0;
            for (int i = 0; i < table.GetLength(0); i++)
                for (int j = 0; j < table.GetLength(1); j++)
                    if (table[i,j] == a)
                    {
                        Console.WriteLine($"Элемент таблицы равный {a} находится на позиции [{i+1}, {j+1}]");
                        sum++;
                    }
            if (sum == 0)
                Console.WriteLine("Такого элемента нет в таблице");
        }
        static void TableMax(int[,] table)
        {
            int max = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                max = 0;
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] > max)
                        max = table[i, j];
                    if (j + 1 == table.GetLength(1))
                        Console.WriteLine($"Самый боьшой элемент строки {i+1} = {max}");
                }
            }
        }
    }
}
