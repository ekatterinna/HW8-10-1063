using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ArabicToRoman
{
    class Program
    {
        static string ToRoman(uint arabic)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < arabic; i++)
            {
                while (arabic >= 1000)
                {
                    //check for thousands place
                    result.Append("M");
                    arabic = arabic - 1000;
                }
                while (arabic >= 900)
                {
                    //check for nine hundred place
                    result.Append("CM");
                    arabic = arabic - 900;
                }
                while (arabic >= 500)
                {
                    //check for five hundred place
                    result.Append("D");
                    arabic = arabic - 500;
                }
                while (arabic >= 400)
                {
                    //check for four hundred place
                    result.Append("CD");
                    arabic = arabic - 400;
                }
                while (arabic >= 100)
                {
                    //check for one hundred place
                    result.Append("C");
                    arabic = arabic - 100;
                }
                while (arabic >= 90)
                {
                    //check for ninety place
                    result.Append("XC");
                    arabic = arabic - 90;
                }
                while (arabic >= 50)
                {
                    //check for fifty place
                    result.Append("L");
                    arabic = arabic - 50;
                }
                while (arabic >= 40)
                {
                    // check for forty place
                    result.Append("XL");
                    arabic = arabic - 40;
                }

                while (arabic >= 10)
                {
                    // check for tenth place
                    result.Append("X");
                    arabic = arabic - 10;
                }
                while (arabic >= 9)
                {
                    //check for nineth place
                    result.Append("IX");
                    arabic = arabic - 9;
                }
                while (arabic >= 5)
                {
                    //check for fifth place
                    result.Append("V");
                    arabic = arabic - 5;
                }
                while (arabic >= 4)
                {
                    //check for fourth place
                    result.Append("IV");
                    arabic = arabic - 4;
                }
                while (arabic >= 1)
                {
                    //check for first place
                    result.Append("I");
                    arabic = arabic - 1;
                }
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            if (n >= 4000 || n == 0) Console.WriteLine("Error");
            else Console.WriteLine(ToRoman(n));
        }
    }
}

