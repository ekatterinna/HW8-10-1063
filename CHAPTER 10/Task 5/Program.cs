using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion_Task5
{
    class Program
    {
        private static List<string> wordSequence = new List<string>() { "test", "rock", "fun" };
        private static StringBuilder output = new StringBuilder();
        private static List<string> allSubsequences = new List<string>();

        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            wordSequence = new List<string>();
            for (int i = 0; i < length; i++)
            {
                string word = Console.ReadLine();
                wordSequence.Add(word);
            }

            SolveWithRecursion(0, "");
            Console.WriteLine(output.ToString().TrimEnd(',', ' '));
        }

        private static void SolveWithRecursion(int index, string set)
        {
            if (allSubsequences.Count == 1 << wordSequence.Count)
            {
                return;
            }

            if (index == wordSequence.Count)
            {
                if (!allSubsequences.Contains(set))
                {
                    allSubsequences.Add(set);
                    string result = "(" + set.TrimEnd() + "), ";
                    output.Append(result);
                }
                set = "";
                return;
            }

            for (int i = 0; i < wordSequence.Count; i++)
            {
                SolveWithRecursion(index + 1, set);
                if (!set.Contains(wordSequence[index]))
                {
                    set += wordSequence[index] + " ";
                }
            }
        }
    }
}
