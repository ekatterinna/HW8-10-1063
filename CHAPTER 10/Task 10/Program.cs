using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindAllPaths
{
    class Program
    {
        private static char[,] lab;
        private static List<Tuple<int, int>> path = new List<Tuple<int, int>>();

        static void Main(string[] args)
        {
            ReadInput();
            int x;
            int y;
            FindStartLocation(out x, out y);
            FindPathToExit(x, y);
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

        private static void FindStartLocation(out int x, out int y)
        {
            x = -1;
            y = -1;
            for (int row = 0; row < lab.GetLength(0); row++)
            {
                for (int col = 0; col < lab.GetLength(1); col++)
                {
                    if (lab[row, col] == 's')
                    {
                        x = row;
                        y = col;
                        lab[row, col] = '.';
                        return;
                    }
                }
            }
            if (x == -1 || y == -1)
            {
                throw new ArgumentException("No starting location 's' found.");
            }
        }

        static void FindPathToExit(int row, int col)
        {
            if (!InRange(row, col))
            {
                // We are out of the labyrinth -> can't find a path
                return;
            }

            // Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                int pathLength = path.Count + 1;
                Console.WriteLine(pathLength);
                PrintPath(row, col);
            }

            if (lab[row, col] != '.')
            {
                // The current cell is not free -> can't find a path
                return;
            }

            // Temporarily mark the current cell as visited
            lab[row, col] = 'v';
            path.Add(new Tuple<int, int>(row, col));

            // Invoke recursion the explore all possible directions
            FindPathToExit(row, col - 1); // left
            FindPathToExit(row - 1, col); // up
            FindPathToExit(row, col + 1); // right
            FindPathToExit(row + 1, col); // down

            // Mark back the current cell as free
            lab[row, col] = '.';
            path.RemoveAt(path.Count - 1);
        }

        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }

        static void PrintPath(int finalRow, int finalCol)
        {
            bool filledCell = false;
            for (int row = 0; row < lab.GetLength(0); row++)
            {
                for (int col = 0; col < lab.GetLength(1); col++)
                {
                    foreach (var cell in path)
                    {
                        if (row == cell.Item1 && col == cell.Item2)
                        {
                            Console.Write("r");
                            filledCell = true;
                        }
                    }
                    if (!filledCell)
                    {
                        if (lab[row, col] != '.')
                        {
                            Console.Write(lab[row, col]);
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    filledCell = false;
                }
                Console.WriteLine();
            }
        }
    }
}

