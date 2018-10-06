using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            ShowLargeFilesWithoutLinq(path);
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }

        }
    }
}
