using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\Nilton\Documents\GitHub\udemy_c_sharp_basics_for_beginners\section_09\Exercises\Exercises01\TestFile.txt";
            
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File path is invalid!");
            }
            else
            {
                try
                {
                    var fileContent = File.ReadAllText(filePath);
                    var words = fileContent.Trim().Split(' ');
                    Console.WriteLine("Number of words: " + words.Count());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid file type");
                }
            }
        }
    }
}
