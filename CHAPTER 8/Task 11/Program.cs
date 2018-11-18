using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.RomanToArabic
{
    class Program
    {
        static char[] rimNums = { 'i', 'v', 'x', 'l', 'c', 'd', 'm' };
        static void Main(string[] args)
        {
            string roman = Console.ReadLine();
            int arabic = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (!CheckToEnd(roman, i, convertToValue(roman[i])))
                {
                    arabic -= GetValue(roman[i]);
                }
                else arabic += GetValue(roman[i]);
            }
            Console.WriteLine(arabic);
        }

        static int GetValue(char c)
        {
            if (c == 'm') return 1000;
            else if (c == 'd') return 500;
            else if (c == 'c') return 100;
            else if (c == 'l') return 50;
            else if (c == 'x') return 10;
            else if (c == 'v') return 5;
            else if (c == 'i') return 1;
            return 0;
        }

        static bool CheckToEnd(string roman, int pos, int value)
        {
            for (int i = pos + 1; i < roman.Length; i++)
            {
                if (value < convertToValue(roman[i])) return false;
            }
            return true;
        }

        static int convertToValue(char c)
        {
            for (int i = 0; i < rimNums.Length; i++)
            {
                if (c == rimNums[i]) return i;
            }
            return -1;
        }
    }
}
