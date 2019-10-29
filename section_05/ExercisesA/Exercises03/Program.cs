using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input the width of the image: ");
                var width = int.Parse(Console.ReadLine());

                Console.Write("Input the height of the image: ");
                var height = int.Parse(Console.ReadLine());

                Console.WriteLine(width >= height ? "Landscape" : "Portrait");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
            
        }
    }
}
