using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combinations
{
    class Program
    {

        static int[] combinationsArray;

        static void Main(string[] args)
        {
            int maxNumber = 0;
            maxNumber = int.Parse(Console.ReadLine());
            int maxPosition = 0;
            maxPosition = int.Parse(Console.ReadLine());
            combinationsArray = new int[maxPosition];
            SimulateNestedLoops(maxNumber, maxPosition);
        }

        static void SimulateNestedLoops(int maxNumber, int maxPosition, int startNumber = 1, int currentPosition = 1)
        {
            for (int i = startNumber; i <= maxNumber; i++)
            {
                combinationsArray[currentPosition - 1] = i;
                if (currentPosition != maxPosition)
                {
                    SimulateNestedLoops(maxNumber, maxPosition, startNumber, currentPosition + 1);
                    startNumber++;
                }
                else
                {
                    PrintArray(combinationsArray);
                }
            }
        }

        static void PrintArray(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write("{0} ", numbersArray[i]);
            }
            Console.WriteLine();
        }
    }
}
