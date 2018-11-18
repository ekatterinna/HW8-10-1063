using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.BigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int[] arrayNum1 = new int[num1.Length];
            int[] arrayNum2 = new int[num2.Length];

            ToArray(num1, arrayNum1);
            ToArray(num2, arrayNum2);

            int[] sum = new int[Math.Max(num1.Length, num2.Length) + 1];
            if (arrayNum1.Length > arrayNum2.Length)
            {
                Array.Copy(arrayNum2, sum, arrayNum2.Length);
                SumArrays(sum, arrayNum1);
            }
            else
            {
                Array.Copy(arrayNum1, sum, arrayNum1.Length);
                SumArrays(sum, arrayNum2);
            }

            Array.Reverse(sum);
            int i = 0;
            if (sum[i] == 0) i++;
            for (; i < sum.Length; i++)
            {
                Console.Write(sum[i]);
            }
        }

        private static void SumArrays(int[] sum, int[] array1)
        {
            int oneOnMind = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if ((sum[i] + array1[i] + oneOnMind) > 9)
                {
                    sum[i] = ((sum[i] + array1[i] + oneOnMind) % 10);
                    oneOnMind = 1;
                }
                else
                {
                    sum[i] = ((sum[i] + array1[i] + oneOnMind) % 10);
                    oneOnMind = 0;
                }
            }
            if (oneOnMind == 1) sum[sum.Length - 1] = 1;
        }

        private static void ToArray(string num1, int[] arrayNum1)
        {
            for (int i = 0, j = num1.Length - 1; j >= 0; i++, j--)
            {
                arrayNum1[i] = num1[j] - '0';
            }
        }
    }
}
