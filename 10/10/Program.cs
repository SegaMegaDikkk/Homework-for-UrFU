using System;
using System.Xml;

namespace Mass
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Введите целочисленные первый член последовательности и ее разность");
            int firstNum = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] nums = new int[10];
            nums[0] = firstNum;
            for (int i = 1; i < 10; i++)
                nums[i] = nums[i - 1] + step;
            var pr = new Program();
            pr.OutputMass(nums);
            Console.WriteLine("Введите целое число, на которое увеличится каждый элемент массива");
            int plus = int.Parse(Console.ReadLine());
            pr.Summ(nums, plus);
            pr.OddNums(nums);
            Console.WriteLine("Введите степень, на которую увеличить каждый элемент массива");
            int degreeOfMass = int.Parse(Console.ReadLine());
            pr.Degree(nums, degreeOfMass);
        }
        public void OutputMass(int[] nums)
        {
            Console.WriteLine("Ваша последовательность:");
            for (int i = 0; i < 9; i++)
                Console.Write(nums[i] + ", ");
            Console.WriteLine(nums[9]);
        }
        public void Summ(int[] nums, int plus)
        {
            Console.WriteLine($"Ваша последовательность увеличенная на {plus}:");
            for (int i = 0; i < 9; i++)
                Console.Write((nums[i] + plus) + ", ");
            Console.WriteLine(nums[9] + plus);
        }
        public void OddNums(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
                if (nums[i] % 2 == 1)
                    sum++;
            Console.WriteLine($"Количество нечетных чисел массива = {sum}");
        }
        public void Degree(int[] nums, int degreeOfMass)
        {
            double[] degreeNums = new double[10];
            Console.WriteLine($"Ваша последовательность в степени {degreeOfMass}:");
            for (int i = 0; i < 9; i++)
            {
                degreeNums[i] = Math.Pow(nums[i], degreeOfMass);
                Console.Write(degreeNums[i] + ", ");
            }
            degreeNums[9] = Math.Pow(nums[9], degreeOfMass);
            Console.WriteLine(degreeNums[9]);
        }
    }
}
