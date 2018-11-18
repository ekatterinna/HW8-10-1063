using System;
using System.Collections.Generic;
using System.Linq;

namespace FindSubsetSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumToFind = int.Parse(Console.ReadLine());
            string inputArray = Console.ReadLine();
            char[] splitters = new char[] { ' ', ',' };
            string[] inputArraySplited = inputArray.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            int[] numbersArray = new int[inputArraySplited.Length];
            for (int i = 0; i < inputArraySplited.Length; i++)
            {
                numbersArray[i] = int.Parse(inputArraySplited[i]);
            }

            int subsetCombinations = (int)Math.Pow(2, numbersArray.Length);
            int currentSum = 0;
            bool isSubsetIsFound = false;
            List<int> elementsInCurrentSubSet = new List<int>();

            //position is zero-indexed
            for (int currentCombination = 0; currentCombination < subsetCombinations; currentCombination++)
            {
                currentSum = 0;
                for (int currentPosition = 0; currentPosition < numbersArray.Length; currentPosition++)
                {
                    currentSum += (numbersArray[currentPosition] * FindDigitOnPosition(currentCombination, currentPosition));
                    elementsInCurrentSubSet.Add(numbersArray[currentPosition] * FindDigitOnPosition(currentCombination, currentPosition));
                }
                if (currentSum == sumToFind)
                {
                    isSubsetIsFound = true;
                    //Print subset that has equal sum to searched sum
                    PrintSubset(sumToFind, elementsInCurrentSubSet);
                    break;
                }
                elementsInCurrentSubSet.Clear();
            }
            if (!isSubsetIsFound)
            {
                Console.WriteLine("No");
            }

        }

        private static void PrintSubset(int sumToFind, List<int> elementsInCurrentSubSet)
        {
            elementsInCurrentSubSet.RemoveAll(item => item == 0);
            for (int i = 0; i < elementsInCurrentSubSet.Count; i++)
            {
                Console.Write("{0} ", elementsInCurrentSubSet[i]);
            }
            Console.WriteLine();
        }

        static int FindDigitOnPosition(int number, int position)
        {
            int mask = 1;
            mask <<= position;
            mask &= number;
            if (mask != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

