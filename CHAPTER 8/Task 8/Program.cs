using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.HexToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int[] bin = new int[4 * hex.Length];

            bin = hexToBin(hex);
            Array.Reverse(bin);

            //print
            foreach (var item in bin)
            {
                Console.Write(item);
            }
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
            return theNum;
        }
    }
}
