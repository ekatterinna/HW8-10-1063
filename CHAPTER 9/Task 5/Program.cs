using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.CheckTheNeiboursInArray
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

            Console.Write("Input the positon to check - ");
            int position = int.Parse(Console.ReadLine());
            if (position < 0 || position > arrayLenght) throw new Exception("Wrong position!");

            CheckNeighbors(array, position);
        }

        static void CheckNeighbors(int[] array, int position)
        {
            if (position == 0)
            {
                Console.WriteLine("this is first element");
                return;
            }
            if (position == array.Length - 1)
            {
                Console.WriteLine("this is last element");
                return;
            }
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                Console.WriteLine("bigger then neibours");
                return;
            }
            if (array[position] < array[position - 1] && array[position] < array[position + 1])
            {
                Console.WriteLine("smaller then neibors");
                return;
            }
            else Console.WriteLine("not bigger or smaller then neibours"); return;
        }
    }
}

