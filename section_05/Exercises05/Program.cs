using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a series of number separated by commas: ");
            var input = Console.ReadLine();
            try
            {
                var inputNumbers = input.Split(',');
                var max = int.Parse(inputNumbers[0]);
                foreach (var number in inputNumbers)
                    if (int.Parse(number) > max)
                        max = int.Parse(number);
                Console.WriteLine(max);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                throw;
            }
        }
    }
}
