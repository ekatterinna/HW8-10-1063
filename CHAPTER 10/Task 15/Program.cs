using System;
using System.IO;

namespace Task11DisplayFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            TraverseDirs(new DirectoryInfo(path));
        }

        static void TraverseDirs(DirectoryInfo dir)
        {
            try
            {
                foreach (DirectoryInfo iInfo in dir.GetDirectories())
                {
                    Console.WriteLine("Found dir:  " + iInfo.FullName);
                    TraverseDirs(iInfo);
                }
            }
            catch (Exception)
            {
            }
            try
            {
                foreach (FileInfo iInfo in dir.GetFiles())
                {
                    Console.WriteLine("Found file: " + iInfo.FullName);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}


