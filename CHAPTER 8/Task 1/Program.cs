using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ConverSomeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 151, 35, 43, 251 };

            for (int i = 0; i < nums.Length; i++)
            {
                //write the number to convert
                Console.Write(nums[i] + " - ");
                Stack<int> binNum = new Stack<int>();

                //convert number and put 1and0 to stack
                while (nums[i] > 0)
                {
                    if (nums[i] % 2 == 1) binNum.Push(1);
                    else binNum.Push(0);
                    nums[i] /= 2;
                }
                //print the number backwards
                while (binNum.Count > 0)
                {
                    Console.Write(binNum.Pop());
                }
                Console.WriteLine();
            }
        }
    }
}
