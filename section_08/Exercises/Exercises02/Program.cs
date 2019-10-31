using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input numbers separated by hyphens: ");
            var input = Console.ReadLine();
            try
            {
                if (!String.IsNullOrWhiteSpace(input))
                {
                    var numbers = input.Trim().Split('-').Select(int.Parse).ToList();
                    if (numbers.Count != numbers.Distinct().Count())
                    {
                        Console.WriteLine("Duplicates");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
