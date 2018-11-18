using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int reverse = Reverse(number);
            Console.WriteLine(reverse);
        }

        static int CountDigits(int num)
        {
            int cnt = 0;
            while (num != 0)
            {
                num /= 10;
                cnt++;
            }
            return cnt;
        }

        static int Reverse(int num)
        {
            int cnt = CountDigits(num);
            int tmpNum = 0;
            for (int i = cnt - 1; i >= 0; i--)
            {
                tmpNum += (num % 10) * (int)Math.Pow(10, i);
                num /= 10;
            }
            return tmpNum;
        }
    }
}

