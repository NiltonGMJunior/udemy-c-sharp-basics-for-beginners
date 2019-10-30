using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises04
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            string input;
            while (true)
            {
                Console.Write("Input a number to continue or type \"Quit\" to exit: ");
                input = Console.ReadLine();
                if (input == "Quit")
                {
                    break;
                }
                else
                {
                    try
                    {

                        numbers.Add(int.Parse(input));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            var uniqueNumbers = numbers.Distinct().ToList();
            foreach (var number in uniqueNumbers)
                Console.WriteLine(number);
        }
    }
}
