using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Use05
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

            int result = CheckAllNeighbors(array);
            if (result != -1) Console.WriteLine("Found at position - {0}", result);
            else Console.WriteLine("Not found");
        }

        static int CheckAllNeighbors(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (CheckNeighbors(array, i)) return i;
            }
            return -1;
        }

        static bool CheckNeighbors(int[] array, int position)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }
            else return false;
        }
    }
}
