using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.ConvertBinNumberToDecAndHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "1111010110011110";
            int numberInDec = 0;
            string numberInHex = null;

            numberInDec = ToDec(number);
            Console.WriteLine(numberInDec);

            numberInHex = ToHex(number).ToString();
            Console.WriteLine(numberInHex);
        }

        private static int ToDec(string number)
        {
            int stepen = 0;
            int numberInDec = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                numberInDec += ((int)number[i] - 48) * (int)Math.Pow(2, stepen++);
            }
            return numberInDec;
        }

        private static string ToHex(string number)
        {
            char[] hexNum = new char[4];
            short pos = 0;
            for (int i = 0; i < 4; i++)
            {
                int stepen = 3;
                int num = 0;
                for (int j = i * 4; j < (i * 4) + 4; j++)
                {
                    num += ((int)number[j] - 48) * (int)Math.Pow(10, stepen--);
                }
                if (num == 0) hexNum[pos++] = '0';
                else if (num == 1) hexNum[pos++] = '1';
                else if (num == 10) hexNum[pos++] = '2';
                else if (num == 11) hexNum[pos++] = '3';
                else if (num == 100) hexNum[pos++] = '4';
                else if (num == 101) hexNum[pos++] = '5';
                else if (num == 110) hexNum[pos++] = '6';
                else if (num == 111) hexNum[pos++] = '7';
                else if (num == 1000) hexNum[pos++] = '8';
                else if (num == 1001) hexNum[pos++] = '9';
                else if (num == 1010) hexNum[pos++] = 'A';
                else if (num == 1011) hexNum[pos++] = 'B';
                else if (num == 1100) hexNum[pos++] = 'C';
                else if (num == 1101) hexNum[pos++] = 'D';
                else if (num == 1110) hexNum[pos++] = 'E';
                else if (num == 1111) hexNum[pos++] = 'F';
            }
            return new string(hexNum);
        }
    }
}
