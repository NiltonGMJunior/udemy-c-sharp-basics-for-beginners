using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFundamentalsPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C: \Users\Nilton\Documents\GitHub\udemy_c_sharp_basics_for_beginners\section_09\CSharpFundamentalsPath\CSharpFundamentalsPath.sln";
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));
            Console.WriteLine("Full path: " + Path.GetFullPath(path));
        }
    }
}
