using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_numericalSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            int decNum = int.Parse(Console.ReadLine());
            string theBinNum = null;

            if (decNum >= 0) theBinNum = positiveBin(decNum);
            else
            {
                string tmpBinNum = positiveBin((int)(-decNum - 1));
                char[] binNegativ = new char[(((tmpBinNum.Length - 1) / 4) + 1) * 4];
                for (int i = 0; i < binNegativ.Length; i++)
                {
                    binNegativ[i] = '1';
                }
                for (int i = tmpBinNum.Length - 1, j = binNegativ.Length - 1; i >= 0; i--)
                {
                    if (tmpBinNum[i] == '1') binNegativ[j--] = '0';
                    else binNegativ[j--] = '1';
                }
                theBinNum = new string(binNegativ);
            }
            Console.WriteLine(theBinNum);
        }

        private static string positiveBin(int decNum)
        {
            StringBuilder binNum = new StringBuilder();
            do
            {
                if (decNum % 2 == 1)
                {
                    binNum.Append(1);
                }
                else
                {
                    binNum.Append(0);
                }
                decNum /= 2;
            }
            while (decNum > 0);

            return ReverseString(binNum.ToString());
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
