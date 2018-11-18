
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.Sum_Sub_Mul_Arrays
{
    class Program
    {
        static void PrintPolynom(int[] pol)
        {
            for (int i = pol.Length - 1; i > 0; i--)
            {
                if (pol[i] != 0)
                    Console.Write("{0}*x^{1} + ", pol[i], i);
            }
            Console.WriteLine(pol[0]);
        }

        static void MultPolynom(string first, string second)
        {
            int[] mult = new int[(first.Length) * (second.Length) + 1];
            int pow = 0;
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    pow = i + j;
                    mult[pow] += (first[i] - '0') * (second[j] - '0');
                }
            }

            PrintPolynom(mult);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two polynomials as a sequance of their coefficiens from the lowest power(x^0).");
            string firstPol = Console.ReadLine();
            string secondPol = Console.ReadLine();

            MultPolynom(firstPol, secondPol);
            Console.WriteLine();
        }
    }
}

