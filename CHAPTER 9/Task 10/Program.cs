using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.n_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num < 100; num++)
            {
                int[] arrayNum = new int[1000];
                arrayNum[0] = 1;

                for (int i = 1; i <= num; i++)
                {
                    Multiply(arrayNum, i);
                }

                Array.Reverse(arrayNum);
                int j = 0;
                while (arrayNum[j] == 0) j++;
                for (; j < arrayNum.Length; j++)
                {
                    Console.Write(arrayNum[j]);
                }
                Console.WriteLine();
            }
        }

        private static void Multiply(int[] array, int a)
        {
            int oneOnMind = 0;
            int i = 0;
            for (; i < 1000; i++)
            {
                int temp = (array[i] * a + oneOnMind);
                if (temp > 9)
                {
                    array[i] = (temp % 10);
                    oneOnMind = temp / 10;
                }
                else
                {
                    array[i] = (temp % 10);
                    oneOnMind = 0;
                }
            }
            if (oneOnMind != 0) array[i] = oneOnMind;
        }

    }
}
