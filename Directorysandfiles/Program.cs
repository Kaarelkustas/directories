using System;
using System.IO;

namespace Directorysandfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";

            string[] allDirectories = Directory.GetDirectories(rootPath);
            ReadArray(allDirectories);


            string[] includeNestadDirectories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            ReadArray(includeNestadDirectories);

            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);
        }
        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }
    }
}
