using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFundamentalsFileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFilePath = @"C:\Users\Nilton\Documents\GitHub\udemy_c_sharp_basics_for_beginners\section_09\CSharpFundamentalsFileFileInfo\Files\SourceFile.txt";
            var destinationFilePath = @"C:\Users\Nilton\Documents\GitHub\udemy_c_sharp_basics_for_beginners\section_09\CSharpFundamentalsFileFileInfo\Files\DestinationFile.txt";
            var deletionPath = @"C:\Users\Nilton\Documents\GitHub\udemy_c_sharp_basics_for_beginners\section_09\CSharpFundamentalsFileFileInfo\Files\DeletionFile.txt";
            //File.Copy(sourceFilePath, destinationFilePath, true);
            //File.Delete(deletionPath);
            //if (File.Exists(sourceFilePath))
            //{
            //    //  Does something
            //}
            //var fileContent = File.ReadAllText(sourceFilePath);
            //Console.WriteLine(fileContent);

            var fileInfo = new FileInfo(sourceFilePath);
            fileInfo.CopyTo(destinationFilePath, true);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //  Does something
            }
        }
    }
}
