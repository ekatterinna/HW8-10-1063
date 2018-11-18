using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestConnectedArea
{
    class Program
    {
        private static char[,] lab;
        private static int maxCount = 0;
        private static int currentCount = 0;

        static void Main(string[] args)
        {
            ReadInput();

            for (int row = 0; row < lab.GetLength(0); row++)
            {
                for (int col = 0; col < lab.GetLength(1); col++)
                {
                    if (lab[row, col] != '.')
                    {
                        continue;
                    }
                    else
                    {
                        currentCount = 0;
                        FindAllPaths(row, col);
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                        }
                    }
                }
            }
            Console.WriteLine("The largest connected area is: {0}", maxCount);
        }

        private static void ReadInput()
        {
            string line = Console.ReadLine();
            string[] rowsAndCols = line.Split(' ');
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);
            lab = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string rowStr = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    lab[row, col] = rowStr[col];
                }
            }
        }

        static void FindAllPaths(int row, int col)
        {
            if ((row < 0 || row >= lab.GetLength(0)) || (col < 0 || col >= lab.GetLength(1)))
            {
                return;
            }
            if (lab[row, col] == '.')
            {
                lab[row, col] = 'v';
                currentCount++;
                FindAllPaths(row, col + 1);
                FindAllPaths(row + 1, col);
                FindAllPaths(row, col - 1);
                FindAllPaths(row - 1, col);
            }
        }
    }
}


