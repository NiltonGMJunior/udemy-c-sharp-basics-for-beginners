using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFundamentalsDirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryPath = @"C:\Users\Nilton\Documents\GitHub\udemy_c_sharp_basics_for_beginners\section_09\CSharpFundamentalsDirectoryDirectoryInfo\TestDirectory";
            Directory.CreateDirectory(directoryPath);
            Directory.GetFiles(directoryPath);
            var files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);
        }
    }
}
