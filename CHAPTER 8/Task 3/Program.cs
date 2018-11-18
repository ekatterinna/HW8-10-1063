using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ConvertSomeHexToDecAndBin
{
    class Program
    {
        //2A3E, FA, FFFF, 5A0E9
        static void Main(string[] args)
        {
            string[] hex = new string[] { "2A3E", "FA", "FFFF", "5A0E9" };
            int[] dec = new int[hex.Length];
            int[][] bin = new int[hex.Length][];

            //to dec
            for (int i = 0; i < hex.Length; i++)
            {
                dec[i] = hexToDec(hex[i]);
            }

            //to bin
            for (int i = 0; i < hex.Length; i++)
            {
                bin[i] = hexToBin(hex[i]);
            }

            //print
            for (int i = 0; i < hex.Length; i++)
            {
                Console.Write(hex[i] + " " + dec[i] + " ");
                int j = 0;
                while (bin[i][j] == 0) j++;
                for (; j < bin[i].Length; j++)
                {
                    Console.Write(bin[i][j]);
                }
                Console.WriteLine();
            }
        }

        private static int hexToDec(string hex)
        {
            int dec = 0;
            int cnt = hex.Length - 1;
            int stepen = 0;
            while (cnt >= 0)
            {
                int stepNumber = hex[cnt] - 48;
                if (stepNumber > 9) stepNumber -= 7;
                dec += stepNumber * (int)Math.Pow(16, stepen++);
                cnt--;
            }
            return dec;
        }

        private static int[] hexToBin(string hex)
        {
            int dec = 0;
            int cnt = hex.Length - 1;
            int[] theNum = new int[hex.Length * 4];
            int stepen = 0;
            while (cnt >= 0)
            {
                int stepNumber = hex[cnt] - 48;
                if (stepNumber > 9) stepNumber -= 7;
                dec = stepNumber;
                int step = 4 * stepen;
                for (int i = 0; i < 4; i++)
                {
                    theNum[step] = dec % 2;
                    dec /= 2;
                    step++;
                }
                cnt--;
                stepen++;
            }
            Array.Reverse(theNum);
            return theNum;
        }
    }
}


