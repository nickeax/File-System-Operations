using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootPath = @"C:\Users\nicke\OneDrive\dev\eastern-press\exam-results\support\";

            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);

            foreach (var file in files)
            {
                var fi = new FileInfo(Path.Combine(rootPath, file));
                Console.WriteLine(fi.Length);
            }
        }
    }
}
