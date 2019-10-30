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
            string input;
            List<int> numbers;

            while(true)
            {
                try
                {
                    Console.Write("Input a list of comma separated numbers: ");
                    input = Console.ReadLine();
                    numbers = input.Split(',').Select(int.Parse).ToList();
                    if (numbers.Count < 5)
                    {
                        Console.WriteLine("Invalid list. Please retry.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input! Please retry.");
                }
            }

            numbers.Sort();

            foreach (var number in numbers.GetRange(0, 3))
                Console.WriteLine(number);
        }
    }
}
