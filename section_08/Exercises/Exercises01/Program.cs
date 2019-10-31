using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input numbers separated by hyphens: ");
            var input = Console.ReadLine();
            try
            {
                var numbers = input.Trim().Split('-').Select(int.Parse).ToList();
                var isConsecutiveDescending = true;
                var isConsecutiveAscending = true;
                bool isConsecutive;
                if (numbers.Count <= 1)
                {
                    isConsecutive = true;
                } else
                {
                    for (var i = 0; i < numbers.Count - 1; i++)
                    {
                        if (numbers[i] != numbers[i + 1] + 1)
                            isConsecutiveAscending = false;
                        if (numbers[i] != numbers[i + 1] - 1)
                            isConsecutiveDescending = false;
                    }
                    isConsecutive = isConsecutiveDescending || isConsecutiveAscending;
                }
                if (isConsecutive)
                    Console.WriteLine("Consecutive");
                else
                    Console.WriteLine("Not Consecutive");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
