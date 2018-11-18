using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.LastDigitInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string lastDigit = GetLast(num % 10);
            Console.WriteLine(lastDigit);
        }
        static string GetLast(int num)
        {
            if (num < 0) num = -num;

            if (num == 0) return "Zero";
            else if (num == 1) return "One";
            else if (num == 2) return "Two";
            else if (num == 3) return "Three";
            else if (num == 4) return "Four";
            else if (num == 5) return "Five";
            else if (num == 6) return "Six";
            else if (num == 7) return "Seven";
            else if (num == 8) return "Eight";
            return "Nine";
        }
    }
}

