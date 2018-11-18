using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.ConvertoToAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            string numToConvert = Console.ReadLine();
            long dec = 0;

            dec = FromToDec(numToConvert, from);

            char[] newNumber = new char[numToConvert.Length * 4];
            newNumber = DecToTo(dec, to, numToConvert.Length * 4);

            //print
            int i = 0;
            while (newNumber[i] == 0) i++;
            for (; i < newNumber.Length; i++)
            {
                Console.Write(newNumber[i]);
            }
            Console.WriteLine();

        }

        private static long FromToDec(string num, int from)
        {
            long dec = 0;
            int cnt = num.Length - 1;
            int stepen = 0;
            while (cnt >= 0)
            {
                int stepNumber = num[cnt] - 48;
                if (stepNumber > 9) stepNumber -= 7;
                dec += stepNumber * (int)Math.Pow(from, stepen++);
                cnt--;
            }
            return dec;
        }

        private static char[] DecToTo(long decNum, int TO, int lenght)
        {
            char[] tmp = new char[lenght];
            short cnt = 0;

            do
            {
                if (((decNum % TO) >= 0) && ((decNum % TO <= 9)))
                {
                    tmp[cnt] = (char)((decNum % TO) + 48);
                }
                else
                {
                    tmp[cnt] = (char)((decNum % TO) + 48 + 7);
                }
                decNum = decNum / TO;
                cnt++;
            }
            while (decNum > 0);
            Array.Reverse(tmp);
            return tmp;
        }

    }
}
