using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace BinToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger bin = BigInteger.Parse(input);
            BigInteger theDec = 0;

            string tmpbin = bin.ToString();
            if ((input.Length % 8 == 0) && tmpbin[0] == 1 + '0')
            {
                BigInteger justOnes = new BigInteger();
                for (int i = 0; i < tmpbin.Length; i++)
                {
                    justOnes += 1 * (BigInteger)Math.Pow(10, i);
                }
                bin = justOnes - bin + 1;
                theDec = -toDec(bin);
            }
            else
            {
                theDec = toDec(bin);
            }

            Console.WriteLine(theDec);
        }

        private static BigInteger toDec(BigInteger bin)
        {
            BigInteger decNum = 0;
            int cnt = 0;
            while (bin > 0)
            {
                decNum += (BigInteger)(bin % 10) * (BigInteger)Math.Pow(2, cnt);
                bin /= 10;
                cnt++;
            }
            return decNum;
        }
    }
}

