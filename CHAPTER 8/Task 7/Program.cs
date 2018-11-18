using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _03.HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            BigInteger dec = 0;

            dec = hexToDec(hex, dec);

            Console.WriteLine(dec);
        }

        private static BigInteger hexToDec(string hex, BigInteger dec)
        {
            int pos = hex.Length - 1;
            int stepen = 0;
            while (pos >= 0)
            {
                int stepNumber = hex[pos] - 48;
                if (stepNumber > 9) stepNumber -= 7;
                dec += stepNumber * (BigInteger)Math.Pow(16, stepen++);
                pos--;
            }
            return dec;
        }
    }
}


