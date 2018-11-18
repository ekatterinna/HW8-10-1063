using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(a, b), c));
        }

        private static int GetMax(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
    }
}


