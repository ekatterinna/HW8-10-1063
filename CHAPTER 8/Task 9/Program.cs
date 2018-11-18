using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string binNum1 = Console.ReadLine();
            char[] binNum = binNum1.ToCharArray();
            Array.Reverse(binNum);

            if (binNum1.Length < 4 && int.Parse(binNum1) == 0) Console.WriteLine(0);
            else
            {
                char[] hex = new char[(binNum.Length / 4) + 1];
                hex = ToHex(binNum);

                //print
                int i = 0;
                while (hex[i] == 0) i++;
                if (hex[i] == '0') i++;
                for (int j = i; j < hex.Length; j++)
                {
                    Console.Write(hex[j]);
                }
                Console.WriteLine();
            }
        }

        private static char[] ToHex(char[] binNum)
        {
            char[] tmpBig = new char[((binNum.Length / 4) + 1) * 4];
            short step = 0;
            int length = ((binNum.Length / 4) + 1);
            for (int i = 0; i < length; i++)
            {
                int little = 0;
                int num = 0;
                for (int j = i * 4; j < (i * 4) + 4; j++)
                {
                    if (j >= binNum.Length) break;
                    num += (int)(binNum[j] - 48) * (int)Math.Pow(10, little++);
                }
                if (num == 0) tmpBig[step++] = '0';
                else if (num == 1) tmpBig[step++] = '1';
                else if (num == 10) tmpBig[step++] = '2';
                else if (num == 11) tmpBig[step++] = '3';
                else if (num == 100) tmpBig[step++] = '4';
                else if (num == 101) tmpBig[step++] = '5';
                else if (num == 110) tmpBig[step++] = '6';
                else if (num == 111) tmpBig[step++] = '7';
                else if (num == 1000) tmpBig[step++] = '8';
                else if (num == 1001) tmpBig[step++] = '9';
                else if (num == 1010) tmpBig[step++] = 'A';
                else if (num == 1011) tmpBig[step++] = 'B';
                else if (num == 1100) tmpBig[step++] = 'C';
                else if (num == 1101) tmpBig[step++] = 'D';
                else if (num == 1110) tmpBig[step++] = 'E';
                else if (num == 1111) tmpBig[step++] = 'F';
            }
            Array.Reverse(tmpBig);
            return tmpBig;
        }
    }
}


