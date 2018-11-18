using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountNumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to input - ");
            int arrayLenght = int.Parse(Console.ReadLine());
            if (arrayLenght < 1) throw new Exception("You must enter some numbers!");

            Console.WriteLine("Input the Numbers:");
            int[] array = new int[arrayLenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Number to search for - ");
            int numToSearch = int.Parse(Console.ReadLine());

            Console.WriteLine("Found {0} times", CheckNum(array, numToSearch));
        }

        static int CheckNum(int[] array, int num)
        {
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num) cnt++;
            }
            return cnt;
        }
    }
}
