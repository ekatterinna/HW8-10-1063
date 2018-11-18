using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int listCount = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < listCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }

            List<int> sortedList = MergeSort(list);
            PrintList(sortedList);
        }

        static void PrintList(List<int> list)
        {
            Console.Write("{ ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write("{0}, ", list[i]);
            }
            Console.Write("{0} ", list[list.Count - 1]);
            Console.WriteLine("}");
        }

        static List<int> MergeSort(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> result = new List<int>();
            int middle = arr.Count / 2;
            for (int i = 0; i < arr.Count; i++)
            {
                if (i < middle)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }
            left = MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right);

            return result;
        }

        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            return result;
        }
    }
}
