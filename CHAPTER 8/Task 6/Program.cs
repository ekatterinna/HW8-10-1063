using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.DecToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int decNum = int.Parse(Console.ReadLine());
            char[] hex = new char[8];

            if (decNum >= 0)
            {
                hex = ToHex(decNum);
            }
            else
            {
                char[] tmpHex = new char[8];
                tmpHex = ToHex(-decNum - 1);
                hex = Minus(tmpHex);
            }

            //print
            int i = 0;
            while (hex[i] == 0) i++;
            for (int j = i; j < hex.Length; j++)
            {
                Console.Write(hex[j]);
            }
            Console.WriteLine();
        }

        private static char[] ToHex(int decNum)
        {
            char[] tmp = new char[8];
            short pos = 0;

            do
            {
                if (((decNum % 16) >= 0) && ((decNum % 16 <= 9)))
                {
                    tmp[pos] = (char)((decNum % 16) + 48);
                }
                else
                {
                    tmp[pos] = (char)((decNum % 16) + 48 + 7);
                }
                decNum = decNum / 16;
                pos++;
            }
            while (decNum > 0);
            Array.Reverse(tmp);
            return tmp;
        }

        private static char[] Minus(char[] positivHex)
        {
            Array.Reverse(positivHex);
            char[] lastHex = new char[8];

            for (int i = 0; i < 8; i++)
            {
                if (positivHex[i] == '0') lastHex[i] = 'F';
                else if (positivHex[i] == '1') lastHex[i] = 'E';
                else if (positivHex[i] == '2') lastHex[i] = 'D';
                else if (positivHex[i] == '3') lastHex[i] = 'C';
                else if (positivHex[i] == '4') lastHex[i] = 'B';
                else if (positivHex[i] == '5') lastHex[i] = 'A';
                else if (positivHex[i] == '6') lastHex[i] = '9';
                else if (positivHex[i] == '7') lastHex[i] = '8';
                else if (positivHex[i] == '8') lastHex[i] = '7';
                else if (positivHex[i] == '9') lastHex[i] = '6';
                else if (positivHex[i] == 'A') lastHex[i] = '5';
                else if (positivHex[i] == 'B') lastHex[i] = '4';
                else if (positivHex[i] == 'C') lastHex[i] = '3';
                else if (positivHex[i] == 'D') lastHex[i] = '2';
                else if (positivHex[i] == 'E') lastHex[i] = '1';
                else if (positivHex[i] == 'F') lastHex[i] = '0';
                else if (positivHex[i] == 0) lastHex[i] = 'F';
            }
            Array.Reverse(lastHex);
            return lastHex;
        }

    }
}


