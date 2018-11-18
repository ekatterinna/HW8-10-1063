using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion_Task8
{
    class Program
    {
        private static int k;
        private static int arraySize;
        private static int[] used;
        private static int[] combo;
        private static List<int[]> combinations;
        private static int sum;
        private static int[] numbers;

        static void Main(string[] args)
        {
            ProcessInput();
            arraySize = numbers.Length;
            used = new int[arraySize];
            combinations = new List<int[]>();
            for (int i = 1; i <= numbers.Length; i++)
            {
                k = i;
                combo = new int[k];
                GenerateCombo(0);
            }

            List<int[]> finalList = new List<int[]>();
            finalList = RemoveDuplicates(combinations);

            foreach (int[] comb in finalList)
            {
                Print(comb);
            }
        }

        private static void ProcessInput()
        {
            arraySize = int.Parse(Console.ReadLine());
            numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            sum = int.Parse(Console.ReadLine());
        }

        static List<int[]> RemoveDuplicates(List<int[]> inputList)
        {
            List<int[]> finalList = new List<int[]>();
            foreach (int[] current in inputList)
            {
                if (!Contains(finalList, current))
                {
                    finalList.Add(current);
                }
            }
            return finalList;
        }

        static bool Contains(List<int[]> list, int[] comparedValue)
        {
            foreach (int[] listValue in list)
            {
                if (listValue.SequenceEqual(comparedValue))
                {
                    return true;
                }
            }
            return false;
        }

        static void GenerateCombo(int startIndex)
        {
            if (startIndex >= k)
            {
                if (combo.Sum() == sum)
                {
                    int[] tmpArr = new int[k];
                    Array.Copy(combo, tmpArr, k);
                    Array.Sort(tmpArr);
                    combinations.Add(tmpArr);
                }
                return;
            }

            for (int i = 0; i < arraySize; i++)
            {
                if (used[i] == 0)
                {
                    used[i] = 1;
                    combo[startIndex] = numbers[i];
                    GenerateCombo(startIndex + 1);
                    used[i] = 0;
                }
            }
        }

        static void Print(int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0}", arr[i]);
            }
            Console.WriteLine(" }");
        }
    }
}
