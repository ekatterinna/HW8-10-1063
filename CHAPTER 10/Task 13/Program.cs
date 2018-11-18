using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task10AllPassableAreas
{
    class Program
    {
        private static char[,] lab;
        private static List<Tuple<int, int>> path;

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
                        path = new List<Tuple<int, int>>();
                        FindAreas(row, col);
                        PrintArea(path);
                    }
                }
            }
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

        static void FindAreas(int row, int col)
        {
            if ((row < 0 || row >= lab.GetLength(0)) || (col < 0 || col >= lab.GetLength(1)))
            {
                return;
            }

            if (lab[row, col] == '.')
            {
                lab[row, col] = 'v';
                path.Add(new Tuple<int, int>(row, col));
                FindAreas(row, col + 1);
                FindAreas(row + 1, col);
                FindAreas(row, col - 1);
                FindAreas(row - 1, col);
            }
        }

        static void PrintArea(List<Tuple<int, int>> area)
        {
            Console.WriteLine(area.Count);
            foreach (var cell in area)
            {
                Console.Write("({0}, {1}) ", cell.Item1, cell.Item2);
            }
            Console.WriteLine();
        }
    }
}

