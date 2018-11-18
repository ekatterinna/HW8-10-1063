using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubsetOfStrings
{
    class Program
    {
        static string[] setOfStrings;

        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            setOfStrings = new string[length];
            for (int i = 0; i < length; i++)
            {
                setOfStrings[i] = Console.ReadLine();
            }
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];
            FindCombinations(array, 0, 0, length);
        }

        static void FindCombinations(int[] vector, int index, int start, int end)
        {
            if (index >= vector.Length)
            {
                Print(vector);
            }
            else
            {
                for (int i = start; i < end; i++)
                {
                    vector[index] = i;
                    FindCombinations(vector, index + 1, i + 1, end);
                }
            }
        }

        static void Print(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0}", setOfStrings[vector[i]]);
                if (i != vector.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
