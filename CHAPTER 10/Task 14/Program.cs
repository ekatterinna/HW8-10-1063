using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task9BFS
{
    class Program
    {
        private static char[,] lab;
        static Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        static Dictionary<Tuple<int, int>, Tuple<int, int>> parentTree = new Dictionary<Tuple<int, int>, Tuple<int, int>>();

        static void Main(string[] args)
        {
            ReadInput();
            int x;
            int y;
            char location = 's';
            FindLocation(location, out x, out y);
            q.Enqueue(new Tuple<int, int>(x, y));
            BreadthFirstSearch();
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

        private static void FindLocation(char location, out int x, out int y)
        {
            x = -1;
            y = -1;
            for (int row = 0; row < lab.GetLength(0); row++)
            {
                for (int col = 0; col < lab.GetLength(1); col++)
                {
                    if (lab[row, col] == location)
                    {
                        x = row;
                        y = col;
                        lab[row, col] = ' ';
                        return;
                    }
                }
            }
            if (x == -1 || y == -1)
            {
                throw new ArgumentException("No starting location 's' found.");
            }
        }

        static void BreadthFirstSearch()
        {
            Tuple<int, int> cell = q.Dequeue();

            if (lab[cell.Item1, cell.Item2] == 'e')
            {
                CalculatePathLength();
                return;
            }

            int qCount = q.Count;
            lab[cell.Item1, cell.Item2] = 's';

            if (InRange(cell.Item1, cell.Item2 + 1) && lab[cell.Item1, cell.Item2 + 1] != '*' && lab[cell.Item1, cell.Item2 + 1] != 's')
            {
                q.Enqueue(new Tuple<int, int>(cell.Item1, cell.Item2 + 1));
            }
            if (InRange(cell.Item1 + 1, cell.Item2) && lab[cell.Item1 + 1, cell.Item2] != '*' && lab[cell.Item1 + 1, cell.Item2] != 's')
            {
                q.Enqueue(new Tuple<int, int>(cell.Item1 + 1, cell.Item2));
            }
            if (InRange(cell.Item1 - 1, cell.Item2) && lab[cell.Item1 - 1, cell.Item2] != '*' && lab[cell.Item1 - 1, cell.Item2] != 's')
            {
                q.Enqueue(new Tuple<int, int>(cell.Item1 - 1, cell.Item2));
            }
            if (InRange(cell.Item1, cell.Item2 - 1) && lab[cell.Item1, cell.Item2 - 1] != '*' && lab[cell.Item1, cell.Item2 - 1] != 's')
            {
                q.Enqueue(new Tuple<int, int>(cell.Item1, cell.Item2 - 1));
            }

            if (q.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            foreach (var newCell in q)
            {
                if (!parentTree.ContainsKey(newCell))
                {
                    parentTree.Add(newCell, cell);
                }
            }

            BreadthFirstSearch();
        }

        static void CalculatePathLength()
        {
            int x;
            int y;
            char location = 'e';
            FindLocation(location, out x, out y);
            Tuple<int, int> cell = new Tuple<int, int>(x, y);
            int pathLength = 0;
            Tuple<int, int> parentCell = parentTree[cell];
            while (parentTree.ContainsKey(parentCell))
            {
                cell = parentCell;
                parentCell = parentTree[cell];
                pathLength++;
            }
            pathLength++;
            Console.WriteLine(pathLength);
        }

        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }
    }
}

