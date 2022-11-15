using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLanguage
{
    class Program
    {

        public string Leet(string text)
        {
            text = text.Replace("a", "4");
            text = text.Replace("b", "8");
            text = text.Replace("c", ")");
            text = text.Replace("d", "|)");
            text = text.Replace("e", "3");
            text = text.Replace("f", "|=");
            text = text.Replace("g", "6");
            text = text.Replace("h", "|-|");
            text = text.Replace("i", "!");
            text = text.Replace("j", ")");
            text = text.Replace("k", "|<");
            text = text.Replace("l", "1");
            text = text.Replace("m", "|//|");
            text = text.Replace("n", "|/|");
            text = text.Replace("o", "0");
            text = text.Replace("p", "|<");
            text = text.Replace("q", "9");
            text = text.Replace("r", "|2");
            text = text.Replace("s", "5");
            text = text.Replace("t", "7");
            text = text.Replace("u", "|_|");
            text = text.Replace("v", "//");
            text = text.Replace("w", "////");
            text = text.Replace("x", "><");
            text = text.Replace("y", "'/");
            text = text.Replace("z", "2");
            return text;
        }

        static void Main()
        {
            string text = Convert.ToString(Console.ReadLine());
            var pr = new Program();
            Console.WriteLine(pr.Leet(text.ToLower()));

        }
    }
}
