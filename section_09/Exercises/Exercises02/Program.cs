using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\Nilton\Documents\GitHub\udemy_c_sharp_basics_for_beginners\section_09\Exercises\Exercises02\TestFile.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File path is invalid.");
            } else
            {
                try
                {
                    var fileContent = File.ReadAllText(filePath);
                    var words = fileContent.Trim().Split(' ');
                    var maxLength = 0;
                    foreach (var word in words)
                    {
                        if (word.Trim().Length > maxLength)
                            maxLength = word.Trim().Length;
                    }
                    Console.WriteLine("Maximum length: " + maxLength);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid file type.");
                }
            }
        }
    }
}
